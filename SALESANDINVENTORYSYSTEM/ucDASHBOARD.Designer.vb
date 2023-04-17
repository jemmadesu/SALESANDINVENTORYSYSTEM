<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucDASHBOARD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucDASHBOARD))
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblsales = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblexp = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.lblproducts = New System.Windows.Forms.Label()
        Me.pictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel2.SuspendLayout()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel8
        '
        Me.Panel8.Location = New System.Drawing.Point(1015, 331)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(267, 395)
        Me.Panel8.TabIndex = 42
        '
        'Panel7
        '
        Me.Panel7.Location = New System.Drawing.Point(1015, 75)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(267, 228)
        Me.Panel7.TabIndex = 41
        '
        'Panel6
        '
        Me.Panel6.Location = New System.Drawing.Point(40, 498)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(953, 228)
        Me.Panel6.TabIndex = 40
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.lblsales)
        Me.Panel5.Controls.Add(Me.PictureBox5)
        Me.Panel5.Controls.Add(Me.Label10)
        Me.Panel5.Location = New System.Drawing.Point(761, 78)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(232, 81)
        Me.Panel5.TabIndex = 37
        '
        'lblsales
        '
        Me.lblsales.AutoSize = True
        Me.lblsales.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsales.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblsales.Location = New System.Drawing.Point(82, 40)
        Me.lblsales.Name = "lblsales"
        Me.lblsales.Size = New System.Drawing.Size(24, 25)
        Me.lblsales.TabIndex = 22
        Me.lblsales.Text = "0"
        '
        'PictureBox5
        '
        Me.PictureBox5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.ImageLocation = ""
        Me.PictureBox5.Location = New System.Drawing.Point(8, 8)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(68, 66)
        Me.PictureBox5.TabIndex = 21
        Me.PictureBox5.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label10.Location = New System.Drawing.Point(82, 8)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 21)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Sales"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.lblexp)
        Me.Panel4.Controls.Add(Me.PictureBox4)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Location = New System.Drawing.Point(522, 78)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(232, 81)
        Me.Panel4.TabIndex = 38
        '
        'lblexp
        '
        Me.lblexp.AutoSize = True
        Me.lblexp.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblexp.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblexp.Location = New System.Drawing.Point(82, 40)
        Me.lblexp.Name = "lblexp"
        Me.lblexp.Size = New System.Drawing.Size(24, 25)
        Me.lblexp.TabIndex = 22
        Me.lblexp.Text = "0"
        '
        'PictureBox4
        '
        Me.PictureBox4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.ImageLocation = ""
        Me.PictureBox4.Location = New System.Drawing.Point(8, 8)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(68, 66)
        Me.PictureBox4.TabIndex = 21
        Me.PictureBox4.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label8.Location = New System.Drawing.Point(82, 8)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(139, 21)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Expired Products"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Location = New System.Drawing.Point(278, 78)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(232, 81)
        Me.Panel3.TabIndex = 36
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(82, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 25)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "0"
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.ImageLocation = ""
        Me.PictureBox2.Location = New System.Drawing.Point(8, 8)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(68, 66)
        Me.PictureBox2.TabIndex = 21
        Me.PictureBox2.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(82, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 21)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "New Products"
        '
        'panel2
        '
        Me.panel2.Controls.Add(Me.lblproducts)
        Me.panel2.Controls.Add(Me.pictureBox3)
        Me.panel2.Controls.Add(Me.Label2)
        Me.panel2.Location = New System.Drawing.Point(40, 78)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(232, 81)
        Me.panel2.TabIndex = 35
        '
        'lblproducts
        '
        Me.lblproducts.AutoSize = True
        Me.lblproducts.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblproducts.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblproducts.Location = New System.Drawing.Point(82, 40)
        Me.lblproducts.Name = "lblproducts"
        Me.lblproducts.Size = New System.Drawing.Size(24, 25)
        Me.lblproducts.TabIndex = 22
        Me.lblproducts.Text = "0"
        '
        'pictureBox3
        '
        Me.pictureBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pictureBox3.Image = CType(resources.GetObject("pictureBox3.Image"), System.Drawing.Image)
        Me.pictureBox3.ImageLocation = ""
        Me.pictureBox3.Location = New System.Drawing.Point(8, 8)
        Me.pictureBox3.Name = "pictureBox3"
        Me.pictureBox3.Size = New System.Drawing.Size(68, 66)
        Me.pictureBox3.TabIndex = 21
        Me.pictureBox3.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(82, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 21)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Products"
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(28, 177)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Total Sales"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(965, 300)
        Me.Chart1.TabIndex = 43
        Me.Chart1.Text = "Chart1"
        '
        'ucDASHBOARD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.panel2)
        Me.Name = "ucDASHBOARD"
        Me.Size = New System.Drawing.Size(1322, 801)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel2.ResumeLayout(False)
        Me.panel2.PerformLayout()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel6 As Panel
    Private WithEvents Panel5 As Panel
    Private WithEvents lblsales As Label
    Private WithEvents PictureBox5 As PictureBox
    Private WithEvents Label10 As Label
    Private WithEvents Panel4 As Panel
    Private WithEvents lblexp As Label
    Private WithEvents PictureBox4 As PictureBox
    Private WithEvents Label8 As Label
    Private WithEvents Panel3 As Panel
    Private WithEvents Label5 As Label
    Private WithEvents PictureBox2 As PictureBox
    Private WithEvents Label6 As Label
    Private WithEvents panel2 As Panel
    Private WithEvents lblproducts As Label
    Private WithEvents pictureBox3 As PictureBox
    Private WithEvents Label2 As Label
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
End Class
