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
        CmbTgl = New ComboBox()
        CmbBln = New ComboBox()
        CmbThn = New ComboBox()
        close = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(104, 115)
        Label1.Name = "Label1"
        Label1.Size = New Size(87, 15)
        Label1.TabIndex = 0
        Label1.Text = "Tgl/Bln/Tahun :"
        ' 
        ' CmbTgl
        ' 
        CmbTgl.FormattingEnabled = True
        CmbTgl.Location = New Point(229, 112)
        CmbTgl.Name = "CmbTgl"
        CmbTgl.Size = New Size(121, 23)
        CmbTgl.TabIndex = 1
        ' 
        ' CmbBln
        ' 
        CmbBln.FormattingEnabled = True
        CmbBln.Location = New Point(380, 112)
        CmbBln.Name = "CmbBln"
        CmbBln.Size = New Size(121, 23)
        CmbBln.TabIndex = 2
        ' 
        ' CmbThn
        ' 
        CmbThn.FormattingEnabled = True
        CmbThn.Location = New Point(533, 112)
        CmbThn.Name = "CmbThn"
        CmbThn.Size = New Size(121, 23)
        CmbThn.TabIndex = 3
        ' 
        ' close
        ' 
        close.Location = New Point(579, 171)
        close.Name = "close"
        close.Size = New Size(75, 23)
        close.TabIndex = 4
        close.Text = "Keluar"
        close.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(726, 285)
        Controls.Add(close)
        Controls.Add(CmbThn)
        Controls.Add(CmbBln)
        Controls.Add(CmbTgl)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Perulangan FOR"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents CmbTgl As ComboBox
    Friend WithEvents CmbBln As ComboBox
    Friend WithEvents CmbThn As ComboBox
    Friend WithEvents close As Button

End Class
