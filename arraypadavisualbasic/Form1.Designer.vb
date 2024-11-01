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
        TxtNIM = New TextBox()
        TxtNama = New TextBox()
        TxtProdi = New TextBox()
        BtnTambah = New Button()
        ListView1 = New ListView()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(72, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(30, 15)
        Label1.TabIndex = 0
        Label1.Text = "NIM"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(72, 74)
        Label2.Name = "Label2"
        Label2.Size = New Size(39, 15)
        Label2.TabIndex = 1
        Label2.Text = "Nama"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(72, 121)
        Label3.Name = "Label3"
        Label3.Size = New Size(35, 15)
        Label3.TabIndex = 2
        Label3.Text = "Prodi"
        ' 
        ' TxtNIM
        ' 
        TxtNIM.Location = New Point(170, 35)
        TxtNIM.Name = "TxtNIM"
        TxtNIM.Size = New Size(100, 23)
        TxtNIM.TabIndex = 3
        ' 
        ' TxtNama
        ' 
        TxtNama.Location = New Point(170, 74)
        TxtNama.Name = "TxtNama"
        TxtNama.Size = New Size(100, 23)
        TxtNama.TabIndex = 4
        ' 
        ' TxtProdi
        ' 
        TxtProdi.Location = New Point(170, 121)
        TxtProdi.Name = "TxtProdi"
        TxtProdi.Size = New Size(100, 23)
        TxtProdi.TabIndex = 5
        ' 
        ' BtnTambah
        ' 
        BtnTambah.Location = New Point(195, 177)
        BtnTambah.Name = "BtnTambah"
        BtnTambah.Size = New Size(75, 23)
        BtnTambah.TabIndex = 6
        BtnTambah.Text = "Tambah"
        BtnTambah.UseVisualStyleBackColor = True
        ' 
        ' ListView1
        ' 
        ListView1.Location = New Point(62, 267)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(455, 125)
        ListView1.TabIndex = 7
        ListView1.UseCompatibleStateImageBehavior = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ListView1)
        Controls.Add(BtnTambah)
        Controls.Add(TxtProdi)
        Controls.Add(TxtNama)
        Controls.Add(TxtNIM)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Array Satu Dimensi"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtNIM As TextBox
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents TxtProdi As TextBox
    Friend WithEvents BtnTambah As Button
    Friend WithEvents ListView1 As ListView

End Class
