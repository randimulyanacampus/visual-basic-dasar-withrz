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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        TxtNIM = New TextBox()
        TxtNama = New TextBox()
        CmbKelamin = New ComboBox()
        CmbProdi = New ComboBox()
        BtnProses = New Button()
        ListView1 = New ListView()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(50, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(30, 15)
        Label1.TabIndex = 0
        Label1.Text = "NIM"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(50, 76)
        Label2.Name = "Label2"
        Label2.Size = New Size(43, 15)
        Label2.TabIndex = 1
        Label2.Text = "NAMA"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(50, 122)
        Label3.Name = "Label3"
        Label3.Size = New Size(57, 15)
        Label3.TabIndex = 2
        Label3.Text = "KELAMIN"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(50, 172)
        Label4.Name = "Label4"
        Label4.Size = New Size(41, 15)
        Label4.TabIndex = 3
        Label4.Text = "PRODI"
        ' 
        ' TxtNIM
        ' 
        TxtNIM.Location = New Point(184, 31)
        TxtNIM.Name = "TxtNIM"
        TxtNIM.Size = New Size(100, 23)
        TxtNIM.TabIndex = 4
        ' 
        ' TxtNama
        ' 
        TxtNama.Location = New Point(184, 76)
        TxtNama.Name = "TxtNama"
        TxtNama.Size = New Size(100, 23)
        TxtNama.TabIndex = 5
        ' 
        ' CmbKelamin
        ' 
        CmbKelamin.FormattingEnabled = True
        CmbKelamin.Location = New Point(184, 122)
        CmbKelamin.Name = "CmbKelamin"
        CmbKelamin.Size = New Size(121, 23)
        CmbKelamin.TabIndex = 6
        ' 
        ' CmbProdi
        ' 
        CmbProdi.FormattingEnabled = True
        CmbProdi.Location = New Point(184, 172)
        CmbProdi.Name = "CmbProdi"
        CmbProdi.Size = New Size(121, 23)
        CmbProdi.TabIndex = 7
        ' 
        ' BtnProses
        ' 
        BtnProses.Location = New Point(230, 223)
        BtnProses.Name = "BtnProses"
        BtnProses.Size = New Size(75, 23)
        BtnProses.TabIndex = 8
        BtnProses.Text = "Proses"
        BtnProses.UseVisualStyleBackColor = True
        ' 
        ' ListView1
        ' 
        ListView1.Location = New Point(51, 293)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(439, 133)
        ListView1.TabIndex = 9
        ListView1.UseCompatibleStateImageBehavior = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ListView1)
        Controls.Add(BtnProses)
        Controls.Add(CmbProdi)
        Controls.Add(CmbKelamin)
        Controls.Add(TxtNama)
        Controls.Add(TxtNIM)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form2"
        Text = "Array Multi Dimensi"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtNIM As TextBox
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents CmbKelamin As ComboBox
    Friend WithEvents CmbProdi As ComboBox
    Friend WithEvents BtnProses As Button
    Friend WithEvents ListView1 As ListView
End Class
