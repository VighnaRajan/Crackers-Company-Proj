Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class createMEASURE
    Dim con As New OleDbConnection
    Dim rawcmd, msrcmd, dupcmd, nucmd As New OleDbCommand
    Dim rawda, msrda, dupda As New OleDbDataAdapter
    Dim rawds, msrds, dupds As New DataSet
    Dim i, j As Integer
    Dim ff As String
    Dim writer As StreamWriter
    Private Sub createMEASURE_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        writer.Close()
        writer.Dispose()
    End Sub
    Private Sub createMEASURE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = cs '"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & cs
        con.Open()
        'rawcmd.CommandText = "select * from items where ucase(itemtype)='ADD-ON'"
        'rawcmd.Connection = con
        'rawds.Reset()
        'rawds.Clear()
        'rawda.SelectCommand = rawcmd
        'rawda.Fill(rawds)
        'show_raw_materials()
        msrcmd.CommandText = "select * from measures"
        msrcmd.Connection = con
        msrds.Reset()
        msrds.Clear()
        msrda.SelectCommand = msrcmd
        msrda.Fill(msrds)
        show_measures()

        dupcmd.Connection = con
        nucmd.Connection = con

        If msrds.Tables(0).Rows.Count > 0 Then measure.SelectedIndex = 0

        'writing to log file
        '===================
        logfile = String.Format(driv & "\COMPANY\LOGS\log_{0}.txt", DateTime.Today.ToString("dd-MMM-yyyy"))
        FileExists = File.Exists(logfile)
        writer = New StreamWriter(logfile, True)

    End Sub
    Private Sub show_measures()
        measure.Items.Clear()
        If msrds.Tables(0).Rows.Count > 0 Then
            For i = 0 To msrds.Tables(0).Rows.Count - 1
                measure.Items.Add(msrds.Tables(0).Rows(i).Item("measure"))
            Next
        End If
    End Sub
  
    Private Sub ext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ext.Click
        Me.Close()
    End Sub
    Private Sub addnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addnew.Click
read_again:
        ff = InputBox("New Measurement : ", "ADD NEW MEASUREMENT")
        dupcmd.CommandText = "select * from measures where ucase(measure)='" & UCase(ff) & "'"
        dupds.Reset()
        dupds.Clear()
        dupda.SelectCommand = dupcmd
        dupda.Fill(dupds)
        If dupds.Tables(0).Rows.Count > 0 Then
            MsgBox("ITEM CODE ALREADY EXIST. PLEASE SPECIFY A NEW ONE.", MsgBoxStyle.Critical, "DUPLICATE ITEM CODE")
            GoTo read_again
        Else
            nucmd.CommandText = "insert into measures values('" & ff & "')"
            writer.WriteLine("Adding New Measurement ...")
            writer.WriteLine("Query : " & nucmd.CommandText)
            nucmd.ExecuteNonQuery()
            measure.Items.Add(ff)
            MsgBox("NEW MEASUREMENT ADDED", MsgBoxStyle.Information, "SUCCESS")
        End If
    End Sub
    Private Sub editt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editt.Click
        Dim oldmeasure As String
        oldmeasure = measure.Text
read_again:
        ff = InputBox("Corrected Measurement : ", "EDIT MEASUREMENT", oldmeasure)
        dupcmd.CommandText = "select * from measures where ucase(measure)='" & UCase(ff) & "'"
        dupds.Reset()
        dupds.Clear()
        dupda.SelectCommand = dupcmd
        dupda.Fill(dupds)
        If dupds.Tables(0).Rows.Count > 0 Then
            MsgBox("MEASUREMENT ALREADY EXIST. PLEASE SPECIFY A NEW ONE.", MsgBoxStyle.Critical, "DUPLICATE MEASUREMENT")
            GoTo read_again
        Else
            nucmd.CommandText = "update measures set measure='" & ff & "' where measure='" & oldmeasure & "'"
            writer.WriteLine("Editing Measurement ...")
            writer.WriteLine("Query : " & nucmd.CommandText)
            nucmd.ExecuteNonQuery()
            measure.Items(measure.SelectedIndex) = ff
            MsgBox("MEASUREMENT CORRECTED", MsgBoxStyle.Information, "SUCCESS")
        End If
    End Sub
End Class