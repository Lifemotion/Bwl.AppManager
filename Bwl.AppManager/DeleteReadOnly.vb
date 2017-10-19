Imports System.IO
Imports System.Runtime.CompilerServices

Module DeleteReadOnly

    Public Sub ForceDelete(ByVal path As String)
        ForceDelete(New DirectoryInfo(path))
    End Sub

    <Extension()>
    Public Sub Delete(directory As DirectoryInfo, recursive As Boolean, forceReadOnlyDelete As Boolean)
        directory.ForceDelete()
    End Sub

    <Extension()>
    Public Sub ForceDelete(ByVal directory As DirectoryInfo)
        directory.RemoveReadOnlyAttributeFromFiles(True)
        directory.Delete(True)
    End Sub

    <Extension()>
    Public Sub RemoveReadOnlyAttributeFromFiles(ByVal directory As DirectoryInfo, ByVal recursive As Boolean)

        Dim readOnlyFiles = From f In directory.GetFiles()
                            Where (f.Attributes And FileAttributes.ReadOnly) = FileAttributes.ReadOnly

        For Each file In readOnlyFiles
            file.Attributes = FileAttributes.Normal
        Next

        If recursive Then

            For Each subDirectory In directory.GetDirectories()
                subDirectory.RemoveReadOnlyAttributeFromFiles(True)
            Next

        End If

    End Sub

End Module
