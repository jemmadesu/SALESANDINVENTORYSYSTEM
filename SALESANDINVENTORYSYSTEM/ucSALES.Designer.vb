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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DGVSALES = New System.Windows.Forms.DataGridView()
        Me.TXTINCOME = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Daily = New Guna.UI2.WinForms.Guna2CustomRadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Weekly = New Guna.UI2.WinForms.Guna2CustomRadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Monthly = New Guna.UI2.WinForms.Guna2CustomRadioButton()
        CType(Me.DGVSALES, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(876, 241)
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
        Me.Label8.Location = New System.Drawing.Point(19, 108)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(207, 32)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "SALES INCOME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.Label2.Location = New System.Drawing.Point(789, 662)
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
        Me.Panel2.Size = New System.Drawing.Size(1091, 49)
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
        Me.DGVSALES.Location = New System.Drawing.Point(14, 170)
        Me.DGVSALES.Name = "DGVSALES"
        Me.DGVSALES.ReadOnly = True
        Me.DGVSALES.RowHeadersVisible = False
        Me.DGVSALES.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVSALES.Size = New System.Drawing.Size(1054, 470)
        Me.DGVSALES.TabIndex = 49
        '
        'TXTINCOME
        '
        Me.TXTINCOME.BackColor = System.Drawing.Color.White
        Me.TXTINCOME.Enabled = False
        Me.TXTINCOME.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTINCOME.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.TXTINCOME.Location = New System.Drawing.Point(905, 659)
        Me.TXTINCOME.Name = "TXTINCOME"
        Me.TXTINCOME.Size = New System.Drawing.Size(163, 27)
        Me.TXTINCOME.TabIndex = 47
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(801, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 20)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Daily"
        '
        'Daily
        '
        Me.Daily.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Daily.CheckedState.BorderThickness = 0
        Me.Daily.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Daily.CheckedState.InnerColor = System.Drawing.Color.White
        Me.Daily.CheckedState.Parent = Me.Daily
        Me.Daily.Location = New System.Drawing.Point(775, 118)
        Me.Daily.Name = "Daily"
        Me.Daily.ShadowDecoration.Parent = Me.Daily
        Me.Daily.Size = New System.Drawing.Size(20, 20)
        Me.Daily.TabIndex = 55
        Me.Daily.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Daily.UncheckedState.BorderThickness = 2
        Me.Daily.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.Daily.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.Daily.UncheckedState.Parent = Me.Daily
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(891, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 20)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "Weekly"
        '
        'Weekly
        '
        Me.Weekly.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Weekly.CheckedState.BorderThickness = 0
        Me.Weekly.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Weekly.CheckedState.InnerColor = System.Drawing.Color.White
        Me.Weekly.CheckedState.Parent = Me.Weekly
        Me.Weekly.Location = New System.Drawing.Point(865, 118)
        Me.Weekly.Name = "Weekly"
        Me.Weekly.ShadowDecoration.Parent = Me.Weekly
        Me.Weekly.Size = New System.Drawing.Size(20, 20)
        Me.Weekly.TabIndex = 57
        Me.Weekly.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Weekly.UncheckedState.BorderThickness = 2
        Me.Weekly.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.Weekly.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.Weekly.UncheckedState.Parent = Me.Weekly
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(1000, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 20)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "Monthly"
        '
        'Monthly
        '
        Me.Monthly.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Monthly.CheckedState.BorderThickness = 0
        Me.Monthly.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Monthly.CheckedState.InnerColor = System.Drawing.Color.White
        Me.Monthly.CheckedState.Parent = Me.Monthly
        Me.Monthly.Location = New System.Drawing.Point(974, 118)
        Me.Monthly.Name = "Monthly"
        Me.Monthly.ShadowDecoration.Parent = Me.Monthly
        Me.Monthly.Size = New System.Drawing.Size(20, 20)
        Me.Monthly.TabIndex = 59
        Me.Monthly.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Monthly.UncheckedState.BorderThickness = 2
        Me.Monthly.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.Monthly.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.Monthly.UncheckedState.Parent = Me.Monthly
        '
        'ucSALES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Monthly)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Weekly)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Daily)
        Me.Controls.Add(Me.DGVSALES)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TXTINCOME)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Name = "ucSALES"
        Me.Size = New System.Drawing.Size(1091, 729)
        CType(Me.DGVSALES, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DGVSALES As DataGridView
    Friend WithEvents TXTINCOME As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Daily As Guna.UI2.WinForms.Guna2CustomRadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Weekly As Guna.UI2.WinForms.Guna2CustomRadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents Monthly As Guna.UI2.WinForms.Guna2CustomRadioButton
End Class
