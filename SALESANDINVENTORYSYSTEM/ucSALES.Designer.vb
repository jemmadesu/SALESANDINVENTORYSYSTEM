﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
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
        Me.BTNGENERATE.Location = New System.Drawing.Point(1046, 108)
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
        Me.DGVSALES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
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
        Me.DATE1.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.DATE1.HoverState.Parent = Me.DATE1
        Me.DATE1.Location = New System.Drawing.Point(540, 105)
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
        Me.DATE2.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.DATE2.HoverState.Parent = Me.DATE2
        Me.DATE2.Location = New System.Drawing.Point(806, 108)
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
        Me.BTNCLEAR.Location = New System.Drawing.Point(1156, 108)
        Me.BTNCLEAR.Name = "BTNCLEAR"
        Me.BTNCLEAR.Size = New System.Drawing.Size(83, 33)
        Me.BTNCLEAR.TabIndex = 52
        Me.BTNCLEAR.Text = "Clear"
        Me.BTNCLEAR.UseVisualStyleBackColor = False
        '
        'ucSALES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
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
End Class
