Imports System.Data
Imports System.Data.OleDb
Imports System.Globalization
Public Class SALARYENTRY
    Dim con As New OleDbConnection
    Dim cmd, ecmd, jcmd, dcmd, nucmd As New OleDbCommand
    Dim da, eda, jda, dda As New OleDbDataAdapter
    Dim ds, eds, jds, dds As New DataSet
    Dim i, hours, minutes As Integer
    Dim sal, m As Decimal
    Dim d As Date
    Dim en, jb As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If rb1.Checked = True Then cmd.CommandText = "select * from empworkhrs where jdate between #" & fd.Value.Date & "# and #" & td.Value.Date & "# and concerncode=" & ccode & " order by jdate,ecode"
        If rb2.Checked = True Then cmd.CommandText = "select * from empworkhrs where jdate between #" & fd.Value.Date & "# and #" & td.Value.Date & "# and concerncode=" & ccode & " order by ecode,jdate"
        ds.Reset()
        ds.Clear()
        da.SelectCommand = cmd
        da.Fill(ds)

        grid.Rows.Clear()

        If ds.Tables(0).Rows.Count > 0 Then
            grid.Rows.Add(ds.Tables(0).Rows.Count)
            For i = 0 To ds.Tables(0).Rows.Count - 1
                d = ds.Tables(0).Rows(i).Item("jdate")
                grid.Rows(i).Cells(0).Value = Format(ds.Tables(0).Rows(i).Item("jdate"), "dd-MM-yyyy ") & d.ToString("ddd") ' , New CultureInfo("fr-FR"))
                grid.Rows(i).Cells(2).Value = ds.Tables(0).Rows(i).Item("job")
                grid.Rows(i).Cells(3).Value = Format(ds.Tables(0).Rows(i).Item("startt"), "hh:mm: tt")
                grid.Rows(i).Cells(4).Value = Format(ds.Tables(0).Rows(i).Item("endd"), "hh:mm: tt")

                ecmd.CommandText = "select * from employees where ecode=" & ds.Tables(0).Rows(i).Item("ecode")
                eds.Reset()
                eds.Clear()
                eda.SelectCommand = ecmd
                eda.Fill(eds)
                grid.Rows(i).Cells(1).Value = eds.Tables(0).Rows(0).Item("ename")

                minutes = DateDiff(DateInterval.Minute, ds.Tables(0).Rows(i).Item("startt"), ds.Tables(0).Rows(i).Item("endd"))
                hours = minutes \ 60
                minutes = minutes Mod 60
                grid.Rows(i).Cells(5).Value = hours
                grid.Rows(i).Cells(6).Value = minutes

                jcmd.CommandText = "select * from jobs where job='" & ds.Tables(0).Rows(i).Item("job") & "' and concerncode=" & ds.Tables(0).Rows(i).Item("concerncode")
                jds.Reset()
                jds.Clear()
                jda.SelectCommand = jcmd
                jda.Fill(jds)
                sal = jds.Tables(0).Rows(0).Item("hourlypay")

                If minutes > 0 And minutes <= 15 Then m = 0.25
                If minutes > 15 And minutes <= 30 Then m = 0.5
                If minutes > 30 And minutes <= 45 Then m = 0.75
                If minutes > 45 And minutes <= 60 Then m = 1
                grid.Rows(i).Cells(7).Value = (hours * sal) + (m * sal)

            Next i
            Button2.Enabled = True
        Else
            MsgBox("NO ENTRIES", MsgBoxStyle.Critical, "EMPTY WORK HOUR ENTRIES FOR THESE DATES")
        End If
    End Sub
    Private Sub SALARYENTRY_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = cs
        con.Open()
        cmd.Connection = con
        ecmd.Connection = con
        jcmd.Connection = con
        nucmd.Connection = con
        dcmd.Connection = con
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        grid.Rows(0).Cells(0).Style.ForeColor = Color.Pink
        For i = 0 To ds.Tables(0).Rows.Count - 1
            d = ds.Tables(0).Rows(i).Item("jdate")
            en = grid.Rows(i).Cells(1).Value 'emp name
            hours = grid.Rows(i).Cells(5).Value
            minutes = grid.Rows(i).Cells(6).Value
            jb = ds.Tables(0).Rows(i).Item("job")
            sal = grid.Rows(i).Cells(7).Value
            dcmd.CommandText = "select * from salary where concerncode=" & ccode & " and jdate=#" & d & "# and ename='" & en & "'"
            dds.Reset()
            dds.Clear()
            dda.SelectCommand = dcmd
            dda.Fill(dds)
            If dds.Tables(0).Rows.Count > 0 Then
                MsgBox("Entry Already Exist for Employee " & UCase(en) & " on " & d)
            Else
                nucmd.CommandText = "insert into salary values(" & ccode & ",#" & d & "#,'" & en & "'," & hours & "," & minutes & ",'" & jb & "'," & sal & ",False,#" & Today.Date & "#)"
                nucmd.ExecuteNonQuery()
            End If
        Next i
        MsgBox("Salary Details Uploaded")
        grid.Rows.Clear()
        rb1.Checked = False
        rb2.Checked = False
        Button2.Enabled = False

    End Sub
End Class