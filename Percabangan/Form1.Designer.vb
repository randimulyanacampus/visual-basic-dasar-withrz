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
        Btn_if = New Button()
        Btn_if_else = New Button()
        Btn_case = New Button()
        SuspendLayout()
        ' 
        ' Btn_if
        ' 
        Btn_if.Location = New Point(216, 84)
        Btn_if.Name = "Btn_if"
        Btn_if.Size = New Size(91, 23)
        Btn_if.TabIndex = 0
        Btn_if.Text = "IF.. ENDIF"
        Btn_if.UseVisualStyleBackColor = True
        ' 
        ' Btn_if_else
        ' 
        Btn_if_else.Location = New Point(203, 167)
        Btn_if_else.Name = "Btn_if_else"
        Btn_if_else.Size = New Size(104, 23)
        Btn_if_else.TabIndex = 1
        Btn_if_else.Text = "IF.. ELSE.. ENDIF"
        Btn_if_else.UseVisualStyleBackColor = True
        ' 
        ' Btn_case
        ' 
        Btn_case.Location = New Point(179, 226)
        Btn_case.Name = "Btn_case"
        Btn_case.Size = New Size(137, 26)
        Btn_case.TabIndex = 2
        Btn_case.Text = "CASE.. ENDCASE"
        Btn_case.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Btn_case)
        Controls.Add(Btn_if_else)
        Controls.Add(Btn_if)
        Name = "Form1"
        Text = "Pencabangan IF"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Btn_if As Button
    Friend WithEvents Btn_if_else As Button
    Friend WithEvents Btn_case As Button

End Class
