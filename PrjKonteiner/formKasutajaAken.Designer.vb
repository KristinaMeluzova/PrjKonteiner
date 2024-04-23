<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formKasutajaAken
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.txtSisendTekst = New System.Windows.Forms.TextBox()
        Me.SisendTekst = New System.Windows.Forms.Label()
        Me.txtValjundTekst1 = New System.Windows.Forms.TextBox()
        Me.valjund = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtValjundTekst2 = New System.Windows.Forms.TextBox()
        Me.btnPoora1 = New System.Windows.Forms.Button()
        Me.btnPoora2 = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.timerUuenda = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CAlgoCheck = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtSisendTekst
        '
        Me.txtSisendTekst.Location = New System.Drawing.Point(152, 88)
        Me.txtSisendTekst.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSisendTekst.Name = "txtSisendTekst"
        Me.txtSisendTekst.Size = New System.Drawing.Size(131, 20)
        Me.txtSisendTekst.TabIndex = 0
        '
        'SisendTekst
        '
        Me.SisendTekst.AutoSize = True
        Me.SisendTekst.Location = New System.Drawing.Point(72, 88)
        Me.SisendTekst.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.SisendTekst.Name = "SisendTekst"
        Me.SisendTekst.Size = New System.Drawing.Size(62, 13)
        Me.SisendTekst.TabIndex = 1
        Me.SisendTekst.Text = "Sisendtekst"
        '
        'txtValjundTekst1
        '
        Me.txtValjundTekst1.Location = New System.Drawing.Point(152, 142)
        Me.txtValjundTekst1.Margin = New System.Windows.Forms.Padding(2)
        Me.txtValjundTekst1.Name = "txtValjundTekst1"
        Me.txtValjundTekst1.ReadOnly = True
        Me.txtValjundTekst1.Size = New System.Drawing.Size(131, 20)
        Me.txtValjundTekst1.TabIndex = 2
        '
        'valjund
        '
        Me.valjund.AutoSize = True
        Me.valjund.Location = New System.Drawing.Point(11, 144)
        Me.valjund.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.valjund.Name = "valjund"
        Me.valjund.Size = New System.Drawing.Size(123, 13)
        Me.valjund.TabIndex = 3
        Me.valjund.Text = "Pööramine funktsiooniga"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 176)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Pöörame protseduuriga"
        '
        'txtValjundTekst2
        '
        Me.txtValjundTekst2.Location = New System.Drawing.Point(152, 172)
        Me.txtValjundTekst2.Margin = New System.Windows.Forms.Padding(2)
        Me.txtValjundTekst2.Name = "txtValjundTekst2"
        Me.txtValjundTekst2.ReadOnly = True
        Me.txtValjundTekst2.Size = New System.Drawing.Size(131, 20)
        Me.txtValjundTekst2.TabIndex = 5
        '
        'btnPoora1
        '
        Me.btnPoora1.Location = New System.Drawing.Point(117, 113)
        Me.btnPoora1.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPoora1.Name = "btnPoora1"
        Me.btnPoora1.Size = New System.Drawing.Size(200, 25)
        Me.btnPoora1.TabIndex = 6
        Me.btnPoora1.Text = "Pööra funktsiooniga"
        Me.btnPoora1.UseVisualStyleBackColor = True
        '
        'btnPoora2
        '
        Me.btnPoora2.Location = New System.Drawing.Point(145, 193)
        Me.btnPoora2.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPoora2.Name = "btnPoora2"
        Me.btnPoora2.Size = New System.Drawing.Size(151, 21)
        Me.btnPoora2.TabIndex = 7
        Me.btnPoora2.Text = "Pööra protseduuriga"
        Me.btnPoora2.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(69, 237)
        Me.btnStart.Margin = New System.Windows.Forms.Padding(2)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(151, 21)
        Me.btnStart.TabIndex = 8
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(232, 237)
        Me.btnStop.Margin = New System.Windows.Forms.Padding(2)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(151, 21)
        Me.btnStop.TabIndex = 9
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'timerUuenda
        '
        Me.timerUuenda.Interval = 5000
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(323, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "0"
        '
        'CAlgoCheck
        '
        Me.CAlgoCheck.AutoSize = True
        Me.CAlgoCheck.Location = New System.Drawing.Point(341, 140)
        Me.CAlgoCheck.Name = "CAlgoCheck"
        Me.CAlgoCheck.Size = New System.Drawing.Size(124, 17)
        Me.CAlgoCheck.TabIndex = 11
        Me.CAlgoCheck.Text = "CAlgoritmilinePooraja"
        Me.CAlgoCheck.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(392, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "0"
        '
        'formKasutajaAken
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 291)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CAlgoCheck)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.btnPoora2)
        Me.Controls.Add(Me.btnPoora1)
        Me.Controls.Add(Me.txtValjundTekst2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.valjund)
        Me.Controls.Add(Me.txtValjundTekst1)
        Me.Controls.Add(Me.SisendTekst)
        Me.Controls.Add(Me.txtSisendTekst)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "formKasutajaAken"
        Me.Text = "formKasutajaAken"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSisendTekst As TextBox
    Friend WithEvents SisendTekst As Label
    Friend WithEvents txtValjundTekst1 As TextBox
    Friend WithEvents valjund As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtValjundTekst2 As TextBox
    Friend WithEvents btnPoora1 As Button
    Friend WithEvents btnPoora2 As Button
    Friend WithEvents btnStart As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents timerUuenda As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents CAlgoCheck As CheckBox
    Friend WithEvents Label3 As Label
End Class
