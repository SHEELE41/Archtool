<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class search_code_form
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TB_Address = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LB_scd = New System.Windows.Forms.Label()
        Me.LB_bcd = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("굴림", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label1.Location = New System.Drawing.Point(74, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(456, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "주소를 입력해주세요(읍, 면, 동, 리, 가 까지)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(207, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(191, 12)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "(예시 : 서울특별시 종로구 혜화동)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(222, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(161, 12)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "띄어쓰기가 매우 중요합니다."
        '
        'TB_Address
        '
        Me.TB_Address.Location = New System.Drawing.Point(96, 155)
        Me.TB_Address.Name = "TB_Address"
        Me.TB_Address.Size = New System.Drawing.Size(412, 21)
        Me.TB_Address.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(193, 207)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(218, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "내 코드 조회하기"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(222, 290)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 12)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "시군구 코드 : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(222, 334)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 12)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "법정동 코드 : "
        '
        'LB_scd
        '
        Me.LB_scd.AutoSize = True
        Me.LB_scd.Location = New System.Drawing.Point(309, 290)
        Me.LB_scd.Name = "LB_scd"
        Me.LB_scd.Size = New System.Drawing.Size(0, 12)
        Me.LB_scd.TabIndex = 5
        '
        'LB_bcd
        '
        Me.LB_bcd.AutoSize = True
        Me.LB_bcd.Location = New System.Drawing.Point(309, 334)
        Me.LB_bcd.Name = "LB_bcd"
        Me.LB_bcd.Size = New System.Drawing.Size(0, 12)
        Me.LB_bcd.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(230, 400)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(217, 12)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "데이터 출처 : 행정표준코드 관리시스템"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(453, 400)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(141, 12)
        Me.LinkLabel1.TabIndex = 7
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "http://www.code.go.kr/"
        '
        'search_code_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(605, 421)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LB_bcd)
        Me.Controls.Add(Me.LB_scd)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TB_Address)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "search_code_form"
        Me.Text = "행정 표준 코드 조회"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TB_Address As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LB_scd As Label
    Friend WithEvents LB_bcd As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
