Public Class search_code_form
    Dim content As String

    Private Sub search_code_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Open txt file
        Dim file As New System.IO.StreamReader("C:\code_data.txt")
        content = file.ReadToEnd()
        file.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim word_index As Integer = InStr(content, TB_Address.Text)  'get index where target sentence is placed
        If word_index > 10 Then
            Dim code_str As String = Mid(content, word_index - 11, 10)  'Parse code 10 words

            Dim sigunguCd As String = Microsoft.VisualBasic.Left(code_str, 5)
            Dim bjdongCd As String = Microsoft.VisualBasic.Right(code_str, 5)

            LB_scd.Text = sigunguCd
            LB_bcd.Text = bjdongCd
        Else
            LB_scd.Text = "정확한 주소를 입력해주세요!"
            LB_bcd.Text = "정확한 주소를 입력해주세요!"
        End If
    End Sub
End Class