Public Class Country
    Private title, pop As String
    Private best_states As String()
    Private city As City

    Public Sub New(ByVal Name As String, Population As String, States As String(), BestCity As City)
        Me.Name = Name
        Me.Population = Population
        Me.States = States
        Me.BestCity = BestCity
    End Sub

    Public Property Name() As String
        Get
            Return title
        End Get
        Set(ByVal Value As String)
            title = Value
        End Set
    End Property

    Public Property Population() As String
        Get
            Return pop
        End Get
        Set(ByVal Value As String)
            pop = Value
        End Set
    End Property

    Public Property States() As String()
        Get
            Return best_states
        End Get
        Set(ByVal Value As String())
            best_states = Value
        End Set
    End Property

    Public Property BestCity() As City
        Get
            Return city
        End Get
        Set(ByVal Value As City)
            city = Value
        End Set
    End Property
End Class


Public Class City
    Private title, pop As String

    Public Sub New(ByVal Name As String, Population As String)
        Me.Name = Name
        Me.Population = Population
    End Sub

    Public Property Name() As String
        Get
            Return title
        End Get
        Set(ByVal Value As String)
            title = Value
        End Set
    End Property

    Public Property Population() As String
        Get
            Return pop
        End Get
        Set(ByVal Value As String)
            pop = Value
        End Set
    End Property
End Class
