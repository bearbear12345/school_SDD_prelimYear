Imports System.IO
Imports System.Media
Imports Microsoft.WindowsAPICodePack.Taskbar

Public Class Boggle
#Region "Settings"
    Public GameTime As Integer = 180
    ReadOnly _dieFaces() As String = New String() {
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
#End Region
#Region "UI"
    Public GameState As Integer = 1
    Public Sub UpdateButton()
        Select Case GameState
            Case 1 ' Reset
                btnMulti.Text = "Play"
            Case 2 ' Playing
                btnMulti.Text = "Give Up"
            Case 3 ' Stopped
                btnMulti.Text = "Reset"
        End Select
    End Sub
    Private Sub MenuExitButton(sender As Object, e As EventArgs) Handles menuGame_exit.Click
        Application.Exit()
    End Sub
    Private Sub MenuOptionsButton(sender As Object, e As EventArgs) Handles menuGame_options.Click
        Boggle_options.ShowDialog()
    End Sub
    Private Sub MenuHelpButton(sender As Object, e As EventArgs) Handles menuHelp.Click
        Boggle_about.ShowDialog()
    End Sub
#End Region


#Region "Game Functions"
    Dim _wordList As New List(Of String)
    Public Sub ShowScore()
        Dim score = 0
        For Each word In _wordList
            score += CountWord(word)
        Next
        MsgBox("You scored:" + Str(score) + " points!",, My.Application.Info.ProductName)
    End Sub
    Public Sub InitialiseGame()
        txtMaxScore.Visible = False
        txtMaxScore.Text = "Max Score: Calculating..."
        maxScoreThread_flag = False
        StopGame()
        TaskbarManager.Instance.SetProgressValue(1, 1)
        TaskbarManager.Instance.SetProgressState(8)
        GameTimer.Tag = GameTime
        userList.Items.Clear()
    End Sub

    Dim maxScoreThread As New System.Threading.Thread(AddressOf CalculateMaxScore)
    Public Sub StartGame()
        txtMaxScore.Visible = True
        maxScoreThread.Start()
        TaskbarManager.Instance.SetProgressState(2)
        txtInput.Enabled = True
        txtInput.Focus()
        If GameTime <> -1 Then
            lblTime.Visible = True
            lblTime.Text = "Time: " + GameTime.ToString()
            GameTimer.Start()
        End If
    End Sub
    Public Sub StopGame()
        shuffleTimer.Stop()
        GameTimer.Stop()
        txtInput.Clear()
        txtInput.Enabled = False
        lblTime.Visible = False
    End Sub
    Public Sub ButtonEvent() Handles btnMulti.Click
        Select Case GameState
            Case 1 ' Click when waiting for new game
                InitialiseGame()
                animation.Stop()
                shuffleTimer.Tag = DateTime.Now.AddSeconds(2).Ticks
                shuffleTimer.Start()
                SetGameState(2)
                Return
            Case 2 ' Click when playing
                StopGame()
                TaskbarManager.Instance.SetProgressValue(1, 1)
                TaskbarManager.Instance.SetProgressState(8)
                ShowScore()
                SetGameState(3)
                Return
            Case 3 ' Click when end
                InitialiseGame()
                _animationI = 1
                animation.Start()
                SetGameState(1)
                Return
        End Select
    End Sub
    Public Sub Shuffle()
        Dim i = 0
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
            Die.Text = Replace(_dieFaces(selectedNumbers(i))(Int(Rnd() * 6)), "q", "Qu")
            i += 1
        Next
    End Sub
    Public Sub UserInput(sender As Object, e As KeyPressEventArgs) Handles txtInput.KeyPress
        If (txtInput.TextLength = 15 Or e.KeyChar = ChrW(Keys.Return)) Then
            HandleWord(txtInput.Text.Trim().ToLower())
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
        TaskbarManager.Instance.SetProgressValue(GameTimer.Tag, GameTime)
        TaskbarManager.Instance.SetProgressState(If(GameTimer.Tag / GameTime > 0.6, 2, If(GameTimer.Tag / GameTime > 0.3, 8, 4)))
        If GameTimer.Tag = 0 Then
            SetGameState(2)
            ButtonEvent()
        End If

    End Sub
#End Region
#Region "Game Utilities"
    Dim _lexicon() As String
    Public Sub AppLoad(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            _lexicon = File.ReadAllLines("lexicon.txt")
        Catch
            _lexicon = My.Resources.lexicon.Split()
        End Try
        Boggle_about.Text = My.Application.Info.ProductName
        Boggle_about.OKButton.Text = "Continue"
        Boggle_about.ShowDialog()
        Boggle_about.Text = "About Boggle"
        Boggle_about.OKButton.Text = "OK"
        animation_initialise()
        animation.Start()
    End Sub
    Private Sub AppQuit(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        maxScoreThread_flag = False
    End Sub
    Public Sub SetGameState(i As Integer)
        GameState = i
        UpdateButton()
    End Sub
    Public Function CountWord(word)
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
        Return False
    End Function
    Public Function GetGridLocations(ch As Char)
        Return (From die In pnlGameboard.Controls.Cast(Of Label)().ToList() Where die.Text.ToLower()(0) = ch).ToList()
    End Function
    Public Function GetSurroundingLocations(loc As Label)
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
        Dim oldlettersurroundings() As Label = GetSurroundingLocations(previous)
        Dim newletterlocations As List(Of Label) = GetGridLocations(word(i))
        Dim locationsmatch As List(Of Label) = oldlettersurroundings.Intersect(newletterlocations).Except(exclude).ToList()

        If locationsmatch.Count = 0 Then
            Return False
        ElseIf i + 1 = word.Count Then
            Return True
        End If

        For Each x In locationsmatch
            If WordLoop(i + 1, word, x, exclude) Then Return True
        Next

        Return False

    End Function
    Public Function ValidateWord(word As String)
        If word.Length < 3 or word.Length > 16 Then Return False
        word = word.Replace("qu", "q")
        Dim wordSplit As List(Of Char) = word.ToCharArray().ToList()
        If wordSplit.Any(Function(letter) GetGridLocations(letter).Count = 0) Then Return False
        Dim newletterlocations = GetGridLocations(word(0))
        For Each newletterlocation In newletterlocations
            If WordLoop(1, wordSplit, newletterlocation, New List(Of Label)) Then Return True
        Next
        Return False
    End Function
    Dim dingSound As SoundPlayer = New SoundPlayer(My.Resources.ding)
    Public Sub HandleWord(word As String)
        If Not ValidateWord(word) Then
            Return
        End If
        word = word.Replace("q", "qu")
        If _lexicon.Contains(word) Then
            If Not _wordList.Contains(word) Then
                _wordList.Add(word)
                _userList.Items.Add(word)
                dingSound.Play()
            End If
        End If
    End Sub
    Dim maxScoreThread_flag As Boolean
    Sub CalculateMaxScore()
        maxScoreThread_flag = True
        Dim maxscore = 0
        For Each word In _lexicon
            If ValidateWord(word) Then
                maxscore += CountWord(word)
            End If
            If Not maxScoreThread_flag Then Return
        Next
        txtMaxScore.Text = "Max Score:" + Str(maxscore)
    End Sub

#End Region
#Region "Animations"
    Dim _animationI As Integer = 0
    Dim _animationFrames = New List(Of List(Of String))
    Private Sub animationTick(sender As Object, e As EventArgs) Handles animation.Tick
        animation_step()
    End Sub
    Private Sub animation_initialise()
        _animationFrames.Add(New List(Of String)({"", "", "", "", "", "", "", "", "", "", "", "", "", "", "", ""}))
        _animationFrames.Add(New List(Of String)({"", "\", "/", "", "", "", "", "", "", "", "", "", "", "", "", ""}))
        _animationFrames.Add(New List(Of String)({"\", "|", "|", "/", "", "\", "/", "", "", "", "", "", "", "", "", ""}))
        _animationFrames.Add(New List(Of String)({"", "|", "|", "", "\", "|", "|", "/", "", "\", "/", "", "", "", "", ""}))
        _animationFrames.Add(New List(Of String)({"", "|", "|", "", "", "|", "|", "", "\", "|", "|", "/", "", "\", "/", ""}))
        _animationFrames.Add(New List(Of String)({"", "", "", "", "", "|", "|", "", "", "|", "|", "", "\", "|", "|", "/"}))
        _animationFrames.Add(New List(Of String)({"", "", "", "", "", "", "", "", "", "|", "|", "", "", "|", "|", ""}))
        _animationFrames.Add(New List(Of String)({"", "", "", "", "", "", "", "", "", "", "", "", "", "|", "|", ""}))
    End Sub
    Private Sub animation_step()
        animation_painter(_animationFrames(_animationI))
        _animationI += 1
        If _animationI = _animationFrames.Count Then
            _animationI = 0
        End If
    End Sub
    Private Sub animation_painter(matrix As List(Of String))
        Dim i = 0
        For Each Die In {DieA1, DieB1, DieC1, DieD1, DieA2, DieB2, DieC2, DieD2, DieA3, DieB3, DieC3, DieD3, DieA4, DieB4, DieC4, DieD4}
            Die.Text = matrix(i)
            i += 1
        Next
    End Sub
#End Region
End Class

