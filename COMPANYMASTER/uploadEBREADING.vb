Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class uploadEBREADING
    Dim con As New OleDbConnection
    Dim rawcmd, msrcmd, dupcmd, nucmd As New OleDbCommand
    Dim rawda, msrda, dupda As New OleDbDataAdapter
    Dim rawds, msrds, dupds As New DataSet
    Dim i, j, ec As Integer
    Dim ff As MsgBoxResult
    Dim m(2) As String
    Dim writer As StreamWriter
    Private Sub uploadEBREADING_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        writer.Close()
        writer.Dispose()
    End Sub
    Private Sub uploadEBREADING_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = cs '"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & cs
        con.Open()
        dupcmd.Connection = con
        nucmd.Connection = con
        msrcmd.Connection = con
        box_readonly(1)
        doj.MaxDate = Today.Date
        'writing to log file
        '===================
        logfile = String.Format(driv & "\COMPANY\LOGS\log_{0}.txt", DateTime.Today.ToString("dd-MMM-yyyy"))
        FileExists = File.Exists(logfile)
        writer = New StreamWriter(logfile, True)
    End Sub
    Private Sub box_readonly(ByVal ic As Integer)
        If ic = 1 Then start.ReadOnly = True Else start.ReadOnly = False
        start.ReadOnly = True
        endd.ReadOnly = True
    End Sub
    Private Sub box_edit(ByVal ic As Integer)
        If ic = 1 Then start.ReadOnly = False Else start.ReadOnly = True
        start.ReadOnly = False
        endd.ReadOnly = False
    End Sub
    Private Sub ext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ext.Click
        Me.Close()
    End Sub
    Private Sub addnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addnew.Click
        If addnew.Text = "Make Correction" Then
            box_edit(1)
            addnew.Text = "Save Correction"
            start.Focus()
        ElseIf addnew.Text = "Mark Reading" Then
            box_edit(1)
            addnew.Text = "Save Reading"
            start.Focus()
        ElseIf addnew.Text = "Save Reading" Then
            If Val(endd.Text) < Val(start.Text) Then
                MsgBox("STARTING READING CAN NOT BE GREATER THAN ENDING VALUE", MsgBoxStyle.Critical, "ERROR IN READING")
                start.Focus()
                GoTo out
            End If
            ff = MsgBox("Add New EB Reading?", MsgBoxStyle.OkCancel, "CONFIRMATION")
            If ff = MsgBoxResult.Ok Then
                nucmd.CommandText = "insert into ebreading values(" & ccode & ",#" & doj.Value.Date & "#," & Val(start.Text) & "," & Val(endd.Text) & ")"
                writer.WriteLine("Adding New EB Reading ...")
                writer.WriteLine("Query : " & nucmd.CommandText)
                nucmd.ExecuteNonQuery()
                MsgBox("NEW EB READING ADDED", MsgBoxStyle.Information, "SUCCESS")
                addnew.Enabled = False
                box_readonly(1)
            Else
                MsgBox("NEW EB READING ADDITION - CANCELLED BY USER", MsgBoxStyle.Critical, "USER ABORT")
            End If
        ElseIf addnew.Text = "Save Correction" Then
            If Val(endd.Text) < Val(start.Text) Then
                MsgBox("STARTING READING CAN NOT BE GREATER THAN ENDING VALUE", MsgBoxStyle.Critical, "ERROR IN READING")
                start.Focus()
                GoTo out
            End If
            ff = MsgBox("Save Corrected EB Reading?", MsgBoxStyle.OkCancel, "CONFIRMATION")
            If ff = MsgBoxResult.Ok Then
                nucmd.CommandText = "update ebreading set startt=" & Val(start.Text) & ", endd=" & Val(endd.Text) & " where rdate=#" & doj.Value.Date & "# and concerncode=" & ccode
                writer.WriteLine("Editing Exisintg EB Reading ...")
                writer.WriteLine("Query : " & nucmd.CommandText)
                nucmd.ExecuteNonQuery()
                MsgBox("EB READING CORRECTION MADE", MsgBoxStyle.Information, "SUCCESS")
                addnew.Enabled = False
                box_readonly(1)
            Else
                MsgBox("CORRECTION IN EB READING - CANCELLED BY USER", MsgBoxStyle.Critical, "USER ABORT")
            End If
        End If
out:
    End Sub
    Private Sub doj_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles doj.ValueChanged
        dupcmd.CommandText = "select * from ebreading where rdate=#" & doj.Value.Date & "# and concerncode=" & ccode
        dupds.Reset()
        dupds.Clear()
        dupcmd.Connection = con
        dupda.SelectCommand = dupcmd
        dupda.Fill(dupds)
        If dupds.Tables(0).Rows.Count > 0 Then
            addnew.Text = "Make Correction"
            start.Text = dupds.Tables(0).Rows(0).Item("startt")
            endd.Text = dupds.Tables(0).Rows(0).Item("endd")
        Else
            addnew.Text = "Mark Reading"
            start.Clear()
            endd.Clear()
        End If
        addnew.Enabled = True
        addnew.Focus()
    End Sub
End Class