Public Class Form2
    Function Akar(ByVal a As Decimal) As String
        Return Math.Sqrt(a)
    End Function
    Function Pangkat(ByVal a As Decimal, ByVal b As Decimal) As String
        Return a ^ b
    End Function
    Function Pembagian(ByVal a As Decimal, ByVal b As Decimal) As String
        Return a / b
    End Function
    Function Perkalian(ByVal a As Decimal, ByVal b As Decimal) As String
        Return a * b
    End Function
    Function Pemjumlahan(ByVal a As Decimal, ByVal b As Decimal) As String
        Return a + b
    End Function
    Function Pengurangan(ByVal a As Decimal, ByVal b As Decimal) As String
        Return a - b
    End Function

    Private Sub BtnHitung_Click_1(sender As Object, e As EventArgs) Handles BtnHitung.Click
        If RdbAkar.Checked = True Then
            TxtHasil.Text = Akar(TxtVar1.Text)
        ElseIf RdbPangkat.Checked = True Then
            TxtHasil.Text = Pangkat(TxtVar1.Text, TxtVar2.Text)
        ElseIf RdbPembagian.Checked = True Then
            TxtHasil.Text = Pembagian(TxtVar1.Text, TxtVar2.Text)
        ElseIf RdbPerkalian.Checked = True Then
            TxtHasil.Text = Perkalian(TxtVar1.Text, TxtVar2.Text)
        ElseIf RdbPenjumlahan.Checked = True Then
            TxtHasil.Text = Pemjumlahan(TxtVar1.Text, TxtVar2.Text)
        ElseIf RdbPengurangan.Checked = True Then
            TxtHasil.Text = Pengurangan(TxtVar1.Text, TxtVar2.Text)
        End If
    End Sub
End Class