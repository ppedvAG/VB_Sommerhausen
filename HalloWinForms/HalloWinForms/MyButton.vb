Public Class MyButton
    Inherits Button

    Public Overrides Property BackColor As Color
        Get
            Return MyBase.BackColor
        End Get
        Set(value As Color)
            If value = Color.Pink Then
                MyBase.BackColor = Color.Black
            Else
                MyBase.BackColor = value
            End If
        End Set
    End Property

    Protected Overrides Sub OnPaint(pevent As PaintEventArgs)

        'MyBase.OnPaint(pevent)
        pevent.Graphics.FillEllipse(Brushes.LightSalmon, ClientRectangle)
    End Sub

End Class
