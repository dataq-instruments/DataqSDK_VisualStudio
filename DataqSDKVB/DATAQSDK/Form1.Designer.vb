<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Start = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.AxDataqSdk1 = New AxDATAQSDKLib.AxDataqSdk()
        Me.AxUltimaMeter1 = New AxULTIMAMETERLib.AxUltimaMeter()
        Me.AxFFT10241 = New AxFFT1024Lib.AxFFT1024()
        Me.AxUltimaWaterfall1 = New AxULTIMAWATERFALLLib.AxUltimaWaterfall()
        Me.AxXChart1 = New AxXCHARTLib.AxXChart()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.AxUltimaMeter2 = New AxULTIMAMETERLib.AxUltimaMeter()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        CType(Me.AxDataqSdk1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxUltimaMeter1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxFFT10241, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxUltimaWaterfall1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxXChart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxUltimaMeter2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Start
        '
        Me.Start.Location = New System.Drawing.Point(745, 174)
        Me.Start.Name = "Start"
        Me.Start.Size = New System.Drawing.Size(75, 23)
        Me.Start.TabIndex = 2
        Me.Start.Text = "Start"
        Me.Start.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(843, 174)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Stop"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'AxDataqSdk1
        '
        Me.AxDataqSdk1.Enabled = True
        Me.AxDataqSdk1.Location = New System.Drawing.Point(872, 70)
        Me.AxDataqSdk1.Name = "AxDataqSdk1"
        Me.AxDataqSdk1.OcxState = CType(resources.GetObject("AxDataqSdk1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxDataqSdk1.Size = New System.Drawing.Size(20, 23)
        Me.AxDataqSdk1.TabIndex = 1
        '
        'AxUltimaMeter1
        '
        Me.AxUltimaMeter1.Enabled = True
        Me.AxUltimaMeter1.Location = New System.Drawing.Point(530, 12)
        Me.AxUltimaMeter1.Name = "AxUltimaMeter1"
        Me.AxUltimaMeter1.OcxState = CType(resources.GetObject("AxUltimaMeter1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxUltimaMeter1.Size = New System.Drawing.Size(187, 201)
        Me.AxUltimaMeter1.TabIndex = 4
        '
        'AxFFT10241
        '
        Me.AxFFT10241.Enabled = True
        Me.AxFFT10241.Location = New System.Drawing.Point(888, 41)
        Me.AxFFT10241.Name = "AxFFT10241"
        Me.AxFFT10241.OcxState = CType(resources.GetObject("AxFFT10241.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxFFT10241.Size = New System.Drawing.Size(30, 23)
        Me.AxFFT10241.TabIndex = 5
        Me.AxFFT10241.Visible = False
        '
        'AxUltimaWaterfall1
        '
        Me.AxUltimaWaterfall1.Enabled = True
        Me.AxUltimaWaterfall1.Location = New System.Drawing.Point(12, 219)
        Me.AxUltimaWaterfall1.Name = "AxUltimaWaterfall1"
        Me.AxUltimaWaterfall1.OcxState = CType(resources.GetObject("AxUltimaWaterfall1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxUltimaWaterfall1.Size = New System.Drawing.Size(725, 308)
        Me.AxUltimaWaterfall1.TabIndex = 6
        '
        'AxXChart1
        '
        Me.AxXChart1.Enabled = True
        Me.AxXChart1.Location = New System.Drawing.Point(12, 12)
        Me.AxXChart1.Name = "AxXChart1"
        Me.AxXChart1.OcxState = CType(resources.GetObject("AxXChart1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxXChart1.Size = New System.Drawing.Size(512, 201)
        Me.AxXChart1.TabIndex = 7
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(743, 27)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(140, 20)
        Me.TextBox1.TabIndex = 8
        Me.TextBox1.Text = "di104nt.dll"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(740, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "DataqSDK DevieDriver"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(743, 66)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(140, 20)
        Me.TextBox2.TabIndex = 10
        Me.TextBox2.Text = "com4 145 9600"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(740, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "DeviceID"
        '
        'Timer2
        '
        '
        'AxUltimaMeter2
        '
        Me.AxUltimaMeter2.Enabled = True
        Me.AxUltimaMeter2.Location = New System.Drawing.Point(743, 219)
        Me.AxUltimaMeter2.Name = "AxUltimaMeter2"
        Me.AxUltimaMeter2.OcxState = CType(resources.GetObject("AxUltimaMeter2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxUltimaMeter2.Size = New System.Drawing.Size(175, 181)
        Me.AxUltimaMeter2.TabIndex = 12
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(745, 110)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(75, 20)
        Me.TextBox3.TabIndex = 13
        Me.TextBox3.Text = "200"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(742, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Sample Rate"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(752, 395)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(45, 17)
        Me.RadioButton1.TabIndex = 15
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "B2T"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Checked = True
        Me.RadioButton2.Location = New System.Drawing.Point(752, 418)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(40, 17)
        Me.RadioButton2.TabIndex = 16
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "-45"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(752, 441)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(37, 17)
        Me.RadioButton3.TabIndex = 17
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "45"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Enabled = False
        Me.RadioButton4.Location = New System.Drawing.Point(752, 510)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(45, 17)
        Me.RadioButton4.TabIndex = 18
        Me.RadioButton4.Text = "R2L"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(752, 464)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(45, 17)
        Me.RadioButton5.TabIndex = 19
        Me.RadioButton5.Text = "T2B"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Enabled = False
        Me.RadioButton6.Location = New System.Drawing.Point(752, 487)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(47, 17)
        Me.RadioButton6.TabIndex = 20
        Me.RadioButton6.Text = "iR2L"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(831, 510)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(40, 17)
        Me.CheckBox1.TabIndex = 21
        Me.CheckBox1.Text = "3D"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(926, 537)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.RadioButton6)
        Me.Controls.Add(Me.RadioButton5)
        Me.Controls.Add(Me.RadioButton4)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.AxUltimaMeter2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.AxXChart1)
        Me.Controls.Add(Me.AxUltimaWaterfall1)
        Me.Controls.Add(Me.AxFFT10241)
        Me.Controls.Add(Me.AxUltimaMeter1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Start)
        Me.Controls.Add(Me.AxDataqSdk1)
        Me.Name = "Form1"
        Me.Text = "DataqSDK demo"
        CType(Me.AxDataqSdk1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxUltimaMeter1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxFFT10241, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxUltimaWaterfall1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxXChart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxUltimaMeter2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AxDataqSdk1 As AxDATAQSDKLib.AxDataqSdk
    Friend WithEvents Start As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents AxUltimaMeter1 As AxULTIMAMETERLib.AxUltimaMeter
    Friend WithEvents AxFFT10241 As AxFFT1024Lib.AxFFT1024
    Friend WithEvents AxUltimaWaterfall1 As AxULTIMAWATERFALLLib.AxUltimaWaterfall
    Friend WithEvents AxXChart1 As AxXCHARTLib.AxXChart
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents AxUltimaMeter2 As AxULTIMAMETERLib.AxUltimaMeter
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton6 As System.Windows.Forms.RadioButton
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox

End Class
