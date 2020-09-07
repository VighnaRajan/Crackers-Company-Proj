Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class createUSER
    Dim con As New OleDbConnection
    Dim rawcmd, msrcmd, dupcmd, nucmd As New OleDbCommand
    Dim rawda, msrda, dupda As New OleDbDataAdapter
    Dim rawds, msrds, dupds As New DataSet
    Dim i, j As Integer
    Dim ff As MsgBoxResult
    Dim m(2) As String
    Dim writer As StreamWriter
    Private Sub createUSER_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        writer.Close()
        writer.Dispose()
    End Sub
    Private Sub createUSER_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = cs '"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & cs
        con.Open()

        rawcmd.CommandText = "select * from users"
        rawcmd.Connection = con
        rawds.Reset()
        rawds.Clear()
        rawda.SelectCommand = rawcmd
        rawda.Fill(rawds)
        show_users()
        dupcmd.Connection = con
        nucmd.Connection = con
        box_readonly(1)
        If rawds.Tables(0).Rows.Count > 0 Then users.SelectedIndex = 0

        'writing to log file
        '===================
        logfile = String.Format(driv & "\COMPANY\LOGS\log_{0}.txt", DateTime.Today.ToString("dd-MMM-yyyy"))
        FileExists = File.Exists(logfile)
        writer = New StreamWriter(logfile, True)

    End Sub
    Private Sub show_users()
        users.Items.Clear()
        If rawds.Tables(0).Rows.Count > 0 Then
            For i = 0 To rawds.Tables(0).Rows.Count - 1
                users.Items.Add(rawds.Tables(0).Rows(i).Item("uname"))
            Next
        End If
    End Sub
    Private Sub box_readonly(ByVal ic As Integer)
        If ic = 1 Then username.ReadOnly = True Else username.ReadOnly = False
        password.ReadOnly = True
        password1.ReadOnly = True
    End Sub
    Private Sub box_edit(ByVal ic As Integer)
        If ic = 1 Then username.ReadOnly = False Else username.ReadOnly = True
        password.ReadOnly = False
        password1.ReadOnly = False
    End Sub
    Private Sub raws_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles users.SelectedIndexChanged
        rawds.Reset()
        rawds.Clear()
        rawda.Fill(rawds)
        If users.SelectedIndex >= 0 Then
            username.Text = rawds.Tables(0).Rows(users.SelectedIndex).Item("uname")
            password.Clear()
            password1.Clear()
        End If
    End Sub
    Private Sub ext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ext.Click
        Me.Close()
    End Sub
    Private Sub addnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addnew.Click
        If addnew.Text = "&Add New User" Then
            box_edit(1)
            addnew.Text = "Save"
            editt.Enabled = False
            username.Clear()
            password.Clear()
            password1.Clear()
            username.Focus()
        Else
            If password.Text <> password1.Text Then
                MsgBox("PASSWORDS DO NOT MATCH", MsgBoxStyle.Critical, "PASSWORD ERROR")
                password.Clear()
                password1.Clear()
                password.Focus()
                GoTo out
            End If
            ff = MsgBox("Create New user?", MsgBoxStyle.OkCancel, "CONFIRMATION")
            If ff = MsgBoxResult.Ok Then
                dupcmd.CommandText = "select * from users where ucase(uname)='" & UCase(username.Text) & "'"
                dupds.Reset()
                dupds.Clear()
                dupda.SelectCommand = dupcmd
                dupda.Fill(dupds)
                If dupds.Tables(0).Rows.Count > 0 Then
                    MsgBox("USER NAME ALREADY EXIST", MsgBoxStyle.Critical, "DUPLICATE USER NAME")
                    username.Focus()
                Else
                    nucmd.CommandText = "insert into users values('" & username.Text & "','" & password.Text & "')"
                    writer.WriteLine("Adding New User ...")
                    writer.WriteLine("Query : " & nucmd.CommandText)
                    nucmd.ExecuteNonQuery()
                    users.Items.Add(username.Text)
                    MsgBox("NEW USER ADDED", MsgBoxStyle.Information, "SUCCESS")
                    addnew.Text = "&Add New User"
                    editt.Enabled = True
                    box_readonly(1)
                End If
            Else
                MsgBox("NEW USER CREATION - CANCELLED BY USER", MsgBoxStyle.Critical, "USER ABORT")
            End If
out:
        End If
    End Sub
    Private Sub editt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editt.Click
        If editt.Text = "&Change Password" Then
            box_edit(0)
            editt.Text = "Save"
            addnew.Enabled = False
            password.Focus()
        Else
            If password.Text <> password1.Text Then
                MsgBox("PASSWORDS DO NOT MATCH", MsgBoxStyle.Critical, "PASSWORD ERROR")
                password.Clear()
                password1.Clear()
                password.Focus()
                GoTo outt
            End If
            ff = MsgBox("Update User Password?", MsgBoxStyle.OkCancel, "CONFIRMATION")
            If ff = MsgBoxResult.Ok Then
                nucmd.CommandText = "update users set pword='" & password.Text & "' where uname='" & username.Text & "'"
                writer.WriteLine("Changing Password of a User ...")
                writer.WriteLine("Query : " & nucmd.CommandText)
                nucmd.ExecuteNonQuery()
                MsgBox("USER PASSWORD UPDATED", MsgBoxStyle.Information, "SUCCESS")
                editt.Text = "&Change Password"
                addnew.Enabled = True
                box_readonly(1)
            Else
                MsgBox("EDIT OPERATION CANCELLED BY USER", MsgBoxStyle.Critical, "USER ABORT")
            End If
outt:
        End If
    End Sub
End Class