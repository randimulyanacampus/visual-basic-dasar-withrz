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
        TxtUserName = New TextBox()
        TxtPassword = New TextBox()
        BtnLogin = New Button()
        BtnCancel = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(61, 88)
        Label1.Name = "Label1"
        Label1.Size = New Size(65, 15)
        Label1.TabIndex = 0
        Label1.Text = "User Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(61, 153)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 15)
        Label2.TabIndex = 1
        Label2.Text = "Password"
        ' 
        ' TxtUserName
        ' 
        TxtUserName.Location = New Point(167, 80)
        TxtUserName.Name = "TxtUserName"
        TxtUserName.Size = New Size(100, 23)
        TxtUserName.TabIndex = 2
        ' 
        ' TxtPassword
        ' 
        TxtPassword.Location = New Point(167, 165)
        TxtPassword.Name = "TxtPassword"
        TxtPassword.PasswordChar = "*"c
        TxtPassword.Size = New Size(100, 23)
        TxtPassword.TabIndex = 3
        ' 
        ' BtnLogin
        ' 
        BtnLogin.Location = New Point(151, 226)
        BtnLogin.Name = "BtnLogin"
        BtnLogin.Size = New Size(75, 23)
        BtnLogin.TabIndex = 4
        BtnLogin.Text = "Login"
        BtnLogin.UseVisualStyleBackColor = True
        ' 
        ' BtnCancel
        ' 
        BtnCancel.Location = New Point(251, 226)
        BtnCancel.Name = "BtnCancel"
        BtnCancel.Size = New Size(75, 23)
        BtnCancel.TabIndex = 5
        BtnCancel.Text = "Cancel"
        BtnCancel.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(BtnCancel)
        Controls.Add(BtnLogin)
        Controls.Add(TxtPassword)
        Controls.Add(TxtUserName)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Pencabangan IF"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtUserName As TextBox
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents BtnLogin As Button
    Friend WithEvents BtnCancel As Button

End Class
