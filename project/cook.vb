Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Data.SqlClient

Public Class cook

    Public connStr As String
    Dim displayName As String
    Dim unID As String

    Public Sub New(ByVal connection As String, ByVal id As String, ByVal name As String)
        InitializeComponent()
        connStr = connection
        displayName = Name
        unID = id
    End Sub

    Private Sub cook_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        retrieveNote()

        welcomeLabel.Text = "Welcome, " + displayName + "!"
        timeLabel.Text = String.Format("{0:hh:mm:ss tt}", Date.Now)
        dateLabel.Text = Now.Date
    End Sub

    Private Sub timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timer.Tick
        'every tick updates time
        timeLabel.Text = String.Format("{0:hh:mm:ss tt}", Date.Now)
    End Sub

    Public Sub retrieveNote()
        Dim query As String = "SELECT note FROM restaurant.employeeinfo WHERE un='" + unID + "';"
        Using connection As New MySqlConnection(connStr)
            Dim command As New MySqlCommand(query, connection)
            Try
                connection.Open()
                noteLabel.Text = Convert.ToString(command.ExecuteScalar())
                connection.Close()
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Using
    End Sub

    Private Sub logoutButton_Click(sender As System.Object, e As System.EventArgs) Handles logoutButton.Click
        Me.Close()
        login.Show()
    End Sub

    Private Sub clockOutButton_Click(sender As Object, e As EventArgs) Handles clockOutButton.Click
        Dim query As String = "UPDATE restaurant.employeeinfo SET `isLoggedIn`='n' WHERE `un`='" + unID + "';"
        Dim connection As New MySqlConnection(connStr)
        Dim command As New MySqlCommand(query, connection)
        Try
            connection.Open()
            command.ExecuteNonQuery()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally
            connection.Close()
        End Try
        Me.Close()
        login.Show()
    End Sub

End Class