Imports Microsoft.WindowsAPICodePack.Taskbar
Imports System.IO

Public Class AppMain
    Dim _lexicon() As String
    ReadOnly _gameTime As Integer = 180
    Dim _wordList As New List(Of String)
    ReadOnly DieList() As String = New String() {
    "ACDEMP",
    "EGKLUY",
    "BFIORX",
    "ACELRS",
    "DENOSW",
    "ADENVZ",
    "ABILTY",
    "EHINIS",
    "ELPSTU",
    "AEFHIY",
    "DKNOTU",
    "ACEIOT",
    "GILRUW",
    "ABJMOq",
    "AHMORS",
    "EGINTV"
}

    #Region "Game Functions"
    Public Sub ResetGame() Handles btnPlay.Click
        StopGame()
        InfoTip.Visible = False
        TaskbarManager.Instance.SetProgressValue(1, 1)
        TaskbarManager.Instance.SetProgressState(8)
        GameTimer.Tag = _gameTime
        _wordList.Clear()
        shuffleTimer.Tag = DateTime.Now.AddSeconds(2).Ticks
        shuffleTimer.Start()
    End Sub
    Public Sub StartGame()
        TaskbarManager.Instance.SetProgressState(2)
        txtInput.Enabled = True
        txtInput.Focus()
        lblTime.Visible = True
        lblTime.Text = "Time: " + _gameTime.ToString()
        GameTimer.Start()
    End Sub
    Public Sub StopGame()
        GameTimer.Stop()
        TaskbarManager.Instance.SetProgressValue(1, 1)
        txtInput.Clear()
        txtInput.Enabled = False
        lblTime.Visible = False

    End Sub
    Public Sub Shuffle()
        Dim i As Integer = 0
        Dim rand As New Random
        Dim allNumbers As New List(Of Integer)(Enumerable.Range(1, 16))
        Dim selectedNumbers As New List(Of Integer)
        For i = 0 To 15
            Dim index As Integer = rand.Next(0, allNumbers.Count)
            selectedNumbers.Add(allNumbers(index) - 1)
            allNumbers.RemoveAt(index)
        Next

        i = 0
        For Each Die In pnlGameboard.Controls
            Die.Text = Replace(DieList(selectedNumbers(i))(Int(Rnd() * 6)), "q", "Qu")
            i += 1
        Next
    End Sub
    Public Sub txtInput_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtInput.KeyPress
        If (txtInput.TextLength = 15 Or e.KeyChar = ChrW(Keys.Return)) Then
            If txtInput.TextLength > 2 Then
                HandleWord(txtInput.Text.Trim().ToLower())
            End If
            txtInput.Clear()
            e.Handled = True
        ElseIf Not (Char.IsLetter(e.KeyChar) Or e.KeyChar = ChrW(Keys.Back) Or e.KeyChar = ChrW(Keys.Delete)) Or e.KeyChar = "." Then
            e.Handled = True
        End If
    End Sub
#End Region

#Region "Timers"
    Public Sub shuffleTimer_Tick(sender As Object, e As EventArgs) Handles shuffleTimer.Tick
        If shuffleTimer.Tag > DateTime.Now.Ticks Then '??? WHAT.
            Shuffle()
        Else
            shuffleTimer.Stop()
            StartGame()
        End If
    End Sub
    Public Sub GameTimer_Tick(sender As Object, e As EventArgs) Handles GameTimer.Tick
        GameTimer.Tag -= 1
        lblTime.Text = "Time: " + GameTimer.Tag.ToString()
        TaskbarManager.Instance.SetProgressValue(GameTimer.Tag, _gameTime)
        TaskbarManager.Instance.SetProgressState(If(GameTimer.Tag / _gameTime > 0.6, 2, If(GameTimer.Tag / _gameTime > 0.3, 8, 4)))
        If GameTimer.Tag = 0 Then
            StopGame()
            Dim score As Integer = 0
            For Each word In _wordList
                score += countWord(word)
            Next
            MsgBox("You scored: " + score + "!")
        End If

    End Sub
#End Region

#Region "Game Utilities"
    Public Sub AppLoad(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _lexicon = File.ReadAllLines("lexicon.txt")
    End Sub
    Public Function countWord(word)
        Select Case word.length
            Case Is > 7
                Return 11
            Case 7
                Return 5
            Case 6
                Return 3
            Case 5
                Return 2
            Case 4, 3
                Return 1
        End Select
    End Function
    Public Function getGridLocations(ch As Char)
        Return (From die In pnlGameboard.Controls.Cast(Of Label)().ToList() Where die.Text.ToLower()(0) = ch).ToList()
    End Function
    Public Function getSurroundingLocations(loc As Label)
        ' Hardcoded for 4x4 grid. Can do five by attempting to +- 1 number and character between A - ? and 1 - ?
        Select Case loc.Name.Substring(3)
            Case "A1"
                Return {DieB1, DieB2, DieA2}
            Case "A2"
                Return {DieA1, DieB1, DieB2, DieB3, DieA3}
            Case "A3"
                Return {DieA2, DieB2, DieB3, DieB4, DieA4}
            Case "A4"
                Return {DieA3, DieB3, DieB4}
            Case "B1"
                Return {DieC1, DieC2, DieB2, DieA2, DieA1}
            Case "B2"
                Return {DieA1, DieB1, DieC1, DieC2, DieC3, DieB3, DieA3, DieA2}
            Case "B3"
                Return {DieA2, DieB2, DieC2, DieC3, DieC4, DieB4, DieA4, DieA3}
            Case "B4"
                Return {DieA3, DieB3, DieC3, DieC4, DieA4}
            Case "C1"
                Return {DieB1, DieD1, DieD2, DieC2, DieB2}
            Case "C2"
                Return {DieB1, DieC1, DieD1, DieD2, DieD3, DieC3, DieB3, DieB2}
            Case "C3"
                Return {DieB2, DieC2, DieD2, DieD3, DieD4, DieC4, DieB4, DieB3}
            Case "C4"
                Return {DieB3, DieC3, DieD3, DieD4, DieB4}
            Case "D1"
                Return {DieC1, DieD2, DieC2}
            Case "D2"
                Return {DieC1, DieD1, DieD3, DieC3, DieC2}
            Case "D3"
                Return {DieC2, DieD2, DieD4, DieC4, DieC3}
            Case "D4"
                Return {DieC3, DieD3, DieC4}
        End Select
        Return False
    End Function
    Public Function WordLoop(i As Integer, word As List(Of Char), previous As Label, exclude As List(Of Label))
        exclude.Add(previous)
        Dim oldlettersurroundings As List(Of Label) = getSurroundingLocations(previous)
        Dim newletterlocations As List(Of Label) = getGridLocations(word(i))
        Dim locationsmatch As List(Of Label) = oldlettersurroundings.Intersect(newletterlocations).Except(exclude)

        If locationsmatch.Count = 0 Then
            Return False
        ElseIf i + 1 = word.Count Then
            Return True
        End If

        For Each x In locationsmatch
            if WordLoop(i + 1, word, x, exclude) Then return true
        Next

        Return False

    End Function
    Public Function ValidateWord(word As String)
        word = word.Replace("qu", "q")
        Dim wordSplit as List(Of Char) = word.ToCharArray().ToList()
        If wordSplit.Any(Function(letter) getGridLocations(letter).Count = 0) Then Return False
        Dim newletterlocations = getGridLocations(word(0))
        For Each newletterlocation In newletterlocations
            if WordLoop(1, wordSplit, newletterlocation, New List(Of Label)) then return True
        Next
        Return False
   #Region "CodePattern"
        '    Dim temporaryvar = getGridLocations(wordSplit(0)) ' FIRST
        '    If temporaryvar.count = 0 Then Return False
        ''1 letter
        '    Dim btemporaryvar = getGridLocations(wordSplit(1)) ' SECOND
        '    'Dim temporarylocations = getSurroundingLocations(temporaryvar) ' Surrounding FIRST

        '    for each a in temporaryvar 
        '        'Dim exclude As List(Of Label)
        '        'exclude.Add(a)

        '        Dim _temporarylocation as List(Of Label) = getSurroundingLocations(a)
        '        Dim _temporarylocations = _temporarylocation.Intersect(btemporaryvar) ' Get position of next letter

        '        If _temporarylocations.Count = 0 then return false
        ''second letter

        '        Dim Ctemporaryvar = getGridLocations(wordSplit(2)) ' THIRD
        '        for each b in _temporarylocations
        '            Dim exclude As New List(Of Label)
        '            exclude.Add(a)

        '            Dim ztemporarylocation = getSurroundingLocations(b)
        '            Dim ztemporarylocations = ztemporarylocation.Intersect(Ctemporaryvar).except(exclude)

        '            If ztemporarylocations.count = 0 then Return false
        ''third letter
        '            Dim Dtemporaryvar = getGridLocations(wordSplit(3)) ' FOURTH
        '            for each c in ztemporarylocations
        '                Dim excludemore as New List(of Label)
        '                excludemore.Add(b)

        '                Dim xtemporarylocation = getSurroundingLocations(c)
        '                Dim xtemporarylocations = xtemporarylocation.intersects(Dtemporaryvar).except(excludemore)
        '                if xtemporarylocations.count = 0 then return false
        ''fourth letter



        '            Next
        '        next





        '    Next
#End Region
    End Function
    Public Sub HandleWord(word As String)
        If Not ValidateWord(word) Then
            Return
        End If
        word = word.Replace("q", "qu")
        If _lexicon.Contains(word) Then
            If Not _wordList.Contains(word) Then
                _wordList.Add(word)
                My.Computer.Audio.Play("ding.wav")
            End If
        End If
    End Sub
#End Region


End Class

