<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DepFull
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
        Me.PicMed = New System.Windows.Forms.PictureBox()
        Me.PicBack = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.CmdQuit = New System.Windows.Forms.Button()
        CType(Me.PicMed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PicMed
        '
        Me.PicMed.Location = New System.Drawing.Point(304, 48)
        Me.PicMed.Name = "PicMed"
        Me.PicMed.Size = New System.Drawing.Size(100, 50)
        Me.PicMed.TabIndex = 3
        Me.PicMed.TabStop = False
        '
        'PicBack
        '
        Me.PicBack.Location = New System.Drawing.Point(142, 48)
        Me.PicBack.Name = "PicBack"
        Me.PicBack.Size = New System.Drawing.Size(100, 50)
        Me.PicBack.TabIndex = 2
        Me.PicBack.TabStop = False
        '
        'Timer1
        '
        '
        'CmdQuit
        '
        Me.CmdQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdQuit.Location = New System.Drawing.Point(13, 13)
        Me.CmdQuit.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdQuit.Name = "CmdQuit"
        Me.CmdQuit.Size = New System.Drawing.Size(69, 32)
        Me.CmdQuit.TabIndex = 50
        Me.CmdQuit.Text = "&Quit"
        Me.CmdQuit.UseVisualStyleBackColor = True
        '
        'DepFull
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CmdQuit)
        Me.Controls.Add(Me.PicMed)
        Me.Controls.Add(Me.PicBack)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DepFull"
        Me.Text = "Form2"
        CType(Me.PicMed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PicMed As PictureBox
    Friend WithEvents PicBack As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents CmdQuit As Button
End Class
