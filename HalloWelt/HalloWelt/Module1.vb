Imports System.Globalization
Imports System.Text

Module Module1

    Sub Main()
        Console.WriteLine("Hallo Welt!")
        Console.OutputEncoding = Encoding.UTF8
        'ganzzahlige Datentypen
        Dim _8bit As Byte
        Dim zahlKlein As Short '16 bit
        Dim zahl As Integer = Int32.MaxValue '32 bit 
        Dim großeZahl As Long = 438743874387348743
        Console.WriteLine(ULong.MaxValue)

        'fließkomma
        Dim einfach As Single '32bit
        Dim doppelt As Double '64bit
        Dim geld As Decimal = 3456.8765D '128bit

        'boolean
        Dim bool As Boolean

        'text
        Dim zeichen As Char = "B"c
        Dim text As String = "bis zu 2 GB Text"

        Console.WriteLine("Mein Geld ist: " + geld.ToString("c", New CultureInfo("DE-ch")))
        Console.WriteLine(String.Format("Mein {1} Geld ist: {0:c}", geld, 467))
        Console.WriteLine($"Mein Geld ist: {geld:c}") 'string interpolation

        'casting
        großeZahl = zahlKlein 'implitize umwandlung
        'zahlKlein = CShort(zahl) 'explizite umwandlung (casting)

        'parsing
        Dim stringAlsZahl As Integer = Integer.Parse("7437438")
        Dim stringAlsZahl2 As Decimal
        If Decimal.TryParse("74374..38", stringAlsZahl2) Then
            Console.WriteLine($"OK, das doppelte: {stringAlsZahl2 * 2:c}")
        End If



        Console.ReadKey()
    End Sub

End Module
