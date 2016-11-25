Public Class BuildHelper
    Dim toolPaths As String() = {
        "C:\Program Files (x86)\MSBuild\14.0\Bin\MSBuild.EXE",
        "C:\Program Files\MSBuild\14.0\Bin\MSBuild.EXE",
        "C:\Program Files (x86)\MSBuild\12.0\Bin\MSBuild.EXE",
        "C:\Program Files\MSBuild\12.0\Bin\MSBuild.EXE",
        "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\MSBuild.EXE",
        "C:\Windows\Microsoft.NET\Framework\v4.0.30319\MSBuild.EXE"}
    Public Property ProjectFile As String
    Public Property ProjectDirectory As String
    Public Property ProjectName As String
    Public Property Configuration As String
    Public Property Success As Boolean

    Public Overrides Function ToString() As String
        Return ProjectName + " (" + Configuration + ")"
    End Function

    Public Sub New(path As String)
        Me.New(path, "Release")
    End Sub

    Public Sub New(path As String, conf As String)
        If IO.File.Exists(path) = False Then Throw New ArgumentOutOfRangeException
        ProjectFile = path
        ProjectName = IO.Path.GetFileNameWithoutExtension(path)
        ProjectDirectory = IO.Path.GetDirectoryName(path)
        Configuration = conf
        Success = False
    End Sub

    Private Function FindTools() As String
        For Each toolPath In toolPaths
            If IO.File.Exists(toolPath) Then
                Return toolPath
            End If
        Next
        Console.BackgroundColor = ConsoleColor.Red
        Console.WriteLine("Build tools not found!")
        Throw New Exception("Build tools not found!")
    End Function

    Public Function Build(additionalOptions As String) As Boolean
        Dim prc As New Process()
        prc.StartInfo.WorkingDirectory = ProjectDirectory
        prc.StartInfo.FileName = FindTools()
        prc.StartInfo.UseShellExecute = False
        prc.StartInfo.RedirectStandardOutput = True
        prc.StartInfo.Arguments = """" + ProjectFile + """ /p:Configuration=" + Configuration + additionalOptions
        prc.Start()
        Do While prc.StandardOutput.EndOfStream = False
            Dim p = prc.StandardOutput.ReadLine
            Console.WriteLine(p)
        Loop
        Success = (prc.ExitCode = 0)
        Return Success
    End Function
End Class
