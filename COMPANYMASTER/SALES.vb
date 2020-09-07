Imports System.IO
Imports System.Data
Imports System.Data.OleDb
Public Class SALES
    Dim writer As StreamWriter
    Dim con As New OleDbConnection
    Dim icmd, tcmd, suppcmd, stkcmd, nucmd As New OleDbCommand
    Dim ida, tda, suppda, stkda As New OleDbDataAdapter
    Dim ids, tds, suppds, stkds As New DataSet
    Dim i As Integer
    Dim oldstkm1, oldstkm2, clstkm1, clstkm2 As Long
    Dim ff As MsgBoxResult
    Dim tot, dr, cr, cmnt As String
    Private Sub SALES_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        writer.Close()
        writer.Dispose()
    End Sub
    Private Sub SALES_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = cs
        con.Open()
        icmd.Connection = con
        tcmd.Connection = con
        suppcmd.Connection = con
        stkcmd.Connection = con
        nucmd.Connection = con
        icmd.CommandText = "select * from items where concerncode=" & ccode & " and itemtype='PRODUCT'"
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

        suppcmd.CommandText = "select * from parties where concerncode=" & ccode & " and partytype='CUSTOMER'"
        suppds.Reset()
        suppds.Clear()
        suppda.SelectCommand = suppcmd
        suppda.Fill(suppds)
        suppliers.Items.Clear()
        If suppds.Tables(0).Rows.Count > 0 Then
            For i = 0 To suppds.Tables(0).Rows.Count - 1
                suppliers.Items.Add(suppds.Tables(0).Rows(i).Item("nam"))
            Next i
        End If

        dop.MaxDate = Today.Date
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
        q2.Clear() : q1.Clear() : rate.Clear()
        If Trim(m2.Text) = "-" Then
            q2.Enabled = False
        Else
            q2.Enabled = True
        End If
        'check existing stock
        stkcmd.CommandText = "select * from stock where concerncode=" & ccode & " and itemcode='" & ids.Tables(0).Rows(itms.SelectedIndex).Item("itemcode") & "'"
        stkds.Reset()
        stkds.Clear()
        stkda.SelectCommand = stkcmd
        stkda.Fill(stkds)
        If stkds.Tables(0).Rows.Count > 0 Then 'stock entry is there
            oldstk1.Text = stkds.Tables(0).Rows(0).Item("stockm1")
            oldstkm1 = stkds.Tables(0).Rows(0).Item("stockm1")
            oldstk2.Text = stkds.Tables(0).Rows(0).Item("stockm2")
            oldstkm2 = stkds.Tables(0).Rows(0).Item("stockm2")
        Else ' no stock. mark it zro
            oldstk1.Text = 0
            oldstkm1 = 0
            oldstk2.Text = 0
            oldstkm2 = 0
        End If
        'check any purchase of same item already exist on the same date
        tcmd.CommandText = "select * from itemstrans where tdate=#" & dop.Value.Date & "# and itemcode='" & ids.Tables(0).Rows(itms.SelectedIndex).Item("itemcode") & "'"
        tds.Reset()
        tds.Clear()
        tda.SelectCommand = tcmd
        tda.Fill(tds)
        If tds.Tables(0).Rows.Count > 0 Then 'already purchase entry exist on same date. ? to do
            ff = MsgBox("Already Sales of the Item : " & itms.Text & " Exist on this same date. Add another Sales?", MsgBoxStyle.YesNo, "SALES ALREADY EXIST. ADD ANOTHER - CONFIRMATION")
            If ff = MsgBoxResult.Yes Then 'add another purchase of same item on same date
                GoTo fresh_purchase
            Else
                'ff = MsgBox("Edit the Existing Purchase Entry?", MsgBoxStyle.OkCancel, "PURCHASE ALREADY EXIST. EDIT? - CONFIRMATION")
                'If ff = MsgBoxResult.Ok Then 'edit
                ''prohibited now
                'Else
                MsgBox("SALES PROCESS CENCELLED BY USER", MsgBoxStyle.Critical, "USER ABORT")
                'End If
            End If
        Else ' make a fresh purchase entry
fresh_purchase:
            Button1.Enabled = True
            Button1.Text = "Save"
            q1.Focus()
        End If
    End Sub
    Private Sub suppliers_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles suppliers.SelectedIndexChanged
        addr.Text = suppds.Tables(0).Rows(suppliers.SelectedIndex).Item("address") & " Ph :" & suppds.Tables(0).Rows(suppliers.SelectedIndex).Item("phone")
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If bno.Text = "" Or Val(bno.Text) = 0 Then
            MsgBox("Enter Valid Bill No.", MsgBoxStyle.Critical, "ERROR IN BILL NO.")
            rate.Focus()
            GoTo out
        End If
        If q2.Enabled = False Then 'read only q1
            If q1.Text = "" Then
                MsgBox("Enter Valid Quantiity", MsgBoxStyle.Critical, "ERROR IN QUANTITY")
                q1.Focus()
                GoTo out
            End If
            If Val(q1.Text) > oldstkm2 Then
                MsgBox("Enter Valid Quantiity", MsgBoxStyle.Critical, "STOCK UNDERFLOW - LEAD TO NEGATIVE STOCK")
                q1.Focus()
                GoTo out
            End If
        Else
            If q1.Text = "" And q2.Text = "" Then
                MsgBox("Enter Valid Quantiity", MsgBoxStyle.Critical, "ERROR IN QUANTITY")
                q1.Focus()
                GoTo out
            End If
            If Val(q1.Text) > oldstkm1 Or (Val(q1.Text) = oldstkm1 And Val(q2.Text) > oldstkm2) Then
                MsgBox("Enter Valid Quantiity", MsgBoxStyle.Critical, "STOCK UNDERFLOW - LEAD TO NEGATIVE STOCK")
                q1.Focus()
                GoTo out
            End If
            If q1.Text = "" And q2.Text = "" Then
                MsgBox("Enter Valid Quantiity", MsgBoxStyle.Critical, "ERROR IN QUANTITY")
                q1.Focus()
                GoTo out
            End If
        End If
        If rate.Text = "" Or Val(rate.Text) = 0 Then
            MsgBox("Enter Valid Rate", MsgBoxStyle.Critical, "ERROR IN RATE")
            rate.Focus()
            GoTo out
        End If
        If suppliers.SelectedIndex < 0 Then
            MsgBox("Select any Customer", MsgBoxStyle.Critical, "CUSTOMER CAN NOT BE LEFT BLANK")
            suppliers.Focus()
            GoTo out
        End If

        ff = MsgBox("Cash Sales?", MsgBoxStyle.YesNo, "CASH Sales? - CONFIRMATION")
        cr = ids.Tables(0).Rows(itms.SelectedIndex).Item("itemcode") 'item goes out
        If ff = MsgBoxResult.Yes Then
            tot = "CASH SALES"
            dr = "CASH" 'cash comes in
            cmnt = "CASH SALES as per bill no." & bno.Text & " dated :" & dop.Value.Date
        Else
            tot = "CREDIT SALES"
            cr = suppds.Tables(0).Rows(suppliers.SelectedIndex).Item("code")
            cmnt = "CREDIT SALES as per bill no." & bno.Text & " dated :" & dop.Value.Date
        End If
        'find closing stock
        If Val(q1.Text) = oldstkm1 Then
            clstkm1 = 0
            clstkm2 = oldstkm2 - Val(q2.Text)
        End If
        If Val(q1.Text) < oldstkm1 Then
            If Val(q2.Text) < oldstkm2 Then
                clstkm1 = oldstkm1 - Val(q1.Text)
                clstkm2 = oldstkm2 - Val(q2.Text)
            Else
                clstkm1 = (oldstkm1 - 1) - Val(q1.Text)
                clstkm2 = oldstkm2 + 1000 - Val(q2.Text)
            End If
            'clstkm1 = 0
            'clstkm2 = oldstkm2 - Val(q2.Text)
        End If

        'clstkm1 = oldstkm1 - Val(q1.Text)
        'clstkm2 = oldstkm2 - Val(q2.Text)

        'add purchase to itemstrans
        nucmd.CommandText = "insert into itemstrans values(" & ccode & ",#" & dop.Value.Date & "#,'" & ids.Tables(0).Rows(itms.SelectedIndex).Item("itemcode") & "','PURCHASE'," & Val(q1.Text) & "," & Val(q2.Text) & ",'" & suppds.Tables(0).Rows(suppliers.SelectedIndex).Item("code") & "'," & Val(rate.Text) & "," & clstkm1 & "," & clstkm2 & ")"
        writer.WriteLine("Adding SALES TO ITEMSTRANS ...")
        writer.WriteLine("Query : " & nucmd.CommandText)
        nucmd.ExecuteNonQuery()

        'add the purchase to stock also
        If oldstkm1 = 0 And oldstkm2 = 0 Then
            'nucmd.CommandText = "insert into stock values(" & ccode & ",'" & ids.Tables(0).Rows(itms.SelectedIndex).Item("itemcode") & "'," & Val(q1.Text) & "," & Val(q2.Text) & ")"
        Else
            nucmd.CommandText = "update stock set stockm1= " & clstkm1 & ",stockm2=" & clstkm2 & " where concerncode=" & ccode & " and itemcode='" & ids.Tables(0).Rows(itms.SelectedIndex).Item("itemcode") & "'"
        End If
        writer.WriteLine("Updating SALES QUANTITY To STOCK table...")
        writer.WriteLine("Query : " & nucmd.CommandText)
        nucmd.ExecuteNonQuery()

        'update trans
        nucmd.CommandText = "insert into trans values(" & ccode & ",#" & dop.Value.Date & "#,'" & tot & "','" & dr & "','" & cr & "'," & Val(rate.Text) & ",'" & cmnt & "')"
        writer.WriteLine("Adding SALES TO ITEMSTRANS ...")
        writer.WriteLine("Query : " & nucmd.CommandText)
        nucmd.ExecuteNonQuery()

        MsgBox("SALES ENTRY MADE", MsgBoxStyle.Information, "SUCCESS")
        bno.Clear()
        q1.Clear()
        q2.Clear()
        rate.Clear()
        oldstk1.Text = clstkm1
        oldstk2.Text = clstkm2
        'oldm1.Text = ""
        'oldm2.Text = ""
        m1.Text = ""
        m2.Text = ""

out:
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class