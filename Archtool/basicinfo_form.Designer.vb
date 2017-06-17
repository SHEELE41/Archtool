<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class basicinfo_form
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.CB_Date = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ResultMsg = New System.Windows.Forms.Label()
        Me.ShowAllButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TB_bldNm = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TB_archGbCdNm = New System.Windows.Forms.TextBox()
        Me.TB_platArea = New System.Windows.Forms.TextBox()
        Me.TB_archArea = New System.Windows.Forms.TextBox()
        Me.TB_bcRat = New System.Windows.Forms.TextBox()
        Me.TB_vlRat = New System.Windows.Forms.TextBox()
        Me.TB_mainPurpsCdNm = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LB_Address = New System.Windows.Forms.Label()
        Me.WB_RoadView = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
        '
        'CB_Date
        '
        Me.CB_Date.FormattingEnabled = True
        Me.CB_Date.Location = New System.Drawing.Point(112, 62)
        Me.CB_Date.Name = "CB_Date"
        Me.CB_Date.Size = New System.Drawing.Size(121, 20)
        Me.CB_Date.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 12)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "건축허가일"
        '
        'ResultMsg
        '
        Me.ResultMsg.AutoSize = True
        Me.ResultMsg.Font = New System.Drawing.Font("굴림", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.ResultMsg.Location = New System.Drawing.Point(280, 27)
        Me.ResultMsg.Name = "ResultMsg"
        Me.ResultMsg.Size = New System.Drawing.Size(203, 19)
        Me.ResultMsg.TabIndex = 2
        Me.ResultMsg.Text = "건축인허가 정보 요약"
        '
        'ShowAllButton
        '
        Me.ShowAllButton.Location = New System.Drawing.Point(576, 505)
        Me.ShowAllButton.Name = "ShowAllButton"
        Me.ShowAllButton.Size = New System.Drawing.Size(174, 23)
        Me.ShowAllButton.TabIndex = 3
        Me.ShowAllButton.Text = "전체 정보 보기"
        Me.ShowAllButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(433, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 12)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "건물명"
        '
        'TB_bldNm
        '
        Me.TB_bldNm.Location = New System.Drawing.Point(496, 124)
        Me.TB_bldNm.Name = "TB_bldNm"
        Me.TB_bldNm.Size = New System.Drawing.Size(214, 21)
        Me.TB_bldNm.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(421, 235)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 12)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "대지면적"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(421, 289)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 12)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "건축면적"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(433, 343)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 12)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "건폐율"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(433, 397)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 12)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "용적률"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(429, 451)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 12)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "주 용도"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(417, 181)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 12)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "건축 구분"
        '
        'TB_archGbCdNm
        '
        Me.TB_archGbCdNm.Location = New System.Drawing.Point(496, 178)
        Me.TB_archGbCdNm.Name = "TB_archGbCdNm"
        Me.TB_archGbCdNm.Size = New System.Drawing.Size(214, 21)
        Me.TB_archGbCdNm.TabIndex = 6
        '
        'TB_platArea
        '
        Me.TB_platArea.Location = New System.Drawing.Point(496, 232)
        Me.TB_platArea.Name = "TB_platArea"
        Me.TB_platArea.Size = New System.Drawing.Size(214, 21)
        Me.TB_platArea.TabIndex = 6
        '
        'TB_archArea
        '
        Me.TB_archArea.Location = New System.Drawing.Point(496, 286)
        Me.TB_archArea.Name = "TB_archArea"
        Me.TB_archArea.Size = New System.Drawing.Size(214, 21)
        Me.TB_archArea.TabIndex = 6
        '
        'TB_bcRat
        '
        Me.TB_bcRat.Location = New System.Drawing.Point(496, 340)
        Me.TB_bcRat.Name = "TB_bcRat"
        Me.TB_bcRat.Size = New System.Drawing.Size(214, 21)
        Me.TB_bcRat.TabIndex = 6
        '
        'TB_vlRat
        '
        Me.TB_vlRat.Location = New System.Drawing.Point(496, 394)
        Me.TB_vlRat.Name = "TB_vlRat"
        Me.TB_vlRat.Size = New System.Drawing.Size(214, 21)
        Me.TB_vlRat.TabIndex = 6
        '
        'TB_mainPurpsCdNm
        '
        Me.TB_mainPurpsCdNm.Location = New System.Drawing.Point(496, 448)
        Me.TB_mainPurpsCdNm.Name = "TB_mainPurpsCdNm"
        Me.TB_mainPurpsCdNm.Size = New System.Drawing.Size(214, 21)
        Me.TB_mainPurpsCdNm.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(32, 126)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(29, 12)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "주소"
        '
        'LB_Address
        '
        Me.LB_Address.AutoSize = True
        Me.LB_Address.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.LB_Address.Location = New System.Drawing.Point(69, 126)
        Me.LB_Address.Name = "LB_Address"
        Me.LB_Address.Size = New System.Drawing.Size(10, 12)
        Me.LB_Address.TabIndex = 8
        Me.LB_Address.Text = " "
        '
        'WB_RoadView
        '
        Me.WB_RoadView.Location = New System.Drawing.Point(34, 156)
        Me.WB_RoadView.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WB_RoadView.Name = "WB_RoadView"
        Me.WB_RoadView.ScrollBarsEnabled = False
        Me.WB_RoadView.Size = New System.Drawing.Size(344, 313)
        Me.WB_RoadView.TabIndex = 9
        Me.WB_RoadView.Url = New System.Uri("", System.UriKind.Relative)
        '
        'basicinfo_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 540)
        Me.Controls.Add(Me.WB_RoadView)
        Me.Controls.Add(Me.LB_Address)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TB_mainPurpsCdNm)
        Me.Controls.Add(Me.TB_vlRat)
        Me.Controls.Add(Me.TB_bcRat)
        Me.Controls.Add(Me.TB_archArea)
        Me.Controls.Add(Me.TB_platArea)
        Me.Controls.Add(Me.TB_archGbCdNm)
        Me.Controls.Add(Me.TB_bldNm)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ShowAllButton)
        Me.Controls.Add(Me.ResultMsg)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CB_Date)
        Me.Name = "basicinfo_form"
        Me.Text = "건축인허가 정보 조회"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CB_Date As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ResultMsg As Label
    Friend WithEvents ShowAllButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TB_bldNm As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TB_archGbCdNm As TextBox
    Friend WithEvents TB_platArea As TextBox
    Friend WithEvents TB_archArea As TextBox
    Friend WithEvents TB_bcRat As TextBox
    Friend WithEvents TB_vlRat As TextBox
    Friend WithEvents TB_mainPurpsCdNm As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents LB_Address As Label
    Friend WithEvents WB_RoadView As WebBrowser
End Class
