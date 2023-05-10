Public Class clsRoles
    Private RolesID As Integer
    Private RoleName As String
    Private RoleActive As Boolean

    Public Overrides Function ToString() As String
        Return RolesID.ToString()
    End Function

    Public Property RoleRolesID As Integer
        Get
            Return RolesID
        End Get
        Set(value As Integer)
            RolesID = value
        End Set
    End Property

    Public Property RoleRolesName As String
        Get
            Return RoleName
        End Get
        Set(value As String)
            RoleName = value
        End Set
    End Property

    Public Property RoleRolesActive As Boolean
        Get
            Return RoleActive
        End Get
        Set(value As Boolean)
            RoleActive = value
        End Set
    End Property

    Public Sub New(IDOfRole As Integer, NameOfRole As String, StatusOfRole As Boolean)
        Me.RolesID = IDOfRole
        Me.RoleName = NameOfRole
        Me.RoleActive = StatusOfRole
    End Sub

End Class
