Imports System.ComponentModel





Public Class Form2

    Inherits Form

    Private currentBorderColor As Color = Color.Blue
    Private textTotal As String = ""

    ' 親から受け取るプロパティ（デザイナ非表示）
    <Browsable(False)>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property ReceivedText As String

    ' 親に返すプロパティ（デザイナ非表示）
    <Browsable(False)>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property ReturnedText As String

    Public Sub New()
        InitializeComponent()
        Me.Size = New Size(1280, 800)
        Me.FormBorderStyle = FormBorderStyle.None
        Me.Padding = New Padding(5)
        Me.StartPosition = FormStartPosition.CenterScreen
        'メイン画面からセット'
        TextBox1.Text = ReceivedText

    End Sub

    Private Sub OKbutton_Click(sender As Object, e As EventArgs) Handles OKbutton.Click
        ReturnedText = TextBox1.Text
        Me.Close()
    End Sub
End Class