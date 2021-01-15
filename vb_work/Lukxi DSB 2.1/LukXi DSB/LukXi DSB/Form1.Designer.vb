<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.TimResize = New System.Windows.Forms.Timer(Me.components)
        Me.TimForm2 = New System.Windows.Forms.Timer(Me.components)
        Me.PicMaskS2 = New System.Windows.Forms.PictureBox()
        Me.PicMaskS1 = New System.Windows.Forms.PictureBox()
        Me.LblPhoto = New System.Windows.Forms.Label()
        Me.TimPhoto = New System.Windows.Forms.Timer(Me.components)
        Me.LblDate = New System.Windows.Forms.Label()
        Me.LblClock = New System.Windows.Forms.Label()
        Me.LblScroll3 = New System.Windows.Forms.Label()
        Me.LblScroll2 = New System.Windows.Forms.Label()
        Me.LblScroll1 = New System.Windows.Forms.Label()
        Me.PicFlyer = New System.Windows.Forms.PictureBox()
        Me.PanInfo1 = New System.Windows.Forms.Panel()
        Me.PanInfo4 = New System.Windows.Forms.Panel()
        Me.PanInfo3 = New System.Windows.Forms.Panel()
        Me.CmdRestart = New System.Windows.Forms.Button()
        Me.TimTime = New System.Windows.Forms.Timer(Me.components)
        Me.PicMask4 = New System.Windows.Forms.PictureBox()
        Me.PicMask2 = New System.Windows.Forms.PictureBox()
        Me.PicMask3 = New System.Windows.Forms.PictureBox()
        Me.PicMask1 = New System.Windows.Forms.PictureBox()
        Me.PicMask = New System.Windows.Forms.PictureBox()
        Me.CmdQuit = New System.Windows.Forms.Button()
        Me.TimScroll = New System.Windows.Forms.Timer(Me.components)
        Me.TimInfo = New System.Windows.Forms.Timer(Me.components)
        Me.PanInfo2 = New System.Windows.Forms.Panel()
        Me.TimTimetable = New System.Windows.Forms.Timer(Me.components)
        Me.TimProblem = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PicMaskS2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicMaskS1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicFlyer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicMask4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicMask2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicMask3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicMask1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicMask, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TimResize
        '
        Me.TimResize.Enabled = True
        Me.TimResize.Interval = 1000
        '
        'TimForm2
        '
        Me.TimForm2.Interval = 1
        '
        'PicMaskS2
        '
        Me.PicMaskS2.BackColor = System.Drawing.Color.White
        Me.PicMaskS2.Location = New System.Drawing.Point(984, 114)
        Me.PicMaskS2.Name = "PicMaskS2"
        Me.PicMaskS2.Size = New System.Drawing.Size(100, 50)
        Me.PicMaskS2.TabIndex = 44
        Me.PicMaskS2.TabStop = False
        '
        'PicMaskS1
        '
        Me.PicMaskS1.BackColor = System.Drawing.Color.White
        Me.PicMaskS1.Location = New System.Drawing.Point(984, 42)
        Me.PicMaskS1.Name = "PicMaskS1"
        Me.PicMaskS1.Size = New System.Drawing.Size(100, 50)
        Me.PicMaskS1.TabIndex = 43
        Me.PicMaskS1.TabStop = False
        '
        'LblPhoto
        '
        Me.LblPhoto.AutoSize = True
        Me.LblPhoto.BackColor = System.Drawing.Color.White
        Me.LblPhoto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPhoto.Location = New System.Drawing.Point(784, 282)
        Me.LblPhoto.Name = "LblPhoto"
        Me.LblPhoto.Size = New System.Drawing.Size(45, 15)
        Me.LblPhoto.TabIndex = 36
        Me.LblPhoto.Text = "Label1"
        '
        'TimPhoto
        '
        Me.TimPhoto.Interval = 1000
        '
        'LblDate
        '
        Me.LblDate.AutoSize = True
        Me.LblDate.BackColor = System.Drawing.Color.Transparent
        Me.LblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDate.ForeColor = System.Drawing.Color.White
        Me.LblDate.Location = New System.Drawing.Point(781, 210)
        Me.LblDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblDate.Name = "LblDate"
        Me.LblDate.Size = New System.Drawing.Size(53, 20)
        Me.LblDate.TabIndex = 45
        Me.LblDate.Text = "Clock"
        '
        'LblClock
        '
        Me.LblClock.AutoSize = True
        Me.LblClock.BackColor = System.Drawing.Color.Transparent
        Me.LblClock.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblClock.ForeColor = System.Drawing.Color.White
        Me.LblClock.Location = New System.Drawing.Point(781, 166)
        Me.LblClock.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblClock.Name = "LblClock"
        Me.LblClock.Size = New System.Drawing.Size(88, 31)
        Me.LblClock.TabIndex = 30
        Me.LblClock.Text = "Clock"
        '
        'LblScroll3
        '
        Me.LblScroll3.AutoSize = True
        Me.LblScroll3.BackColor = System.Drawing.Color.Transparent
        Me.LblScroll3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblScroll3.ForeColor = System.Drawing.Color.White
        Me.LblScroll3.Location = New System.Drawing.Point(781, 123)
        Me.LblScroll3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblScroll3.Name = "LblScroll3"
        Me.LblScroll3.Size = New System.Drawing.Size(101, 31)
        Me.LblScroll3.TabIndex = 28
        Me.LblScroll3.Text = "Label3"
        '
        'LblScroll2
        '
        Me.LblScroll2.AutoSize = True
        Me.LblScroll2.BackColor = System.Drawing.Color.Transparent
        Me.LblScroll2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblScroll2.ForeColor = System.Drawing.Color.White
        Me.LblScroll2.Location = New System.Drawing.Point(781, 82)
        Me.LblScroll2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblScroll2.Name = "LblScroll2"
        Me.LblScroll2.Size = New System.Drawing.Size(101, 31)
        Me.LblScroll2.TabIndex = 27
        Me.LblScroll2.Text = "Label2"
        '
        'LblScroll1
        '
        Me.LblScroll1.AutoSize = True
        Me.LblScroll1.BackColor = System.Drawing.Color.Transparent
        Me.LblScroll1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblScroll1.ForeColor = System.Drawing.Color.White
        Me.LblScroll1.Location = New System.Drawing.Point(781, 42)
        Me.LblScroll1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblScroll1.Name = "LblScroll1"
        Me.LblScroll1.Size = New System.Drawing.Size(101, 31)
        Me.LblScroll1.TabIndex = 26
        Me.LblScroll1.Text = "Label1"
        '
        'PicFlyer
        '
        Me.PicFlyer.BackColor = System.Drawing.Color.White
        Me.PicFlyer.Location = New System.Drawing.Point(787, 316)
        Me.PicFlyer.Name = "PicFlyer"
        Me.PicFlyer.Size = New System.Drawing.Size(100, 50)
        Me.PicFlyer.TabIndex = 35
        Me.PicFlyer.TabStop = False
        '
        'PanInfo1
        '
        Me.PanInfo1.BackColor = System.Drawing.Color.White
        Me.PanInfo1.Location = New System.Drawing.Point(134, 413)
        Me.PanInfo1.Margin = New System.Windows.Forms.Padding(1)
        Me.PanInfo1.Name = "PanInfo1"
        Me.PanInfo1.Size = New System.Drawing.Size(500, 20)
        Me.PanInfo1.TabIndex = 31
        '
        'PanInfo4
        '
        Me.PanInfo4.BackColor = System.Drawing.Color.White
        Me.PanInfo4.Location = New System.Drawing.Point(134, 381)
        Me.PanInfo4.Margin = New System.Windows.Forms.Padding(1)
        Me.PanInfo4.Name = "PanInfo4"
        Me.PanInfo4.Size = New System.Drawing.Size(500, 20)
        Me.PanInfo4.TabIndex = 34
        '
        'PanInfo3
        '
        Me.PanInfo3.BackColor = System.Drawing.Color.White
        Me.PanInfo3.Location = New System.Drawing.Point(134, 346)
        Me.PanInfo3.Margin = New System.Windows.Forms.Padding(1)
        Me.PanInfo3.Name = "PanInfo3"
        Me.PanInfo3.Size = New System.Drawing.Size(500, 20)
        Me.PanInfo3.TabIndex = 33
        '
        'CmdRestart
        '
        Me.CmdRestart.Location = New System.Drawing.Point(13, 23)
        Me.CmdRestart.Name = "CmdRestart"
        Me.CmdRestart.Size = New System.Drawing.Size(70, 30)
        Me.CmdRestart.TabIndex = 37
        Me.CmdRestart.Text = "&Restart"
        Me.CmdRestart.UseVisualStyleBackColor = True
        '
        'TimTime
        '
        Me.TimTime.Interval = 10000
        '
        'PicMask4
        '
        Me.PicMask4.BackColor = System.Drawing.Color.White
        Me.PicMask4.Location = New System.Drawing.Point(645, 114)
        Me.PicMask4.Name = "PicMask4"
        Me.PicMask4.Size = New System.Drawing.Size(100, 50)
        Me.PicMask4.TabIndex = 42
        Me.PicMask4.TabStop = False
        '
        'PicMask2
        '
        Me.PicMask2.BackColor = System.Drawing.Color.White
        Me.PicMask2.Location = New System.Drawing.Point(514, 112)
        Me.PicMask2.Name = "PicMask2"
        Me.PicMask2.Size = New System.Drawing.Size(100, 50)
        Me.PicMask2.TabIndex = 41
        Me.PicMask2.TabStop = False
        '
        'PicMask3
        '
        Me.PicMask3.BackColor = System.Drawing.Color.White
        Me.PicMask3.Location = New System.Drawing.Point(645, 42)
        Me.PicMask3.Name = "PicMask3"
        Me.PicMask3.Size = New System.Drawing.Size(100, 50)
        Me.PicMask3.TabIndex = 40
        Me.PicMask3.TabStop = False
        '
        'PicMask1
        '
        Me.PicMask1.BackColor = System.Drawing.Color.White
        Me.PicMask1.Location = New System.Drawing.Point(514, 42)
        Me.PicMask1.Name = "PicMask1"
        Me.PicMask1.Size = New System.Drawing.Size(100, 50)
        Me.PicMask1.TabIndex = 39
        Me.PicMask1.TabStop = False
        '
        'PicMask
        '
        Me.PicMask.BackColor = System.Drawing.Color.White
        Me.PicMask.Location = New System.Drawing.Point(123, 33)
        Me.PicMask.Name = "PicMask"
        Me.PicMask.Size = New System.Drawing.Size(100, 50)
        Me.PicMask.TabIndex = 38
        Me.PicMask.TabStop = False
        '
        'CmdQuit
        '
        Me.CmdQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdQuit.Location = New System.Drawing.Point(13, 60)
        Me.CmdQuit.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdQuit.Name = "CmdQuit"
        Me.CmdQuit.Size = New System.Drawing.Size(69, 32)
        Me.CmdQuit.TabIndex = 29
        Me.CmdQuit.Text = "&Quit"
        Me.CmdQuit.UseVisualStyleBackColor = True
        '
        'TimScroll
        '
        Me.TimScroll.Interval = 1
        '
        'TimInfo
        '
        Me.TimInfo.Interval = 1
        '
        'PanInfo2
        '
        Me.PanInfo2.BackColor = System.Drawing.Color.White
        Me.PanInfo2.Location = New System.Drawing.Point(134, 444)
        Me.PanInfo2.Margin = New System.Windows.Forms.Padding(1)
        Me.PanInfo2.Name = "PanInfo2"
        Me.PanInfo2.Size = New System.Drawing.Size(500, 20)
        Me.PanInfo2.TabIndex = 32
        '
        'TimTimetable
        '
        Me.TimTimetable.Interval = 1
        '
        'TimProblem
        '
        Me.TimProblem.Interval = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1144, 552)
        Me.Controls.Add(Me.PicMaskS2)
        Me.Controls.Add(Me.PicMaskS1)
        Me.Controls.Add(Me.LblPhoto)
        Me.Controls.Add(Me.LblDate)
        Me.Controls.Add(Me.LblClock)
        Me.Controls.Add(Me.LblScroll3)
        Me.Controls.Add(Me.LblScroll2)
        Me.Controls.Add(Me.LblScroll1)
        Me.Controls.Add(Me.PicFlyer)
        Me.Controls.Add(Me.PicMask4)
        Me.Controls.Add(Me.PicMask2)
        Me.Controls.Add(Me.PicMask3)
        Me.Controls.Add(Me.PicMask1)
        Me.Controls.Add(Me.PanInfo1)
        Me.Controls.Add(Me.PanInfo4)
        Me.Controls.Add(Me.PanInfo3)
        Me.Controls.Add(Me.PanInfo2)
        Me.Controls.Add(Me.PicMask)
        Me.Controls.Add(Me.CmdRestart)
        Me.Controls.Add(Me.CmdQuit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PicMaskS2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicMaskS1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicFlyer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicMask4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicMask2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicMask3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicMask1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicMask, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TimResize As Timer
    Friend WithEvents TimForm2 As Timer
    Friend WithEvents PicMaskS2 As PictureBox
    Friend WithEvents PicMaskS1 As PictureBox
    Friend WithEvents LblPhoto As Label
    Friend WithEvents TimPhoto As Timer
    Friend WithEvents LblDate As Label
    Friend WithEvents LblClock As Label
    Friend WithEvents LblScroll3 As Label
    Friend WithEvents LblScroll2 As Label
    Friend WithEvents LblScroll1 As Label
    Friend WithEvents PicFlyer As PictureBox
    Friend WithEvents PanInfo1 As Panel
    Friend WithEvents PanInfo4 As Panel
    Friend WithEvents PanInfo3 As Panel
    Friend WithEvents CmdRestart As Button
    Friend WithEvents TimTime As Timer
    Friend WithEvents PicMask4 As PictureBox
    Friend WithEvents PicMask2 As PictureBox
    Friend WithEvents PicMask3 As PictureBox
    Friend WithEvents PicMask1 As PictureBox
    Friend WithEvents PicMask As PictureBox
    Friend WithEvents CmdQuit As Button
    Friend WithEvents TimScroll As Timer
    Friend WithEvents TimInfo As Timer
    Friend WithEvents PanInfo2 As Panel
    Friend WithEvents TimTimetable As Timer
    Friend WithEvents TimProblem As Timer
End Class
