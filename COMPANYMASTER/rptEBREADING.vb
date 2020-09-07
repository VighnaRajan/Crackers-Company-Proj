Imports System.Data
Imports System.Data.OleDb
Public Class rptEBREADING
    Dim con As New OleDbConnection
    Dim cmd, nucmd As New OleDbCommand
    Dim da As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim i As Integer
    Private Sub rptEBREADING_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fd.Value = Today.Date
        con.ConnectionString = cs
        con.Open()
        cmd.Connection = con
        nucmd.Connection = con
    End Sub
    Private Sub fd_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fd.ValueChanged
        td.MinDate = fd.Value.Date
        td.MaxDate = Today.Date
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        cmd.CommandText = "delete from rpteb"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "select * from ebreading where concerncode=" & ccode & " and rdate between #" & fd.Value.Date & "# and #" & td.Value.Date & "#"
        ds.Reset()
        ds.Clear()
        da.SelectCommand = cmd
        da.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            For i = 0 To ds.Tables(0).Rows.Count - 1
                nucmd.CommandText = "insert into rpteb values(#" & ds.Tables(0).Rows(i).Item("rdate") & "#," & ds.Tables(0).Rows(i).Item("startt") & "," & ds.Tables(0).Rows(i).Item("endd") & ",'" & concern & "',#" & fd.Value.Date & "#,#" & td.Value.Date & "#)"
                nucmd.ExecuteNonQuery()
            Next
        Else
            MsgBox("NO READING ENTRIES RECORDED WITHIN THE SPECIFIED PERIOD", MsgBoxStyle.Exclamation, "NO ENTRIES - BLANK REPORT")
        End If
        MsgBox("EB Reading Report Ready", MsgBoxStyle.Information, "SUCCESS")
        CrystalReportViewer1.RefreshReport()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class