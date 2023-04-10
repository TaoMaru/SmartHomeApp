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
        Me.btnStats.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStats.Location = New System.Drawing.Point(230, 380)
        Me.btnStats.Name = "btnStats"
        Me.btnStats.Size = New System.Drawing.Size(375, 55)
        Me.btnStats.TabIndex = 0
        Me.btnStats.Text = "Display Statistics"
        Me.btnStats.UseVisualStyleBackColor = True
        '
        'lblHeading
        '
        Me.lblHeading.Font = New System.Drawing.Font("Tahoma", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(434, 9)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(389, 126)
        Me.lblHeading.TabIndex = 1
        Me.lblHeading.Text = "Smart Home" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Electric Savings"
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboMonth
        '
        Me.cboMonth.FormattingEnabled = True
        Me.cboMonth.Location = New System.Drawing.Point(557, 194)
        Me.cboMonth.Name = "cboMonth"
        Me.cboMonth.Size = New System.Drawing.Size(121, 24)
        Me.cboMonth.TabIndex = 2
        '
        'lblStats
        '
        Me.lblStats.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStats.Location = New System.Drawing.Point(44, 319)
        Me.lblStats.Name = "lblStats"
        Me.lblStats.Size = New System.Drawing.Size(747, 58)
        Me.lblStats.TabIndex = 3
        Me.lblStats.Text = "The electric savings for XXXXXXXX was: $XXXX"
        Me.lblStats.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAvg
        '
        Me.lblAvg.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvg.Location = New System.Drawing.Point(44, 447)
        Me.lblAvg.Name = "lblAvg"
        Me.lblAvg.Size = New System.Drawing.Size(747, 58)
        Me.lblAvg.TabIndex = 4
        Me.lblAvg.Text = "The average monthly savings was: $XXXX"
        Me.lblAvg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMost
        '
        Me.lblMost.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.ClientSize = New System.Drawing.Size(835, 593)
        Me.Controls.Add(Me.picSmartHome)
        Me.Controls.Add(Me.lblMost)
        Me.Controls.Add(Me.lblAvg)
        Me.Controls.Add(Me.lblStats)
        Me.Controls.Add(Me.cboMonth)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.btnStats)
        Me.Name = "frmSmartHome"
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
