Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()
        Dim filePath As String
        Dim fileName As String
        Dim locRoot As String = "data\media\"

        fd.Title = "Bild wählen"
        fd.InitialDirectory = "E:\Lukas\Pictures\Camera Roll\Bodensee dome"
        fd.Filter = "Image Files(*.PNG;*.JPG;*.GIF)|*.PNG;*.JPG;*.GIF|All files (*.*)|*.*"
        fd.FilterIndex = 1
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            filePath = fd.FileName
            fileName = System.IO.Path.GetFileName(filePath)

            If My.Computer.FileSystem.FileExists(locRoot & fileName) = False Then
                FileCopy(filePath, locRoot & fileName)

                PictureBox1.ImageLocation = locRoot & fileName
                PictureBox1.Show()

                Dim t As String = InputBox("Zugehörigen text Eingeben.")
                Label1.Text = t

            Else
                MessageBox.Show("Das ausgewählte Bild oder ein Bild mit gleichem Namen existiert schon!", "Bild exisitiert schon",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If



        End If





    End Sub

    Private Sub TxtPhotoNum_TextChanged(sender As Object, e As EventArgs) Handles TxtPhotoNum.TextChanged

        If unapprovedChange Then
            Dim sucsess As Boolean = False
            Dim b As Integer

            Try
                b = Integer.Parse(TxtPhotoNum.Text)
                sucsess = True
            Catch ex As Exception

            End Try

            If sucsess Then
                If b > 0 And b < photosArray.Count + 1 Then

                    If b > nPhoto + 1 Then

                        photosArray.Insert(b, photosArray(nPhoto))
                        photosArray.RemoveAt(nPhoto)
                        nPhoto = b - 1

                    ElseIf b < nPhoto + 1 Then

                        photosArray.Insert(b - 1, photosArray(nPhoto))
                        photosArray.RemoveAt(nPhoto)
                        nPhoto = b - 1

                    End If


                    LblPhotoNum.Text = photosArray.Count
                    PicFlyer.ImageLocation = photosArray(nPhoto).getLoc()
                    TxtPhotoData.Text = photosArray(nPhoto).getText()
                    TxtPhotoNum.Text = nPhoto + 1

                End If
            End If
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
