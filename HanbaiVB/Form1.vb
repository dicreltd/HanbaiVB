Public Class FormMain
    Private dtShouhin As New DataTable()

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con = New HanbaiConnection()
        Dim dao = New ShouhinDAO(con)

        con.Open()
        dao.Fill(dtShouhin)
        con.Close()

        dataGridView1.DataSource = dtShouhin

        dataGridView1.Columns(0).Visible = False
        dataGridView1.Columns(1).HeaderText = "商品名"
        dataGridView1.Columns(2).HeaderText = "単価"

    End Sub

    Private Sub buttonAdd_Click(sender As Object, e As EventArgs) Handles buttonAdd.Click
        Dim frm = New FormEdit()

        If frm.ShowDialog() = DialogResult.OK Then
            Dim con = New HanbaiConnection()
            Dim dao = New ShouhinDAO(con)

            con.Open()
            dao.Insert(frm.sho)
            dao.Fill(dtShouhin)
            con.Close()
        End If
    End Sub

    Private Function GetCurrentShouhin() As Shouhin
        Dim rowIndex = dataGridView1.CurrentCell.RowIndex
        Dim row = dtShouhin.Rows(rowIndex)

        Dim sid = Int(row("sid"))
        Dim sname = row("sname").ToString()
        Dim tanka = Int(row("tanka"))

        Return New Shouhin(sid, sname, tanka)
    End Function

    Private Sub buttonEdit_Click(sender As Object, e As EventArgs) Handles buttonEdit.Click
        Dim frm = New FormEdit()

        frm.sho = GetCurrentShouhin()

        If frm.ShowDialog() = DialogResult.OK Then
            Dim con = New HanbaiConnection()
            Dim dao = New ShouhinDAO(con)

            con.Open()
            dao.Update(frm.sho)
            dao.Fill(dtShouhin)
            con.Close()
        End If

    End Sub

    Private Sub buttonDel_Click(sender As Object, e As EventArgs) Handles buttonDel.Click
        Dim Shouhin = GetCurrentShouhin()

        If MessageBox.Show(Shouhin.Sname + "を削除しますか？",
               "削除", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Dim con = New HanbaiConnection()
            Dim dao = New ShouhinDAO(con)

            con.Open()
            dao.Delete(Shouhin.Sid)
            dao.Fill(dtShouhin)
            con.Close()
        End If
    End Sub
End Class
