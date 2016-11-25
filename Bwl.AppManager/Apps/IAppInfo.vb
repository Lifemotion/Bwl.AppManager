Public Interface IAppInfo
    ReadOnly Property BasePath As String
    ReadOnly Property ExecutablePath As String
    ReadOnly Property Homepage As String
    ReadOnly Property Downloaded As Boolean
    ReadOnly Property Prepared As Boolean
    ReadOnly Property Name As String
    ReadOnly Property Version As String
    ReadOnly Property UpdateExists As Boolean

    Sub UpdateLocal()
    Sub CheckUpdates()
    Sub InstallOrUpdate()
    Sub Run()
End Interface
