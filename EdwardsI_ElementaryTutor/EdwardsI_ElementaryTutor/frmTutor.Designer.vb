<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTutor
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
        Me.mnuMain = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOperation = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAddition = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMultiplication = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radEarlyElementary = New System.Windows.Forms.RadioButton()
        Me.radUpperElementary = New System.Windows.Forms.RadioButton()
        Me.btnCreateList = New System.Windows.Forms.Button()
        Me.lstExamples = New System.Windows.Forms.ListBox()
        Me.mnuMain.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuMain
        '
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuOperation})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(477, 24)
        Me.mnuMain.TabIndex = 0
        Me.mnuMain.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClear, Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuOperation
        '
        Me.mnuOperation.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAddition, Me.mnuMultiplication})
        Me.mnuOperation.Name = "mnuOperation"
        Me.mnuOperation.Size = New System.Drawing.Size(72, 20)
        Me.mnuOperation.Text = "&Operation"
        '
        'mnuClear
        '
        Me.mnuClear.Name = "mnuClear"
        Me.mnuClear.Size = New System.Drawing.Size(180, 22)
        Me.mnuClear.Text = "&Clear"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(180, 22)
        Me.mnuExit.Text = "E&xit"
        '
        'mnuAddition
        '
        Me.mnuAddition.Name = "mnuAddition"
        Me.mnuAddition.Size = New System.Drawing.Size(180, 22)
        Me.mnuAddition.Text = "&Addition"
        '
        'mnuMultiplication
        '
        Me.mnuMultiplication.Name = "mnuMultiplication"
        Me.mnuMultiplication.Size = New System.Drawing.Size(180, 22)
        Me.mnuMultiplication.Text = "&Multiplication"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radUpperElementary)
        Me.GroupBox1.Controls.Add(Me.radEarlyElementary)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 62)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(183, 101)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Grade Level"
        '
        'radEarlyElementary
        '
        Me.radEarlyElementary.AutoSize = True
        Me.radEarlyElementary.Location = New System.Drawing.Point(7, 20)
        Me.radEarlyElementary.Name = "radEarlyElementary"
        Me.radEarlyElementary.Size = New System.Drawing.Size(103, 17)
        Me.radEarlyElementary.TabIndex = 0
        Me.radEarlyElementary.TabStop = True
        Me.radEarlyElementary.Text = "Early Elementary"
        Me.radEarlyElementary.UseVisualStyleBackColor = True
        '
        'radUpperElementary
        '
        Me.radUpperElementary.AutoSize = True
        Me.radUpperElementary.Location = New System.Drawing.Point(7, 54)
        Me.radUpperElementary.Name = "radUpperElementary"
        Me.radUpperElementary.Size = New System.Drawing.Size(109, 17)
        Me.radUpperElementary.TabIndex = 1
        Me.radUpperElementary.TabStop = True
        Me.radUpperElementary.Text = "Upper Elementary"
        Me.radUpperElementary.UseVisualStyleBackColor = True
        '
        'btnCreateList
        '
        Me.btnCreateList.Location = New System.Drawing.Point(12, 186)
        Me.btnCreateList.Name = "btnCreateList"
        Me.btnCreateList.Size = New System.Drawing.Size(75, 23)
        Me.btnCreateList.TabIndex = 2
        Me.btnCreateList.Text = "Create List"
        Me.btnCreateList.UseVisualStyleBackColor = True
        '
        'lstExamples
        '
        Me.lstExamples.FormattingEnabled = True
        Me.lstExamples.Location = New System.Drawing.Point(285, 59)
        Me.lstExamples.Name = "lstExamples"
        Me.lstExamples.Size = New System.Drawing.Size(131, 173)
        Me.lstExamples.TabIndex = 3
        '
        'frmTutor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 271)
        Me.Controls.Add(Me.lstExamples)
        Me.Controls.Add(Me.btnCreateList)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.mnuMain)
        Me.MainMenuStrip = Me.mnuMain
        Me.Name = "frmTutor"
        Me.Text = "Elementary Math Tutor"
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuMain As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuClear As ToolStripMenuItem
    Friend WithEvents mnuOperation As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents mnuAddition As ToolStripMenuItem
    Friend WithEvents mnuMultiplication As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radEarlyElementary As RadioButton
    Friend WithEvents radUpperElementary As RadioButton
    Friend WithEvents btnCreateList As Button
    Friend WithEvents lstExamples As ListBox
End Class
