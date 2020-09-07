Imports System.Data
Imports System.Data.OleDb
Public Class CONCERNSELCTION
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim da As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim i As Integer
    Private Sub CONCERNSELCTION_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = cs '"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & cs
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "select * from concern order by concerncode"
        ds.Reset()
        ds.Clear()
        da.SelectCommand = cmd
        da.Fill(ds)
        concerns.Items.Clear()
        If ds.Tables(0).Rows.Count > 0 Then
            For i = 0 To ds.Tables(0).Rows.Count - 1
                concerns.Items.Add(ds.Tables(0).Rows(i).Item("concernname"))
            Next
        End If
    End Sub
    Private Sub concerns_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles concerns.SelectedIndexChanged
        ccode = ds.Tables(0).Rows(concerns.SelectedIndex).Item("concerncode")
    End Sub
    Private Sub proceed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles proceed.Click
        If concerns.SelectedIndex >= 0 Then
            concern = concerns.Text
            MDIParent1.Show()
        Else
            MsgBox("Please Select A Concern", MsgBoxStyle.Exclamation, "NO CONCERN SELECTED")
            concerns.Focus()
        End If
    End Sub
End Class