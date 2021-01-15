<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.CmdForm2 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CmdSave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmdClose = New System.Windows.Forms.Button()
        Me.CmdPhotoBack = New System.Windows.Forms.Button()
        Me.CmdPhotoNext = New System.Windows.Forms.Button()
        Me.TxtPhotoData = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CmdWe = New System.Windows.Forms.Button()
        Me.CmdFri = New System.Windows.Forms.Button()
        Me.CmdThu = New System.Windows.Forms.Button()
        Me.CmdWed = New System.Windows.Forms.Button()
        Me.CmdMon = New System.Windows.Forms.Button()
        Me.TxtScroll = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtInfo = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LblPhotoNum = New System.Windows.Forms.Label()
        Me.PicFlyer = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CmddAddPic = New System.Windows.Forms.Button()
        Me.CmdRemCurrPIc = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblWeekday = New System.Windows.Forms.Label()
        Me.TxtWeekdayText = New System.Windows.Forms.TextBox()
        Me.CmdTue = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.CmdPrev = New System.Windows.Forms.Button()
        Me.CmdPicMain = New System.Windows.Forms.Button()
        Me.Panel3.SuspendLayout()
        CType(Me.PicFlyer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CmdForm2
        '
        Me.CmdForm2.Location = New System.Drawing.Point(1091, 847)
        Me.CmdForm2.Name = "CmdForm2"
        Me.CmdForm2.Size = New System.Drawing.Size(187, 70)
        Me.CmdForm2.TabIndex = 60
        Me.CmdForm2.Text = "Einstellungen und Konfiguration"
        Me.CmdForm2.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(727, 744)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 15)
        Me.Label7.TabIndex = 58
        Me.Label7.Text = "Bildtexte"
        '
        'CmdSave
        '
        Me.CmdSave.Location = New System.Drawing.Point(1484, 893)
        Me.CmdSave.Name = "CmdSave"
        Me.CmdSave.Size = New System.Drawing.Size(160, 50)
        Me.CmdSave.TabIndex = 57
        Me.CmdSave.Text = "Speichern"
        Me.CmdSave.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(122, 899)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 17)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Lauftext"
        '
        'CmdClose
        '
        Me.CmdClose.Location = New System.Drawing.Point(1674, 893)
        Me.CmdClose.Name = "CmdClose"
        Me.CmdClose.Size = New System.Drawing.Size(160, 50)
        Me.CmdClose.TabIndex = 55
        Me.CmdClose.Text = "Beenden"
        Me.CmdClose.UseVisualStyleBackColor = True
        '
        'CmdPhotoBack
        '
        Me.CmdPhotoBack.Location = New System.Drawing.Point(1073, 800)
        Me.CmdPhotoBack.Name = "CmdPhotoBack"
        Me.CmdPhotoBack.Size = New System.Drawing.Size(75, 23)
        Me.CmdPhotoBack.TabIndex = 54
        Me.CmdPhotoBack.Text = "<<"
        Me.CmdPhotoBack.UseVisualStyleBackColor = True
        '
        'CmdPhotoNext
        '
        Me.CmdPhotoNext.Location = New System.Drawing.Point(1154, 800)
        Me.CmdPhotoNext.Name = "CmdPhotoNext"
        Me.CmdPhotoNext.Size = New System.Drawing.Size(75, 23)
        Me.CmdPhotoNext.TabIndex = 53
        Me.CmdPhotoNext.Text = ">>"
        Me.CmdPhotoNext.UseVisualStyleBackColor = True
        '
        'TxtPhotoData
        '
        Me.TxtPhotoData.Location = New System.Drawing.Point(729, 764)
        Me.TxtPhotoData.Name = "TxtPhotoData"
        Me.TxtPhotoData.Size = New System.Drawing.Size(500, 20)
        Me.TxtPhotoData.TabIndex = 52
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1477, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(194, 22)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Termine/ Informationen"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(951, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 22)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Bilder"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(309, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 22)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Raumbelegung"
        '
        'CmdWe
        '
        Me.CmdWe.Location = New System.Drawing.Point(32, 249)
        Me.CmdWe.Name = "CmdWe"
        Me.CmdWe.Size = New System.Drawing.Size(80, 23)
        Me.CmdWe.TabIndex = 48
        Me.CmdWe.Text = "Wochenende"
        Me.CmdWe.UseVisualStyleBackColor = True
        '
        'CmdFri
        '
        Me.CmdFri.Location = New System.Drawing.Point(32, 219)
        Me.CmdFri.Name = "CmdFri"
        Me.CmdFri.Size = New System.Drawing.Size(80, 23)
        Me.CmdFri.TabIndex = 47
        Me.CmdFri.Text = "Freitag"
        Me.CmdFri.UseVisualStyleBackColor = True
        '
        'CmdThu
        '
        Me.CmdThu.Location = New System.Drawing.Point(32, 189)
        Me.CmdThu.Name = "CmdThu"
        Me.CmdThu.Size = New System.Drawing.Size(80, 23)
        Me.CmdThu.TabIndex = 46
        Me.CmdThu.Text = "Donnerstag"
        Me.CmdThu.UseVisualStyleBackColor = True
        '
        'CmdWed
        '
        Me.CmdWed.Location = New System.Drawing.Point(32, 159)
        Me.CmdWed.Name = "CmdWed"
        Me.CmdWed.Size = New System.Drawing.Size(80, 23)
        Me.CmdWed.TabIndex = 45
        Me.CmdWed.Text = "Mittwoch"
        Me.CmdWed.UseVisualStyleBackColor = True
        '
        'CmdMon
        '
        Me.CmdMon.Location = New System.Drawing.Point(32, 99)
        Me.CmdMon.Name = "CmdMon"
        Me.CmdMon.Size = New System.Drawing.Size(80, 23)
        Me.CmdMon.TabIndex = 43
        Me.CmdMon.Text = "Montag"
        Me.CmdMon.UseVisualStyleBackColor = True
        '
        'TxtScroll
        '
        Me.TxtScroll.Location = New System.Drawing.Point(124, 923)
        Me.TxtScroll.Multiline = True
        Me.TxtScroll.Name = "TxtScroll"
        Me.TxtScroll.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.TxtScroll.Size = New System.Drawing.Size(1217, 20)
        Me.TxtScroll.TabIndex = 42
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 734)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(152, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Überschriften mit ## markieren"
        '
        'TxtInfo
        '
        Me.TxtInfo.Location = New System.Drawing.Point(4, 25)
        Me.TxtInfo.Multiline = True
        Me.TxtInfo.Name = "TxtInfo"
        Me.TxtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtInfo.Size = New System.Drawing.Size(491, 700)
        Me.TxtInfo.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.TxtInfo)
        Me.Panel3.Location = New System.Drawing.Point(1334, 48)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(500, 770)
        Me.Panel3.TabIndex = 41
        '
        'LblPhotoNum
        '
        Me.LblPhotoNum.AutoSize = True
        Me.LblPhotoNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPhotoNum.Location = New System.Drawing.Point(12, 8)
        Me.LblPhotoNum.Name = "LblPhotoNum"
        Me.LblPhotoNum.Size = New System.Drawing.Size(28, 15)
        Me.LblPhotoNum.TabIndex = 39
        Me.LblPhotoNum.Text = "Bild"
        '
        'PicFlyer
        '
        Me.PicFlyer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PicFlyer.Location = New System.Drawing.Point(9, 35)
        Me.PicFlyer.Name = "PicFlyer"
        Me.PicFlyer.Size = New System.Drawing.Size(480, 640)
        Me.PicFlyer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicFlyer.TabIndex = 0
        Me.PicFlyer.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.CmddAddPic)
        Me.Panel2.Controls.Add(Me.CmdRemCurrPIc)
        Me.Panel2.Controls.Add(Me.LblPhotoNum)
        Me.Panel2.Controls.Add(Me.PicFlyer)
        Me.Panel2.Location = New System.Drawing.Point(729, 48)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(500, 690)
        Me.Panel2.TabIndex = 40
        '
        'CmddAddPic
        '
        Me.CmddAddPic.Location = New System.Drawing.Point(387, 5)
        Me.CmddAddPic.Name = "CmddAddPic"
        Me.CmddAddPic.Size = New System.Drawing.Size(102, 23)
        Me.CmddAddPic.TabIndex = 42
        Me.CmddAddPic.Text = "Bild Hinzufügen"
        Me.CmddAddPic.UseVisualStyleBackColor = True
        '
        'CmdRemCurrPIc
        '
        Me.CmdRemCurrPIc.Location = New System.Drawing.Point(170, 5)
        Me.CmdRemCurrPIc.Name = "CmdRemCurrPIc"
        Me.CmdRemCurrPIc.Size = New System.Drawing.Size(160, 23)
        Me.CmdRemCurrPIc.TabIndex = 41
        Me.CmdRemCurrPIc.Text = "Dieses Bild Entfernen"
        Me.CmdRemCurrPIc.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 734)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Überschriften mit ## markieren"
        '
        'LblWeekday
        '
        Me.LblWeekday.AutoSize = True
        Me.LblWeekday.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWeekday.Location = New System.Drawing.Point(4, -1)
        Me.LblWeekday.Name = "LblWeekday"
        Me.LblWeekday.Size = New System.Drawing.Size(0, 15)
        Me.LblWeekday.TabIndex = 2
        '
        'TxtWeekdayText
        '
        Me.TxtWeekdayText.Location = New System.Drawing.Point(4, 25)
        Me.TxtWeekdayText.Multiline = True
        Me.TxtWeekdayText.Name = "TxtWeekdayText"
        Me.TxtWeekdayText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtWeekdayText.Size = New System.Drawing.Size(491, 700)
        Me.TxtWeekdayText.TabIndex = 1
        Me.TxtWeekdayText.TabStop = False
        '
        'CmdTue
        '
        Me.CmdTue.Location = New System.Drawing.Point(32, 129)
        Me.CmdTue.Name = "CmdTue"
        Me.CmdTue.Size = New System.Drawing.Size(80, 23)
        Me.CmdTue.TabIndex = 44
        Me.CmdTue.Text = "Dienstag"
        Me.CmdTue.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.LblWeekday)
        Me.Panel1.Controls.Add(Me.TxtWeekdayText)
        Me.Panel1.Location = New System.Drawing.Point(124, 48)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(500, 765)
        Me.Panel1.TabIndex = 39
        '
        'CmdPrev
        '
        Me.CmdPrev.Location = New System.Drawing.Point(891, 847)
        Me.CmdPrev.Name = "CmdPrev"
        Me.CmdPrev.Size = New System.Drawing.Size(187, 70)
        Me.CmdPrev.TabIndex = 61
        Me.CmdPrev.Text = "Vorschau"
        Me.CmdPrev.UseVisualStyleBackColor = True
        '
        'CmdPicMain
        '
        Me.CmdPicMain.Location = New System.Drawing.Point(690, 847)
        Me.CmdPicMain.Name = "CmdPicMain"
        Me.CmdPicMain.Size = New System.Drawing.Size(187, 70)
        Me.CmdPicMain.TabIndex = 62
        Me.CmdPicMain.Text = "Vollbild-Einstellungen"
        Me.CmdPicMain.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1870, 984)
        Me.Controls.Add(Me.CmdPicMain)
        Me.Controls.Add(Me.CmdPrev)
        Me.Controls.Add(Me.CmdForm2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CmdSave)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CmdClose)
        Me.Controls.Add(Me.CmdPhotoBack)
        Me.Controls.Add(Me.CmdPhotoNext)
        Me.Controls.Add(Me.TxtPhotoData)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CmdWe)
        Me.Controls.Add(Me.CmdFri)
        Me.Controls.Add(Me.CmdThu)
        Me.Controls.Add(Me.CmdWed)
        Me.Controls.Add(Me.CmdMon)
        Me.Controls.Add(Me.TxtScroll)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.CmdTue)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PicFlyer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CmdForm2 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents CmdSave As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents CmdClose As Button
    Friend WithEvents CmdPhotoBack As Button
    Friend WithEvents CmdPhotoNext As Button
    Friend WithEvents TxtPhotoData As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CmdWe As Button
    Friend WithEvents CmdFri As Button
    Friend WithEvents CmdThu As Button
    Friend WithEvents CmdWed As Button
    Friend WithEvents CmdMon As Button
    Friend WithEvents TxtScroll As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtInfo As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents LblPhotoNum As Label
    Friend WithEvents PicFlyer As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents LblWeekday As Label
    Friend WithEvents TxtWeekdayText As TextBox
    Friend WithEvents CmdTue As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents CmddAddPic As Button
    Friend WithEvents CmdRemCurrPIc As Button
    Friend WithEvents CmdPrev As Button
    Friend WithEvents CmdPicMain As Button
End Class
