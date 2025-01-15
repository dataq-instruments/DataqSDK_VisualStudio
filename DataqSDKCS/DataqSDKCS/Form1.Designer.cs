namespace DataqSDKCS
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axXChart1 = new AxXCHARTLib.AxXChart();
            this.axUltimaWaterfall1 = new AxULTIMAWATERFALLLib.AxUltimaWaterfall();
            this.axUltimaMeter1 = new AxULTIMAMETERLib.AxUltimaMeter();
            this.axFFT10241 = new AxFFT1024Lib.AxFFT1024();
            this.axDataqSdk1 = new AxDATAQSDKLib.AxDataqSdk();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.axXChart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axUltimaWaterfall1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axUltimaMeter1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axFFT10241)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axDataqSdk1)).BeginInit();
            this.SuspendLayout();
            // 
            // axXChart1
            // 
            this.axXChart1.Enabled = true;
            this.axXChart1.Location = new System.Drawing.Point(0, 2);
            this.axXChart1.Name = "axXChart1";
            this.axXChart1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axXChart1.OcxState")));
            this.axXChart1.Size = new System.Drawing.Size(602, 212);
            this.axXChart1.TabIndex = 0;
            // 
            // axUltimaWaterfall1
            // 
            this.axUltimaWaterfall1.Enabled = true;
            this.axUltimaWaterfall1.Location = new System.Drawing.Point(0, 220);
            this.axUltimaWaterfall1.Name = "axUltimaWaterfall1";
            this.axUltimaWaterfall1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axUltimaWaterfall1.OcxState")));
            this.axUltimaWaterfall1.Size = new System.Drawing.Size(654, 275);
            this.axUltimaWaterfall1.TabIndex = 1;
            // 
            // axUltimaMeter1
            // 
            this.axUltimaMeter1.Enabled = true;
            this.axUltimaMeter1.Location = new System.Drawing.Point(608, 2);
            this.axUltimaMeter1.Name = "axUltimaMeter1";
            this.axUltimaMeter1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axUltimaMeter1.OcxState")));
            this.axUltimaMeter1.Size = new System.Drawing.Size(195, 212);
            this.axUltimaMeter1.TabIndex = 2;
            // 
            // axFFT10241
            // 
            this.axFFT10241.Enabled = true;
            this.axFFT10241.Location = new System.Drawing.Point(426, 99);
            this.axFFT10241.Name = "axFFT10241";
            this.axFFT10241.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axFFT10241.OcxState")));
            this.axFFT10241.Size = new System.Drawing.Size(100, 50);
            this.axFFT10241.TabIndex = 3;
            // 
            // axDataqSdk1
            // 
            this.axDataqSdk1.Enabled = true;
            this.axDataqSdk1.Location = new System.Drawing.Point(764, 26);
            this.axDataqSdk1.Name = "axDataqSdk1";
            this.axDataqSdk1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axDataqSdk1.OcxState")));
            this.axDataqSdk1.Size = new System.Drawing.Size(100, 50);
            this.axDataqSdk1.TabIndex = 4;
            this.axDataqSdk1.NewData += new AxDATAQSDKLib._DDataqSdkEvents_NewDataEventHandler(this.axDataqSdk1_NewData);
            this.axDataqSdk1.ControlError += new AxDATAQSDKLib._DDataqSdkEvents_ControlErrorEventHandler(this.axDataqSdk1_ControlError);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(660, 454);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 31);
            this.button1.TabIndex = 5;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(755, 455);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 30);
            this.button2.TabIndex = 6;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(679, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "DataqSDK DeviceDriver";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(677, 238);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "DI104NT.DLL";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(677, 287);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(140, 20);
            this.textBox2.TabIndex = 10;
            this.textBox2.Text = "COM4 145 9600";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(679, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "DataqSDK DeviceID";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(677, 342);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(140, 20);
            this.textBox3.TabIndex = 12;
            this.textBox3.Text = "200";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(679, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Sample Rate";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 493);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.axDataqSdk1);
            this.Controls.Add(this.axUltimaMeter1);
            this.Controls.Add(this.axUltimaWaterfall1);
            this.Controls.Add(this.axXChart1);
            this.Controls.Add(this.axFFT10241);
            this.Name = "Form1";
            this.Text = "DataqSDK C# Example";
            ((System.ComponentModel.ISupportInitialize)(this.axXChart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axUltimaWaterfall1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axUltimaMeter1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axFFT10241)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axDataqSdk1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxXCHARTLib.AxXChart axXChart1;
        private AxULTIMAWATERFALLLib.AxUltimaWaterfall axUltimaWaterfall1;
        private AxULTIMAMETERLib.AxUltimaMeter axUltimaMeter1;
        private AxFFT1024Lib.AxFFT1024 axFFT10241;
        private AxDATAQSDKLib.AxDataqSdk axDataqSdk1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

