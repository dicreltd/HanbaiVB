Imports MySql.Data.MySqlClient

Public Class ShouhinDAO
    Private con As HanbaiConnection

    Public Sub New(con As HanbaiConnection)
        Me.con = con
    End Sub

    Public Sub Fill(table As DataTable)
        table.Clear()
        Dim adp = New MySqlDataAdapter("SELECT * FROM shouhin", con.Connection)
        adp.Fill(table)
    End Sub

    Public Function FindById(sid As Integer) As Shouhin
        Dim Sql = "SELECT * FROM shouhin WHERE mid=@sid"
        Dim cmd = New MySqlCommand(Sql, con.Connection)
        cmd.Parameters.AddWithValue("@sid", sid)

        Dim reader = cmd.ExecuteReader()

        Dim s As Shouhin = Nothing
        If reader.Read() Then

            Dim sname = reader.GetString("sname")
            Dim tanka = reader.GetInt32("tanka")

            s = New Shouhin(sid, sname, tanka)
        End If
        reader.Close()

        Return s

    End Function

    Public Sub Insert(s As Shouhin)
        Dim sql = "INSERT INTO shouhin(sname,tanka) VALUES(@sname,@tanka)"
        Dim cmd = New MySqlCommand(sql, con.Connection)

        cmd.Parameters.AddWithValue("@sname", s.Sname)
        cmd.Parameters.AddWithValue("@tanka", s.Tanka)

        cmd.ExecuteNonQuery()

    End Sub
    Public Sub Update(s As Shouhin)
        Dim sql = "UPDATE shouhin SET sname=@sname,tanka=@tanka WHERE sid=@sid"
        Dim cmd = New MySqlCommand(sql, con.Connection)

        cmd.Parameters.AddWithValue("@sname", s.Sname)
        cmd.Parameters.AddWithValue("@tanka", s.Tanka)
        cmd.Parameters.AddWithValue("@sid", s.Sid)

        cmd.ExecuteNonQuery()
    End Sub

    Public Sub Delete(sid As Integer)
        Dim sql = "DELETE FROM shouhin WHERE sid=@sid"
        Dim cmd = New MySqlCommand(sql, con.Connection)

        cmd.Parameters.AddWithValue("@sid", sid)

        cmd.ExecuteNonQuery()
    End Sub
End Class
