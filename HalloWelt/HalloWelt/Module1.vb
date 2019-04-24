Module Module1

    Sub Main()
        Console.WriteLine("Hallo Welt!")

        'ganzzahlige Datentypen
        Dim _8bit As Byte
        Dim zahlKlein As Short '16 bit
        Dim zahl As Integer '32 bit
        Dim großeZahl As Long
        Console.WriteLine(ULong.MaxValue)

        'fließkomma
        Dim einfach As Single '32bit
        Dim doppelt As Double '64bit
        Dim geld As Decimal '128bit

        'boolean
        Dim bool As Boolean

        'text
        Dim zeichen As Char = "B"
        Dim text As String = "bis zu 2 GB Text"



        Console.ReadKey()
    End Sub

End Module
