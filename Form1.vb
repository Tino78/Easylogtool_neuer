Imports System
Imports System.IO
Imports System.ServiceProcess
Imports System.Configuration
Imports System.Diagnostics
Imports System.Threading
Imports Microsoft.Win32

Public Class SichereDB
    Dim uname As String = Environment.UserName
    Dim zeile = File.ReadAllLines("C:\Users\" + uname + "\documents\easylogtool\tooldatei.txt")
    Dim sicherverz = zeile(0)
    Dim easyverz = zeile(1)
    Dim dienst = zeile(2)
    Dim dbdatei = zeile(3)
    Dim zeitstart = zeile(4)
    Dim zeitende = zeile(5)
    Dim Datum As String = Date.Now.ToShortDateString - "0.00.0000"
    Sub Fortschritt1()
        Dim I As Integer
        For I = 0 To 100
            ProgressBar1.Value = I / 100
        Next
    End Sub

    Sub Fortschritt2()
        Dim Max As Integer = 100
        ProgressBar1.Maximum = Max
        ProgressBar1.Step = 10
        'Dim I As Integer
        'For I = 0 To 100
        ProgressBar1.PerformStep()
        'Next
    End Sub
    Sub Fortschritt3()
        Dim Max As Integer = 100
        ProgressBar1.Maximum = Max
        ProgressBar1.Step = 25
        'Dim I As Integer
        'For I = 0 To 100
        ProgressBar1.PerformStep()
        'Next
    End Sub
    Sub Fortschritt4()
        Dim Max As Integer = 100
        ProgressBar1.Maximum = Max
        ProgressBar1.Step = 50
        'Dim I As Integer
        'For I = 0 To 100
        ProgressBar1.PerformStep()
        ' Next
    End Sub
    Sub Fortschritt5()
        Dim Max As Integer = 100
        ProgressBar1.Maximum = Max
        ProgressBar1.Step = 75
        'Dim I As Integer
        'For I = 0 To 100
        ProgressBar1.PerformStep()
        'Next
    End Sub
    Sub Fortschritt6()
        Dim Max As Integer = 100
        ProgressBar1.Maximum = Max
        ProgressBar1.Step = 100
        'Dim I As Integer
        'For I = 0 To 100
        ProgressBar1.PerformStep()
        'Next
    End Sub
    Sub Erstelle()
        My.Computer.FileSystem.CreateDirectory(sicherverz + String.Format("{0:d}", "\EL_" & Datum))
    End Sub
    Dim theController As System.ServiceProcess.ServiceController = New System.ServiceProcess.ServiceController(dienst)
    Sub Kopieren()
        If theController.CanStop = True Then
            theController.Stop()
        Else
            If theController.CanStop.ToString() = False Then
                Dim Datei As New Object
                Datei = CreateObject("Scripting.FileSystemObject")
                Fortschritt2()
                Datei.CopyFile(easyverz + "\" + dbdatei, sicherverz + "\EL_" + Datum & "\" + dbdatei)
                Fortschritt3()
                Datei.CopyFile(easyverz + "\LD_D01.DBR", sicherverz + "\EL_" + Datum & "\LD_D01.DBR")
                Fortschritt4()
                Datei.CopyFile(easyverz + "\LD_I01.DBR", sicherverz + "\EL_" + Datum & "\LD_I01.DBR")
                Fortschritt5()
                Datei.CopyFile(easyverz + "\leitdaten.db", sicherverz + "\EL_" + Datum & "\leitdaten.db")
                theController.Start()
                Fortschritt6()
            Else
                MsgBox("kopieren ist nicht möglich!!")
            End If
        End If
    End Sub
    Sub loeschen()

        Dim Datum As String = Date.Now.ToShortDateString - "3.00.0000"
        If My.Computer.FileSystem.DirectoryExists(sicherverz + "\EL_" & Datum) Then
            My.Computer.FileSystem.DeleteDirectory(sicherverz + "\EL_" & Datum, FileIO.DeleteDirectoryOption.DeleteAllContents)
        End If


    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click


        If My.Computer.FileSystem.DirectoryExists(sicherverz + "\EL_" + Datum) = True Then
            If My.Computer.FileSystem.FileExists(sicherverz + "\EL_" + Datum & "\" + dbdatei) = True Then
                MsgBox("Dateien wurden schon kopiert.")
                theController.Start()
                End
            Else
                Kopieren()
            End If

        Else
            Erstelle()
            Kopieren()
            loeschen()
        End If


    End Sub


    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Dim time = zeitstart
        Dim timeout = zeitende
        If TimeOfDay <= timeout Then
            If TimeOfDay >= time Then
                Erstelle()
                Kopieren()
                loeschen()

            End If
        End If

    End Sub
    Public Property ServiceName As String

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click 'als Dienst installieren
        'MsgBox(Directory.GetCurrentDirectory())
        'Process.Start("c:\windows\system32\sc.exe create EasylogTool start=auto binpath=" + Directory.GetCurrentDirectory)
        MsgBox("Diese Funktion steht leider noch nicht zur Verfügung.")

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        info.Show()
    End Sub

    Private Sub einstell_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles einstell.LinkClicked 'Einstellungen fürs Tool
        Form2.Show()
    End Sub
End Class
