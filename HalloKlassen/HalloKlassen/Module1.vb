Imports System.IO

Module Module1

    Sub Main()
        Console.WriteLine("Hallo Klassen")

        Dim meinAuto As Auto 'deklaration
        meinAuto = New Auto() 'instanzierung
        meinAuto.Farbe = "rOsA"
        meinAuto.Kraftstoffsorte = "Diesel"
        meinAuto.Leistung = 743

        ZeigeAuto(meinAuto)

        Dim deinAuto As New Auto() 'deklaration + instanzierung
        deinAuto.Farbe = "rot"
        deinAuto.Kraftstoffsorte = "Supa"
        deinAuto.Leistung = 323

        ZeigeAuto(deinAuto)


        Dim meinCabrio As New Cabrio()
        meinCabrio.Leistung = 600
        meinCabrio.Dachmaterial = "Stoff"
        ZeigeAuto(meinCabrio)

        Console.ReadKey()
    End Sub

    Sub ZeigeAuto(einAuto As Auto)
        If TypeOf einAuto Is Cabrio Then 'typprüfung
            Dim autoAsCabrio As Cabrio = CType(einAuto, Cabrio) 'typumwandlung (casting)
            Console.WriteLine($"Cabrio Material: {autoAsCabrio.Dachmaterial}")
        End If

        Dim einCabrio = TryCast(einAuto, Cabrio) 'besser!
        If Not einCabrio Is Nothing Then
            Console.WriteLine($"Cabrio Material: {einCabrio.Dachmaterial}")
        End If



        Console.WriteLine($"Farbe: {einAuto.Farbe} {vbNewLine}" &
                          $"Leistung: {einAuto.Leistung} ({einAuto.LeistungInKW:0.00})" &
                          $"{vbNewLine}Bitten tanken Sie: {einAuto.Kraftstoffsorte}")
    End Sub

End Module
