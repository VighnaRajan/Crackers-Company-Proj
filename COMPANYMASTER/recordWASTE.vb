Imports System.IO
Imports System.Data
Imports System.Data.OleDb
Public Class recordWASTE
    Dim writer As StreamWriter
    Dim con As New OleDbConnection
    Dim icmd, stkcmd, tcmd, nucmd As New OleDbCommand
    Dim ida, stkda, tda As New OleDbDataAdapter
    Dim ids, stkds, tds As New DataSet
    Dim i As Integer
    Dim ff As MsgBoxResult
    Dim clstk1, clstk2 As Long
    Private Sub recordWASTE_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        writer.Close()
        writer.Dispose()
    End Sub
    Private Sub recordWASTE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dop.MinDate = Today.Date
        dop.MaxDate = Today.Date
        con.ConnectionString = cs
        con.Open()
        icmd.Connection = con
        icmd.CommandText = "select * from items where concerncode=" & ccode & " and itemtype='WASTE'"
        ids.Reset()
        ids.Clear()
        ida.SelectCommand = icmd
        ida.Fill(ids)
        itms.Items.Clear()
        If ids.Tables(0).Rows.Count > 0 Then
            For i = 0 To ids.Tables(0).Rows.Count - 1
                itms.Items.Add(ids.Tables(0).Rows(i).Item("itemname"))
            Next i
        End If
        'writing to log file
        '===================
        logfile = String.Format(driv & "\COMPANY\LOGS\log_{0}.txt", DateTime.Today.ToString("dd-MMM-yyyy"))
        FileExists = File.Exists(logfile)
        writer = New StreamWriter(logfile, True)
    End Sub
    Private Sub itms_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles itms.SelectedIndexChanged
        m1.Text = ids.Tables(0).Rows(itms.SelectedIndex).Item("measure")
        oldm1.Text = m1.Text
        m2.Text = ids.Tables(0).Rows(itms.SelectedIndex).Item("measure1")
        oldm2.Text = m2.Text
        q2.Clear() : q1.Clear()
        If Trim(m2.Text) = "-" Then
            q2.Enabled = False
        Else
            q2.Enabled = True
        End If
        'check existing stock
        stkcmd.Connection = con
        stkcmd.CommandText = "select * from stock where concerncode=" & ccode & " and itemcode='" & ids.Tables(0).Rows(itms.SelectedIndex).Item("itemcode") & "'"
        stkds.Reset()
        stkds.Clear()
        stkda.SelectCommand = stkcmd
        stkda.Fill(stkds)
        If stkds.Tables(0).Rows.Count > 0 Then 'stock entry is there
            oldstk1.Text = stkds.Tables(0).Rows(0).Item("stockm1")
            'oldstkm1 = stkds.Tables(0).Rows(0).Item("stockm1")
            oldstk2.Text = stkds.Tables(0).Rows(0).Item("stockm2")
            'oldstkm2 = stkds.Tables(0).Rows(0).Item("stockm2")
        Else ' no stock. mark it zro
            oldstk1.Text = 0
            'oldstkm1 = 0
            oldstk2.Text = 0
            'oldstkm2 = 0
        End If
        'check any waste entry of same item already exist on the same date
        tcmd.Connection = con
        tcmd.CommandText = "select * from itemstrans where tdate=#" & dop.Value.Date & "# and itemcode='" & ids.Tables(0).Rows(itms.SelectedIndex).Item("itemcode") & "'"
        tds.Reset()
        tds.Clear()
        tda.SelectCommand = tcmd
        tda.Fill(tds)
        If tds.Tables(0).Rows.Count > 0 Then 'already purchase entry exist on same date. ? to do
            ff = MsgBox("Already Waste Entry of the Item : " & itms.Text & " Exist on this same date. Add another?", MsgBoxStyle.YesNo, "WASTAGE ALREADY EXIST. ADD ANOTHER - CONFIRMATION")
            If ff = MsgBoxResult.Yes Then 'add another purchase of same item on same date
                GoTo fresh_purchase
            Else
                'ff = MsgBox("Edit the Existing Purchase Entry?", MsgBoxStyle.OkCancel, "PURCHASE ALREADY EXIST. EDIT? - CONFIRMATION")
                'If ff = MsgBoxResult.Ok Then 'edit
                ''prohibited now
                'Else
                MsgBox("WASTAGE ENTRY PROCESS CENCELLED BY USER", MsgBoxStyle.Critical, "USER ABORT")
                'End If
            End If
        Else ' make a fresh purchase entry
fresh_purchase:
            Button1.Enabled = True
            Button1.Text = "Save"
            q1.Focus()
        End If

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        clstk1 = Val(oldstk1.Text) + Val(q1.Text)
        clstk2 = Val(oldstk2.Text) + Val(q2.Text)
        If clstk2 > 1000 Then
            clstk1 = clstk1 + 1
            clstk2 = clstk2 Mod 1000
        End If
        'add waste to itemstrans
        nucmd.Connection = con
        nucmd.CommandText = "insert into itemstrans values(" & ccode & ",#" & dop.Value.Date & "#,'" & ids.Tables(0).Rows(itms.SelectedIndex).Item("itemcode") & "','WASTE'," & Val(q1.Text) & "," & Val(q2.Text) & ",'0',0," & clstk1 & "," & clstk2 & ")"
        writer.WriteLine("Adding WASTE TO ITEMSTRANS ...")
        writer.WriteLine("Query : " & nucmd.CommandText)
        nucmd.ExecuteNonQuery()

        'add the waste to stock also
        If Val(oldstk1.Text) = 0 And Val(oldstk2.Text) = 0 Then
            nucmd.CommandText = "insert into stock values(" & ccode & ",'" & ids.Tables(0).Rows(itms.SelectedIndex).Item("itemcode") & "'," & Val(q1.Text) & "," & Val(q2.Text) & ")"
        Else
            nucmd.CommandText = "update stock set stockm1= " & clstk1 & ",stockm2=" & clstk2 & " where concerncode=" & ccode & " and itemcode='" & ids.Tables(0).Rows(itms.SelectedIndex).Item("itemcode") & "'"
        End If
        writer.WriteLine("Updating WASTE QUANTITY To STOCK table...")
        writer.WriteLine("Query : " & nucmd.CommandText)
        nucmd.ExecuteNonQuery()
        MsgBox("WASTE ENTRY ADDED", MsgBoxStyle.Information, "SUCCESS")
        oldstk1.Text = clstk1
        oldstk2.Text = clstk2
        q1.Clear()
        q2.Clear()
        Button1.Enabled = False
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub dop_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dop.ValueChanged
        If dop.Value.Date <> Today.Date Then
            MsgBox("WASTE ENTRY ON-DATE ONLY IS ALLOWED", MsgBoxStyle.Critical, "ERROR IN DATE. SELECT TODAY'S DATE")
            dop.Focus()
        End If
    End Sub
End Class