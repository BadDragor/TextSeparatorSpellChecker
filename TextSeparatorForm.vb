Public Class TextSeparatorForm
    Dim i As Integer = 0
    Dim intRows As Integer = 0
    Dim strRows As String = "00"
    'Dim intTempTextLength As Integer
    Dim strTempText As String = ""
    Dim strTekst As String
    Dim objLine As Object
    Dim objGrammarLine As Object
    Dim strRootProgramPath As String = ""

    Private objTemp0, objTemp9 As Object

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        '#If DEBUG Then
        '        txtContentPath.Text = "C:\Temp\content.txt"
        '        txtGrammarPath.Text = "C:\Temp\grammar.txt"
        '#End If

        CheckForTheNewestVersionOfTheProgramToolStripMenuItem.Text = CheckForTheNewestVersionOfTheProgramToolStripMenuItem.Text & " (current " & VersionToolStripMenuItem.Text.ToLower & ")"

    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        strRootProgramPath = Application.StartupPath

        If System.IO.File.Exists(strRootProgramPath & "\" & "SavedData.txt") Then
            Dim objReader As New System.IO.StreamReader(strRootProgramPath & "\" & "SavedData.txt", System.Text.Encoding.GetEncoding("windows-1250"), True)

            objLine = ""
            i = 0
            Do
                objLine = objReader.ReadLine()

                If objLine IsNot Nothing Then
                    Select Case i
                        Case 0
                            txtContentPath.Text = objLine
                        Case 1
                            txtGrammarPath.Text = objLine
                    End Select

                End If
                i += 1

            Loop Until objLine Is Nothing

            objReader.Close()
        Else
            txtContentPath.Text = "C:\Temp\A_story_that_needs_editing.txt"
            txtGrammarPath.Text = "C:\Temp\grammar.txt"
        End If
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim objWriter As New System.IO.StreamWriter(strRootProgramPath & "\" & "SavedData.txt", False)
        'An unhandled exception of type 'System.UnauthorizedAccessException' occurred in mscorlib.dll  Additional information: Access to the path 'C:\SavedData.txt' is denied.
        objWriter.Write(txtContentPath.Text & vbCrLf & txtGrammarPath.Text)
        objWriter.Close()

    End Sub

    Private Sub bttSeparate_Click(sender As Object, e As EventArgs) Handles bttSeparate.Click
        dgvSeparated.Rows.Clear()

        strTekst = ""
        Dim objReader As New System.IO.StreamReader(txtContentPath.Text, System.Text.Encoding.GetEncoding("windows-1250"), True)

        objLine = ""

        Do
            objLine = objReader.ReadLine()

            If objLine IsNot Nothing Then
                strTekst &= objLine & vbCrLf
            End If
        Loop Until objLine Is Nothing

        objReader.Close()

        objTemp0 = strTekst.ToString.Length

        For i = 0 To objTemp0 - 1
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

        objTemp0 = dgvSeparated.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
        If objTemp0 IsNot Nothing Then
            Try
                Clipboard.SetText(objTemp0)
                'An unhandled exception of type 'System.ArgumentNullException' occurred in System.Windows.Forms.dll Additional information: Value cannot be null.
            Catch ex As Exception
            End Try

            dgvSeparated.Rows(e.RowIndex).Cells("ENTERED").Value = 1
        End If

        For intConsecutiveCommentLine = intLine To dgvSeparated.Rows.Count - 1
            objTemp0 = dgvSeparated.Rows(intConsecutiveCommentLine).Cells("COLUMN_TEXT").Value
            If objTemp0 Is Nothing OrElse objTemp0.GetType.Name = "DBNull" OrElse Trim(objTemp0) = "" Then
                objTemp0 = dgvSeparated.Rows(intConsecutiveCommentLine).Cells("NUMBER").Value
                If objTemp0 Is Nothing OrElse objTemp0.GetType.Name = "DBNull" Then
                    objTemp0 = ""
                Else
                    objTemp0 = objTemp0.ToString.Replace("[]", vbCrLf)
                End If

                txtCommentCopy.Text = objTemp0
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim cls As New Class1

            If Not System.IO.File.Exists(txtContentPath.Text) Then
                objTemp0 = System.IO.Path.GetDirectoryName(txtContentPath.Text)
                If Not System.IO.Directory.Exists(objTemp0) Then
                    System.IO.Directory.CreateDirectory(objTemp0)
                End If
                Dim objWriter As New System.IO.StreamWriter(txtContentPath.Text, False)

                objWriter.Write(cls.RandomContent)
                objWriter.Close()
            End If

            If Not System.IO.File.Exists(txtGrammarPath.Text) Then
                objTemp0 = System.IO.Path.GetDirectoryName(txtGrammarPath.Text)
                If Not System.IO.Directory.Exists(objTemp0) Then
                    System.IO.Directory.CreateDirectory(objTemp0)
                End If
                Dim objWriter As New System.IO.StreamWriter(txtGrammarPath.Text, False)

                objWriter.Write(cls.RandomGrammarContent)
                objWriter.Close()
#If Not Debug Then
                System.Diagnostics.Process.Start("https://docs.google.com/document/d/1hmi3FbLKJGY076vsUaHFSEAU-MYRjG4hJVX8vBq11I4/edit#")
#End If
            End If
        Catch ex As Exception
#If DEBUG Then
            objTemp9 = ex.Message
            MsgBox(objTemp9)
#End If
        End Try

        dgvSeparated.Rows.Clear()

        strTekst = ""

        Dim blnSkip As Boolean = False
        Dim strAllCharacters As String = "abcčdefgijklmnoprsštuvzžyxqABCČDEFGIJKLMNOPRSŠTUVZŽYXQ"
        Dim strCharacter As String = ""
        Dim i As Integer = 0

        Dim intContentCounter As Integer = 0
        Dim intGrammarCounter As Integer = 0

        objLine = ""

        Dim lstGrammarFile As New System.Collections.ArrayList
        Dim lstContentFile As New System.Collections.ArrayList
        Dim j As Integer = 0
        Dim k As Integer = 0

        Dim objReader2 As New System.IO.StreamReader(txtGrammarPath.Text, System.Text.Encoding.GetEncoding("windows-1250"), True)
        Dim blnGrammarTagWasUsed As Boolean = False
        Dim blnRowsAdded As Boolean = False

        Try
            objGrammarLine = objReader2.ReadLine()
            'An unhandled exception of type 'System.ObjectDisposedException' occurred in mscorlib.dll Additional information: Cannot read from a closed TextReader.   'Solution: Open it for every line of content.
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & "intContentCounter = " & intContentCounter & vbCrLf & "intGrammarCounter = " & intGrammarCounter)
        End Try

        Do
            'intGrammarCounter += 1
            Try
                objGrammarLine = objReader2.ReadLine()
                'An unhandled exception of type 'System.ObjectDisposedException' occurred in mscorlib.dll Additional information: Cannot read from a closed TextReader.
            Catch ex As Exception
                MsgBox(ex.Message & vbCrLf & "intContentCounter = " & intContentCounter & vbCrLf & "intGrammarCounter = " & intGrammarCounter)
            End Try

            If objGrammarLine IsNot Nothing Then
                'objGrammarLine = objLine
                lstGrammarFile.Add(objGrammarLine)
            End If
        Loop Until objGrammarLine Is Nothing

        objReader2.Close()

        'intContentCounter += 1
        Dim objReader As New System.IO.StreamReader(txtContentPath.Text, System.Text.Encoding.GetEncoding("windows-1250"), True)

        Do
            'intContentCounter += 1
            Try
                objLine = objReader.ReadLine()
                'An unhandled exception of type 'System.ObjectDisposedException' occurred in mscorlib.dll Additional information: Cannot read from a closed TextReader.
            Catch ex As Exception
                MsgBox(ex.Message & vbCrLf & "intContentCounter = " & intContentCounter & vbCrLf & "intGrammarCounter = " & intGrammarCounter)
            End Try

            If objLine IsNot Nothing Then
                'objGrammarLine = objLine
                lstContentFile.Add(objLine)
            End If
        Loop Until objLine Is Nothing

        objReader.Close()

        For j = 0 To lstGrammarFile.Count - 1
            blnGrammarTagWasUsed = False
            objGrammarLine = lstGrammarFile(j)
            intGrammarCounter += 1

            For k = 0 To lstContentFile.Count - 1
                intContentCounter += 1
                'Do
                Try
                    objLine = lstContentFile(k) 'objReader.ReadLine()
                    'An unhandled exception of type 'System.ObjectDisposedException' occurred in mscorlib.dll Additional information: Cannot read from a closed TextReader.
                Catch ex As Exception
                    MsgBox(ex.Message & vbCrLf & "intContentCounter = " & intContentCounter & vbCrLf & "intGrammarCounter = " & intGrammarCounter)
                End Try

                If objLine IsNot Nothing Then
                    'objGrammarLine = objLine
                    strTekst = objLine

                    blnSkip = False
                    If objGrammarLine Is Nothing Then Continue For

                    If Not blnSkip AndAlso objGrammarLine.ToString.Contains("[ignore]") Then
                        If blnRowsAdded Then
                            'AddGrammarRow("", objGrammarLine.ToString.Replace("[ignore]", ""))
                            blnRowsAdded = False
                        End If
                        'blnSkip = True
                        Exit For
                    End If

                    If Not blnSkip AndAlso objGrammarLine.ToString.Contains("[explain]") Then
                        If blnRowsAdded Then
                            AddGrammarRow("", objGrammarLine.ToString.Replace("[explain]", ""))
                            blnRowsAdded = False
                        End If
                        'blnSkip = True
                        Exit For
                    End If

                    If Not blnSkip AndAlso objGrammarLine.ToString.Contains("[comment]") Then
                        AddGrammarRow("", objGrammarLine.ToString.Replace("[comment]", ""))
                        'blnSkip = True
                        Exit For
                    End If

                    If Not blnSkip AndAlso objGrammarLine.ToString.Contains("[abc]") Then
                        For i = 0 To strAllCharacters.Length - 1
                            strCharacter = strAllCharacters.Substring(i, 1)
                            If Not blnSkip AndAlso objLine.ToString.Contains(objGrammarLine.ToString.Replace("[abc]", strCharacter)) Then
                                AddGrammarRow(objLine, objGrammarLine.Replace("[abc]", strCharacter))
                                blnRowsAdded = True
                                'blnSkip = True
                                'Exit For
                            End If
                        Next
                    End If

                    If Not blnSkip AndAlso objGrammarLine.ToString.Contains("[allcase]") Then
                        If Not blnSkip AndAlso objLine.ToString.ToLower.Contains(objGrammarLine.ToString.ToLower.Replace("[allcase]", "")) Then
                            AddGrammarRow(objLine, objGrammarLine.ToString.Replace("[allcase]", ""))
                            blnRowsAdded = True
                        End If
                        'blnSkip = True
                    End If

                    If Not blnSkip AndAlso objGrammarLine.ToString <> "" AndAlso objGrammarLine.ToString <> " " AndAlso objLine.ToString.Contains(objGrammarLine) Then
                        AddGrammarRow(objLine, objGrammarLine)
                        blnRowsAdded = True
                    End If

                End If

            Next 'Loop Until objLine Is Nothing
        Next

        objReader.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles bttOpenGrammar.Click
        joined_bttOpen_Click(txtGrammarPath.Text)
    End Sub

    Private Sub txtContentPath_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtContentPath.MouseDoubleClick
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*" '"|txt (*.txt)|*.txt"
        OpenFileDialog.Title = "Select the source file."
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            txtContentPath.Text = OpenFileDialog.FileName
        End If
    End Sub

    Private Sub txtContentPath_TextChanged(sender As Object, e As EventArgs) Handles txtContentPath.TextChanged

    End Sub

    Private Sub txtGrammarPath_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtGrammarPath.MouseDoubleClick
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*" '"|txt (*.txt)|*.txt"
        OpenFileDialog.Title = "Select the source file."
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            txtContentPath.Text = OpenFileDialog.FileName
        End If
    End Sub

    Private Sub txtGrammarPath_TextChanged(sender As Object, e As EventArgs) Handles txtGrammarPath.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

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
