#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <vcclr.h>

#pragma once

namespace DataqSDKCpp {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Summary for Form1
	/// </summary>
	public ref class Form1 : public System::Windows::Forms::Form
	{
	public:
		Form1(void)
		{
			InitializeComponent();
			//
			//TODO: Add the constructor code here
			//
		}

	protected:
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		~Form1()
		{
			if (components)
			{
				delete components;
			}
		}
	private: AxFFT1024Lib::AxFFT1024^  axFFT10241;
	protected: 
	private: AxULTIMAWATERFALLLib::AxUltimaWaterfall^  axUltimaWaterfall1;
	private: AxXCHARTLib::AxXChart^  axXChart1;
	private: AxULTIMAMETERLib::AxUltimaMeter^  axUltimaMeter1;
	private: System::Windows::Forms::Label^  label1;
	private: System::Windows::Forms::TextBox^  textBox1;
	private: System::Windows::Forms::TextBox^  textBox2;
	private: System::Windows::Forms::Label^  label2;
	private: System::Windows::Forms::TextBox^  textBox3;
	private: System::Windows::Forms::Label^  label3;
	private: System::Windows::Forms::Button^  button1;
	private: System::Windows::Forms::Button^  button2;
	private: AxDATAQSDKLib::AxDataqSdk^  axDataqSdk1;
	private: AxFFT1024Lib::AxFFT1024^  axFFT10242;
	private: System::Windows::Forms::Timer^  timer1;
	private: System::Windows::Forms::Timer^  timer2;
	private: System::ComponentModel::IContainer^  components;

	private:
		/// <summary>
		/// Required designer variable.
		/// </summary>


#pragma region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		void InitializeComponent(void)
		{
			this->components = (gcnew System::ComponentModel::Container());
			System::ComponentModel::ComponentResourceManager^  resources = (gcnew System::ComponentModel::ComponentResourceManager(Form1::typeid));
			this->axFFT10241 = (gcnew AxFFT1024Lib::AxFFT1024());
			this->axUltimaWaterfall1 = (gcnew AxULTIMAWATERFALLLib::AxUltimaWaterfall());
			this->axXChart1 = (gcnew AxXCHARTLib::AxXChart());
			this->axUltimaMeter1 = (gcnew AxULTIMAMETERLib::AxUltimaMeter());
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->textBox1 = (gcnew System::Windows::Forms::TextBox());
			this->textBox2 = (gcnew System::Windows::Forms::TextBox());
			this->label2 = (gcnew System::Windows::Forms::Label());
			this->textBox3 = (gcnew System::Windows::Forms::TextBox());
			this->label3 = (gcnew System::Windows::Forms::Label());
			this->button1 = (gcnew System::Windows::Forms::Button());
			this->button2 = (gcnew System::Windows::Forms::Button());
			this->axDataqSdk1 = (gcnew AxDATAQSDKLib::AxDataqSdk());
			this->axFFT10242 = (gcnew AxFFT1024Lib::AxFFT1024());
			this->timer1 = (gcnew System::Windows::Forms::Timer(this->components));
			this->timer2 = (gcnew System::Windows::Forms::Timer(this->components));
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^  >(this->axFFT10241))->BeginInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^  >(this->axUltimaWaterfall1))->BeginInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^  >(this->axXChart1))->BeginInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^  >(this->axUltimaMeter1))->BeginInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^  >(this->axDataqSdk1))->BeginInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^  >(this->axFFT10242))->BeginInit();
			this->SuspendLayout();
			// 
			// axFFT10241
			// 
			this->axFFT10241->Enabled = true;
			this->axFFT10241->Location = System::Drawing::Point(0, 0);
			this->axFFT10241->Name = L"axFFT10241";
			this->axFFT10241->OcxState = (cli::safe_cast<System::Windows::Forms::AxHost::State^  >(resources->GetObject(L"axFFT10241.OcxState")));
			this->axFFT10241->Size = System::Drawing::Size(100, 50);
			this->axFFT10241->TabIndex = 0;
			// 
			// axUltimaWaterfall1
			// 
			this->axUltimaWaterfall1->Enabled = true;
			this->axUltimaWaterfall1->Location = System::Drawing::Point(0, 182);
			this->axUltimaWaterfall1->Name = L"axUltimaWaterfall1";
			this->axUltimaWaterfall1->OcxState = (cli::safe_cast<System::Windows::Forms::AxHost::State^  >(resources->GetObject(L"axUltimaWaterfall1.OcxState")));
			this->axUltimaWaterfall1->Size = System::Drawing::Size(602, 288);
			this->axUltimaWaterfall1->TabIndex = 1;
			// 
			// axXChart1
			// 
			this->axXChart1->Enabled = true;
			this->axXChart1->Location = System::Drawing::Point(0, 0);
			this->axXChart1->Name = L"axXChart1";
			this->axXChart1->OcxState = (cli::safe_cast<System::Windows::Forms::AxHost::State^  >(resources->GetObject(L"axXChart1.OcxState")));
			this->axXChart1->Size = System::Drawing::Size(602, 176);
			this->axXChart1->TabIndex = 2;
			// 
			// axUltimaMeter1
			// 
			this->axUltimaMeter1->Enabled = true;
			this->axUltimaMeter1->Location = System::Drawing::Point(608, 0);
			this->axUltimaMeter1->Name = L"axUltimaMeter1";
			this->axUltimaMeter1->OcxState = (cli::safe_cast<System::Windows::Forms::AxHost::State^  >(resources->GetObject(L"axUltimaMeter1.OcxState")));
			this->axUltimaMeter1->Size = System::Drawing::Size(207, 225);
			this->axUltimaMeter1->TabIndex = 3;
			this->axUltimaMeter1->MouseWheelEvent += gcnew AxULTIMAMETERLib::_DUltimaMeterEvents_MouseWheelEventHandler(this, &Form1::axUltimaMeter1_MouseWheelEvent);
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Location = System::Drawing::Point(608, 212);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(126, 13);
			this->label1->TabIndex = 4;
			this->label1->Text = L"DataqSDK Device Driver";
			// 
			// textBox1
			// 
			this->textBox1->Location = System::Drawing::Point(607, 229);
			this->textBox1->Name = L"textBox1";
			this->textBox1->Size = System::Drawing::Size(126, 20);
			this->textBox1->TabIndex = 5;
			this->textBox1->Text = L"DI104NT.DLL";
			this->textBox1->TextChanged += gcnew System::EventHandler(this, &Form1::textBox1_TextChanged);
			// 
			// textBox2
			// 
			this->textBox2->Location = System::Drawing::Point(607, 291);
			this->textBox2->Name = L"textBox2";
			this->textBox2->Size = System::Drawing::Size(126, 20);
			this->textBox2->TabIndex = 7;
			this->textBox2->Text = L"COM4 145 9600";
			// 
			// label2
			// 
			this->label2->AutoSize = true;
			this->label2->Location = System::Drawing::Point(608, 274);
			this->label2->Name = L"label2";
			this->label2->Size = System::Drawing::Size(106, 13);
			this->label2->TabIndex = 6;
			this->label2->Text = L"DataqSDK DeviceID";
			// 
			// textBox3
			// 
			this->textBox3->Location = System::Drawing::Point(607, 355);
			this->textBox3->Name = L"textBox3";
			this->textBox3->Size = System::Drawing::Size(126, 20);
			this->textBox3->TabIndex = 9;
			this->textBox3->Text = L"200";
			// 
			// label3
			// 
			this->label3->AutoSize = true;
			this->label3->Location = System::Drawing::Point(608, 338);
			this->label3->Name = L"label3";
			this->label3->Size = System::Drawing::Size(68, 13);
			this->label3->TabIndex = 8;
			this->label3->Text = L"Sample Rate";
			// 
			// button1
			// 
			this->button1->Location = System::Drawing::Point(610, 408);
			this->button1->Name = L"button1";
			this->button1->Size = System::Drawing::Size(65, 22);
			this->button1->TabIndex = 10;
			this->button1->Text = L"Start";
			this->button1->UseVisualStyleBackColor = true;
			this->button1->Click += gcnew System::EventHandler(this, &Form1::button1_Click);
			// 
			// button2
			// 
			this->button2->Location = System::Drawing::Point(701, 408);
			this->button2->Name = L"button2";
			this->button2->Size = System::Drawing::Size(65, 22);
			this->button2->TabIndex = 11;
			this->button2->Text = L"Stop";
			this->button2->UseVisualStyleBackColor = true;
			this->button2->Click += gcnew System::EventHandler(this, &Form1::button2_Click);
			// 
			// axDataqSdk1
			// 
			this->axDataqSdk1->Enabled = true;
			this->axDataqSdk1->Location = System::Drawing::Point(761, 235);
			this->axDataqSdk1->Name = L"axDataqSdk1";
			this->axDataqSdk1->OcxState = (cli::safe_cast<System::Windows::Forms::AxHost::State^  >(resources->GetObject(L"axDataqSdk1.OcxState")));
			this->axDataqSdk1->Size = System::Drawing::Size(54, 50);
			this->axDataqSdk1->TabIndex = 12;
			this->axDataqSdk1->NewData += gcnew AxDATAQSDKLib::_DDataqSdkEvents_NewDataEventHandler(this, &Form1::axDataqSdk1_NewData);
			this->axDataqSdk1->ControlError += gcnew AxDATAQSDKLib::_DDataqSdkEvents_ControlErrorEventHandler(this, &Form1::axDataqSdk1_ControlError);
			// 
			// axFFT10242
			// 
			this->axFFT10242->Enabled = true;
			this->axFFT10242->Location = System::Drawing::Point(438, 325);
			this->axFFT10242->Name = L"axFFT10242";
			this->axFFT10242->OcxState = (cli::safe_cast<System::Windows::Forms::AxHost::State^  >(resources->GetObject(L"axFFT10242.OcxState")));
			this->axFFT10242->Size = System::Drawing::Size(54, 50);
			this->axFFT10242->TabIndex = 13;
			// 
			// timer1
			// 
			this->timer1->Tick += gcnew System::EventHandler(this, &Form1::timer1_Tick);
			// 
			// timer2
			// 
			this->timer2->Tick += gcnew System::EventHandler(this, &Form1::timer2_Tick);
			// 
			// Form1
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(810, 471);
			this->Controls->Add(this->axDataqSdk1);
			this->Controls->Add(this->button2);
			this->Controls->Add(this->button1);
			this->Controls->Add(this->textBox3);
			this->Controls->Add(this->label3);
			this->Controls->Add(this->textBox2);
			this->Controls->Add(this->label2);
			this->Controls->Add(this->textBox1);
			this->Controls->Add(this->label1);
			this->Controls->Add(this->axUltimaMeter1);
			this->Controls->Add(this->axXChart1);
			this->Controls->Add(this->axUltimaWaterfall1);
			this->Controls->Add(this->axFFT10241);
			this->Controls->Add(this->axFFT10242);
			this->Name = L"Form1";
			this->Text = L"DataqSDK C++ Example";
			this->Load += gcnew System::EventHandler(this, &Form1::Form1_Load);
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^  >(this->axFFT10241))->EndInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^  >(this->axUltimaWaterfall1))->EndInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^  >(this->axXChart1))->EndInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^  >(this->axUltimaMeter1))->EndInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^  >(this->axDataqSdk1))->EndInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^  >(this->axFFT10242))->EndInit();
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
	private: System::Void textBox1_TextChanged(System::Object^  sender, System::EventArgs^  e) {
			 }
private: System::Void button1_Click(System::Object^  sender, System::EventArgs^  e) {
			 
			 axDataqSdk1->DeviceDriver=textBox1->Text;
			 axDataqSdk1->DeviceID=textBox2->Text;
			 axUltimaMeter1->MaxValue=10;
			 axUltimaMeter1->MinValue=-10;
			 
			 axDataqSdk1->SampleRate=Double::Parse(textBox3->Text);
			 axUltimaWaterfall1->ChartType=ULTIMAWATERFALLLib::enumCharType::uw3D;
			 axUltimaWaterfall1->ChartDirection=ULTIMAWATERFALLLib::enumCharDir::uwSlope;
			 axDataqSdk1->EventPoint=1;
			 timer1->Interval=10;
			 timer1->Enabled=1;
			 timer2->Interval=50;
			 timer2->Enabled=1;
			 axDataqSdk1->Start();
		 }

private: System::Void button2_Click(System::Object^  sender, System::EventArgs^  e) {
			 timer1->Enabled=0;
			 timer2->Enabled=0;
			 axDataqSdk1->Stop();
		 }
private: System::Void timer1_Tick(System::Object^  sender, System::EventArgs^  e) {
			 if (axDataqSdk1->AvailableData >0){
				 array<Int16, 2>^ Data = (array<Int16, 2>^)axDataqSdk1->GetData();

				 axXChart1->Chart(Data);
				 axUltimaMeter1->Value=(double)Data[0,0]/3276.8;
			 }

		 }
private: System::Void axDataqSdk1_ControlError(System::Object^  sender, AxDATAQSDKLib::_DDataqSdkEvents_ControlErrorEvent^  e) {
			 timer1->Enabled=0;
			 timer2->Enabled=0;
			 axDataqSdk1->Stop();
			 MessageBox::Show("Error: Please check DeviceDriver and DeviceID","Error",MessageBoxButtons::OK);
		 }
private: System::Void timer2_Tick(System::Object^  sender, System::EventArgs^  e) {
			 array<Int16, 2>^ Data2 = (array<Int16, 2>^)axDataqSdk1->GetDataFrame(1024);
			 int i;
			 for (i=0; i<1024; i++){
				 axFFT10242->SetWaveformPt(i,Data2[0,i]);
			 }
			 axFFT10242->FFTNow(1024);
			 axUltimaWaterfall1->Chart(axFFT10242->Power());

		}
private: System::Void axUltimaMeter1_MouseWheelEvent(System::Object^  sender, AxULTIMAMETERLib::_DUltimaMeterEvents_MouseWheelEvent^  e) {
		 }
private: System::Void Form1_Load(System::Object^  sender, System::EventArgs^  e) {
		 }
 private: System::Void axDataqSdk1_NewData(System::Object^  sender, AxDATAQSDKLib::_DDataqSdkEvents_NewDataEvent^  e) {
		  }
};
 }

