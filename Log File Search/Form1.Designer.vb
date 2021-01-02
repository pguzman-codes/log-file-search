<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.txtSource = New System.Windows.Forms.TextBox()
        Me.txtSave = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnSource = New System.Windows.Forms.Button()
        Me.btnProcess = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtExclude = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.numAfter = New System.Windows.Forms.NumericUpDown()
        Me.numBefore = New System.Windows.Forms.NumericUpDown()
        Me.chkAfter = New System.Windows.Forms.CheckBox()
        Me.chkBefore = New System.Windows.Forms.CheckBox()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.numAfter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numBefore, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Log|*.log"
        Me.OpenFileDialog1.Multiselect = True
        Me.OpenFileDialog1.RestoreDirectory = True
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.CreatePrompt = True
        Me.SaveFileDialog1.DefaultExt = "txt"
        Me.SaveFileDialog1.Filter = "Text file|*.txt"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripProgressBar1, Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 414)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(333, 22)
        Me.StatusStrip1.TabIndex = 10
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(100, 16)
        Me.ToolStripProgressBar1.Step = 1
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(119, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(115, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Select source file(s):"
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.BackColor = System.Drawing.Color.LightGreen
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Location = New System.Drawing.Point(49, 160)
        Me.txtSearch.Multiline = True
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(235, 19)
        Me.txtSearch.TabIndex = 26
        '
        'txtSource
        '
        Me.txtSource.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSource.Enabled = False
        Me.txtSource.Location = New System.Drawing.Point(49, 37)
        Me.txtSource.Name = "txtSource"
        Me.txtSource.Size = New System.Drawing.Size(154, 20)
        Me.txtSource.TabIndex = 18
        '
        'txtSave
        '
        Me.txtSave.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSave.Enabled = False
        Me.txtSave.Location = New System.Drawing.Point(49, 102)
        Me.txtSave.Name = "txtSave"
        Me.txtSave.Size = New System.Drawing.Size(154, 20)
        Me.txtSave.TabIndex = 22
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(101, 144)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(130, 13)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Word or phrase to search:"
        '
        'btnSource
        '
        Me.btnSource.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSource.Location = New System.Drawing.Point(209, 35)
        Me.btnSource.Name = "btnSource"
        Me.btnSource.Size = New System.Drawing.Size(75, 23)
        Me.btnSource.TabIndex = 20
        Me.btnSource.Text = "Open"
        Me.btnSource.UseVisualStyleBackColor = True
        '
        'btnProcess
        '
        Me.btnProcess.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnProcess.Location = New System.Drawing.Point(129, 388)
        Me.btnProcess.MinimumSize = New System.Drawing.Size(0, 23)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(75, 23)
        Me.btnProcess.TabIndex = 24
        Me.btnProcess.Text = "Process"
        Me.btnProcess.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(111, 86)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(110, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Select destination file:"
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Location = New System.Drawing.Point(209, 100)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 23
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtExclude
        '
        Me.txtExclude.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtExclude.BackColor = System.Drawing.Color.Tomato
        Me.txtExclude.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtExclude.Location = New System.Drawing.Point(49, 207)
        Me.txtExclude.Multiline = True
        Me.txtExclude.Name = "txtExclude"
        Me.txtExclude.Size = New System.Drawing.Size(235, 19)
        Me.txtExclude.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(99, 191)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Word or phrase to exclude:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.numAfter)
        Me.GroupBox1.Controls.Add(Me.numBefore)
        Me.GroupBox1.Controls.Add(Me.chkAfter)
        Me.GroupBox1.Controls.Add(Me.chkBefore)
        Me.GroupBox1.Location = New System.Drawing.Point(68, 243)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 73)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lines to Include in Results"
        '
        'numAfter
        '
        Me.numAfter.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.numAfter.Enabled = False
        Me.numAfter.Location = New System.Drawing.Point(119, 39)
        Me.numAfter.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numAfter.Name = "numAfter"
        Me.numAfter.Size = New System.Drawing.Size(56, 20)
        Me.numAfter.TabIndex = 31
        Me.numAfter.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'numBefore
        '
        Me.numBefore.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.numBefore.Enabled = False
        Me.numBefore.Location = New System.Drawing.Point(119, 16)
        Me.numBefore.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numBefore.Name = "numBefore"
        Me.numBefore.Size = New System.Drawing.Size(56, 20)
        Me.numBefore.TabIndex = 30
        Me.numBefore.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'chkAfter
        '
        Me.chkAfter.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chkAfter.AutoSize = True
        Me.chkAfter.Location = New System.Drawing.Point(25, 42)
        Me.chkAfter.Name = "chkAfter"
        Me.chkAfter.Size = New System.Drawing.Size(79, 17)
        Me.chkAfter.TabIndex = 30
        Me.chkAfter.Text = "Lines After:"
        Me.chkAfter.UseVisualStyleBackColor = True
        '
        'chkBefore
        '
        Me.chkBefore.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chkBefore.AutoSize = True
        Me.chkBefore.Location = New System.Drawing.Point(25, 19)
        Me.chkBefore.Name = "chkBefore"
        Me.chkBefore.Size = New System.Drawing.Size(88, 17)
        Me.chkBefore.TabIndex = 30
        Me.chkBefore.Text = "Lines Before:"
        Me.chkBefore.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(333, 436)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtExclude)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.txtSource)
        Me.Controls.Add(Me.txtSave)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnSource)
        Me.Controls.Add(Me.btnProcess)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.StatusStrip1)
        Me.MinimumSize = New System.Drawing.Size(349, 475)
        Me.Name = "Form1"
        Me.Text = "Log File Search"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.numAfter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numBefore, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripProgressBar1 As ToolStripProgressBar
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents Label7 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents txtSource As TextBox
    Friend WithEvents txtSave As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnSource As Button
    Friend WithEvents btnProcess As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents txtExclude As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents numAfter As NumericUpDown
    Friend WithEvents numBefore As NumericUpDown
    Friend WithEvents chkAfter As CheckBox
    Friend WithEvents chkBefore As CheckBox
End Class
