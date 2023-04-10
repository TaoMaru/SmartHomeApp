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
        Me.btnStats.Location = New System.Drawing.Point(254, 359)
        Me.btnStats.Name = "btnStats"
        Me.btnStats.Size = New System.Drawing.Size(326, 55)
        Me.btnStats.TabIndex = 0
        Me.btnStats.Text = "Button1"
        Me.btnStats.UseVisualStyleBackColor = True
        '
        'lblHeading
        '
        Me.lblHeading.Location = New System.Drawing.Point(423, 38)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(389, 90)
        Me.lblHeading.TabIndex = 1
        Me.lblHeading.Text = "Label1"
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
        Me.lblStats.Location = New System.Drawing.Point(151, 282)
        Me.lblStats.Name = "lblStats"
        Me.lblStats.Size = New System.Drawing.Size(532, 58)
        Me.lblStats.TabIndex = 3
        Me.lblStats.Text = "Label2"
        '
        'lblAvg
        '
        Me.lblAvg.Location = New System.Drawing.Point(151, 438)
        Me.lblAvg.Name = "lblAvg"
        Me.lblAvg.Size = New System.Drawing.Size(532, 58)
        Me.lblAvg.TabIndex = 4
        Me.lblAvg.Text = "Label3"
        '
        'lblMost
        '
        Me.lblMost.Location = New System.Drawing.Point(151, 514)
        Me.lblMost.Name = "lblMost"
        Me.lblMost.Size = New System.Drawing.Size(532, 58)
        Me.lblMost.TabIndex = 5
        Me.lblMost.Text = "Label4"
        '
        'picSmartHome
        '
        Me.picSmartHome.Location = New System.Drawing.Point(0, 0)
        Me.picSmartHome.Name = "picSmartHome"
        Me.picSmartHome.Size = New System.Drawing.Size(405, 267)
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
