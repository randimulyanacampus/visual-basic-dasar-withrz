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
        TxtNilai1 = New TextBox()
        TxtNilai2 = New TextBox()
        TxtHasil = New TextBox()
        CmbOperator = New ComboBox()
        BtnProses = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(40, 49)
        Label1.Name = "Label1"
        Label1.Size = New Size(37, 15)
        Label1.TabIndex = 0
        Label1.Text = "Nilai1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(40, 147)
        Label2.Name = "Label2"
        Label2.Size = New Size(37, 15)
        Label2.TabIndex = 1
        Label2.Text = "Nilai2"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(40, 103)
        Label3.Name = "Label3"
        Label3.Size = New Size(54, 15)
        Label3.TabIndex = 2
        Label3.Text = "Operator"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(40, 209)
        Label4.Name = "Label4"
        Label4.Size = New Size(33, 15)
        Label4.TabIndex = 3
        Label4.Text = "Hasil"
        ' 
        ' TxtNilai1
        ' 
        TxtNilai1.Location = New Point(163, 41)
        TxtNilai1.Name = "TxtNilai1"
        TxtNilai1.Size = New Size(100, 23)
        TxtNilai1.TabIndex = 4
        ' 
        ' TxtNilai2
        ' 
        TxtNilai2.Location = New Point(163, 144)
        TxtNilai2.Name = "TxtNilai2"
        TxtNilai2.Size = New Size(100, 23)
        TxtNilai2.TabIndex = 5
        ' 
        ' TxtHasil
        ' 
        TxtHasil.Location = New Point(163, 201)
        TxtHasil.Name = "TxtHasil"
        TxtHasil.Size = New Size(100, 23)
        TxtHasil.TabIndex = 6
        ' 
        ' CmbOperator
        ' 
        CmbOperator.FormattingEnabled = True
        CmbOperator.Location = New Point(163, 95)
        CmbOperator.Name = "CmbOperator"
        CmbOperator.Size = New Size(121, 23)
        CmbOperator.TabIndex = 7
        ' 
        ' BtnProses
        ' 
        BtnProses.Location = New Point(217, 255)
        BtnProses.Name = "BtnProses"
        BtnProses.Size = New Size(75, 23)
        BtnProses.TabIndex = 8
        BtnProses.Text = "Proses"
        BtnProses.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(BtnProses)
        Controls.Add(CmbOperator)
        Controls.Add(TxtHasil)
        Controls.Add(TxtNilai2)
        Controls.Add(TxtNilai1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Operator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtNilai1 As TextBox
    Friend WithEvents TxtNilai2 As TextBox
    Friend WithEvents TxtHasil As TextBox
    Friend WithEvents CmbOperator As ComboBox
    Friend WithEvents BtnProses As Button

End Class
