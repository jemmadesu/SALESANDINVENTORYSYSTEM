<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMRUNNINGOUTOFSTOCKS
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DGVLOWQTY = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LBLCLOSE = New System.Windows.Forms.PictureBox()
        CType(Me.DGVLOWQTY, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.LBLCLOSE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVLOWQTY
        '
        Me.DGVLOWQTY.AllowUserToAddRows = False
        Me.DGVLOWQTY.AllowUserToDeleteRows = False
        Me.DGVLOWQTY.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVLOWQTY.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DGVLOWQTY.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.MediumSeaGreen
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVLOWQTY.DefaultCellStyle = DataGridViewCellStyle8
        Me.DGVLOWQTY.Location = New System.Drawing.Point(31, 108)
        Me.DGVLOWQTY.Name = "DGVLOWQTY"
        Me.DGVLOWQTY.ReadOnly = True
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.MediumSeaGreen
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVLOWQTY.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.DGVLOWQTY.RowHeadersVisible = False
        Me.DGVLOWQTY.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVLOWQTY.Size = New System.Drawing.Size(990, 515)
        Me.DGVLOWQTY.TabIndex = 74
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.Label8.Location = New System.Drawing.Point(25, 61)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(352, 32)
        Me.Label8.TabIndex = 72
        Me.Label8.Text = "RUNNING OUT OF STOCKS"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panel2.Controls.Add(Me.LBLCLOSE)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1059, 49)
        Me.Panel2.TabIndex = 73
        '
        'LBLCLOSE
        '
        Me.LBLCLOSE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LBLCLOSE.Image = Global.SALESANDINVENTORYSYSTEM.My.Resources.Resources.x_mark_64__1_
        Me.LBLCLOSE.Location = New System.Drawing.Point(994, 12)
        Me.LBLCLOSE.Name = "LBLCLOSE"
        Me.LBLCLOSE.Size = New System.Drawing.Size(27, 25)
        Me.LBLCLOSE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LBLCLOSE.TabIndex = 58
        Me.LBLCLOSE.TabStop = False
        '
        'FRMRUNNINGOUTOFSTOCKS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1059, 651)
        Me.Controls.Add(Me.DGVLOWQTY)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FRMRUNNINGOUTOFSTOCKS"
        Me.Text = "FRMRUNNINGOUTOFSTOCKS"
        CType(Me.DGVLOWQTY, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.LBLCLOSE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVLOWQTY As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LBLCLOSE As PictureBox
End Class
