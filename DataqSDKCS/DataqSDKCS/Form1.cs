using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataqSDKCS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            axDataqSdk1.DeviceDriver=textBox1.Text;

            axDataqSdk1.DeviceID=textBox2.Text;

            axUltimaMeter1.MaxValue=10;

            axUltimaMeter1.MinValue=-10;

 

            axDataqSdk1.SampleRate=Convert.ToDouble(textBox3.Text);

            axUltimaWaterfall1.ChartType = ULTIMAWATERFALLLib.enumCharType.uw3D;

            axUltimaWaterfall1.ChartDirection = ULTIMAWATERFALLLib.enumCharDir.uwSlope;

            axDataqSdk1.EventPoint=1;

            timer1.Interval=10;

            timer1.Enabled = true;

            timer2.Interval=50;

            timer2.Enabled = true; 

            axDataqSdk1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            axDataqSdk1.Stop();
        }

        private void axDataqSdk1_NewData(object sender, AxDATAQSDKLib._DDataqSdkEvents_NewDataEvent e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (axDataqSdk1.AvailableData > 0)
            {
                object V;
                short[,] intArray;
                V = axDataqSdk1.GetData();
                axXChart1.Chart(V);

                intArray = (short[,])V;
                axUltimaMeter1.Value = intArray[0, 0]/3276.8;
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            object V;
            short[,] intArray;
            short i;

            V = axDataqSdk1.GetDataFrame(1024);
            intArray = (short[,])V;

            for (i=0; i<1024; i++){
                axFFT10241.SetWaveformPt(i, intArray[0, i]);
            }

            axFFT10241.FFTNow(1024);

            axUltimaWaterfall1.Chart(axFFT10241.Power());

        }

        private void axDataqSdk1_ControlError(object sender, AxDATAQSDKLib._DDataqSdkEvents_ControlErrorEvent e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            axDataqSdk1.Stop();
            MessageBox.Show("Error: Please check DeviceDriver and DeviceID");
        }
    }
}
