<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMBACKUP
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
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BACKPROD = New Guna.UI2.WinForms.Guna2Button()
        Me.DGVPROD = New System.Windows.Forms.DataGridView()
        Me.Panel5.SuspendLayout()
        CType(Me.DGVPROD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Location = New System.Drawing.Point(-2, -3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(846, 59)
        Me.Panel5.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(27, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 20)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "Backup Tab"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(787, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 32)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "x"
        '
        'BACKPROD
        '
        Me.BACKPROD.CheckedState.Parent = Me.BACKPROD
        Me.BACKPROD.CustomImages.Parent = Me.BACKPROD
        Me.BACKPROD.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.BACKPROD.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BACKPROD.ForeColor = System.Drawing.Color.White
        Me.BACKPROD.HoverState.Parent = Me.BACKPROD
        Me.BACKPROD.Location = New System.Drawing.Point(717, 423)
        Me.BACKPROD.Name = "BACKPROD"
        Me.BACKPROD.ShadowDecoration.Parent = Me.BACKPROD
        Me.BACKPROD.Size = New System.Drawing.Size(98, 36)
        Me.BACKPROD.TabIndex = 7
        Me.BACKPROD.Text = "Backup"
        '
        'DGVPROD
        '
        Me.DGVPROD.BackgroundColor = System.Drawing.Color.White
        Me.DGVPROD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVPROD.Location = New System.Drawing.Point(29, 78)
        Me.DGVPROD.Name = "DGVPROD"
        Me.DGVPROD.Size = New System.Drawing.Size(786, 328)
        Me.DGVPROD.TabIndex = 8
        '
        'FRMBACKUP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 471)
        Me.Controls.Add(Me.DGVPROD)
        Me.Controls.Add(Me.BACKPROD)
        Me.Controls.Add(Me.Panel5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRMBACKUP"
        Me.Text = "FRMBACKUP"
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.DGVPROD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents BACKPROD As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DGVPROD As DataGridView
End Class
