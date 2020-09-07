Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class uploadCONSUMPTIONDAILY
    Dim con As New OleDbConnection
    Dim empcmd, stkcmd, dcmd, ucmd As New OleDbCommand
    Dim empda, stkda, dda As New OleDbDataAdapter
    Dim empds, stkds, dds As New DataSet
    Dim i, j, ec, b, k As Integer
    Dim ff As MsgBoxResult
    Dim m(2), x, y As String
    Dim writer As StreamWriter
    Dim op, tk, cl As Decimal
    Private Sub uploadCONSUMPTIONDAILY_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        writer.Close()
        writer.Dispose()
    End Sub
    Private Sub uploadCONSUMPTIONDAILY_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = cs '"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & cs
        con.Open()
        stkcmd.Connection = con
        empcmd.Connection = con
        ucmd.Connection = con
        dcmd.Connection = con
        empcmd.CommandText = "select * from items where (itemtype='ADD-ON' or itemtype='RAW-MATERIAL') and concerncode=" & ccode & " order by itemcode"
        empds.Reset()
        empds.Clear()
        empda.SelectCommand = empcmd
        empda.Fill(empds)
        items.Items.Clear()
        If empds.Tables(0).Rows.Count > 0 Then
            For i = 0 To empds.Tables(0).Rows.Count - 1
                items.Items.Add(empds.Tables(0).Rows(i).Item("itemname"))
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
    Private Sub doj_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles doj.ValueChanged
        If doj.Value.Date <> Today.Date Then
            MsgBox("You can't make consumption entry other than TODAY", MsgBoxStyle.Critical, "ERROR IN DATE")
            doj.Value = Today.Date
            GoTo do_no
        End If
        items.Focus()
do_no:
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub items_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles items.SelectedIndexChanged
        stkcmd.CommandText = "select * from stock where itemcode='" & empds.Tables(0).Rows(items.SelectedIndex).Item("itemcode") & "' and concerncode=" & ccode
        stkds.Reset()
        stkds.Clear()
        stkda.SelectCommand = stkcmd
        stkda.Fill(stkds)
        If stkds.Tables(0).Rows.Count > 0 Then
            s1.Text = stkds.Tables(0).Rows(0).Item("stockm1")
            s2.Text = stkds.Tables(0).Rows(0).Item("stockm2")
        Else
            s1.Text = 0
            s2.Text = 0
        End If
        c1.Text = 0
        c2.Text = 0
        m1.Text = empds.Tables(0).Rows(items.SelectedIndex).Item("measure") : m3.Text = m1.Text : m5.Text = m1.Text
        m2.Text = empds.Tables(0).Rows(items.SelectedIndex).Item("measure1") : m4.Text = m2.Text : m6.Text = m2.Text
        s3.Text = s1.Text
        s4.Text = s2.Text
        dcmd.CommandText = "select * from itemstrans where concerncode=" & ccode & " and tdate=#" & doj.Value.Date & "# and itemcode='" & empds.Tables(0).Rows(items.SelectedIndex).Item("itemcode") & "' and typeoftrans='CONSUMPTION'"
        dds.Reset()
        dds.Clear()
        dda.SelectCommand = dcmd
        dda.Fill(dds)
        If dds.Tables(0).Rows.Count > 0 Then
            c1.Enabled = False
            c2.Enabled = False
            c1.Text = dds.Tables(0).Rows(0).Item("measure1")
            c2.Text = dds.Tables(0).Rows(0).Item("measure2")
            status.Text = "Already Consumed Today"
        Else
            c1.Enabled = True
            c2.Enabled = True
            status.Text = "___"
        End If
        If stkds.Tables(0).Rows.Count = 0 Then
            c1.Enabled = False
            c2.Enabled = False
            status.Text = "NO STOCK"
        End If
    End Sub
    Private Sub c1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1.LostFocus
        If Val(c1.Text) > Val(s1.Text) Then
            MsgBox("NOT ENOUGH STOCK", MsgBoxStyle.Critical, "PLEASE MENTION A LOWER VALUE THAN CURRENT STOCK")
            c1.Focus()
            Button1.Enabled = False
        End If
    End Sub
    Private Sub c2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles c2.LostFocus
        If Val(s1.Text & "." & s2.Text) - Val(c1.Text & "." & c2.Text) < 0 Then
            MsgBox("NOT ENOUGH STOCK", MsgBoxStyle.Critical, "PLEASE MENTION A LOWER VALUE THAN CURRENT STOCK")
            c1.Focus()
            Button1.Enabled = False
        Else
            op = Val(s1.Text & "." & s2.Text)
            tk = Val(c1.Text & "." & c2.Text)
            If Val(c2.Text) > Val(s2.Text) Then
                s3.Text = Val(s1.Text) - Val(c1.Text) - 1
                s4.Text = Val(s2.Text) + 1000 - Val(c2.Text)
            Else
                s3.Text = Val(s1.Text) - Val(c1.Text)
                s4.Text = Val(s2.Text) - Val(c2.Text)
            End If
            Button1.Enabled = True
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ucmd.CommandText = "update stock set stockm1=" & Val(s3.Text) & "," & "stockm2=" & Val(s4.Text) & " where itemcode='" & empds.Tables(0).Rows(items.SelectedIndex).Item("itemcode") & "' and concerncode=" & ccode
        writer.WriteLine("Updating STOCK after consumption ...")
        writer.WriteLine("Query : " & ucmd.CommandText)
        ucmd.ExecuteNonQuery()
        ucmd.CommandText = "insert into itemstrans values (" & ccode & ",#" & doj.Value.Date & "#,'" & empds.Tables(0).Rows(items.SelectedIndex).Item("itemcode") & "','CONSUMPTION'," & Val(c1.Text) & "," & Val(c2.Text) & ",0,0," & Val(s3.Text) & "," & Val(s4.Text) & ")"
        writer.WriteLine("Adding Entry into Transaction for STOCK consumption ...")
        writer.WriteLine("Query : " & ucmd.CommandText)
        ucmd.ExecuteNonQuery()
    End Sub
End Class