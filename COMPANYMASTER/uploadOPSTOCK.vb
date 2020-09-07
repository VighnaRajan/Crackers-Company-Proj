Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class uploadOPSTOCK
    Dim con As New OleDbConnection
    Dim empcmd, jobcmd, dupcmd, nucmd As New OleDbCommand
    Dim empda, jobda, dupda As New OleDbDataAdapter
    Dim empds, jobds, dupds As New DataSet
    Dim i, j, ec As Integer
    Dim ff As MsgBoxResult
    Dim m(2) As String
    Dim writer As StreamWriter
    Private Sub uploadOPSTOCK_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        writer.Close()
        writer.Dispose()
    End Sub
    Private Sub search_data()
        dupcmd.CommandText = "select * from itemstrans where itemcode='" & empds.Tables(0).Rows(items.SelectedIndex).Item("itemcode") & "' and typeoftrans='OPBAL' and concerncode=" & ccode
        dupds.Reset()
        dupds.Clear()
        dupda.SelectCommand = dupcmd
        dupda.Fill(dupds)
        If dupds.Tables(0).Rows.Count > 0 Then
            MsgBox("OPENING STOCK ALREADY ENTERED", MsgBoxStyle.Critical, "OPENING BALANCE CAN NOT BE EDITED")
            doj.Value = dupds.Tables(0).Rows(0).Item("tdate")
            measure1.Text = dupds.Tables(0).Rows(0).Item("measure1")
            m1.Text = empds.Tables(0).Rows(items.SelectedIndex).Item("measure")
            If empds.Tables(0).Rows(items.SelectedIndex).Item("measure1") <> "-" Then
                m2.Text = empds.Tables(0).Rows(items.SelectedIndex).Item("measure1")
                m2.Visible = True
                measure2.Text = dupds.Tables(0).Rows(0).Item("measure2")
                measure2.Visible = True
            Else
                m2.Visible = False
                measure2.Visible = False
            End If
            addnew.Enabled = False
            'GoTo skp
            'addnew.Text = "Make Correction"
            'End If
skp:
        Else
            measure1.Clear()
            m1.Text = empds.Tables(0).Rows(items.SelectedIndex).Item("measure")
            If empds.Tables(0).Rows(items.SelectedIndex).Item("measure1") <> "-" Then
                m2.Text = empds.Tables(0).Rows(items.SelectedIndex).Item("measure1")
                m2.Visible = True
                measure2.Clear()
                measure2.Visible = True
            Else
                m2.Visible = False
                measure2.Visible = False
            End If
            addnew.Text = "Enter Opening Balance"
            addnew.Enabled = True
            addnew.Focus()
        End If
    End Sub
    Private Sub uploadOPSTOCK_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = cs '"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & cs
        con.Open()
        dupcmd.Connection = con
        nucmd.Connection = con
        jobcmd.Connection = con
        empcmd.Connection = con
        box_readonly(1)
        empcmd.CommandText = "select * from items order by itemcode"
        empds.Reset()
        empds.Clear()
        empda.SelectCommand = empcmd
        empda.Fill(empds)
        items.Items.Clear()
        If empds.Tables(0).Rows.Count > 0 Then
            For i = 0 To empds.Tables(0).Rows.Count - 1
                items.Items.Add(empds.Tables(0).Rows(i).Item("itemname"))
            Next
        End If
        'writing to log file
        '===================
        logfile = String.Format(driv & "\COMPANY\LOGS\log_{0}.txt", DateTime.Today.ToString("dd-MMM-yyyy"))
        FileExists = File.Exists(logfile)
        writer = New StreamWriter(logfile, True)
        doj.Value = Today.Date
        doj.MaxDate = Today.Date
    End Sub
    Private Sub box_readonly(ByVal ic As Integer)
        'If ic = 1 Then start.Enabled = True Else start.Enabled = False
        measure1.ReadOnly = True
        measure2.ReadOnly = True
        'doj.Enabled = False
    End Sub
    Private Sub box_edit(ByVal ic As Integer)
        'If ic = 1 Then start.Enabled = True Else start.Enabled = False
        measure1.ReadOnly = False
        measure2.ReadOnly = False
        'doj.Enabled = True
    End Sub
    Private Sub ext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ext.Click
        Me.Close()
    End Sub
    Private Sub addnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addnew.Click
        If addnew.Text = "Make Correction" Then  'de-activated
            box_edit(1)
            addnew.Text = "Save Correction"
            measure1.Focus()
        ElseIf addnew.Text = "Enter Opening Balance" Then
            box_edit(1)
            addnew.Text = "Save"
            measure1.Focus()
        ElseIf addnew.Text = "Save" Then
            ff = MsgBox("Add Opening Balance?", MsgBoxStyle.OkCancel, "CONFIRMATION")
            If ff = MsgBoxResult.Ok Then
                nucmd.CommandText = "insert into itemstrans values(" & ccode & ",#" & doj.Value & "#,'" & empds.Tables(0).Rows(items.SelectedIndex).Item("itemcode") & "','OPBAL'," & Val(measure1.Text) & "," & Val(measure2.Text) & ",0,0," & Val(measure1.Text) & "," & Val(measure2.Text) & ")"
                writer.WriteLine("Adding OPENING BALANCE ...")
                writer.WriteLine("Query : " & nucmd.CommandText)
                nucmd.ExecuteNonQuery()
                'add the opening balance to stock also
                nucmd.CommandText = "insert into stock values(" & ccode & ",'" & empds.Tables(0).Rows(items.SelectedIndex).Item("itemcode") & "'," & Val(measure1.Text) & "," & Val(measure2.Text) & ")"
                writer.WriteLine("Adding OPENING BALANCE To STOCK...")
                writer.WriteLine("Query : " & nucmd.CommandText)
                nucmd.ExecuteNonQuery()

                MsgBox("OPENING BALANCE DETAILS ADDED & UPDATED INTO STOCK...", MsgBoxStyle.Information, "SUCCESS")
                addnew.Enabled = False
                box_readonly(1)
            Else
                MsgBox("OPENING BALANCE DETAIL UPLOAD - CANCELLED BY USER", MsgBoxStyle.Critical, "USER ABORT")
            End If
        ElseIf addnew.Text = "Save Correction" Then  'deactivated
            ff = MsgBox("Save Corrected Opening Balance Detail?", MsgBoxStyle.OkCancel, "CONFIRMATION")
            If ff = MsgBoxResult.Ok Then
                nucmd.CommandText = "update itemstrans set tdate=#" & doj.Value & "#,measure1=" & Val(measure1.Text) & ",measure2=" & Val(measure2.Text) & " where itemcode='" & empds.Tables(0).Rows(items.SelectedIndex).Item("itemcode") & "'"
                writer.WriteLine("Editing OPENING BALANCE details ...")
                writer.WriteLine("Query : " & nucmd.CommandText)
                nucmd.ExecuteNonQuery()
                MsgBox("OPENING BALANCE CORRECTION MADE", MsgBoxStyle.Information, "SUCCESS")
                addnew.Enabled = False
                box_readonly(1)
            Else
                MsgBox("CORRECTION IN OPENING BALANCE - CANCELLED BY USER", MsgBoxStyle.Critical, "USER ABORT")
            End If
        End If
out:
    End Sub
    Private Sub process()
        If items.SelectedIndex >= 0 Then
            search_data()
        End If
    End Sub
    Private Sub doj_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles doj.ValueChanged
        'If addnew.Text <> "Save Correction" And addnew.Text <> "Enter Opening Balance" Then  'if making correction, let them select job, else show from db
        'process()
        'End If
    End Sub
    Private Sub emps_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles items.SelectedIndexChanged
        process()
    End Sub
End Class