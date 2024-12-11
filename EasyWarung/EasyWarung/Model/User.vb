Public Class User
    Private _No As Integer
    Private _UserID As String
    Private _UserNames As String
    Private _UserAddress As String
    Private _UserEmail As String
    Private _UserPhone As String
    Private _UserRoleStr As String
    Private _Username As String
    Private _Password As String
    Private _UserImage As Byte()
    Private _UserStatusStr As String
    Private _UserRoleInt As Integer
    Private _UserStatusInt As Integer

    Sub New()

    End Sub

    Sub New(UserID As String, UserNames As String, UserAddress As String, UserEmail As String, UserPhone As String, UserRoleStr As String, Username As String, Password As String, UserImage As Byte(), UserStatusStr As String, UserRoleInt As Integer, UserStatusInt As Integer)
        Me.UserID = UserID
        Me.UserNames = UserNames
        Me.UserAddress = UserAddress
        Me.UserEmail = UserEmail
        Me.UserPhone = UserPhone
        Me.UserRoleStr = UserRoleStr
        Me.Username = Username
        Me.Password = Password
        Me.UserImage = UserImage
        Me.UserStatusStr = UserStatusStr
        Me.UserRoleInt = UserRoleInt
        Me.UserStatusInt = UserStatusInt
    End Sub

    Public Property UserStatusInt() As Integer
        Get
            Return _UserStatusInt
        End Get
        Set(ByVal value As Integer)
            _UserStatusInt = value
        End Set
    End Property

    Public Property UserRoleInt() As Integer
        Get
            Return _UserRoleInt
        End Get
        Set(ByVal value As Integer)
            _UserRoleInt = value
        End Set
    End Property

    Public Property UserStatusStr() As String
        Get
            Return _UserStatusStr
        End Get
        Set(ByVal value As String)
            _UserStatusStr = value
        End Set
    End Property

    Public Property UserImage() As Byte()
        Get
            Return _UserImage
        End Get
        Set(ByVal value As Byte())
            _UserImage = value
        End Set
    End Property

    Public Property Password() As String
        Get
            Return _Password
        End Get
        Set(ByVal value As String)
            _Password = value
        End Set
    End Property

    Public Property Username() As String
        Get
            Return _Username
        End Get
        Set(ByVal value As String)
            _Username = value
        End Set
    End Property

    Public Property UserRoleStr() As String
        Get
            Return _UserRoleStr
        End Get
        Set(ByVal value As String)
            _UserRoleStr = value
        End Set
    End Property

    Public Property UserPhone() As String
        Get
            Return _UserPhone
        End Get
        Set(ByVal value As String)
            _UserPhone = value
        End Set
    End Property

    Public Property UserEmail() As String
        Get
            Return _UserEmail
        End Get
        Set(ByVal value As String)
            _UserEmail = value
        End Set
    End Property

    Public Property UserAddress() As String
        Get
            Return _UserAddress
        End Get
        Set(ByVal value As String)
            _UserAddress = value
        End Set
    End Property

    Public Property UserNames() As String
        Get
            Return _UserNames
        End Get
        Set(ByVal value As String)
            _UserNames = value
        End Set
    End Property

    Public Property UserID() As String
        Get
            Return _UserID
        End Get
        Set(ByVal value As String)
            _UserID = value
        End Set
    End Property

    Public ReadOnly Property No() As Integer
        Get
            Return _No
        End Get
    End Property
End Class