Imports System.Data.SQLite

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim conString = "Data Source=..\..\Northwind.sqlite"

        Dim con As New SQLite.SQLiteConnection(conString)
        con.Open()

        Dim cmd = New SQLiteCommand()
        cmd.Connection = con
        cmd.CommandText = "SELECT * FROM Employees"

        Dim reader = cmd.ExecuteReader()
        Dim emps = New List(Of Employee)

        While reader.Read()

            Dim emp = New Employee
            emp.FirstName = reader("FirstName")
            emp.LastName = reader("LastName")
            emp.BirthDate = reader.GetDateTime(reader.GetOrdinal("BirthDate"))
            emps.Add(emp)
        End While

        DataGridView1.DataSource = emps
    End Sub
End Class
