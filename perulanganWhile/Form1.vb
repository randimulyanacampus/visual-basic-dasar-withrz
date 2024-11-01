Public Class Form1
    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim angka As Integer
        ListBox1.Items.Clear()
        angka = 1
        While angka <= Val(TxtBatas.Text)
            ListBox1.Items.Add(angka)
            angka = angka + 1
        End While
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
