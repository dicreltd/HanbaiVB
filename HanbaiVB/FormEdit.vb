Public Class FormEdit
    Public sho As Shouhin

    Private Sub FormEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not sho Is Nothing Then
            textBoxSname.Text = sho.Sname
            textBoxTanka.Text = sho.Tanka.ToString()
        End If
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim sname = textBoxSname.Text
        Dim tanka = Int(textBoxTanka.Text)

        If sho Is Nothing Then
            sho = New Shouhin(0, sname, tanka)
        Else
            sho.Sname = sname
            sho.Tanka = tanka
        End If

    End Sub
End Class