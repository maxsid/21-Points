<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.gk1 = New System.Windows.Forms.PictureBox()
        Me.gk1_2 = New System.Windows.Forms.PictureBox()
        Me.MyBall = New System.Windows.Forms.Label()
        Me.PCBall = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.gk2 = New System.Windows.Forms.PictureBox()
        Me.gk2_2 = New System.Windows.Forms.PictureBox()
        Me.gk3 = New System.Windows.Forms.PictureBox()
        Me.gk3_2 = New System.Windows.Forms.PictureBox()
        Me.WinBall = New System.Windows.Forms.Label()
        Me.LoseBall = New System.Windows.Forms.Label()
        Me.DrowBall = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Talk = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.gk1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gk1_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gk2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gk2_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gk3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gk3_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gk1
        '
        Me.gk1.Location = New System.Drawing.Point(160, 234)
        Me.gk1.Name = "gk1"
        Me.gk1.Size = New System.Drawing.Size(65, 65)
        Me.gk1.TabIndex = 0
        Me.gk1.TabStop = False
        '
        'gk1_2
        '
        Me.gk1_2.Location = New System.Drawing.Point(275, 234)
        Me.gk1_2.Name = "gk1_2"
        Me.gk1_2.Size = New System.Drawing.Size(65, 65)
        Me.gk1_2.TabIndex = 1
        Me.gk1_2.TabStop = False
        '
        'MyBall
        '
        Me.MyBall.Font = New System.Drawing.Font("Microsoft Sans Serif", 44.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.MyBall.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.MyBall.Location = New System.Drawing.Point(33, 11)
        Me.MyBall.Name = "MyBall"
        Me.MyBall.Size = New System.Drawing.Size(104, 70)
        Me.MyBall.TabIndex = 3
        Me.MyBall.Text = "0"
        Me.MyBall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PCBall
        '
        Me.PCBall.Font = New System.Drawing.Font("Microsoft Sans Serif", 44.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.PCBall.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PCBall.Location = New System.Drawing.Point(365, 11)
        Me.PCBall.Name = "PCBall"
        Me.PCBall.Size = New System.Drawing.Size(104, 70)
        Me.PCBall.TabIndex = 4
        Me.PCBall.Text = "0"
        Me.PCBall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Green
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.кнопка1
        Me.PictureBox1.Location = New System.Drawing.Point(217, 305)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(63, 52)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'gk2
        '
        Me.gk2.Location = New System.Drawing.Point(160, 168)
        Me.gk2.Name = "gk2"
        Me.gk2.Size = New System.Drawing.Size(65, 65)
        Me.gk2.TabIndex = 9
        Me.gk2.TabStop = False
        '
        'gk2_2
        '
        Me.gk2_2.Location = New System.Drawing.Point(275, 168)
        Me.gk2_2.Name = "gk2_2"
        Me.gk2_2.Size = New System.Drawing.Size(65, 65)
        Me.gk2_2.TabIndex = 10
        Me.gk2_2.TabStop = False
        '
        'gk3
        '
        Me.gk3.Location = New System.Drawing.Point(160, 102)
        Me.gk3.Name = "gk3"
        Me.gk3.Size = New System.Drawing.Size(65, 65)
        Me.gk3.TabIndex = 11
        Me.gk3.TabStop = False
        '
        'gk3_2
        '
        Me.gk3_2.Location = New System.Drawing.Point(275, 102)
        Me.gk3_2.Name = "gk3_2"
        Me.gk3_2.Size = New System.Drawing.Size(65, 65)
        Me.gk3_2.TabIndex = 12
        Me.gk3_2.TabStop = False
        '
        'WinBall
        '
        Me.WinBall.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.WinBall.ForeColor = System.Drawing.Color.Black
        Me.WinBall.Location = New System.Drawing.Point(44, 222)
        Me.WinBall.Name = "WinBall"
        Me.WinBall.Size = New System.Drawing.Size(20, 25)
        Me.WinBall.TabIndex = 13
        Me.WinBall.Text = "0"
        Me.WinBall.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'LoseBall
        '
        Me.LoseBall.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LoseBall.ForeColor = System.Drawing.Color.Black
        Me.LoseBall.Location = New System.Drawing.Point(102, 222)
        Me.LoseBall.Name = "LoseBall"
        Me.LoseBall.Size = New System.Drawing.Size(20, 25)
        Me.LoseBall.TabIndex = 14
        Me.LoseBall.Text = "0"
        Me.LoseBall.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'DrowBall
        '
        Me.DrowBall.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.DrowBall.ForeColor = System.Drawing.Color.Black
        Me.DrowBall.Location = New System.Drawing.Point(73, 222)
        Me.DrowBall.Name = "DrowBall"
        Me.DrowBall.Size = New System.Drawing.Size(20, 25)
        Me.DrowBall.TabIndex = 15
        Me.DrowBall.Text = "0"
        Me.DrowBall.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Black
        Me.PictureBox4.Image = Global.WindowsApplication1.My.Resources.Resources.oblako
        Me.PictureBox4.Location = New System.Drawing.Point(240, 2)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(119, 62)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 16
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Visible = False
        '
        'Talk
        '
        Me.Talk.BackColor = System.Drawing.Color.White
        Me.Talk.Location = New System.Drawing.Point(257, 17)
        Me.Talk.Name = "Talk"
        Me.Talk.Size = New System.Drawing.Size(83, 28)
        Me.Talk.TabIndex = 17
        Me.Talk.Text = "У соперника больше очков"
        Me.Talk.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Green
        Me.PictureBox3.Enabled = False
        Me.PictureBox3.Image = Global.WindowsApplication1.My.Resources.Resources.кнопка3
        Me.PictureBox3.Location = New System.Drawing.Point(291, 305)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(63, 52)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 8
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Green
        Me.PictureBox2.Image = Global.WindowsApplication1.My.Resources.Resources.кнопка2
        Me.PictureBox2.Location = New System.Drawing.Point(226, 305)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(63, 52)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.старая
        Me.ClientSize = New System.Drawing.Size(504, 400)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Talk)
        Me.Controls.Add(Me.PCBall)
        Me.Controls.Add(Me.MyBall)
        Me.Controls.Add(Me.DrowBall)
        Me.Controls.Add(Me.LoseBall)
        Me.Controls.Add(Me.WinBall)
        Me.Controls.Add(Me.gk3_2)
        Me.Controls.Add(Me.gk3)
        Me.Controls.Add(Me.gk2_2)
        Me.Controls.Add(Me.gk2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.gk1_2)
        Me.Controls.Add(Me.gk1)
        Me.Controls.Add(Me.PictureBox4)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MaximumSize = New System.Drawing.Size(520, 439)
        Me.MinimumSize = New System.Drawing.Size(520, 439)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = " "
        CType(Me.gk1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gk1_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gk2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gk2_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gk3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gk3_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gk1 As System.Windows.Forms.PictureBox
    Friend WithEvents gk1_2 As System.Windows.Forms.PictureBox
    Friend WithEvents MyBall As System.Windows.Forms.Label
    Friend WithEvents PCBall As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents gk2 As System.Windows.Forms.PictureBox
    Friend WithEvents gk2_2 As System.Windows.Forms.PictureBox
    Friend WithEvents gk3 As System.Windows.Forms.PictureBox
    Friend WithEvents gk3_2 As System.Windows.Forms.PictureBox
    Friend WithEvents WinBall As System.Windows.Forms.Label
    Friend WithEvents LoseBall As System.Windows.Forms.Label
    Friend WithEvents DrowBall As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Talk As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox

End Class
