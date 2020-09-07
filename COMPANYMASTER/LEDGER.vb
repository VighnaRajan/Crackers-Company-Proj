Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class LEDGER
    Dim con As New OleDbConnection
    Dim supcmd, t1cmd, t2cmd, tcmd, nucmd As New OleDbCommand
    Dim supda, t1da, t2da, tda As New OleDbDataAdapter
    Dim supds, t1ds, t2ds, tds As New DataSet

    Dim opbalcr, opbaldr As Decimal


    Dim writer As StreamWriter
    Dim i As Integer
    Dim scode As Long
    Dim opbal, totdr, totcr, curbal, nubal As Decimal
    Dim opbaldate As Date
    Dim opbaltype, curbaltype, nubaltype As String
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub LEDGER_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        writer.Close()
        writer.Dispose()
    End Sub
    Private Sub LEDGER_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If con.State = ConnectionState.Closed Then
            con.ConnectionString = cs
            con.Open()
        End If
        supcmd.Connection = con
        t1cmd.Connection = con
        t2cmd.Connection = con
        tcmd.Connection = con
        nucmd.Connection = con
        'writing to log file
        '===================
        logfile = String.Format(driv & "\COMPANY\LOGS\log_{0}.txt", DateTime.Today.ToString("dd-MMM-yyyy"))
        FileExists = File.Exists(logfile)
        writer = New StreamWriter(logfile, True)
    End Sub
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles supplier.CheckedChanged
        If con.State = ConnectionState.Closed Then
            con.ConnectionString = cs
            con.Open()
        End If
        supcmd.Connection = con
        supcmd.CommandText = "select * from parties where concerncode=" & ccode & " and partytype='SUPPLIER'"
        fill_parties()
    End Sub
    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles customer.CheckedChanged
        supcmd.Connection = con
        supcmd.CommandText = "select * from parties where concerncode=" & ccode & " and partytype='CUSTOMER'"
        fill_parties()
    End Sub
    Private Sub fill_parties()
        supds.Reset()
        supds.Clear()
        supda.SelectCommand = supcmd
        supda.Fill(supds)
        suppliers.Items.Clear()
        If supds.Tables(0).Rows.Count > 0 Then
            For i = 0 To supds.Tables(0).Rows.Count - 1
                suppliers.Items.Add(supds.Tables(0).Rows(i).Item("nam"))
            Next i
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cr, dr As Decimal
        Dim tdat As Date
        Dim parti As String

        nucmd.CommandText = "delete from rptLEDGER"
        nucmd.ExecuteNonQuery()
        'add opening balance entry
        '-------------------------
        nucmd.CommandText = "insert into rptLEDGER values(" & supds.Tables(0).Rows(suppliers.SelectedIndex).Item("code") & ",#" & opbaldate & "#,'OPENING BALANCE'," & opbaldr & "," & opbalcr & ")"
        nucmd.ExecuteNonQuery()
        'add entries after opening balance till from-date
        '------------------------------------------------
        If supplier.Checked Then
            'total credit purchase made from the supplier
            '--------------------------------------------
            t1cmd.CommandText = "select sum(amt) from trans where concerncode=" & ccode & " and (tdate >= #" & opbaldate & "# and tdate < #" & fd.Value.Date & "#) and typeoftrans='CREDIT PURCHASE' and cr='" & supds.Tables(0).Rows(suppliers.SelectedIndex).Item("code") & "'"
            t1ds.Reset()
            t1ds.Clear()
            t1da.SelectCommand = t1cmd
            t1da.Fill(t1ds)
            If Not IsDBNull(t1ds.Tables(0).Rows(0).Item(0)) Then cr = t1ds.Tables(0).Rows(0).Item(0) Else cr = 0
            nucmd.CommandText = "insert into rptLEDGER values(" & supds.Tables(0).Rows(suppliers.SelectedIndex).Item("code") & ",#" & fd.Value.Date & "#,'CREDIT PURCHASES MADE',0," & cr & ")"
            nucmd.ExecuteNonQuery()
            'total cash payment made to the supplier
            '---------------------------------------
            t2cmd.CommandText = "select sum(amt) from trans where concerncode=" & ccode & " and (tdate >= #" & opbaldate & "# and tdate < #" & fd.Value.Date & "#) and typeoftrans='CASH PAYMENT' and dr='" & supds.Tables(0).Rows(suppliers.SelectedIndex).Item("code") & "'"
            t2ds.Reset()
            t2ds.Clear()
            t2da.SelectCommand = t2cmd
            t2da.Fill(t2ds)
            If Not IsDBNull(t2ds.Tables(0).Rows(0).Item(0)) Then dr = t2ds.Tables(0).Rows(0).Item(0) Else dr = 0
            nucmd.CommandText = "insert into rptLEDGER values(" & supds.Tables(0).Rows(suppliers.SelectedIndex).Item("code") & ",#" & fd.Value.Date & "#,'CASH PAYMENTS MADE'," & dr & ",0)"
            nucmd.ExecuteNonQuery()
            'add actual transactions within spec. dates
            '------------------------------------------
            tcmd.CommandText = "select * from trans where concerncode=" & ccode & " and (tdate >= #" & fd.Value.Date & "# and tdate <= #" & td.Value.Date & "#) and ((typeoftrans='CREDIT PURCHASE' and cr='" & supds.Tables(0).Rows(suppliers.SelectedIndex).Item("code") & "') or (typeoftrans='CASH PAYMENT' and dr='" & supds.Tables(0).Rows(suppliers.SelectedIndex).Item("code") & "'))"
            tds.Reset()
            tds.Clear()
            tda.SelectCommand = tcmd
            tda.Fill(tds)
            If tds.Tables(0).Rows.Count > 0 Then
                For i = 0 To tds.Tables(0).Rows.Count - 1
                    tdat = tds.Tables(0).Rows(i).Item("tdate")
                    If tds.Tables(0).Rows(i).Item("typeoftrans") = "CREDIT PURCHASE" Then
                        parti = "CREDIT PURCHASE"
                        dr = 0
                        cr = tds.Tables(0).Rows(i).Item("amt")
                    End If
                    If tds.Tables(0).Rows(i).Item("typeoftrans") = "CASH PAYMENT" Then
                        parti = "CASH PAYMENT"
                        dr = tds.Tables(0).Rows(i).Item("amt")
                        cr = 0
                    End If
                    nucmd.CommandText = "insert into rptLEDGER values(" & supds.Tables(0).Rows(suppliers.SelectedIndex).Item("code") & ",#" & tdat & "#,'" & parti & "'," & dr & "," & cr & ")"
                    nucmd.ExecuteNonQuery()
                Next
            End If
        ElseIf customer.Checked Then
            'total credit sales made to the customer
            '---------------------------------------
            t1cmd.CommandText = "select sum(amt) from trans where concerncode=" & ccode & " and (tdate >= #" & opbaldate & "# and tdate < #" & fd.Value.Date & "#) and typeoftrans='CREDIT SALES' and dr='" & supds.Tables(0).Rows(suppliers.SelectedIndex).Item("code") & "'"
            t1ds.Reset()
            t1ds.Clear()
            t1da.SelectCommand = t1cmd
            t1da.Fill(t1ds)
            If Not IsDBNull(t1ds.Tables(0).Rows(0).Item(0)) Then dr = t1ds.Tables(0).Rows(0).Item(0) Else dr = 0
            nucmd.CommandText = "insert into rptLEDGER values(" & supds.Tables(0).Rows(suppliers.SelectedIndex).Item("code") & ",#" & fd.Value.Date & "#,'CREDIT SALES MADE'," & dr & ",0)"
            nucmd.ExecuteNonQuery()
            'total cash receipt received from the customer
            '---------------------------------------------
            t2cmd.CommandText = "select sum(amt) from trans where concerncode=" & ccode & " and (tdate >= #" & opbaldate & "# and tdate < #" & fd.Value.Date & "#) and typeoftrans='CASH RECEIPT' and cr='" & supds.Tables(0).Rows(suppliers.SelectedIndex).Item("code") & "'"
            t2ds.Reset()
            t2ds.Clear()
            t2da.SelectCommand = t2cmd
            t2da.Fill(t2ds)
            If Not IsDBNull(t2ds.Tables(0).Rows(0).Item(0)) Then cr = t2ds.Tables(0).Rows(0).Item(0) Else cr = 0
            nucmd.CommandText = "insert into rptLEDGER values(" & supds.Tables(0).Rows(suppliers.SelectedIndex).Item("code") & ",#" & fd.Value.Date & "#,'CASH RECEIPTS MADE',0," & cr & ")"
            nucmd.ExecuteNonQuery()
            'add actual transactions within spec. dates
            '------------------------------------------
            tcmd.CommandText = "select * from trans where concerncode=" & ccode & " and (tdate >= #" & fd.Value.Date & "# and tdate <= #" & td.Value.Date & "#) and ((typeoftrans='CREDIT SALES' and dr='" & supds.Tables(0).Rows(suppliers.SelectedIndex).Item("code") & "') or (typeoftrans='CASH RECEIPT' and cr='" & supds.Tables(0).Rows(suppliers.SelectedIndex).Item("code") & "'))"
            tds.Reset()
            tds.Clear()
            tda.SelectCommand = tcmd
            tda.Fill(tds)
            If tds.Tables(0).Rows.Count > 0 Then
                For i = 0 To tds.Tables(0).Rows.Count - 1
                    tdat = tds.Tables(0).Rows(i).Item("tdate")
                    If tds.Tables(0).Rows(i).Item("typeoftrans") = "CREDIT SALES" Then
                        parti = "CREDIT SALES"
                        cr = 0
                        dr = tds.Tables(0).Rows(i).Item("amt")
                    End If
                    If tds.Tables(0).Rows(i).Item("typeoftrans") = "CASH RECEIPT" Then
                        parti = "CASH RECEIPT"
                        cr = tds.Tables(0).Rows(i).Item("amt")
                        dr = 0
                    End If
                    nucmd.CommandText = "insert into rptLEDGER values(" & supds.Tables(0).Rows(suppliers.SelectedIndex).Item("code") & ",#" & tdat & "#,'" & parti & "'," & dr & "," & cr & ")"
                    nucmd.ExecuteNonQuery()
                Next
            End If
            't1cmd.CommandText = "select * from trans where concerncode=" & ccode & " and (tdate between #" & fd.Value.Date & "# and #" & td.Value.Date & "#) and ((typeoftrans='CREDIT SALES' and dr=" & supds.Tables(0).Rows(suppliers.SelectedIndex).Item("code") & ") or (typeoftrans='CASH RECEIPT' and cr=" & supds.Tables(0).Rows(suppliers.SelectedIndex).Item("code") & "))"
        End If
    End Sub
    Private Sub fd_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fd.ValueChanged
        td.MinDate = fd.Value.Date
        td.MaxDate = Today.Date
    End Sub
    Private Sub suppliers_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles suppliers.SelectedIndexChanged

        opbaldate = supds.Tables(0).Rows(suppliers.SelectedIndex).Item("opbalason")
        If supds.Tables(0).Rows(suppliers.SelectedIndex).Item("drcr") = "DR" Then
            opbaldr = supds.Tables(0).Rows(suppliers.SelectedIndex).Item("opbal")
            opbalcr = 0
        ElseIf supds.Tables(0).Rows(suppliers.SelectedIndex).Item("drcr") = "CR" Then
            opbalcr = supds.Tables(0).Rows(suppliers.SelectedIndex).Item("opbal")
            opbaldr = 0
        End If
    End Sub
End Class