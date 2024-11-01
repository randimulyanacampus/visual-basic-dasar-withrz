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
        TxtBatas = New TextBox()
        ListBox1 = New ListBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(63, 58)
        Label1.Name = "Label1"
        Label1.Size = New Size(35, 15)
        Label1.TabIndex = 0
        Label1.Text = "Batas"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(65, 100)
        Label2.Name = "Label2"
        Label2.Size = New Size(61, 15)
        Label2.TabIndex = 1
        Label2.Text = "Tampilkan"
        ' 
        ' TxtBatas
        ' 
        TxtBatas.Location = New Point(194, 55)
        TxtBatas.Name = "TxtBatas"
        TxtBatas.Size = New Size(151, 23)
        TxtBatas.TabIndex = 2
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(192, 109)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(154, 199)
        ListBox1.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(271, 324)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 4
        Button1.Text = "Proses"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(ListBox1)
        Controls.Add(TxtBatas)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtBatas As TextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button1 As Button

End Class
