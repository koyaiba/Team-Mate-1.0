﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.btnAns = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ReplyBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnAns
        '
        Me.btnAns.Location = New System.Drawing.Point(288, 84)
        Me.btnAns.Name = "btnAns"
        Me.btnAns.Size = New System.Drawing.Size(75, 23)
        Me.btnAns.TabIndex = 5
        Me.btnAns.Text = "Answer"
        Me.btnAns.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(243, 12)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Team Mate: When will you complete your part?"
        '
        'ReplyBox
        '
        Me.ReplyBox.Location = New System.Drawing.Point(25, 53)
        Me.ReplyBox.Multiline = True
        Me.ReplyBox.Name = "ReplyBox"
        Me.ReplyBox.Size = New System.Drawing.Size(257, 54)
        Me.ReplyBox.TabIndex = 3
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 135)
        Me.Controls.Add(Me.btnAns)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ReplyBox)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAns As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ReplyBox As TextBox
End Class
