```vbnet
''' <summary>
''' 指定した recno に応じて FlexGrid の行を選択します。
''' recno = "0" の場合は先頭行、それ以外は一致する行を検索して選択。
''' </summary>
''' <param name="grid">対象の C1FlexGrid</param>
''' <param name="recno">"0" または recno 値</param>
Public Sub SelectRowByRecnoOrTop(grid As C1.Win.C1FlexGrid.C1FlexGrid, recno As String)
    Dim dataStartRow As Integer = grid.Rows.Fixed ' 通常は 2（ヘッダー行数）
    Dim targetRowIndex As Integer = -1

    If recno = "0" Then
        ' 先頭データ行を選択
        targetRowIndex = dataStartRow
    Else
        ' "recno" 列のインデックス取得（列名が "recno" の場合）
        Dim colRecnoIndex As Integer = grid.Cols("recno").Index

        ' データ行をループして一致する recno を探す
        For row As Integer = dataStartRow To grid.Rows.Count - 1
            If grid(row, colRecnoIndex).ToString() = recno Then
                targetRowIndex = row
                Exit For
            End If
        Next

        ' 見つからなければ先頭行にフォールバック
        If targetRowIndex = -1 Then
            targetRowIndex = dataStartRow
        End If
    End If

    ' 行全体を選択状態にする
    grid.Select(targetRowIndex, 0, targetRowIndex, grid.Cols.Count - 1)
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