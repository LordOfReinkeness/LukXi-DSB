Public Class FormFull

    Dim loading As New EditorLoad
    Dim adress As New EditorAdresslist
    Dim saving As New EditorSave

    Dim nPhoto As Integer = 0

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If FormMain.photosFullArray.Count < 2 Then
            CmdRemPic.Enabled = False
        End If

        LblPhotoNum.Text = "Bild " & nPhoto + 1 & " von " & FormMain.photosFullArray.Count()
        PicMain.ImageLocation = adress.getRelativPath("meF") & FormMain.photosFullArray(nPhoto)
        PicMain.Show()

    End Sub

    Private Sub CmdNext_Click(sender As Object, e As EventArgs) Handles CmdNext.Click

        nPhoto += 1
        If nPhoto > FormMain.photosFullArray.Count() - 1 Then
            nPhoto = 0
        End If

        PicMain.ImageLocation = adress.getRelativPath("meF") & FormMain.photosFullArray(nPhoto)
        LblPhotoNum.Text = "Bild " & nPhoto + 1 & " von " & FormMain.photosFullArray.Count()
        PicMain.Show()

    End Sub

    Private Sub CmdPrev_Click(sender As Object, e As EventArgs) Handles CmdPrev.Click

        nPhoto -= 1
        If nPhoto < 0 Then
            nPhoto = FormMain.photosFullArray.Count() - 1
        End If

        PicMain.ImageLocation = adress.getRelativPath("meF") & FormMain.photosFullArray(nPhoto)
        LblPhotoNum.Text = "Bild " & nPhoto + 1 & " von " & FormMain.photosFullArray.Count()
        PicMain.Show()

    End Sub

    Private Sub CmdRemPic_Click(sender As Object, e As EventArgs) Handles CmdRemPic.Click

        Dim i As Integer = FormMain.photosFullArray.Count

        If i > 1 Then

            My.Computer.FileSystem.DeleteFile(adress.getRelativPath("meF") & FormMain.photosFullArray(nPhoto))
            FormMain.photosFullArray.RemoveAt(nPhoto)

            If nPhoto = FormMain.photosFullArray.Count Then
                nPhoto -= 1
            End If

            PicMain.ImageLocation = adress.getRelativPath("meF") & FormMain.photosFullArray(nPhoto)
            LblPhotoNum.Text = "Bild " & nPhoto + 1 & " von " & FormMain.photosFullArray.Count

        End If

        If FormMain.photosFullArray.Count = 1 Then
            CmdRemPic.Enabled = False
        End If

        FormMain.CmdSave.Enabled = True

    End Sub

    Private Sub CmdAddPic_Click(sender As Object, e As EventArgs) Handles CmdAddPic.Click

        Dim fd As OpenFileDialog = New OpenFileDialog()
        Dim filePath As String
        Dim fileName As String
        Dim locRoot As String = adress.getRelativPath("meF") & "\"

        fd.Title = "Bild wählen"
        fd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
        fd.Filter = "Image Files(*.PNG;*.JPG;*.GIF)|*.PNG;*.JPG;*.GIF|All files (*.*)|*.*"
        fd.FilterIndex = 1
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            filePath = fd.FileName
            fileName = System.IO.Path.GetFileName(filePath)

            If My.Computer.FileSystem.FileExists(locRoot & fileName) = False Then
                FileCopy(filePath, locRoot & fileName)

                PicMain.ImageLocation = locRoot & fileName
                PicMain.Show()

                nPhoto += 1

                FormMain.photosFullArray.Insert(nPhoto, "/" & fileName)
                LblPhotoNum.Text = "Bild " & nPhoto + 1 & " von " & FormMain.photosFullArray.Count()

            Else
                MessageBox.Show("Das ausgewählte Bild oder ein Bild mit gleichem Namen existiert schon!", "Bild exisitiert schon",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        End If

        If FormMain.photosFullArray.Count > 1 Then
            CmdRemPic.Enabled = True
        End If

        FormMain.CmdSave.Enabled = True

    End Sub

    Private Sub CmdQuit_Click(sender As Object, e As EventArgs) Handles CmdQuit.Click
        Me.Close()
    End Sub

End Class