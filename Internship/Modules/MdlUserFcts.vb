Imports MySql.Data.MySqlClient

Module MdlUserFcts

    Private UsersList As New List(Of clsUsers)

    Public Function GetUsers(ByVal ShowAll As Boolean) As List(Of clsUsers)
        Try
            MdlCommon.conn.Close()
            MdlCommon.connect()
            Dim Rs As MySqlDataReader
            Dim SQL As String

            SQL = "SELECT U.ID as UserID, IfNull(U.Email, '') as UserMail, ifNull(U.Username,'') as UserUsername, ifNull(U.Password,'') as UserPass, 
                    ifNull(U.FName,'') as UserFName, ifNull(U.LName,'') as UserLName, ifNull(U.Active,'') as UserActive, 
                    ifNull(U.RolesID,'') as UserRoleID, ifNull(R.RoleName,'') as UserRole

                    FROM users U
                    LEFT JOIN Roles R ON R.RolesID=U.RolesID "

            If ShowAll Then
                SQL &= " WHERE (U.Active=1 OR U.Active=0)"
            Else
                SQL &= " WHERE (U.Active=1)"
            End If

            Dim cmd As MySqlCommand = New MySqlCommand(SQL, conn)

            Rs = cmd.ExecuteReader()

            If Rs IsNot Nothing Then
                UsersList.Clear()
                While Rs.Read
                    UsersList.Add(New clsUsers(Rs("UserID"), Rs("UserMail"), Rs("UserUserName"), Rs("UserPass"), Rs("UserFName"),
                                               Rs("UserLName"), Rs("UserActive"), Rs("UserRoleID"), Rs("UserRole")))
                End While

                Return UsersList
            Else
                Return Nothing
            End If

            Rs.Close()
            Rs.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

End Module
