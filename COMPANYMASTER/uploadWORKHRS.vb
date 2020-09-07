Imports System.Data
Imports System.Data.OleDb
Imports System.IO

Public Class uploadWORKHRS
    Dim con As New OleDbConnection
    Dim empcmd, jobcmd, dupcmd, oldcmd, dup1cmd, nucmd, xcmd As New OleDbCommand
    Dim empda, jobda, dupda, oldda, dup1da, xda As New OleDbDataAdapter
    Dim empds, jobds, dupds, oldds, dup1ds, xds As New DataSet
    Dim i, j, ec, b, k As Integer
    Dim ff As MsgBoxResult
    Dim m(2), x, y As String
    Dim writer As StreamWriter
    Private Sub uploadWORKHRS_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        writer.Close()
        writer.Dispose()
    End Sub
    Private Sub uploadWORKHRS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = cs '"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & cs
        con.Open()
        dupcmd.Connection = con
        nucmd.Connection = con
        jobcmd.Connection = con
        empcmd.Connection = con
        oldcmd.Connection = con
        dup1cmd.Connection = con
        xcmd.Connection = con
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
        Job.Items.Clear()  'combo box inside data grid
        If jobds.Tables(0).Rows.Count > 0 Then
            For i = 0 To jobds.Tables(0).Rows.Count - 1
                Job.Items.Add(jobds.Tables(0).Rows(i).Item("job"))
            Next
        End If
        TimeIn.DefaultCellStyle.Format = "t"
        TimeOut.DefaultCellStyle.Format = "t"
        'writing to log file
        '===================
        logfile = String.Format(driv & "\COMPANY\LOGS\log_{0}.txt", DateTime.Today.ToString("dd-MMM-yyyy"))
        FileExists = File.Exists(logfile)
        writer = New StreamWriter(logfile, True)
        doj.Value = Today.Date
        doj.MaxDate = Today.Date
    End Sub
    Private Sub extract_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles extract.Click
        dgrid.Rows.Clear()
        If emps.CheckedItems.Count > 0 Then
            dgrid.Rows.Add(emps.CheckedItems.Count)
            j = 0
            For i = 0 To emps.Items.Count - 1
                If emps.GetItemCheckState(i) = CheckState.Checked Then
                    dgrid.Rows(j).Cells(0).Value = emps.Items(i)
                    j = j + 1
                End If
            Next
        End If
        If extract.Text = "Extract" Then 'new date entry, so no more extra work

        ElseIf extract.Text = "Extract Updated" Then 'reload remaining fields of datagrid from database
            For i = 0 To dgrid.Rows.Count - 2
                dup1cmd.CommandText = "select * from employees where ename='" & dgrid.Rows(i).Cells(0).Value & "'"
                dup1ds.Reset()
                dup1ds.Clear()
                dup1da.SelectCommand = dup1cmd
                dup1da.Fill(dup1ds)
                ec = dup1ds.Tables(0).Rows(0).Item("ecode")
                xcmd.CommandText = "select * from empworkhrs where ecode=" & ec & " and jdate=#" & doj.Value.Date & "# and concerncode=" & ccode
                xds.Reset()
                xds.Clear()
                xda.SelectCommand = xcmd
                xda.Fill(xds)
                If xds.Tables(0).Rows.Count > 0 Then
                    dgrid.Rows(i).Cells("Job").Value = xds.Tables(0).Rows(0).Item("job")
                    dgrid.Rows(i).Cells("TimeIn").Value = xds.Tables(0).Rows(0).Item("startt")
                    dgrid.Rows(i).Cells("TimeOut").Value = xds.Tables(0).Rows(0).Item("endd")
                End If
            Next
            xcmd.CommandText = "delete from empworkhrs where jdate=#" & doj.Value.Date & "# and concerncode=" & ccode
            xcmd.ExecuteNonQuery()
        End If
        extract.Enabled = False
        Button1.Enabled = True
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim en, jb As String
        Dim ec As Integer
        Dim tin, tout As Date
        For i = 0 To dgrid.Rows.Count - 2
            en = dgrid.Rows(i).Cells("EmployeeName").Value
            dupcmd.CommandText = "select * from employees where ename='" & en & "'"
            dupds.Reset()
            dupds.Clear()
            dupda.SelectCommand = dupcmd
            dupda.Fill(dupds)
            ec = dupds.Tables(0).Rows(0).Item("ecode")
            jb = dgrid.Rows(i).Cells("Job").Value
            tin = dgrid.Rows(i).Cells("TimeIn").Value
            tout = dgrid.Rows(i).Cells("TimeOut").Value

            dupcmd.CommandText = "select * from empworkhrs where concerncode=" & ccode & " and ecode=" & ec & " and jdate=#" & doj.Value.Date & "#"
            dupds.Reset()
            dupds.Clear()
            dupda.SelectCommand = dupcmd
            dupda.Fill(dupds)
            If dupds.Tables(0).Rows.Count = 0 Then
                nucmd.CommandText = "insert into empworkhrs values(" & ccode & "," & ec & ",#" & doj.Value.Date & "#,'" & jb & "',#" & tin & "#,#" & tout & "#)"
                writer.WriteLine("Adding Working Hours ...")
                writer.WriteLine("Query : " & nucmd.CommandText)
                nucmd.ExecuteNonQuery()
                MsgBox("WORKING HOURS DETAILS ADDED", MsgBoxStyle.Information, "SUCCESS")
            Else
                nucmd.CommandText = "update empworkhrs set startt=#" & tin & "#,endd=#" & tout & "# where concerncode=" & ccode & " and ecode=" & ec & " and jdate=#" & doj.Value.Date & "#"
                writer.WriteLine("Updating Working Hours ...")
                writer.WriteLine("Query : " & nucmd.CommandText)
                nucmd.ExecuteNonQuery()
                MsgBox("WORKING HOURS DETAILS UPDATED", MsgBoxStyle.Information, "SUCCESS")
            End If
        Next
        extract.Enabled = False
        Button1.Enabled = False
    End Sub
    Private Sub doj_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles doj.ValueChanged
        process()
        extract.Enabled = True
    End Sub
    Private Sub process()
        Dim enm As String
        Dim ii, jj As Integer
        oldcmd.CommandText = "select * from empworkhrs where jdate=#" & doj.Value.Date & "# and concerncode=" & ccode & " order by ecode"
        oldds.Reset()
        oldds.Clear()
        oldda.SelectCommand = oldcmd
        oldda.Fill(oldds)

        dgrid.Rows.Clear()
        For i = 0 To emps.Items.Count - 1
            emps.SetItemCheckState(i, CheckState.Unchecked)
        Next
        If oldds.Tables(0).Rows.Count > 0 Then 'if already working hours noted for this company on this date
            For i = 0 To oldds.Tables(0).Rows.Count - 1
                dupcmd.CommandText = "select * from employees where ecode=" & oldds.Tables(0).Rows(i).Item("ecode")
                dupds.Reset()
                dupds.Clear()
                dupda.SelectCommand = dupcmd
                dupda.Fill(dupds)
                enm = dupds.Tables(0).Rows(0).Item("ename")
                For j = 0 To emps.Items.Count - 1
                    If enm = emps.Items(j) Then
                        emps.SetItemCheckState(j, CheckState.Checked)
                    End If
                Next
            Next
            If emps.CheckedItems.Count > 0 Then
                dgrid.Rows.Add(emps.CheckedItems.Count)
                jj = 0
                For ii = 0 To emps.Items.Count - 1
                    If emps.GetItemCheckState(ii) = CheckState.Checked Then
                        dgrid.Rows(jj).Cells(0).Value = emps.Items(ii)
                        dgrid.Rows(jj).Cells(1).Value = oldds.Tables(0).Rows(jj).Item("job") ' emps.Items(ii)
                        dgrid.Rows(jj).Cells(2).Value = oldds.Tables(0).Rows(jj).Item("startt") ' emps.Items(ii)
                        dgrid.Rows(jj).Cells(3).Value = oldds.Tables(0).Rows(jj).Item("endd") 'emps.Items(ii)
                        jj = jj + 1
                    End If
                Next
            End If
            extract.Text = "Extract Updated"
        Else
            extract.Text = "Extract"
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class