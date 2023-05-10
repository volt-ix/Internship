Public Class clsUsers

    Private ID As Long
    Private Email As String
    Private Username As String
    Private Password As String
    Private FName As String
    Private LName As String
    Private Active As Boolean
    Private RoleID As Integer
    Private RoleName As String

    Public Overrides Function ToString() As String
        Return ID.ToString()
    End Function

    Public Property UserUserID As Integer
        Get
            Return ID
        End Get
        Set(value As Integer)
            ID = value
        End Set
    End Property

    Public Property UserMail As String
        Get
            Return Email
        End Get
        Set(value As String)
            Email = value
        End Set
    End Property

    Public Property UserUsername As String
        Get
            Return Username
        End Get
        Set(value As String)
            Username = value
        End Set
    End Property

    Public Property UserPass As String
        Get
            Return Password
        End Get
        Set(value As String)
            Password = value
        End Set
    End Property

    Public Property UserFName As String
        Get
            Return FName
        End Get
        Set(value As String)
            FName = value
        End Set
    End Property

    Public Property UserLName As String
        Get
            Return LName
        End Get
        Set(value As String)
            LName = value
        End Set
    End Property

    Public Property UserActive As String
        Get
            Return Active
        End Get
        Set(value As String)
            Active = value
        End Set
    End Property

    Public Property UserRoleID As String
        Get
            Return RoleID
        End Get
        Set(value As String)
            RoleID = value
        End Set
    End Property

    Public Property UserRoleName As String
        Get
            Return RoleName
        End Get
        Set(value As String)
            RoleName = value
        End Set
    End Property

    Public Sub New(IDOfUser As Long, EmailOfUser As String, UsernameOfUser As String, PasswordOfUser As String, FNameOfUser As String,
                   LNameOfUser As String, StatusOfUser As Boolean, RoleIDOfUser As Integer, RoleNameOfUser As String)
        Me.ID = IDOfUser
        Me.Email = EmailOfUser
        Me.Username = UsernameOfUser
        Me.Password = PasswordOfUser
        Me.FName = FNameOfUser
        Me.LName = LNameOfUser
        Me.Active = StatusOfUser
        Me.RoleID = RoleIDOfUser
        Me.RoleName = RoleNameOfUser
    End Sub

End Class
