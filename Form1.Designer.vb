<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSmartHome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSmartHome))
        Me.btnStats = New System.Windows.Forms.Button()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.cboMonth = New System.Windows.Forms.ComboBox()
        Me.lblStats = New System.Windows.Forms.Label()
        Me.lblAvg = New System.Windows.Forms.Label()
        Me.lblMost = New System.Windows.Forms.Label()
        Me.picSmartHome = New System.Windows.Forms.PictureBox()
        CType(Me.picSmartHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnStats
        '
        Me.btnStats.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.btnStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStats.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStats.ForeColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnStats.Location = New System.Drawing.Point(230, 380)
        Me.btnStats.Name = "btnStats"
        Me.btnStats.Size = New System.Drawing.Size(375, 55)
        Me.btnStats.TabIndex = 0
        Me.btnStats.Text = "Display Statistics"
        Me.btnStats.UseVisualStyleBackColor = False
        '
        'lblHeading
        '
        Me.lblHeading.BackColor = System.Drawing.Color.Transparent
        Me.lblHeading.Font = New System.Drawing.Font("Tahoma", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.lblHeading.Location = New System.Drawing.Point(412, 27)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(421, 126)
        Me.lblHeading.TabIndex = 1
        Me.lblHeading.Text = "Smart Home" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Electric Savings"
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboMonth
        '
        Me.cboMonth.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMonth.FormattingEnabled = True
        Me.cboMonth.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cboMonth.Location = New System.Drawing.Point(505, 197)
        Me.cboMonth.Name = "cboMonth"
        Me.cboMonth.Size = New System.Drawing.Size(253, 41)
        Me.cboMonth.TabIndex = 2
        Me.cboMonth.Text = "Select Month:"
        '
        'lblStats
        '
        Me.lblStats.BackColor = System.Drawing.Color.Transparent
        Me.lblStats.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStats.ForeColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.lblStats.Location = New System.Drawing.Point(44, 319)
        Me.lblStats.Name = "lblStats"
        Me.lblStats.Size = New System.Drawing.Size(747, 58)
        Me.lblStats.TabIndex = 3
        Me.lblStats.Text = "The electric savings for XXXXXXXX was: $XXXX"
        Me.lblStats.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAvg
        '
        Me.lblAvg.BackColor = System.Drawing.Color.Transparent
        Me.lblAvg.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.lblAvg.Location = New System.Drawing.Point(44, 447)
        Me.lblAvg.Name = "lblAvg"
        Me.lblAvg.Size = New System.Drawing.Size(747, 58)
        Me.lblAvg.TabIndex = 4
        Me.lblAvg.Text = "The average monthly savings was: $XXXX"
        Me.lblAvg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMost
        '
        Me.lblMost.BackColor = System.Drawing.Color.Transparent
        Me.lblMost.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMost.ForeColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.lblMost.Location = New System.Drawing.Point(44, 526)
        Me.lblMost.Name = "lblMost"
        Me.lblMost.Size = New System.Drawing.Size(747, 58)
        Me.lblMost.TabIndex = 5
        Me.lblMost.Text = "XXXXXXXX had the most significant monthly savings."
        Me.lblMost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picSmartHome
        '
        Me.picSmartHome.Image = CType(resources.GetObject("picSmartHome.Image"), System.Drawing.Image)
        Me.picSmartHome.Location = New System.Drawing.Point(0, 0)
        Me.picSmartHome.Name = "picSmartHome"
        Me.picSmartHome.Size = New System.Drawing.Size(415, 295)
        Me.picSmartHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSmartHome.TabIndex = 6
        Me.picSmartHome.TabStop = False
        '
        'frmSmartHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(835, 593)
        Me.Controls.Add(Me.picSmartHome)
        Me.Controls.Add(Me.lblMost)
        Me.Controls.Add(Me.lblAvg)
        Me.Controls.Add(Me.lblStats)
        Me.Controls.Add(Me.cboMonth)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.btnStats)
        Me.Name = "frmSmartHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.picSmartHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnStats As Button
    Friend WithEvents lblHeading As Label
    Friend WithEvents cboMonth As ComboBox
    Friend WithEvents lblStats As Label
    Friend WithEvents lblAvg As Label
    Friend WithEvents lblMost As Label
    Friend WithEvents picSmartHome As PictureBox
End Class
