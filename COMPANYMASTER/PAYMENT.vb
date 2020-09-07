Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class PAYMENT
    Dim con As New OleDbConnection
    Dim supcmd, t1cmd, t2cmd, nucmd As New OleDbCommand
    Dim supda, t1da, t2da As New OleDbDataAdapter
    Dim supds, t1ds, t2ds As New DataSet
    Dim writer As StreamWriter
    Dim i As Integer
    Dim scode As Long
    Dim opbal, totdr, totcr, curbal, nubal As Decimal
    Dim opbaldate As Date
    Dim opbaltype, curbaltype, nubaltype As String
    Private Sub PAYMENT_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        writer.Close()
        writer.Dispose()
    End Sub
    Private Sub PAYMENT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = cs
        con.Open()
        supcmd.Connection = con
        t1cmd.Connection = con
        t2cmd.Connection = con
        nucmd.Connection = con
        supcmd.CommandText = "select * from parties where concerncode=" & ccode & " and partytype='SUPPLIER'"
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
        'writing to log file
        '===================
        logfile = String.Format(driv & "\COMPANY\LOGS\log_{0}.txt", DateTime.Today.ToString("dd-MMM-yyyy"))
        FileExists = File.Exists(logfile)
        writer = New StreamWriter(logfile, True)
    End Sub
    Private Sub suppliers_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles suppliers.SelectedIndexChanged
        totcr = 0
        totdr = 0
        curbal = 0
        amt.Text = 0

        scode = supds.Tables(0).Rows(suppliers.SelectedIndex).Item("code")
        opbal = supds.Tables(0).Rows(suppliers.SelectedIndex).Item("opbal")
        opbaldate = supds.Tables(0).Rows(suppliers.SelectedIndex).Item("opbalason")
        opbaltype = supds.Tables(0).Rows(suppliers.SelectedIndex).Item("drcr")

        adr.Text = supds.Tables(0).Rows(suppliers.SelectedIndex).Item("address")
        ph.Text = supds.Tables(0).Rows(suppliers.SelectedIndex).Item("phone")

        'find total credit purchases made from selected supplier
        t1cmd.CommandText = "select sum(amt) from trans where cr='" & scode & "' and typeoftrans='CREDIT PURCHASE' and tdate>=#" & opbaldate & "#"
        t1ds.Reset()
        t1ds.Clear()
        t1da.SelectCommand = t1cmd
        t1da.Fill(t1ds)
        If IsDBNull(t1ds.Tables(0).Rows(0).Item(0)) Then totcr = 0 Else totcr = t1ds.Tables(0).Rows(0).Item(0)
        'find total cash payments made to the selected supplier
        t2cmd.CommandText = "select sum(amt) from trans where dr='" & scode & "' and cr='CASH' and typeoftrans='CASH PAYMENT' and tdate>=#" & opbaldate & "#"
        t2ds.Reset()
        t2ds.Clear()
        t2da.SelectCommand = t2cmd
        t2da.Fill(t2ds)
        If IsDBNull(t2ds.Tables(0).Rows(0).Item(0)) Then totdr = 0 Else totdr = t2ds.Tables(0).Rows(0).Item(0)
        'MsgBox("op.bAL =" & opbal & "-" & opbaltype)
        'MsgBox("Tot Dr =" & totdr)
        'MsgBox("Tot Cr =" & totcr)

        If opbaltype = "CR" Then
            curbal = opbal + totcr - totdr
            If curbal > 0 Then
                curbaltype = "CR"
            Else
                curbaltype = "DR"
            End If
        ElseIf opbaltype = "DR" Then
            curbal = opbal + totdr - totcr
            If curbal > 0 Then
                curbaltype = "DR"
            Else
                curbaltype = "CR"
            End If
        End If
        'MsgBox("Cur Bal=" & curbal & "-" & curbaltype)
        cbal.Text = curbal
        If curbaltype = "CR" Then
            cbal.ForeColor = Color.Red
            cbtype.Text = "(CR)"
            cbtype.ForeColor = Color.Red
        ElseIf curbaltype = "DR" Then
            cbal.ForeColor = Color.Green
            cbtype.Text = "(DR)"
            cbtype.ForeColor = Color.Green
        End If
        'amt.Focus()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub amt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles amt.TextChanged
        If curbaltype = "CR" Then
            If Val(amt.Text) < curbal Then
                nubal = curbal - Val(amt.Text)
                nubaltype = "CR"
            ElseIf Val(amt.Text) > curbal Then
                GoTo adddr
            ElseIf Val(amt.Text) = curbal Then
                nubal = 0
                nubaltype = "CR"
            End If
        ElseIf curbaltype = "DR" Then
adddr:
            nubal = Val(amt.Text) - curbal
            nubaltype = "DR"
        End If
        newbal.Text = nubal
        newbaltype.Text = nubaltype
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        nucmd.CommandText = "insert into trans values(" & ccode & ",#" & dop.Value.Date & "#,'CASH PAYMENT','" & scode & "','CASH'," & Val(amt.Text) & ",'CASH PAYMENT made as on " & dop.Value.Date & "')"
        nucmd.ExecuteNonQuery()
        amt.Clear()
        'i = suppliers.SelectedIndex
        suppliers.SelectedIndex = 0
    End Sub
End Class