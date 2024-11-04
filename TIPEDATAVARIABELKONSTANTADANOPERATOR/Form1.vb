Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CmbOperator.Items.Add("+")
        CmbOperator.Items.Add("-")
        CmbOperator.Items.Add("x")
        CmbOperator.Items.Add("/")
        CmbOperator.Items.Add("Sisa")
        CmbOperator.Items.Add("Pangkat")
        CmbOperator.Items.Add("<>")
        CmbOperator.Items.Add("<")
        CmbOperator.Items.Add(">")
        CmbOperator.Items.Add("<=")
        CmbOperator.Items.Add(">=")
        CmbOperator.Items.Add("Like")
        CmbOperator.Items.Add("Not")
        CmbOperator.Items.Add("And")
        CmbOperator.Items.Add("Or")
        CmbOperator.Items.Add("Xor")
        CmbOperator.Items.Add("+p")
        CmbOperator.Items.Add("&")
    End Sub

    Private Sub BtnProses_Click(sender As Object, e As EventArgs) Handles BtnProses.Click
        Select Case CmbOperator.Text
            Case "+"
                TxtHasil.Text = Val(TxtNilai1.Text) + Val(TxtNilai2.Text)
            Case "-"
                TxtHasil.Text = Val(TxtNilai1.Text) - Val(TxtNilai2.Text)
            Case "x"
                TxtHasil.Text = Val(TxtNilai1.Text) * Val(TxtNilai2.Text)
            Case "/"
                TxtHasil.Text = Val(TxtNilai1.Text) / Val(TxtNilai2.Text)
            Case "Sisa"
                TxtHasil.Text = Val(TxtNilai1.Text) Mod Val(TxtNilai2.Text)
            Case "Pangkat"
                TxtHasil.Text = Val(TxtNilai1.Text) ^ Val(TxtNilai2.Text)
            Case "<>"
                TxtHasil.Text = TxtNilai1.Text <> TxtNilai2.Text
            Case "<"
                TxtHasil.Text = TxtNilai1.Text < TxtNilai2.Text
            Case ">"
                TxtHasil.Text = TxtNilai1.Text > TxtNilai2.Text
            Case "<="
                TxtHasil.Text = TxtNilai1.Text <= TxtNilai2.Text
            Case ">="
                TxtHasil.Text = TxtNilai1.Text >= TxtNilai2.Text
            Case "Like"
                TxtHasil.Text = TxtNilai1.Text Like TxtNilai2.Text
            Case "Not"
                TxtHasil.Text = Not TxtNilai1.Text = TxtNilai2.Text
            Case "And"
                TxtHasil.Text = TxtNilai1.Text = "STIKOM" And TxtNilai2.Text = "STIKOM"
            Case "Or"
                TxtHasil.Text = TxtNilai1.Text = "STIKOM" Or TxtNilai2.Text = "STIKOM"
            Case "Xor"
                TxtHasil.Text = TxtNilai1.Text = "STIKOM" Xor TxtNilai2.Text = "STIKOM"
            Case "+P"
                TxtHasil.Text = TxtNilai1.Text + TxtNilai2.Text
            Case "&"
                TxtHasil.Text = TxtNilai1.Text & TxtNilai2.Text
        End Select
    End Sub
End Class
