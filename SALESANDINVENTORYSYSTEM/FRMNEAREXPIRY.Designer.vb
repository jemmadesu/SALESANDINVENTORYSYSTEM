﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMNEAREXPIRY
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DGVEXP = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LBLCLOSE = New System.Windows.Forms.PictureBox()
        CType(Me.DGVEXP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.LBLCLOSE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.Label8.Location = New System.Drawing.Point(33, 63)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(229, 32)
        Me.Label8.TabIndex = 136
        Me.Label8.Text = "NEARLY-EXPIRED"
        '
        'DGVEXP
        '
        Me.DGVEXP.AllowUserToAddRows = False
        Me.DGVEXP.AllowUserToDeleteRows = False
        Me.DGVEXP.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.MediumSeaGreen
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVEXP.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DGVEXP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.MediumSeaGreen
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVEXP.DefaultCellStyle = DataGridViewCellStyle8
        Me.DGVEXP.Location = New System.Drawing.Point(39, 120)
        Me.DGVEXP.Name = "DGVEXP"
        Me.DGVEXP.ReadOnly = True
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.MediumSeaGreen
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVEXP.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.DGVEXP.RowHeadersVisible = False
        Me.DGVEXP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVEXP.Size = New System.Drawing.Size(999, 521)
        Me.DGVEXP.TabIndex = 135
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panel2.Controls.Add(Me.LBLCLOSE)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1075, 49)
        Me.Panel2.TabIndex = 134
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(939, 287)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 133
        '
        'LBLCLOSE
        '
        Me.LBLCLOSE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LBLCLOSE.Image = Global.SALESANDINVENTORYSYSTEM.My.Resources.Resources.x_mark_64__1_
        Me.LBLCLOSE.Location = New System.Drawing.Point(1011, 12)
        Me.LBLCLOSE.Name = "LBLCLOSE"
        Me.LBLCLOSE.Size = New System.Drawing.Size(27, 25)
        Me.LBLCLOSE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LBLCLOSE.TabIndex = 137
        Me.LBLCLOSE.TabStop = False
        '
        'FRMNEAREXPIRY
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1075, 690)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DGVEXP)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRMNEAREXPIRY"
        Me.Text = "FRMNEAREXPIRY"
        CType(Me.DGVEXP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.LBLCLOSE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents DGVEXP As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents LBLCLOSE As PictureBox
End Class
