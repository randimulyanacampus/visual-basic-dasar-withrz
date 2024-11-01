Public Class Form1
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.GridLines = True
        ListView1.View = View.Details
        ListView1.Columns.Add("NIM")
        ListView1.Columns.Add("NAMA", 115)
        ListView1.Columns.Add("PRODI", 110)
        TxtNIM.Text = 1
        TxtNama.Focus()
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Dim Arr(2) As String
        Arr(0) = TxtNIM.Text
        Arr(1) = TxtNama.Text
        Arr(2) = TxtProdi.Text
        Dim listitem As ListViewItem
        listitem = New ListViewItem
        listitem = ListView1.Items.Add(Arr(0))
        listitem.SubItems.Add(Arr(1))
        listitem.SubItems.Add(Arr(2))
        TxtNIM.Text = TxtNIM.Text + 1
        TxtNama.Text = ""
        TxtProdi.Text = ""
        TxtNama.Focus()
    End Sub
End Class
