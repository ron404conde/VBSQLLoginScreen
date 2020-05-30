<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSplashScreen
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSplashScreen))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pgbLoading = New System.Windows.Forms.ProgressBar()
        Me.TimerFadeIn = New System.Windows.Forms.Timer(Me.components)
        Me.TimerFadeOut = New System.Windows.Forms.Timer(Me.components)
        Me.TimerLoading = New System.Windows.Forms.Timer(Me.components)
        Me.lblPreparing = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(256, 251)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(186, 146)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'pgbLoading
        '
        Me.pgbLoading.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pgbLoading.Location = New System.Drawing.Point(581, 352)
        Me.pgbLoading.Name = "pgbLoading"
        Me.pgbLoading.Size = New System.Drawing.Size(105, 14)
        Me.pgbLoading.TabIndex = 7
        Me.pgbLoading.Visible = False
        '
        'TimerFadeIn
        '
        Me.TimerFadeIn.Enabled = True
        Me.TimerFadeIn.Interval = 5
        '
        'TimerFadeOut
        '
        Me.TimerFadeOut.Interval = 1700
        '
        'TimerLoading
        '
        '
        'lblPreparing
        '
        Me.lblPreparing.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblPreparing.AutoSize = True
        Me.lblPreparing.BackColor = System.Drawing.Color.Transparent
        Me.lblPreparing.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreparing.ForeColor = System.Drawing.Color.Black
        Me.lblPreparing.Location = New System.Drawing.Point(15, 349)
        Me.lblPreparing.Name = "lblPreparing"
        Me.lblPreparing.Size = New System.Drawing.Size(82, 17)
        Me.lblPreparing.TabIndex = 6
        Me.lblPreparing.Text = "Preparing . . ."
        Me.lblPreparing.Visible = False
        '
        'frmSplashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(698, 378)
        Me.ControlBox = False
        Me.Controls.Add(Me.pgbLoading)
        Me.Controls.Add(Me.lblPreparing)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmSplashScreen"
        Me.Opacity = 0.0R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pgbLoading As System.Windows.Forms.ProgressBar
    Friend WithEvents TimerFadeIn As System.Windows.Forms.Timer
    Friend WithEvents TimerFadeOut As System.Windows.Forms.Timer
    Friend WithEvents TimerLoading As System.Windows.Forms.Timer
    Friend WithEvents lblPreparing As System.Windows.Forms.Label
End Class
