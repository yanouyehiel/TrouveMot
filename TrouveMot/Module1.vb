Module Module1

    Sub Main()
        Dim TabMot(6) As String
        Dim mot As String = "Bonjour"
        Dim lettre As String = ""
        Dim res As String = ""
        Dim k As Integer = 1
        Dim m As Integer = 1

        Console.WriteLine("Entrer le mot secret composé de 6 lettres")
        For i As Integer = 0 To TabMot.Length - 1
            lettre = Console.ReadLine()
            TabMot(i) = lettre
        Next

        Console.WriteLine("Veuillez deviner le mot secret, entrer une lettre")
        lettre = Console.ReadLine()

        For j As Integer = 0 To TabMot.Length - 1
            If (TabMot(j) = lettre) Then
                res = lettre
            Else
                k = k + j
                Do
                    res = "_" & lettre
                Loop Until m <= k
            End If
        Next
        Console.WriteLine(res)

        Console.Read()
    End Sub

End Module
