<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TextSeparatorForm
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
        Me.dgvSeparated = New System.Windows.Forms.DataGridView()
        Me.txtNUMBER_OF_CHARACTERS = New System.Windows.Forms.TextBox()
        Me.txtNUMBER_OF_REPEAT_CHARACTERS = New System.Windows.Forms.TextBox()
        Me.lbltxtNUMBER_OF_CHARACTERS = New System.Windows.Forms.Label()
        Me.lbltxtNUMBER_OF_REPEAT_CHARACTERS = New System.Windows.Forms.Label()
        Me.bttSeparate = New System.Windows.Forms.Button()
        Me.txtContentPath = New System.Windows.Forms.TextBox()
        Me.txtPreText = New System.Windows.Forms.TextBox()
        Me.lblPretext = New System.Windows.Forms.Label()
        Me.bttOpenStory = New System.Windows.Forms.Button()
        Me.txtGrammarPath = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.bttOpenGrammar = New System.Windows.Forms.Button()
        Me.ToolTipForAllControls = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HowDoIUseThisProgrammanualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckForTheNewestVersionOfTheProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckForTheLatestGrammarResourceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GetRandomStoriesToTestTheProgramOnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutTheAuthorOfThisProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtCommentCopy = New System.Windows.Forms.TextBox()
        Me.ReportABugImprovementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabSeparatorControl = New System.Windows.Forms.TabControl()
        Me.TabGrammar = New System.Windows.Forms.TabPage()
        Me.TabSeparator = New System.Windows.Forms.TabPage()
        Me.COLUMN_TEXT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NUMBER = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ENTERED = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.VersionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgvSeparated, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.TabSeparatorControl.SuspendLayout()
        Me.TabGrammar.SuspendLayout()
        Me.TabSeparator.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvSeparated
        '
        Me.dgvSeparated.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvSeparated.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSeparated.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.COLUMN_TEXT, Me.NUMBER, Me.ENTERED})
        Me.dgvSeparated.Location = New System.Drawing.Point(0, 27)
        Me.dgvSeparated.Name = "dgvSeparated"
        Me.dgvSeparated.RowHeadersVisible = False
        Me.dgvSeparated.Size = New System.Drawing.Size(741, 462)
        Me.dgvSeparated.TabIndex = 0
        '
        'txtNUMBER_OF_CHARACTERS
        '
        Me.txtNUMBER_OF_CHARACTERS.Location = New System.Drawing.Point(251, 31)
        Me.txtNUMBER_OF_CHARACTERS.Name = "txtNUMBER_OF_CHARACTERS"
        Me.txtNUMBER_OF_CHARACTERS.Size = New System.Drawing.Size(100, 20)
        Me.txtNUMBER_OF_CHARACTERS.TabIndex = 1
        Me.txtNUMBER_OF_CHARACTERS.Text = "50000"
        '
        'txtNUMBER_OF_REPEAT_CHARACTERS
        '
        Me.txtNUMBER_OF_REPEAT_CHARACTERS.Location = New System.Drawing.Point(251, 57)
        Me.txtNUMBER_OF_REPEAT_CHARACTERS.Name = "txtNUMBER_OF_REPEAT_CHARACTERS"
        Me.txtNUMBER_OF_REPEAT_CHARACTERS.Size = New System.Drawing.Size(100, 20)
        Me.txtNUMBER_OF_REPEAT_CHARACTERS.TabIndex = 2
        Me.txtNUMBER_OF_REPEAT_CHARACTERS.Text = "15"
        '
        'lbltxtNUMBER_OF_CHARACTERS
        '
        Me.lbltxtNUMBER_OF_CHARACTERS.Location = New System.Drawing.Point(49, 30)
        Me.lbltxtNUMBER_OF_CHARACTERS.Name = "lbltxtNUMBER_OF_CHARACTERS"
        Me.lbltxtNUMBER_OF_CHARACTERS.Size = New System.Drawing.Size(196, 20)
        Me.lbltxtNUMBER_OF_CHARACTERS.TabIndex = 62
        Me.lbltxtNUMBER_OF_CHARACTERS.Text = "Number of characters in one segment"
        Me.lbltxtNUMBER_OF_CHARACTERS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbltxtNUMBER_OF_REPEAT_CHARACTERS
        '
        Me.lbltxtNUMBER_OF_REPEAT_CHARACTERS.Location = New System.Drawing.Point(0, 56)
        Me.lbltxtNUMBER_OF_REPEAT_CHARACTERS.Name = "lbltxtNUMBER_OF_REPEAT_CHARACTERS"
        Me.lbltxtNUMBER_OF_REPEAT_CHARACTERS.Size = New System.Drawing.Size(245, 20)
        Me.lbltxtNUMBER_OF_REPEAT_CHARACTERS.TabIndex = 63
        Me.lbltxtNUMBER_OF_REPEAT_CHARACTERS.Text = "Repeated characters from the end of previous line"
        Me.lbltxtNUMBER_OF_REPEAT_CHARACTERS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'bttSeparate
        '
        Me.bttSeparate.Location = New System.Drawing.Point(357, 3)
        Me.bttSeparate.Name = "bttSeparate"
        Me.bttSeparate.Size = New System.Drawing.Size(172, 23)
        Me.bttSeparate.TabIndex = 65
        Me.bttSeparate.Text = "Separate text on equal segments"
        Me.bttSeparate.UseVisualStyleBackColor = True
        '
        'txtContentPath
        '
        Me.txtContentPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtContentPath.Location = New System.Drawing.Point(12, 604)
        Me.txtContentPath.Name = "txtContentPath"
        Me.txtContentPath.Size = New System.Drawing.Size(729, 20)
        Me.txtContentPath.TabIndex = 66
        Me.txtContentPath.Text = "C:\A_story_that_needs_editing.txt"
        Me.ToolTipForAllControls.SetToolTip(Me.txtContentPath, "Double click to select the path or just write it in the field")
        '
        'txtPreText
        '
        Me.txtPreText.Location = New System.Drawing.Point(251, 5)
        Me.txtPreText.Name = "txtPreText"
        Me.txtPreText.Size = New System.Drawing.Size(100, 20)
        Me.txtPreText.TabIndex = 67
        Me.txtPreText.Text = "00_"
        '
        'lblPretext
        '
        Me.lblPretext.Location = New System.Drawing.Point(101, 4)
        Me.lblPretext.Name = "lblPretext"
        Me.lblPretext.Size = New System.Drawing.Size(144, 20)
        Me.lblPretext.TabIndex = 68
        Me.lblPretext.Text = "preText in Data field"
        Me.lblPretext.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'bttOpenStory
        '
        Me.bttOpenStory.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttOpenStory.Location = New System.Drawing.Point(12, 627)
        Me.bttOpenStory.Name = "bttOpenStory"
        Me.bttOpenStory.Size = New System.Drawing.Size(101, 23)
        Me.bttOpenStory.TabIndex = 69
        Me.bttOpenStory.Text = "Open story file"
        Me.bttOpenStory.UseVisualStyleBackColor = True
        '
        'txtGrammarPath
        '
        Me.txtGrammarPath.Location = New System.Drawing.Point(8, 6)
        Me.txtGrammarPath.Name = "txtGrammarPath"
        Me.txtGrammarPath.Size = New System.Drawing.Size(345, 20)
        Me.txtGrammarPath.TabIndex = 70
        Me.txtGrammarPath.Text = "C:\Grammar.txt"
        Me.ToolTipForAllControls.SetToolTip(Me.txtGrammarPath, "Double click to select the path or just write it in the field")
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(357, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 23)
        Me.Button1.TabIndex = 71
        Me.Button1.Text = "Run grammar check"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'bttOpenGrammar
        '
        Me.bttOpenGrammar.Location = New System.Drawing.Point(8, 28)
        Me.bttOpenGrammar.Name = "bttOpenGrammar"
        Me.bttOpenGrammar.Size = New System.Drawing.Size(101, 23)
        Me.bttOpenGrammar.TabIndex = 72
        Me.bttOpenGrammar.Text = "Open grammar file"
        Me.bttOpenGrammar.UseVisualStyleBackColor = True
        '
        'ToolTipForAllControls
        '
        Me.ToolTipForAllControls.AutomaticDelay = 50
        Me.ToolTipForAllControls.AutoPopDelay = 5000
        Me.ToolTipForAllControls.InitialDelay = 50
        Me.ToolTipForAllControls.ReshowDelay = 10
        Me.ToolTipForAllControls.ShowAlways = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem, Me.VersionToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(741, 24)
        Me.MenuStrip1.TabIndex = 74
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HowDoIUseThisProgrammanualToolStripMenuItem, Me.CheckForTheNewestVersionOfTheProgramToolStripMenuItem, Me.CheckForTheLatestGrammarResourceToolStripMenuItem, Me.GetRandomStoriesToTestTheProgramOnToolStripMenuItem, Me.ReportABugImprovementToolStripMenuItem, Me.AboutTheAuthorOfThisProgramToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'HowDoIUseThisProgrammanualToolStripMenuItem
        '
        Me.HowDoIUseThisProgrammanualToolStripMenuItem.Name = "HowDoIUseThisProgrammanualToolStripMenuItem"
        Me.HowDoIUseThisProgrammanualToolStripMenuItem.Size = New System.Drawing.Size(391, 22)
        Me.HowDoIUseThisProgrammanualToolStripMenuItem.Text = "Help, how do I use this program (the manual = user's guide)"
        '
        'CheckForTheNewestVersionOfTheProgramToolStripMenuItem
        '
        Me.CheckForTheNewestVersionOfTheProgramToolStripMenuItem.Name = "CheckForTheNewestVersionOfTheProgramToolStripMenuItem"
        Me.CheckForTheNewestVersionOfTheProgramToolStripMenuItem.Size = New System.Drawing.Size(391, 22)
        Me.CheckForTheNewestVersionOfTheProgramToolStripMenuItem.Text = "Check for the newest version of the program"
        '
        'CheckForTheLatestGrammarResourceToolStripMenuItem
        '
        Me.CheckForTheLatestGrammarResourceToolStripMenuItem.Name = "CheckForTheLatestGrammarResourceToolStripMenuItem"
        Me.CheckForTheLatestGrammarResourceToolStripMenuItem.Size = New System.Drawing.Size(391, 22)
        Me.CheckForTheLatestGrammarResourceToolStripMenuItem.Text = "Get the latest Grammar resource"
        '
        'GetRandomStoriesToTestTheProgramOnToolStripMenuItem
        '
        Me.GetRandomStoriesToTestTheProgramOnToolStripMenuItem.Name = "GetRandomStoriesToTestTheProgramOnToolStripMenuItem"
        Me.GetRandomStoriesToTestTheProgramOnToolStripMenuItem.Size = New System.Drawing.Size(391, 22)
        Me.GetRandomStoriesToTestTheProgramOnToolStripMenuItem.Text = "Find random stories to test this program on"
        '
        'AboutTheAuthorOfThisProgramToolStripMenuItem
        '
        Me.AboutTheAuthorOfThisProgramToolStripMenuItem.Name = "AboutTheAuthorOfThisProgramToolStripMenuItem"
        Me.AboutTheAuthorOfThisProgramToolStripMenuItem.Size = New System.Drawing.Size(391, 22)
        Me.AboutTheAuthorOfThisProgramToolStripMenuItem.Text = "Contact the author"
        '
        'txtCommentCopy
        '
        Me.txtCommentCopy.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCommentCopy.Location = New System.Drawing.Point(0, 489)
        Me.txtCommentCopy.Multiline = True
        Me.txtCommentCopy.Name = "txtCommentCopy"
        Me.txtCommentCopy.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtCommentCopy.Size = New System.Drawing.Size(741, 112)
        Me.txtCommentCopy.TabIndex = 76
        '
        'ReportABugImprovementToolStripMenuItem
        '
        Me.ReportABugImprovementToolStripMenuItem.Name = "ReportABugImprovementToolStripMenuItem"
        Me.ReportABugImprovementToolStripMenuItem.Size = New System.Drawing.Size(391, 22)
        Me.ReportABugImprovementToolStripMenuItem.Text = "Report a bug or suggest an improvement on GitHub"
        '
        'TabSeparatorControl
        '
        Me.TabSeparatorControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabSeparatorControl.Controls.Add(Me.TabGrammar)
        Me.TabSeparatorControl.Controls.Add(Me.TabSeparator)
        Me.TabSeparatorControl.Location = New System.Drawing.Point(0, 656)
        Me.TabSeparatorControl.Name = "TabSeparatorControl"
        Me.TabSeparatorControl.SelectedIndex = 0
        Me.TabSeparatorControl.Size = New System.Drawing.Size(745, 106)
        Me.TabSeparatorControl.TabIndex = 77
        '
        'TabGrammar
        '
        Me.TabGrammar.Controls.Add(Me.txtGrammarPath)
        Me.TabGrammar.Controls.Add(Me.bttOpenGrammar)
        Me.TabGrammar.Controls.Add(Me.Button1)
        Me.TabGrammar.Location = New System.Drawing.Point(4, 22)
        Me.TabGrammar.Name = "TabGrammar"
        Me.TabGrammar.Padding = New System.Windows.Forms.Padding(3)
        Me.TabGrammar.Size = New System.Drawing.Size(737, 80)
        Me.TabGrammar.TabIndex = 0
        Me.TabGrammar.Text = "Grammar"
        Me.TabGrammar.UseVisualStyleBackColor = True
        '
        'TabSeparator
        '
        Me.TabSeparator.Controls.Add(Me.txtPreText)
        Me.TabSeparator.Controls.Add(Me.txtNUMBER_OF_CHARACTERS)
        Me.TabSeparator.Controls.Add(Me.txtNUMBER_OF_REPEAT_CHARACTERS)
        Me.TabSeparator.Controls.Add(Me.bttSeparate)
        Me.TabSeparator.Controls.Add(Me.lbltxtNUMBER_OF_CHARACTERS)
        Me.TabSeparator.Controls.Add(Me.lblPretext)
        Me.TabSeparator.Controls.Add(Me.lbltxtNUMBER_OF_REPEAT_CHARACTERS)
        Me.TabSeparator.Location = New System.Drawing.Point(4, 22)
        Me.TabSeparator.Name = "TabSeparator"
        Me.TabSeparator.Padding = New System.Windows.Forms.Padding(3)
        Me.TabSeparator.Size = New System.Drawing.Size(737, 80)
        Me.TabSeparator.TabIndex = 1
        Me.TabSeparator.Text = "Text Separation"
        Me.TabSeparator.UseVisualStyleBackColor = True
        '
        'COLUMN_TEXT
        '
        Me.COLUMN_TEXT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.COLUMN_TEXT.HeaderText = "Text"
        Me.COLUMN_TEXT.Name = "COLUMN_TEXT"
        '
        'NUMBER
        '
        Me.NUMBER.HeaderText = "Data"
        Me.NUMBER.Name = "NUMBER"
        Me.NUMBER.Width = 150
        '
        'ENTERED
        '
        Me.ENTERED.HeaderText = "E"
        Me.ENTERED.Name = "ENTERED"
        Me.ENTERED.ToolTipText = "This row was already entered at least once."
        Me.ENTERED.Width = 20
        '
        'VersionToolStripMenuItem
        '
        Me.VersionToolStripMenuItem.Enabled = False
        Me.VersionToolStripMenuItem.Name = "VersionToolStripMenuItem"
        Me.VersionToolStripMenuItem.Size = New System.Drawing.Size(114, 20)
        Me.VersionToolStripMenuItem.Text = "Version 2018.06.22"
        '
        'TextSeparatorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(741, 762)
        Me.Controls.Add(Me.txtContentPath)
        Me.Controls.Add(Me.bttOpenStory)
        Me.Controls.Add(Me.TabSeparatorControl)
        Me.Controls.Add(Me.txtCommentCopy)
        Me.Controls.Add(Me.dgvSeparated)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "TextSeparatorForm"
        Me.Text = "Text separator"
        CType(Me.dgvSeparated, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabSeparatorControl.ResumeLayout(False)
        Me.TabGrammar.ResumeLayout(False)
        Me.TabGrammar.PerformLayout()
        Me.TabSeparator.ResumeLayout(False)
        Me.TabSeparator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvSeparated As System.Windows.Forms.DataGridView
    Friend WithEvents txtNUMBER_OF_CHARACTERS As System.Windows.Forms.TextBox
    Friend WithEvents txtNUMBER_OF_REPEAT_CHARACTERS As System.Windows.Forms.TextBox
    Friend WithEvents lbltxtNUMBER_OF_CHARACTERS As System.Windows.Forms.Label
    Friend WithEvents lbltxtNUMBER_OF_REPEAT_CHARACTERS As System.Windows.Forms.Label
    Friend WithEvents bttSeparate As System.Windows.Forms.Button
    Friend WithEvents txtContentPath As System.Windows.Forms.TextBox
    Friend WithEvents txtPreText As System.Windows.Forms.TextBox
    Friend WithEvents lblPretext As System.Windows.Forms.Label
    Friend WithEvents bttOpenStory As System.Windows.Forms.Button
    Friend WithEvents txtGrammarPath As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents bttOpenGrammar As System.Windows.Forms.Button
    Friend WithEvents ToolTipForAllControls As System.Windows.Forms.ToolTip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HowDoIUseThisProgrammanualToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutTheAuthorOfThisProgramToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CheckForTheNewestVersionOfTheProgramToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CheckForTheLatestGrammarResourceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GetRandomStoriesToTestTheProgramOnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtCommentCopy As System.Windows.Forms.TextBox
    Friend WithEvents ReportABugImprovementToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabSeparatorControl As System.Windows.Forms.TabControl
    Friend WithEvents TabGrammar As System.Windows.Forms.TabPage
    Friend WithEvents TabSeparator As System.Windows.Forms.TabPage
    Friend WithEvents COLUMN_TEXT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NUMBER As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ENTERED As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents VersionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
