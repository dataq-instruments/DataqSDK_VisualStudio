Public Class Form1
    Dim v(,) As Short
    Dim v2(,) As Short

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Start.Click
        AxDataqSdk1.DeviceDriver = TextBox1.Text
        AxDataqSdk1.DeviceID = TextBox2.Text
        AxDataqSdk1.SampleRate = Val(TextBox3.Text)
        AxDataqSdk1.ADChannelCount = 1
        AxDataqSdk1.EventPoint = 1

        AxDataqSdk1.Start()
        AxUltimaMeter2.MaxValue = AxDataqSdk1.SampleRate / 2
        TextBox3.Text = AxDataqSdk1.SampleRate
        Timer1.Interval = 10
        Timer1.Enabled = True
        Timer2.Interval = 50
        Timer2.Enabled = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        AxDataqSdk1.Stop()
        Timer1.Enabled = False
        Timer2.Enabled = False
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim dTemp As Double

        If AxDataqSdk1.AvailableData > 0 Then
            v = AxDataqSdk1.GetData
            AxXChart1.Chart(v)
            dTemp = Val(v(0, 0))
            AxUltimaMeter1.Value = dTemp / 3276.8

        End If

    End Sub
   

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AxUltimaMeter1.MinValue = -10
        AxUltimaMeter1.MaxValue = 10
        AxUltimaMeter2.MinValue = 0
        AxUltimaMeter2.Unit = "Peak Hz"
        AxUltimaWaterfall1.ChartType = ULTIMAWATERFALLLib.enumCharType.uw3D
        AxUltimaWaterfall1.ChartDirection = ULTIMAWATERFALLLib.enumCharDir.uwNSlope
        AxUltimaWaterfall1.ScalingMethod = ULTIMAWATERFALLLib.enumColorScale.uwBGR

    End Sub



    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Dim i As Short
        v2 = AxDataqSdk1.GetDataFrame(1024)
        For i = 0 To 1023
            AxFFT10241.SetWaveformPt(i, v2(0, i))
        Next i
        AxFFT10241.FFTNow(1024)
        AxUltimaWaterfall1.Chart(AxFFT10241.Power)
        AxUltimaMeter2.Value = AxUltimaMeter2.MaxValue * (AxFFT10241.GetPeakIdx() / 512)
    End Sub

    
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If Timer1.Enabled Then AxUltimaWaterfall1.ChartDirection = ULTIMAWATERFALLLib.enumCharDir.uwB2T
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If Timer1.Enabled Then
            If CheckBox1.CheckState = CheckState.Checked Then
                AxUltimaWaterfall1.ChartType = ULTIMAWATERFALLLib.enumCharType.uw3D
                RadioButton6.Enabled = False
                RadioButton4.Enabled = False
            Else
                AxUltimaWaterfall1.ChartType = ULTIMAWATERFALLLib.enumCharType.uw2D
                RadioButton6.Enabled = True
                RadioButton4.Enabled = True
            End If
        End If
    End Sub

    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged
        If Timer1.Enabled Then AxUltimaWaterfall1.ChartDirection = ULTIMAWATERFALLLib.enumCharDir.uwR2Lx
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If Timer1.Enabled Then AxUltimaWaterfall1.ChartDirection = ULTIMAWATERFALLLib.enumCharDir.uwNSlope
    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        If Timer1.Enabled Then AxUltimaWaterfall1.ChartDirection = ULTIMAWATERFALLLib.enumCharDir.uwT2B
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        If Timer1.Enabled Then AxUltimaWaterfall1.ChartDirection = ULTIMAWATERFALLLib.enumCharDir.uwSlope
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        If Timer1.Enabled Then AxUltimaWaterfall1.ChartDirection = ULTIMAWATERFALLLib.enumCharDir.uwR2L
    End Sub
End Class
