<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSettings
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TrkForm1dur = New System.Windows.Forms.TrackBar()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ChkForm2 = New System.Windows.Forms.CheckBox()
        Me.TrkForm2dur = New System.Windows.Forms.TrackBar()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TxtSpeedScroll = New System.Windows.Forms.TextBox()
        Me.TxtSpeedInf = New System.Windows.Forms.TextBox()
        Me.TxtSpeedPic = New System.Windows.Forms.TextBox()
        Me.TxtSpeedTime = New System.Windows.Forms.TextBox()
        Me.LblSpeedScroll = New System.Windows.Forms.Label()
        Me.LblSpeedInf = New System.Windows.Forms.Label()
        Me.LblSpeedTime = New System.Windows.Forms.Label()
        Me.TrkSpeedTimetable = New System.Windows.Forms.TrackBar()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TrkSpeedPhotos = New System.Windows.Forms.TrackBar()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TrkSpeedInfo = New System.Windows.Forms.TrackBar()
        Me.TrkSpeedScroll = New System.Windows.Forms.TrackBar()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Fotos = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LblSpeedPic = New System.Windows.Forms.Label()
        Me.CmbTime2 = New System.Windows.Forms.ComboBox()
        Me.CmbTime1 = New System.Windows.Forms.ComboBox()
        Me.ChkPcOff = New System.Windows.Forms.CheckBox()
        Me.ChkPgmOff = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TxtForm1Dur = New System.Windows.Forms.TextBox()
        Me.TxtForm2Dur = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CmdClose = New System.Windows.Forms.Button()
        Me.CmdSave = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        CType(Me.TrkForm1dur, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrkForm2dur, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.TrkSpeedTimetable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrkSpeedPhotos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrkSpeedInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrkSpeedScroll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(89, 233)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(178, 16)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Infotext Geschwindigkeit:"
        '
        'TrkForm1dur
        '
        Me.TrkForm1dur.LargeChange = 50
        Me.TrkForm1dur.Location = New System.Drawing.Point(76, 133)
        Me.TrkForm1dur.Maximum = 300
        Me.TrkForm1dur.Minimum = 1
        Me.TrkForm1dur.Name = "TrkForm1dur"
        Me.TrkForm1dur.Size = New System.Drawing.Size(217, 45)
        Me.TrkForm1dur.SmallChange = 10
        Me.TrkForm1dur.TabIndex = 54
        Me.TrkForm1dur.Value = 60
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(104, 18)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(170, 16)
        Me.Label12.TabIndex = 53
        Me.Label12.Text = "Anzeigerdauer Vollbild:"
        '
        'ChkForm2
        '
        Me.ChkForm2.AutoSize = True
        Me.ChkForm2.Location = New System.Drawing.Point(432, 12)
        Me.ChkForm2.Name = "ChkForm2"
        Me.ChkForm2.Size = New System.Drawing.Size(131, 17)
        Me.ChkForm2.TabIndex = 94
        Me.ChkForm2.Text = "Große Bilder Anzeigen"
        Me.ChkForm2.UseVisualStyleBackColor = True
        '
        'TrkForm2dur
        '
        Me.TrkForm2dur.LargeChange = 50
        Me.TrkForm2dur.Location = New System.Drawing.Point(75, 40)
        Me.TrkForm2dur.Maximum = 60
        Me.TrkForm2dur.Minimum = 1
        Me.TrkForm2dur.Name = "TrkForm2dur"
        Me.TrkForm2dur.Size = New System.Drawing.Size(217, 45)
        Me.TrkForm2dur.SmallChange = 10
        Me.TrkForm2dur.TabIndex = 49
        Me.TrkForm2dur.Value = 60
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.TxtSpeedScroll)
        Me.Panel1.Controls.Add(Me.TxtSpeedInf)
        Me.Panel1.Controls.Add(Me.TxtSpeedPic)
        Me.Panel1.Controls.Add(Me.TxtSpeedTime)
        Me.Panel1.Controls.Add(Me.LblSpeedScroll)
        Me.Panel1.Controls.Add(Me.LblSpeedInf)
        Me.Panel1.Controls.Add(Me.LblSpeedTime)
        Me.Panel1.Controls.Add(Me.TrkSpeedTimetable)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.TrkSpeedPhotos)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.TrkSpeedInfo)
        Me.Panel1.Controls.Add(Me.TrkSpeedScroll)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Fotos)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(351, 427)
        Me.Panel1.TabIndex = 92
        '
        'TxtSpeedScroll
        '
        Me.TxtSpeedScroll.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.TxtSpeedScroll.Location = New System.Drawing.Point(216, 373)
        Me.TxtSpeedScroll.Name = "TxtSpeedScroll"
        Me.TxtSpeedScroll.Size = New System.Drawing.Size(25, 22)
        Me.TxtSpeedScroll.TabIndex = 54
        Me.TxtSpeedScroll.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtSpeedInf
        '
        Me.TxtSpeedInf.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.TxtSpeedInf.Location = New System.Drawing.Point(216, 280)
        Me.TxtSpeedInf.Name = "TxtSpeedInf"
        Me.TxtSpeedInf.Size = New System.Drawing.Size(25, 22)
        Me.TxtSpeedInf.TabIndex = 53
        Me.TxtSpeedInf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtSpeedPic
        '
        Me.TxtSpeedPic.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.TxtSpeedPic.Location = New System.Drawing.Point(148, 193)
        Me.TxtSpeedPic.Name = "TxtSpeedPic"
        Me.TxtSpeedPic.Size = New System.Drawing.Size(25, 22)
        Me.TxtSpeedPic.TabIndex = 52
        Me.TxtSpeedPic.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtSpeedTime
        '
        Me.TxtSpeedTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.TxtSpeedTime.Location = New System.Drawing.Point(216, 91)
        Me.TxtSpeedTime.Name = "TxtSpeedTime"
        Me.TxtSpeedTime.Size = New System.Drawing.Size(25, 22)
        Me.TxtSpeedTime.TabIndex = 51
        Me.TxtSpeedTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblSpeedScroll
        '
        Me.LblSpeedScroll.AutoSize = True
        Me.LblSpeedScroll.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSpeedScroll.Location = New System.Drawing.Point(103, 374)
        Me.LblSpeedScroll.Name = "LblSpeedScroll"
        Me.LblSpeedScroll.Size = New System.Drawing.Size(106, 16)
        Me.LblSpeedScroll.TabIndex = 41
        Me.LblSpeedScroll.Text = "Geschwindigkeit"
        '
        'LblSpeedInf
        '
        Me.LblSpeedInf.AutoSize = True
        Me.LblSpeedInf.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSpeedInf.Location = New System.Drawing.Point(103, 281)
        Me.LblSpeedInf.Name = "LblSpeedInf"
        Me.LblSpeedInf.Size = New System.Drawing.Size(106, 16)
        Me.LblSpeedInf.TabIndex = 44
        Me.LblSpeedInf.Text = "Geschwindigkeit"
        '
        'LblSpeedTime
        '
        Me.LblSpeedTime.AutoSize = True
        Me.LblSpeedTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSpeedTime.Location = New System.Drawing.Point(103, 92)
        Me.LblSpeedTime.Name = "LblSpeedTime"
        Me.LblSpeedTime.Size = New System.Drawing.Size(106, 16)
        Me.LblSpeedTime.TabIndex = 30
        Me.LblSpeedTime.Text = "Geschwindigkeit"
        '
        'TrkSpeedTimetable
        '
        Me.TrkSpeedTimetable.Location = New System.Drawing.Point(66, 56)
        Me.TrkSpeedTimetable.Maximum = 30
        Me.TrkSpeedTimetable.Minimum = 1
        Me.TrkSpeedTimetable.Name = "TrkSpeedTimetable"
        Me.TrkSpeedTimetable.Size = New System.Drawing.Size(217, 45)
        Me.TrkSpeedTimetable.TabIndex = 27
        Me.TrkSpeedTimetable.Value = 30
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(45, 61)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(15, 16)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "1"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(289, 61)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(22, 16)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "30"
        '
        'TrkSpeedPhotos
        '
        Me.TrkSpeedPhotos.LargeChange = 50
        Me.TrkSpeedPhotos.Location = New System.Drawing.Point(66, 152)
        Me.TrkSpeedPhotos.Maximum = 60
        Me.TrkSpeedPhotos.Minimum = 1
        Me.TrkSpeedPhotos.Name = "TrkSpeedPhotos"
        Me.TrkSpeedPhotos.Size = New System.Drawing.Size(217, 45)
        Me.TrkSpeedPhotos.SmallChange = 10
        Me.TrkSpeedPhotos.TabIndex = 31
        Me.TrkSpeedPhotos.Value = 60
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(26, 160)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(25, 16)
        Me.Label13.TabIndex = 33
        Me.Label13.Text = "1 s"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(289, 160)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(32, 16)
        Me.Label14.TabIndex = 34
        Me.Label14.Text = "60 s"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(45, 261)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(15, 16)
        Me.Label18.TabIndex = 37
        Me.Label18.Text = "1"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(289, 261)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(22, 16)
        Me.Label19.TabIndex = 38
        Me.Label19.Text = "30"
        '
        'TrkSpeedInfo
        '
        Me.TrkSpeedInfo.Location = New System.Drawing.Point(66, 252)
        Me.TrkSpeedInfo.Maximum = 30
        Me.TrkSpeedInfo.Minimum = 1
        Me.TrkSpeedInfo.Name = "TrkSpeedInfo"
        Me.TrkSpeedInfo.Size = New System.Drawing.Size(217, 45)
        Me.TrkSpeedInfo.TabIndex = 39
        Me.TrkSpeedInfo.Value = 1
        '
        'TrkSpeedScroll
        '
        Me.TrkSpeedScroll.Location = New System.Drawing.Point(71, 345)
        Me.TrkSpeedScroll.Maximum = 30
        Me.TrkSpeedScroll.Minimum = 1
        Me.TrkSpeedScroll.Name = "TrkSpeedScroll"
        Me.TrkSpeedScroll.Size = New System.Drawing.Size(217, 45)
        Me.TrkSpeedScroll.TabIndex = 40
        Me.TrkSpeedScroll.Value = 1
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(45, 350)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(15, 16)
        Me.Label16.TabIndex = 42
        Me.Label16.Text = "1"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(289, 350)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(22, 16)
        Me.Label17.TabIndex = 43
        Me.Label17.Text = "30"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(68, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(215, 16)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Stundenplan Geschwindigkeit:"
        '
        'Fotos
        '
        Me.Fotos.AutoSize = True
        Me.Fotos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fotos.Location = New System.Drawing.Point(103, 130)
        Me.Fotos.Name = "Fotos"
        Me.Fotos.Size = New System.Drawing.Size(151, 16)
        Me.Fotos.TabIndex = 48
        Me.Fotos.Text = "Anzeigedauer Fotos:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(59, 326)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(240, 16)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Scrollbandarole Geschwindigkeit:"
        '
        'LblSpeedPic
        '
        Me.LblSpeedPic.AutoSize = True
        Me.LblSpeedPic.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSpeedPic.Location = New System.Drawing.Point(197, 173)
        Me.LblSpeedPic.Name = "LblSpeedPic"
        Me.LblSpeedPic.Size = New System.Drawing.Size(15, 16)
        Me.LblSpeedPic.TabIndex = 32
        Me.LblSpeedPic.Text = "s"
        '
        'CmbTime2
        '
        Me.CmbTime2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbTime2.FormattingEnabled = True
        Me.CmbTime2.Items.AddRange(New Object() {"00", "15", "30", "45"})
        Me.CmbTime2.Location = New System.Drawing.Point(600, 325)
        Me.CmbTime2.Name = "CmbTime2"
        Me.CmbTime2.Size = New System.Drawing.Size(39, 21)
        Me.CmbTime2.TabIndex = 90
        '
        'CmbTime1
        '
        Me.CmbTime1.AllowDrop = True
        Me.CmbTime1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbTime1.FormattingEnabled = True
        Me.CmbTime1.Items.AddRange(New Object() {"00", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23"})
        Me.CmbTime1.Location = New System.Drawing.Point(555, 325)
        Me.CmbTime1.Name = "CmbTime1"
        Me.CmbTime1.Size = New System.Drawing.Size(39, 21)
        Me.CmbTime1.TabIndex = 89
        '
        'ChkPcOff
        '
        Me.ChkPcOff.AutoSize = True
        Me.ChkPcOff.Location = New System.Drawing.Point(471, 354)
        Me.ChkPcOff.Name = "ChkPcOff"
        Me.ChkPcOff.Size = New System.Drawing.Size(141, 17)
        Me.ChkPcOff.TabIndex = 88
        Me.ChkPcOff.Text = "Auch Pc Herunterfahren"
        Me.ChkPcOff.UseVisualStyleBackColor = True
        '
        'ChkPgmOff
        '
        Me.ChkPgmOff.AutoSize = True
        Me.ChkPgmOff.Location = New System.Drawing.Point(471, 299)
        Me.ChkPgmOff.Name = "ChkPgmOff"
        Me.ChkPgmOff.Size = New System.Drawing.Size(184, 17)
        Me.ChkPgmOff.TabIndex = 87
        Me.ChkPgmOff.Text = "Zu bestimmter Uhrzeit Auschalten"
        Me.ChkPgmOff.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(469, 328)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 86
        Me.Label2.Text = "Auschalten um:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(104, 107)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(183, 16)
        Me.Label22.TabIndex = 58
        Me.Label22.Text = "Zeit zwischen Vollbildern:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.TxtForm1Dur)
        Me.Panel2.Controls.Add(Me.TxtForm2Dur)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.LblSpeedPic)
        Me.Panel2.Controls.Add(Me.TrkForm1dur)
        Me.Panel2.Controls.Add(Me.Label22)
        Me.Panel2.Controls.Add(Me.TrkForm2dur)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Location = New System.Drawing.Point(432, 35)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(354, 215)
        Me.Panel2.TabIndex = 93
        '
        'TxtForm1Dur
        '
        Me.TxtForm1Dur.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.TxtForm1Dur.Location = New System.Drawing.Point(163, 170)
        Me.TxtForm1Dur.Name = "TxtForm1Dur"
        Me.TxtForm1Dur.Size = New System.Drawing.Size(28, 22)
        Me.TxtForm1Dur.TabIndex = 62
        Me.TxtForm1Dur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtForm2Dur
        '
        Me.TxtForm2Dur.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.TxtForm2Dur.Location = New System.Drawing.Point(163, 82)
        Me.TxtForm2Dur.Name = "TxtForm2Dur"
        Me.TxtForm2Dur.Size = New System.Drawing.Size(28, 22)
        Me.TxtForm2Dur.TabIndex = 55
        Me.TxtForm2Dur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(298, 48)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(32, 16)
        Me.Label11.TabIndex = 61
        Me.Label11.Text = "60 s"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(298, 137)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 16)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "300 s"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(44, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(25, 16)
        Me.Label7.TabIndex = 60
        Me.Label7.Text = "1 s"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(44, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 16)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "1 s"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(592, 329)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(11, 13)
        Me.Label6.TabIndex = 91
        Me.Label6.Text = ":"
        '
        'CmdClose
        '
        Me.CmdClose.Location = New System.Drawing.Point(403, 462)
        Me.CmdClose.Name = "CmdClose"
        Me.CmdClose.Size = New System.Drawing.Size(160, 50)
        Me.CmdClose.TabIndex = 81
        Me.CmdClose.Text = "Schließen"
        Me.CmdClose.UseVisualStyleBackColor = True
        '
        'CmdSave
        '
        Me.CmdSave.Location = New System.Drawing.Point(232, 463)
        Me.CmdSave.Name = "CmdSave"
        Me.CmdSave.Size = New System.Drawing.Size(160, 50)
        Me.CmdSave.TabIndex = 80
        Me.CmdSave.Text = "Speichern"
        Me.CmdSave.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(197, 85)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(15, 16)
        Me.Label15.TabIndex = 63
        Me.Label15.Text = "s"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(179, 196)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(15, 16)
        Me.Label20.TabIndex = 64
        Me.Label20.Text = "s"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 524)
        Me.Controls.Add(Me.ChkForm2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.CmbTime2)
        Me.Controls.Add(Me.CmbTime1)
        Me.Controls.Add(Me.ChkPcOff)
        Me.Controls.Add(Me.ChkPgmOff)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CmdClose)
        Me.Controls.Add(Me.CmdSave)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.TrkForm1dur, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrkForm2dur, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TrkSpeedTimetable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrkSpeedPhotos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrkSpeedInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrkSpeedScroll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents TrkForm1dur As TrackBar
    Friend WithEvents Label12 As Label
    Friend WithEvents ChkForm2 As CheckBox
    Friend WithEvents TrkForm2dur As TrackBar
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LblSpeedScroll As Label
    Friend WithEvents LblSpeedInf As Label
    Friend WithEvents LblSpeedPic As Label
    Friend WithEvents LblSpeedTime As Label
    Friend WithEvents TrkSpeedTimetable As TrackBar
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TrkSpeedPhotos As TrackBar
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents TrkSpeedInfo As TrackBar
    Friend WithEvents TrkSpeedScroll As TrackBar
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Fotos As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CmbTime2 As ComboBox
    Friend WithEvents CmbTime1 As ComboBox
    Friend WithEvents ChkPcOff As CheckBox
    Friend WithEvents ChkPgmOff As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents CmdClose As Button
    Friend WithEvents CmdSave As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtSpeedScroll As TextBox
    Friend WithEvents TxtSpeedInf As TextBox
    Friend WithEvents TxtSpeedPic As TextBox
    Friend WithEvents TxtSpeedTime As TextBox
    Friend WithEvents TxtForm1Dur As TextBox
    Friend WithEvents TxtForm2Dur As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label15 As Label
End Class
