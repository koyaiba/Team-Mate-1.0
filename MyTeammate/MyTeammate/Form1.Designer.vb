<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ReplyBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAns = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ReplyBox
        '
        Me.ReplyBox.Location = New System.Drawing.Point(42, 52)
        Me.ReplyBox.Multiline = True
        Me.ReplyBox.Name = "ReplyBox"
        Me.ReplyBox.Size = New System.Drawing.Size(257, 54)
        Me.ReplyBox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(243, 12)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Team Mate: When will you complete your part?"
        '
        'btnAns
        '
        Me.btnAns.Location = New System.Drawing.Point(305, 83)
        Me.btnAns.Name = "btnAns"
        Me.btnAns.Size = New System.Drawing.Size(75, 23)
        Me.btnAns.TabIndex = 2
        Me.btnAns.Text = "Answer"
        Me.btnAns.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(401, 131)
        Me.Controls.Add(Me.btnAns)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ReplyBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReplyBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAns As Button
End Class
