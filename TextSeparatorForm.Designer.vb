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
        Me.COLUMN_TEXT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NUMBER = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ENTERED = New System.Windows.Forms.DataGridViewCheckBoxColumn()
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
        Me.btnRunGrammarCheck = New System.Windows.Forms.Button()
        Me.bttOpenGrammar = New System.Windows.Forms.Button()
        Me.ToolTipForAllControls = New System.Windows.Forms.ToolTip(Me.components)
        Me.Lines = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HowDoIUseThisProgrammanualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckForTheNewestVersionOfTheProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckForTheLatestGrammarResourceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GetRandomStoriesToTestTheProgramOnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportABugImprovementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutTheAuthorOfThisProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VersionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtCommentCopy = New System.Windows.Forms.TextBox()
        Me.TabSeparatorControl = New System.Windows.Forms.TabControl()
        Me.TabGrammar = New System.Windows.Forms.TabPage()
        Me.TabSeparator = New System.Windows.Forms.TabPage()
        Me.tabMainTabControl = New System.Windows.Forms.TabControl()
        Me.TabMainGrammar = New System.Windows.Forms.TabPage()
        Me.TabMainText = New System.Windows.Forms.TabPage()
        Me.AllText = New System.Windows.Forms.RichTextBox()
        Me.TabMainStatistics = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvSeparated, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.TabSeparatorControl.SuspendLayout()
        Me.TabGrammar.SuspendLayout()
        Me.TabSeparator.SuspendLayout()
        Me.tabMainTabControl.SuspendLayout()
        Me.TabMainGrammar.SuspendLayout()
        Me.TabMainText.SuspendLayout()
        Me.TabMainStatistics.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvSeparated
        '
        Me.dgvSeparated.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvSeparated.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSeparated.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.COLUMN_TEXT, Me.NUMBER, Me.ENTERED})
        Me.dgvSeparated.Location = New System.Drawing.Point(6, 6)
        Me.dgvSeparated.Name = "dgvSeparated"
        Me.dgvSeparated.RowHeadersVisible = False
        Me.dgvSeparated.Size = New System.Drawing.Size(741, 462)
        Me.dgvSeparated.TabIndex = 0
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
        Me.txtContentPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtContentPath.Location = New System.Drawing.Point(18, 583)
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
        Me.bttOpenStory.Location = New System.Drawing.Point(18, 606)
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
        'btnRunGrammarCheck
        '
        Me.btnRunGrammarCheck.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnRunGrammarCheck.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRunGrammarCheck.Location = New System.Drawing.Point(357, 3)
        Me.btnRunGrammarCheck.Name = "btnRunGrammarCheck"
        Me.btnRunGrammarCheck.Size = New System.Drawing.Size(114, 23)
        Me.btnRunGrammarCheck.TabIndex = 71
        Me.btnRunGrammarCheck.Text = "Run grammar check"
        Me.btnRunGrammarCheck.UseVisualStyleBackColor = False
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
        'Lines
        '
        Me.Lines.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lines.Location = New System.Drawing.Point(6, 16)
        Me.Lines.Name = "Lines"
        Me.Lines.Size = New System.Drawing.Size(44, 20)
        Me.Lines.TabIndex = 67
        Me.ToolTipForAllControls.SetToolTip(Me.Lines, "Double click to select the path or just write it in the field")
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem, Me.VersionToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(787, 24)
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
        'ReportABugImprovementToolStripMenuItem
        '
        Me.ReportABugImprovementToolStripMenuItem.Name = "ReportABugImprovementToolStripMenuItem"
        Me.ReportABugImprovementToolStripMenuItem.Size = New System.Drawing.Size(391, 22)
        Me.ReportABugImprovementToolStripMenuItem.Text = "Report a bug or suggest an improvement on GitHub"
        '
        'AboutTheAuthorOfThisProgramToolStripMenuItem
        '
        Me.AboutTheAuthorOfThisProgramToolStripMenuItem.Name = "AboutTheAuthorOfThisProgramToolStripMenuItem"
        Me.AboutTheAuthorOfThisProgramToolStripMenuItem.Size = New System.Drawing.Size(391, 22)
        Me.AboutTheAuthorOfThisProgramToolStripMenuItem.Text = "Contact the author"
        '
        'VersionToolStripMenuItem
        '
        Me.VersionToolStripMenuItem.Enabled = False
        Me.VersionToolStripMenuItem.Name = "VersionToolStripMenuItem"
        Me.VersionToolStripMenuItem.Size = New System.Drawing.Size(114, 20)
        Me.VersionToolStripMenuItem.Text = "Version 2018.06.22"
        '
        'txtCommentCopy
        '
        Me.txtCommentCopy.Location = New System.Drawing.Point(6, 468)
        Me.txtCommentCopy.Multiline = True
        Me.txtCommentCopy.Name = "txtCommentCopy"
        Me.txtCommentCopy.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtCommentCopy.Size = New System.Drawing.Size(741, 112)
        Me.txtCommentCopy.TabIndex = 76
        '
        'TabSeparatorControl
        '
        Me.TabSeparatorControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabSeparatorControl.Controls.Add(Me.TabGrammar)
        Me.TabSeparatorControl.Controls.Add(Me.TabSeparator)
        Me.TabSeparatorControl.Location = New System.Drawing.Point(6, 635)
        Me.TabSeparatorControl.Name = "TabSeparatorControl"
        Me.TabSeparatorControl.SelectedIndex = 0
        Me.TabSeparatorControl.Size = New System.Drawing.Size(745, 106)
        Me.TabSeparatorControl.TabIndex = 77
        '
        'TabGrammar
        '
        Me.TabGrammar.Controls.Add(Me.txtGrammarPath)
        Me.TabGrammar.Controls.Add(Me.bttOpenGrammar)
        Me.TabGrammar.Controls.Add(Me.btnRunGrammarCheck)
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
        'tabMainTabControl
        '
        Me.tabMainTabControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabMainTabControl.Controls.Add(Me.TabMainGrammar)
        Me.tabMainTabControl.Controls.Add(Me.TabMainText)
        Me.tabMainTabControl.Controls.Add(Me.TabMainStatistics)
        Me.tabMainTabControl.Location = New System.Drawing.Point(12, 27)
        Me.tabMainTabControl.Name = "tabMainTabControl"
        Me.tabMainTabControl.SelectedIndex = 0
        Me.tabMainTabControl.Size = New System.Drawing.Size(764, 776)
        Me.tabMainTabControl.TabIndex = 78
        '
        'TabMainGrammar
        '
        Me.TabMainGrammar.Controls.Add(Me.dgvSeparated)
        Me.TabMainGrammar.Controls.Add(Me.txtContentPath)
        Me.TabMainGrammar.Controls.Add(Me.txtCommentCopy)
        Me.TabMainGrammar.Controls.Add(Me.bttOpenStory)
        Me.TabMainGrammar.Controls.Add(Me.TabSeparatorControl)
        Me.TabMainGrammar.Location = New System.Drawing.Point(4, 22)
        Me.TabMainGrammar.Name = "TabMainGrammar"
        Me.TabMainGrammar.Padding = New System.Windows.Forms.Padding(3)
        Me.TabMainGrammar.Size = New System.Drawing.Size(756, 750)
        Me.TabMainGrammar.TabIndex = 0
        Me.TabMainGrammar.Text = "Grammar"
        Me.TabMainGrammar.UseVisualStyleBackColor = True
        '
        'TabMainText
        '
        Me.TabMainText.Controls.Add(Me.AllText)
        Me.TabMainText.Location = New System.Drawing.Point(4, 22)
        Me.TabMainText.Name = "TabMainText"
        Me.TabMainText.Padding = New System.Windows.Forms.Padding(3)
        Me.TabMainText.Size = New System.Drawing.Size(756, 750)
        Me.TabMainText.TabIndex = 1
        Me.TabMainText.Text = "Text"
        Me.TabMainText.UseVisualStyleBackColor = True
        '
        'AllText
        '
        Me.AllText.Location = New System.Drawing.Point(0, 0)
        Me.AllText.Name = "AllText"
        Me.AllText.Size = New System.Drawing.Size(753, 747)
        Me.AllText.TabIndex = 0
        Me.AllText.Text = ""
        '
        'TabMainStatistics
        '
        Me.TabMainStatistics.Controls.Add(Me.Label1)
        Me.TabMainStatistics.Controls.Add(Me.Lines)
        Me.TabMainStatistics.Location = New System.Drawing.Point(4, 22)
        Me.TabMainStatistics.Name = "TabMainStatistics"
        Me.TabMainStatistics.Padding = New System.Windows.Forms.Padding(3)
        Me.TabMainStatistics.Size = New System.Drawing.Size(756, 750)
        Me.TabMainStatistics.TabIndex = 2
        Me.TabMainStatistics.Text = "Statistics"
        Me.TabMainStatistics.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "Lines"
        '
        'TextSeparatorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(787, 815)
        Me.Controls.Add(Me.tabMainTabControl)
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
        Me.tabMainTabControl.ResumeLayout(False)
        Me.TabMainGrammar.ResumeLayout(False)
        Me.TabMainGrammar.PerformLayout()
        Me.TabMainText.ResumeLayout(False)
        Me.TabMainStatistics.ResumeLayout(False)
        Me.TabMainStatistics.PerformLayout()
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
    Friend WithEvents btnRunGrammarCheck As System.Windows.Forms.Button
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
    Friend WithEvents tabMainTabControl As TabControl
    Friend WithEvents TabMainGrammar As TabPage
    Friend WithEvents TabMainText As TabPage
    Friend WithEvents AllText As RichTextBox
    Friend WithEvents TabMainStatistics As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents Lines As TextBox
End Class
