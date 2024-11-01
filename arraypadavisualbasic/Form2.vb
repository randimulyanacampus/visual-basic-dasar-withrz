Public Class Form2
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Arr(3, 1) As String
        Arr(0, 0) = "NIM"
        Arr(0, 1) = "NAMA"
        Arr(1, 0) = "JENIS KELAMIN"
        Arr(1, 1) = "PRODI"
        Arr(2, 0) = "Laki-laki"
        Arr(2, 1) = "Perempuan"
        Arr(3, 0) = "Manajemen Informatika"
        Arr(3, 1) = "Teknik Informatika"
        ListView1.GridLines = True
        ListView1.View = View.Details
        For Baris = 0 To 1
            For Kolom = 0 To 1
                ListView1.Columns.Add(Arr(Baris, Kolom), 100)
            Next Kolom
        Next Baris
        For Baris = 2 To 2
            For Kolom = 0 To 1
                CmbKelamin.Items.Add(Arr(Baris, Kolom))
            Next Kolom
        Next Baris
        For Baris = 3 To 3
            For Kolom = 0 To 1
                CmbProdi.Items.Add(Arr(Baris, Kolom))
            Next Kolom
        Next Baris
    End Sub

    Private Sub BtnProses_Click(sender As Object, e As EventArgs) Handles BtnProses.Click
        Dim Arr(3) As String
        Arr(0) = TxtNIM.Text
        Arr(1) = TxtNama.Text
        Arr(2) = CmbKelamin.Text
        Arr(3) = CmbProdi.Text
        Dim listitem As ListViewItem
        listitem = New ListViewItem
        listitem = ListView1.Items.Add(Arr(0))
        listitem.SubItems.Add(Arr(1))
        listitem.SubItems.Add(Arr(2))
        listitem.SubItems.Add(Arr(3))
        TxtNIM.Text = TxtNIM.Text + 1
        TxtNama.Text = ""
        CmbKelamin.Text = ""
        CmbProdi.Text = ""
        TxtNama.Focus()
    End Sub
End Class