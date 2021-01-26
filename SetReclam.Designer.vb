<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SetReclam
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SetReclam))
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ContextMenu2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ОбновитьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.КопироватьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.КопироватьВсёToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ОчиститьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFile1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenu2.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenu1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.HorizontalScrollbar = True
        Me.ListBox1.ItemHeight = 18
        Me.ListBox1.Location = New System.Drawing.Point(12, 12)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(116, 346)
        Me.ListBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label1.Location = New System.Drawing.Point(134, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(290, 348)
        Me.Label1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label2.Location = New System.Drawing.Point(119, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 31)
        Me.Label2.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Gray
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.ContextMenuStrip = Me.ContextMenu2
        Me.PictureBox1.ErrorImage = Global.ReclamaV1.My.Resources.Resources._Error
        Me.PictureBox1.InitialImage = Global.ReclamaV1.My.Resources.Resources.Pic_Load
        Me.PictureBox1.Location = New System.Drawing.Point(147, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(141, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'ContextMenu2
        '
        Me.ContextMenu2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ContextMenu2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ОбновитьToolStripMenuItem})
        Me.ContextMenu2.Name = "ContextMenu1"
        Me.ContextMenu2.ShowImageMargin = False
        Me.ContextMenu2.Size = New System.Drawing.Size(111, 26)
        '
        'ОбновитьToolStripMenuItem
        '
        Me.ОбновитьToolStripMenuItem.Name = "ОбновитьToolStripMenuItem"
        Me.ОбновитьToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.ОбновитьToolStripMenuItem.Text = "Обновить"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(294, 34)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 45)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Изменить изображение"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TextBox1.Location = New System.Drawing.Point(147, 189)
        Me.TextBox1.MaxLength = 10000
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(263, 88)
        Me.TextBox1.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label3.Location = New System.Drawing.Point(144, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Описание рекламы:"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TextBox2.Location = New System.Drawing.Point(229, 139)
        Me.TextBox2.MaxLength = 100
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(181, 23)
        Me.TextBox2.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label4.Location = New System.Drawing.Point(144, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 18)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Заголовок:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label5.Location = New System.Drawing.Point(144, 286)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(160, 18)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Время закрытия (сек.):"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.NumericUpDown1.Location = New System.Drawing.Point(311, 283)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(99, 23)
        Me.NumericUpDown1.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label6.Location = New System.Drawing.Point(144, 330)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(153, 18)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Время повтора (мин.):"
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.NumericUpDown2.Enabled = False
        Me.NumericUpDown2.Location = New System.Drawing.Point(311, 328)
        Me.NumericUpDown2.Maximum = New Decimal(New Integer() {1440, 0, 0, 0})
        Me.NumericUpDown2.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(99, 23)
        Me.NumericUpDown2.TabIndex = 12
        Me.NumericUpDown2.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.CheckBox1.Location = New System.Drawing.Point(147, 310)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(95, 22)
        Me.CheckBox1.TabIndex = 13
        Me.CheckBox1.Text = "Повторять"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(12, 363)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(51, 23)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "-"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(69, 363)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(59, 23)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "+"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(311, 363)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(101, 23)
        Me.Button4.TabIndex = 16
        Me.Button4.Text = "Сохранить"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label7.Location = New System.Drawing.Point(301, 354)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(123, 38)
        Me.Label7.TabIndex = 17
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.SystemColors.ControlDark
        Me.TextBox3.ContextMenuStrip = Me.ContextMenu1
        Me.TextBox3.Location = New System.Drawing.Point(294, 85)
        Me.TextBox3.MaxLength = 100
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(118, 23)
        Me.TextBox3.TabIndex = 18
        '
        'ContextMenu1
        '
        Me.ContextMenu1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ContextMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.КопироватьToolStripMenuItem, Me.КопироватьВсёToolStripMenuItem, Me.ToolStripSeparator1, Me.ОчиститьToolStripMenuItem})
        Me.ContextMenu1.Name = "ContextMenu1"
        Me.ContextMenu1.ShowImageMargin = False
        Me.ContextMenu1.Size = New System.Drawing.Size(148, 76)
        '
        'КопироватьToolStripMenuItem
        '
        Me.КопироватьToolStripMenuItem.Name = "КопироватьToolStripMenuItem"
        Me.КопироватьToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.КопироватьToolStripMenuItem.Text = "Копировать"
        '
        'КопироватьВсёToolStripMenuItem
        '
        Me.КопироватьВсёToolStripMenuItem.Name = "КопироватьВсёToolStripMenuItem"
        Me.КопироватьВсёToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.КопироватьВсёToolStripMenuItem.Text = "Копировать всё"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(144, 6)
        '
        'ОчиститьToolStripMenuItem
        '
        Me.ОчиститьToolStripMenuItem.Name = "ОчиститьToolStripMenuItem"
        Me.ОчиститьToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.ОчиститьToolStripMenuItem.Text = "Очистить"
        '
        'OpenFile1
        '
        Me.OpenFile1.Filter = "Файлы JPEG|*.jpg"
        Me.OpenFile1.Title = "Выберите файл"
        '
        'SetReclam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(436, 398)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.NumericUpDown2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SetReclam"
        Me.Text = "Добавить/Удалить/Изменить рекламу"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenu2.ResumeLayout(False)
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenu1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents OpenFile1 As OpenFileDialog
    Friend WithEvents ContextMenu1 As ContextMenuStrip
    Friend WithEvents КопироватьToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents КопироватьВсёToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ОчиститьToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenu2 As ContextMenuStrip
    Friend WithEvents ОбновитьToolStripMenuItem As ToolStripMenuItem
End Class
