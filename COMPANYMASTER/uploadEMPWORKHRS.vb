Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class uploadEMPWORKHRS
    Dim con As New OleDbConnection
    Dim empcmd, jobcmd, dupcmd, nucmd As New OleDbCommand
    Dim empda, jobda, dupda As New OleDbDataAdapter
    Dim empds, jobds, dupds As New DataSet
    Dim i, j, ec, b As Integer
    Dim ff As MsgBoxResult
    Dim m(2), x, y As String
    Dim writer As StreamWriter
    Private Sub uploadEMPWORKHRS_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        writer.Close()
        writer.Dispose()
    End Sub
    Private Sub search_data()
        dupcmd.CommandText = "select * from empworkhrs where ecode=" & empds.Tables(0).Rows(emps.SelectedIndex).Item("ecode") & " and jdate=#" & doj.Value.Date & "# and concerncode=" & ccode
        dupds.Reset()
        dupds.Clear()
        dupda.SelectCommand = dupcmd
        dupda.Fill(dupds)
        timing.Items.Clear()
        If dupds.Tables(0).Rows.Count > 0 Then
            For i = 0 To dupds.Tables(0).Rows.Count - 1
                b = Strings.InStr(dupds.Tables(0).Rows(i).Item("startt"), " ", CompareMethod.Text)
                x = Strings.Mid(dupds.Tables(0).Rows(i).Item("startt"), b + 1)
                'x = dupds.Tables(0).Rows(i).Item("startt")
                b = Strings.InStr(dupds.Tables(0).Rows(i).Item("endd"), " ", CompareMethod.Text)
                y = Strings.Mid(dupds.Tables(0).Rows(i).Item("endd"), b + 1)
                'y = dupds.Tables(0).Rows(i).Item("endd")
                timing.Items.Add(x & " - " & y)
            Next
            start.Value = dupds.Tables(0).Rows(0).Item("startt")
            endd.Value = dupds.Tables(0).Rows(0).Item("endd")
            If addnew.Text <> "Save Correction" Then  'if making correction, let them select job, else show from db
                For j = 0 To jobs.Items.Count - 1
                    If jobs.Items(j) = dupds.Tables(0).Rows(0).Item("job") Then
                        jobs.SelectedIndex = j
                        GoTo aftr
                    End If
                Next
aftr:
                addnew.Text = "Make Correction"
            End If
        Else
            addnew.Text = "Mark Reading"
        End If
        addnew.Enabled = True
        addnew.Focus()
    End Sub
    Private Sub uploadEMPWORKHRS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = cs '"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & cs
        con.Open()
        dupcmd.Connection = con
        nucmd.Connection = con
        jobcmd.Connection = con
        empcmd.Connection = con
        box_readonly(1)
        empcmd.CommandText = "select * from employees order by ecode"
        empds.Reset()
        empds.Clear()
        empda.SelectCommand = empcmd
        empda.Fill(empds)
        emps.Items.Clear()
        If empds.Tables(0).Rows.Count > 0 Then
            For i = 0 To empds.Tables(0).Rows.Count - 1
                emps.Items.Add(empds.Tables(0).Rows(i).Item("ename"))
            Next
        End If
        jobcmd.CommandText = "select * from jobs where concerncode=" & ccode
        jobds.Reset()
        jobds.Clear()
        jobda.SelectCommand = jobcmd
        jobda.Fill(jobds)
        jobs.Items.Clear()
        If jobds.Tables(0).Rows.Count > 0 Then
            For i = 0 To jobds.Tables(0).Rows.Count - 1
                jobs.Items.Add(jobds.Tables(0).Rows(i).Item("job"))
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
        If ic = 1 Then start.Enabled = True Else start.Enabled = False
        start.Enabled = False
        endd.Enabled = False
    End Sub
    Private Sub box_edit(ByVal ic As Integer)
        If ic = 1 Then start.Enabled = True Else start.Enabled = False
        start.Enabled = True
        endd.Enabled = True
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
            ff = MsgBox("Add Working Hours?", MsgBoxStyle.OkCancel, "CONFIRMATION")
            If ff = MsgBoxResult.Ok Then
                nucmd.CommandText = "insert into empworkhrs values(" & ccode & "," & empds.Tables(0).Rows(emps.SelectedIndex).Item("ecode") & ",#" & doj.Value.Date & "#,'" & jobs.Text & "',#" & start.Value & "#,#" & endd.Value & "#)"
                writer.WriteLine("Adding Working Hours ...")
                writer.WriteLine("Query : " & nucmd.CommandText)
                nucmd.ExecuteNonQuery()
                MsgBox("WORKING HOURS DETAILS ADDED", MsgBoxStyle.Information, "SUCCESS")
                addnew.Enabled = False
                box_readonly(1)
            Else
                MsgBox("WORKING HOURS DETAIL UPLOAD - CANCELLED BY USER", MsgBoxStyle.Critical, "USER ABORT")
            End If
        ElseIf addnew.Text = "Save Correction" Then
            ff = MsgBox("Save Corrected Workin Hours Detail?", MsgBoxStyle.OkCancel, "CONFIRMATION")
            If ff = MsgBoxResult.Ok Then
                nucmd.CommandText = "update empworkhrs set job='" & jobs.Text & "',startt=#" & start.Value & "#, endd=#" & endd.Value & "# where jdate=#" & doj.Value.Date & "# and ecode=" & empds.Tables(0).Rows(emps.SelectedIndex).Item("ecode") & " and concerncode=" & ccode
                writer.WriteLine("Editing working hours details ...")
                writer.WriteLine("Query : " & nucmd.CommandText)
                nucmd.ExecuteNonQuery()
                MsgBox("WORKING HOURS CORRECTION MADE", MsgBoxStyle.Information, "SUCCESS")
                addnew.Enabled = False
                box_readonly(1)
            Else
                MsgBox("CORRECTION IN WORKING HOURS - CANCELLED BY USER", MsgBoxStyle.Critical, "USER ABORT")
            End If
        End If
out:
    End Sub
    Private Sub process()
        If emps.SelectedIndex >= 0 And jobs.SelectedIndex >= 0 Then
            search_data()
        End If
    End Sub
    Private Sub doj_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles doj.ValueChanged
        process()
    End Sub
    Private Sub emps_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles emps.SelectedIndexChanged
        process()
    End Sub
    Private Sub jobs_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles jobs.SelectedIndexChanged
        process()
    End Sub
    Private Sub start_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles start.ValueChanged
        endd.MinDate = start.Value
    End Sub
End Class