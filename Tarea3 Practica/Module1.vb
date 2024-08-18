Module Module1

    Sub Main()
        Dim random As New Random()
        Dim numeroSecreto As Integer = random.Next(1, 1001)

        Dim adivinado As Boolean = False
        Dim intento As Integer

        Console.WriteLine("Adivina el número secreto entre 1 y 1000")

        While Not adivinado
            Console.Write("Ingrese el número que cree que se generó: ")
            intento = Convert.ToInt32(Console.ReadLine())

            If intento > numeroSecreto Then
                Console.WriteLine("Ingrese el número que cree que se generó, pero más bajo.")
            ElseIf intento < numeroSecreto Then
                Console.WriteLine("Ingrese el número que cree que se generó, pero mayor.")
            Else
                Console.WriteLine("¡Felicidades, el número secreto era " & numeroSecreto & "!")
                adivinado = True
            End If
        End While

        Console.WriteLine("Presione cualquier tecla para salir...")
        Console.ReadKey()
    End Sub

End Module
