Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class firsttime

    Public connStr As String

    Public Sub New(ByVal connection As String)
        InitializeComponent()
        connStr = connection
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
        login.Close()
        Dim loginform As New login
        login.Show()
        login.firsttimeflag = 1
        Me.Close()
    End Sub

    Private Sub writetofile()
        
    End Sub
End Class