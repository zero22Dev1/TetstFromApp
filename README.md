```vbnet
Private Sub C1FlexGrid1_CellChecked(sender As Object, e As RowColEventArgs) Handles C1FlexGrid1.CellChecked
    ' チェックボックス列の列インデックス取得（例："選択"列）
    Dim checkColIndex As Integer = -1
    For col As Integer = C1FlexGrid1.Cols.Fixed To C1FlexGrid1.Cols.Count - 1
        If C1FlexGrid1(0, col).ToString() = "選択" Then
            checkColIndex = col
            Exit For
        End If
    Next

    If checkColIndex = -1 Then Exit Sub

    Dim row As Integer = e.Row
    Dim isChecked As Boolean = C1FlexGrid1(row, checkColIndex)

    ' スタイルを作成または取得
    Dim checkedStyle = C1FlexGrid1.Styles("CheckedRow")
    If checkedStyle Is Nothing Then
        checkedStyle = C1FlexGrid1.Styles.Add("CheckedRow")
        checkedStyle.BackColor = Color.LightGreen
    End If

    ' チェックされたら背景色を変える
    If isChecked Then
        C1FlexGrid1.Rows(row).Style = checkedStyle
    Else
        ' チェックを外した場合はスタイルを戻す
        C1FlexGrid1.Rows(row).Style = Nothing
    End If
End Sub
```


```vbnet
' 対象列名を配列で定義
Dim targetColNames As String() = {"金額", "調整額", "割引額"}

' 赤文字スタイルを作成（なければ）
Dim redTextStyle = C1FlexGrid1.Styles("NegativeValueTextStyle")
If redTextStyle Is Nothing Then
    redTextStyle = C1FlexGrid1.Styles.Add("NegativeValueTextStyle")
    redTextStyle.ForeColor = Color.Red
End If

' 列名からインデックスを特定するディクショナリを作成
Dim targetColIndices As New List(Of Integer)

For col As Integer = C1FlexGrid1.Cols.Fixed To C1FlexGrid1.Cols.Count - 1
    Dim header As String = C1FlexGrid1(0, col).ToString()
    If targetColNames.Contains(header) Then
        targetColIndices.Add(col)
    End If
Next

' 各行の対象列をチェックして処理
For row As Integer = C1FlexGrid1.Rows.Fixed To C1FlexGrid1.Rows.Count - 1
    For Each col In targetColIndices
        Dim value As Double
        If Double.TryParse(C1FlexGrid1(row, col).ToString(), value) Then
            If value < 0 Then
                ' 値を正にしてセット
                C1FlexGrid1(row, col) = Math.Abs(value)
                ' 赤文字スタイル適用
                C1FlexGrid1.SetCellStyle(row, col, redTextStyle)
            End If
        End If
    Next
Next
```