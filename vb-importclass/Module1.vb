Imports System
Imports System.IO
Imports System.Text

Module Module1

    Sub Main()
        Dim s1 = New String() {"New York", "Virginia", "California", "Florida", "Hawaii"}
        Dim c1 As New City("Los Angeles", "4 million")
        Dim country1 As New Country("USA", "350 million", s1, c1)

        Dim s2 = New String() {"Durango", "Puebla", "Guerrero", "Quintana Roo"}
        Dim c2 As New City("Cancun", "700,000")
        Dim country2 As New Country("Mexico", "127 million", s2, c2)

        Dim countries = New Country() {country1, country2}

        Dim fs As FileStream = File.Create("log.txt")

        For Each country As Country In countries
            Dim n As Byte() = New UTF8Encoding(True).GetBytes("Name: " + country.Name + Environment.NewLine)
            fs.Write(n, 0, n.Length)
            Dim p As Byte() = New UTF8Encoding(True).GetBytes("Population: " + country.Population + Environment.NewLine)
            fs.Write(p, 0, p.Length)
            Dim b As Byte() = New UTF8Encoding(True).GetBytes("Best States: " + String.Join(", ", country.States) + Environment.NewLine)
            fs.Write(b, 0, b.Length)
            Dim t As Byte() = New UTF8Encoding(True).GetBytes("Top State Count: " + country.States.Length.ToString() + Environment.NewLine)
            fs.Write(t, 0, t.Length)
            Dim bc As Byte() = New UTF8Encoding(True).GetBytes("Best City: " + country.BestCity.Name + Environment.NewLine)
            fs.Write(bc, 0, bc.Length)
            Dim bcp As Byte() = New UTF8Encoding(True).GetBytes(country.BestCity.Name + " Population: " + country.BestCity.Population + Environment.NewLine + Environment.NewLine)
            fs.Write(bcp, 0, bcp.Length)
        Next

        fs.Close()

    End Sub

End Module
