<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LBLEXIT = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DGVEXP = New System.Windows.Forms.DataGridView()
        Me.Panel2.SuspendLayout()
        CType(Me.DGVEXP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panel2.Controls.Add(Me.LBLEXIT)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1306, 49)
        Me.Panel2.TabIndex = 129
        '
        'LBLEXIT
        '
        Me.LBLEXIT.AutoSize = True
        Me.LBLEXIT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LBLEXIT.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLEXIT.ForeColor = System.Drawing.Color.White
        Me.LBLEXIT.Location = New System.Drawing.Point(1239, 9)
        Me.LBLEXIT.Name = "LBLEXIT"
        Me.LBLEXIT.Size = New System.Drawing.Size(30, 32)
        Me.LBLEXIT.TabIndex = 135
        Me.LBLEXIT.Text = "x"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.Label8.Location = New System.Drawing.Point(40, 77)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(229, 32)
        Me.Label8.TabIndex = 134
        Me.Label8.Text = "NEARLY-EXPIRED"
        '
        'DGVEXP
        '
        Me.DGVEXP.AllowUserToAddRows = False
        Me.DGVEXP.AllowUserToDeleteRows = False
        Me.DGVEXP.BackgroundColor = System.Drawing.Color.White
        Me.DGVEXP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVEXP.Location = New System.Drawing.Point(54, 136)
        Me.DGVEXP.Name = "DGVEXP"
        Me.DGVEXP.ReadOnly = True
        Me.DGVEXP.RowHeadersVisible = False
        Me.DGVEXP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVEXP.Size = New System.Drawing.Size(1181, 573)
        Me.DGVEXP.TabIndex = 133
        '
        'FRMNEAREXPIRY
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1306, 762)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.DGVEXP)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRMNEAREXPIRY"
        Me.Text = "FRMNEAREXPIRY"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DGVEXP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents DGVEXP As DataGridView
    Friend WithEvents LBLEXIT As Label
End Class
