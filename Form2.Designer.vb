<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.verzeichnis1 = New System.Windows.Forms.TextBox()
        Me.verzeichnis2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dienst = New System.Windows.Forms.TextBox()
        Me.dbdatei = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.zeitstart = New System.Windows.Forms.TextBox()
        Me.zeitende = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(32, 337)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(324, 337)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Abbrechen"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'verzeichnis1
        '
        Me.verzeichnis1.AcceptsReturn = True
        Me.verzeichnis1.Location = New System.Drawing.Point(227, 53)
        Me.verzeichnis1.Name = "verzeichnis1"
        Me.verzeichnis1.Size = New System.Drawing.Size(172, 20)
        Me.verzeichnis1.TabIndex = 2
        Me.verzeichnis1.Text = "C:\sicherung"
        '
        'verzeichnis2
        '
        Me.verzeichnis2.Location = New System.Drawing.Point(227, 91)
        Me.verzeichnis2.Name = "verzeichnis2"
        Me.verzeichnis2.Size = New System.Drawing.Size(172, 20)
        Me.verzeichnis2.TabIndex = 3
        Me.verzeichnis2.Text = "C:\easylog6.6\server"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Verzeichnis in dem gesichert werden soll:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(209, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Verzeichnis aus dem gesichert werden soll:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Bezeichnung des Dienstes:"
        '
        'dienst
        '
        Me.dienst.Location = New System.Drawing.Point(227, 125)
        Me.dienst.Name = "dienst"
        Me.dienst.Size = New System.Drawing.Size(172, 20)
        Me.dienst.TabIndex = 7
        Me.dienst.Text = "Adaptive Server Anywhere - ELServer66"
        '
        'dbdatei
        '
        Me.dbdatei.Location = New System.Drawing.Point(227, 163)
        Me.dbdatei.Name = "dbdatei"
        Me.dbdatei.Size = New System.Drawing.Size(172, 20)
        Me.dbdatei.TabIndex = 8
        Me.dbdatei.Text = "easylog66.db"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(169, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Bezeichnung der Datenbankdatei:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 202)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Startzeit:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(224, 202)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Endzeit:"
        '
        'zeitstart
        '
        Me.zeitstart.Location = New System.Drawing.Point(96, 195)
        Me.zeitstart.Name = "zeitstart"
        Me.zeitstart.Size = New System.Drawing.Size(100, 20)
        Me.zeitstart.TabIndex = 12
        Me.zeitstart.Text = "21:00"
        '
        'zeitende
        '
        Me.zeitende.Location = New System.Drawing.Point(299, 199)
        Me.zeitende.Name = "zeitende"
        Me.zeitende.Size = New System.Drawing.Size(100, 20)
        Me.zeitende.TabIndex = 13
        Me.zeitende.Text = "21:05"
        '
        'Form2
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(426, 372)
        Me.Controls.Add(Me.zeitende)
        Me.Controls.Add(Me.zeitstart)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dbdatei)
        Me.Controls.Add(Me.dienst)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.verzeichnis2)
        Me.Controls.Add(Me.verzeichnis1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.ShowInTaskbar = False
        Me.Text = "Einstellungen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents verzeichnis1 As System.Windows.Forms.TextBox
    Friend WithEvents verzeichnis2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dienst As System.Windows.Forms.TextBox
    Friend WithEvents dbdatei As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents zeitstart As System.Windows.Forms.TextBox
    Friend WithEvents zeitende As System.Windows.Forms.TextBox
End Class
