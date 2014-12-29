Module Module1

    Sub Main()
        'dim ==> declare in module
        'dim ==> declare in memory
        'dim ==> dimension

        'Dim i As Integer
        'Dim j As Integer
        'Dim k As Integer
        'Console.Write("enter first number : ")
        'i = Integer.Parse(Console.ReadLine())
        'Console.Write("enter second number : ")
        'j = Integer.Parse(Console.ReadLine())
        'Console.WriteLine("The addition of {0} and {1} is {2}", i, j, i + j)
        'Console.ReadKey()

        'Try
        '    Dim Animal(3) As String
        '    Animal(0) = "Donkey"
        '    Animal(1) = "Monkey"
        '    Animal(2) = "Hippo"
        '    Animal(3) = "Dog"
        '    Dim i As Integer
        '    For i = 0 To 4
        '        Console.WriteLine("Animal({0})={1}", i, Animal(i))
        '    Next
        '    Console.ReadKey()

        'Catch ex As Exception
        '    Console.WriteLine("array index out of bound")
        '    Console.WriteLine(ex.ToString)

        '    Console.ReadKey()

        'End Try


        'Dim n(10) As Integer
        'Dim i, j As Integer
        'For i = 0 To 10
        '    n(i) = i + 100
        'Next
        'For j = 0 To 10
        '    Console.WriteLine("n({0}) = {1}", j, n(j))
        'Next
        'Console.ReadKey()


        'Dim names() As String = {"pumba", "kuku", "birju", "viku"}
        'For i As Integer = 0 To names.Length - 1
        '    Console.WriteLine("names({0})={1}", i, names(i))
        'Next
        'Console.ReadKey()


        'Dim mixarr() As Object = {"pumba", "kuku", "birju", "viku", 123, 1, "a"c}
        'For i As Integer = 0 To mixarr.Length - 1
        '    Console.WriteLine("names({0})={1}", i, mixarr(i))
        'Next
        'Console.ReadKey()


        'Dim myarr() As Integer

        'ReDim myarr(2)
        'myarr(0) = 10
        'myarr(1) = 20
        'myarr(2) = 30
        'Console.WriteLine("myarr(2) Length={0}", myarr.Length)
        'ReDim Preserve myarr(5)
        'Console.WriteLine("myarr(2) Length={0}", myarr.Length)
        'myarr(3) = 40
        'myarr(4) = 50
        'myarr(5) = 60
        'Console.WriteLine("myarr(5) Length={0}", myarr.Length)
        'ReDim Preserve myarr(3)
        'Console.WriteLine("myarr(3) Length={0}", myarr.Length)
        'For i As Integer = 0 To myarr.Length - 1
        '    Console.WriteLine("myarr({0})={1}", i, myarr(i))
        'Next
        'Console.ReadKey()


        'Dim a(,) As Integer = {{0, 1}, {2, 3}, {4, 5}, {4, 6}, {8, 9}}
        'Dim i, j As Integer
        'For i = 0 To a.GetLength(0) - 1
        '    For j = 0 To a.GetLength(1) - 1
        '        Console.WriteLine("a({0},{1})={2}", i, j, a(i, j))
        '    Next
        'Next
        'Console.WriteLine("a is a matrix of: {0} x {1}", a.GetLength(0), a.GetLength(1))
        'Console.ReadKey()


        'JAGGED ARRAY OR ARRAY OF ARRAY
        'Dim a()() As Integer = New Integer(4)() {}
        'a(0) = New Integer() {0, 1}
        'a(1) = New Integer() {2, 3}
        'a(2) = New Integer() {4, 5}
        'a(3) = New Integer() {6, 7}
        'a(4) = New Integer() {8, 9}

        'Dim i, j As Integer
        'For i = 0 To 4
        '    For j = 0 To 1
        '        Console.WriteLine("a(({0})({1}))={2}", i, j, a(i)(j))

        '    Next

        'Next
        'Console.ReadKey()


        'Dim mypro As New Process
        'mypro.StartInfo.FileName = "notepad"
        'mypro.Start()
        'mypro.StartInfo.FileName = "mspaint"
        'mypro.Start()
        'mypro.StartInfo.FileName = "C:\Program Files (x86)\Google\Chrome\Application\chrome.exe"
        'mypro.Start()
        'mypro.StartInfo.FileName = "C:\Program Files"
        'mypro.Start()
        'mypro.StartInfo.FileName = "F:\"
        'mypro.Start()





    End Sub


End Module
