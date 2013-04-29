Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Data.SqlClient
Imports System
Imports System.IO
Imports System.Text

Public Class firsttime

    Public connStr As String
    Dim username As String
    Dim password As String

    Public Sub New(ByVal connection As String, ByVal un As String, ByVal pw As String)
        InitializeComponent()
        connStr = connection
        username = un
        password = pw
        Label2.Text = un + vbCrLf + password
    End Sub

    Private Sub firsttime_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        timeLabel.Text = String.Format("{0:hh:mm:ss tt}", Date.Now)
        dateLabel.Text = Now.Date
    End Sub

    Private Sub timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timer.Tick
        'every tick updates time
        timeLabel.Text = String.Format("{0:hh:mm:ss tt}", Date.Now)
    End Sub

    Private Sub finishedButton_Click(sender As Object, e As EventArgs) Handles finishedButton.Click
        Dim ip As String = manualIPTextBox.Text
        Dim temparray() As String = Split(ip, ".")
        Dim array(0 To 3) As String
        Dim i As Integer = 0
        For i = 0 To (temparray.Length - 1)
            array(i) = temparray(i)
        Next

        If (array(0) = "localhost") Then

        ElseIf (array(0).Length > 3 Or array(1).Length > 3 Or array(2).Length > 3 Or array(3).Length > 3) Then
            errorIPLabel.Text = "invalid IP entered"
        End If


        'login.Close()
        'Dim loginform As New login
        If writetofile() = False Then
            errorLabel.Text = "error with file events"
            Exit Sub
        End If
        login.Update()
        Me.Close()
    End Sub

    Private Function writetofile()
        Dim path As String = Application.StartupPath + "\r100ft.sr"
        Dim flag As Boolean = False

        Try
            Dim fs As FileStream = File.Create(path)
            Dim newline As Byte() = New UTF8Encoding(True).GetBytes("xkLpuzVEvdEWSbfcuX3J")
            fs.Write(newline, 0, newline.Length)
            fs.Close()
            flag = True
            login.FTflag1 = False

        Catch ex As Exception
            flag = False
        End Try

        Return flag
    End Function
End Class