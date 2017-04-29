Imports System.IO
Imports System.Collections




Public Class Form2
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim uname As String = Environment.UserName
        If My.Computer.FileSystem.FileExists("C:\Users\" + uname + "\documents\easylogtool\tooldatei.txt") Then
            Dim zeile = File.ReadAllLines("C:\Users\" + uname + "\documents\easylogtool\tooldatei.txt")
            verzeichnis1.Text = zeile(0)
            verzeichnis2.Text = zeile(1)
            dienst.Text = zeile(2)
            dbdatei.Text = zeile(3)
            zeitstart.Text = zeile(4)
            zeitende.Text = zeile(5)
        Else
            verzeichnis1.Text = "C:\sicherung"
            verzeichnis2.Text = "C:\Easylog6.9\server"
            dienst.Text = "Adaptive Server Anywhere - ELServer69"
            dbdatei.Text = "easylog69.db"
            zeitstart.Text = "21:00"
            zeitende.Text = "21:05"
        End If


    End Sub



    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim uname = Environment.UserName
        If Not My.Computer.FileSystem.DirectoryExists("C:\Users\" + uname + "\documents\easylogtool") Then
            My.Computer.FileSystem.CreateDirectory("C:\Users\" + uname + "\documents\easylogtool")
        Else
            My.Computer.FileSystem.WriteAllText("C:\Users\" + uname + "\documents\easylogtool\tooldatei.txt", verzeichnis1.Text + vbNewLine + verzeichnis2.Text + vbNewLine + dienst.Text + vbNewLine + dbdatei.Text + vbNewLine + zeitstart.Text + vbNewLine + zeitende.Text, False)
            SichereDB.Show()
            Me.Close()

        End If

    End Sub

End Class