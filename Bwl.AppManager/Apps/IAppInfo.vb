Public Interface IAppInfo
    ReadOnly Property BasePath As String
    ReadOnly Property ExecutablePath As String
    ReadOnly Property Homepage As String
    ReadOnly Property Downloaded As Boolean
    ReadOnly Property Prepared As Boolean
    ReadOnly Property Name As String
    ReadOnly Property Version As String
    ReadOnly Property UpdateExists As Boolean
    ReadOnly Property CurrentOperation As String
    Property Description As String
    Event Changed(source As IAppInfo)
    Sub UpdateLocal()
    Sub CheckUpdates()
    Sub InstallOrUpdate()
    Sub Run()
    Sub Delete()
End Interface
