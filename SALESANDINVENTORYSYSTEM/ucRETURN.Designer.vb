<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucRETURN
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucRETURN))
        Me.DGVTRANS = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LBLORNO = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BTNRETURN = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BTNBACK = New System.Windows.Forms.Button()
        CType(Me.DGVTRANS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGVTRANS
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DGVTRANS.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVTRANS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVTRANS.BackgroundColor = System.Drawing.Color.White
        Me.DGVTRANS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGVTRANS.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGVTRANS.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVTRANS.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGVTRANS.ColumnHeadersHeight = 4
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVTRANS.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGVTRANS.EnableHeadersVisualStyles = False
        Me.DGVTRANS.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGVTRANS.Location = New System.Drawing.Point(51, 219)
        Me.DGVTRANS.Name = "DGVTRANS"
        Me.DGVTRANS.RowHeadersVisible = False
        Me.DGVTRANS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVTRANS.Size = New System.Drawing.Size(1178, 465)
        Me.DGVTRANS.TabIndex = 0
        Me.DGVTRANS.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.DGVTRANS.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DGVTRANS.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DGVTRANS.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DGVTRANS.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DGVTRANS.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DGVTRANS.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DGVTRANS.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGVTRANS.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGVTRANS.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGVTRANS.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DGVTRANS.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DGVTRANS.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DGVTRANS.ThemeStyle.HeaderStyle.Height = 4
        Me.DGVTRANS.ThemeStyle.ReadOnly = False
        Me.DGVTRANS.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DGVTRANS.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGVTRANS.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DGVTRANS.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DGVTRANS.ThemeStyle.RowsStyle.Height = 22
        Me.DGVTRANS.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGVTRANS.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(47, 176)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 20)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Order No :"
        '
        'LBLORNO
        '
        Me.LBLORNO.AutoSize = True
        Me.LBLORNO.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLORNO.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LBLORNO.Location = New System.Drawing.Point(138, 176)
        Me.LBLORNO.Name = "LBLORNO"
        Me.LBLORNO.Size = New System.Drawing.Size(65, 20)
        Me.LBLORNO.TabIndex = 42
        Me.LBLORNO.Text = "0000000"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(430, 177)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 20)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "0000000"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(247, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(177, 20)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Transaction Date/Time :"
        '
        'BTNRETURN
        '
        Me.BTNRETURN.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BTNRETURN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNRETURN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNRETURN.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNRETURN.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNRETURN.Location = New System.Drawing.Point(1106, 164)
        Me.BTNRETURN.Name = "BTNRETURN"
        Me.BTNRETURN.Size = New System.Drawing.Size(113, 48)
        Me.BTNRETURN.TabIndex = 61
        Me.BTNRETURN.Text = "Return"
        Me.BTNRETURN.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panel2.Controls.Add(Me.BTNBACK)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1322, 49)
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
        Me.BTNBACK.Location = New System.Drawing.Point(1200, 3)
        Me.BTNBACK.Name = "BTNBACK"
        Me.BTNBACK.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.BTNBACK.Size = New System.Drawing.Size(119, 46)
        Me.BTNBACK.TabIndex = 3
        Me.BTNBACK.Text = " Back"
        Me.BTNBACK.UseVisualStyleBackColor = False
        '
        'ucRETURN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.BTNRETURN)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LBLORNO)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGVTRANS)
        Me.Name = "ucRETURN"
        Me.Size = New System.Drawing.Size(1322, 801)
        CType(Me.DGVTRANS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVTRANS As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents LBLORNO As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BTNRETURN As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BTNBACK As Button
End Class
