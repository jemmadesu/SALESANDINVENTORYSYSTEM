<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMLOGIN
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMLOGIN))
        Me.exitLogin = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CHKPASS = New System.Windows.Forms.CheckBox()
        Me.panel3 = New System.Windows.Forms.Panel()
        Me.label5 = New System.Windows.Forms.Label()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TXTPW = New System.Windows.Forms.TextBox()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.pictureBox3 = New System.Windows.Forms.PictureBox()
        Me.TXTUN = New System.Windows.Forms.TextBox()
        Me.LBLUN = New System.Windows.Forms.Label()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.txtLogin = New System.Windows.Forms.Label()
        Me.BTNLOGIN = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.BTNCANCEL = New System.Windows.Forms.Button()
        Me.panel3.SuspendLayout()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel2.SuspendLayout()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'exitLogin
        '
        Me.exitLogin.AutoSize = True
        Me.exitLogin.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitLogin.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.exitLogin.Location = New System.Drawing.Point(627, -34)
        Me.exitLogin.Name = "exitLogin"
        Me.exitLogin.Size = New System.Drawing.Size(30, 32)
        Me.exitLogin.TabIndex = 19
        Me.exitLogin.Text = "x"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(627, -34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 32)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "x"
        '
        'CHKPASS
        '
        Me.CHKPASS.AutoSize = True
        Me.CHKPASS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CHKPASS.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHKPASS.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.CHKPASS.Location = New System.Drawing.Point(325, 337)
        Me.CHKPASS.Name = "CHKPASS"
        Me.CHKPASS.Size = New System.Drawing.Size(114, 21)
        Me.CHKPASS.TabIndex = 30
        Me.CHKPASS.Text = "Show Password"
        Me.CHKPASS.UseVisualStyleBackColor = True
        '
        'panel3
        '
        Me.panel3.Controls.Add(Me.label5)
        Me.panel3.Controls.Add(Me.pictureBox2)
        Me.panel3.Controls.Add(Me.TXTPW)
        Me.panel3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panel3.Location = New System.Drawing.Point(-1, 288)
        Me.panel3.Name = "panel3"
        Me.panel3.Size = New System.Drawing.Size(440, 43)
        Me.panel3.TabIndex = 29
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.label5.Location = New System.Drawing.Point(62, 15)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(69, 17)
        Me.label5.TabIndex = 19
        Me.label5.Text = "Password"
        '
        'pictureBox2
        '
        Me.pictureBox2.Image = CType(resources.GetObject("pictureBox2.Image"), System.Drawing.Image)
        Me.pictureBox2.Location = New System.Drawing.Point(20, 10)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(25, 26)
        Me.pictureBox2.TabIndex = 7
        Me.pictureBox2.TabStop = False
        '
        'TXTPW
        '
        Me.TXTPW.BackColor = System.Drawing.Color.White
        Me.TXTPW.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXTPW.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPW.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TXTPW.Location = New System.Drawing.Point(147, 15)
        Me.TXTPW.Name = "TXTPW"
        Me.TXTPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TXTPW.Size = New System.Drawing.Size(245, 16)
        Me.TXTPW.TabIndex = 6
        '
        'panel2
        '
        Me.panel2.Controls.Add(Me.pictureBox3)
        Me.panel2.Controls.Add(Me.TXTUN)
        Me.panel2.Controls.Add(Me.LBLUN)
        Me.panel2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panel2.Location = New System.Drawing.Point(-1, 239)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(440, 43)
        Me.panel2.TabIndex = 28
        '
        'pictureBox3
        '
        Me.pictureBox3.Image = CType(resources.GetObject("pictureBox3.Image"), System.Drawing.Image)
        Me.pictureBox3.Location = New System.Drawing.Point(20, 9)
        Me.pictureBox3.Name = "pictureBox3"
        Me.pictureBox3.Size = New System.Drawing.Size(25, 24)
        Me.pictureBox3.TabIndex = 8
        Me.pictureBox3.TabStop = False
        '
        'TXTUN
        '
        Me.TXTUN.BackColor = System.Drawing.Color.White
        Me.TXTUN.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXTUN.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTUN.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TXTUN.Location = New System.Drawing.Point(150, 12)
        Me.TXTUN.Name = "TXTUN"
        Me.TXTUN.Size = New System.Drawing.Size(243, 16)
        Me.TXTUN.TabIndex = 5
        '
        'LBLUN
        '
        Me.LBLUN.AutoSize = True
        Me.LBLUN.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLUN.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LBLUN.Location = New System.Drawing.Point(62, 12)
        Me.LBLUN.Name = "LBLUN"
        Me.LBLUN.Size = New System.Drawing.Size(71, 17)
        Me.LBLUN.TabIndex = 8
        Me.LBLUN.Text = "Username"
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblWelcome.Location = New System.Drawing.Point(50, 165)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(346, 51)
        Me.lblWelcome.TabIndex = 27
        Me.lblWelcome.Text = "Rizal Provincial Hospital Employees and Community " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Multi-purpose Cooperative " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtLogin
        '
        Me.txtLogin.AutoSize = True
        Me.txtLogin.Font = New System.Drawing.Font("Century Gothic", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLogin.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.txtLogin.Location = New System.Drawing.Point(166, 104)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(148, 44)
        Me.txtLogin.TabIndex = 26
        Me.txtLogin.Text = "LOG IN"
        '
        'BTNLOGIN
        '
        Me.BTNLOGIN.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BTNLOGIN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNLOGIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNLOGIN.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNLOGIN.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BTNLOGIN.Location = New System.Drawing.Point(64, 392)
        Me.BTNLOGIN.Name = "BTNLOGIN"
        Me.BTNLOGIN.Size = New System.Drawing.Size(131, 35)
        Me.BTNLOGIN.TabIndex = 23
        Me.BTNLOGIN.Text = "Login"
        Me.BTNLOGIN.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.PictureBox4)
        Me.Panel4.Location = New System.Drawing.Point(445, -2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(524, 554)
        Me.Panel4.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(521, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 25)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "x"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(23, 35)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(475, 451)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox4.TabIndex = 0
        Me.PictureBox4.TabStop = False
        '
        'BTNCANCEL
        '
        Me.BTNCANCEL.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BTNCANCEL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNCANCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNCANCEL.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCANCEL.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BTNCANCEL.Location = New System.Drawing.Point(248, 392)
        Me.BTNCANCEL.Name = "BTNCANCEL"
        Me.BTNCANCEL.Size = New System.Drawing.Size(131, 35)
        Me.BTNCANCEL.TabIndex = 32
        Me.BTNCANCEL.Text = "Cancel"
        Me.BTNCANCEL.UseVisualStyleBackColor = False
        '
        'FRMLOGIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(968, 496)
        Me.Controls.Add(Me.BTNCANCEL)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.CHKPASS)
        Me.Controls.Add(Me.panel3)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.txtLogin)
        Me.Controls.Add(Me.BTNLOGIN)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.exitLogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FRMLOGIN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.panel3.ResumeLayout(False)
        Me.panel3.PerformLayout()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel2.ResumeLayout(False)
        Me.panel2.PerformLayout()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents exitLogin As Label
    Friend WithEvents Label1 As Label
    Private WithEvents CHKPASS As CheckBox
    Private WithEvents panel3 As Panel
    Private WithEvents label5 As Label
    Private WithEvents pictureBox2 As PictureBox
    Friend WithEvents TXTPW As TextBox
    Private WithEvents panel2 As Panel
    Private WithEvents pictureBox3 As PictureBox
    Friend WithEvents TXTUN As TextBox
    Friend WithEvents LBLUN As Label
    Private WithEvents lblWelcome As Label
    Private WithEvents txtLogin As Label
    Friend WithEvents BTNLOGIN As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents BTNCANCEL As Button
End Class
