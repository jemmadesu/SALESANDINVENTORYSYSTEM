<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMMAINMENU
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMMAINMENU))
        Me.PNLMAIN = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BTNSALES = New System.Windows.Forms.Button()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.LBLTIME = New System.Windows.Forms.Label()
        Me.TIMEDATE = New System.Windows.Forms.Label()
        Me.BTNREPORTS = New System.Windows.Forms.Button()
        Me.LBLUSERTYPE = New System.Windows.Forms.Label()
        Me.LBLUSERNAME = New System.Windows.Forms.Label()
        Me.BTNINVENTORY = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTNTRANSACTION = New System.Windows.Forms.Button()
        Me.BTNLOGOUT = New System.Windows.Forms.Button()
        Me.BTNSETTINGS = New System.Windows.Forms.Button()
        Me.BTNDASHBOARD = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PNLMAIN
        '
        Me.PNLMAIN.BackColor = System.Drawing.Color.White
        Me.PNLMAIN.Location = New System.Drawing.Point(251, -3)
        Me.PNLMAIN.Name = "PNLMAIN"
        Me.PNLMAIN.Size = New System.Drawing.Size(1322, 801)
        Me.PNLMAIN.TabIndex = 18
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BTNSALES)
        Me.Panel1.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.Panel1.Controls.Add(Me.LBLTIME)
        Me.Panel1.Controls.Add(Me.TIMEDATE)
        Me.Panel1.Controls.Add(Me.BTNREPORTS)
        Me.Panel1.Controls.Add(Me.LBLUSERTYPE)
        Me.Panel1.Controls.Add(Me.LBLUSERNAME)
        Me.Panel1.Controls.Add(Me.BTNINVENTORY)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.BTNTRANSACTION)
        Me.Panel1.Controls.Add(Me.BTNLOGOUT)
        Me.Panel1.Controls.Add(Me.BTNSETTINGS)
        Me.Panel1.Controls.Add(Me.BTNDASHBOARD)
        Me.Panel1.Location = New System.Drawing.Point(-6, -6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(259, 804)
        Me.Panel1.TabIndex = 20
        '
        'BTNSALES
        '
        Me.BTNSALES.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BTNSALES.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNSALES.Enabled = False
        Me.BTNSALES.FlatAppearance.BorderSize = 0
        Me.BTNSALES.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNSALES.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNSALES.ForeColor = System.Drawing.SystemColors.Window
        Me.BTNSALES.Image = CType(resources.GetObject("BTNSALES.Image"), System.Drawing.Image)
        Me.BTNSALES.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNSALES.Location = New System.Drawing.Point(3, 423)
        Me.BTNSALES.Name = "BTNSALES"
        Me.BTNSALES.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.BTNSALES.Size = New System.Drawing.Size(266, 43)
        Me.BTNSALES.TabIndex = 26
        Me.BTNSALES.Text = "    Sales Income"
        Me.BTNSALES.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTNSALES.UseVisualStyleBackColor = False
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.Image = CType(resources.GetObject("Guna2CirclePictureBox1.Image"), System.Drawing.Image)
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(45, 52)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.ShadowDecoration.Parent = Me.Guna2CirclePictureBox1
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(89, 89)
        Me.Guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2CirclePictureBox1.TabIndex = 25
        Me.Guna2CirclePictureBox1.TabStop = False
        '
        'LBLTIME
        '
        Me.LBLTIME.AutoSize = True
        Me.LBLTIME.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTIME.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.LBLTIME.Location = New System.Drawing.Point(65, 739)
        Me.LBLTIME.Name = "LBLTIME"
        Me.LBLTIME.Size = New System.Drawing.Size(56, 24)
        Me.LBLTIME.TabIndex = 24
        Me.LBLTIME.Text = "Time"
        '
        'TIMEDATE
        '
        Me.TIMEDATE.AutoSize = True
        Me.TIMEDATE.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TIMEDATE.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.TIMEDATE.Location = New System.Drawing.Point(47, 778)
        Me.TIMEDATE.Name = "TIMEDATE"
        Me.TIMEDATE.Size = New System.Drawing.Size(40, 17)
        Me.TIMEDATE.TabIndex = 22
        Me.TIMEDATE.Text = "Date"
        '
        'BTNREPORTS
        '
        Me.BTNREPORTS.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BTNREPORTS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNREPORTS.Enabled = False
        Me.BTNREPORTS.FlatAppearance.BorderSize = 0
        Me.BTNREPORTS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNREPORTS.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNREPORTS.ForeColor = System.Drawing.SystemColors.Window
        Me.BTNREPORTS.Image = CType(resources.GetObject("BTNREPORTS.Image"), System.Drawing.Image)
        Me.BTNREPORTS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNREPORTS.Location = New System.Drawing.Point(2, 492)
        Me.BTNREPORTS.Name = "BTNREPORTS"
        Me.BTNREPORTS.Padding = New System.Windows.Forms.Padding(40, 0, 0, 0)
        Me.BTNREPORTS.Size = New System.Drawing.Size(267, 43)
        Me.BTNREPORTS.TabIndex = 23
        Me.BTNREPORTS.Text = "    Reports"
        Me.BTNREPORTS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTNREPORTS.UseVisualStyleBackColor = False
        '
        'LBLUSERTYPE
        '
        Me.LBLUSERTYPE.AutoSize = True
        Me.LBLUSERTYPE.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLUSERTYPE.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.LBLUSERTYPE.Location = New System.Drawing.Point(147, 101)
        Me.LBLUSERTYPE.Name = "LBLUSERTYPE"
        Me.LBLUSERTYPE.Size = New System.Drawing.Size(74, 20)
        Me.LBLUSERTYPE.TabIndex = 20
        Me.LBLUSERTYPE.Text = "Usertype"
        '
        'LBLUSERNAME
        '
        Me.LBLUSERNAME.AutoSize = True
        Me.LBLUSERNAME.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLUSERNAME.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.LBLUSERNAME.Location = New System.Drawing.Point(46, 144)
        Me.LBLUSERNAME.Name = "LBLUSERNAME"
        Me.LBLUSERNAME.Size = New System.Drawing.Size(88, 21)
        Me.LBLUSERNAME.TabIndex = 19
        Me.LBLUSERNAME.Text = "Username"
        '
        'BTNINVENTORY
        '
        Me.BTNINVENTORY.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BTNINVENTORY.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNINVENTORY.Enabled = False
        Me.BTNINVENTORY.FlatAppearance.BorderSize = 0
        Me.BTNINVENTORY.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNINVENTORY.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNINVENTORY.ForeColor = System.Drawing.SystemColors.Window
        Me.BTNINVENTORY.Image = CType(resources.GetObject("BTNINVENTORY.Image"), System.Drawing.Image)
        Me.BTNINVENTORY.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNINVENTORY.Location = New System.Drawing.Point(2, 293)
        Me.BTNINVENTORY.Name = "BTNINVENTORY"
        Me.BTNINVENTORY.Padding = New System.Windows.Forms.Padding(40, 0, 0, 0)
        Me.BTNINVENTORY.Size = New System.Drawing.Size(266, 40)
        Me.BTNINVENTORY.TabIndex = 12
        Me.BTNINVENTORY.Text = "    Inventory"
        Me.BTNINVENTORY.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTNINVENTORY.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Window
        Me.Label1.Location = New System.Drawing.Point(147, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 21)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Hello !"
        '
        'BTNTRANSACTION
        '
        Me.BTNTRANSACTION.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BTNTRANSACTION.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNTRANSACTION.Enabled = False
        Me.BTNTRANSACTION.FlatAppearance.BorderSize = 0
        Me.BTNTRANSACTION.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNTRANSACTION.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNTRANSACTION.ForeColor = System.Drawing.SystemColors.Window
        Me.BTNTRANSACTION.Image = CType(resources.GetObject("BTNTRANSACTION.Image"), System.Drawing.Image)
        Me.BTNTRANSACTION.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNTRANSACTION.Location = New System.Drawing.Point(0, 356)
        Me.BTNTRANSACTION.Name = "BTNTRANSACTION"
        Me.BTNTRANSACTION.Padding = New System.Windows.Forms.Padding(40, 0, 0, 0)
        Me.BTNTRANSACTION.Size = New System.Drawing.Size(266, 43)
        Me.BTNTRANSACTION.TabIndex = 16
        Me.BTNTRANSACTION.Text = "  Sales  Transaction"
        Me.BTNTRANSACTION.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTNTRANSACTION.UseVisualStyleBackColor = False
        '
        'BTNLOGOUT
        '
        Me.BTNLOGOUT.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BTNLOGOUT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNLOGOUT.FlatAppearance.BorderSize = 0
        Me.BTNLOGOUT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNLOGOUT.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNLOGOUT.ForeColor = System.Drawing.SystemColors.Window
        Me.BTNLOGOUT.Image = CType(resources.GetObject("BTNLOGOUT.Image"), System.Drawing.Image)
        Me.BTNLOGOUT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNLOGOUT.Location = New System.Drawing.Point(-4, 624)
        Me.BTNLOGOUT.Name = "BTNLOGOUT"
        Me.BTNLOGOUT.Padding = New System.Windows.Forms.Padding(40, 0, 0, 0)
        Me.BTNLOGOUT.Size = New System.Drawing.Size(273, 43)
        Me.BTNLOGOUT.TabIndex = 14
        Me.BTNLOGOUT.Text = "    Logout"
        Me.BTNLOGOUT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTNLOGOUT.UseVisualStyleBackColor = False
        '
        'BTNSETTINGS
        '
        Me.BTNSETTINGS.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BTNSETTINGS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNSETTINGS.Enabled = False
        Me.BTNSETTINGS.FlatAppearance.BorderSize = 0
        Me.BTNSETTINGS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNSETTINGS.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNSETTINGS.ForeColor = System.Drawing.SystemColors.Window
        Me.BTNSETTINGS.Image = CType(resources.GetObject("BTNSETTINGS.Image"), System.Drawing.Image)
        Me.BTNSETTINGS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNSETTINGS.Location = New System.Drawing.Point(0, 561)
        Me.BTNSETTINGS.Name = "BTNSETTINGS"
        Me.BTNSETTINGS.Padding = New System.Windows.Forms.Padding(40, 0, 0, 0)
        Me.BTNSETTINGS.Size = New System.Drawing.Size(269, 43)
        Me.BTNSETTINGS.TabIndex = 13
        Me.BTNSETTINGS.Text = "    Settings"
        Me.BTNSETTINGS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTNSETTINGS.UseVisualStyleBackColor = False
        '
        'BTNDASHBOARD
        '
        Me.BTNDASHBOARD.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BTNDASHBOARD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNDASHBOARD.Enabled = False
        Me.BTNDASHBOARD.FlatAppearance.BorderSize = 0
        Me.BTNDASHBOARD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNDASHBOARD.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNDASHBOARD.ForeColor = System.Drawing.SystemColors.Window
        Me.BTNDASHBOARD.Image = CType(resources.GetObject("BTNDASHBOARD.Image"), System.Drawing.Image)
        Me.BTNDASHBOARD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNDASHBOARD.Location = New System.Drawing.Point(3, 219)
        Me.BTNDASHBOARD.Name = "BTNDASHBOARD"
        Me.BTNDASHBOARD.Padding = New System.Windows.Forms.Padding(40, 0, 0, 0)
        Me.BTNDASHBOARD.Size = New System.Drawing.Size(260, 43)
        Me.BTNDASHBOARD.TabIndex = 10
        Me.BTNDASHBOARD.Text = "    Dashboard"
        Me.BTNDASHBOARD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTNDASHBOARD.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'FRMMAINMENU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1571, 798)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PNLMAIN)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRMMAINMENU"
        Me.Text = "w"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PNLMAIN As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BTNTRANSACTION As Button
    Friend WithEvents BTNLOGOUT As Button
    Friend WithEvents BTNSETTINGS As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BTNDASHBOARD As Button
    Friend WithEvents BTNINVENTORY As Button
    Friend WithEvents LBLUSERNAME As Label
    Friend WithEvents LBLUSERTYPE As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TIMEDATE As Label
    Friend WithEvents BTNREPORTS As Button
    Friend WithEvents LBLTIME As Label
    Friend WithEvents BTNSALES As Button
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
End Class
