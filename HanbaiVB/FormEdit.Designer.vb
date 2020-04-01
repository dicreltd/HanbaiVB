<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEdit
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
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.textBoxTanka = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.textBoxSname = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'button2
        '
        Me.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.button2.Location = New System.Drawing.Point(185, 120)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(75, 23)
        Me.button2.TabIndex = 11
        Me.button2.Text = "キャンセル"
        Me.button2.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.button1.Location = New System.Drawing.Point(47, 120)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(75, 23)
        Me.button1.TabIndex = 10
        Me.button1.Text = "OK"
        Me.button1.UseVisualStyleBackColor = True
        '
        'textBoxTanka
        '
        Me.textBoxTanka.Location = New System.Drawing.Point(102, 57)
        Me.textBoxTanka.Name = "textBoxTanka"
        Me.textBoxTanka.Size = New System.Drawing.Size(100, 22)
        Me.textBoxTanka.TabIndex = 9
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(28, 60)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(37, 15)
        Me.label2.TabIndex = 8
        Me.label2.Text = "単価"
        '
        'textBoxSname
        '
        Me.textBoxSname.Location = New System.Drawing.Point(101, 18)
        Me.textBoxSname.Name = "textBoxSname"
        Me.textBoxSname.Size = New System.Drawing.Size(100, 22)
        Me.textBoxSname.TabIndex = 7
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(21, 21)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(52, 15)
        Me.label1.TabIndex = 6
        Me.label1.Text = "商品名"
        '
        'FormEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(294, 178)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.textBoxTanka)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.textBoxSname)
        Me.Controls.Add(Me.label1)
        Me.Name = "FormEdit"
        Me.Text = "商品"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents button2 As Button
    Private WithEvents button1 As Button
    Private WithEvents textBoxTanka As TextBox
    Private WithEvents label2 As Label
    Private WithEvents textBoxSname As TextBox
    Private WithEvents label1 As Label
End Class
