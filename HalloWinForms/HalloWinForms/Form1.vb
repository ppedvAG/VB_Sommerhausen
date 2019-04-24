Public Class Form1


    Dim counter As Integer = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        counter += 1

        For index = 1 To 10

            DieTextBox1.Left += 1
            DieTextBox1.Top += 1

        Next

        'If counter = 1 Then
        '    MessageBox.Show($"Hallo {DieTextBox1.Text} das war der erste klick")
        'Else
        '    MessageBox.Show($"Hallo {DieTextBox1.Text} du hast schon {counter} mal geklickt.")
        'End If

    End Sub



    Dim speed_X As Integer = 2
    Dim speed_Y As Integer = 2


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        DVDButton.Left += speed_X
        DVDButton.Top += speed_Y


        If DVDButton.Right >= Panel1.Right Or DVDButton.Left <= 0 Then
            speed_X *= -1
        End If


        If DVDButton.Bottom >= Panel1.ClientRectangle.Bottom Or DVDButton.Top <= 0 Then
            speed_Y *= -1
        End If

    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        Timer1.Interval = TrackBar1.Value
    End Sub

    Private Sub DVDButton_MouseUp(sender As Object, e As MouseEventArgs) Handles DVDButton.MouseUp
        If e.Button = MouseButtons.Left Then
            MessageBox.Show("Links")
        End If
    End Sub


    Dim besterBelag As Belag = Belag.Käse & Belag.Käse & Belag.Wurst

End Class
