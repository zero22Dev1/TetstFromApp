<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MaiinForm
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        ProgressBar1 = New ProgressBar()
        TextBox1 = New TextBox()
        Button1 = New Button()
        TextBox2 = New TextBox()
        Label1 = New Label()
        TextBox3 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(660, 12)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(128, 24)
        ProgressBar1.TabIndex = 0
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(110, 84)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(651, 31)
        TextBox1.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(501, 376)
        Button1.Name = "Button1"
        Button1.Size = New Size(287, 62)
        Button1.TabIndex = 2
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(110, 190)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(651, 31)
        TextBox2.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(45, 53)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 25)
        Label1.TabIndex = 4
        Label1.Text = "Label1"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(110, 265)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(651, 31)
        TextBox3.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(45, 146)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 25)
        Label2.TabIndex = 4
        Label2.Text = "Label1"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(45, 236)
        Label3.Name = "Label3"
        Label3.Size = New Size(63, 25)
        Label3.TabIndex = 4
        Label3.Text = "Label1"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(45, 302)
        Button2.Name = "Button2"
        Button2.Size = New Size(146, 35)
        Button2.TabIndex = 5
        Button2.Text = "Button2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' MaiinForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1258, 744)
        Controls.Add(Button2)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        Controls.Add(ProgressBar1)
        Name = "MaiinForm"
        Text = "MaiinForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
End Class
