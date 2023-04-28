<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMRESTORE
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LBLEXIT = New System.Windows.Forms.Label()
        Me.Guna2DateTimePicker1 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Guna2DateTimePicker2 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.BTNFILTER = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNCLEAR = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNRESTORE = New Guna.UI2.WinForms.Guna2Button()
        Me.DGVPROD = New System.Windows.Forms.DataGridView()
        Me.Panel3.SuspendLayout()
        CType(Me.DGVPROD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.LBLEXIT)
        Me.Panel3.Location = New System.Drawing.Point(-2, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(863, 55)
        Me.Panel3.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(31, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 20)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Restore Tab"
        '
        'LBLEXIT
        '
        Me.LBLEXIT.AutoSize = True
        Me.LBLEXIT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LBLEXIT.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLEXIT.ForeColor = System.Drawing.Color.White
        Me.LBLEXIT.Location = New System.Drawing.Point(787, 11)
        Me.LBLEXIT.Name = "LBLEXIT"
        Me.LBLEXIT.Size = New System.Drawing.Size(30, 32)
        Me.LBLEXIT.TabIndex = 28
        Me.LBLEXIT.Text = "x"
        '
        'Guna2DateTimePicker1
        '
        Me.Guna2DateTimePicker1.CheckedState.Parent = Me.Guna2DateTimePicker1
        Me.Guna2DateTimePicker1.FillColor = System.Drawing.Color.White
        Me.Guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.Guna2DateTimePicker1.HoverState.Parent = Me.Guna2DateTimePicker1
        Me.Guna2DateTimePicker1.Location = New System.Drawing.Point(29, 70)
        Me.Guna2DateTimePicker1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.Guna2DateTimePicker1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.Guna2DateTimePicker1.Name = "Guna2DateTimePicker1"
        Me.Guna2DateTimePicker1.ShadowDecoration.Parent = Me.Guna2DateTimePicker1
        Me.Guna2DateTimePicker1.Size = New System.Drawing.Size(200, 36)
        Me.Guna2DateTimePicker1.TabIndex = 1
        Me.Guna2DateTimePicker1.Value = New Date(2023, 4, 28, 15, 40, 59, 242)
        '
        'Guna2DateTimePicker2
        '
        Me.Guna2DateTimePicker2.CheckedState.Parent = Me.Guna2DateTimePicker2
        Me.Guna2DateTimePicker2.FillColor = System.Drawing.Color.White
        Me.Guna2DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.Guna2DateTimePicker2.HoverState.Parent = Me.Guna2DateTimePicker2
        Me.Guna2DateTimePicker2.Location = New System.Drawing.Point(290, 70)
        Me.Guna2DateTimePicker2.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.Guna2DateTimePicker2.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.Guna2DateTimePicker2.Name = "Guna2DateTimePicker2"
        Me.Guna2DateTimePicker2.ShadowDecoration.Parent = Me.Guna2DateTimePicker2
        Me.Guna2DateTimePicker2.Size = New System.Drawing.Size(200, 36)
        Me.Guna2DateTimePicker2.TabIndex = 2
        Me.Guna2DateTimePicker2.Value = New Date(2023, 4, 28, 15, 40, 59, 242)
        '
        'BTNFILTER
        '
        Me.BTNFILTER.CheckedState.Parent = Me.BTNFILTER
        Me.BTNFILTER.CustomImages.Parent = Me.BTNFILTER
        Me.BTNFILTER.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.BTNFILTER.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTNFILTER.ForeColor = System.Drawing.Color.White
        Me.BTNFILTER.HoverState.Parent = Me.BTNFILTER
        Me.BTNFILTER.Location = New System.Drawing.Point(542, 70)
        Me.BTNFILTER.Name = "BTNFILTER"
        Me.BTNFILTER.ShadowDecoration.Parent = Me.BTNFILTER
        Me.BTNFILTER.Size = New System.Drawing.Size(98, 36)
        Me.BTNFILTER.TabIndex = 5
        Me.BTNFILTER.Text = "Filter"
        '
        'BTNCLEAR
        '
        Me.BTNCLEAR.BackColor = System.Drawing.Color.Transparent
        Me.BTNCLEAR.CheckedState.Parent = Me.BTNCLEAR
        Me.BTNCLEAR.CustomImages.Parent = Me.BTNCLEAR
        Me.BTNCLEAR.FillColor = System.Drawing.SystemColors.ControlDark
        Me.BTNCLEAR.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTNCLEAR.ForeColor = System.Drawing.Color.White
        Me.BTNCLEAR.HoverState.Parent = Me.BTNCLEAR
        Me.BTNCLEAR.Location = New System.Drawing.Point(681, 70)
        Me.BTNCLEAR.Name = "BTNCLEAR"
        Me.BTNCLEAR.ShadowDecoration.Parent = Me.BTNCLEAR
        Me.BTNCLEAR.Size = New System.Drawing.Size(98, 36)
        Me.BTNCLEAR.TabIndex = 6
        Me.BTNCLEAR.Text = "Clear Filter"
        '
        'BTNRESTORE
        '
        Me.BTNRESTORE.CheckedState.Parent = Me.BTNRESTORE
        Me.BTNRESTORE.CustomImages.Parent = Me.BTNRESTORE
        Me.BTNRESTORE.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.BTNRESTORE.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTNRESTORE.ForeColor = System.Drawing.Color.White
        Me.BTNRESTORE.HoverState.Parent = Me.BTNRESTORE
        Me.BTNRESTORE.Location = New System.Drawing.Point(717, 423)
        Me.BTNRESTORE.Name = "BTNRESTORE"
        Me.BTNRESTORE.ShadowDecoration.Parent = Me.BTNRESTORE
        Me.BTNRESTORE.Size = New System.Drawing.Size(98, 36)
        Me.BTNRESTORE.TabIndex = 7
        Me.BTNRESTORE.Text = "Restore"
        '
        'DGVPROD
        '
        Me.DGVPROD.BackgroundColor = System.Drawing.Color.White
        Me.DGVPROD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVPROD.Location = New System.Drawing.Point(29, 130)
        Me.DGVPROD.Name = "DGVPROD"
        Me.DGVPROD.Size = New System.Drawing.Size(786, 274)
        Me.DGVPROD.TabIndex = 9
        '
        'FRMRESTORE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(844, 471)
        Me.Controls.Add(Me.DGVPROD)
        Me.Controls.Add(Me.BTNRESTORE)
        Me.Controls.Add(Me.BTNCLEAR)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.BTNFILTER)
        Me.Controls.Add(Me.Guna2DateTimePicker2)
        Me.Controls.Add(Me.Guna2DateTimePicker1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRMRESTORE"
        Me.Text = "FRMRESTORE"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DGVPROD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents LBLEXIT As Label
    Friend WithEvents Guna2DateTimePicker1 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Guna2DateTimePicker2 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents BTNFILTER As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNCLEAR As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNRESTORE As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DGVPROD As DataGridView
End Class
