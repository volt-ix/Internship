Imports MySql.Data.MySqlClient

Module MdlRolesfcts
    Private RolesList As New List(Of clsRoles)

    Public Function getRoles(ByVal showAll As Boolean) As List(Of clsRoles)
        Try
            MdlCommon.conn.Close()
            MdlCommon.connect()
            Dim Rs As MySqlDataReader
            Dim SQL As String

            SQL = "SELECT R.RolesID as RolesID, ifNull(R.RoleName,'') as RoleName, ifNull(R.Active,'') as RoleActive
                    FROM roles R"

            If showAll Then
                SQL &= " WHERE (R.Active=1 OR R.Active=0)"
            Else
                SQL &= " WHERE (R.Active=1)"
            End If

            Dim cmd As MySqlCommand = New MySqlCommand(SQL, conn)

            Rs = cmd.ExecuteReader()

            If Rs IsNot Nothing Then
                RolesList.Clear()
                While Rs.Read
                    RolesList.Add(New clsRoles(Rs("RolesID"), Rs("RoleName"), Rs("RoleActive")))
                End While

                Return RolesList
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
