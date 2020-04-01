Imports MySql.Data.MySqlClient

Public Class HanbaiConnection
    Public Property Connection As MySqlConnection

    Public Sub New()
        Connection = New MySqlConnection("userid=root;password=;database=hanbai;Host=localhost")
    End Sub

    Public Sub Open()
        Connection.Open()
    End Sub

    Public Sub Close()
        Connection.Close()
    End Sub
End Class
