<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reclama
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reclama))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProductTitle = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ProductPicture = New System.Windows.Forms.PictureBox()
        Me.ProductInfo = New System.Windows.Forms.TextBox()
        Me.Next_button = New System.Windows.Forms.Button()
        Me.Next_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.ProductPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PictureBox1.ErrorImage = Global.ReclamaV1.My.Resources.Resources._Error
        Me.PictureBox1.Image = Global.ReclamaV1.My.Resources.Resources.Reclama_Pic
        Me.PictureBox1.InitialImage = Global.ReclamaV1.My.Resources.Resources.Pic_Load
        Me.PictureBox1.Location = New System.Drawing.Point(4, 4)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(367, 40)
        Me.Label1.TabIndex = 1
        '
        'ProductTitle
        '
        Me.ProductTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProductTitle.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ProductTitle.Location = New System.Drawing.Point(43, 9)
        Me.ProductTitle.Name = "ProductTitle"
        Me.ProductTitle.Size = New System.Drawing.Size(310, 20)
        Me.ProductTitle.TabIndex = 2
        Me.ProductTitle.Text = "Title"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ProductPicture, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ProductInfo, 0, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 43)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(341, 313)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'ProductPicture
        '
        Me.ProductPicture.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProductPicture.ErrorImage = Global.ReclamaV1.My.Resources.Resources._Error
        Me.ProductPicture.InitialImage = Global.ReclamaV1.My.Resources.Resources.Pic_Load
        Me.ProductPicture.Location = New System.Drawing.Point(3, 3)
        Me.ProductPicture.Name = "ProductPicture"
        Me.ProductPicture.Size = New System.Drawing.Size(335, 197)
        Me.ProductPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ProductPicture.TabIndex = 0
        Me.ProductPicture.TabStop = False
        '
        'ProductInfo
        '
        Me.ProductInfo.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ProductInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProductInfo.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ProductInfo.Location = New System.Drawing.Point(3, 206)
        Me.ProductInfo.MaxLength = 10000
        Me.ProductInfo.Multiline = True
        Me.ProductInfo.Name = "ProductInfo"
        Me.ProductInfo.ReadOnly = True
        Me.ProductInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ProductInfo.Size = New System.Drawing.Size(335, 104)
        Me.ProductInfo.TabIndex = 1
        '
        'Next_button
        '
        Me.Next_button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Next_button.Location = New System.Drawing.Point(269, 362)
        Me.Next_button.Name = "Next_button"
        Me.Next_button.Size = New System.Drawing.Size(84, 28)
        Me.Next_button.TabIndex = 4
        Me.Next_button.Text = "Next"
        Me.Next_button.UseVisualStyleBackColor = True
        '
        'Next_Timer
        '
        Me.Next_Timer.Interval = 1000
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBox1.Location = New System.Drawing.Point(-1, 374)
        Me.TextBox1.MaxLength = 1
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(10, 16)
        Me.TextBox1.TabIndex = 5
        '
        'Reclama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(365, 402)
        Me.ControlBox = False
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Next_button)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.ProductTitle)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Reclama"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.ProductPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ProductTitle As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents ProductPicture As PictureBox
    Friend WithEvents ProductInfo As TextBox
    Friend WithEvents Next_button As Button
    Friend WithEvents Next_Timer As Timer
    Friend WithEvents TextBox1 As TextBox
End Class
