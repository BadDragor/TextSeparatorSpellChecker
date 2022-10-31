Public Class TextSeparatorForm
    Dim intRows As Integer = 0
    Dim strRows As String = "00"
    Dim strTempText As String = ""
    Dim strTekst As String
    Dim objGrammarLine As Object
    Dim strRootProgramPath As String = ""

    Dim lstGrammarFile As New System.Collections.ArrayList
    Dim lstContentFile As New System.Collections.ArrayList
    Dim intLinesCount As Integer = 0
    Dim strAllText As String = ""

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        '#If DEBUG Then
        '        txtContentPath.Text = "C:\Temp\content.txt"
        '        txtGrammarPath.Text = "C:\Temp\grammar.txt"
        '#End If

        CheckForTheNewestVersionOfTheProgramToolStripMenuItem.Text = CheckForTheNewestVersionOfTheProgramToolStripMenuItem.Text & " (current " & VersionToolStripMenuItem.Text.ToLower & ")"

    End Sub

    Private Sub ReadConfig()
        strRootProgramPath = Application.StartupPath

        If System.IO.File.Exists(strRootProgramPath & "\" & "SavedData.txt") Then
            Dim objReader As New System.IO.StreamReader(strRootProgramPath & "\" & "SavedData.txt", System.Text.Encoding.GetEncoding("windows-1250"), True)

            Dim curLine As String = ""
            Dim i As Integer = 0
            Do
                curLine = objReader.ReadLine()

                If curLine IsNot Nothing Then
                    Select Case i
                        Case 0
                            txtContentPath.Text = curLine
                        Case 1
                            txtGrammarPath.Text = curLine
                    End Select

                End If
                i += 1

            Loop Until curLine Is Nothing

            objReader.Close()
        Else
            txtContentPath.Text = "C:\Temp\A_story_that_needs_editing.txt"
            txtGrammarPath.Text = "C:\Temp\grammar.txt"
        End If
    End Sub

    Private Sub WriteConfig()
        Dim objWriter As New System.IO.StreamWriter(strRootProgramPath & "\" & "SavedData.txt", False)
        'An unhandled exception of type 'System.UnauthorizedAccessException' occurred in mscorlib.dll  Additional information: Access to the path 'C:\SavedData.txt' is denied.
        objWriter.Write(txtContentPath.Text & vbCrLf & txtGrammarPath.Text)
        objWriter.Close()
    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ReadConfig()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        WriteConfig()
    End Sub

    Private Sub bttSeparate_Click(sender As Object, e As EventArgs) Handles bttSeparate.Click
        dgvSeparated.Rows.Clear()

        strTekst = ""
        Dim objReader As New System.IO.StreamReader(txtContentPath.Text, System.Text.Encoding.GetEncoding("windows-1250"), True)

        Dim curLine As String = ""

        Dim intLinesCount As Integer = 0
        Do
            curLine = objReader.ReadLine()

            If curLine IsNot Nothing Then
                strTekst &= curLine & vbCrLf
                intLinesCount += 1
            End If
        Loop Until curLine Is Nothing

        AllText.Text = strTekst
        Lines.Text = intLinesCount

        objReader.Close()

        Dim i As Integer = 0

        For i = 0 To strTekst.ToString.Length - 1
            If strTempText.Length < txtNUMBER_OF_CHARACTERS.Text Then
                strTempText &= strTekst.ToString.Substring(i, 1)
            Else
                AddRow()
                i = i - txtNUMBER_OF_REPEAT_CHARACTERS.Text
            End If
        Next

        AddRow()
    End Sub

    Private Sub AddRow()
        intRows += 1
        strRows = "0" & intRows
        strRows = Microsoft.VisualBasic.Right(strRows, 2)
        strRows = txtPreText.Text & strRows
        dgvSeparated.Rows.Add(strTempText, strRows, 0)
        strTempText = ""
        strRows = ""
    End Sub

    Private Sub AddGrammarRow(ByVal strLine As String, ByVal strGrammar As String)
        If strLine <> " " Then
            intRows += 1
            dgvSeparated.Rows.Add(strLine, strGrammar, 0)
        End If
    End Sub

    Private Sub dgvSeparated_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSeparated.CellEnter
        Dim intLine As Integer = 0
        Dim intConsecutiveCommentLine As Integer = 0

        intLine = e.RowIndex

        Dim currentCell As Object = dgvSeparated.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
        If currentCell IsNot Nothing Then
            Try
                Clipboard.SetText(currentCell)
                'An unhandled exception of type 'System.ArgumentNullException' occurred in System.Windows.Forms.dll Additional information: Value cannot be null.
            Catch ex As Exception
            End Try

            dgvSeparated.Rows(e.RowIndex).Cells("ENTERED").Value = 1
        End If

        For intConsecutiveCommentLine = intLine To dgvSeparated.Rows.Count - 1
            currentCell = dgvSeparated.Rows(intConsecutiveCommentLine).Cells("COLUMN_TEXT").Value
            If currentCell Is Nothing OrElse currentCell.GetType.Name = "DBNull" OrElse Trim(currentCell) = "" Then
                currentCell = dgvSeparated.Rows(intConsecutiveCommentLine).Cells("NUMBER").Value
                If currentCell Is Nothing OrElse currentCell.GetType.Name = "DBNull" Then
                    currentCell = ""
                Else
                    currentCell = currentCell.ToString.Replace("[]", vbCrLf)
                End If

                txtCommentCopy.Text = currentCell
                Exit For
            End If
        Next
    End Sub

    Private Sub bttOpen_Click(sender As Object, e As EventArgs) Handles bttOpenStory.Click
        joined_bttOpen_Click(txtContentPath.Text)
    End Sub

    Private Sub joined_bttOpen_Click(ByVal strPath As String)
        Try
            If Not System.IO.File.Exists(strPath) Then
                System.IO.File.Create(strPath)
            End If
            System.Diagnostics.Process.Start(strPath)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CreateFileAndPath(thePath As String, theContents As String)
        Dim currentPath As String = System.IO.Path.GetDirectoryName(thePath)
        If Not System.IO.Directory.Exists(currentPath) Then
            System.IO.Directory.CreateDirectory(currentPath)
        End If

        Dim objWriter As New System.IO.StreamWriter(thePath, False)
        objWriter.Write(theContents)
        objWriter.Close()
    End Sub

    Private Sub CreateFilesIfMissing()
        Try
            Dim cls As New WrongUseHandler

            If Not System.IO.File.Exists(txtContentPath.Text) Then
                CreateFileAndPath(txtContentPath.Text, cls.RandomContent)
            End If

            If Not System.IO.File.Exists(txtGrammarPath.Text) Then
                CreateFileAndPath(txtGrammarPath.Text, cls.RandomGrammarContent)
#If Not Debug Then
                System.Diagnostics.Process.Start("https://docs.google.com/document/d/1hmi3FbLKJGY076vsUaHFSEAU-MYRjG4hJVX8vBq11I4/edit#")
#End If
            End If
        Catch ex As Exception
#If DEBUG Then
            Dim objTemp9 As String = ex.Message
            MsgBox(objTemp9)
#End If
        End Try
    End Sub

    Private Sub PullGrammar()
        Dim objReader2 As New System.IO.StreamReader(txtGrammarPath.Text, System.Text.Encoding.GetEncoding("windows-1250"), True)

        Try
            objGrammarLine = objReader2.ReadLine()
            'An unhandled exception of type 'System.ObjectDisposedException' occurred in mscorlib.dll Additional information: Cannot read from a closed TextReader.   'Solution: Open it for every line of content.
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & "Exception thrown during initial read of objGrammarLine." & vbCrLf)
        End Try

        Do
            Try
                objGrammarLine = objReader2.ReadLine()
                'An unhandled exception of type 'System.ObjectDisposedException' occurred in mscorlib.dll Additional information: Cannot read from a closed TextReader.
            Catch ex As Exception
                MsgBox(ex.Message & vbCrLf & "Exception thrown while reading objGrammarLine." & vbCrLf)
            End Try

            If objGrammarLine IsNot Nothing Then
                lstGrammarFile.Add(objGrammarLine)
            End If
        Loop Until objGrammarLine Is Nothing

        objReader2.Close()
    End Sub

    Private Sub PullContent()
        Dim objReader As New System.IO.StreamReader(txtContentPath.Text, System.Text.Encoding.GetEncoding("windows-1250"), True)

        Dim curLine As String = ""

        Do
            Try
                curLine = objReader.ReadLine()
                'An unhandled exception of type 'System.ObjectDisposedException' occurred in mscorlib.dll Additional information: Cannot read from a closed TextReader.
            Catch ex As Exception
                MsgBox(ex.Message & vbCrLf & "Exception thrown while reading curLine." & vbCrLf & "intLinesCount = " & intLinesCount & vbCrLf)
            End Try

            If curLine IsNot Nothing Then
                lstContentFile.Add(curLine)
                strAllText &= curLine & vbCrLf
                intLinesCount += 1
            End If
        Loop Until curLine Is Nothing

        objReader.Close()
    End Sub

    Private Sub btnRunGrammarCheck_Click(sender As Object, e As EventArgs) Handles btnRunGrammarCheck.Click

        CreateFilesIfMissing()
        dgvSeparated.Rows.Clear()

        PullGrammar()
        PullContent()

        AllText.Text = strAllText
        Lines.Text = intLinesCount

        Dim blnRowsAdded As Boolean = False

        Dim j As Integer = 0
        Dim intContentCounter As Integer = 0
        Dim intGrammarCounter As Integer = 0

        For j = 0 To lstGrammarFile.Count - 1
            objGrammarLine = lstGrammarFile(j)
            intGrammarCounter += 1

            Dim k As Integer = 0
            Dim curLine As String = ""

            For k = 0 To lstContentFile.Count - 1
                intContentCounter += 1
                'Do
                Try
                    curLine = lstContentFile(k) 'objReader.ReadLine()
                    'An unhandled exception of type 'System.ObjectDisposedException' occurred in mscorlib.dll Additional information: Cannot read from a closed TextReader.
                Catch ex As Exception
                    MsgBox(ex.Message & vbCrLf & "intContentCounter = " & intContentCounter & vbCrLf & "intGrammarCounter = " & intGrammarCounter)
                End Try

                If curLine IsNot Nothing Then

                    If objGrammarLine Is Nothing Then Continue For

                    If objGrammarLine.ToString.Contains("[ignore]") Then
                        If blnRowsAdded Then
                            blnRowsAdded = False
                        End If
                        Exit For
                    End If

                    If objGrammarLine.ToString.Contains("[explain]") Then
                        If blnRowsAdded Then
                            AddGrammarRow("", objGrammarLine.ToString.Replace("[explain]", ""))
                            blnRowsAdded = False
                        End If
                        Exit For
                    End If

                    If objGrammarLine.ToString.Contains("[comment]") Then
                        AddGrammarRow("", objGrammarLine.ToString.Replace("[comment]", ""))
                        Exit For
                    End If

                    If objGrammarLine.ToString.Contains("[abc]") Then
                        Const strAllCharacters As String = "abcčdefgijklmnoprsštuvzžyxqABCČDEFGIJKLMNOPRSŠTUVZŽYXQ"
                        Dim strCharacter As String = ""
                        Dim i As Integer = 0

                        For i = 0 To strAllCharacters.Length - 1
                            strCharacter = strAllCharacters.Substring(i, 1)
                            If curLine.ToString.Contains(objGrammarLine.ToString.Replace("[abc]", strCharacter)) Then
                                AddGrammarRow(curLine, objGrammarLine.Replace("[abc]", strCharacter))
                                blnRowsAdded = True
                            End If
                        Next
                    End If

                    If objGrammarLine.ToString.Contains("[allcase]") Then
                        If curLine.ToString.ToLower.Contains(objGrammarLine.ToString.ToLower.Replace("[allcase]", "")) Then
                            AddGrammarRow(curLine, objGrammarLine.ToString.Replace("[allcase]", ""))
                            blnRowsAdded = True
                        End If
                    End If

                    If objGrammarLine.ToString <> "" AndAlso objGrammarLine.ToString <> " " AndAlso curLine.ToString.Contains(objGrammarLine) Then
                        AddGrammarRow(curLine, objGrammarLine)
                        blnRowsAdded = True
                    End If
                End If

            Next 'Loop Until curLine Is Nothing
        Next
    End Sub

    Private Sub bttOpenGrammar_Click(sender As Object, e As EventArgs) Handles bttOpenGrammar.Click
        joined_bttOpen_Click(txtGrammarPath.Text)
    End Sub

    Private Function GetPathname() As String
        Dim thePath As String = ""
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*" '"|txt (*.txt)|*.txt"
        OpenFileDialog.Title = "Select the source file."

        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            thePath = OpenFileDialog.FileName
        End If

        Return thePath
    End Function

    Private Sub txtContentPath_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtContentPath.MouseDoubleClick
        Dim thePath As String = ""

        thePath = GetPathname()
        If (thePath <> "") Then
            txtContentPath.Text = thePath
        End If
    End Sub

    Private Sub txtGrammarPath_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtGrammarPath.MouseDoubleClick
        Dim thePath As String = ""

        thePath = GetPathname()
        If (thePath <> "") Then
            txtContentPath.Text = thePath
        End If
    End Sub

    Private Sub HowDoIUseThisProgrammanualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HowDoIUseThisProgrammanualToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://docs.google.com/document/d/1Gwy43ddbjC17Zdxv0OoOl73vwArmJa4LQZacTcMgk5g/edit#")
    End Sub

    Private Sub AboutTheAuthorOfThisProgramToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutTheAuthorOfThisProgramToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://www.fimfiction.net/user/127717/Bad+Dragon")
        System.Diagnostics.Process.Start("https://www.fimfiction.net/user/127717/SweetAI+Belle")
    End Sub

    Private Sub CheckForTheNewestVersionOfTheProgramToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckForTheNewestVersionOfTheProgramToolStripMenuItem.Click
        System.Diagnostics.Process.Start("http://www.pearltrees.com/dragor/textseparator/id17876303#l550")
    End Sub

    Private Sub CheckForTheLatestGrammarResourceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckForTheLatestGrammarResourceToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://docs.google.com/document/d/1hmi3FbLKJGY076vsUaHFSEAU-MYRjG4hJVX8vBq11I4/edit#")
    End Sub

    Private Sub GetRandomStoriesToTestTheProgramOnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GetRandomStoriesToTestTheProgramOnToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://www.fimfiction.net/blog/713204/gdocs-of-my-stories")
    End Sub

    Private Sub dgvSeparated_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSeparated.CellContentClick

    End Sub

    Private Sub ReportABugImprovementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportABugImprovementToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://github.com/BadDragor/TextSeparatorSpellChecker/issues")
    End Sub

End Class
