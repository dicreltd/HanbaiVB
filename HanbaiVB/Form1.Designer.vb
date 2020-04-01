<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Me.buttonDel = New System.Windows.Forms.Button()
        Me.buttonEdit = New System.Windows.Forms.Button()
        Me.buttonAdd = New System.Windows.Forms.Button()
        Me.dataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'buttonDel
        '
        Me.buttonDel.Location = New System.Drawing.Point(365, 99)
        Me.buttonDel.Name = "buttonDel"
        Me.buttonDel.Size = New System.Drawing.Size(98, 33)
        Me.buttonDel.TabIndex = 7
        Me.buttonDel.Text = "削除"
        Me.buttonDel.UseVisualStyleBackColor = True
        '
        'buttonEdit
        '
        Me.buttonEdit.Location = New System.Drawing.Point(365, 57)
        Me.buttonEdit.Name = "buttonEdit"
        Me.buttonEdit.Size = New System.Drawing.Size(98, 33)
        Me.buttonEdit.TabIndex = 6
        Me.buttonEdit.Text = "編集"
        Me.buttonEdit.UseVisualStyleBackColor = True
        '
        'buttonAdd
        '
        Me.buttonAdd.Location = New System.Drawing.Point(365, 15)
        Me.buttonAdd.Name = "buttonAdd"
        Me.buttonAdd.Size = New System.Drawing.Size(98, 33)
        Me.buttonAdd.TabIndex = 5
        Me.buttonAdd.Text = "追加"
        Me.buttonAdd.UseVisualStyleBackColor = True
        '
        'dataGridView1
        '
        Me.dataGridView1.AllowUserToAddRows = False
        Me.dataGridView1.AllowUserToDeleteRows = False
        Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView1.Location = New System.Drawing.Point(3, 14)
        Me.dataGridView1.MultiSelect = False
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.ReadOnly = True
        Me.dataGridView1.RowHeadersWidth = 51
        Me.dataGridView1.RowTemplate.Height = 24
        Me.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataGridView1.Size = New System.Drawing.Size(349, 252)
        Me.dataGridView1.TabIndex = 4
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(466, 281)
        Me.Controls.Add(Me.buttonDel)
        Me.Controls.Add(Me.buttonEdit)
        Me.Controls.Add(Me.buttonAdd)
        Me.Controls.Add(Me.dataGridView1)
        Me.Name = "FormMain"
        Me.Text = "販売管理"
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents buttonDel As Button
    Private WithEvents buttonEdit As Button
    Private WithEvents buttonAdd As Button
    Private WithEvents dataGridView1 As DataGridView
End Class
