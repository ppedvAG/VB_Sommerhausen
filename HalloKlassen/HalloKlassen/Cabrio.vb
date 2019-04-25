Public Class Cabrio
    Inherits Auto

    Property Dachmaterial As String

    Overrides Sub Hupen()
        Console.Beep(840, Leistung)
    End Sub


End Class
