Module Module1

    Sub Main()
        ''JAGGED ARRAY OR ARRAY OF ARRAY

        'Dim a()() As Integer = New Integer(4)() {}
        'a(0) = New Integer() {0, 1}
        'a(1) = New Integer() {2, 3, 33, 333}
        'a(2) = New Integer() {4}
        'a(3) = New Integer() {6, 7, 77}
        'a(4) = New Integer() {8, 9}

        'Dim i, j As Integer
        'For i = 0 To a.Length - 1
        '    For j = 0 To a(i).Length - 1
        '        Console.WriteLine("a(({0})({1}))={2}", i, j, a(i)(j))

        '    Next

        'Next
        'Console.ReadKey()


        'Dim int As Integer = InputBox("Enter any number : ", "Pooja", "10", 100, 0)
        'For i As Integer = 1 To int
        '    Console.WriteLine("{0}", i)
        'Next
        'Console.ReadKey()



        ''WAP TO GET PC NAME , PROCESSORS , DRIVES , PATHS , etc

        'Console.WriteLine(System.Environment.MachineName.ToString())
        'Console.ReadKey()

        'Dim compname As String
        'compname = System.Net.Dns.GetHostName
        'Console.WriteLine(compname.ToString())
        'Console.ReadKey()

        'Console.WriteLine(System.Environment.ProcessorCount)
        'Console.ReadKey()

        'Console.WriteLine(System.Environment.Is64BitOperatingSystem)
        'Console.ReadKey()

        'Console.WriteLine(System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop))
        'Console.WriteLine(System.Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles))
        'Console.WriteLine(System.Environment.GetFolderPath(Environment.SpecialFolder.Windows))
        'Console.ReadKey()

        'Dim mydrive() As String
        'mydrive = System.Environment.GetLogicalDrives()
        'Dim i As Integer
        'For i = 0 To mydrive.Length - 1
        '    Console.WriteLine("{0}", mydrive(i))
        'Next
        'Console.ReadKey()

        'Console.WriteLine(System.Environment.OSVersion)
        'Console.ReadKey()

        'Console.WriteLine(System.Environment.SystemDirectory)
        'Console.ReadKey()

        'Console.WriteLine(System.Environment.UserName)
        'Console.WriteLine(System.Environment.CommandLine)
        'Console.WriteLine(System.Environment.TickCount / 1000 / 60)
        'Console.ReadKey()


        'Dim syspro() As Process = Process.GetProcesses
        'Dim Pro As Process
        'For Each Pro In syspro
        '    Console.WriteLine("Process Name:" & Pro.ProcessName & "Process Id:" & Pro.Id & _
        '                      "Responding:" & Pro.Responding)

        'Next
        'Console.ReadKey()


        Dim myNotepads() As Process = Process.GetProcessesByName("notepad")
        Dim myNotepad As Process
        For Each myNotepad In myNotepads
            Console.WriteLine("process name:" & myNotepad.ProcessName & _
                              "Window Title:" & myNotepad.MainWindowTitle & _
                              "Total Processor Time:" & myNotepad.TotalProcessorTime.ToString)

            myNotepad.CloseMainWindow()  ''Ask to save changes

            'myNotepad.Kill()            '' Will not ask

            myNotepad.WaitForExit()
            If Not myNotepad.HasExited Then
                Console.WriteLine("Running")
            Else
                Console.WriteLine("Not Running")
            End If
        Next
        Console.ReadKey()





























    End Sub

End Module
