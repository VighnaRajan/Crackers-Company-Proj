Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class createJOB
    Dim con As New OleDbConnection
    Dim rawcmd, msrcmd, dupcmd, nucmd As New OleDbCommand
    Dim rawda, msrda, dupda As New OleDbDataAdapter
    Dim rawds, msrds, dupds As New DataSet
    Dim i, j As Integer
    Dim ff As MsgBoxResult
    Dim m(2) As String
    Dim writer As StreamWriter
    Private Sub createJOB_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        writer.Close()
        writer.Dispose()
    End Sub
    Private Sub createJOB_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = cs '"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & cs
        con.Open()
        rawcmd.CommandText = "select * from jobs where concerncode=" & ccode
        rawcmd.Connection = con
        rawds.Reset()
        rawds.Clear()
        rawda.SelectCommand = rawcmd
        rawda.Fill(rawds)
        show_jobs()
        dupcmd.Connection = con
        nucmd.Connection = con
        box_readonly(1)
        If rawds.Tables(0).Rows.Count > 0 Then jobs.SelectedIndex = 0

        'writing to log file
        '===================
        logfile = String.Format(driv & "\COMPANY\LOGS\log_{0}.txt", DateTime.Today.ToString("dd-MMM-yyyy"))
        FileExists = File.Exists(logfile)
        writer = New StreamWriter(logfile, True)

    End Sub
    Private Sub show_jobs()
        jobs.Items.Clear()
        If rawds.Tables(0).Rows.Count > 0 Then
            For i = 0 To rawds.Tables(0).Rows.Count - 1
                jobs.Items.Add(rawds.Tables(0).Rows(i).Item("job"))
            Next
        End If
    End Sub
    Private Sub box_readonly(ByVal ic As Integer)
        If ic = 1 Then jobname.ReadOnly = True Else jobname.ReadOnly = False
        hourlypay.ReadOnly = True
        cb.Enabled = False
    End Sub
    Private Sub box_edit(ByVal ic As Integer)
        If ic = 1 Then jobname.ReadOnly = False Else jobname.ReadOnly = True
        hourlypay.ReadOnly = False
        cb.Enabled = True
    End Sub
    Private Sub raws_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles jobs.SelectedIndexChanged
        rawds.Reset()
        rawds.Clear()
        rawda.Fill(rawds)
        If jobs.SelectedIndex >= 0 Then
            jobname.Text = rawds.Tables(0).Rows(jobs.SelectedIndex).Item("job")
            hourlypay.Text = rawds.Tables(0).Rows(jobs.SelectedIndex).Item("hourlypay")
            If rawds.Tables(0).Rows(jobs.SelectedIndex).Item("createproduct") = True Then
                cb.CheckState = CheckState.Checked
            Else
                cb.CheckState = CheckState.Unchecked
            End If
        End If
    End Sub
    Private Sub ext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ext.Click
        Me.Close()
    End Sub
    Private Sub addnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addnew.Click
        If addnew.Text = "&Add New Job" Then
            box_edit(1)
            addnew.Text = "Save"
            editt.Enabled = False
            jobname.Clear()
            hourlypay.Clear()
            cb.CheckState = CheckState.Unchecked
            jobname.Focus()
        Else
            ff = MsgBox("Create New Job?", MsgBoxStyle.OkCancel, "CONFIRMATION")
            If ff = MsgBoxResult.Ok Then
                dupcmd.CommandText = "select * from jobs where ucase(job)='" & UCase(jobname.Text) & "' and concerncode=" & ccode
                dupds.Reset()
                dupds.Clear()
                dupda.SelectCommand = dupcmd
                dupda.Fill(dupds)
                If dupds.Tables(0).Rows.Count > 0 Then
                    MsgBox("JOB ALREADY CREATED", MsgBoxStyle.Critical, "DUPLICATE JOB NAME")
                    jobname.Focus()
                Else
                    nucmd.CommandText = "insert into jobs values(" & ccode & ",'" & jobname.Text & "'," & hourlypay.Text & "," & cb.CheckState & ")"
                    writer.WriteLine("Adding New Job ...")
                    writer.WriteLine("Query : " & nucmd.CommandText)
                    nucmd.ExecuteNonQuery()
                    jobs.Items.Add(jobname.Text)
                    MsgBox("NEW JOB ADDED", MsgBoxStyle.Information, "SUCCESS")
                    addnew.Text = "&Add New Job"
                    editt.Enabled = True
                    box_readonly(1)
                End If
            Else
                MsgBox("NEW JOB CREATION - CANCELLED BY USER", MsgBoxStyle.Critical, "USER ABORT")
            End If
out:
        End If
    End Sub
    Private Sub editt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editt.Click
        If editt.Text = "&Change Salary" Then
            box_edit(0)
            editt.Text = "Save"
            addnew.Enabled = False
            hourlypay.Focus()
        Else
            ff = MsgBox("Update Job Details?", MsgBoxStyle.OkCancel, "CONFIRMATION")
            If ff = MsgBoxResult.Ok Then
                nucmd.CommandText = "update jobs set hourlypay=" & hourlypay.Text & ",createproduct=" & cb.CheckState & " where job='" & jobname.Text & "' and concerncode=" & ccode
                writer.WriteLine("Changing salary and other details of a job ...")
                writer.WriteLine("Query : " & nucmd.CommandText)
                nucmd.ExecuteNonQuery()
                MsgBox("JOB DETAILS UPDATED", MsgBoxStyle.Information, "SUCCESS")
                editt.Text = "&Change Salary"
                addnew.Enabled = True
                box_readonly(1)
            Else
                MsgBox("JOB DETAILS UPDATION CANCELLED BY USER", MsgBoxStyle.Critical, "USER ABORT")
            End If
outt:
        End If
    End Sub
End Class