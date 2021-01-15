<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormFull
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
        Me.CmdQuit = New System.Windows.Forms.Button()
        Me.CmdRemPic = New System.Windows.Forms.Button()
        Me.PicMain = New System.Windows.Forms.PictureBox()
        Me.CmdAddPic = New System.Windows.Forms.Button()
        Me.LblPhotoNum = New System.Windows.Forms.Label()
        Me.CmdNext = New System.Windows.Forms.Button()
        Me.CmdPrev = New System.Windows.Forms.Button()
        CType(Me.PicMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmdQuit
        '
        Me.CmdQuit.Location = New System.Drawing.Point(1703, 845)
        Me.CmdQuit.Name = "CmdQuit"
        Me.CmdQuit.Size = New System.Drawing.Size(160, 55)
        Me.CmdQuit.TabIndex = 0
        Me.CmdQuit.Text = "Fenster schließen"
        Me.CmdQuit.UseVisualStyleBackColor = True
        '
        'CmdRemPic
        '
        Me.CmdRemPic.Location = New System.Drawing.Point(1417, 24)
        Me.CmdRemPic.Name = "CmdRemPic"
        Me.CmdRemPic.Size = New System.Drawing.Size(126, 23)
        Me.CmdRemPic.TabIndex = 1
        Me.CmdRemPic.Text = "Bild Entfernen"
        Me.CmdRemPic.UseVisualStyleBackColor = True
        '
        'PicMain
        '
        Me.PicMain.Location = New System.Drawing.Point(197, 63)
        Me.PicMain.Name = "PicMain"
        Me.PicMain.Size = New System.Drawing.Size(1488, 837)
        Me.PicMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicMain.TabIndex = 2
        Me.PicMain.TabStop = False
        '
        'CmdAddPic
        '
        Me.CmdAddPic.Location = New System.Drawing.Point(1559, 24)
        Me.CmdAddPic.Name = "CmdAddPic"
        Me.CmdAddPic.Size = New System.Drawing.Size(126, 23)
        Me.CmdAddPic.TabIndex = 4
        Me.CmdAddPic.Text = "Bild Hinzufügen"
        Me.CmdAddPic.UseVisualStyleBackColor = True
        '
        'LblPhotoNum
        '
        Me.LblPhotoNum.AutoSize = True
        Me.LblPhotoNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPhotoNum.Location = New System.Drawing.Point(195, 41)
        Me.LblPhotoNum.Name = "LblPhotoNum"
        Me.LblPhotoNum.Size = New System.Drawing.Size(39, 20)
        Me.LblPhotoNum.TabIndex = 5
        Me.LblPhotoNum.Text = "Bild "
        '
        'CmdNext
        '
        Me.CmdNext.Location = New System.Drawing.Point(1610, 906)
        Me.CmdNext.Name = "CmdNext"
        Me.CmdNext.Size = New System.Drawing.Size(75, 23)
        Me.CmdNext.TabIndex = 6
        Me.CmdNext.Text = ">>"
        Me.CmdNext.UseVisualStyleBackColor = True
        '
        'CmdPrev
        '
        Me.CmdPrev.Location = New System.Drawing.Point(1529, 906)
        Me.CmdPrev.Name = "CmdPrev"
        Me.CmdPrev.Size = New System.Drawing.Size(75, 23)
        Me.CmdPrev.TabIndex = 7
        Me.CmdPrev.Text = "<<"
        Me.CmdPrev.UseVisualStyleBackColor = True
        '
        'FormFull
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1884, 981)
        Me.Controls.Add(Me.CmdPrev)
        Me.Controls.Add(Me.CmdNext)
        Me.Controls.Add(Me.LblPhotoNum)
        Me.Controls.Add(Me.CmdAddPic)
        Me.Controls.Add(Me.PicMain)
        Me.Controls.Add(Me.CmdRemPic)
        Me.Controls.Add(Me.CmdQuit)
        Me.Location = New System.Drawing.Point(10, 10)
        Me.Name = "FormFull"
        Me.Text = "Form3"
        CType(Me.PicMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CmdQuit As Button
    Friend WithEvents CmdRemPic As Button
    Friend WithEvents PicMain As PictureBox
    Friend WithEvents CmdAddPic As Button
    Friend WithEvents LblPhotoNum As Label
    Friend WithEvents CmdNext As Button
    Friend WithEvents CmdPrev As Button
End Class
