Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim X%
        X = TxtAngka.Text
        Do
            X = X Mod 2
            If X = 0 Then
                MsgBox("Bilangan Genap")
                Exit Do
            ElseIf X = 1 Then
                MsgBox("Bilangan Ganjil")
                Exit Do
            End If
        Loop While Not X
    End Sub
End Class
