Imports System.IO
Imports System.Media
Imports Microsoft.WindowsAPICodePack.Taskbar

''' <summary>
''' .NET Boggle Game by Andrew Wong (11SOF1)
''' Software Design Development Assessment Task 3 (2016)
''' http://github.com/bearbear12345/school_SDD_prelimYear
''' </summary>
Public Class Boggle

#Region "Settings"
    Public GameTime As Integer = 10 ' Default game time (in seconds)
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
        "ABJMOQ",
        "AHMORS",
        "EGINTV"
    } ' Collection of 16 dice faces
#End Region


#Region "User Interface"
#Region "UI Functions"

    ''' <summary>
    ''' Game states to change the function of the interface button
    ''' </summary>
    Private GameState As Integer = 1
    Private Sub UpdateButton()
        Select Case GameState
            Case 1 ' Visible when game is reset
                btnMulti.Text = "Play"
            Case 2 ' Visible during an active game
                btnMulti.Text = "Give Up"
            Case 3 ' Visible at the end of a game
                btnMulti.Text = "Reset"
        End Select
    End Sub

    ''' <summary>
    ''' Exit game from dropdown menu item
    ''' </summary>
    Private Sub MenuExitButton() Handles menuGame_exit.Click
        Application.Exit()
    End Sub

    ''' <summary>
    ''' Open Options window
    ''' </summary>
    Private Sub MenuOptionsButton() Handles menuGame_options.Click
        Boggle_options.ShowDialog()
    End Sub

    ''' <summary>
    ''' Open About/Help window
    ''' </summary>
    Private Sub MenuHelpButton() Handles menuHelp.Click
        Boggle_about.ShowDialog()
    End Sub
#End Region

#Region "Animations"
    ' 
    ' Grid animation to make the application not so boring.
    '
    '  ||
    '  ||
    ' \||/
    '  \/
    ' 

    Dim _animationI As Integer = 0 ' Frame position
    Dim _animationFrames = New List(Of List(Of String)) ' List of lists containing a matrix of characters to show

    ''' <summary>
    ''' Add frames into frame list
    ''' </summary>
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

    ''' <summary>
    ''' Change animation frame each interval
    ''' Call from timer function
    ''' </summary>
    Private Sub animationTick() Handles animation.Tick
        animation_step()
    End Sub

    ''' <summary>
    ''' Cycle through frames
    ''' </summary>
    Private Sub animation_step()
        animation_painter(_animationFrames(_animationI)) ' Call function to display frame
        _animationI += 1 ' Increment frame position
        If _animationI = _animationFrames.Count Then
            _animationI = 0 ' Set frame position to 0 if the last frame has been reached
        End If
    End Sub

    ''' <summary>
    ''' 'Paints' the frame onto the grid
    ''' </summary>
    ''' <param name="matrix">List of 16 string elements containing text</param>
    Private Sub animation_painter(matrix As List(Of String))
        Dim i = 0
        For Each Die In {DieA1, DieB1, DieC1, DieD1, DieA2, DieB2, DieC2, DieD2, DieA3, DieB3, DieC3, DieD3, DieA4, DieB4, DieC4, DieD4} ' Work from top left to bottom right going horizontally
            Die.Text = matrix(i)
            i += 1
        Next
    End Sub

#End Region
#End Region

#Region "Dice"
#Region "Game Functions"
    Dim _wordList As New List(Of String) ' List containing words that the player enters
    ''' <summary>
    ''' Displays a popup of the player's score
    ''' </summary>
    Private Sub ShowScore()
        Dim score = 0
        For Each word In _wordList
            score += CountWord(word) ' Iterate through the user's word list, and add up each word's value
        Next
        MsgBox("You scored:" + Str(score) + " points!",, My.Application.Info.ProductName) ' Display a message box to the player
    End Sub

    ''' <summary>
    ''' Reset game
    ''' </summary>
    Private Sub InitialiseGame()

        txtMaxScore.Visible = False ' Hide the max score notice
        txtMaxScore.Text = "Max Score: Calculating..." ' Reset default text
        maxScoreThread_flag = False ' Abort max score calculation if running
        StopGame() ' Stop any running timers and disable game controls
        GameTimer.Tag = GameTime ' Reset game time
        userList.Items.Clear() ' Clear user's word list
    End Sub

    ''' <summary>
    ''' Start the game
    ''' </summary>
    Private Sub StartGame()
        txtMaxScore.Visible = True ' Show the max score notice
        Dim maxScoreThread As New System.Threading.Thread(AddressOf CalculateMaxScore) ' Create threading object to calculate the maximum score in the background
        maxScoreThread.Start() ' Start the max score calculation
        TaskbarManager.Instance.SetProgressState(2) ' Make taskbar progress bar green
        txtInput.Enabled = True ' Enable word input
        txtInput.Focus() ' Switch the application focus to the textbox so the player does not have to enter it themselves
        If GameTime <> -1 Then ' Check if the game is not on unlimited mode (aka no timer).. Else:
            lblTime.Visible = True ' Show the countdown time
            lblTime.Text = "Time: " + GameTime.ToString() ' Set countdown time
            GameTimer.Start() ' Start countdown timer
        End If
    End Sub

    ''' <summary>
    ''' Stop the game
    ''' </summary>
    Private Sub StopGame()
        shuffleTimer.Stop() ' Stop shuffle effect
        GameTimer.Stop() ' Stop countdown timer
        TaskbarManager.Instance.SetProgressValue(1, 1) ' Make taskbar progress bar completely full
        TaskbarManager.Instance.SetProgressState(8) ' Make taskbar progress bar yellow
        txtInput.Clear() ' Clear word input
        txtInput.Enabled = False ' Disable word input
        lblTime.Visible = False ' Hide the countdown time
    End Sub

    ''' <summary>
    ''' Multi-function button effect, that changes function according to the game state
    ''' </summary>
    Public Sub ButtonEvent() Handles btnMulti.Click
        Select Case GameState
            Case 1 ' Click event when waiting for new game
                InitialiseGame() ' Call reset game function
                animation.Stop() ' Stop animation
                shuffleTimer.Tag = DateTime.Now.AddSeconds(2).Ticks ' Set shuffle time
                shuffleTimer.Start() ' Start shuffling!
                SetGameState(2) ' Set game state to ingame
                Return
            Case 2 ' Click event when ingame
                StopGame() ' Call stop game function
                ShowScore() ' Display user's score
                SetGameState(3) ' Set game state to finished
                Return
            Case 3 ' Click event when finished
                InitialiseGame() ' Call reset game function
                _animationI = 1 ' Set animation frame to the second frame (I don't like the blank frame)
                animation.Start() ' Start animation
                SetGameState(1) ' Set game state to waiting
                Return
        End Select
    End Sub

    ''' <summary>
    ''' Shake the board!
    ''' </summary>
    Private Sub Shuffle()
        Dim rand As New Random ' Create 'random' object
        Dim allNumbers As New List(Of Integer)(Enumerable.Range(1, 16)) ' Create a list of integers from 1 to 16
        Dim selectedNumbers As New List(Of Integer) ' Create empty list of integers
        Dim i As Integer
        For i = 0 To 15 ' Repeat 16 times
            Dim index As Integer = rand.Next(0, allNumbers.Count) ' Generate a random number from 0 to the amount of items in allNumbers
            selectedNumbers.Add(allNumbers(index) - 1) ' Add the number with the index of 'index' to selectedNumbers
            allNumbers.RemoveAt(index) ' Remove the added number
        Next

        i = 0
        For Each Die In pnlGameboard.Controls
            Die.Text = Replace(_dieFaces(selectedNumbers(i))(Int(Rnd() * 6)), "Q", "Qu") ' Assign random die face to each grid location, replacing "Q" with "Qu" if necessary
            i += 1
        Next
    End Sub

    ''' <summary>
    ''' Keyboard listener
    ''' We're intercepting the keypress event BEFORE the new key is shown in the text box
    ''' </summary>
    Private Sub UserInput(sender As Object, e As KeyPressEventArgs) Handles txtInput.KeyPress
        If (txtInput.TextLength = 15 Or e.KeyChar = ChrW(Keys.Return)) Then ' Handle the 16th letter (if that happens), or the return key
            HandleWord((txtInput.Text + e.KeyChar).ToLower().Trim()) ' Pass the lowercase transformation of the submitted word to the HandleWorld subroutine
            txtInput.Clear() ' Clear word input
            e.Handled = True ' Finish the event
        ElseIf Not (Char.IsLetter(e.KeyChar) Or e.KeyChar = ChrW(Keys.Back) Or e.KeyChar = ChrW(Keys.Delete)) Or e.KeyChar = "." Then ' Allow only letters to be typed in
            e.Handled = True
        End If
    End Sub
#End Region

#Region "Game Utilities"
    Dim _lexicon() As String
    ''' <summary>
    ''' Initialise application interface
    ''' </summary>
    Private Sub AppLoad(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            _lexicon = File.ReadAllLines("lexicon.txt") ' Read 'lexicon.txt' word list
        Catch
            _lexicon = My.Resources.lexicon.Split() ' If 'lexicon.txt' can't be read (404! or parsing error), then use embedded word list
        End Try
        Boggle_about.Text = My.Application.Info.ProductName
        Boggle_about.OKButton.Text = "Continue"
        Boggle_about.ShowDialog()
        Boggle_about.Text = "About Boggle"
        Boggle_about.OKButton.Text = "OK"
        animation_initialise()
        animation.Start()
    End Sub

    ''' <summary>
    ''' Intercept application quit event
    ''' </summary>
    Private Sub AppQuit(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        maxScoreThread_flag = False ' Tell maximum score calculation thread to stop
    End Sub

    ''' <summary>
    ''' Utility function to universally change the game state
    ''' State 1 - waiting for new game
    ''' State 2 - ingame
    ''' State 3 - finished
    ''' </summary>
    Public Sub SetGameState(i As Integer)
        GameState = i ' Change value of GameState
        UpdateButton() ' Update button text
    End Sub

    ''' <summary>
    ''' Calculates the word's point value
    ''' </summary>
    ''' <param name="word">word</param>
    ''' <returns>Integer</returns>
    Private Function CountWord(word)
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

    ''' <summary>
    ''' Finds grid locations of input character
    ''' </summary>
    ''' <param name="ch">Character to find grid locations for</param>
    ''' <returns>List of labels (grid locations)</returns>
    Private Function GetGridLocations(ch As Char)
        Return (From die In pnlGameboard.Controls.Cast(Of Label)().ToList() Where die.Text.ToLower()(0) = ch).ToList()
    End Function

    ''' <summary>
    ''' Returns locations surrounding a particular grid location (hard coded)
    ''' </summary>
    ''' <param name="loc">Grid location</param>
    ''' <returns></returns>
    Private Function GetSurroundingLocations(loc As Label)
        ' Hardcoded for a 4x4 grid
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

    ''' <summary>
    ''' Self-executing function to validate if a word is on the grid
    ''' The function calls itself for each path it can take - To get the word BEAR, there might be two Es around the B, and only one E might have a surrounding A.
    ''' </summary>
    ''' <param name="i">Current position through word</param>
    ''' <param name="word">List of sequential individual characters of a word</param>
    ''' <param name="previous">Previous grid location</param>
    ''' <param name="exclude">Grid locations to skip</param>
    Private Function WordLoop(i As Integer, word As List(Of Char), previous As Label, exclude As List(Of Label))
        exclude.Add(previous) ' Exclude previous grid location
        Dim oldlettersurroundings() As Label = GetSurroundingLocations(previous) ' Get grid locations surrounding the previous location
        Dim newletterlocations As List(Of Label) = GetGridLocations(word(i)) ' Find grid locations of the next letter
        Dim locationsmatch As List(Of Label) = oldlettersurroundings.Intersect(newletterlocations).Except(exclude).ToList() ' Match grid locations of the next letter around the previous letter, exluding previously used letters

        If locationsmatch.Count = 0 Then
            Return False ' If there aren't any matching letters, fail this path
        ElseIf i + 1 = word.Count Then
            Return True ' If all letters have been found, approve the word
        End If

        For Each x In locationsmatch
            If WordLoop(i + 1, word, x, exclude) Then Return True ' Self-execute a new child path, returning true to it parent's parent call if the word is approved
        Next

        Return False ' Fail this path

        ' Example 
        '
        ' B will search for surrounding Es (A3, C3)
        ' For each E that is found:
        '   E @ A3 will search for surrounding As (A2, A4)
        '     For each A that is found:
        '       A @ A4 will search for surrounding Rs (none - therefore try another A)
        '       A @ A2 will search for surrounding Rs (A1)
        '         Word found - Approve the word
        '
        ' /  A B C D
        '
        ' 1  R X X X
        '
        ' 2  A X X X 
        '
        ' 3  E X E X
        '
        ' 4  A B X X
        '
    End Function
    Private Function ValidateWord(word As String)
        If word.Length < 3 Or word.Length > 16 Then Return False ' Make sure the word is 3 - 16 characters long
        word = word.Replace("qu", "q") ' Replace "qu" with "q" during the validation process
        Dim wordSplit As List(Of Char) = word.ToCharArray().ToList() ' Split the word into a list of characters
        If wordSplit.Any(Function(letter) GetGridLocations(letter).Count = 0) Then Return False ' Make sure all the letters are on the game board

        ' Alternate WordLoop function for the first character
        Dim newletterlocations = GetGridLocations(word(0))
        For Each newletterlocation In newletterlocations
            If WordLoop(1, wordSplit, newletterlocation, New List(Of Label)) Then Return True
        Next
        Return False
    End Function

    ReadOnly dingSound As SoundPlayer = New SoundPlayer(My.Resources.ding) ' 'Ding' noise for when the user enters a new valid word
    ''' <summary>
    ''' Handle word received from word input
    ''' </summary>
    ''' <param name="word">lowercase word</param>
    Private Sub HandleWord(word As String)
        If Not ValidateWord(word) Then
            Return ' Ignore words that do not appear on the game board
        End If
        word = word.Replace("q", "qu") ' Restore "q" back into "qu"
        If _lexicon.Contains(word) Then ' Check if the lexicon contains the word
            If Not _wordList.Contains(word) Then ' Check if the word has already been entered
                _wordList.Add(word) ' Add the word into the user word list
                _userList.Items.Add(word) ' Display the word in the application
                dingSound.Play() ' Play a 'ding' noise. Yay!
            End If
        End If
    End Sub

    Dim maxScoreThread_flag As Boolean ' Volatile flag variable to work around threading issues present in VB.NET or something
    ''' <summary>
    ''' (Function called by thread)
    ''' Calculate the highest possible score of the given gameboard by trying to validate each word in the lexicon
    ''' </summary>
    Sub CalculateMaxScore()
        maxScoreThread_flag = True ' Allow thread to run
        Dim maxscore = 0
        For Each word In _lexicon
            If ValidateWord(word) Then
                maxscore += CountWord(word) ' For every word in the lexicon, if it is a valid word, add its word value
            End If
            If Not maxScoreThread_flag Then Return ' If flag is False, stop the function
        Next
        txtMaxScore.Text = "Max Score:" + Str(maxscore) ' Display the maximum score
    End Sub

#End Region

#End Region

#Region "Timers"

    ''' <summary>
    ''' Shuffle effect
    ''' Call from timer function
    ''' </summary>
    Private Sub shuffleTimerTick() Handles shuffleTimer.Tick
        If shuffleTimer.Tag > DateTime.Now.Ticks Then
            Shuffle()
        Else
            shuffleTimer.Stop()
            StartGame()
        End If
    End Sub

    ''' <summary>
    ''' Countdown timer
    ''' Call from timer function
    ''' </summary>
    Private Sub GameTimerTick() Handles GameTimer.Tick
        GameTimer.Tag -= 1 ' Decrement time by one second
        lblTime.Text = "Time: " + GameTimer.Tag.ToString() ' Show remaining time
        TaskbarManager.Instance.SetProgressValue(GameTimer.Tag, GameTime) ' Update taskbar progress bar
        TaskbarManager.Instance.SetProgressState(If(GameTimer.Tag / GameTime > 0.6, 2, If(GameTimer.Tag / GameTime > 0.3, 8, 4))) ' Change taskbar progress bar colour depending on remaining time. (0-30% - Red, 30-60% - Yellow, 60-100% - Green)
        lblTime.ForeColor = If(GameTimer.Tag / GameTime <= 0.6, If(GameTimer.Tag / GameTime <= 0.3, Color.Red, Color.Orange), Color.Black) ' Change countdown colour
        If GameTimer.Tag = 0 Then ' When timer reaches 0
            SetGameState(2) ' Set game state to finished
            ButtonEvent() ' Simulate a 'Give Up' button click
        End If
    End Sub

#End Region
End Class

