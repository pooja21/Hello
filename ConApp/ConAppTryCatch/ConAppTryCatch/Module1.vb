Module Module1

    Sub Main()
        ' myFirstProc()
        'Dim n1, n2 As Integer
        'Console.WriteLine("Enter First Number:")
        'n1 = Convert.ToInt32(Console.ReadLine())
        'Console.WriteLine("Enter Second Number:")
        'n2 = Convert.ToInt32(Console.ReadLine())
        'division(n1, n2)
        'Console.ReadKey()

        Try
            Dim myThrow As New ApplicationException("A user defined exception is being thrown from here...")
            Throw myThrow
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Console.ReadKey()

       

    End Sub

    Sub myFirstProc()
        'Console.Write("Welcome..!!")
        'Console.ReadKey()

        MsgBox("Thankyou..", MsgBoxStyle.MsgBoxHelp, "Compact")

    End Sub

    Sub division(ByVal num1 As Integer, ByVal num2 As Integer)
        Dim result As Integer
        Try
            result = num1 \ num2                    '' \ - INTEGER DIVIDE
        Catch ex As DivideByZeroException
            Console.WriteLine("Divide by  zero error: {0}", ex.Message)
        Finally
            Console.WriteLine("Result: {0}", result)

        End Try
    End Sub

End Module
