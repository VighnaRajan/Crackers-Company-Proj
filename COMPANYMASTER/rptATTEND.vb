Imports System.Data
Imports System.Data.OleDb
Public Class rptATTEND
    Dim con As New OleDbConnection
    Dim cmd, nucmd, ecmd As New OleDbCommand
    Dim da, eda As New OleDbDataAdapter
    Dim ds, eds As New DataSet
    Dim i As Integer
    Private Sub rptATTEND_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fd.Value = Today.Date
        con.ConnectionString = cs
        con.Open()
        cmd.Connection = con
        nucmd.Connection = con
        ecmd.Connection = con
    End Sub
    Private Sub fd_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fd.ValueChanged
        td.MinDate = fd.Value.Date
        td.MaxDate = Today.Date
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        cmd.CommandText = "delete from rptattendance"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "select * from empworkhrs where concerncode=" & ccode & " and jdate between #" & fd.Value.Date & "# and #" & td.Value.Date & "# order by jdate,ecode"
        ds.Reset()
        ds.Clear()
        da.SelectCommand = cmd
        da.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            For i = 0 To ds.Tables(0).Rows.Count - 1
                ecmd.CommandText = "select * from employees where ecode=" & ds.Tables(0).Rows(i).Item("ecode")
                eds.Reset()
                eds.Clear()
                eda.SelectCommand = ecmd
                eda.Fill(eds)

                nucmd.CommandText = "insert into rptattendance values(#" & ds.Tables(0).Rows(i).Item("jdate") & "#," & eds.Tables(0).Rows(0).Item("ecode") & ",'" & eds.Tables(0).Rows(0).Item("ename") & "',#" & ds.Tables(0).Rows(i).Item("startt") & "#,#" & ds.Tables(0).Rows(i).Item("endd") & "#,0,0,#" & fd.Value.Date & "#,#" & td.Value.Date & "#,'" & concern & "','" & ds.Tables(0).Rows(i).Item("job") & "')"
                nucmd.ExecuteNonQuery()
            Next
        Else
            MsgBox("NO WORKING HOUR ENTRIES RECORDED WITHIN THE SPECIFIED PERIOD", MsgBoxStyle.Exclamation, "NO ENTRIES - BLANK REPORT")
        End If
        MsgBox("Attendance Report Ready", MsgBoxStyle.Information, "SUCCESS")
        rv.RefreshReport()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class