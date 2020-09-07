Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class createRAWMATERIAL
    Dim con As New OleDbConnection
    Dim rawcmd, msrcmd, dupcmd, nucmd As New OleDbCommand
    Dim rawda, msrda, dupda As New OleDbDataAdapter
    Dim rawds, msrds, dupds As New DataSet
    Dim i, j As Integer
    Dim ff As MsgBoxResult
    Dim m(2) As String
    Dim writer As StreamWriter
    Private Sub createRAWMATERIAL_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        writer.Close()
        writer.Dispose()
    End Sub
    Private Sub createRAWMATERIAL_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = cs '"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & cs
        con.Open()
        rawcmd.CommandText = "select * from items where ucase(itemtype)='RAW-MATERIAL' and concerncode=" & ccode
        rawcmd.Connection = con
        rawds.Reset()
        rawds.Clear()
        rawda.SelectCommand = rawcmd
        rawda.Fill(rawds)
        show_raw_materials()
        msrcmd.CommandText = "select * from measures"
        msrcmd.Connection = con
        msrds.Reset()
        msrds.Clear()
        msrda.SelectCommand = msrcmd
        msrda.Fill(msrds)
        show_measures()
        dupcmd.Connection = con
        nucmd.Connection = con
        box_readonly(1)
        If rawds.Tables(0).Rows.Count > 0 Then raws.SelectedIndex = 0
        'writing to log file
        '===================
        logfile = String.Format(driv & "\COMPANY\LOGS\log_{0}.txt", DateTime.Today.ToString("dd-MMM-yyyy"))
        FileExists = File.Exists(logfile)
        writer = New StreamWriter(logfile, True)
    End Sub
    Private Sub show_raw_materials()
        raws.Items.Clear()
        If rawds.Tables(0).Rows.Count > 0 Then
            For i = 0 To rawds.Tables(0).Rows.Count - 1
                raws.Items.Add(rawds.Tables(0).Rows(i).Item("itemname"))
            Next
        End If
    End Sub
    Private Sub show_measures()
        measure.Items.Clear()
        If msrds.Tables(0).Rows.Count > 0 Then
            For i = 0 To msrds.Tables(0).Rows.Count - 1
                measure.Items.Add(msrds.Tables(0).Rows(i).Item("measure"))
            Next
        End If
    End Sub
    Private Sub box_readonly(ByVal ic As Integer)
        If ic = 1 Then itemcode.ReadOnly = True Else itemcode.ReadOnly = False
        itemname.ReadOnly = True
        measure.Enabled = False
    End Sub
    Private Sub box_edit(ByVal ic As Integer)
        If ic = 1 Then itemcode.ReadOnly = False Else itemcode.ReadOnly = True
        itemname.ReadOnly = False
        measure.Enabled = True
    End Sub
    Private Sub raws_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles raws.SelectedIndexChanged
        rawds.Reset()
        rawds.Clear()
        rawda.Fill(rawds)
        If raws.SelectedIndex >= 0 Then
            itemcode.Text = rawds.Tables(0).Rows(raws.SelectedIndex).Item("itemcode")
            itemname.Text = rawds.Tables(0).Rows(raws.SelectedIndex).Item("itemname")
            m(1) = rawds.Tables(0).Rows(raws.SelectedIndex).Item("measure")
            m(2) = rawds.Tables(0).Rows(raws.SelectedIndex).Item("measure1")
            i = 1
            For j = 0 To measure.Items.Count - 1
                If i > 2 Then GoTo nextj
                If measure.Items(j) = m(i) Then
                    measure.SetItemChecked(j, True)
                    i = i + 1
                Else
                    measure.SetItemChecked(j, False)
                End If
nextj:
            Next
            measure.Text = rawds.Tables(0).Rows(raws.SelectedIndex).Item("measure")
        End If
    End Sub
    Private Sub ext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ext.Click
        Me.Close()
    End Sub
    Private Sub addnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addnew.Click
        If addnew.Text = "&Add New" Then
            box_edit(1)
            addnew.Text = "Save"
            editt.Enabled = False
            itemcode.Clear()
            itemname.Clear()
            itemcode.Focus()
        Else
            If measure.CheckedItems.Count > 2 Then
                MsgBox("YOU CAN SELECT  A MAXIMUM OF 2 MEASUREMENTS", MsgBoxStyle.Critical, "MEASUREMENTS ONLY 2")
                measure.Focus()
                GoTo out
            End If
            m(1) = "-"
            m(2) = "-"
            For j = 1 To measure.CheckedItems.Count
                m(j) = measure.CheckedItems(j - 1)
            Next
            ff = MsgBox("Save New Item?", MsgBoxStyle.OkCancel, "CONFIRMATION")
            If ff = MsgBoxResult.Ok Then
                dupcmd.CommandText = "select * from items where ucase(itemcode)='" & UCase(itemcode.Text) & "' and concerncode=" & ccode & " and itemtype='RAW-MATERIAL'"
                dupds.Reset()
                dupds.Clear()
                dupda.SelectCommand = dupcmd
                dupda.Fill(dupds)
                If dupds.Tables(0).Rows.Count > 0 Then
                    MsgBox("ITEM CODE ALREADY EXIST", MsgBoxStyle.Critical, "DUPLICATE ITEM CODE")
                    itemcode.Focus()
                Else
                    nucmd.CommandText = "insert into items values(" & ccode & ",'" & itemcode.Text & "','" & itemname.Text & "','RAW-MATERIAL','" & m(1) & "','" & m(2) & "')"
                    writer.WriteLine("Adding New Raw Material ...")
                    writer.WriteLine("Query : " & nucmd.CommandText)
                    nucmd.ExecuteNonQuery()
                    raws.Items.Add(itemname.Text)
                    MsgBox("NEW ITEM ADDED", MsgBoxStyle.Information, "SUCCESS")
                    addnew.Text = "&Add New"
                    editt.Enabled = True
                    box_readonly(1)
                End If
            Else
                MsgBox("ADD NEW OPERATION CANCELLED BY USER", MsgBoxStyle.Critical, "USER ABORT")
            End If
out:
        End If
    End Sub
    Private Sub editt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editt.Click
        If editt.Text = "&Edit" Then
            box_edit(0)
            editt.Text = "Save"
            addnew.Enabled = False
            itemname.Focus()
        Else
            If measure.SelectedItems.Count > 2 Then
                MsgBox("YOU CAN SELECT  A MAXIMUM OF 2 MEASUREMENTS", MsgBoxStyle.Critical, "MEASUREMENTS ONLY 2")
                measure.Focus()
                GoTo outt
            End If
            m(1) = "-"
            m(2) = "-"
            For j = 1 To measure.CheckedItems.Count
                m(j) = measure.CheckedItems(j - 1)
            Next
            ff = MsgBox("Save Corrections in Item?", MsgBoxStyle.OkCancel, "CONFIRMATION")
            If ff = MsgBoxResult.Ok Then
                nucmd.CommandText = "update items set itemname='" & itemname.Text & "',measure='" & m(1) & "',measure1='" & m(2) & "' where itemcode='" & itemcode.Text & "' and concerncode=" & ccode & " and itemtype='RAW-MATERIAL'"
                writer.WriteLine("Query : " & nucmd.CommandText)
                nucmd.ExecuteNonQuery()
                raws.Items(raws.SelectedIndex) = itemname.Text
                MsgBox("ITEM ENTRY CORRECTED", MsgBoxStyle.Information, "SUCCESS")
                editt.Text = "&Edit"
                addnew.Enabled = True
                box_readonly(0)
            Else
                MsgBox("EDIT OPERATION CANCELLED BY USER", MsgBoxStyle.Critical, "USER ABORT")
            End If
outt:
        End If
    End Sub
End Class