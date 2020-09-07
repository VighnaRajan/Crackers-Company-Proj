Imports System.Data
Imports System.Data.OleDb
Public Class rptSALARYSHEET
    Dim con As New OleDbConnection
    Dim cmd, clearcmd, nucmd, ccmd As New OleDbCommand
    Dim da, cda As New OleDbDataAdapter
    Dim ds, cds As New DataSet
    Dim i As Integer
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        con.Close()
        Me.Close()
    End Sub
    Private Sub rptSALARYSHEET_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = cs
        con.Open()
        cmd.Connection = con
        ccmd.Connection = con
        clearcmd.Connection = con
        nucmd.Connection = con
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'cmd.CommandText = "select * from salary where concerncode=" & ccode & " and jdate between #" & fd.Value.Date & "# and #" & td.Value.Date & "#"
        cmd.CommandText = "select * from salary where jdate between #" & fd.Value.Date & "# and #" & td.Value.Date & "#"
        ds.Reset()
        ds.Clear()
        da.SelectCommand = cmd
        da.Fill(ds)

        clearcmd.CommandText = "delete from rptsalary"
        clearcmd.ExecuteNonQuery()

        If ds.Tables(0).Rows.Count > 0 Then
            For i = 0 To ds.Tables(0).Rows.Count - 1
                cds.Reset()
                cds.Clear()
                ccmd.CommandText = "select * from concern where concerncode=" & ds.Tables(0).Rows(i).Item("concerncode")
                cda.SelectCommand = ccmd
                cda.Fill(cds)

                nucmd.CommandText = "insert into rptsalary values('" & cds.Tables(0).Rows(0).Item("concernname") & "',#" & ds.Tables(0).Rows(i).Item("jdate") & "#,'" & ds.Tables(0).Rows(i).Item("ename") & "'," & ds.Tables(0).Rows(i).Item("hrs") & "," & ds.Tables(0).Rows(i).Item("mins") & ",'" & ds.Tables(0).Rows(i).Item("job") & "'," & ds.Tables(0).Rows(i).Item("salary") & "," & ds.Tables(0).Rows(i).Item("issued") & ",#" & ds.Tables(0).Rows(i).Item("issuedon") & "#,#" & fd.Value.Date & "#,#" & td.Value.Date & "#)"
                nucmd.ExecuteNonQuery()
            Next i
        End If
        MsgBox("REFRESH YOUR REPORT.", MsgBoxStyle.Information, "REPORT READY")
    End Sub
End Class