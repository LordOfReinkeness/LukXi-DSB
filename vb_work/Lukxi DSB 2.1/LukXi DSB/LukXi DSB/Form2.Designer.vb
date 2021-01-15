<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PicBack = New System.Windows.Forms.PictureBox()
        Me.PicMed = New System.Windows.Forms.PictureBox()
        CType(Me.PicBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicMed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'PicBack
        '
        Me.PicBack.Location = New System.Drawing.Point(28, 27)
        Me.PicBack.Name = "PicBack"
        Me.PicBack.Size = New System.Drawing.Size(100, 50)
        Me.PicBack.TabIndex = 0
        Me.PicBack.TabStop = False
        '
        'PicMed
        '
        Me.PicMed.Location = New System.Drawing.Point(190, 27)
        Me.PicMed.Name = "PicMed"
        Me.PicMed.Size = New System.Drawing.Size(100, 50)
        Me.PicMed.TabIndex = 1
        Me.PicMed.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PicMed)
        Me.Controls.Add(Me.PicBack)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.PicBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicMed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents PicBack As PictureBox
    Friend WithEvents PicMed As PictureBox
End Class
