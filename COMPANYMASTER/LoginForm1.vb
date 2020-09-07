Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class LoginForm1
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim da As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim writer As StreamWriter
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        cmd.Connection = con
        cmd.CommandText = "select * from users where uname='" & uname.Text & "' and pword='" & pword.Text & "'"
        ds.Reset()
        ds.Clear()
        da.SelectCommand = cmd
        da.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            currentuser = ds.Tables(0).Rows(0).Item("uname")
            '============================================================================
            writer.WriteLine("------------------------------------------------------")
            writer.WriteLine("logged in as " & currentuser & " on : " & DateTime.Now)
            writer.Close()
            writer.Dispose()
            '============================================================================
            CONCERNSELCTION.Show()
        Else
            MsgBox("INVALID AUTHENTICATION", MsgBoxStyle.Critical, "PLEASE PROVIDE CORRECT CREDENTIALS...")
            uname.Clear()
            pword.Clear()
            uname.Focus()
        End If
    End Sub
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub
    Private Sub LoginForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        driv = "D:"
        cs = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & driv & "\vighna.k.v.r\COMPANY\COMPANY.MDB"
        concern = "MY CONCERN"
        con.ConnectionString = cs '"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & cs
        con.Open()
        uname.Text = "admin"
        pword.Text = "Admin123"

        'writing to log file
        '===================
        logfile = String.Format(driv & "\COMPANY\LOGS\log_{0}.txt", DateTime.Today.ToString("dd-MMM-yyyy"))
        FileExists = File.Exists(logfile)
        writer = New StreamWriter(logfile, True)
        If Not FileExists Then
            writer.WriteLine("created at : " & DateTime.Now)
        End If

    End Sub
End Class
