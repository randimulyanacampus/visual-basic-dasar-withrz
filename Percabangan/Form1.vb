Public Class Form1
    Private Sub Btn_if_else_Click(sender As Object, e As EventArgs) Handles Btn_if_else.Click
        Dim usia As String, nilai As Single, thn As Integer
        usia = InputBox("Usia Pegawai saat ini?", "Batasan usia pensiun", 0)
        nilai = Val(usia)
        If nilai >= 55 Then
            thn = nilai - 55
            MessageBox.Show("usia pegawai : " & usia & " Tahun", "Konfirmasi", MessageBoxButtons.OK,
           MessageBoxIcon.Information)
            MessageBox.Show("Keterangan : Pegawai harus pensiun " & thn & " tahun yang lalu", "Konfirmasi",
           MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            thn = 55 - nilai
            MessageBox.Show("usia pegawai : " & usia & " Tahun", "Konfirmasi", MessageBoxButtons.OK,
           MessageBoxIcon.Information)
            MessageBox.Show("Keterangan : Pegawai akan pensiun " & thn & " lagi", "Konfirmasi", MessageBoxButtons.OK,
           MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Btn_if_Click(sender As Object, e As EventArgs) Handles Btn_if.Click
        Dim usia As String, nilai As Single, thn As Integer
        usia = InputBox("Usia Pegawai saat ini?", "Batasan usia pensiun", 0)
        nilai = Val(usia)
        If nilai >= 55 Then
            thn = nilai - 55
            MessageBox.Show("usia pegawai : " & usia & " Tahun", "Konfirmasi", MessageBoxButtons.OK,
           MessageBoxIcon.Information)
            MessageBox.Show("Keterangan : Pegawai harus pensiun " & thn & " tahun yang lalu", "Konfirmasi",
           MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Btn_case_Click(sender As Object, e As EventArgs) Handles Btn_case.Click
        Dim isian As String, usia As Integer
        isian = InputBox("Usia anda saat ini?", "Status Anda")
        usia = Val(isian)
        MessageBox.Show("Usia Anda saat ini : " & usia & " tahun", "Konfirmasi", MessageBoxButtons.OK,
       MessageBoxIcon.Information)
        Select Case usia
            Case 1 To 4
                MessageBox.Show("Anda sekarang tergolong balita", "Konfirmasi", MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
            Case 5 To 16
                MessageBox.Show("Anda sekarang tergolong anak-anak", "Konfirmasi", MessageBoxButtons.OK,
               MessageBoxIcon.Information)
            Case 17 To 24
                MessageBox.Show("Anda sekarang tergolong remaja", "Konfirmasi", MessageBoxButtons.OK,
               MessageBoxIcon.Information)
            Case 25 To 55
                MessageBox.Show("Anda sekarang tergolong dewasa", "Konfirmasi", MessageBoxButtons.OK,
               MessageBoxIcon.Information)
            Case Is >= 56
                MessageBox.Show("Anda sekarang tergolong manula", "Konfirmasi", MessageBoxButtons.OK,
               MessageBoxIcon.Information)
            Case Else
                MessageBox.Show("Anda salah memasukkan usia", "Konfirmasi", MessageBoxButtons.OK,
               MessageBoxIcon.Information)
        End Select
    End Sub
End Class
