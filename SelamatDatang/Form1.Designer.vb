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
        lblText = New Label()
        SuspendLayout()
        ' 
        ' lblText
        ' 
        lblText.AutoSize = True
        lblText.Location = New Point(286, 89)
        lblText.Name = "lblText"
        lblText.Size = New Size(41, 15)
        lblText.TabIndex = 0
        lblText.Text = "Label1"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblText)
        Name = "Form1"
        Text = "Latihan Visual Basic"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblText As Label

End Class
