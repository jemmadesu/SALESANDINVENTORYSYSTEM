<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucSTOCKLIST
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucSTOCKLIST))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BTNBACK = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXTSEARCH = New Guna.UI2.WinForms.Guna2TextBox()
        Me.DGVSTOCK = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.DGVSTOCK, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panel2.Controls.Add(Me.BTNBACK)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1091, 49)
        Me.Panel2.TabIndex = 128
        '
        'BTNBACK
        '
        Me.BTNBACK.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BTNBACK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BTNBACK.FlatAppearance.BorderSize = 0
        Me.BTNBACK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNBACK.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNBACK.ForeColor = System.Drawing.Color.White
        Me.BTNBACK.Image = CType(resources.GetObject("BTNBACK.Image"), System.Drawing.Image)
        Me.BTNBACK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNBACK.Location = New System.Drawing.Point(963, 3)
        Me.BTNBACK.Name = "BTNBACK"
        Me.BTNBACK.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.BTNBACK.Size = New System.Drawing.Size(119, 46)
        Me.BTNBACK.TabIndex = 3
        Me.BTNBACK.Text = " Back"
        Me.BTNBACK.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.Label1.Location = New System.Drawing.Point(18, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 32)
        Me.Label1.TabIndex = 131
        Me.Label1.Text = "STOCK LIST"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(629, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 21)
        Me.Label2.TabIndex = 135
        Me.Label2.Text = "Search Product :"
        '
        'TXTSEARCH
        '
        Me.TXTSEARCH.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTSEARCH.DefaultText = ""
        Me.TXTSEARCH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTSEARCH.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTSEARCH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTSEARCH.DisabledState.Parent = Me.TXTSEARCH
        Me.TXTSEARCH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTSEARCH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTSEARCH.FocusedState.Parent = Me.TXTSEARCH
        Me.TXTSEARCH.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTSEARCH.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTSEARCH.HoverState.Parent = Me.TXTSEARCH
        Me.TXTSEARCH.Location = New System.Drawing.Point(774, 103)
        Me.TXTSEARCH.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TXTSEARCH.Name = "TXTSEARCH"
        Me.TXTSEARCH.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTSEARCH.PlaceholderText = ""
        Me.TXTSEARCH.SelectedText = ""
        Me.TXTSEARCH.ShadowDecoration.Parent = Me.TXTSEARCH
        Me.TXTSEARCH.Size = New System.Drawing.Size(293, 27)
        Me.TXTSEARCH.TabIndex = 134
        '
        'DGVSTOCK
        '
        Me.DGVSTOCK.AllowUserToAddRows = False
        Me.DGVSTOCK.AllowUserToDeleteRows = False
        Me.DGVSTOCK.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumSeaGreen
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVSTOCK.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVSTOCK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumSeaGreen
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVSTOCK.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGVSTOCK.Location = New System.Drawing.Point(24, 147)
        Me.DGVSTOCK.Name = "DGVSTOCK"
        Me.DGVSTOCK.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumSeaGreen
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVSTOCK.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DGVSTOCK.RowHeadersVisible = False
        Me.DGVSTOCK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVSTOCK.Size = New System.Drawing.Size(1043, 521)
        Me.DGVSTOCK.TabIndex = 133
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(939, 264)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 132
        '
        'ucSTOCKLIST
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXTSEARCH)
        Me.Controls.Add(Me.DGVSTOCK)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "ucSTOCKLIST"
        Me.Size = New System.Drawing.Size(1091, 729)
        Me.Panel2.ResumeLayout(False)
        CType(Me.DGVSTOCK, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BTNBACK As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TXTSEARCH As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents DGVSTOCK As DataGridView
    Friend WithEvents Label4 As Label
End Class
