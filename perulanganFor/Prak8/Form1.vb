Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tgl, bln, thn As Integer
        For tgl = 1 To 31
            CmbTgl.Items.Add(tgl)
        Next tgl

        For bln = 1 To 12
            CmbBln.Items.Add(bln)
        Next bln

        For thn = 1900 To 9999
            CmbThn.Items.Add(thn)
        Next thn
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles close.Click
        End
    End Sub
End Class
