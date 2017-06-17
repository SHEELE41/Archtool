Public Class main_form

    Private Sub ParseBIButton_Click(sender As Object, e As EventArgs) Handles ParseBIButton.Click
        With Target_Building    'Fill Information of Target Building
            .sigunguCd = TB_sigunguCd.Text
            .bjdongCd = TB_bjdongCd.Text
            .bun = TB_bun.Text
            .ji = TB_ji.Text
        End With

        basicinfo_form.Show()   'Show Second Form
    End Sub

    Private Sub search_code_button_Click(sender As Object, e As EventArgs) Handles search_code_button.Click
        search_code_form.Show()
    End Sub
End Class
