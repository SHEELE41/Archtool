<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class main_form
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TB_sigunguCd = New System.Windows.Forms.TextBox()
        Me.TB_bjdongCd = New System.Windows.Forms.TextBox()
        Me.TB_bun = New System.Windows.Forms.TextBox()
        Me.TB_ji = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ParseBIButton = New System.Windows.Forms.Button()
        Me.search_code_button = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(156, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 12)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "시군구 코드"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(155, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 12)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "법정동 코드"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(207, 184)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(17, 12)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "번"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(207, 225)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(17, 12)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "지"
        '
        'TB_sigunguCd
        '
        Me.TB_sigunguCd.Location = New System.Drawing.Point(239, 92)
        Me.TB_sigunguCd.Name = "TB_sigunguCd"
        Me.TB_sigunguCd.Size = New System.Drawing.Size(198, 21)
        Me.TB_sigunguCd.TabIndex = 5
        '
        'TB_bjdongCd
        '
        Me.TB_bjdongCd.Location = New System.Drawing.Point(239, 133)
        Me.TB_bjdongCd.Name = "TB_bjdongCd"
        Me.TB_bjdongCd.Size = New System.Drawing.Size(198, 21)
        Me.TB_bjdongCd.TabIndex = 5
        '
        'TB_bun
        '
        Me.TB_bun.Location = New System.Drawing.Point(239, 181)
        Me.TB_bun.Name = "TB_bun"
        Me.TB_bun.Size = New System.Drawing.Size(198, 21)
        Me.TB_bun.TabIndex = 5
        '
        'TB_ji
        '
        Me.TB_ji.Location = New System.Drawing.Point(239, 222)
        Me.TB_ji.Name = "TB_ji"
        Me.TB_ji.Size = New System.Drawing.Size(198, 21)
        Me.TB_ji.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("굴림", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label7.Location = New System.Drawing.Point(199, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(210, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "<<건물 기초 정보 입력>>"
        '
        'ParseBIButton
        '
        Me.ParseBIButton.Location = New System.Drawing.Point(148, 334)
        Me.ParseBIButton.Name = "ParseBIButton"
        Me.ParseBIButton.Size = New System.Drawing.Size(314, 36)
        Me.ParseBIButton.TabIndex = 7
        Me.ParseBIButton.Text = "건축인허가 정보 조회"
        Me.ParseBIButton.UseVisualStyleBackColor = True
        '
        'search_code_button
        '
        Me.search_code_button.Location = New System.Drawing.Point(449, 394)
        Me.search_code_button.Name = "search_code_button"
        Me.search_code_button.Size = New System.Drawing.Size(150, 23)
        Me.search_code_button.TabIndex = 8
        Me.search_code_button.Text = "행정 표준 코드 조회"
        Me.search_code_button.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(178, 266)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(253, 12)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "번지를 입력하실 때는 네글자로 입력해주세요!"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(130, 287)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(349, 12)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "(예시 : 12-34번지일 경우 번에 0012를, 지에 0034를 적어주세요)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 399)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(233, 12)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "시군구, 법정동 코드 : 행정 표준 코드 기준"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(53, 309)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(505, 12)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "(하이픈 없이 159번지 라고만 나와있을 경우에는 번에 0159, 지에 0000을 입력하시면 됩니다.)"
        '
        'main_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 424)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.search_code_button)
        Me.Controls.Add(Me.ParseBIButton)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TB_ji)
        Me.Controls.Add(Me.TB_bun)
        Me.Controls.Add(Me.TB_bjdongCd)
        Me.Controls.Add(Me.TB_sigunguCd)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "main_form"
        Me.Text = "ArchTool [Ver 1.0]"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TB_sigunguCd As TextBox
    Friend WithEvents TB_bjdongCd As TextBox
    Friend WithEvents TB_bun As TextBox
    Friend WithEvents TB_ji As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ParseBIButton As Button
    Friend WithEvents search_code_button As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
End Class
