<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucSUPPLIER
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
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TXTNAME = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.BTNCANCEL = New System.Windows.Forms.Button()
        Me.BTNEDIT = New System.Windows.Forms.Button()
        Me.BTNSAVE = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TXTTEL = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TXTCOM = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TXTSEARCH = New System.Windows.Forms.TextBox()
        Me.DGVSUP = New System.Windows.Forms.DataGridView()
        Me.CBOSTATUS = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        CType(Me.DGVSUP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label22.Location = New System.Drawing.Point(48, 247)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(102, 17)
        Me.Label22.TabIndex = 134
        Me.Label22.Text = "Supplier Name"
        '
        'TXTNAME
        '
        Me.TXTNAME.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.TXTNAME.Location = New System.Drawing.Point(51, 280)
        Me.TXTNAME.Name = "TXTNAME"
        Me.TXTNAME.Size = New System.Drawing.Size(313, 22)
        Me.TXTNAME.TabIndex = 131
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.Label11.Location = New System.Drawing.Point(43, 34)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(325, 32)
        Me.Label11.TabIndex = 135
        Me.Label11.Text = "SUPPLIER MANAGEMENT"
        '
        'BTNCANCEL
        '
        Me.BTNCANCEL.BackColor = System.Drawing.Color.Gray
        Me.BTNCANCEL.FlatAppearance.BorderSize = 0
        Me.BTNCANCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNCANCEL.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.BTNCANCEL.ForeColor = System.Drawing.Color.White
        Me.BTNCANCEL.Location = New System.Drawing.Point(287, 410)
        Me.BTNCANCEL.Name = "BTNCANCEL"
        Me.BTNCANCEL.Size = New System.Drawing.Size(75, 35)
        Me.BTNCANCEL.TabIndex = 147
        Me.BTNCANCEL.Text = "Cancel"
        Me.BTNCANCEL.UseVisualStyleBackColor = False
        '
        'BTNEDIT
        '
        Me.BTNEDIT.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BTNEDIT.FlatAppearance.BorderSize = 0
        Me.BTNEDIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNEDIT.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.BTNEDIT.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNEDIT.Location = New System.Drawing.Point(192, 410)
        Me.BTNEDIT.Name = "BTNEDIT"
        Me.BTNEDIT.Size = New System.Drawing.Size(75, 35)
        Me.BTNEDIT.TabIndex = 146
        Me.BTNEDIT.Text = "Edit"
        Me.BTNEDIT.UseVisualStyleBackColor = False
        '
        'BTNSAVE
        '
        Me.BTNSAVE.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BTNSAVE.FlatAppearance.BorderSize = 0
        Me.BTNSAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNSAVE.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.BTNSAVE.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNSAVE.Location = New System.Drawing.Point(97, 410)
        Me.BTNSAVE.Name = "BTNSAVE"
        Me.BTNSAVE.Size = New System.Drawing.Size(75, 35)
        Me.BTNSAVE.TabIndex = 144
        Me.BTNSAVE.Text = "Save"
        Me.BTNSAVE.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(47, 336)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 17)
        Me.Label5.TabIndex = 152
        Me.Label5.Text = "Status"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label7.Location = New System.Drawing.Point(47, 164)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 17)
        Me.Label7.TabIndex = 158
        Me.Label7.Text = "Tel No."
        '
        'TXTTEL
        '
        Me.TXTTEL.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.TXTTEL.Location = New System.Drawing.Point(49, 193)
        Me.TXTTEL.Name = "TXTTEL"
        Me.TXTTEL.Size = New System.Drawing.Size(315, 22)
        Me.TXTTEL.TabIndex = 157
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label8.Location = New System.Drawing.Point(46, 96)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(117, 17)
        Me.Label8.TabIndex = 160
        Me.Label8.Text = "Company Name"
        '
        'TXTCOM
        '
        Me.TXTCOM.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.TXTCOM.Location = New System.Drawing.Point(47, 128)
        Me.TXTCOM.Name = "TXTCOM"
        Me.TXTCOM.Size = New System.Drawing.Size(315, 22)
        Me.TXTCOM.TabIndex = 159
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label9.Location = New System.Drawing.Point(192, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 17)
        Me.Label9.TabIndex = 163
        Me.Label9.Text = "Search"
        '
        'TXTSEARCH
        '
        Me.TXTSEARCH.Location = New System.Drawing.Point(249, 22)
        Me.TXTSEARCH.Name = "TXTSEARCH"
        Me.TXTSEARCH.Size = New System.Drawing.Size(285, 23)
        Me.TXTSEARCH.TabIndex = 162
        '
        'DGVSUP
        '
        Me.DGVSUP.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumSeaGreen
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVSUP.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVSUP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumSeaGreen
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVSUP.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGVSUP.Location = New System.Drawing.Point(29, 63)
        Me.DGVSUP.Name = "DGVSUP"
        Me.DGVSUP.ReadOnly = True
        Me.DGVSUP.RowHeadersVisible = False
        Me.DGVSUP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVSUP.Size = New System.Drawing.Size(505, 344)
        Me.DGVSUP.TabIndex = 164
        '
        'CBOSTATUS
        '
        Me.CBOSTATUS.FormattingEnabled = True
        Me.CBOSTATUS.Items.AddRange(New Object() {"Active", "Inactive"})
        Me.CBOSTATUS.Location = New System.Drawing.Point(51, 362)
        Me.CBOSTATUS.Name = "CBOSTATUS"
        Me.CBOSTATUS.Size = New System.Drawing.Size(313, 21)
        Me.CBOSTATUS.TabIndex = 165
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.GroupBox2.Controls.Add(Me.DGVSUP)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.TXTSEARCH)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox2.Location = New System.Drawing.Point(403, 22)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(558, 423)
        Me.GroupBox2.TabIndex = 166
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Supplier List"
        '
        'ucSUPPLIER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.BTNSAVE)
        Me.Controls.Add(Me.CBOSTATUS)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.BTNEDIT)
        Me.Controls.Add(Me.TXTCOM)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BTNCANCEL)
        Me.Controls.Add(Me.TXTTEL)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.TXTNAME)
        Me.Name = "ucSUPPLIER"
        Me.Size = New System.Drawing.Size(996, 476)
        CType(Me.DGVSUP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label22 As Label
    Friend WithEvents TXTNAME As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents BTNCANCEL As Button
    Friend WithEvents BTNEDIT As Button
    Friend WithEvents BTNSAVE As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TXTTEL As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TXTCOM As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TXTSEARCH As TextBox
    Friend WithEvents DGVSUP As DataGridView
    Friend WithEvents CBOSTATUS As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
