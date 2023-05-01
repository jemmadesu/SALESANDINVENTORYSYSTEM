<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucOUTOFSTOCKS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucOUTOFSTOCKS))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BTNBACK = New System.Windows.Forms.Button()
        Me.DGVOUTOFSTOCKS = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BTNARCHIVE = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        CType(Me.DGVOUTOFSTOCKS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panel2.Controls.Add(Me.BTNBACK)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1322, 49)
        Me.Panel2.TabIndex = 48
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
        Me.BTNBACK.Location = New System.Drawing.Point(1197, 3)
        Me.BTNBACK.Name = "BTNBACK"
        Me.BTNBACK.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.BTNBACK.Size = New System.Drawing.Size(119, 46)
        Me.BTNBACK.TabIndex = 3
        Me.BTNBACK.Text = " Back"
        Me.BTNBACK.UseVisualStyleBackColor = False
        '
        'DGVOUTOFSTOCKS
        '
        Me.DGVOUTOFSTOCKS.AllowUserToAddRows = False
        Me.DGVOUTOFSTOCKS.AllowUserToDeleteRows = False
        Me.DGVOUTOFSTOCKS.BackgroundColor = System.Drawing.Color.White
        Me.DGVOUTOFSTOCKS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVOUTOFSTOCKS.Location = New System.Drawing.Point(63, 157)
        Me.DGVOUTOFSTOCKS.Name = "DGVOUTOFSTOCKS"
        Me.DGVOUTOFSTOCKS.ReadOnly = True
        Me.DGVOUTOFSTOCKS.RowHeadersVisible = False
        Me.DGVOUTOFSTOCKS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVOUTOFSTOCKS.Size = New System.Drawing.Size(1163, 562)
        Me.DGVOUTOFSTOCKS.TabIndex = 75
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.Label8.Location = New System.Drawing.Point(57, 79)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(219, 32)
        Me.Label8.TabIndex = 73
        Me.Label8.Text = "OUT OF STOCKS"
        '
        'BTNARCHIVE
        '
        Me.BTNARCHIVE.BackColor = System.Drawing.Color.Gray
        Me.BTNARCHIVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNARCHIVE.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNARCHIVE.ForeColor = System.Drawing.Color.White
        Me.BTNARCHIVE.Location = New System.Drawing.Point(1102, 740)
        Me.BTNARCHIVE.Name = "BTNARCHIVE"
        Me.BTNARCHIVE.Size = New System.Drawing.Size(124, 34)
        Me.BTNARCHIVE.TabIndex = 76
        Me.BTNARCHIVE.Text = "Archive"
        Me.BTNARCHIVE.UseVisualStyleBackColor = False
        '
        'ucOUTOFSTOCKS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.BTNARCHIVE)
        Me.Controls.Add(Me.DGVOUTOFSTOCKS)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "ucOUTOFSTOCKS"
        Me.Size = New System.Drawing.Size(1322, 801)
        Me.Panel2.ResumeLayout(False)
        CType(Me.DGVOUTOFSTOCKS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents BTNBACK As Button
    Friend WithEvents DGVOUTOFSTOCKS As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents BTNARCHIVE As Button
End Class
