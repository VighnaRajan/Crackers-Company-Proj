Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class newSUPPLIER
    Dim con As New OleDbConnection
    Dim rawcmd, msrcmd, dupcmd, nucmd As New OleDbCommand
    Dim rawda, msrda, dupda As New OleDbDataAdapter
    Dim rawds, msrds, dupds As New DataSet
    Dim i, j, ec As Integer
    Dim ff As MsgBoxResult
    Dim m(2), drcr As String
    Dim writer As StreamWriter
    Private Sub newSUPPLIER_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        writer.Close()
        writer.Dispose()
    End Sub
    Private Sub newSUPPLIER_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = cs '"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & cs
        con.Open()
        rawcmd.CommandText = "select * from parties where partytype='SUPPLIER' and concerncode=" & ccode & " order by code"
        rawcmd.Connection = con
        rawds.Reset()
        rawds.Clear()
        rawda.SelectCommand = rawcmd
        rawda.Fill(rawds)
        show_emps()
        dupcmd.Connection = con
        nucmd.Connection = con
        box_readonly(1)
        If rawds.Tables(0).Rows.Count > 0 Then emps.SelectedIndex = 0
        'writing to log file
        '===================
        logfile = String.Format(driv & "\COMPANY\LOGS\log_{0}.txt", DateTime.Today.ToString("dd-MMM-yyyy"))
        FileExists = File.Exists(logfile)
        writer = New StreamWriter(logfile, True)
        msrcmd.Connection = con
    End Sub
    Private Sub show_emps()
        emps.Items.Clear()
        If rawds.Tables(0).Rows.Count > 0 Then
            For i = 0 To rawds.Tables(0).Rows.Count - 1
                emps.Items.Add(rawds.Tables(0).Rows(i).Item("nam"))
            Next
        End If
    End Sub
    Private Sub box_readonly(ByVal ic As Integer)
        If ic = 1 Then ename.ReadOnly = True Else ename.ReadOnly = False
        address.ReadOnly = True
        phone.ReadOnly = True
        opbal.ReadOnly = True
        opbalason.Enabled = False
        cr.Enabled = False
        dr.Enabled = False
    End Sub
    Private Sub box_edit(ByVal ic As Integer)
        If ic = 1 Then ename.ReadOnly = False Else ename.ReadOnly = True
        address.ReadOnly = False
        phone.ReadOnly = False
        opbal.ReadOnly = False
        opbalason.Enabled = True
        cr.Enabled = True
        dr.Enabled = True
    End Sub
    Private Sub raws_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles emps.SelectedIndexChanged
        rawds.Reset()
        rawds.Clear()
        rawda.Fill(rawds)
        If emps.SelectedIndex >= 0 Then
            ec = rawds.Tables(0).Rows(emps.SelectedIndex).Item("code")
            ename.Text = rawds.Tables(0).Rows(emps.SelectedIndex).Item("nam")
            address.Text = rawds.Tables(0).Rows(emps.SelectedIndex).Item("address")
            phone.Text = rawds.Tables(0).Rows(emps.SelectedIndex).Item("phone")
            opbalason.Text = rawds.Tables(0).Rows(emps.SelectedIndex).Item("opbalason")
            opbal.Text = rawds.Tables(0).Rows(emps.SelectedIndex).Item("opbal")
            If UCase(rawds.Tables(0).Rows(emps.SelectedIndex).Item("drcr")) = "DR" Then
                dr.Checked = True
            ElseIf UCase(rawds.Tables(0).Rows(emps.SelectedIndex).Item("drcr")) = "CR" Then
                cr.Checked = True
            End If
        End If
    End Sub
    Private Sub ext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ext.Click
        Me.Close()
    End Sub
    Private Sub addnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addnew.Click
        If addnew.Text = "&Add New Supplier" Then
            box_edit(1)
            addnew.Text = "Save"
            editt.Enabled = False
            ename.Clear()
            address.Clear()
            phone.Clear()
            opbalason.Value = Today.Date
            opbal.Clear()
            ename.Focus()
        Else
            ff = MsgBox("Add New Supplier?", MsgBoxStyle.OkCancel, "CONFIRMATION")
            If ff = MsgBoxResult.Ok Then
                dupcmd.CommandText = "select * from parties where ucase(nam)='" & UCase(ename.Text) & "' and ucase(partytype)='SUPPLIER' and concerncode=" & ccode
                dupds.Reset()
                dupds.Clear()
                dupda.SelectCommand = dupcmd
                dupda.Fill(dupds)
                If dupds.Tables(0).Rows.Count > 0 Then
                    MsgBox("SUPPLIER NAME ALREADY ADDED", MsgBoxStyle.Critical, "DUPLICATE SUPPLIER NAME")
                    ename.Focus()
                Else
                    msrcmd.CommandText = "select max(code) from parties where ucase(partytype)='SUPPLIER' and concerncode=" & ccode
                    msrds.Reset()
                    msrds.Clear()
                    msrda.SelectCommand = msrcmd
                    msrda.Fill(msrds)
                    If dr.Checked = True Then drcr = "DR"
                    If cr.Checked = True Then drcr = "CR"
                    If IsDBNull(msrds.Tables(0).Rows(0).Item(0)) Then ec = 1 Else ec = msrds.Tables(0).Rows(0).Item(0) + 1
                    nucmd.CommandText = "insert into parties values(" & ccode & "," & ec & ",'" & ename.Text & "','" & address.Text & "','" & phone.Text & "','SUPPLIER'," & Val(opbal.Text) & ",#" & opbalason.Value.Date & "#,'" & drcr & "')"
                    writer.WriteLine("Adding New Supplier ...")
                    writer.WriteLine("Query : " & nucmd.CommandText)
                    nucmd.ExecuteNonQuery()
                    emps.Items.Add(ename.Text)
                    MsgBox("NEW SUPPLIER ADDED", MsgBoxStyle.Information, "SUCCESS")
                    addnew.Text = "&Add New Supplier"
                    editt.Enabled = True
                    box_readonly(1)
                    emps.SelectedIndex = emps.Items.Count - 1
                End If
            Else
                MsgBox("NEW SUPPLIER ADDITION - CANCELLED BY USER", MsgBoxStyle.Critical, "USER ABORT")
            End If
out:
        End If
    End Sub
    Private Sub editt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editt.Click
        If editt.Text = "&Change Details" Then
            box_edit(0)
            editt.Text = "Save"
            addnew.Enabled = False
            address.Focus()
        Else
            ff = MsgBox("Update Details?", MsgBoxStyle.OkCancel, "CONFIRMATION")
            If ff = MsgBoxResult.Ok Then
                nucmd.CommandText = "update parties set address='" & address.Text & "', phone='" & phone.Text & "',opbal=" & Val(opbal.Text) & ",opbalason=#" & opbalason.Value.Date & "# where partytype='SUPPLIER' and code=" & ec & " and concerncode=" & ccode
                writer.WriteLine("Changing details of a supplier ...")
                writer.WriteLine("Query : " & nucmd.CommandText)
                nucmd.ExecuteNonQuery()
                MsgBox("DETAILS UPDATED", MsgBoxStyle.Information, "SUCCESS")
                editt.Text = "&Change Details"
                addnew.Enabled = True
                box_readonly(1)
            Else
                MsgBox("SUPPLIER DETAILS UPDATION CANCELLED BY USER", MsgBoxStyle.Critical, "USER ABORT")
            End If
outt:
        End If
    End Sub
End Class