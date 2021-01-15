Imports System.IO
Public Class BoardWorkingClass

    Public Sub Mask()

        PicMask1()
        PicMask2()
        PicMask3()
        PicMask4()
        PicMaskS1()
        PicMaskS2()

    End Sub

    Public Sub StringToTxt(a As String, s As String)        ' Argumente: (1) Adresse , (2) zu schreibender String

        Dim fs As New FileStream(a, FileMode.Create)
        Dim sw As New StreamWriter(fs)

        sw.WriteLine(s)

        sw.Close()

    End Sub

    Private Sub PicMask1()

        DepMain.PicMask1.Location = New Point(105, 0)
        DepMain.PicMask1.Size = New Size(500, 220)
        ' Make a Bitmap to hold the result.
        Dim bm1 As New Bitmap(500, 220)

        ' Associate a Graphics object with the Bitmap
        Using gr1 As Graphics = Graphics.FromImage(bm1)
            ' Define source and destination rectangles.
            Dim src_rect1 As New Rectangle(105, 0, 500, 220)
            Dim dst_rect1 As New Rectangle(0, 0, 500, 220)

            ' Copy that part of the image.
            gr1.DrawImage(DepMain.PicMask.Image, dst_rect1, src_rect1, GraphicsUnit.Pixel)
        End Using

        ' Display the result.
        DepMain.PicMask1.Image = bm1
    End Sub

    Private Sub PicMask2()

        DepMain.PicMask2.Location = New Point(105, 920)
        DepMain.PicMask2.Size = New Size(500, 160)
        ' Make a Bitmap to hold the result.
        Dim bm2 As New Bitmap(500, 160)

        ' Associate a Graphics object with the Bitmap
        Using gr2 As Graphics = Graphics.FromImage(bm2)
            ' Define source and destination rectangles.
            Dim src_rect2 As New Rectangle(105, 920, 500, 160)
            Dim dst_rect2 As New Rectangle(0, 0, 500, 160)

            ' Copy that part of the image.
            gr2.DrawImage(DepMain.PicMask.Image, dst_rect2, src_rect2, GraphicsUnit.Pixel)
        End Using

        ' Display the result.
        DepMain.PicMask2.Image = bm2
    End Sub

    Private Sub PicMask3()

        DepMain.PicMask3.Location = New Point(1315, 0)
        DepMain.PicMask3.Size = New Size(500, 160)
        ' Make a Bitmap to hold the result.
        Dim bm3 As New Bitmap(500, 160)

        ' Associate a Graphics object with the Bitmap
        Using gr3 As Graphics = Graphics.FromImage(bm3)
            ' Define source and destination rectangles.
            Dim src_rect3 As New Rectangle(1315, 0, 500, 160)
            Dim dst_rect3 As New Rectangle(0, 0, 500, 160)

            ' Copy that part of the image.
            gr3.DrawImage(DepMain.PicMask.Image, dst_rect3, src_rect3, GraphicsUnit.Pixel)
        End Using

        ' Display the result.
        DepMain.PicMask3.Image = bm3

    End Sub

    Private Sub PicMask4()

        DepMain.PicMask4.Location = New Point(1315, 860)
        DepMain.PicMask4.Size = New Size(500, 220)
        ' Make a Bitmap to hold the result.
        Dim bm4 As New Bitmap(500, 220)

        ' Associate a Graphics object with the Bitmap
        Using gr4 As Graphics = Graphics.FromImage(bm4)
            ' Define source and destination rectangles.
            Dim src_rect4 As New Rectangle(1315, 860, 500, 220)
            Dim dst_rect4 As New Rectangle(0, 0, 500, 220)

            ' Copy that part of the image.
            gr4.DrawImage(DepMain.PicMask.Image, dst_rect4, src_rect4, GraphicsUnit.Pixel)
        End Using

        ' Display the result.
        DepMain.PicMask4.Image = bm4

    End Sub

    Private Sub PicMaskS1()

        DepMain.PicMaskS1.Location = New Point(0, DepMain.LblScroll1.Location.Y)
        DepMain.PicMaskS1.Size = New Size(105, DepMain.LblScroll1.Height)
        ' Make a Bitmap to hold the result.
        Dim bmS1 As New Bitmap(105, DepMain.LblScroll1.Height)

        ' Associate a Graphics object with the Bitmap
        Using gr As Graphics = Graphics.FromImage(bmS1)
            ' Define source and destination rectangles.
            Dim src_rect As New Rectangle(0, DepMain.LblScroll1.Location.Y, 105, DepMain.LblScroll1.Height)
            Dim dst_rect As New Rectangle(0, 0, 105, DepMain.LblScroll1.Height)

            ' Copy that part of the image.
            gr.DrawImage(DepMain.PicMask.Image, dst_rect, src_rect, GraphicsUnit.Pixel)
        End Using

        ' Display the result.
        DepMain.PicMaskS1.Image = bmS1

    End Sub

    Private Sub PicMaskS2()

        DepMain.PicMaskS2.Location = New Point(1815, DepMain.LblScroll1.Location.Y)
        DepMain.PicMaskS2.Size = New Size(105, DepMain.LblScroll1.Height)
        ' Make a Bitmap to hold the result.
        Dim bmS2 As New Bitmap(105, DepMain.LblScroll1.Height)

        ' Associate a Graphics object with the Bitmap
        Using gr As Graphics = Graphics.FromImage(bmS2)
            ' Define source and destination rectangles.
            Dim src_rect As New Rectangle(1815, DepMain.LblScroll1.Location.Y, 105, DepMain.LblScroll1.Height)
            Dim dst_rect As New Rectangle(0, 0, 105, DepMain.LblScroll1.Height)

            ' Copy that part of the image.
            gr.DrawImage(DepMain.PicMask.Image, dst_rect, src_rect, GraphicsUnit.Pixel)
        End Using

        ' Display the result.
        DepMain.PicMaskS2.Image = bmS2

    End Sub

End Class
