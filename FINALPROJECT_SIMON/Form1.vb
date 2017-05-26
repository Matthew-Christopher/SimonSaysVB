' Copyright Matthew Christopher 2017 - Visual Basic 2010 'Simon Says' V1.0
' INCOMPLETE CODE - MAY BE INEFFICIENT

Public Class Form1

    ' Colours
    ' Green_DARK: 46, 204, 113
    ' Green_LIGHT: 89, 217, 143
    ' Red_DARK: 231, 76, 60
    ' Red_LIGHT: 238, 129, 118
    ' Yellow_DARK: 241, 196, 15
    ' Yellow_Light: 245, 213, 85
    ' Blue_DARK: 52, 152, 219
    ' Blue_LIGHT: 102, 176, 228
    ' Turquoise: 78, 205, 196

    Dim resetChoice As Integer
    Dim currentLightSeq As ArrayList
    Dim iter As Integer = 0
    Dim length As Integer = 3

    Dim guessNumber = 1
    Dim pScore = 0
    Dim timeLeft As Integer = 60

    Private Sub Btn_GREEN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_GREEN.Click
        ' Lights up the green button.
        light(0)
        ' Increases the guess count
        guessNumber += 1
        ' If the amount of guesses is higher than the length of the sequence to be guessed, play another sequence.
        If guessNumber > currentLightSeq.Count() - 1 Then
            Load.Start()
        End If
        ' If the player guesses correctly, increase their score.
        If currentLightSeq(guessNumber - 2) = 1 Then
            pScore += 1
            Score.Text = "Score: "
            Score.Text += pScore.ToString
        End If
    End Sub

    Private Sub Btn_RED_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_RED.Click
        light(1)
        guessNumber += 1
        If guessNumber > currentLightSeq.Count() - 1 Then
            Load.Start()
        End If
        If currentLightSeq(guessNumber - 2) = 2 Then
            pScore += 1
            Score.Text = "Score: "
            Score.Text += pScore.ToString
        End If
    End Sub

    Private Sub Btn_YELLOW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_YELLOW.Click
        light(2)
        guessNumber += 1
        If guessNumber > currentLightSeq.Count() - 1 Then
            Load.Start()
        End If
        If currentLightSeq(guessNumber - 2) = 3 Then
            pScore += 1
            Score.Text = "Score: "
            Score.Text += pScore.ToString
        End If
    End Sub

    Private Sub Btn_BLUE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_BLUE.Click
        light(3)
        guessNumber += 1
        If guessNumber > currentLightSeq.Count() - 1 Then
            Load.Start()
        End If
        If currentLightSeq(guessNumber - 2) = 4 Then
            pScore += 1
            Score.Text = "Score: "
            Score.Text += pScore.ToString
        End If
    End Sub

    Private Sub Restart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Restart.Click
        ' Reset all buttons and variables, restart the game.
        Btn_GREEN.BackColor = Color.FromArgb(46, 204, 113)
        Btn_RED.BackColor = Color.FromArgb(231, 76, 60)
        Btn_YELLOW.BackColor = Color.FromArgb(241, 196, 15)
        Btn_BLUE.BackColor = Color.FromArgb(52, 152, 219)
        Score.Font = New Font("Century Gothic", 18)
        Score.Location = New Point(12, 49)
        Time.Location = New Point(13, 9)
        Time.Font = New Font("Century Gothic", 14)
        iter = 0
        length = 3
        guessNumber = 1
        pScore = 0
        Time.Text = "60 Seconds Left"
        Score.Text = "Score: " & pScore.ToString
        timeLeft = 60
        Btn_GREEN.Visible = True
        Btn_RED.Visible = True
        Btn_YELLOW.Visible = True
        Btn_BLUE.Visible = True
        Btn_GREEN.Enabled = False
        Btn_RED.Enabled = False
        Btn_YELLOW.Enabled = False
        Btn_BLUE.Enabled = False
        Load.Start()
    End Sub

    Sub light(ByVal button)
        ' Change the buttons' colours to a lighter colour.
        Select Case button
            Case 0
                Btn_GREEN.BackColor = Color.FromArgb(89, 217, 143)
                resetChoice = 1
                Reset.Start()
            Case 1
                Btn_RED.BackColor = Color.FromArgb(238, 129, 118)
                resetChoice = 2
                Reset.Start()
            Case 2
                Btn_YELLOW.BackColor = Color.FromArgb(245, 213, 85)
                resetChoice = 3
                Reset.Start()
            Case 3
                Btn_BLUE.BackColor = Color.FromArgb(102, 176, 228)
                resetChoice = 4
                Reset.Start()
        End Select
    End Sub

    Private Sub Reset_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Reset.Tick
        ' Change the buttons' colours back to their original colour.
        Select Case resetChoice
            Case 1
                Reset.Stop()
                Btn_GREEN.BackColor = Color.FromArgb(46, 204, 113)
            Case 2
                Reset.Stop()
                Btn_RED.BackColor = Color.FromArgb(231, 76, 60)
            Case 3
                Reset.Stop()
                Btn_YELLOW.BackColor = Color.FromArgb(241, 196, 15)
            Case 4
                Reset.Stop()
                Btn_BLUE.BackColor = Color.FromArgb(52, 152, 219)
        End Select
    End Sub

    Sub ai()
        ' Create a sequence of buttons that the player will have to memorise.
        Dim seq As New ArrayList
        seq.Clear()
        Btn_GREEN.Enabled = False
        Btn_RED.Enabled = False
        Btn_YELLOW.Enabled = False
        Btn_BLUE.Enabled = False
        resetChoice = 0
        iter = 0
        guessNumber = 1
        Dim temp
        length += 1
        ' Ensure that no two same buttons play one after the other.
        For i = 0 To length
            Randomize()
            ' Random number between 1 & 4.
            temp = CInt(Math.Ceiling(Rnd() * 4))
            If i = 0 Then
                seq.Add(CInt(Math.Ceiling(Rnd() * 4)))
            Else
                If seq(i - 1) = 1 And temp = 1 Then
                    While temp = 1
                        temp = CInt(Math.Ceiling(Rnd() * 4))
                    End While
                ElseIf seq(i - 1) = 2 And temp = 2 Then
                    While temp = 2
                        temp = CInt(Math.Ceiling(Rnd() * 4))
                    End While
                ElseIf seq(i - 1) = 3 And temp = 3 Then
                    While temp = 3
                        temp = CInt(Math.Ceiling(Rnd() * 4))
                    End While
                ElseIf seq(i - 1) = 4 And temp = 4 Then
                    While temp = 4
                        temp = CInt(Math.Ceiling(Rnd() * 4))
                    End While
                End If
                seq.Add(temp)
            End If
        Next
        currentLightSeq = seq
        PlaySequence.Start()
    End Sub

    Public Sub playArray()
        ' Set the memorise sequence button to the lighter colour.
        Select Case currentLightSeq(iter)
            Case 1
                Btn_GREEN.BackColor = Color.FromArgb(89, 217, 143)
            Case 2
                Btn_RED.BackColor = Color.FromArgb(238, 129, 118)
            Case 3
                Btn_YELLOW.BackColor = Color.FromArgb(245, 213, 85)
            Case 4
                Btn_BLUE.BackColor = Color.FromArgb(102, 176, 228)
        End Select
    End Sub

    Private Sub Load_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Load.Tick
        ' After the load interval, begin the game.
        Load.Stop()
        Timer.Start()
        ai()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Wait for a short period of time before the game starts.
        Btn_GREEN.Enabled = False
        Btn_RED.Enabled = False
        Btn_YELLOW.Enabled = False
        Btn_BLUE.Enabled = False
        Load.Start()
    End Sub

    Private Sub PlaySequence_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlaySequence.Tick
        ' Reset the button's colour and play the next button in the sequence.
        Btn_GREEN.BackColor = Color.FromArgb(46, 204, 113)
        Btn_RED.BackColor = Color.FromArgb(231, 76, 60)
        Btn_YELLOW.BackColor = Color.FromArgb(241, 196, 15)
        Btn_BLUE.BackColor = Color.FromArgb(52, 152, 219)
        If iter < length Then
            ' Increase 'i' value.
            playArray()
            iter += 1
        Else
            ' Allow the player to recite the sequence.
            PlaySequence.Stop()
            Btn_GREEN.Enabled = True
            Btn_RED.Enabled = True
            Btn_YELLOW.Enabled = True
            Btn_BLUE.Enabled = True
        End If
    End Sub

    Private Sub Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer.Tick
        ' Count down and display the remaining time to the user. Once the time is up, pause the game and display the score in a large font.
        timeLeft -= 1
        If timeLeft <= 0 Then
            ' Stop all timers and display the score and "Game Over" in the center of the window in a large font. Hide the buttons.
            Time.Text = "Game Over"
            Timer.Stop()
            PlaySequence.Stop()
            Reset.Stop()
            Load.Stop()
            Btn_GREEN.Enabled = False
            Btn_RED.Enabled = False
            Btn_YELLOW.Enabled = False
            Btn_BLUE.Enabled = False
            Score.Font = New Font("Century Gothic", 45)
            Score.Location = New Point(120, 280)
            Time.Location = New Point(120, 230)
            Time.Font = New Font("Century Gothic", 30)
            Btn_GREEN.Visible = False
            Btn_RED.Visible = False
            Btn_YELLOW.Visible = False
            Btn_BLUE.Visible = False
        Else
            ' Refresh the time display.
            Time.Text = timeLeft & " Seconds Left"
        End If
    End Sub
End Class