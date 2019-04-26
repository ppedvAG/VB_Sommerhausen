Imports System.Data.SQLite
Imports System.IO

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim conString = "Data Source=..\..\Northwind.sqlite"

        Using con As New SQLite.SQLiteConnection(conString)

            Try
                con.Open()

            Catch ex As Exception
                MessageBox.Show($"Fehler: {ex.Message}")
            End Try

            Using cmd = New SQLiteCommand()

                cmd.Connection = con
                cmd.CommandText = "SELECT * FROM Employees"
                Try

                    Using reader = cmd.ExecuteReader()

                        Dim emps = New List(Of Employee)

                        While reader.Read()

                            Dim emp = New Employee
                            emp.FirstName = reader("FirstName")
                            emp.LastName = reader("LastName")
                            emp.BirthDate = reader.GetDateTime(reader.GetOrdinal("BirthDate"))
                            emps.Add(emp)
                        End While
                        Throw New FreitagNachmittagException
                        DataGridView1.DataSource = emps
                    End Using
                    'hier kommt nicht mehr hin!
                Catch ex As FileNotFoundException
                    MessageBox.Show($"Datei nicht :{ex.Message}")

                Catch otto As SQLiteException
                    MessageBox.Show($"SQL Lite Fehler:{otto.Message}")

                Catch ex As Exception
                    MessageBox.Show($"Fehler:{ex.Message}")
                End Try

                'hier gehts weiter
            End Using
        End Using


    End Sub
End Class


Class FreitagNachmittagException
    Inherits Exception

    Property Datum As Date
End Class
