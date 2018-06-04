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
        Me.bttOpen = New System.Windows.Forms.Button()
        Me.txtGrammarPath = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ToolTipForAllControls = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HowDoIUseThisProgrammanualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckForTheNewestVersionOfTheProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckForTheLatestGrammarResourceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GetRandomStoriesToTestTheProgramOnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutTheAuthorOfThisProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCommentCopy = New System.Windows.Forms.TextBox()
        Me.COLUMN_TEXT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NUMBER = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ENTERED = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.dgvSeparated, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvSeparated
        '
        Me.dgvSeparated.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvSeparated.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSeparated.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.COLUMN_TEXT, Me.NUMBER, Me.ENTERED})
        Me.dgvSeparated.Location = New System.Drawing.Point(12, 27)
        Me.dgvSeparated.Name = "dgvSeparated"
        Me.dgvSeparated.Size = New System.Drawing.Size(721, 462)
        Me.dgvSeparated.TabIndex = 0
        '
        'txtNUMBER_OF_CHARACTERS
        '
        Me.txtNUMBER_OF_CHARACTERS.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNUMBER_OF_CHARACTERS.Location = New System.Drawing.Point(150, 43)
        Me.txtNUMBER_OF_CHARACTERS.Name = "txtNUMBER_OF_CHARACTERS"
        Me.txtNUMBER_OF_CHARACTERS.Size = New System.Drawing.Size(100, 20)
        Me.txtNUMBER_OF_CHARACTERS.TabIndex = 1
        Me.txtNUMBER_OF_CHARACTERS.Text = "50000"
        '
        'txtNUMBER_OF_REPEAT_CHARACTERS
        '
        Me.txtNUMBER_OF_REPEAT_CHARACTERS.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNUMBER_OF_REPEAT_CHARACTERS.Location = New System.Drawing.Point(150, 69)
        Me.txtNUMBER_OF_REPEAT_CHARACTERS.Name = "txtNUMBER_OF_REPEAT_CHARACTERS"
        Me.txtNUMBER_OF_REPEAT_CHARACTERS.Size = New System.Drawing.Size(100, 20)
        Me.txtNUMBER_OF_REPEAT_CHARACTERS.TabIndex = 2
        Me.txtNUMBER_OF_REPEAT_CHARACTERS.Text = "15"
        '
        'lbltxtNUMBER_OF_CHARACTERS
        '
        Me.lbltxtNUMBER_OF_CHARACTERS.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbltxtNUMBER_OF_CHARACTERS.Location = New System.Drawing.Point(-3, 42)
        Me.lbltxtNUMBER_OF_CHARACTERS.Name = "lbltxtNUMBER_OF_CHARACTERS"
        Me.lbltxtNUMBER_OF_CHARACTERS.Size = New System.Drawing.Size(147, 20)
        Me.lbltxtNUMBER_OF_CHARACTERS.TabIndex = 62
        Me.lbltxtNUMBER_OF_CHARACTERS.Text = "Number of characters"
        Me.lbltxtNUMBER_OF_CHARACTERS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbltxtNUMBER_OF_REPEAT_CHARACTERS
        '
        Me.lbltxtNUMBER_OF_REPEAT_CHARACTERS.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbltxtNUMBER_OF_REPEAT_CHARACTERS.Location = New System.Drawing.Point(-3, 68)
        Me.lbltxtNUMBER_OF_REPEAT_CHARACTERS.Name = "lbltxtNUMBER_OF_REPEAT_CHARACTERS"
        Me.lbltxtNUMBER_OF_REPEAT_CHARACTERS.Size = New System.Drawing.Size(147, 20)
        Me.lbltxtNUMBER_OF_REPEAT_CHARACTERS.TabIndex = 63
        Me.lbltxtNUMBER_OF_REPEAT_CHARACTERS.Text = "Number of repeat characters"
        Me.lbltxtNUMBER_OF_REPEAT_CHARACTERS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'bttSeparate
        '
        Me.bttSeparate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttSeparate.Location = New System.Drawing.Point(78, 95)
        Me.bttSeparate.Name = "bttSeparate"
        Me.bttSeparate.Size = New System.Drawing.Size(172, 23)
        Me.bttSeparate.TabIndex = 65
        Me.bttSeparate.Text = "Separate text on equal segments"
        Me.bttSeparate.UseVisualStyleBackColor = True
        '
        'txtContentPath
        '
        Me.txtContentPath.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtContentPath.Location = New System.Drawing.Point(12, 639)
        Me.txtContentPath.Name = "txtContentPath"
        Me.txtContentPath.Size = New System.Drawing.Size(345, 20)
        Me.txtContentPath.TabIndex = 66
        Me.txtContentPath.Text = "C:\A_story_that_needs_editing.txt"
        Me.ToolTipForAllControls.SetToolTip(Me.txtContentPath, "Double click to select the path or just write it in")
        '
        'txtPreText
        '
        Me.txtPreText.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPreText.Location = New System.Drawing.Point(150, 13)
        Me.txtPreText.Name = "txtPreText"
        Me.txtPreText.Size = New System.Drawing.Size(100, 20)
        Me.txtPreText.TabIndex = 67
        Me.txtPreText.Text = "00_"
        '
        'lblPretext
        '
        Me.lblPretext.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPretext.Location = New System.Drawing.Point(84, 12)
        Me.lblPretext.Name = "lblPretext"
        Me.lblPretext.Size = New System.Drawing.Size(60, 20)
        Me.lblPretext.TabIndex = 68
        Me.lblPretext.Text = "preText"
        Me.lblPretext.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'bttOpen
        '
        Me.bttOpen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttOpen.Location = New System.Drawing.Point(12, 662)
        Me.bttOpen.Name = "bttOpen"
        Me.bttOpen.Size = New System.Drawing.Size(75, 23)
        Me.bttOpen.TabIndex = 69
        Me.bttOpen.Text = "Open file"
        Me.bttOpen.UseVisualStyleBackColor = True
        '
        'txtGrammarPath
        '
        Me.txtGrammarPath.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtGrammarPath.Location = New System.Drawing.Point(12, 691)
        Me.txtGrammarPath.Name = "txtGrammarPath"
        Me.txtGrammarPath.Size = New System.Drawing.Size(345, 20)
        Me.txtGrammarPath.TabIndex = 70
        Me.txtGrammarPath.Text = "C:\Grammar.txt"
        Me.ToolTipForAllControls.SetToolTip(Me.txtGrammarPath, "Double click to select the path or just write it in")
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(363, 636)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 23)
        Me.Button1.TabIndex = 71
        Me.Button1.Text = "Run grammar check"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(12, 713)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 72
        Me.Button2.Text = "Open file"
        Me.Button2.UseVisualStyleBackColor = True
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
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(741, 24)
        Me.MenuStrip1.TabIndex = 74
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HowDoIUseThisProgrammanualToolStripMenuItem, Me.CheckForTheNewestVersionOfTheProgramToolStripMenuItem, Me.CheckForTheLatestGrammarResourceToolStripMenuItem, Me.GetRandomStoriesToTestTheProgramOnToolStripMenuItem, Me.AboutTheAuthorOfThisProgramToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'HowDoIUseThisProgrammanualToolStripMenuItem
        '
        Me.HowDoIUseThisProgrammanualToolStripMenuItem.Name = "HowDoIUseThisProgrammanualToolStripMenuItem"
        Me.HowDoIUseThisProgrammanualToolStripMenuItem.Size = New System.Drawing.Size(314, 22)
        Me.HowDoIUseThisProgrammanualToolStripMenuItem.Text = "Help, how do I use this program (the manual)"
        '
        'CheckForTheNewestVersionOfTheProgramToolStripMenuItem
        '
        Me.CheckForTheNewestVersionOfTheProgramToolStripMenuItem.Name = "CheckForTheNewestVersionOfTheProgramToolStripMenuItem"
        Me.CheckForTheNewestVersionOfTheProgramToolStripMenuItem.Size = New System.Drawing.Size(314, 22)
        Me.CheckForTheNewestVersionOfTheProgramToolStripMenuItem.Text = "Check for the newest version of the program"
        '
        'CheckForTheLatestGrammarResourceToolStripMenuItem
        '
        Me.CheckForTheLatestGrammarResourceToolStripMenuItem.Name = "CheckForTheLatestGrammarResourceToolStripMenuItem"
        Me.CheckForTheLatestGrammarResourceToolStripMenuItem.Size = New System.Drawing.Size(314, 22)
        Me.CheckForTheLatestGrammarResourceToolStripMenuItem.Text = "Get the latest Grammar resource"
        '
        'GetRandomStoriesToTestTheProgramOnToolStripMenuItem
        '
        Me.GetRandomStoriesToTestTheProgramOnToolStripMenuItem.Name = "GetRandomStoriesToTestTheProgramOnToolStripMenuItem"
        Me.GetRandomStoriesToTestTheProgramOnToolStripMenuItem.Size = New System.Drawing.Size(314, 22)
        Me.GetRandomStoriesToTestTheProgramOnToolStripMenuItem.Text = "Find random stories to test this program on"
        '
        'AboutTheAuthorOfThisProgramToolStripMenuItem
        '
        Me.AboutTheAuthorOfThisProgramToolStripMenuItem.Name = "AboutTheAuthorOfThisProgramToolStripMenuItem"
        Me.AboutTheAuthorOfThisProgramToolStripMenuItem.Size = New System.Drawing.Size(314, 22)
        Me.AboutTheAuthorOfThisProgramToolStripMenuItem.Text = "Contact the author"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txtPreText)
        Me.GroupBox1.Controls.Add(Me.txtNUMBER_OF_CHARACTERS)
        Me.GroupBox1.Controls.Add(Me.txtNUMBER_OF_REPEAT_CHARACTERS)
        Me.GroupBox1.Controls.Add(Me.lbltxtNUMBER_OF_CHARACTERS)
        Me.GroupBox1.Controls.Add(Me.lbltxtNUMBER_OF_REPEAT_CHARACTERS)
        Me.GroupBox1.Controls.Add(Me.lblPretext)
        Me.GroupBox1.Controls.Add(Me.bttSeparate)
        Me.GroupBox1.Location = New System.Drawing.Point(477, 613)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(256, 123)
        Me.GroupBox1.TabIndex = 75
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Text separating"
        '
        'txtCommentCopy
        '
        Me.txtCommentCopy.Location = New System.Drawing.Point(12, 495)
        Me.txtCommentCopy.Multiline = True
        Me.txtCommentCopy.Name = "txtCommentCopy"
        Me.txtCommentCopy.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtCommentCopy.Size = New System.Drawing.Size(721, 112)
        Me.txtCommentCopy.TabIndex = 76
        '
        'COLUMN_TEXT
        '
        Me.COLUMN_TEXT.HeaderText = "Text"
        Me.COLUMN_TEXT.Name = "COLUMN_TEXT"
        Me.COLUMN_TEXT.Width = 558
        '
        'NUMBER
        '
        Me.NUMBER.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NUMBER.HeaderText = "Data"
        Me.NUMBER.Name = "NUMBER"
        '
        'ENTERED
        '
        Me.ENTERED.HeaderText = "E"
        Me.ENTERED.Name = "ENTERED"
        Me.ENTERED.ToolTipText = "This row was already entered at least once."
        Me.ENTERED.Width = 20
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(741, 741)
        Me.Controls.Add(Me.txtCommentCopy)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtGrammarPath)
        Me.Controls.Add(Me.bttOpen)
        Me.Controls.Add(Me.txtContentPath)
        Me.Controls.Add(Me.dgvSeparated)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Text separator"
        CType(Me.dgvSeparated, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
    Friend WithEvents bttOpen As System.Windows.Forms.Button
    Friend WithEvents txtGrammarPath As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ToolTipForAllControls As System.Windows.Forms.ToolTip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HowDoIUseThisProgrammanualToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutTheAuthorOfThisProgramToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckForTheNewestVersionOfTheProgramToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CheckForTheLatestGrammarResourceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GetRandomStoriesToTestTheProgramOnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtCommentCopy As System.Windows.Forms.TextBox
    Friend WithEvents COLUMN_TEXT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NUMBER As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ENTERED As System.Windows.Forms.DataGridViewCheckBoxColumn

End Class
