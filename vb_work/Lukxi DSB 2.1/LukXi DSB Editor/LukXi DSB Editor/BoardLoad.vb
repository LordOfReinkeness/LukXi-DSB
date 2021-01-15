Imports System.IO
Public Class BoardLoad

    Public Function TxtToString(adress As String)

        Dim lineCount = File.ReadAllLines(adress).Length

        Dim fs As New FileStream(adress, FileMode.Open)
        Dim sr As New StreamReader(fs)
        Dim line, text As String

        For i = 0 To lineCount - 1
            line = sr.ReadLine()

            If i < lineCount - 1 Then
                text &= line & vbCrLf
            Else
                text &= line
            End If
        Next

        fs.Close()
        sr.Close()

        Return text

    End Function

    Public Function TxtToSimpleArray(adress As String)


        Dim lineCount = File.ReadAllLines(adress).Length

        Dim fs As New FileStream(adress, FileMode.Open)
        Dim sr As New StreamReader(fs)
        Dim line As String
        Dim text(lineCount - 1) As String

        For i = 0 To lineCount - 1
            line = sr.ReadLine()
            text(i) = line
        Next

        fs.Close()
        sr.Close()

        Return text

    End Function

    Public Function GetDimenionalArray(adress As String)

        Dim plain() As String = TxtToSimpleArray(adress)

        Dim arr(plain.Length / 2 - 1, 1) As String

        For i = 0 To plain.Length / 2 - 1

            Try
                arr(i, 0) = plain(i * 2)
            Catch ex As Exception
                arr(i, 0) = "-1"
            End Try

            Try
                arr(i, 1) = plain(i * 2 + 1)
            Catch ex As Exception
                arr(i, 1) = "i"
            End Try

        Next

        Return arr

    End Function

    Public Function ComparePhotosArray(pArr(,) As String, adress As String)

        Dim i As Integer
        Dim a() As String = Directory.GetFiles(adress)

        Dim z As Integer = 0
        For i = 0 To a.Length - 1
            If a(i).Contains("jpg") Or a(i).Contains("png") Or a(i).Contains("JPG") Then
                z += 1
            End If
        Next

        Dim s(z - 1, 1) As String
        z = 0
        For i = 0 To a.Length - 1
            If a(i).Contains("jpg") Or a(i).Contains("png") Or a(i).Contains("JPG") Then
                s(z, 0) = a(i)
                z += 1
            End If
        Next

        Dim n As String = adress

        For i = 0 To s.Length / 2 - 1
            s(i, 0) = s(i, 0).Substring(n.Length)
        Next

        For i = 0 To s.Length / 2 - 1
            For j = 0 To pArr.Length / 2 - 1
                'If pArr(j, 0).Equals(s(i, 0)) Then
                If s(i, 0).Equals(pArr(j, 0)) Then
                    s(i, 1) = pArr(j, 1)
                End If
            Next
        Next

        Return s
    End Function

    Public Function GetDay()
        'Gibt den Tag als String zurück

        Dim d = Date.Today

        If d.DayOfWeek = DayOfWeek.Monday Then
            Return 0
        ElseIf d.DayOfWeek = DayOfWeek.Tuesday Then
            Return 1
        ElseIf d.DayOfWeek = DayOfWeek.Wednesday Then
            Return 2
        ElseIf d.DayOfWeek = DayOfWeek.Thursday Then
            Return 3
        ElseIf d.DayOfWeek = DayOfWeek.Friday Then
            Return 4
        ElseIf d.DayOfWeek = DayOfWeek.Saturday Or d.DayOfWeek = DayOfWeek.Sunday Then
            Return 5
        End If

    End Function

End Class
