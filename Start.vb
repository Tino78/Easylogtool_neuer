﻿Public NotInheritable Class Start

    'TODO: Dieses Formular kann einfach als Begrüßungsbildschirm für die Anwendung festgelegt werden, indem Sie zur Registerkarte "Anwendung"
    '  des Projekt-Designers wechseln (Menü "Projekt", Option "Eigenschaften").


    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Richten Sie den Dialogtext zur Laufzeit gemäß den Assemblyinformationen der Anwendung ein.  

        'TODO: Passen Sie die Assemblyinformationen der Anwendung im Bereich "Anwendung" des Dialogfelds für die 
        '  Projekteigenschaften (im Menü "Projekt") an.

        'Anwendungstitel
        If My.Application.Info.Title <> "" Then
            ApplicationTitle.Text = My.Application.Info.Title
        Else
            'Wenn der Anwendungstitel fehlt, Anwendungsnamen ohne Erweiterung verwenden
            ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If

        'Verwenden Sie zum Formatieren der Versionsinformationen den Text, der zur Entwurfszeit in der Versionskontrolle festgelegt wurde, als
        '  Formatierungszeichenfolge. Dies ermöglicht ggf. eine effektive Lokalisierung.
        '  Build- und Revisionsinformationen können durch Verwendung des folgenden Codes und durch Ändern 
        '  des Entwurfszeittexts der Versionskontrolle in "Version {0}.{1:00}.{2}.{3}" oder einen ähnlichen Text eingeschlossen werden. Weitere Informationen erhalten Sie unter
        '  String.Format() in der Hilfe.
        '
        '    Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)

        Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)

        'Copyrightinformationen
        Copyright.Text = My.Application.Info.Copyright
        Dim uname As String = Environment.UserName
        If Not My.Computer.FileSystem.FileExists("C:\Users\" + uname + "\documents\easylogtool\tooldatei.txt") Then
            Form2.Show()
        Else
            SichereDB.Show()
        End If
    End Sub

    Private Sub ApplicationTitle_Click(sender As Object, e As EventArgs) Handles ApplicationTitle.Click

    End Sub

    Private Sub MainLayoutPanel_Paint(sender As Object, e As PaintEventArgs) Handles MainLayoutPanel.Paint

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
