<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        TxtVar1 = New TextBox()
        TxtVar2 = New TextBox()
        TxtHasil = New TextBox()
        GroupBox1 = New GroupBox()
        RdbAkar = New RadioButton()
        RdbPangkat = New RadioButton()
        RdbPembagian = New RadioButton()
        RdbPerkalian = New RadioButton()
        RdbPenjumlahan = New RadioButton()
        RdbPengurangan = New RadioButton()
        BtnHitung = New Button()
        BtnExit = New Button()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TxtVar1
        ' 
        TxtVar1.Location = New Point(20, 20)
        TxtVar1.Name = "TxtVar1"
        TxtVar1.Size = New Size(100, 23)
        TxtVar1.TabIndex = 0
        ' 
        ' TxtVar2
        ' 
        TxtVar2.Location = New Point(20, 60)
        TxtVar2.Name = "TxtVar2"
        TxtVar2.Size = New Size(100, 23)
        TxtVar2.TabIndex = 1
        ' 
        ' TxtHasil
        ' 
        TxtHasil.Location = New Point(20, 136)
        TxtHasil.Name = "TxtHasil"
        TxtHasil.ReadOnly = True
        TxtHasil.Size = New Size(100, 23)
        TxtHasil.TabIndex = 2
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(RdbAkar)
        GroupBox1.Controls.Add(RdbPangkat)
        GroupBox1.Controls.Add(RdbPembagian)
        GroupBox1.Controls.Add(RdbPerkalian)
        GroupBox1.Controls.Add(RdbPenjumlahan)
        GroupBox1.Controls.Add(RdbPengurangan)
        GroupBox1.Location = New Point(207, 20)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(200, 203)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        GroupBox1.Text = "Operasi"
        ' 
        ' RdbAkar
        ' 
        RdbAkar.Location = New Point(10, 20)
        RdbAkar.Name = "RdbAkar"
        RdbAkar.Size = New Size(104, 24)
        RdbAkar.TabIndex = 0
        RdbAkar.Text = "Akar Kuadrad"
        ' 
        ' RdbPangkat
        ' 
        RdbPangkat.Location = New Point(10, 50)
        RdbPangkat.Name = "RdbPangkat"
        RdbPangkat.Size = New Size(104, 24)
        RdbPangkat.TabIndex = 1
        RdbPangkat.Text = "Pangkat"
        ' 
        ' RdbPembagian
        ' 
        RdbPembagian.Location = New Point(10, 80)
        RdbPembagian.Name = "RdbPembagian"
        RdbPembagian.Size = New Size(104, 24)
        RdbPembagian.TabIndex = 2
        RdbPembagian.Text = "Pembagian"
        ' 
        ' RdbPerkalian
        ' 
        RdbPerkalian.Location = New Point(10, 110)
        RdbPerkalian.Name = "RdbPerkalian"
        RdbPerkalian.Size = New Size(104, 24)
        RdbPerkalian.TabIndex = 3
        RdbPerkalian.Text = "Perkalian"
        ' 
        ' RdbPenjumlahan
        ' 
        RdbPenjumlahan.Location = New Point(10, 140)
        RdbPenjumlahan.Name = "RdbPenjumlahan"
        RdbPenjumlahan.Size = New Size(104, 24)
        RdbPenjumlahan.TabIndex = 4
        RdbPenjumlahan.Text = "Penjumlahan"
        ' 
        ' RdbPengurangan
        ' 
        RdbPengurangan.Location = New Point(10, 170)
        RdbPengurangan.Name = "RdbPengurangan"
        RdbPengurangan.Size = New Size(104, 24)
        RdbPengurangan.TabIndex = 5
        RdbPengurangan.Text = "Pengurangan"
        ' 
        ' BtnHitung
        ' 
        BtnHitung.Location = New Point(20, 180)
        BtnHitung.Name = "BtnHitung"
        BtnHitung.Size = New Size(75, 23)
        BtnHitung.TabIndex = 4
        BtnHitung.Text = "Hitung"
        ' 
        ' BtnExit
        ' 
        BtnExit.Location = New Point(100, 180)
        BtnExit.Name = "BtnExit"
        BtnExit.Size = New Size(75, 23)
        BtnExit.TabIndex = 5
        BtnExit.Text = "Exit"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TxtVar1)
        Controls.Add(TxtVar2)
        Controls.Add(TxtHasil)
        Controls.Add(GroupBox1)
        Controls.Add(BtnHitung)
        Controls.Add(BtnExit)
        Name = "Form2"
        Text = "Operasi Matematika"
        GroupBox1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    ' Event handler untuk tombol Hitung
    Private Sub BtnHitung_Click(sender As Object, e As EventArgs)
        Dim var1 As Double
        Dim var2 As Double
        Dim hasil As Double

        ' Validasi input
        If Not Double.TryParse(TxtVar1.Text, var1) Or Not Double.TryParse(TxtVar2.Text, var2) Then
            MessageBox.Show("Masukkan angka yang valid.")
            Return
        End If

        ' Cek operasi yang dipilih
        If RdbAkar.Checked Then
            hasil = Math.Sqrt(var1)
        ElseIf RdbPangkat.Checked Then
            hasil = var1 ^ var2
        ElseIf RdbPembagian.Checked Then
            If var2 = 0 Then
                MessageBox.Show("Tidak dapat membagi dengan nol.")
                Return
            End If
            hasil = var1 / var2
        ElseIf RdbPerkalian.Checked Then
            hasil = var1 * var2
        ElseIf RdbPenjumlahan.Checked Then
            hasil = var1 + var2
        ElseIf RdbPengurangan.Checked Then
            hasil = var1 - var2
        End If

        ' Tampilkan hasil
        TxtHasil.Text = hasil.ToString()
    End Sub

    ' Event handler untuk tombol Exit
    Private Sub BtnExit_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Friend WithEvents TxtVar1 As TextBox
    Friend WithEvents TxtVar2 As TextBox
    Friend WithEvents TxtHasil As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RdbAkar As RadioButton
    Friend WithEvents RdbPangkat As RadioButton
    Friend WithEvents RdbPembagian As RadioButton
    Friend WithEvents RdbPerkalian As RadioButton
    Friend WithEvents RdbPenjumlahan As RadioButton
    Friend WithEvents RdbPengurangan As RadioButton
    Friend WithEvents BtnHitung As Button
    Friend WithEvents BtnExit As Button
End Class
