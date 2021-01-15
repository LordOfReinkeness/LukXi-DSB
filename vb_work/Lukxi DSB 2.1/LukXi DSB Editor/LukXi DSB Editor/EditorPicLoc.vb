Public Class EditorPicLoc

    Dim loc As String
    Dim text As String

    Public Sub New(loc As String, text As String)
        Me.loc = loc
        Me.text = text
    End Sub

    Public Function getLoc()
        Return loc
    End Function

    Public Sub setLoc(loc As String)
        Me.loc = loc
    End Sub
    Public Function getText()
        Return text
    End Function

    Public Sub setText(text As String)
        Me.text = text
    End Sub

End Class
