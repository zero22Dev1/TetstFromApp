<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        ReturnButton = New Button()
        OKButton = New Button()
        NoButton = New Button()
        Label1 = New Label()
        TitleLable = New Label()
        SuspendLayout()
        ' 
        ' ReturnButton
        ' 
        ReturnButton.Font = New Font("Yu Gothic UI", 22.0F, FontStyle.Bold)
        ReturnButton.Location = New Point(494, 560)
        ReturnButton.Name = "ReturnButton"
        ReturnButton.Size = New Size(284, 117)
        ReturnButton.TabIndex = 1
        ReturnButton.Text = "戻る"
        ReturnButton.UseVisualStyleBackColor = True
        ' 
        ' OKButton
        ' 
        OKButton.Font = New Font("Yu Gothic UI", 22.0F, FontStyle.Bold)
        OKButton.Location = New Point(138, 560)
        OKButton.Name = "OKButton"
        OKButton.Size = New Size(285, 117)
        OKButton.TabIndex = 1
        OKButton.Text = "OK"
        OKButton.UseVisualStyleBackColor = True
        ' 
        ' NoButton
        ' 
        NoButton.Font = New Font("Yu Gothic UI", 22.0F, FontStyle.Bold)
        NoButton.Location = New Point(863, 564)
        NoButton.Name = "NoButton"
        NoButton.Size = New Size(285, 108)
        NoButton.TabIndex = 1
        NoButton.Text = "NO"
        NoButton.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.Location = New Point(268, 317)
        Label1.Name = "Label1"
        Label1.Size = New Size(644, 86)
        Label1.TabIndex = 2
        Label1.Text = "ああああああああああああああああああああああああああああああああああああああああああああああああ"
        ' 
        ' TitleLable
        ' 
        TitleLable.Font = New Font("Yu Gothic UI", 22.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        TitleLable.Location = New Point(289, 93)
        TitleLable.Name = "TitleLable"
        TitleLable.Size = New Size(582, 85)
        TitleLable.TabIndex = 3
        TitleLable.Text = "Label2"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1258, 744)
        Controls.Add(TitleLable)
        Controls.Add(Label1)
        Controls.Add(OKButton)
        Controls.Add(NoButton)
        Controls.Add(ReturnButton)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub
    Friend WithEvents ReturnButton As Button
    Friend WithEvents OKButton As Button
    Friend WithEvents NoButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TitleLable As Label

End Class
