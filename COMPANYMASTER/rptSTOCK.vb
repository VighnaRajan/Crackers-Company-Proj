Imports System.Data
Imports System.Data.OleDb
Public Class rptSTOCK
    Dim con As New OleDbConnection
    Dim cmd, nucmd, ecmd As New OleDbCommand
    Dim da, eda As New OleDbDataAdapter
    Dim ds, eds As New DataSet
    Dim i As Integer
    Private Sub rptSTOCK_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = cs
        con.Open()
        cmd.Connection = con
        nucmd.Connection = con
        ecmd.Connection = con

        cmd.CommandText = "delete from rptstk"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "select * from stock where concerncode=" & ccode & " order by itemcode"
        ds.Reset()
        ds.Clear()
        da.SelectCommand = cmd
        da.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            For i = 0 To ds.Tables(0).Rows.Count - 1
                ecmd.CommandText = "select * from items where itemcode='" & ds.Tables(0).Rows(i).Item("itemcode") & "'"
                eds.Reset()
                eds.Clear()
                eda.SelectCommand = ecmd
                eda.Fill(eds)

                nucmd.CommandText = "insert into rptstk values('" & concern & "','" & ds.Tables(0).Rows(i).Item("itemcode") & "','" & eds.Tables(0).Rows(0).Item("itemname") & "'," & ds.Tables(0).Rows(i).Item("stockm1") & ",'" & eds.Tables(0).Rows(0).Item("measure") & "'," & ds.Tables(0).Rows(i).Item("stockm2") & ",'" & eds.Tables(0).Rows(0).Item("measure1") & "','" & eds.Tables(0).Rows(0).Item("itemtype") & "')"
                nucmd.ExecuteNonQuery()
            Next
        Else
            MsgBox("NO STOCK ENTRIES RECORDED FOR THE CONCERN : " & concern, MsgBoxStyle.Exclamation, "NO ENTRIES - BLANK REPORT")
        End If
        'MsgBox("Stock Report Ready", MsgBoxStyle.Information, "SUCCESS")
        rv.RefreshReport()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class