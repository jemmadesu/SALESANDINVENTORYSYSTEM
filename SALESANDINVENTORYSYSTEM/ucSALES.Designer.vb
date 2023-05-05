<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucSALES
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BTNGENERATE = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DGVSALES = New System.Windows.Forms.DataGridView()
        Me.TXTINCOME = New System.Windows.Forms.TextBox()
        Me.DATE1 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.DATE2 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.BTNCLEAR = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DGVSALES, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(890, 224)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 31
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.Label8.Location = New System.Drawing.Point(57, 79)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(207, 32)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "SALES INCOME"
        '
        'BTNGENERATE
        '
        Me.BTNGENERATE.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BTNGENERATE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNGENERATE.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNGENERATE.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNGENERATE.Location = New System.Drawing.Point(1049, 111)
        Me.BTNGENERATE.Name = "BTNGENERATE"
        Me.BTNGENERATE.Size = New System.Drawing.Size(83, 33)
        Me.BTNGENERATE.TabIndex = 44
        Me.BTNGENERATE.Text = "Filter"
        Me.BTNGENERATE.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.Label2.Location = New System.Drawing.Point(960, 761)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 19)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "TOTAL SALES :"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1322, 49)
        Me.Panel2.TabIndex = 48
        '
        'DGVSALES
        '
        Me.DGVSALES.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumSeaGreen
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVSALES.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVSALES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumSeaGreen
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVSALES.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGVSALES.Location = New System.Drawing.Point(72, 163)
        Me.DGVSALES.Name = "DGVSALES"
        Me.DGVSALES.ReadOnly = True
        Me.DGVSALES.RowHeadersVisible = False
        Me.DGVSALES.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVSALES.Size = New System.Drawing.Size(1167, 570)
        Me.DGVSALES.TabIndex = 49
        '
        'TXTINCOME
        '
        Me.TXTINCOME.BackColor = System.Drawing.Color.White
        Me.TXTINCOME.Enabled = False
        Me.TXTINCOME.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTINCOME.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.TXTINCOME.Location = New System.Drawing.Point(1076, 758)
        Me.TXTINCOME.Name = "TXTINCOME"
        Me.TXTINCOME.Size = New System.Drawing.Size(163, 27)
        Me.TXTINCOME.TabIndex = 47
        '
        'DATE1
        '
        Me.DATE1.BackColor = System.Drawing.Color.White
        Me.DATE1.CheckedState.Parent = Me.DATE1
        Me.DATE1.FillColor = System.Drawing.Color.White
        Me.DATE1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DATE1.ForeColor = System.Drawing.Color.DimGray
        Me.DATE1.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.DATE1.HoverState.Parent = Me.DATE1
        Me.DATE1.Location = New System.Drawing.Point(529, 108)
        Me.DATE1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DATE1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DATE1.Name = "DATE1"
        Me.DATE1.ShadowDecoration.Parent = Me.DATE1
        Me.DATE1.Size = New System.Drawing.Size(200, 36)
        Me.DATE1.TabIndex = 50
        Me.DATE1.Value = New Date(2023, 4, 9, 3, 3, 41, 799)
        '
        'DATE2
        '
        Me.DATE2.BackColor = System.Drawing.Color.White
        Me.DATE2.CheckedState.Parent = Me.DATE2
        Me.DATE2.FillColor = System.Drawing.Color.White
        Me.DATE2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DATE2.ForeColor = System.Drawing.Color.DimGray
        Me.DATE2.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.DATE2.HoverState.Parent = Me.DATE2
        Me.DATE2.Location = New System.Drawing.Point(799, 108)
        Me.DATE2.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DATE2.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DATE2.Name = "DATE2"
        Me.DATE2.ShadowDecoration.Parent = Me.DATE2
        Me.DATE2.Size = New System.Drawing.Size(200, 36)
        Me.DATE2.TabIndex = 51
        Me.DATE2.Value = New Date(2023, 4, 9, 3, 3, 41, 799)
        '
        'BTNCLEAR
        '
        Me.BTNCLEAR.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BTNCLEAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNCLEAR.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCLEAR.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNCLEAR.Location = New System.Drawing.Point(1156, 113)
        Me.BTNCLEAR.Name = "BTNCLEAR"
        Me.BTNCLEAR.Size = New System.Drawing.Size(83, 33)
        Me.BTNCLEAR.TabIndex = 52
        Me.BTNCLEAR.Text = "Clear"
        Me.BTNCLEAR.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(471, 113)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 20)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "From :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(748, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 20)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "To :"
        '
        'ucSALES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BTNCLEAR)
        Me.Controls.Add(Me.DATE2)
        Me.Controls.Add(Me.DATE1)
        Me.Controls.Add(Me.DGVSALES)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TXTINCOME)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.BTNGENERATE)
        Me.Controls.Add(Me.Label4)
        Me.Name = "ucSALES"
        Me.Size = New System.Drawing.Size(1322, 801)
        CType(Me.DGVSALES, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents BTNGENERATE As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DGVSALES As DataGridView
    Friend WithEvents TXTINCOME As TextBox
    Friend WithEvents DATE1 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents DATE2 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents BTNCLEAR As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
End Class
