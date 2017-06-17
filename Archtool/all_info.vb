Public Class all_info
    Private Sub all_info_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim child_list As MSXML2.IXMLDOMNodeList

        If itemList.length > 0 Then     'Fill ComboBox As Date
            For i As Integer = 0 To itemList.length - 1
                TV_info.Nodes.Add(itemList.item(i).selectSingleNode("archPmsDay").text)
                child_list = itemList.item(i).childNodes
                For Each child As MSXML2.IXMLDOMNode In child_list
                    TV_info.Nodes.Item(i).Nodes.Add(child.nodeName & " : " & child.text)
                Next child
            Next i
        Else
            MsgBox("조회 가능한 건축인 정보가 존재하지 않습니다.")
            Close()
        End If
    End Sub
End Class