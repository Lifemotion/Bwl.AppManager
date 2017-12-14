Public Interface IAppInfo
    Property BasePath As String
    Property ExecutablePath As String
    Property Homepage As String
    Property Downloaded As Boolean
    Property Prepared As Boolean
    Property Name As String
    Property Version As String
    Property UpdateExists As Boolean
    Property CurrentOperation As String
    Property Description As String
    Property AppIcon As Icon
    Event Changed(source As IAppInfo)
    Sub UpdateLocal()
    Sub CheckUpdates()
    Sub InstallOrUpdate()
    Sub Run()
    Sub Delete()
End Interface
