''' <summary>
''' Das Auto
''' </summary>
Public Class Auto
    Inherits Object

    Sub New()
        AnzahlTüren = 4

    End Sub

    ''' <summary>
    ''' MAcht eine neues Auto mit der angegebenenenenne anzahl türen
    ''' </summary>
    ''' <param name="anzTür"></param>
    Sub New(anzTür As Integer)
        AnzahlTüren = anzTür
    End Sub

    Public Sub New(kraftstoffsorte As String, anzahlTüren As Integer)
        Me.Kraftstoffsorte = kraftstoffsorte
        Me.AnzahlTüren = anzahlTüren
    End Sub

    Public Sub New(kraftstoffsorte As String, anzahlTüren As Integer, umweltklasse As Integer, innenausstattug As Boolean, bauJahr As Date, leistung As Integer, farbe As String)
        kraftstoffsorte = kraftstoffsorte
        anzahlTüren = anzahlTüren
        umweltklasse = umweltklasse
        innenausstattug = innenausstattug
        bauJahr = bauJahr
        leistung = leistung
        farbe = farbe
    End Sub

    Property Kraftstoffsorte As String
    Property AnzahlTüren As Integer
    Property Umweltklasse As Integer

    ''' <summary>
    ''' Hat das Auto eine Innenausstatttung?
    ''' </summary>
    ''' <remarks>
    ''' bla bla bla
    ''' </remarks>
    Property Innenausstattug As Boolean

    Property BauJahr As Date = Date.Now
    Property Leistung As Integer 'auto property

    ReadOnly Property LeistungInKW() As Double 'readonly property
        Get
            Return Leistung / 1.37
        End Get
    End Property

    Private _farbe As String 'backing field


    Public Property Farbe() As String 'Full Property
        Get
            Return _farbe
        End Get
        Set(value As String)
            If value.Equals("rosa", StringComparison.CurrentCultureIgnoreCase) Then
                _farbe = "schwarz"
            Else
                _farbe = value
            End If
        End Set
    End Property

    Overridable Sub Hupen()
        Console.Beep(440, Leistung)
    End Sub


#Region "Beispiel für Getter/Setter (wird in .NET als Property implementiert)"

    ''backing field
    'Private farbe As String

    ''setter methode
    'Friend Sub SetFarbe(neueFarbe As String)
    '    If neueFarbe.Equals("rosa", StringComparison.CurrentCultureIgnoreCase) Then
    '        farbe = "schwarz"
    '    Else
    '        farbe = neueFarbe
    '    End If
    'End Sub

    ''getter funktion
    'Public Function GetFarbe() As String
    '    Return farbe
    'End Function
#End Region
End Class
