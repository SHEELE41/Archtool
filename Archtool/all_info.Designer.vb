<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class all_info
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
        Me.TV_info = New System.Windows.Forms.TreeView()
        Me.SuspendLayout()
        '
        'TV_info
        '
        Me.TV_info.Location = New System.Drawing.Point(12, 12)
        Me.TV_info.Name = "TV_info"
        Me.TV_info.Size = New System.Drawing.Size(529, 508)
        Me.TV_info.TabIndex = 0
        '
        'all_info
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(553, 532)
        Me.Controls.Add(Me.TV_info)
        Me.Name = "all_info"
        Me.Text = "건축인허가 전체 정보"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TV_info As TreeView
End Class
