Imports System.IO
Public Class EditorSave

    Dim add As New EditorAdresslist
    Dim exp As New EditorLoad

    Public Sub StringToTxt(a As String, s As String)        ' Argumente: (1) Adresse , (2) zu schreibender String

        Dim fs As New FileStream(a, FileMode.Create)
        Dim sw As New StreamWriter(fs)

        sw.WriteLine(s)

        sw.Close()

    End Sub

    Public Function ArrToString(arr() As String)

        Dim s As String

        For i = 0 To arr.Length - 1
            If i < arr.Length - 1 Then
                s &= arr(i) & vbCrLf
            Else
                s &= arr(i)
            End If
        Next

        Return s

    End Function

    Public Function DimentionalArrayToString(arr(,) As String)

        Dim s As String

        For i = 0 To arr.Length / 2 - 1
            s &= arr(i, 0) & vbCrLf
            If i < arr.Length / 2 - 1 Then
                s &= arr(i, 1) & vbCrLf
            Else
                s &= arr(i, 1)
            End If
        Next

        Return s

    End Function

    Public Sub packageData(pha As ArrayList, phf As ArrayList, tim() As String, cal As String, scrl As String,
                           con() As String, souce As String, trgt As String)

        packagePic(pha, phf)

        For i = 0 To tim.Length - 1
            StringToTxt(add.getRelativPath(i.ToString), tim(i))
        Next

        StringToTxt(add.getRelativPath("cal"), cal)
        StringToTxt(add.getRelativPath("scrl"), scrl)

        StringToTxt(add.getRelativPath("con"), ArrToString(con))

        exp.getData(souce, trgt)

    End Sub

    Private Sub packagePic(arr As ArrayList, phf As ArrayList)

        Dim a(arr.Count - 1, 1) As String
        Dim b(phf.Count - 1) As String

        For i = 0 To arr.Count - 1
            a(i, 0) = arr(i).getLoc
            a(i, 1) = arr(i).getText
        Next

        For i = 0 To phf.Count - 1
            b(i) = phf(i)
        Next

        StringToTxt(add.getRelativPath("phF"), ArrToString(b))
        StringToTxt(add.getRelativPath("phM"), DimentionalArrayToString(a))

    End Sub

    Public Sub pushData(src As String, trgt As String)

        System.Diagnostics.Process.Start("net.exe", "use Y: \\10.16.1.1\xibo /USER:<reinke> <7A3bzU5fsL>")

        If Directory.Exists(trgt) Then
            Directory.Delete(trgt, True)
        End If
        Directory.CreateDirectory(trgt)

        My.Computer.FileSystem.CopyDirectory(src, trgt)

        System.Diagnostics.Process.Start("net.exe", "use /delete Y:")

    End Sub

End Class
