Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        If TxtPassword.Text = "" And TxtUserName.Text = "" Then
            MessageBox.Show("User name dan Password harus diisi", "Konfirmasi", MessageBoxButtons.OK,
           MessageBoxIcon.Question)
            TxtUserName.Focus()
        ElseIf TxtPassword.Text = "" Then
            MessageBox.Show("Password harus diisi", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Question)
            TxtPassword.Focus()
        ElseIf TxtUserName.Text = "" Then
            MessageBox.Show("User name harus diisi", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Question)
            TxtUserName.Focus()
        ElseIf TxtUserName.Text = "admin" And TxtPassword.Text = "admin" Then
            MessageBox.Show("Password dan User Name Benar", "Konfirmasi", MessageBoxButtons.OK,
           MessageBoxIcon.Question)
        Else
            MessageBox.Show("Password dan User Name Anda Salah, ulangi lagi", "Konfirmasi", MessageBoxButtons.OK,
           MessageBoxIcon.Question)
            TxtUserName.Text = ""
            TxtPassword.Text = ""
            TxtUserName.Focus()
        End If
    End Sub
End Class
