Module Module1

    Sub Main()
        Console.WriteLine("Hallo Klassen")

        Dim meinAuto As Auto 'deklaration
        meinAuto = New Auto() 'instanzierung
        meinAuto.Farbe = "rOsA"
        meinAuto.kraftstoffsorte = "Diesel"
        meinAuto.Leistung = 743

        ZeigeAuto(meinAuto)

        Dim deinAuto As New Auto() 'deklaration + instanzierung
        deinAuto.Farbe = "rot"
        deinAuto.kraftstoffsorte = "Supa"
        deinAuto.Leistung = 323

        ZeigeAuto(deinAuto)


        Console.ReadKey()
    End Sub

    Sub ZeigeAuto(einAuto As Auto)
        Console.WriteLine($"Farbe: {einAuto.Farbe} {vbNewLine}" &
                          $"Leistung: {einAuto.Leistung} ({einAuto.LeistungInKW:0.00})" &
                          $"{vbNewLine}Bitten tanken Sie: {einAuto.kraftstoffsorte}")
    End Sub

End Module
