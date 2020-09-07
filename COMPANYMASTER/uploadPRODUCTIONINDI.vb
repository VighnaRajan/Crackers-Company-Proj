Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class uploadPRODUCTIONINDI
    Dim con As New OleDbConnection
    Dim empcmd, stkcmd, dcmd, pcmd, xcmd, ucmd As New OleDbCommand
    Dim empda, stkda, dda, pda, xda As New OleDbDataAdapter
    Dim empds, stkds, dds, pds, xds As New DataSet
    Dim i, j, ec, b, k As Integer
    Dim ff As MsgBoxResult
    Dim m(2), x, y As String
    Dim writer As StreamWriter
    Dim op, tk, cl As Decimal
    Dim q1, q2 As Long
    Private Sub uploadPRODUCTIONINDI_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        writer.Close()
        writer.Dispose()
    End Sub
    Private Sub uploadPRODUCTIONINDI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = cs '"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & cs
        con.Open()
        stkcmd.Connection = con
        empcmd.Connection = con
        ucmd.Connection = con
        dcmd.Connection = con
        pcmd.Connection = con
        xcmd.Connection = con
        empcmd.CommandText = "select * from items where itemtype='PRODUCT' and concerncode=" & ccode & " order by itemcode"
        empds.Reset()
        empds.Clear()
        empda.SelectCommand = empcmd
        empda.Fill(empds)
        Product.Items.Clear()
        l1.Items.Clear()
        l2.Items.Clear()
        l3.Items.Clear()
        If empds.Tables(0).Rows.Count > 0 Then
            For i = 0 To empds.Tables(0).Rows.Count - 1
                Product.Items.Add(empds.Tables(0).Rows(i).Item("itemname"))
                l1.Items.Add(empds.Tables(0).Rows(i).Item("itemname"))
                l2.Items.Add(0)
                l3.Items.Add(0)
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
            MsgBox("You can't make Production entry other than TODAY", MsgBoxStyle.Critical, "ERROR IN DATE")
            doj.Value = Today.Date
            grid.Enabled = False
            Button1.Enabled = False
            GoTo do_no
        End If
        'items.Focus()
        grid.Enabled = True
        Button1.Enabled = True
        grid.Rows.Clear()
        pcmd.CommandText = "select * from employees where ecode in (select ecode from empworkhrs where concerncode=" & ccode & " and jdate=#" & doj.Value.Date & "# and job in (select job from jobs where createproduct=true))"
        pds.Reset()
        pds.Clear()
        pda.SelectCommand = pcmd
        pda.Fill(pds)
        If pds.Tables(0).Rows.Count > 0 Then
            grid.Rows.Add(pds.Tables(0).Rows.Count)
            For i = 0 To pds.Tables(0).Rows.Count - 1
                grid.Rows(i).Cells(0).Value = pds.Tables(0).Rows(i).Item("ename")
            Next
            'existing database details
            Dim tcmd As New OleDbCommand
            Dim tda As New OleDbDataAdapter
            Dim tds As New DataSet
            tcmd.Connection = con
            tcmd.CommandText = "select * from itemstrans where typeoftrans='PRODUCTION' and tdate=#" & doj.Value.Date & "# and concerncode=" & ccode
            tds.Reset()
            tds.Clear()
            tda.SelectCommand = tcmd
            tda.Fill(tds)
            If tds.Tables(0).Rows.Count > 0 Then
                MsgBox("PRODUCTION ENTRY ALREADY MADE", MsgBoxStyle.Information, "ERROR")
                Button1.Enabled = False
                grid.Enabled = False
            Else
                Button1.Enabled = True
                grid.Enabled = True
            End If
        Else
            MsgBox("NO EMPLOYEES ASSIGNED FOR PRODUCTION JOB", MsgBoxStyle.Information, "NO PRODUCTION STAFF ON THIS DATE")
            grid.Enabled = False
            Button1.Enabled = False
            GoTo do_no
        End If
do_no:
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub c1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1.LostFocus
        If Val(c1.Text) < 0 Then
            MsgBox("NEGATIVE VALUES NOT ALLOWED", MsgBoxStyle.Critical, "PLEASE MENTION A VALUE GREATER THAN ZERO")
            c1.Focus()
            Button1.Enabled = False
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim qcmd, icmd, scmd As New OleDbCommand
        Dim qda, ida, sda As New OleDbDataAdapter
        Dim qds, ids, sds As New DataSet
        Dim cls1, cls2 As Long
        icmd.Connection = con
        qcmd.Connection = con
        scmd.Connection = con
        For i = 0 To grid.Rows.Count - 2
            icmd.CommandText = "select * from items where concerncode=" & ccode & " and itemname='" & grid.Rows(i).Cells(1).Value & "'"
            ids.Reset()
            ids.Clear()
            ida.SelectCommand = icmd
            ida.Fill(ids)

            qcmd.CommandText = "select * from stock where itemcode='" & ids.Tables(0).Rows(0).Item("itemcode") & "' and concerncode=" & ccode
            qds.Reset()
            qds.Clear()
            qda.SelectCommand = qcmd
            qda.Fill(qds)
            If qds.Tables(0).Rows.Count = 0 Then 'insert new product stock
                ucmd.CommandText = "insert into stock values(" & ccode & ",'" & ids.Tables(0).Rows(0).Item("itemcode") & "'," & grid.Rows(i).Cells(2).Value & "," & grid.Rows(i).Cells(4).Value & ")"
            Else 'update stock
                ucmd.CommandText = "update stock set stockm1=stockm1+" & grid.Rows(i).Cells(2).Value & ", stockm2=stockm2+" & grid.Rows(i).Cells(4).Value & " where concerncode=" & ccode & " and itemcode='" & ids.Tables(0).Rows(0).Item("itemcode") & "'"
            End If
            writer.WriteLine("Updating STOCK after production ...")
            writer.WriteLine("Query : " & ucmd.CommandText)
            ucmd.ExecuteNonQuery()

            scmd.CommandText = "select * from stock where concerncode=" & ccode & " and itemcode='" & ids.Tables(0).Rows(0).Item("itemcode") & "'"
            sds.Reset()
            sds.Clear()
            sda.SelectCommand = scmd
            sda.Fill(sds)
            If sds.Tables(0).Rows.Count = 0 Then
                cls1 = Val(grid.Rows(i).Cells(2).Value)
                cls2 = Val(grid.Rows(i).Cells(4).Value)
            Else
                cls1 = sds.Tables(0).Rows(0).Item("stockm1") + Val(grid.Rows(i).Cells(2).Value)
                cls2 = sds.Tables(0).Rows(0).Item("stockm2") + Val(grid.Rows(i).Cells(4).Value)
            End If
            If cls2 >= 1000 Then
                cls1 = cls1 + (cls2 \ 1000)
                cls2 = cls2 Mod 1000
            End If

            ucmd.CommandText = "insert into itemstrans values(" & ccode & ",#" & doj.Value.Date & "#,'" & ids.Tables(0).Rows(0).Item("itemcode") & "','PRODUCTION'," & grid.Rows(i).Cells(2).Value & "," & grid.Rows(i).Cells(4).Value & ",'" & grid.Rows(i).Cells(0).Value & "',0," & cls1 & "," & cls2 & ")"
            writer.WriteLine("Updating TRANS after production ...")
            writer.WriteLine("Query : " & ucmd.CommandText)
            ucmd.ExecuteNonQuery()
        Next
        MsgBox("UPDATED", MsgBoxStyle.Information, "SUCCESS")
    End Sub
    Private Sub grid_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles grid.EditingControlShowing
        If grid.CurrentCell.ColumnIndex = 1 Then
            Dim combo As ComboBox = CType(e.Control, ComboBox)
            If (combo IsNot Nothing) Then
                RemoveHandler combo.SelectionChangeCommitted, New EventHandler(AddressOf ComboBox_SelectionChangeCommitted)
                AddHandler combo.SelectionChangeCommitted, New EventHandler(AddressOf ComboBox_SelectionChangeCommitted)
                'RemoveHandler combo.SelectedIndexChanged, New EventHandler(AddressOf ComboBox_SelectedIndexChanged)
                'AddHandler combo.SelectedIndexChanged, New EventHandler(AddressOf ComboBox_SelectedIndexChanged)
            End If
        End If
        If grid.CurrentCell.ColumnIndex = 2 Or grid.CurrentCell.ColumnIndex = 4 Then
            Dim txt As TextBox = CType(e.Control, TextBox)
            If (txt IsNot Nothing) Then
                RemoveHandler txt.LostFocus, New EventHandler(AddressOf textbox_LostFocus)
                AddHandler txt.LostFocus, New EventHandler(AddressOf textbox_LostFocus)
            End If
        End If
    End Sub
    Private Sub ComboBox_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim combo As ComboBox = CType(sender, ComboBox)
        'MsgBox("Row: " & grid.CurrentCell.RowIndex & " Value: " & combo.SelectedItem)
        xcmd.CommandText = "select * from items where concerncode=" & ccode & " and itemtype='PRODUCT' and itemname='" & combo.SelectedItem & "'"
        xds.Reset()
        xds.Clear()
        xda.SelectCommand = xcmd
        xda.Fill(xds)
        grid.Rows(grid.CurrentCell.RowIndex).Cells("measure1").Value = xds.Tables(0).Rows(0).Item("measure")
        grid.Rows(grid.CurrentCell.RowIndex).Cells("measure2").Value = xds.Tables(0).Rows(0).Item("measure1")
        recalc()
    End Sub
    Private Sub recalc()
        Dim itm As String
        Dim v1, v2, tot, cary, t1, t2, tc As Long
        t1 = 0 : t2 = 0 : tc = 0
        For i = 0 To l1.Items.Count - 1
            l2.Items(i) = 0
            l3.Items(i) = 0
        Next
        For i = 0 To l1.Items.Count - 1
            itm = l1.Items(i)
            For j = 0 To grid.Rows.Count - 1
                If grid.Rows(j).Cells(1).Value = itm Then
                    v1 = Val(l3.Items(i))
                    v2 = Val(grid.Rows(j).Cells(4).Value)
                    tot = v1 + v2
                    If tot > 1000 Then
                        tot = tot - 1000
                        cary = 1
                    End If
                    l3.Items(i) = tot
                    v1 = Val(l2.Items(i))
                    v2 = Val(grid.Rows(j).Cells(2).Value)
                    tot = v1 + v2 + cary
                    l2.Items(i) = tot
                End If
            Next j
            t2 = t2 + Val(l3.Items(i))
            t1 = t1 + Val(l2.Items(i))
            tc = t2 \ 1000
            t1 = t1 + tc
            t2 = t2 Mod 1000
            c1.Text = t1
            c2.Text = t2
        Next i
    End Sub
    Private Sub textbox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim txt As TextBox = CType(sender, TextBox)
        Dim itm As String
        Dim v1, v2, tot, cary, t1, t2, tc As Long
        t1 = 0 : t2 = 0 : tc = 0
        For i = 0 To l1.Items.Count - 1
            l2.Items(i) = 0
            l3.Items(i) = 0
        Next
        For i = 0 To l1.Items.Count - 1
            itm = l1.Items(i)
            For j = 0 To grid.Rows.Count - 1
                If grid.Rows(j).Cells(1).Value = itm Then
                    v1 = Val(l3.Items(i))
                    v2 = Val(grid.Rows(j).Cells(4).Value)
                    tot = v1 + v2
                    If tot > 1000 Then
                        tot = tot - 1000
                        cary = 1
                    End If
                    l3.Items(i) = tot
                    v1 = Val(l2.Items(i))
                    v2 = Val(grid.Rows(j).Cells(2).Value)
                    tot = v1 + v2 + cary
                    l2.Items(i) = tot
                End If
            Next j
            t2 = t2 + Val(l3.Items(i))
            t1 = t1 + Val(l2.Items(i))
            tc = t2 \ 1000
            t1 = t1 + tc
            t2 = t2 Mod 1000
            c1.Text = t1
            c2.Text = t2
        Next i
        'MsgBox("Row: " & grid.CurrentCell.RowIndex & " Value: " & txt.Text)
    End Sub

    Private Sub c2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c2.TextChanged

    End Sub
End Class