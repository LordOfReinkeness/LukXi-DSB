Public Class FormMain

    '///////////////////////Gobale variablen\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

    '////////////Absolute Adressen\\\\\\\\\\\\\\\\\\
    Public root As String = "data\"

    Public dSrc As String '= "\\10.16.1.1\xibo\Lukxi DSB 2.0\data"


    '//////////////Datenspeicher\\\\\\\\\\\\\\\\\\\\
    Dim photosArray As ArrayList = New ArrayList
    Public photosFullArray As ArrayList = New ArrayList
    Dim Timetable(5) As String
    Dim Calendar As String
    Dim ScrollText As String
    Public config() As String
    Dim day() As String = {"Montag", "Dienstag", "Mittwoch", "Donnerstag", "Freitag", "Wochenede"}

    '/////////////Kontrollvariablen\\\\\\\\\\\\\\\\\
    Dim nPhoto As Integer = 0
    Dim nDay As Integer
    Dim unapprovedChange As Boolean = False

    'Instanzen anlegen
    Dim loading As New EditorLoad
    Dim adress As New EditorAdresslist
    Dim saving As New EditorSave

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dSrc = loading.TxtToString("startupLoc.txt")

        'Daten laden
        startup()

        'Felder Füllen
        TxtScroll.Text = ScrollText
        TxtInfo.Text = Calendar
        LblWeekday.Text = day(nDay)
        TxtWeekdayText.Text = Timetable(nDay)

        'Fotos Laden
        Dim net As String = adress.getRelativPath("meM") & photosArray(nPhoto).getLoc()
        PicFlyer.ImageLocation = net
        TxtPhotoData.Text = photosArray(nPhoto).getText()
        LblPhotoNum.Text = "Bild " & nPhoto + 1 & " von " & photosArray.Count

        CmdSave.Enabled = False

    End Sub

    Private Sub startup()

        loading.getData(dSrc, root)

        config = loading.TxtToSimpleArray(adress.getRelativPath("con"))

        Dim photosTempArray(,) As String = loading.GetDimenionalArray(adress.getRelativPath("phM"))
        For i = 0 To photosTempArray.Length / 2 - 1
            photosArray.Add(New EditorPicLoc(photosTempArray(i, 0), photosTempArray(i, 1)))
        Next

        For i = 0 To Timetable.Length - 1
            Timetable(i) = loading.TxtToString(adress.getRelativPath(i.ToString))
        Next

        Dim photosFullTempArray() As String = loading.TxtToSimpleArray(adress.getRelativPath("phF"))
        For i = 0 To photosFullTempArray.Length - 1
            photosFullArray.Add(photosFullTempArray(i))
        Next

        Calendar = loading.TxtToString(adress.getRelativPath("cal"))

        ScrollText = loading.TxtToString(adress.getRelativPath("scrl"))

        nDay = loading.GetDay

    End Sub

    Private Sub CmdClose_Click(sender As Object, e As EventArgs) Handles CmdClose.Click
        Me.Close()
    End Sub

    Private Sub closingApp(sender As Object, e As EventArgs) Handles Me.Closing

        If CmdSave.Enabled Then
            Dim dr As DialogResult
            dr = MessageBox.Show("Die Vorgenommenen Änderungen wurden nicht gespeichert!" & vbCrLf & "Soll gespeichert werden?", "Noch nicht gespeichter!",
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Information)

            If dr = DialogResult.Yes Then
                save()
            End If

        End If

        CmdClose.Enabled = False

    End Sub

    Private Sub CmdPhotoNext_Click(sender As Object, e As EventArgs) Handles CmdPhotoNext.Click

        photosArray(nPhoto).setText(TxtPhotoData.Text)

        nPhoto += 1
        If nPhoto > photosArray.Count - 1 Then
            nPhoto = 0
        End If

        PicFlyer.ImageLocation = adress.getRelativPath("meM") & photosArray(nPhoto).getLoc()
        TxtPhotoData.Text = photosArray(nPhoto).getText
        LblPhotoNum.Text = "Bild " & nPhoto + 1 & " von " & photosArray.Count

    End Sub

    Private Sub CmdPhotoBack_Click(sender As Object, e As EventArgs) Handles CmdPhotoBack.Click

        photosArray(nPhoto).setText(TxtPhotoData.Text)

        nPhoto -= 1
        If nPhoto < 0 Then
            nPhoto = photosArray.Count - 1
        End If

        PicFlyer.ImageLocation = adress.getRelativPath("meM") & photosArray(nPhoto).getLoc()
        TxtPhotoData.Text = photosArray(nPhoto).getText
        LblPhotoNum.Text = "Bild " & nPhoto + 1 & " von " & photosArray.Count

    End Sub

    Private Sub CmdMon_Click(sender As Object, e As EventArgs) Handles CmdMon.Click
        Timetable(nDay) = TxtWeekdayText.Text
        nDay = 0
        LblWeekday.Text = day(nDay)
        TxtWeekdayText.Text = Timetable(nDay)
    End Sub

    Private Sub CmdTue_Click(sender As Object, e As EventArgs) Handles CmdTue.Click
        Timetable(nDay) = TxtWeekdayText.Text
        nDay = 1
        LblWeekday.Text = day(nDay)
        TxtWeekdayText.Text = Timetable(nDay)
    End Sub

    Private Sub CmdWed_Click(sender As Object, e As EventArgs) Handles CmdWed.Click
        Timetable(nDay) = TxtWeekdayText.Text
        nDay = 2
        LblWeekday.Text = day(nDay)
        TxtWeekdayText.Text = Timetable(nDay)
    End Sub

    Private Sub CmdThu_Click(sender As Object, e As EventArgs) Handles CmdThu.Click
        Timetable(nDay) = TxtWeekdayText.Text
        nDay = 3
        LblWeekday.Text = day(nDay)
        TxtWeekdayText.Text = Timetable(nDay)
    End Sub

    Private Sub CmdFri_Click(sender As Object, e As EventArgs) Handles CmdFri.Click
        Timetable(nDay) = TxtWeekdayText.Text
        nDay = 4
        LblWeekday.Text = day(nDay)
        TxtWeekdayText.Text = Timetable(nDay)
    End Sub

    Private Sub CmdWe_Click(sender As Object, e As EventArgs) Handles CmdWe.Click
        Timetable(nDay) = TxtWeekdayText.Text
        nDay = 5
        LblWeekday.Text = day(nDay)
        TxtWeekdayText.Text = Timetable(nDay)
    End Sub

    Private Sub logChanges(sender As Object, e As EventArgs) Handles TxtInfo.TextChanged, TxtPhotoData.TextChanged,
            TxtScroll.TextChanged, TxtWeekdayText.TextChanged

        CmdSave.Enabled = True

    End Sub

    Private Sub CmdSave_Click(sender As Object, e As EventArgs) Handles CmdSave.Click

        save()

        CmdSave.Enabled = False

    End Sub

    Private Sub CmdForm2_Click(sender As Object, e As EventArgs) Handles CmdForm2.Click
        FormSettings.ShowDialog()
    End Sub

    Private Sub save()

        ScrollText = TxtScroll.Text
        photosArray(nPhoto).setText(TxtPhotoData.Text)
        Timetable(nDay) = TxtWeekdayText.Text
        Calendar = TxtInfo.Text

        saving.packageData(photosArray, photosFullArray, Timetable, Calendar, ScrollText, config, root, dSrc)

        saving.pushData(root, dSrc)

    End Sub

    Private Sub CmdRemCurrPIc_Click(sender As Object, e As EventArgs) Handles CmdRemCurrPIc.Click

        Dim i As Integer = photosArray.Count

        If i > 1 Then

            My.Computer.FileSystem.DeleteFile(adress.getRelativPath("meM") & photosArray(nPhoto).getLoc())
            photosArray.RemoveAt(nPhoto)

            If nPhoto = photosArray.Count Then
                nPhoto -= 1
            End If

            PicFlyer.ImageLocation = adress.getRelativPath("meM") & photosArray(nPhoto).getLoc()
            TxtPhotoData.Text = photosArray(nPhoto).getText
            LblPhotoNum.Text = "Bild " & nPhoto + 1 & " von " & photosArray.Count

        End If

        If photosArray.Count = 1 Then
            CmdRemCurrPIc.Enabled = False
        End If


    End Sub

    Private Sub CmddAddPic_Click(sender As Object, e As EventArgs) Handles CmddAddPic.Click

        Dim fd As OpenFileDialog = New OpenFileDialog()
        Dim filePath As String
        Dim fileName As String
        Dim locRoot As String = adress.getRelativPath("meM")

        fd.Title = "Bild wählen"
        fd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
        fd.Filter = "Image Files(*.PNG;*.JPG;*.GIF)|*.PNG;*.JPG;*.GIF|All files (*.*)|*.*"
        fd.FilterIndex = 1
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            filePath = fd.FileName
            fileName = "\" & System.IO.Path.GetFileName(filePath)

            If My.Computer.FileSystem.FileExists(locRoot & fileName) = False Then
                FileCopy(filePath, locRoot & fileName)

                PicFlyer.ImageLocation = locRoot & fileName
                PicFlyer.Show()

                Dim t As String = InputBox("Zugehörigen text Eingeben.")
                TxtPhotoData.Text = t

                nPhoto += 1

                photosArray.Insert(nPhoto, New EditorPicLoc(fileName, t))
                LblPhotoNum.Text = "Bild " & nPhoto + 1 & " von " & photosArray.Count

            Else
                MessageBox.Show("Das ausgewählte Bild oder ein Bild mit gleichem Namen existiert schon!", "Bild exisitiert schon",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If



        End If

        If photosArray.Count > 1 Then
            CmdRemCurrPIc.Enabled = True
        End If

    End Sub

    Private Sub CmdPrev_Click(sender As Object, e As EventArgs) Handles CmdPrev.Click

        If CmdSave.Enabled Then
            Dim dr As DialogResult
            dr = MessageBox.Show("Die Vorgenommenen Änderungen wurden nicht gespeichert!" & vbCrLf & "Es muss gespeichert werden um die Vorschau zu öffnen?",
                                 "Noch nicht gespeichter!",
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Information)

            If dr = DialogResult.Yes Then
                save()
                CmdSave.Enabled = False
                DepMain.ShowDialog()
            End If

        Else

            DepMain.ShowDialog()

        End If
    End Sub

    Private Sub CmdPicMain_Click(sender As Object, e As EventArgs) Handles CmdPicMain.Click
        FormFull.ShowDialog()
    End Sub
End Class
