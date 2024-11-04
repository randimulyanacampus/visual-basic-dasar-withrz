<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        TxtKodeBrg = New TextBox()
        TxtNamaBrg = New TextBox()
        TxtSatuan = New TextBox()
        TxtHrgSatuan = New TextBox()
        TxtHarga = New TextBox()
        TxtTot = New TextBox()
        BtnExit = New Button()
        BtnHitung = New Button()
        BtnClear = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(34, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(74, 15)
        Label1.TabIndex = 0
        Label1.Text = "Kode Barang"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(34, 68)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 15)
        Label2.TabIndex = 1
        Label2.Text = "Nama Barang"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(34, 106)
        Label3.Name = "Label3"
        Label3.Size = New Size(43, 15)
        Label3.TabIndex = 2
        Label3.Text = "Satuan"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(34, 143)
        Label4.Name = "Label4"
        Label4.Size = New Size(78, 15)
        Label4.TabIndex = 3
        Label4.Text = "Harga Satuan"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(34, 183)
        Label5.Name = "Label5"
        Label5.Size = New Size(45, 15)
        Label5.TabIndex = 4
        Label5.Text = "Jumlah"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(34, 225)
        Label6.Name = "Label6"
        Label6.Size = New Size(67, 15)
        Label6.TabIndex = 5
        Label6.Text = "Total Harga"
        ' 
        ' TxtKodeBrg
        ' 
        TxtKodeBrg.Location = New Point(179, 30)
        TxtKodeBrg.Name = "TxtKodeBrg"
        TxtKodeBrg.Size = New Size(145, 23)
        TxtKodeBrg.TabIndex = 6
        ' 
        ' TxtNamaBrg
        ' 
        TxtNamaBrg.Location = New Point(179, 68)
        TxtNamaBrg.Name = "TxtNamaBrg"
        TxtNamaBrg.Size = New Size(277, 23)
        TxtNamaBrg.TabIndex = 7
        ' 
        ' TxtSatuan
        ' 
        TxtSatuan.Location = New Point(179, 106)
        TxtSatuan.Name = "TxtSatuan"
        TxtSatuan.Size = New Size(145, 23)
        TxtSatuan.TabIndex = 8
        ' 
        ' TxtHrgSatuan
        ' 
        TxtHrgSatuan.Location = New Point(179, 143)
        TxtHrgSatuan.Name = "TxtHrgSatuan"
        TxtHrgSatuan.Size = New Size(145, 23)
        TxtHrgSatuan.TabIndex = 9
        ' 
        ' TxtHarga
        ' 
        TxtHarga.Location = New Point(179, 183)
        TxtHarga.Name = "TxtHarga"
        TxtHarga.Size = New Size(145, 23)
        TxtHarga.TabIndex = 10
        ' 
        ' TxtTot
        ' 
        TxtTot.Location = New Point(179, 225)
        TxtTot.Name = "TxtTot"
        TxtTot.Size = New Size(145, 23)
        TxtTot.TabIndex = 11
        ' 
        ' BtnExit
        ' 
        BtnExit.Location = New Point(381, 308)
        BtnExit.Name = "BtnExit"
        BtnExit.Size = New Size(75, 23)
        BtnExit.TabIndex = 12
        BtnExit.Text = "Exit"
        BtnExit.UseVisualStyleBackColor = True
        ' 
        ' BtnHitung
        ' 
        BtnHitung.Location = New Point(179, 308)
        BtnHitung.Name = "BtnHitung"
        BtnHitung.Size = New Size(75, 23)
        BtnHitung.TabIndex = 13
        BtnHitung.Text = "Hitung"
        BtnHitung.UseVisualStyleBackColor = True
        ' 
        ' BtnClear
        ' 
        BtnClear.Location = New Point(270, 308)
        BtnClear.Name = "BtnClear"
        BtnClear.Size = New Size(75, 23)
        BtnClear.TabIndex = 14
        BtnClear.Text = "Clear"
        BtnClear.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(737, 450)
        Controls.Add(BtnClear)
        Controls.Add(BtnHitung)
        Controls.Add(BtnExit)
        Controls.Add(TxtTot)
        Controls.Add(TxtHarga)
        Controls.Add(TxtHrgSatuan)
        Controls.Add(TxtSatuan)
        Controls.Add(TxtNamaBrg)
        Controls.Add(TxtKodeBrg)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "BARANG"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtKodeBrg As TextBox
    Friend WithEvents TxtNamaBrg As TextBox
    Friend WithEvents TxtSatuan As TextBox
    Friend WithEvents TxtHrgSatuan As TextBox
    Friend WithEvents TxtHarga As TextBox
    Friend WithEvents TxtTot As TextBox
    Friend WithEvents BtnExit As Button
    Friend WithEvents BtnHitung As Button
    Friend WithEvents BtnClear As Button

End Class
