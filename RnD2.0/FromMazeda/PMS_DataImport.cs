// Type: MTechERP.PMS_DataImport
// Assembly: MTechERP, Version=4.7.51.0, Culture=neutral, PublicKeyToken=null
// MVID: D0AABECB-CB7F-42E6-A234-0752CE355F07
// Assembly location: D:\CodeData\MTechERP -TMP\MTechERP.exe

using ClassLibraryMicrosoftVisualStudio;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace MTechERP
{
  [DesignerGenerated]
  public class PMS_DataImport : Form
  {
    private IContainer components;
    private int col;
    private int Checker;
    private HL7Control server;
    private ASTMControl ASTMServer;
    private string TestCode;
    private Array myPort;
    private string SearchEXT;
    private string TrackNumber;
    private string SampleID;
    private string TrackNumberFieldName;
    private int TrackNumberFieldLocation;
    private int TestNameLocation;
    private int TestResultLocation;
    private string BufferData;
    private string MachineName;
    private string LISTestCode;
    private int MachineIndex;
    private string SerialSignal;
    private DataTable dtLISResult;
    private string PatientBio;
    private string PatientName;
    private string PatientBirthdate;
    private string PatientSex;
    private string LISBarcode8Bit;
    private string LISTrackNumber;
    private string OrderType;
    private string AssayType;
    private string[] OBX;
    private int RowIndex;
    private int rowindex2;
    private string TestName;
    private string orderSend;
    private string PatientID;
    private int TimeCounter;
    private string OrderQuery;
    private PMS_LISMonitor LISMonitorForm;
    private SerialPort LISSerialPort;
    private DateTime LISMachineTestTime;

    internal virtual DateTimePicker DTPTo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DateTimePicker DTPFrom { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual GroupBox GroupBoxSearch { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBoxSearchValue
    {
      get
      {
        return this._TextBoxSearchValue;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.TextBoxSearchValue_TextChanged);
        TextBox textBox1 = this._TextBoxSearchValue;
        if (textBox1 != null)
          textBox1.TextChanged -= eventHandler;
        this._TextBoxSearchValue = value;
        TextBox textBox2 = this._TextBoxSearchValue;
        if (textBox2 == null)
          return;
        textBox2.TextChanged += eventHandler;
      }
    }

    internal virtual DataGridView DataGridView1
    {
      get
      {
        return this._DataGridView1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DataGridViewCellEventHandler cellEventHandler = new DataGridViewCellEventHandler(this.DataGridView1_CellClick);
        DataGridView dataGridView1 = this._DataGridView1;
        if (dataGridView1 != null)
          dataGridView1.CellClick -= cellEventHandler;
        this._DataGridView1 = value;
        DataGridView dataGridView2 = this._DataGridView1;
        if (dataGridView2 == null)
          return;
        dataGridView2.CellClick += cellEventHandler;
      }
    }

    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button ButtonImportData
    {
      get
      {
        return this._ButtonImportData;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ButtonImportData_Click);
        Button button1 = this._ButtonImportData;
        if (button1 != null)
          button1.Click -= eventHandler;
        this._ButtonImportData = value;
        Button button2 = this._ButtonImportData;
        if (button2 == null)
          return;
        button2.Click += eventHandler;
      }
    }

    internal virtual TextBox TextBoxFile3Col7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBoxFile3Col5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBoxFile3Col9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBoxFile3Col3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBoxFile3Col1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label26 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label27 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label28 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label29 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label30 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBoxFile3Col2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBoxFile3Col4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBoxFile3STX { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBoxFile3Col6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBoxFile3Col8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBoxFile3Col10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label31 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label32 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBoxFile3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label33 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button ButtonFile3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label34 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label35 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label36 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBoxFile3CRLF { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBoxFile3CheckSum { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBoxFile3STX { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox ComboBoxCheckSum3Format { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBoxFile4Col7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBoxFile4Col5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBoxFile4Col9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBoxFile4Col3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBoxFile4Col1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label37 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label38 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label39 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label40 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label41 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBoxFile4Col2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBoxFile4Col4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBoxFile4STX { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBoxFile4Col6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBoxFile4Col8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBoxFile4Col10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label42 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label43 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBoxFile4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label44 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button ButtonFile4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label45 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label46 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBoxFile4CRLF { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBoxFile4CheckSum { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBoxFile4STX { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox ComboBoxCheckSum4Format { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBoxFile3Res1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label50 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBoxFile4Res1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label51 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button ButtonSave
    {
      get
      {
        return this._ButtonSave;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ButtonSave_Click);
        Button button1 = this._ButtonSave;
        if (button1 != null)
          button1.Click -= eventHandler;
        this._ButtonSave = value;
        Button button2 = this._ButtonSave;
        if (button2 == null)
          return;
        button2.Click += eventHandler;
      }
    }

    internal virtual DateTimePicker DateTimePickerTimeTo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DateTimePicker DateTimePickerTimeFrom { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button ButtonMicrosoftAccessFile
    {
      get
      {
        return this._ButtonMicrosoftAccessFile;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ButtonMicrosoftAccessFile_Click);
        Button button1 = this._ButtonMicrosoftAccessFile;
        if (button1 != null)
          button1.Click -= eventHandler;
        this._ButtonMicrosoftAccessFile = value;
        Button button2 = this._ButtonMicrosoftAccessFile;
        if (button2 == null)
          return;
        button2.Click += eventHandler;
      }
    }

    internal virtual TextBox TextBoxAccessFile { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBoxAccessFileUserName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBoxAccessFilePassword { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button ButtonShowData
    {
      get
      {
        return this._ButtonShowData;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ButtonShowData_Click);
        Button button1 = this._ButtonShowData;
        if (button1 != null)
          button1.Click -= eventHandler;
        this._ButtonShowData = value;
        Button button2 = this._ButtonShowData;
        if (button2 == null)
          return;
        button2.Click += eventHandler;
      }
    }

    internal virtual GroupBox GroupBoxAccessFile { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual GroupBox GroupBoxTextFile { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button ButtonTextFile
    {
      get
      {
        return this._ButtonTextFile;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ButtonTextFile_Click);
        Button button1 = this._ButtonTextFile;
        if (button1 != null)
          button1.Click -= eventHandler;
        this._ButtonTextFile = value;
        Button button2 = this._ButtonTextFile;
        if (button2 == null)
          return;
        button2.Click += eventHandler;
      }
    }

    internal virtual TextBox TextBoxTextFile { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual RadioButton RadioButtonMicrosoftAccessFile
    {
      get
      {
        return this._RadioButtonMicrosoftAccessFile;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.RadioButtonMicrosoftAccessFile_CheckedChanged);
        RadioButton radioButton1 = this._RadioButtonMicrosoftAccessFile;
        if (radioButton1 != null)
          radioButton1.CheckedChanged -= eventHandler;
        this._RadioButtonMicrosoftAccessFile = value;
        RadioButton radioButton2 = this._RadioButtonMicrosoftAccessFile;
        if (radioButton2 == null)
          return;
        radioButton2.CheckedChanged += eventHandler;
      }
    }

    internal virtual RadioButton RadioButtonTextFile
    {
      get
      {
        return this._RadioButtonTextFile;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.RadioButtonTextFile_CheckedChanged);
        RadioButton radioButton1 = this._RadioButtonTextFile;
        if (radioButton1 != null)
          radioButton1.CheckedChanged -= eventHandler;
        this._RadioButtonTextFile = value;
        RadioButton radioButton2 = this._RadioButtonTextFile;
        if (radioButton2 == null)
          return;
        radioButton2.CheckedChanged += eventHandler;
      }
    }

    internal virtual ComboBox ComboBoxAccessFileTableName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBoxAccessFileSearchField { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBoxAccessFileSearchExt { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox ComboBoxTestFileMachineName
    {
      get
      {
        return this._ComboBoxTestFileMachineName;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ComboBoxTestFileMachineName_SelectedIndexChanged);
        ComboBox comboBox1 = this._ComboBoxTestFileMachineName;
        if (comboBox1 != null)
          comboBox1.SelectedIndexChanged -= eventHandler;
        this._ComboBoxTestFileMachineName = value;
        ComboBox comboBox2 = this._ComboBoxTestFileMachineName;
        if (comboBox2 == null)
          return;
        comboBox2.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual ComboBox ComboBoxTestFileTestName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual GroupBox GroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button ButtonAbbottMachineFile
    {
      get
      {
        return this._ButtonAbbottMachineFile;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ButtonAbbottMachineFile_Click);
        Button button1 = this._ButtonAbbottMachineFile;
        if (button1 != null)
          button1.Click -= eventHandler;
        this._ButtonAbbottMachineFile = value;
        Button button2 = this._ButtonAbbottMachineFile;
        if (button2 == null)
          return;
        button2.Click += eventHandler;
      }
    }

    internal virtual TextBox TextBoxAbbottMachineFile { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual RadioButton RadioButtonAbbottFile
    {
      get
      {
        return this._RadioButtonAbbottFile;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.RadioButtonAbbottFile_CheckedChanged);
        RadioButton radioButton1 = this._RadioButtonAbbottFile;
        if (radioButton1 != null)
          radioButton1.CheckedChanged -= eventHandler;
        this._RadioButtonAbbottFile = value;
        RadioButton radioButton2 = this._RadioButtonAbbottFile;
        if (radioButton2 == null)
          return;
        radioButton2.CheckedChanged += eventHandler;
      }
    }

    internal virtual GroupBox GroupBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button ButtonExcelFile
    {
      get
      {
        return this._ButtonExcelFile;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ButtonExcelFile_Click);
        Button button1 = this._ButtonExcelFile;
        if (button1 != null)
          button1.Click -= eventHandler;
        this._ButtonExcelFile = value;
        Button button2 = this._ButtonExcelFile;
        if (button2 == null)
          return;
        button2.Click += eventHandler;
      }
    }

    internal virtual TextBox TextBoxExcelFile { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual RadioButton RadioButtonExcelFile
    {
      get
      {
        return this._RadioButtonExcelFile;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.RadioButtonExcelFile_CheckedChanged);
        RadioButton radioButton1 = this._RadioButtonExcelFile;
        if (radioButton1 != null)
          radioButton1.CheckedChanged -= eventHandler;
        this._RadioButtonExcelFile = value;
        RadioButton radioButton2 = this._RadioButtonExcelFile;
        if (radioButton2 == null)
          return;
        radioButton2.CheckedChanged += eventHandler;
      }
    }

    internal virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox ComboBoxExcelSheetNo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox ComboBoxExcelResultColumnNo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox ComboBoxExcelTestColumnNo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox ComboBoxExcelTrackColumnNo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBoxAccessPort { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBoxAccessIP { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBoxTextFilePort { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBoxTextFileIP { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBoxAbbottMachinePort { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBoxAbbottMachineIP { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBoxExcelFilePort { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBoxExcelFileIP { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBoxLIS
    {
      get
      {
        return this._CheckBoxLIS;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBoxLIS_CheckedChanged);
        CheckBox checkBox1 = this._CheckBoxLIS;
        if (checkBox1 != null)
          checkBox1.CheckedChanged -= eventHandler;
        this._CheckBoxLIS = value;
        CheckBox checkBox2 = this._CheckBoxLIS;
        if (checkBox2 == null)
          return;
        checkBox2.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox CheckBoxLISMonitor { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBoxResponseMessage
    {
      get
      {
        return this._TextBoxResponseMessage;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.TextBoxResponseMessage_TextChanged);
        TextBox textBox1 = this._TextBoxResponseMessage;
        if (textBox1 != null)
          textBox1.TextChanged -= eventHandler;
        this._TextBoxResponseMessage = value;
        TextBox textBox2 = this._TextBoxResponseMessage;
        if (textBox2 == null)
          return;
        textBox2.TextChanged += eventHandler;
      }
    }

    internal virtual GroupBox GroupBoxCommunication { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label24 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label22 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual RadioButton RadioButtonSerial { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual RadioButton RadioButtonTCPIP { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox ComboBoxBaudRate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox ComboBoxPortList { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual SerialPort SerialPortArchitect
    {
      get
      {
        return this._SerialPortArchitect;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        SerialDataReceivedEventHandler receivedEventHandler = new SerialDataReceivedEventHandler(this.SerialPortSerialPortArchitect_DataReceived);
        SerialPort serialPort1 = this._SerialPortArchitect;
        if (serialPort1 != null)
          serialPort1.DataReceived -= receivedEventHandler;
        this._SerialPortArchitect = value;
        SerialPort serialPort2 = this._SerialPortArchitect;
        if (serialPort2 == null)
          return;
        serialPort2.DataReceived += receivedEventHandler;
      }
    }

    internal virtual CheckBox CheckBoxTest { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridView DataGridView2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridViewTextBoxColumn FieldEx1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridViewTextBoxColumn FieldEx2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridViewTextBoxColumn FieldEx3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridViewTextBoxColumn FieldEx4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridViewTextBoxColumn FieldEx5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridViewTextBoxColumn FieldEx6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridViewTextBoxColumn FieldEx7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridViewTextBoxColumn FieldEx8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridViewTextBoxColumn FieldEx9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridViewTextBoxColumn FieldEx10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridViewTextBoxColumn FieldEx11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridViewTextBoxColumn FieldEx12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridViewTextBoxColumn FieldEx13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridViewTextBoxColumn FieldEx14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridViewTextBoxColumn FieldEx15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridViewTextBoxColumn FieldEx16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button ButtonImportException
    {
      get
      {
        return this._ButtonImportException;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ButtonImportException_Click);
        Button button1 = this._ButtonImportException;
        if (button1 != null)
          button1.Click -= eventHandler;
        this._ButtonImportException = value;
        Button button2 = this._ButtonImportException;
        if (button2 == null)
          return;
        button2.Click += eventHandler;
      }
    }

    internal virtual TextBox TextBoxTrackForTestOrder { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label25 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn22 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn23 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn24 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn25 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn26 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn27 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn28 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn29 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn30 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn31 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn32 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBoxLISData
    {
      get
      {
        return this._TextBoxLISData;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.TextBoxLISData_TextChanged);
        TextBox textBox1 = this._TextBoxLISData;
        if (textBox1 != null)
          textBox1.TextChanged -= eventHandler;
        this._TextBoxLISData = value;
        TextBox textBox2 = this._TextBoxLISData;
        if (textBox2 == null)
          return;
        textBox2.TextChanged += eventHandler;
      }
    }

    internal virtual Button ButtonSendTestOrder
    {
      get
      {
        return this._ButtonSendTestOrder;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ButtonSendTestOrder_Click);
        Button button1 = this._ButtonSendTestOrder;
        if (button1 != null)
          button1.Click -= eventHandler;
        this._ButtonSendTestOrder = value;
        Button button2 = this._ButtonSendTestOrder;
        if (button2 == null)
          return;
        button2.Click += eventHandler;
      }
    }

    internal virtual TextBox TextBoxLISRespond
    {
      get
      {
        return this._TextBoxLISRespond;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.TextBoxLISRespond_TextChanged);
        TextBox textBox1 = this._TextBoxLISRespond;
        if (textBox1 != null)
          textBox1.TextChanged -= eventHandler;
        this._TextBoxLISRespond = value;
        TextBox textBox2 = this._TextBoxLISRespond;
        if (textBox2 == null)
          return;
        textBox2.TextChanged += eventHandler;
      }
    }

    internal virtual SerialPort SerialPortELITE
    {
      get
      {
        return this._SerialPortELITE;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        SerialDataReceivedEventHandler receivedEventHandler = new SerialDataReceivedEventHandler(this.SerialPortELITE_DataReceived);
        SerialPort serialPort1 = this._SerialPortELITE;
        if (serialPort1 != null)
          serialPort1.DataReceived -= receivedEventHandler;
        this._SerialPortELITE = value;
        SerialPort serialPort2 = this._SerialPortELITE;
        if (serialPort2 == null)
          return;
        serialPort2.DataReceived += receivedEventHandler;
      }
    }

    internal virtual ComboBox ComboBoxOrderType
    {
      get
      {
        return this._ComboBoxOrderType;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ComboBoxOrderType_SelectedIndexChanged);
        ComboBox comboBox1 = this._ComboBoxOrderType;
        if (comboBox1 != null)
          comboBox1.SelectedIndexChanged -= eventHandler;
        this._ComboBoxOrderType = value;
        ComboBox comboBox2 = this._ComboBoxOrderType;
        if (comboBox2 == null)
          return;
        comboBox2.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual CheckBox CheckBoxCheckTestInDBResult { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label48 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual SerialPort SerialPortCellDynRuby
    {
      get
      {
        return this._SerialPortCellDynRuby;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        SerialDataReceivedEventHandler receivedEventHandler = new SerialDataReceivedEventHandler(this.SerialPortCellDynRuby_DataReceived);
        SerialPort serialPort1 = this._SerialPortCellDynRuby;
        if (serialPort1 != null)
          serialPort1.DataReceived -= receivedEventHandler;
        this._SerialPortCellDynRuby = value;
        SerialPort serialPort2 = this._SerialPortCellDynRuby;
        if (serialPort2 == null)
          return;
        serialPort2.DataReceived += receivedEventHandler;
      }
    }

    internal virtual Label Label53 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox ComboBoxDataBits { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label52 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox ComboBoxStopBits { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label49 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox ComboBoxParity { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button ButtonENQ
    {
      get
      {
        return this._ButtonENQ;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ButtonENQ_Click);
        Button button1 = this._ButtonENQ;
        if (button1 != null)
          button1.Click -= eventHandler;
        this._ButtonENQ = value;
        Button button2 = this._ButtonENQ;
        if (button2 == null)
          return;
        button2.Click += eventHandler;
      }
    }

    internal virtual ComboBox ComboBoxDepartment { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label54 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button ButtonBulkImport
    {
      get
      {
        return this._ButtonBulkImport;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ButtonBulkImport_Click);
        Button button1 = this._ButtonBulkImport;
        if (button1 != null)
          button1.Click -= eventHandler;
        this._ButtonBulkImport = value;
        Button button2 = this._ButtonBulkImport;
        if (button2 == null)
          return;
        button2.Click += eventHandler;
      }
    }

    internal virtual Label LabelSetupHide { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual SerialPort SerialPortSiemensAdvia { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBoxHL7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual SerialPort SerialPortSiemensDimension
    {
      get
      {
        return this._SerialPortSiemensDimension;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        SerialDataReceivedEventHandler receivedEventHandler = new SerialDataReceivedEventHandler(this.SerialPortSiemensDimension_DataReceived);
        SerialPort serialPort1 = this._SerialPortSiemensDimension;
        if (serialPort1 != null)
          serialPort1.DataReceived -= receivedEventHandler;
        this._SerialPortSiemensDimension = value;
        SerialPort serialPort2 = this._SerialPortSiemensDimension;
        if (serialPort2 == null)
          return;
        serialPort2.DataReceived += receivedEventHandler;
      }
    }

    internal virtual SerialPort SerialPortImmulite2000
    {
      get
      {
        return this._SerialPortImmulite2000;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        SerialDataReceivedEventHandler receivedEventHandler = new SerialDataReceivedEventHandler(this.SerialPortImmulite2000_DataReceived);
        SerialPort serialPort1 = this._SerialPortImmulite2000;
        if (serialPort1 != null)
          serialPort1.DataReceived -= receivedEventHandler;
        this._SerialPortImmulite2000 = value;
        SerialPort serialPort2 = this._SerialPortImmulite2000;
        if (serialPort2 == null)
          return;
        serialPort2.DataReceived += receivedEventHandler;
      }
    }

    internal virtual Label Label47 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBoxLISPort { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label55 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox ComboBoxLISIPAddress { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridViewTextBoxColumn Field1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridViewTextBoxColumn Field2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridViewTextBoxColumn Field3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridViewTextBoxColumn Field4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridViewTextBoxColumn Field5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridViewTextBoxColumn Field6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridViewTextBoxColumn TestTime { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridViewTextBoxColumn Field7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridViewTextBoxColumn Field8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridViewTextBoxColumn Field9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridViewTextBoxColumn Field10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridViewTextBoxColumn Field11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridViewTextBoxColumn Field12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridViewTextBoxColumn Field13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridViewTextBoxColumn Field14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridViewTextBoxColumn Field15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridViewTextBoxColumn Field16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual SerialPort SerialPortSysmex
    {
      get
      {
        return this._SerialPortSysmex;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        SerialDataReceivedEventHandler receivedEventHandler = new SerialDataReceivedEventHandler(this.SerialPortSysmex_DataReceived);
        SerialPort serialPort1 = this._SerialPortSysmex;
        if (serialPort1 != null)
          serialPort1.DataReceived -= receivedEventHandler;
        this._SerialPortSysmex = value;
        SerialPort serialPort2 = this._SerialPortSysmex;
        if (serialPort2 == null)
          return;
        serialPort2.DataReceived += receivedEventHandler;
      }
    }

    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn33 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual SerialPort SerialPortBioradD10
    {
      get
      {
        return this._SerialPortBioradD10;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        SerialDataReceivedEventHandler receivedEventHandler = new SerialDataReceivedEventHandler(this.SerialPortBioradD10_DataReceived);
        SerialPort serialPort1 = this._SerialPortBioradD10;
        if (serialPort1 != null)
          serialPort1.DataReceived -= receivedEventHandler;
        this._SerialPortBioradD10 = value;
        SerialPort serialPort2 = this._SerialPortBioradD10;
        if (serialPort2 == null)
          return;
        serialPort2.DataReceived += receivedEventHandler;
      }
    }

    internal virtual SerialPort SerialPortCelltacChemi
    {
      get
      {
        return this._SerialPortCelltacChemi;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        SerialDataReceivedEventHandler receivedEventHandler = new SerialDataReceivedEventHandler(this.SerialPortCelltacChemi_DataReceived);
        SerialPort serialPort1 = this._SerialPortCelltacChemi;
        if (serialPort1 != null)
          serialPort1.DataReceived -= receivedEventHandler;
        this._SerialPortCelltacChemi = value;
        SerialPort serialPort2 = this._SerialPortCelltacChemi;
        if (serialPort2 == null)
          return;
        serialPort2.DataReceived += receivedEventHandler;
      }
    }

    internal virtual SerialPort SerialPortVIDAS
    {
      get
      {
        return this._SerialPortVIDAS;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        SerialDataReceivedEventHandler receivedEventHandler = new SerialDataReceivedEventHandler(this.SerialPortVIDAS_DataReceived);
        SerialPort serialPort1 = this._SerialPortVIDAS;
        if (serialPort1 != null)
          serialPort1.DataReceived -= receivedEventHandler;
        this._SerialPortVIDAS = value;
        SerialPort serialPort2 = this._SerialPortVIDAS;
        if (serialPort2 == null)
          return;
        serialPort2.DataReceived += receivedEventHandler;
      }
    }

    internal virtual SerialPort SerialPortBioradVariant
    {
      get
      {
        return this._SerialPortBioradVariant;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        SerialDataReceivedEventHandler receivedEventHandler = new SerialDataReceivedEventHandler(this.SerialPortBioradVariant_DataReceived);
        SerialPort serialPort1 = this._SerialPortBioradVariant;
        if (serialPort1 != null)
          serialPort1.DataReceived -= receivedEventHandler;
        this._SerialPortBioradVariant = value;
        SerialPort serialPort2 = this._SerialPortBioradVariant;
        if (serialPort2 == null)
          return;
        serialPort2.DataReceived += receivedEventHandler;
      }
    }

    public PMS_DataImport()
    {
      this.Disposed += new EventHandler(this.DataImport_Disposed);
      this.FormClosing += new FormClosingEventHandler(this.DataImport_FormClosing);
      this.Load += new EventHandler(this.DataImport_Load);
      this.Shown += new EventHandler(this.PMS_DataImport_Shown);
      this.col = 0;
      this.Checker = 0;
      this.TestCode = "";
      this.SearchEXT = "";
      this.TrackNumber = "";
      this.SampleID = "";
      this.TrackNumberFieldName = "";
      this.TrackNumberFieldLocation = 0;
      this.TestNameLocation = 0;
      this.TestResultLocation = 0;
      this.BufferData = "";
      this.MachineName = "";
      this.LISTestCode = "";
      this.MachineIndex = 0;
      this.SerialSignal = "";
      this.dtLISResult = new DataTable();
      this.PatientBio = "";
      this.PatientName = "";
      this.PatientBirthdate = "";
      this.PatientSex = "";
      this.LISBarcode8Bit = "";
      this.LISTrackNumber = "";
      this.OrderType = "N";
      this.AssayType = "SERUM";
      this.RowIndex = 0;
      this.rowindex2 = 0;
      this.TestName = "";
      this.orderSend = "";
      this.PatientID = "";
      this.TimeCounter = -1;
      this.OrderQuery = "";
      this.LISMonitorForm = new PMS_LISMonitor();
      this.LISSerialPort = new SerialPort();
      this.LISMachineTestTime = DateAndTime.Now;
      this.InitializeComponent();
    }

    [DebuggerNonUserCode]
    protected override void Dispose(bool disposing)
    {
      try
      {
        if (!disposing || this.components == null)
          return;
        this.components.Dispose();
      }
      finally
      {
        base.Dispose(disposing);
      }
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      DataGridViewCellStyle gridViewCellStyle1 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle2 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle3 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle4 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle5 = new DataGridViewCellStyle();
      this.DTPTo = new DateTimePicker();
      this.Label2 = new Label();
      this.DTPFrom = new DateTimePicker();
      this.Label1 = new Label();
      this.GroupBoxSearch = new GroupBox();
      this.TextBoxSearchValue = new TextBox();
      this.DataGridView1 = new DataGridView();
      this.Field1 = new DataGridViewTextBoxColumn();
      this.Field2 = new DataGridViewTextBoxColumn();
      this.Field3 = new DataGridViewTextBoxColumn();
      this.Field4 = new DataGridViewTextBoxColumn();
      this.Field5 = new DataGridViewTextBoxColumn();
      this.Field6 = new DataGridViewTextBoxColumn();
      this.TestTime = new DataGridViewTextBoxColumn();
      this.Field7 = new DataGridViewTextBoxColumn();
      this.Field8 = new DataGridViewTextBoxColumn();
      this.Field9 = new DataGridViewTextBoxColumn();
      this.Field10 = new DataGridViewTextBoxColumn();
      this.Field11 = new DataGridViewTextBoxColumn();
      this.Field12 = new DataGridViewTextBoxColumn();
      this.Field13 = new DataGridViewTextBoxColumn();
      this.Field14 = new DataGridViewTextBoxColumn();
      this.Field15 = new DataGridViewTextBoxColumn();
      this.Field16 = new DataGridViewTextBoxColumn();
      this.ButtonImportData = new Button();
      this.TextBoxFile3Col7 = new TextBox();
      this.TextBoxFile3Col5 = new TextBox();
      this.TextBoxFile3Col9 = new TextBox();
      this.TextBoxFile3Col3 = new TextBox();
      this.TextBoxFile3Col1 = new TextBox();
      this.Label26 = new Label();
      this.Label27 = new Label();
      this.Label28 = new Label();
      this.Label29 = new Label();
      this.Label30 = new Label();
      this.TextBoxFile3Col2 = new TextBox();
      this.TextBoxFile3Col4 = new TextBox();
      this.TextBoxFile3STX = new TextBox();
      this.TextBoxFile3Col6 = new TextBox();
      this.TextBoxFile3Col8 = new TextBox();
      this.TextBoxFile3Col10 = new TextBox();
      this.Label31 = new Label();
      this.Label32 = new Label();
      this.TextBoxFile3 = new TextBox();
      this.Label33 = new Label();
      this.ButtonFile3 = new Button();
      this.Label34 = new Label();
      this.Label35 = new Label();
      this.Label36 = new Label();
      this.CheckBoxFile3CRLF = new CheckBox();
      this.CheckBoxFile3CheckSum = new CheckBox();
      this.CheckBoxFile3STX = new CheckBox();
      this.ComboBoxCheckSum3Format = new ComboBox();
      this.TextBoxFile4Col7 = new TextBox();
      this.TextBoxFile4Col5 = new TextBox();
      this.TextBoxFile4Col9 = new TextBox();
      this.TextBoxFile4Col3 = new TextBox();
      this.TextBoxFile4Col1 = new TextBox();
      this.Label37 = new Label();
      this.Label38 = new Label();
      this.Label39 = new Label();
      this.Label40 = new Label();
      this.Label41 = new Label();
      this.TextBoxFile4Col2 = new TextBox();
      this.TextBoxFile4Col4 = new TextBox();
      this.TextBoxFile4STX = new TextBox();
      this.TextBoxFile4Col6 = new TextBox();
      this.TextBoxFile4Col8 = new TextBox();
      this.TextBoxFile4Col10 = new TextBox();
      this.Label42 = new Label();
      this.Label43 = new Label();
      this.TextBoxFile4 = new TextBox();
      this.Label44 = new Label();
      this.ButtonFile4 = new Button();
      this.Label45 = new Label();
      this.Label46 = new Label();
      this.CheckBoxFile4CRLF = new CheckBox();
      this.CheckBoxFile4CheckSum = new CheckBox();
      this.CheckBoxFile4STX = new CheckBox();
      this.ComboBoxCheckSum4Format = new ComboBox();
      this.TextBoxFile3Res1 = new TextBox();
      this.Label50 = new Label();
      this.TextBoxFile4Res1 = new TextBox();
      this.Label51 = new Label();
      this.ButtonSave = new Button();
      this.DateTimePickerTimeTo = new DateTimePicker();
      this.DateTimePickerTimeFrom = new DateTimePicker();
      this.ButtonMicrosoftAccessFile = new Button();
      this.TextBoxAccessFile = new TextBox();
      this.TextBoxAccessFileUserName = new TextBox();
      this.TextBoxAccessFilePassword = new TextBox();
      this.Label3 = new Label();
      this.Label4 = new Label();
      this.ButtonShowData = new Button();
      this.GroupBoxAccessFile = new GroupBox();
      this.LabelSetupHide = new Label();
      this.Label14 = new Label();
      this.TextBoxAccessPort = new TextBox();
      this.TextBoxAccessIP = new TextBox();
      this.Label15 = new Label();
      this.Label7 = new Label();
      this.TextBoxAccessFileSearchExt = new TextBox();
      this.TextBoxAccessFileSearchField = new TextBox();
      this.Label6 = new Label();
      this.ComboBoxAccessFileTableName = new ComboBox();
      this.Label5 = new Label();
      this.GroupBoxTextFile = new GroupBox();
      this.Label16 = new Label();
      this.TextBoxTextFilePort = new TextBox();
      this.TextBoxTextFileIP = new TextBox();
      this.Label17 = new Label();
      this.ComboBoxTestFileTestName = new ComboBox();
      this.Label8 = new Label();
      this.ButtonTextFile = new Button();
      this.TextBoxTextFile = new TextBox();
      this.Label9 = new Label();
      this.ComboBoxTestFileMachineName = new ComboBox();
      this.RadioButtonMicrosoftAccessFile = new RadioButton();
      this.RadioButtonTextFile = new RadioButton();
      this.GroupBox1 = new GroupBox();
      this.Label18 = new Label();
      this.TextBoxAbbottMachinePort = new TextBox();
      this.TextBoxAbbottMachineIP = new TextBox();
      this.Label19 = new Label();
      this.ButtonAbbottMachineFile = new Button();
      this.TextBoxAbbottMachineFile = new TextBox();
      this.RadioButtonAbbottFile = new RadioButton();
      this.GroupBox2 = new GroupBox();
      this.Label20 = new Label();
      this.TextBoxExcelFilePort = new TextBox();
      this.TextBoxExcelFileIP = new TextBox();
      this.Label21 = new Label();
      this.ComboBoxExcelResultColumnNo = new ComboBox();
      this.ComboBoxExcelTestColumnNo = new ComboBox();
      this.ComboBoxExcelTrackColumnNo = new ComboBox();
      this.Label13 = new Label();
      this.Label12 = new Label();
      this.Label11 = new Label();
      this.Label10 = new Label();
      this.ComboBoxExcelSheetNo = new ComboBox();
      this.ButtonExcelFile = new Button();
      this.TextBoxExcelFile = new TextBox();
      this.RadioButtonExcelFile = new RadioButton();
      this.CheckBoxLIS = new CheckBox();
      this.CheckBoxLISMonitor = new CheckBox();
      this.TextBoxResponseMessage = new TextBox();
      this.GroupBoxCommunication = new GroupBox();
      this.CheckBoxHL7 = new CheckBox();
      this.Label53 = new Label();
      this.ComboBoxDataBits = new ComboBox();
      this.Label52 = new Label();
      this.ComboBoxStopBits = new ComboBox();
      this.Label49 = new Label();
      this.ComboBoxParity = new ComboBox();
      this.Label48 = new Label();
      this.CheckBoxCheckTestInDBResult = new CheckBox();
      this.ComboBoxOrderType = new ComboBox();
      this.Label24 = new Label();
      this.Label22 = new Label();
      this.RadioButtonSerial = new RadioButton();
      this.RadioButtonTCPIP = new RadioButton();
      this.ComboBoxBaudRate = new ComboBox();
      this.ComboBoxPortList = new ComboBox();
      this.SerialPortArchitect = new SerialPort(this.components);
      this.CheckBoxTest = new CheckBox();
      this.DataGridView2 = new DataGridView();
      this.FieldEx1 = new DataGridViewTextBoxColumn();
      this.FieldEx2 = new DataGridViewTextBoxColumn();
      this.FieldEx3 = new DataGridViewTextBoxColumn();
      this.FieldEx4 = new DataGridViewTextBoxColumn();
      this.FieldEx5 = new DataGridViewTextBoxColumn();
      this.FieldEx6 = new DataGridViewTextBoxColumn();
      this.FieldEx7 = new DataGridViewTextBoxColumn();
      this.FieldEx8 = new DataGridViewTextBoxColumn();
      this.FieldEx9 = new DataGridViewTextBoxColumn();
      this.FieldEx10 = new DataGridViewTextBoxColumn();
      this.FieldEx11 = new DataGridViewTextBoxColumn();
      this.FieldEx12 = new DataGridViewTextBoxColumn();
      this.FieldEx13 = new DataGridViewTextBoxColumn();
      this.FieldEx14 = new DataGridViewTextBoxColumn();
      this.FieldEx15 = new DataGridViewTextBoxColumn();
      this.FieldEx16 = new DataGridViewTextBoxColumn();
      this.ButtonImportException = new Button();
      this.TextBoxTrackForTestOrder = new TextBox();
      this.Label25 = new Label();
      this.TextBoxLISData = new TextBox();
      this.ButtonSendTestOrder = new Button();
      this.TextBoxLISRespond = new TextBox();
      this.SerialPortELITE = new SerialPort(this.components);
      this.SerialPortCellDynRuby = new SerialPort(this.components);
      this.ButtonENQ = new Button();
      this.ComboBoxDepartment = new ComboBox();
      this.Label54 = new Label();
      this.ButtonBulkImport = new Button();
      this.SerialPortSiemensAdvia = new SerialPort(this.components);
      this.SerialPortSiemensDimension = new SerialPort(this.components);
      this.SerialPortImmulite2000 = new SerialPort(this.components);
      this.Label47 = new Label();
      this.TextBoxLISPort = new TextBox();
      this.Label55 = new Label();
      this.ComboBoxLISIPAddress = new ComboBox();
      this.SerialPortSysmex = new SerialPort(this.components);
      this.SerialPortBioradD10 = new SerialPort(this.components);
      this.SerialPortCelltacChemi = new SerialPort(this.components);
      this.SerialPortVIDAS = new SerialPort(this.components);
      this.SerialPortBioradVariant = new SerialPort(this.components);
      this.DataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
      this.DataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
      this.DataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
      this.DataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
      this.DataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
      this.DataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
      this.DataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
      this.DataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
      this.DataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
      this.DataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
      this.DataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
      this.DataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
      this.DataGridViewTextBoxColumn13 = new DataGridViewTextBoxColumn();
      this.DataGridViewTextBoxColumn14 = new DataGridViewTextBoxColumn();
      this.DataGridViewTextBoxColumn15 = new DataGridViewTextBoxColumn();
      this.DataGridViewTextBoxColumn16 = new DataGridViewTextBoxColumn();
      this.DataGridViewTextBoxColumn17 = new DataGridViewTextBoxColumn();
      this.DataGridViewTextBoxColumn18 = new DataGridViewTextBoxColumn();
      this.DataGridViewTextBoxColumn19 = new DataGridViewTextBoxColumn();
      this.DataGridViewTextBoxColumn20 = new DataGridViewTextBoxColumn();
      this.DataGridViewTextBoxColumn21 = new DataGridViewTextBoxColumn();
      this.DataGridViewTextBoxColumn22 = new DataGridViewTextBoxColumn();
      this.DataGridViewTextBoxColumn23 = new DataGridViewTextBoxColumn();
      this.DataGridViewTextBoxColumn24 = new DataGridViewTextBoxColumn();
      this.DataGridViewTextBoxColumn25 = new DataGridViewTextBoxColumn();
      this.DataGridViewTextBoxColumn26 = new DataGridViewTextBoxColumn();
      this.DataGridViewTextBoxColumn27 = new DataGridViewTextBoxColumn();
      this.DataGridViewTextBoxColumn28 = new DataGridViewTextBoxColumn();
      this.DataGridViewTextBoxColumn29 = new DataGridViewTextBoxColumn();
      this.DataGridViewTextBoxColumn30 = new DataGridViewTextBoxColumn();
      this.DataGridViewTextBoxColumn31 = new DataGridViewTextBoxColumn();
      this.DataGridViewTextBoxColumn32 = new DataGridViewTextBoxColumn();
      this.DataGridViewTextBoxColumn33 = new DataGridViewTextBoxColumn();
      this.GroupBoxSearch.SuspendLayout();
      this.DataGridView1.BeginInit();
      this.GroupBoxAccessFile.SuspendLayout();
      this.GroupBoxTextFile.SuspendLayout();
      this.GroupBox1.SuspendLayout();
      this.GroupBox2.SuspendLayout();
      this.GroupBoxCommunication.SuspendLayout();
      this.DataGridView2.BeginInit();
      this.SuspendLayout();
      this.DTPTo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.DTPTo.CustomFormat = "dd/MM/yyyy";
      this.DTPTo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.DTPTo.Format = DateTimePickerFormat.Custom;
      this.DTPTo.Location = new Point(719, 29);
      this.DTPTo.Name = "DTPTo";
      this.DTPTo.Size = new Size(105, 22);
      this.DTPTo.TabIndex = 7;
      this.Label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.Label2.AutoSize = true;
      this.Label2.BackColor = SystemColors.Control;
      this.Label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label2.Location = new Point(648, 32);
      this.Label2.Name = "Label2";
      this.Label2.Size = new Size(57, 16);
      this.Label2.TabIndex = 6;
      this.Label2.Text = "Date To";
      this.DTPFrom.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.DTPFrom.CustomFormat = "dd/MM/yyyy";
      this.DTPFrom.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.DTPFrom.Format = DateTimePickerFormat.Custom;
      this.DTPFrom.Location = new Point(719, 4);
      this.DTPFrom.Name = "DTPFrom";
      this.DTPFrom.Size = new Size(105, 22);
      this.DTPFrom.TabIndex = 5;
      this.Label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.Label1.AutoSize = true;
      this.Label1.BackColor = SystemColors.Control;
      this.Label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label1.Location = new Point(648, 7);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(71, 16);
      this.Label1.TabIndex = 4;
      this.Label1.Text = "Date From";
      this.GroupBoxSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.GroupBoxSearch.Controls.Add((Control) this.TextBoxSearchValue);
      this.GroupBoxSearch.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.GroupBoxSearch.ForeColor = Color.FromArgb(192, 0, 0);
      this.GroupBoxSearch.Location = new Point(998, 4);
      this.GroupBoxSearch.Name = "GroupBoxSearch";
      this.GroupBoxSearch.Size = new Size(172, 47);
      this.GroupBoxSearch.TabIndex = 250;
      this.GroupBoxSearch.TabStop = false;
      this.GroupBoxSearch.Text = "Search";
      this.TextBoxSearchValue.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.TextBoxSearchValue.BackColor = Color.AliceBlue;
      this.TextBoxSearchValue.BorderStyle = BorderStyle.FixedSingle;
      this.TextBoxSearchValue.Font = new Font("Microsoft Sans Serif", 11f);
      this.TextBoxSearchValue.ForeColor = Color.Black;
      this.TextBoxSearchValue.Location = new Point(7, 14);
      this.TextBoxSearchValue.Margin = new Padding(0);
      this.TextBoxSearchValue.Name = "TextBoxSearchValue";
      this.TextBoxSearchValue.Size = new Size(161, 24);
      this.TextBoxSearchValue.TabIndex = 15;
      this.DataGridView1.AllowUserToAddRows = false;
      this.DataGridView1.AllowUserToOrderColumns = true;
      this.DataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      DataGridViewColumnCollection columns1 = this.DataGridView1.Columns;
      DataGridViewColumn[] dataGridViewColumnArray1 = new DataGridViewColumn[17];
      int index1 = 0;
      DataGridViewTextBoxColumn field1 = this.Field1;
      dataGridViewColumnArray1[index1] = (DataGridViewColumn) field1;
      int index2 = 1;
      DataGridViewTextBoxColumn field2 = this.Field2;
      dataGridViewColumnArray1[index2] = (DataGridViewColumn) field2;
      int index3 = 2;
      DataGridViewTextBoxColumn field3 = this.Field3;
      dataGridViewColumnArray1[index3] = (DataGridViewColumn) field3;
      int index4 = 3;
      DataGridViewTextBoxColumn field4 = this.Field4;
      dataGridViewColumnArray1[index4] = (DataGridViewColumn) field4;
      int index5 = 4;
      DataGridViewTextBoxColumn field5 = this.Field5;
      dataGridViewColumnArray1[index5] = (DataGridViewColumn) field5;
      int index6 = 5;
      DataGridViewTextBoxColumn field6 = this.Field6;
      dataGridViewColumnArray1[index6] = (DataGridViewColumn) field6;
      int index7 = 6;
      DataGridViewTextBoxColumn testTime = this.TestTime;
      dataGridViewColumnArray1[index7] = (DataGridViewColumn) testTime;
      int index8 = 7;
      DataGridViewTextBoxColumn field7 = this.Field7;
      dataGridViewColumnArray1[index8] = (DataGridViewColumn) field7;
      int index9 = 8;
      DataGridViewTextBoxColumn field8 = this.Field8;
      dataGridViewColumnArray1[index9] = (DataGridViewColumn) field8;
      int index10 = 9;
      DataGridViewTextBoxColumn field9 = this.Field9;
      dataGridViewColumnArray1[index10] = (DataGridViewColumn) field9;
      int index11 = 10;
      DataGridViewTextBoxColumn field10 = this.Field10;
      dataGridViewColumnArray1[index11] = (DataGridViewColumn) field10;
      int index12 = 11;
      DataGridViewTextBoxColumn field11 = this.Field11;
      dataGridViewColumnArray1[index12] = (DataGridViewColumn) field11;
      int index13 = 12;
      DataGridViewTextBoxColumn field12 = this.Field12;
      dataGridViewColumnArray1[index13] = (DataGridViewColumn) field12;
      int index14 = 13;
      DataGridViewTextBoxColumn field13 = this.Field13;
      dataGridViewColumnArray1[index14] = (DataGridViewColumn) field13;
      int index15 = 14;
      DataGridViewTextBoxColumn field14 = this.Field14;
      dataGridViewColumnArray1[index15] = (DataGridViewColumn) field14;
      int index16 = 15;
      DataGridViewTextBoxColumn field15 = this.Field15;
      dataGridViewColumnArray1[index16] = (DataGridViewColumn) field15;
      int index17 = 16;
      DataGridViewTextBoxColumn field16 = this.Field16;
      dataGridViewColumnArray1[index17] = (DataGridViewColumn) field16;
      columns1.AddRange(dataGridViewColumnArray1);
      this.DataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;
      this.DataGridView1.Location = new Point(374, 72);
      this.DataGridView1.Margin = new Padding(4);
      this.DataGridView1.Name = "DataGridView1";
      this.DataGridView1.Size = new Size(796, 395);
      this.DataGridView1.TabIndex = 251;
      this.Field1.HeaderText = "Field1";
      this.Field1.Name = "Field1";
      this.Field1.ReadOnly = true;
      this.Field1.Width = 80;
      this.Field2.HeaderText = "Field2";
      this.Field2.Name = "Field2";
      this.Field2.ReadOnly = true;
      this.Field2.Width = 80;
      this.Field3.HeaderText = "Track No.";
      this.Field3.Name = "Field3";
      this.Field4.HeaderText = "Field4";
      this.Field4.Name = "Field4";
      this.Field4.ReadOnly = true;
      gridViewCellStyle1.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.Field5.DefaultCellStyle = gridViewCellStyle1;
      this.Field5.HeaderText = "Result";
      this.Field5.Name = "Field5";
      this.Field5.Width = 50;
      this.Field6.HeaderText = "Field6";
      this.Field6.Name = "Field6";
      this.Field6.ReadOnly = true;
      this.Field6.Width = 80;
      this.TestTime.HeaderText = "Test Time";
      this.TestTime.Name = "TestTime";
      this.Field7.HeaderText = "Field7";
      this.Field7.Name = "Field7";
      this.Field7.ReadOnly = true;
      this.Field7.Width = 50;
      this.Field8.HeaderText = "Field8";
      this.Field8.Name = "Field8";
      this.Field8.ReadOnly = true;
      this.Field8.Width = 50;
      this.Field9.HeaderText = "Field9";
      this.Field9.Name = "Field9";
      this.Field9.ReadOnly = true;
      this.Field9.Width = 50;
      this.Field10.HeaderText = "Field10";
      this.Field10.Name = "Field10";
      this.Field10.ReadOnly = true;
      this.Field10.Width = 50;
      this.Field11.HeaderText = "Field11";
      this.Field11.Name = "Field11";
      this.Field11.ReadOnly = true;
      this.Field11.Width = 50;
      this.Field12.HeaderText = "Field12";
      this.Field12.Name = "Field12";
      this.Field12.ReadOnly = true;
      this.Field12.Width = 50;
      this.Field13.HeaderText = "Field13";
      this.Field13.Name = "Field13";
      this.Field13.ReadOnly = true;
      this.Field13.Width = 50;
      this.Field14.HeaderText = "Field14";
      this.Field14.Name = "Field14";
      this.Field14.ReadOnly = true;
      this.Field14.Width = 50;
      this.Field15.HeaderText = "Field15";
      this.Field15.Name = "Field15";
      this.Field15.ReadOnly = true;
      this.Field15.Width = 50;
      this.Field16.HeaderText = "Test Code";
      this.Field16.Name = "Field16";
      this.Field16.ReadOnly = true;
      this.Field16.Width = 50;
      this.ButtonImportData.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.ButtonImportData.Location = new Point(1092, 644);
      this.ButtonImportData.Name = "ButtonImportData";
      this.ButtonImportData.Size = new Size(75, 27);
      this.ButtonImportData.TabIndex = 252;
      this.ButtonImportData.Text = "Import Data";
      this.ButtonImportData.UseVisualStyleBackColor = true;
      this.TextBoxFile3Col7.BorderStyle = BorderStyle.FixedSingle;
      this.TextBoxFile3Col7.Location = new Point(621, 289);
      this.TextBoxFile3Col7.Name = "TextBoxFile3Col7";
      this.TextBoxFile3Col7.Size = new Size(28, 20);
      this.TextBoxFile3Col7.TabIndex = 258;
      this.TextBoxFile3Col7.Visible = false;
      this.TextBoxFile3Col5.BorderStyle = BorderStyle.FixedSingle;
      this.TextBoxFile3Col5.Location = new Point(553, 289);
      this.TextBoxFile3Col5.Name = "TextBoxFile3Col5";
      this.TextBoxFile3Col5.Size = new Size(28, 20);
      this.TextBoxFile3Col5.TabIndex = 258;
      this.TextBoxFile3Col5.Visible = false;
      this.TextBoxFile3Col9.BorderStyle = BorderStyle.FixedSingle;
      this.TextBoxFile3Col9.Location = new Point(689, 289);
      this.TextBoxFile3Col9.Name = "TextBoxFile3Col9";
      this.TextBoxFile3Col9.Size = new Size(28, 20);
      this.TextBoxFile3Col9.TabIndex = 258;
      this.TextBoxFile3Col9.Visible = false;
      this.TextBoxFile3Col3.BorderStyle = BorderStyle.FixedSingle;
      this.TextBoxFile3Col3.Location = new Point(485, 289);
      this.TextBoxFile3Col3.Name = "TextBoxFile3Col3";
      this.TextBoxFile3Col3.Size = new Size(28, 20);
      this.TextBoxFile3Col3.TabIndex = 258;
      this.TextBoxFile3Col3.Visible = false;
      this.TextBoxFile3Col1.BorderStyle = BorderStyle.FixedSingle;
      this.TextBoxFile3Col1.Location = new Point(417, 289);
      this.TextBoxFile3Col1.Name = "TextBoxFile3Col1";
      this.TextBoxFile3Col1.Size = new Size(28, 20);
      this.TextBoxFile3Col1.TabIndex = 258;
      this.TextBoxFile3Col1.Visible = false;
      this.Label26.AutoSize = true;
      this.Label26.Location = new Point(485, 273);
      this.Label26.Name = "Label26";
      this.Label26.Size = new Size(28, 13);
      this.Label26.TabIndex = 259;
      this.Label26.Text = "Col3";
      this.Label26.Visible = false;
      this.Label27.AutoSize = true;
      this.Label27.Location = new Point(417, 273);
      this.Label27.Name = "Label27";
      this.Label27.Size = new Size(28, 13);
      this.Label27.TabIndex = 259;
      this.Label27.Text = "Col1";
      this.Label27.Visible = false;
      this.Label28.AutoSize = true;
      this.Label28.Location = new Point(553, 273);
      this.Label28.Name = "Label28";
      this.Label28.Size = new Size(28, 13);
      this.Label28.TabIndex = 259;
      this.Label28.Text = "Col5";
      this.Label28.Visible = false;
      this.Label29.AutoSize = true;
      this.Label29.Location = new Point(621, 273);
      this.Label29.Name = "Label29";
      this.Label29.Size = new Size(28, 13);
      this.Label29.TabIndex = 259;
      this.Label29.Text = "Col7";
      this.Label29.Visible = false;
      this.Label30.AutoSize = true;
      this.Label30.Location = new Point(689, 273);
      this.Label30.Name = "Label30";
      this.Label30.Size = new Size(28, 13);
      this.Label30.TabIndex = 259;
      this.Label30.Text = "Col9";
      this.Label30.Visible = false;
      this.TextBoxFile3Col2.BorderStyle = BorderStyle.FixedSingle;
      this.TextBoxFile3Col2.Location = new Point(451, 289);
      this.TextBoxFile3Col2.Name = "TextBoxFile3Col2";
      this.TextBoxFile3Col2.Size = new Size(28, 20);
      this.TextBoxFile3Col2.TabIndex = 260;
      this.TextBoxFile3Col2.Visible = false;
      this.TextBoxFile3Col4.BorderStyle = BorderStyle.FixedSingle;
      this.TextBoxFile3Col4.Location = new Point(519, 289);
      this.TextBoxFile3Col4.Name = "TextBoxFile3Col4";
      this.TextBoxFile3Col4.Size = new Size(28, 20);
      this.TextBoxFile3Col4.TabIndex = 260;
      this.TextBoxFile3Col4.Visible = false;
      this.TextBoxFile3STX.BorderStyle = BorderStyle.FixedSingle;
      this.TextBoxFile3STX.Location = new Point(465, 316);
      this.TextBoxFile3STX.Name = "TextBoxFile3STX";
      this.TextBoxFile3STX.Size = new Size(28, 20);
      this.TextBoxFile3STX.TabIndex = 260;
      this.TextBoxFile3STX.Visible = false;
      this.TextBoxFile3Col6.BorderStyle = BorderStyle.FixedSingle;
      this.TextBoxFile3Col6.Location = new Point(587, 289);
      this.TextBoxFile3Col6.Name = "TextBoxFile3Col6";
      this.TextBoxFile3Col6.Size = new Size(28, 20);
      this.TextBoxFile3Col6.TabIndex = 260;
      this.TextBoxFile3Col6.Visible = false;
      this.TextBoxFile3Col8.BorderStyle = BorderStyle.FixedSingle;
      this.TextBoxFile3Col8.Location = new Point(655, 289);
      this.TextBoxFile3Col8.Name = "TextBoxFile3Col8";
      this.TextBoxFile3Col8.Size = new Size(28, 20);
      this.TextBoxFile3Col8.TabIndex = 260;
      this.TextBoxFile3Col8.Visible = false;
      this.TextBoxFile3Col10.BorderStyle = BorderStyle.FixedSingle;
      this.TextBoxFile3Col10.Location = new Point(723, 289);
      this.TextBoxFile3Col10.Name = "TextBoxFile3Col10";
      this.TextBoxFile3Col10.Size = new Size(28, 20);
      this.TextBoxFile3Col10.TabIndex = 260;
      this.TextBoxFile3Col10.Visible = false;
      this.Label31.AutoSize = true;
      this.Label31.Location = new Point(451, 273);
      this.Label31.Name = "Label31";
      this.Label31.Size = new Size(28, 13);
      this.Label31.TabIndex = 261;
      this.Label31.Text = "Col2";
      this.Label31.Visible = false;
      this.Label32.AutoSize = true;
      this.Label32.Location = new Point(519, 273);
      this.Label32.Name = "Label32";
      this.Label32.Size = new Size(28, 13);
      this.Label32.TabIndex = 261;
      this.Label32.Text = "Col4";
      this.Label32.Visible = false;
      this.TextBoxFile3.BorderStyle = BorderStyle.FixedSingle;
      this.TextBoxFile3.Enabled = false;
      this.TextBoxFile3.Location = new Point(483, 244);
      this.TextBoxFile3.Name = "TextBoxFile3";
      this.TextBoxFile3.Size = new Size(274, 20);
      this.TextBoxFile3.TabIndex = 256;
      this.TextBoxFile3.Visible = false;
      this.Label33.AutoSize = true;
      this.Label33.Location = new Point(587, 273);
      this.Label33.Name = "Label33";
      this.Label33.Size = new Size(28, 13);
      this.Label33.TabIndex = 261;
      this.Label33.Text = "Col6";
      this.Label33.Visible = false;
      this.ButtonFile3.Location = new Point(411, 243);
      this.ButtonFile3.Name = "ButtonFile3";
      this.ButtonFile3.Size = new Size(63, 23);
      this.ButtonFile3.TabIndex = 257;
      this.ButtonFile3.Text = "File 3";
      this.ButtonFile3.UseVisualStyleBackColor = true;
      this.ButtonFile3.Visible = false;
      this.Label34.AutoSize = true;
      this.Label34.Location = new Point(655, 273);
      this.Label34.Name = "Label34";
      this.Label34.Size = new Size(28, 13);
      this.Label34.TabIndex = 261;
      this.Label34.Text = "Col8";
      this.Label34.Visible = false;
      this.Label35.AutoSize = true;
      this.Label35.Location = new Point(721, 273);
      this.Label35.Name = "Label35";
      this.Label35.Size = new Size(34, 13);
      this.Label35.TabIndex = 261;
      this.Label35.Text = "Col10";
      this.Label35.Visible = false;
      this.Label36.BorderStyle = BorderStyle.Fixed3D;
      this.Label36.Location = new Point(403, 345);
      this.Label36.Name = "Label36";
      this.Label36.Size = new Size(374, 3);
      this.Label36.TabIndex = 264;
      this.Label36.Visible = false;
      this.CheckBoxFile3CRLF.AutoSize = true;
      this.CheckBoxFile3CRLF.Location = new Point(501, 318);
      this.CheckBoxFile3CRLF.Name = "CheckBoxFile3CRLF";
      this.CheckBoxFile3CRLF.Size = new Size(48, 17);
      this.CheckBoxFile3CRLF.TabIndex = 265;
      this.CheckBoxFile3CRLF.Text = "CrLF";
      this.CheckBoxFile3CRLF.UseVisualStyleBackColor = true;
      this.CheckBoxFile3CRLF.Visible = false;
      this.CheckBoxFile3CheckSum.AutoSize = true;
      this.CheckBoxFile3CheckSum.Location = new Point(548, 318);
      this.CheckBoxFile3CheckSum.Name = "CheckBoxFile3CheckSum";
      this.CheckBoxFile3CheckSum.Size = new Size(78, 17);
      this.CheckBoxFile3CheckSum.TabIndex = 265;
      this.CheckBoxFile3CheckSum.Text = "CheckSum";
      this.CheckBoxFile3CheckSum.UseVisualStyleBackColor = true;
      this.CheckBoxFile3CheckSum.Visible = false;
      this.CheckBoxFile3STX.AutoSize = true;
      this.CheckBoxFile3STX.Location = new Point(416, 318);
      this.CheckBoxFile3STX.Name = "CheckBoxFile3STX";
      this.CheckBoxFile3STX.Size = new Size(47, 17);
      this.CheckBoxFile3STX.TabIndex = 266;
      this.CheckBoxFile3STX.Text = "STX";
      this.CheckBoxFile3STX.UseVisualStyleBackColor = true;
      this.CheckBoxFile3STX.Visible = false;
      this.ComboBoxCheckSum3Format.FormattingEnabled = true;
      ComboBox.ObjectCollection items1 = this.ComboBoxCheckSum3Format.Items;
      object[] items2 = new object[2];
      int index18 = 0;
      string str1 = "HEXADECIMAL";
      items2[index18] = (object) str1;
      int index19 = 1;
      string str2 = "ASCII";
      items2[index19] = (object) str2;
      items1.AddRange(items2);
      this.ComboBoxCheckSum3Format.Location = new Point(626, 316);
      this.ComboBoxCheckSum3Format.Name = "ComboBoxCheckSum3Format";
      this.ComboBoxCheckSum3Format.Size = new Size(59, 21);
      this.ComboBoxCheckSum3Format.TabIndex = 267;
      this.ComboBoxCheckSum3Format.Visible = false;
      this.TextBoxFile4Col7.BorderStyle = BorderStyle.FixedSingle;
      this.TextBoxFile4Col7.Location = new Point(621, 405);
      this.TextBoxFile4Col7.Name = "TextBoxFile4Col7";
      this.TextBoxFile4Col7.Size = new Size(28, 20);
      this.TextBoxFile4Col7.TabIndex = 258;
      this.TextBoxFile4Col7.Visible = false;
      this.TextBoxFile4Col5.BorderStyle = BorderStyle.FixedSingle;
      this.TextBoxFile4Col5.Location = new Point(553, 405);
      this.TextBoxFile4Col5.Name = "TextBoxFile4Col5";
      this.TextBoxFile4Col5.Size = new Size(28, 20);
      this.TextBoxFile4Col5.TabIndex = 258;
      this.TextBoxFile4Col5.Visible = false;
      this.TextBoxFile4Col9.BorderStyle = BorderStyle.FixedSingle;
      this.TextBoxFile4Col9.Location = new Point(689, 405);
      this.TextBoxFile4Col9.Name = "TextBoxFile4Col9";
      this.TextBoxFile4Col9.Size = new Size(28, 20);
      this.TextBoxFile4Col9.TabIndex = 258;
      this.TextBoxFile4Col9.Visible = false;
      this.TextBoxFile4Col3.BorderStyle = BorderStyle.FixedSingle;
      this.TextBoxFile4Col3.Location = new Point(485, 405);
      this.TextBoxFile4Col3.Name = "TextBoxFile4Col3";
      this.TextBoxFile4Col3.Size = new Size(28, 20);
      this.TextBoxFile4Col3.TabIndex = 258;
      this.TextBoxFile4Col3.Visible = false;
      this.TextBoxFile4Col1.BorderStyle = BorderStyle.FixedSingle;
      this.TextBoxFile4Col1.Location = new Point(417, 405);
      this.TextBoxFile4Col1.Name = "TextBoxFile4Col1";
      this.TextBoxFile4Col1.Size = new Size(28, 20);
      this.TextBoxFile4Col1.TabIndex = 258;
      this.TextBoxFile4Col1.Visible = false;
      this.Label37.AutoSize = true;
      this.Label37.Location = new Point(485, 389);
      this.Label37.Name = "Label37";
      this.Label37.Size = new Size(28, 13);
      this.Label37.TabIndex = 259;
      this.Label37.Text = "Col3";
      this.Label37.Visible = false;
      this.Label38.AutoSize = true;
      this.Label38.Location = new Point(417, 389);
      this.Label38.Name = "Label38";
      this.Label38.Size = new Size(28, 13);
      this.Label38.TabIndex = 259;
      this.Label38.Text = "Col1";
      this.Label38.Visible = false;
      this.Label39.AutoSize = true;
      this.Label39.Location = new Point(553, 389);
      this.Label39.Name = "Label39";
      this.Label39.Size = new Size(28, 13);
      this.Label39.TabIndex = 259;
      this.Label39.Text = "Col5";
      this.Label39.Visible = false;
      this.Label40.AutoSize = true;
      this.Label40.Location = new Point(621, 389);
      this.Label40.Name = "Label40";
      this.Label40.Size = new Size(28, 13);
      this.Label40.TabIndex = 259;
      this.Label40.Text = "Col7";
      this.Label40.Visible = false;
      this.Label41.AutoSize = true;
      this.Label41.Location = new Point(689, 389);
      this.Label41.Name = "Label41";
      this.Label41.Size = new Size(28, 13);
      this.Label41.TabIndex = 259;
      this.Label41.Text = "Col9";
      this.Label41.Visible = false;
      this.TextBoxFile4Col2.BorderStyle = BorderStyle.FixedSingle;
      this.TextBoxFile4Col2.Location = new Point(451, 405);
      this.TextBoxFile4Col2.Name = "TextBoxFile4Col2";
      this.TextBoxFile4Col2.Size = new Size(28, 20);
      this.TextBoxFile4Col2.TabIndex = 260;
      this.TextBoxFile4Col2.Visible = false;
      this.TextBoxFile4Col4.BorderStyle = BorderStyle.FixedSingle;
      this.TextBoxFile4Col4.Location = new Point(519, 405);
      this.TextBoxFile4Col4.Name = "TextBoxFile4Col4";
      this.TextBoxFile4Col4.Size = new Size(28, 20);
      this.TextBoxFile4Col4.TabIndex = 260;
      this.TextBoxFile4Col4.Visible = false;
      this.TextBoxFile4STX.BorderStyle = BorderStyle.FixedSingle;
      this.TextBoxFile4STX.Location = new Point(465, 432);
      this.TextBoxFile4STX.Name = "TextBoxFile4STX";
      this.TextBoxFile4STX.Size = new Size(28, 20);
      this.TextBoxFile4STX.TabIndex = 260;
      this.TextBoxFile4STX.Visible = false;
      this.TextBoxFile4Col6.BorderStyle = BorderStyle.FixedSingle;
      this.TextBoxFile4Col6.Location = new Point(587, 405);
      this.TextBoxFile4Col6.Name = "TextBoxFile4Col6";
      this.TextBoxFile4Col6.Size = new Size(28, 20);
      this.TextBoxFile4Col6.TabIndex = 260;
      this.TextBoxFile4Col6.Visible = false;
      this.TextBoxFile4Col8.BorderStyle = BorderStyle.FixedSingle;
      this.TextBoxFile4Col8.Location = new Point(655, 405);
      this.TextBoxFile4Col8.Name = "TextBoxFile4Col8";
      this.TextBoxFile4Col8.Size = new Size(28, 20);
      this.TextBoxFile4Col8.TabIndex = 260;
      this.TextBoxFile4Col8.Visible = false;
      this.TextBoxFile4Col10.BorderStyle = BorderStyle.FixedSingle;
      this.TextBoxFile4Col10.Location = new Point(723, 405);
      this.TextBoxFile4Col10.Name = "TextBoxFile4Col10";
      this.TextBoxFile4Col10.Size = new Size(28, 20);
      this.TextBoxFile4Col10.TabIndex = 260;
      this.TextBoxFile4Col10.Visible = false;
      this.Label42.AutoSize = true;
      this.Label42.Location = new Point(451, 389);
      this.Label42.Name = "Label42";
      this.Label42.Size = new Size(28, 13);
      this.Label42.TabIndex = 261;
      this.Label42.Text = "Col2";
      this.Label42.Visible = false;
      this.Label43.AutoSize = true;
      this.Label43.Location = new Point(519, 389);
      this.Label43.Name = "Label43";
      this.Label43.Size = new Size(28, 13);
      this.Label43.TabIndex = 261;
      this.Label43.Text = "Col4";
      this.Label43.Visible = false;
      this.TextBoxFile4.BorderStyle = BorderStyle.FixedSingle;
      this.TextBoxFile4.Enabled = false;
      this.TextBoxFile4.Location = new Point(483, 360);
      this.TextBoxFile4.Name = "TextBoxFile4";
      this.TextBoxFile4.Size = new Size(274, 20);
      this.TextBoxFile4.TabIndex = 256;
      this.TextBoxFile4.Visible = false;
      this.Label44.AutoSize = true;
      this.Label44.Location = new Point(587, 389);
      this.Label44.Name = "Label44";
      this.Label44.Size = new Size(28, 13);
      this.Label44.TabIndex = 261;
      this.Label44.Text = "Col6";
      this.Label44.Visible = false;
      this.ButtonFile4.Location = new Point(411, 359);
      this.ButtonFile4.Name = "ButtonFile4";
      this.ButtonFile4.Size = new Size(63, 23);
      this.ButtonFile4.TabIndex = 257;
      this.ButtonFile4.Text = "File 4";
      this.ButtonFile4.UseVisualStyleBackColor = true;
      this.ButtonFile4.Visible = false;
      this.Label45.AutoSize = true;
      this.Label45.Location = new Point(655, 389);
      this.Label45.Name = "Label45";
      this.Label45.Size = new Size(28, 13);
      this.Label45.TabIndex = 261;
      this.Label45.Text = "Col8";
      this.Label45.Visible = false;
      this.Label46.AutoSize = true;
      this.Label46.Location = new Point(721, 389);
      this.Label46.Name = "Label46";
      this.Label46.Size = new Size(34, 13);
      this.Label46.TabIndex = 261;
      this.Label46.Text = "Col10";
      this.Label46.Visible = false;
      this.CheckBoxFile4CRLF.AutoSize = true;
      this.CheckBoxFile4CRLF.Location = new Point(501, 434);
      this.CheckBoxFile4CRLF.Name = "CheckBoxFile4CRLF";
      this.CheckBoxFile4CRLF.Size = new Size(48, 17);
      this.CheckBoxFile4CRLF.TabIndex = 265;
      this.CheckBoxFile4CRLF.Text = "CrLF";
      this.CheckBoxFile4CRLF.UseVisualStyleBackColor = true;
      this.CheckBoxFile4CRLF.Visible = false;
      this.CheckBoxFile4CheckSum.AutoSize = true;
      this.CheckBoxFile4CheckSum.Location = new Point(548, 434);
      this.CheckBoxFile4CheckSum.Name = "CheckBoxFile4CheckSum";
      this.CheckBoxFile4CheckSum.Size = new Size(78, 17);
      this.CheckBoxFile4CheckSum.TabIndex = 265;
      this.CheckBoxFile4CheckSum.Text = "CheckSum";
      this.CheckBoxFile4CheckSum.UseVisualStyleBackColor = true;
      this.CheckBoxFile4CheckSum.Visible = false;
      this.CheckBoxFile4STX.AutoSize = true;
      this.CheckBoxFile4STX.Location = new Point(416, 434);
      this.CheckBoxFile4STX.Name = "CheckBoxFile4STX";
      this.CheckBoxFile4STX.Size = new Size(47, 17);
      this.CheckBoxFile4STX.TabIndex = 266;
      this.CheckBoxFile4STX.Text = "STX";
      this.CheckBoxFile4STX.UseVisualStyleBackColor = true;
      this.CheckBoxFile4STX.Visible = false;
      this.ComboBoxCheckSum4Format.FormattingEnabled = true;
      ComboBox.ObjectCollection items3 = this.ComboBoxCheckSum4Format.Items;
      object[] items4 = new object[2];
      int index20 = 0;
      string str3 = "HEXADECIMAL";
      items4[index20] = (object) str3;
      int index21 = 1;
      string str4 = "ASCII";
      items4[index21] = (object) str4;
      items3.AddRange(items4);
      this.ComboBoxCheckSum4Format.Location = new Point(626, 432);
      this.ComboBoxCheckSum4Format.Name = "ComboBoxCheckSum4Format";
      this.ComboBoxCheckSum4Format.Size = new Size(59, 21);
      this.ComboBoxCheckSum4Format.TabIndex = 267;
      this.ComboBoxCheckSum4Format.Visible = false;
      this.TextBoxFile3Res1.BorderStyle = BorderStyle.FixedSingle;
      this.TextBoxFile3Res1.Location = new Point(723, 316);
      this.TextBoxFile3Res1.Name = "TextBoxFile3Res1";
      this.TextBoxFile3Res1.Size = new Size(28, 20);
      this.TextBoxFile3Res1.TabIndex = 260;
      this.TextBoxFile3Res1.Visible = false;
      this.Label50.AutoSize = true;
      this.Label50.Location = new Point(691, 320);
      this.Label50.Name = "Label50";
      this.Label50.Size = new Size(26, 13);
      this.Label50.TabIndex = 261;
      this.Label50.Text = "Res";
      this.Label50.Visible = false;
      this.TextBoxFile4Res1.BorderStyle = BorderStyle.FixedSingle;
      this.TextBoxFile4Res1.Location = new Point(723, 432);
      this.TextBoxFile4Res1.Name = "TextBoxFile4Res1";
      this.TextBoxFile4Res1.Size = new Size(28, 20);
      this.TextBoxFile4Res1.TabIndex = 260;
      this.TextBoxFile4Res1.Visible = false;
      this.Label51.AutoSize = true;
      this.Label51.Location = new Point(691, 436);
      this.Label51.Name = "Label51";
      this.Label51.Size = new Size(26, 13);
      this.Label51.TabIndex = 261;
      this.Label51.Text = "Res";
      this.Label51.Visible = false;
      this.ButtonSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      this.ButtonSave.Location = new Point(6, 645);
      this.ButtonSave.Name = "ButtonSave";
      this.ButtonSave.Size = new Size(79, 26);
      this.ButtonSave.TabIndex = 268;
      this.ButtonSave.Text = "Save Setup";
      this.ButtonSave.UseVisualStyleBackColor = true;
      this.DateTimePickerTimeTo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.DateTimePickerTimeTo.CustomFormat = "hh:mm tt";
      this.DateTimePickerTimeTo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.DateTimePickerTimeTo.Format = DateTimePickerFormat.Custom;
      this.DateTimePickerTimeTo.Location = new Point(827, 29);
      this.DateTimePickerTimeTo.Name = "DateTimePickerTimeTo";
      this.DateTimePickerTimeTo.ShowUpDown = true;
      this.DateTimePickerTimeTo.Size = new Size(87, 22);
      this.DateTimePickerTimeTo.TabIndex = 271;
      this.DateTimePickerTimeFrom.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.DateTimePickerTimeFrom.CustomFormat = "hh:mm tt";
      this.DateTimePickerTimeFrom.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.DateTimePickerTimeFrom.Format = DateTimePickerFormat.Custom;
      this.DateTimePickerTimeFrom.Location = new Point(827, 4);
      this.DateTimePickerTimeFrom.Name = "DateTimePickerTimeFrom";
      this.DateTimePickerTimeFrom.ShowUpDown = true;
      this.DateTimePickerTimeFrom.Size = new Size(87, 22);
      this.DateTimePickerTimeFrom.TabIndex = 270;
      this.ButtonMicrosoftAccessFile.Location = new Point(6, 18);
      this.ButtonMicrosoftAccessFile.Name = "ButtonMicrosoftAccessFile";
      this.ButtonMicrosoftAccessFile.Size = new Size(84, 23);
      this.ButtonMicrosoftAccessFile.TabIndex = 273;
      this.ButtonMicrosoftAccessFile.Text = "Select File";
      this.ButtonMicrosoftAccessFile.UseVisualStyleBackColor = true;
      this.TextBoxAccessFile.BorderStyle = BorderStyle.FixedSingle;
      this.TextBoxAccessFile.Location = new Point(104, 20);
      this.TextBoxAccessFile.Name = "TextBoxAccessFile";
      this.TextBoxAccessFile.Size = new Size(249, 20);
      this.TextBoxAccessFile.TabIndex = 272;
      this.TextBoxAccessFileUserName.BorderStyle = BorderStyle.FixedSingle;
      this.TextBoxAccessFileUserName.Location = new Point(104, 46);
      this.TextBoxAccessFileUserName.Name = "TextBoxAccessFileUserName";
      this.TextBoxAccessFileUserName.Size = new Size(140, 20);
      this.TextBoxAccessFileUserName.TabIndex = 274;
      this.TextBoxAccessFilePassword.BorderStyle = BorderStyle.FixedSingle;
      this.TextBoxAccessFilePassword.Location = new Point(104, 72);
      this.TextBoxAccessFilePassword.Name = "TextBoxAccessFilePassword";
      this.TextBoxAccessFilePassword.Size = new Size(140, 20);
      this.TextBoxAccessFilePassword.TabIndex = 275;
      this.TextBoxAccessFilePassword.UseSystemPasswordChar = true;
      this.Label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.Label3.AutoSize = true;
      this.Label3.BackColor = SystemColors.Control;
      this.Label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label3.Location = new Point(10, 48);
      this.Label3.Name = "Label3";
      this.Label3.Size = new Size(77, 16);
      this.Label3.TabIndex = 276;
      this.Label3.Text = "User Name";
      this.Label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.Label4.AutoSize = true;
      this.Label4.BackColor = SystemColors.Control;
      this.Label4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label4.Location = new Point(10, 74);
      this.Label4.Name = "Label4";
      this.Label4.Size = new Size(68, 16);
      this.Label4.TabIndex = 277;
      this.Label4.Text = "Password";
      this.ButtonShowData.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.ButtonShowData.Location = new Point(919, 3);
      this.ButtonShowData.Name = "ButtonShowData";
      this.ButtonShowData.Size = new Size(75, 48);
      this.ButtonShowData.TabIndex = 278;
      this.ButtonShowData.Text = "Show Data";
      this.ButtonShowData.UseVisualStyleBackColor = true;
      this.GroupBoxAccessFile.Controls.Add((Control) this.LabelSetupHide);
      this.GroupBoxAccessFile.Controls.Add((Control) this.Label14);
      this.GroupBoxAccessFile.Controls.Add((Control) this.TextBoxAccessPort);
      this.GroupBoxAccessFile.Controls.Add((Control) this.TextBoxAccessIP);
      this.GroupBoxAccessFile.Controls.Add((Control) this.Label15);
      this.GroupBoxAccessFile.Controls.Add((Control) this.Label7);
      this.GroupBoxAccessFile.Controls.Add((Control) this.TextBoxAccessFileSearchExt);
      this.GroupBoxAccessFile.Controls.Add((Control) this.TextBoxAccessFileSearchField);
      this.GroupBoxAccessFile.Controls.Add((Control) this.Label6);
      this.GroupBoxAccessFile.Controls.Add((Control) this.ComboBoxAccessFileTableName);
      this.GroupBoxAccessFile.Controls.Add((Control) this.Label5);
      this.GroupBoxAccessFile.Controls.Add((Control) this.ButtonMicrosoftAccessFile);
      this.GroupBoxAccessFile.Controls.Add((Control) this.TextBoxAccessFile);
      this.GroupBoxAccessFile.Controls.Add((Control) this.Label4);
      this.GroupBoxAccessFile.Controls.Add((Control) this.TextBoxAccessFileUserName);
      this.GroupBoxAccessFile.Controls.Add((Control) this.Label3);
      this.GroupBoxAccessFile.Controls.Add((Control) this.TextBoxAccessFilePassword);
      this.GroupBoxAccessFile.Location = new Point(6, 72);
      this.GroupBoxAccessFile.Name = "GroupBoxAccessFile";
      this.GroupBoxAccessFile.Size = new Size(359, 152);
      this.GroupBoxAccessFile.TabIndex = 279;
      this.GroupBoxAccessFile.TabStop = false;
      this.GroupBoxAccessFile.Text = "File Type 1";
      this.LabelSetupHide.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
      this.LabelSetupHide.BackColor = Color.LightYellow;
      this.LabelSetupHide.BorderStyle = BorderStyle.FixedSingle;
      this.LabelSetupHide.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.LabelSetupHide.Location = new Point(0, 0);
      this.LabelSetupHide.Name = "LabelSetupHide";
      this.LabelSetupHide.Size = new Size(359, 149);
      this.LabelSetupHide.TabIndex = 297;
      this.LabelSetupHide.Text = "Mazedatech Data Import System";
      this.LabelSetupHide.TextAlign = ContentAlignment.MiddleCenter;
      this.LabelSetupHide.Visible = false;
      this.Label14.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.Label14.AutoSize = true;
      this.Label14.BackColor = SystemColors.Control;
      this.Label14.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label14.Location = new Point(246, 156);
      this.Label14.Name = "Label14";
      this.Label14.Size = new Size(32, 16);
      this.Label14.TabIndex = 291;
      this.Label14.Text = "Port";
      this.Label14.Visible = false;
      this.TextBoxAccessPort.BorderStyle = BorderStyle.FixedSingle;
      this.TextBoxAccessPort.Location = new Point(284, 154);
      this.TextBoxAccessPort.Name = "TextBoxAccessPort";
      this.TextBoxAccessPort.Size = new Size(66, 20);
      this.TextBoxAccessPort.TabIndex = 290;
      this.TextBoxAccessPort.Visible = false;
      this.TextBoxAccessIP.BorderStyle = BorderStyle.FixedSingle;
      this.TextBoxAccessIP.Location = new Point(103, 154);
      this.TextBoxAccessIP.Name = "TextBoxAccessIP";
      this.TextBoxAccessIP.Size = new Size(140, 20);
      this.TextBoxAccessIP.TabIndex = 288;
      this.TextBoxAccessIP.Visible = false;
      this.Label15.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.Label15.AutoSize = true;
      this.Label15.BackColor = SystemColors.Control;
      this.Label15.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label15.Location = new Point(9, 156);
      this.Label15.Name = "Label15";
      this.Label15.Size = new Size(20, 16);
      this.Label15.TabIndex = 289;
      this.Label15.Text = "IP";
      this.Label15.Visible = false;
      this.Label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.Label7.AutoSize = true;
      this.Label7.BackColor = SystemColors.Control;
      this.Label7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label7.Location = new Point(247, 130);
      this.Label7.Name = "Label7";
      this.Label7.Size = new Size(26, 16);
      this.Label7.TabIndex = 287;
      this.Label7.Text = "Ext";
      this.TextBoxAccessFileSearchExt.BorderStyle = BorderStyle.FixedSingle;
      this.TextBoxAccessFileSearchExt.Location = new Point(284, 128);
      this.TextBoxAccessFileSearchExt.Name = "TextBoxAccessFileSearchExt";
      this.TextBoxAccessFileSearchExt.Size = new Size(66, 20);
      this.TextBoxAccessFileSearchExt.TabIndex = 286;
      this.TextBoxAccessFileSearchField.BorderStyle = BorderStyle.FixedSingle;
      this.TextBoxAccessFileSearchField.Location = new Point(104, 128);
      this.TextBoxAccessFileSearchField.Name = "TextBoxAccessFileSearchField";
      this.TextBoxAccessFileSearchField.Size = new Size(140, 20);
      this.TextBoxAccessFileSearchField.TabIndex = 284;
      this.Label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.Label6.AutoSize = true;
      this.Label6.BackColor = SystemColors.Control;
      this.Label6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label6.Location = new Point(10, 130);
      this.Label6.Name = "Label6";
      this.Label6.Size = new Size(84, 16);
      this.Label6.TabIndex = 285;
      this.Label6.Text = "Search Field";
      this.ComboBoxAccessFileTableName.FormattingEnabled = true;
      this.ComboBoxAccessFileTableName.Location = new Point(104, 99);
      this.ComboBoxAccessFileTableName.Name = "ComboBoxAccessFileTableName";
      this.ComboBoxAccessFileTableName.Size = new Size(249, 21);
      this.ComboBoxAccessFileTableName.TabIndex = 283;
      this.Label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.Label5.AutoSize = true;
      this.Label5.BackColor = SystemColors.Control;
      this.Label5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label5.Location = new Point(10, 100);
      this.Label5.Name = "Label5";
      this.Label5.Size = new Size(84, 16);
      this.Label5.TabIndex = 283;
      this.Label5.Text = "Table Name";
      this.GroupBoxTextFile.Controls.Add((Control) this.Label16);
      this.GroupBoxTextFile.Controls.Add((Control) this.TextBoxTextFilePort);
      this.GroupBoxTextFile.Controls.Add((Control) this.TextBoxTextFileIP);
      this.GroupBoxTextFile.Controls.Add((Control) this.Label17);
      this.GroupBoxTextFile.Controls.Add((Control) this.ComboBoxTestFileTestName);
      this.GroupBoxTextFile.Controls.Add((Control) this.Label8);
      this.GroupBoxTextFile.Controls.Add((Control) this.ButtonTextFile);
      this.GroupBoxTextFile.Controls.Add((Control) this.TextBoxTextFile);
      this.GroupBoxTextFile.Location = new Point(7, 226);
      this.GroupBoxTextFile.Name = "GroupBoxTextFile";
      this.GroupBoxTextFile.Size = new Size(358, 71);
      this.GroupBoxTextFile.TabIndex = 280;
      this.GroupBoxTextFile.TabStop = false;
      this.GroupBoxTextFile.Text = "File Type 2";
      this.Label16.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.Label16.AutoSize = true;
      this.Label16.BackColor = SystemColors.Control;
      this.Label16.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label16.Location = new Point(244, 73);
      this.Label16.Name = "Label16";
      this.Label16.Size = new Size(32, 16);
      this.Label16.TabIndex = 295;
      this.Label16.Text = "Port";
      this.Label16.Visible = false;
      this.TextBoxTextFilePort.BorderStyle = BorderStyle.FixedSingle;
      this.TextBoxTextFilePort.Location = new Point(282, 71);
      this.TextBoxTextFilePort.Name = "TextBoxTextFilePort";
      this.TextBoxTextFilePort.Size = new Size(66, 20);
      this.TextBoxTextFilePort.TabIndex = 294;
      this.TextBoxTextFilePort.Visible = false;
      this.TextBoxTextFileIP.BorderStyle = BorderStyle.FixedSingle;
      this.TextBoxTextFileIP.Location = new Point(101, 71);
      this.TextBoxTextFileIP.Name = "TextBoxTextFileIP";
      this.TextBoxTextFileIP.Size = new Size(140, 20);
      this.TextBoxTextFileIP.TabIndex = 292;
      this.TextBoxTextFileIP.Visible = false;
      this.Label17.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.Label17.AutoSize = true;
      this.Label17.BackColor = SystemColors.Control;
      this.Label17.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label17.Location = new Point(7, 73);
      this.Label17.Name = "Label17";
      this.Label17.Size = new Size(20, 16);
      this.Label17.TabIndex = 293;
      this.Label17.Text = "IP";
      this.Label17.Visible = false;
      this.ComboBoxTestFileTestName.FormattingEnabled = true;
      ComboBox.ObjectCollection items5 = this.ComboBoxTestFileTestName.Items;
      object[] items6 = new object[1];
      int index22 = 0;
      string str5 = "CBC";
      items6[index22] = (object) str5;
      items5.AddRange(items6);
      this.ComboBoxTestFileTestName.Location = new Point(101, 17);
      this.ComboBoxTestFileTestName.Name = "ComboBoxTestFileTestName";
      this.ComboBoxTestFileTestName.Size = new Size(249, 21);
      this.ComboBoxTestFileTestName.TabIndex = 285;
      this.Label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.Label8.AutoSize = true;
      this.Label8.BackColor = SystemColors.Control;
      this.Label8.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label8.Location = new Point(9, 19);
      this.Label8.Name = "Label8";
      this.Label8.Size = new Size(35, 16);
      this.Label8.TabIndex = 284;
      this.Label8.Text = "Test";
      this.ButtonTextFile.Location = new Point(7, 42);
      this.ButtonTextFile.Name = "ButtonTextFile";
      this.ButtonTextFile.Size = new Size(84, 23);
      this.ButtonTextFile.TabIndex = 275;
      this.ButtonTextFile.Text = "Select File";
      this.ButtonTextFile.UseVisualStyleBackColor = true;
      this.TextBoxTextFile.BorderStyle = BorderStyle.FixedSingle;
      this.TextBoxTextFile.Location = new Point(101, 44);
      this.TextBoxTextFile.Name = "TextBoxTextFile";
      this.TextBoxTextFile.Size = new Size(249, 20);
      this.TextBoxTextFile.TabIndex = 274;
      this.TextBoxTextFile.Text = "C:\\Mazedatech\\log.csv";
      this.Label9.AutoSize = true;
      this.Label9.BackColor = SystemColors.Control;
      this.Label9.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label9.Location = new Point(373, 23);
      this.Label9.Name = "Label9";
      this.Label9.Size = new Size(59, 16);
      this.Label9.TabIndex = 287;
      this.Label9.Text = "Machine";
      this.ComboBoxTestFileMachineName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      this.ComboBoxTestFileMachineName.FormattingEnabled = true;
      ComboBox.ObjectCollection items7 = this.ComboBoxTestFileMachineName.Items;
      object[] items8 = new object[2];
      int index23 = 0;
      string str6 = "";
      items8[index23] = (object) str6;
      int index24 = 1;
      string str7 = "Machine Name";
      items8[index24] = (object) str7;
      items7.AddRange(items8);
      this.ComboBoxTestFileMachineName.Location = new Point(483, 21);
      this.ComboBoxTestFileMachineName.Name = "ComboBoxTestFileMachineName";
      this.ComboBoxTestFileMachineName.Size = new Size(161, 21);
      this.ComboBoxTestFileMachineName.TabIndex = 286;
      this.RadioButtonMicrosoftAccessFile.AutoSize = true;
      this.RadioButtonMicrosoftAccessFile.Location = new Point(8, 446);
      this.RadioButtonMicrosoftAccessFile.Name = "RadioButtonMicrosoftAccessFile";
      this.RadioButtonMicrosoftAccessFile.Size = new Size(77, 17);
      this.RadioButtonMicrosoftAccessFile.TabIndex = 281;
      this.RadioButtonMicrosoftAccessFile.Text = "File Type 1";
      this.RadioButtonMicrosoftAccessFile.UseVisualStyleBackColor = true;
      this.RadioButtonTextFile.AutoSize = true;
      this.RadioButtonTextFile.Checked = true;
      this.RadioButtonTextFile.Location = new Point(98, 446);
      this.RadioButtonTextFile.Name = "RadioButtonTextFile";
      this.RadioButtonTextFile.Size = new Size(77, 17);
      this.RadioButtonTextFile.TabIndex = 282;
      this.RadioButtonTextFile.TabStop = true;
      this.RadioButtonTextFile.Text = "File Type 2";
      this.RadioButtonTextFile.UseVisualStyleBackColor = true;
      this.GroupBox1.Controls.Add((Control) this.Label18);
      this.GroupBox1.Controls.Add((Control) this.TextBoxAbbottMachinePort);
      this.GroupBox1.Controls.Add((Control) this.TextBoxAbbottMachineIP);
      this.GroupBox1.Controls.Add((Control) this.Label19);
      this.GroupBox1.Controls.Add((Control) this.ButtonAbbottMachineFile);
      this.GroupBox1.Controls.Add((Control) this.TextBoxAbbottMachineFile);
      this.GroupBox1.Location = new Point(8, 299);
      this.GroupBox1.Name = "GroupBox1";
      this.GroupBox1.Size = new Size(358, 44);
      this.GroupBox1.TabIndex = 298;
      this.GroupBox1.TabStop = false;
      this.GroupBox1.Text = "File Type 3";
      this.Label18.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.Label18.AutoSize = true;
      this.Label18.BackColor = SystemColors.Control;
      this.Label18.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label18.Location = new Point(246, 46);
      this.Label18.Name = "Label18";
      this.Label18.Size = new Size(32, 16);
      this.Label18.TabIndex = 295;
      this.Label18.Text = "Port";
      this.Label18.Visible = false;
      this.TextBoxAbbottMachinePort.BorderStyle = BorderStyle.FixedSingle;
      this.TextBoxAbbottMachinePort.Location = new Point(284, 44);
      this.TextBoxAbbottMachinePort.Name = "TextBoxAbbottMachinePort";
      this.TextBoxAbbottMachinePort.Size = new Size(66, 20);
      this.TextBoxAbbottMachinePort.TabIndex = 294;
      this.TextBoxAbbottMachinePort.Visible = false;
      this.TextBoxAbbottMachineIP.BorderStyle = BorderStyle.FixedSingle;
      this.TextBoxAbbottMachineIP.Location = new Point(101, 44);
      this.TextBoxAbbottMachineIP.Name = "TextBoxAbbottMachineIP";
      this.TextBoxAbbottMachineIP.Size = new Size(140, 20);
      this.TextBoxAbbottMachineIP.TabIndex = 292;
      this.TextBoxAbbottMachineIP.Visible = false;
      this.Label19.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.Label19.AutoSize = true;
      this.Label19.BackColor = SystemColors.Control;
      this.Label19.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label19.Location = new Point(9, 46);
      this.Label19.Name = "Label19";
      this.Label19.Size = new Size(20, 16);
      this.Label19.TabIndex = 293;
      this.Label19.Text = "IP";
      this.Label19.Visible = false;
      this.ButtonAbbottMachineFile.Location = new Point(7, 17);
      this.ButtonAbbottMachineFile.Name = "ButtonAbbottMachineFile";
      this.ButtonAbbottMachineFile.Size = new Size(84, 23);
      this.ButtonAbbottMachineFile.TabIndex = 275;
      this.ButtonAbbottMachineFile.Text = "Select File";
      this.ButtonAbbottMachineFile.UseVisualStyleBackColor = true;
      this.TextBoxAbbottMachineFile.BorderStyle = BorderStyle.FixedSingle;
      this.TextBoxAbbottMachineFile.Location = new Point(101, 19);
      this.TextBoxAbbottMachineFile.Name = "TextBoxAbbottMachineFile";
      this.TextBoxAbbottMachineFile.Size = new Size(249, 20);
      this.TextBoxAbbottMachineFile.TabIndex = 274;
      this.TextBoxAbbottMachineFile.Text = "C:\\Mazedatech\\log.P01";
      this.RadioButtonAbbottFile.AutoSize = true;
      this.RadioButtonAbbottFile.Location = new Point(188, 446);
      this.RadioButtonAbbottFile.Name = "RadioButtonAbbottFile";
      this.RadioButtonAbbottFile.Size = new Size(77, 17);
      this.RadioButtonAbbottFile.TabIndex = 299;
      this.RadioButtonAbbottFile.Text = "File Type 3";
      this.RadioButtonAbbottFile.UseVisualStyleBackColor = true;
      this.GroupBox2.Controls.Add((Control) this.Label20);
      this.GroupBox2.Controls.Add((Control) this.TextBoxExcelFilePort);
      this.GroupBox2.Controls.Add((Control) this.TextBoxExcelFileIP);
      this.GroupBox2.Controls.Add((Control) this.Label21);
      this.GroupBox2.Controls.Add((Control) this.ComboBoxExcelResultColumnNo);
      this.GroupBox2.Controls.Add((Control) this.ComboBoxExcelTestColumnNo);
      this.GroupBox2.Controls.Add((Control) this.ComboBoxExcelTrackColumnNo);
      this.GroupBox2.Controls.Add((Control) this.Label13);
      this.GroupBox2.Controls.Add((Control) this.Label12);
      this.GroupBox2.Controls.Add((Control) this.Label11);
      this.GroupBox2.Controls.Add((Control) this.Label10);
      this.GroupBox2.Controls.Add((Control) this.ComboBoxExcelSheetNo);
      this.GroupBox2.Controls.Add((Control) this.ButtonExcelFile);
      this.GroupBox2.Controls.Add((Control) this.TextBoxExcelFile);
      this.GroupBox2.Location = new Point(9, 349);
      this.GroupBox2.Name = "GroupBox2";
      this.GroupBox2.Size = new Size(358, 85);
      this.GroupBox2.TabIndex = 300;
      this.GroupBox2.TabStop = false;
      this.GroupBox2.Text = "File Type 4";
      this.Label20.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.Label20.AutoSize = true;
      this.Label20.BackColor = SystemColors.Control;
      this.Label20.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label20.Location = new Point(246, 89);
      this.Label20.Name = "Label20";
      this.Label20.Size = new Size(32, 16);
      this.Label20.TabIndex = 295;
      this.Label20.Text = "Port";
      this.Label20.Visible = false;
      this.TextBoxExcelFilePort.BorderStyle = BorderStyle.FixedSingle;
      this.TextBoxExcelFilePort.Location = new Point(284, 87);
      this.TextBoxExcelFilePort.Name = "TextBoxExcelFilePort";
      this.TextBoxExcelFilePort.Size = new Size(66, 20);
      this.TextBoxExcelFilePort.TabIndex = 294;
      this.TextBoxExcelFilePort.Visible = false;
      this.TextBoxExcelFileIP.BorderStyle = BorderStyle.FixedSingle;
      this.TextBoxExcelFileIP.Location = new Point(101, 87);
      this.TextBoxExcelFileIP.Name = "TextBoxExcelFileIP";
      this.TextBoxExcelFileIP.Size = new Size(140, 20);
      this.TextBoxExcelFileIP.TabIndex = 292;
      this.TextBoxExcelFileIP.Visible = false;
      this.Label21.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.Label21.AutoSize = true;
      this.Label21.BackColor = SystemColors.Control;
      this.Label21.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label21.Location = new Point(9, 89);
      this.Label21.Name = "Label21";
      this.Label21.Size = new Size(20, 16);
      this.Label21.TabIndex = 293;
      this.Label21.Text = "IP";
      this.Label21.Visible = false;
      this.ComboBoxExcelResultColumnNo.FormattingEnabled = true;
      ComboBox.ObjectCollection items9 = this.ComboBoxExcelResultColumnNo.Items;
      object[] items10 = new object[10];
      int index25 = 0;
      string str8 = "0";
      items10[index25] = (object) str8;
      int index26 = 1;
      string str9 = "1";
      items10[index26] = (object) str9;
      int index27 = 2;
      string str10 = "2";
      items10[index27] = (object) str10;
      int index28 = 3;
      string str11 = "3";
      items10[index28] = (object) str11;
      int index29 = 4;
      string str12 = "4";
      items10[index29] = (object) str12;
      int index30 = 5;
      string str13 = "5";
      items10[index30] = (object) str13;
      int index31 = 6;
      string str14 = "6";
      items10[index31] = (object) str14;
      int index32 = 7;
      string str15 = "7";
      items10[index32] = (object) str15;
      int index33 = 8;
      string str16 = "8";
      items10[index33] = (object) str16;
      int index34 = 9;
      string str17 = "9";
      items10[index34] = (object) str17;
      items9.AddRange(items10);
      this.ComboBoxExcelResultColumnNo.Location = new Point(295, 60);
      this.ComboBoxExcelResultColumnNo.Name = "ComboBoxExcelResultColumnNo";
      this.ComboBoxExcelResultColumnNo.Size = new Size(55, 21);
      this.ComboBoxExcelResultColumnNo.TabIndex = 283;
      this.ComboBoxExcelTestColumnNo.FormattingEnabled = true;
      ComboBox.ObjectCollection items11 = this.ComboBoxExcelTestColumnNo.Items;
      object[] items12 = new object[10];
      int index35 = 0;
      string str18 = "0";
      items12[index35] = (object) str18;
      int index36 = 1;
      string str19 = "1";
      items12[index36] = (object) str19;
      int index37 = 2;
      string str20 = "2";
      items12[index37] = (object) str20;
      int index38 = 3;
      string str21 = "3";
      items12[index38] = (object) str21;
      int index39 = 4;
      string str22 = "4";
      items12[index39] = (object) str22;
      int index40 = 5;
      string str23 = "5";
      items12[index40] = (object) str23;
      int index41 = 6;
      string str24 = "6";
      items12[index41] = (object) str24;
      int index42 = 7;
      string str25 = "7";
      items12[index42] = (object) str25;
      int index43 = 8;
      string str26 = "8";
      items12[index43] = (object) str26;
      int index44 = 9;
      string str27 = "9";
      items12[index44] = (object) str27;
      items11.AddRange(items12);
      this.ComboBoxExcelTestColumnNo.Location = new Point(231, 60);
      this.ComboBoxExcelTestColumnNo.Name = "ComboBoxExcelTestColumnNo";
      this.ComboBoxExcelTestColumnNo.Size = new Size(55, 21);
      this.ComboBoxExcelTestColumnNo.TabIndex = 282;
      this.ComboBoxExcelTrackColumnNo.FormattingEnabled = true;
      ComboBox.ObjectCollection items13 = this.ComboBoxExcelTrackColumnNo.Items;
      object[] items14 = new object[10];
      int index45 = 0;
      string str28 = "0";
      items14[index45] = (object) str28;
      int index46 = 1;
      string str29 = "1";
      items14[index46] = (object) str29;
      int index47 = 2;
      string str30 = "2";
      items14[index47] = (object) str30;
      int index48 = 3;
      string str31 = "3";
      items14[index48] = (object) str31;
      int index49 = 4;
      string str32 = "4";
      items14[index49] = (object) str32;
      int index50 = 5;
      string str33 = "5";
      items14[index50] = (object) str33;
      int index51 = 6;
      string str34 = "6";
      items14[index51] = (object) str34;
      int index52 = 7;
      string str35 = "7";
      items14[index52] = (object) str35;
      int index53 = 8;
      string str36 = "8";
      items14[index53] = (object) str36;
      int index54 = 9;
      string str37 = "9";
      items14[index54] = (object) str37;
      items13.AddRange(items14);
      this.ComboBoxExcelTrackColumnNo.Location = new Point(166, 60);
      this.ComboBoxExcelTrackColumnNo.Name = "ComboBoxExcelTrackColumnNo";
      this.ComboBoxExcelTrackColumnNo.Size = new Size(55, 21);
      this.ComboBoxExcelTrackColumnNo.TabIndex = 281;
      this.Label13.AutoSize = true;
      this.Label13.Location = new Point(293, 43);
      this.Label13.Name = "Label13";
      this.Label13.Size = new Size(58, 13);
      this.Label13.TabIndex = 280;
      this.Label13.Text = "Result Col.";
      this.Label12.AutoSize = true;
      this.Label12.Location = new Point(231, 43);
      this.Label12.Name = "Label12";
      this.Label12.Size = new Size(49, 13);
      this.Label12.TabIndex = 279;
      this.Label12.Text = "Test Col.";
      this.Label11.AutoSize = true;
      this.Label11.Location = new Point(166, 43);
      this.Label11.Name = "Label11";
      this.Label11.Size = new Size(56, 13);
      this.Label11.TabIndex = 278;
      this.Label11.Text = "Track Col.";
      this.Label10.AutoSize = true;
      this.Label10.Location = new Point(101, 43);
      this.Label10.Name = "Label10";
      this.Label10.Size = new Size(55, 13);
      this.Label10.TabIndex = 277;
      this.Label10.Text = "Sheet No.";
      this.ComboBoxExcelSheetNo.FormattingEnabled = true;
      ComboBox.ObjectCollection items15 = this.ComboBoxExcelSheetNo.Items;
      object[] items16 = new object[10];
      int index55 = 0;
      string str38 = "0";
      items16[index55] = (object) str38;
      int index56 = 1;
      string str39 = "1";
      items16[index56] = (object) str39;
      int index57 = 2;
      string str40 = "2";
      items16[index57] = (object) str40;
      int index58 = 3;
      string str41 = "3";
      items16[index58] = (object) str41;
      int index59 = 4;
      string str42 = "4";
      items16[index59] = (object) str42;
      int index60 = 5;
      string str43 = "5";
      items16[index60] = (object) str43;
      int index61 = 6;
      string str44 = "6";
      items16[index61] = (object) str44;
      int index62 = 7;
      string str45 = "7";
      items16[index62] = (object) str45;
      int index63 = 8;
      string str46 = "8";
      items16[index63] = (object) str46;
      int index64 = 9;
      string str47 = "9";
      items16[index64] = (object) str47;
      items15.AddRange(items16);
      this.ComboBoxExcelSheetNo.Location = new Point(101, 60);
      this.ComboBoxExcelSheetNo.Name = "ComboBoxExcelSheetNo";
      this.ComboBoxExcelSheetNo.Size = new Size(55, 21);
      this.ComboBoxExcelSheetNo.TabIndex = 276;
      this.ButtonExcelFile.Location = new Point(7, 17);
      this.ButtonExcelFile.Name = "ButtonExcelFile";
      this.ButtonExcelFile.Size = new Size(84, 23);
      this.ButtonExcelFile.TabIndex = 275;
      this.ButtonExcelFile.Text = "Select File";
      this.ButtonExcelFile.UseVisualStyleBackColor = true;
      this.TextBoxExcelFile.BorderStyle = BorderStyle.FixedSingle;
      this.TextBoxExcelFile.Location = new Point(101, 19);
      this.TextBoxExcelFile.Name = "TextBoxExcelFile";
      this.TextBoxExcelFile.Size = new Size(249, 20);
      this.TextBoxExcelFile.TabIndex = 274;
      this.TextBoxExcelFile.Text = "D:\\Mazedatech\\Maglumi\\log.txt";
      this.RadioButtonExcelFile.AutoSize = true;
      this.RadioButtonExcelFile.Location = new Point(278, 446);
      this.RadioButtonExcelFile.Name = "RadioButtonExcelFile";
      this.RadioButtonExcelFile.Size = new Size(77, 17);
      this.RadioButtonExcelFile.TabIndex = 301;
      this.RadioButtonExcelFile.Text = "File Type 4";
      this.RadioButtonExcelFile.UseVisualStyleBackColor = true;
      this.CheckBoxLIS.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      this.CheckBoxLIS.BackColor = Color.FromArgb(0, 0, 192);
      this.CheckBoxLIS.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CheckBoxLIS.ForeColor = Color.Yellow;
      this.CheckBoxLIS.Location = new Point(946, 633);
      this.CheckBoxLIS.Name = "CheckBoxLIS";
      this.CheckBoxLIS.Size = new Size(54, 25);
      this.CheckBoxLIS.TabIndex = 302;
      this.CheckBoxLIS.Text = "LIS";
      this.CheckBoxLIS.TextAlign = ContentAlignment.MiddleCenter;
      this.CheckBoxLIS.UseVisualStyleBackColor = true;
      this.CheckBoxLISMonitor.AutoSize = true;
      this.CheckBoxLISMonitor.Checked = true;
      this.CheckBoxLISMonitor.CheckState = CheckState.Checked;
      this.CheckBoxLISMonitor.Location = new Point(473, 40);
      this.CheckBoxLISMonitor.Name = "CheckBoxLISMonitor";
      this.CheckBoxLISMonitor.Size = new Size(91, 17);
      this.CheckBoxLISMonitor.TabIndex = 303;
      this.CheckBoxLISMonitor.Text = "Show Monitor";
      this.CheckBoxLISMonitor.UseVisualStyleBackColor = true;
      this.TextBoxResponseMessage.BorderStyle = BorderStyle.FixedSingle;
      this.TextBoxResponseMessage.Location = new Point(7, 34);
      this.TextBoxResponseMessage.Multiline = true;
      this.TextBoxResponseMessage.Name = "TextBoxResponseMessage";
      this.TextBoxResponseMessage.ScrollBars = ScrollBars.Both;
      this.TextBoxResponseMessage.Size = new Size(207, 34);
      this.TextBoxResponseMessage.TabIndex = 304;
      this.GroupBoxCommunication.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      this.GroupBoxCommunication.Controls.Add((Control) this.CheckBoxHL7);
      this.GroupBoxCommunication.Controls.Add((Control) this.Label53);
      this.GroupBoxCommunication.Controls.Add((Control) this.ComboBoxDataBits);
      this.GroupBoxCommunication.Controls.Add((Control) this.Label52);
      this.GroupBoxCommunication.Controls.Add((Control) this.ComboBoxStopBits);
      this.GroupBoxCommunication.Controls.Add((Control) this.Label49);
      this.GroupBoxCommunication.Controls.Add((Control) this.ComboBoxParity);
      this.GroupBoxCommunication.Controls.Add((Control) this.Label48);
      this.GroupBoxCommunication.Controls.Add((Control) this.CheckBoxCheckTestInDBResult);
      this.GroupBoxCommunication.Controls.Add((Control) this.ComboBoxOrderType);
      this.GroupBoxCommunication.Controls.Add((Control) this.Label24);
      this.GroupBoxCommunication.Controls.Add((Control) this.Label22);
      this.GroupBoxCommunication.Controls.Add((Control) this.RadioButtonSerial);
      this.GroupBoxCommunication.Controls.Add((Control) this.RadioButtonTCPIP);
      this.GroupBoxCommunication.Controls.Add((Control) this.ComboBoxBaudRate);
      this.GroupBoxCommunication.Controls.Add((Control) this.ComboBoxPortList);
      this.GroupBoxCommunication.Controls.Add((Control) this.CheckBoxLISMonitor);
      this.GroupBoxCommunication.Location = new Point(368, 611);
      this.GroupBoxCommunication.Name = "GroupBoxCommunication";
      this.GroupBoxCommunication.Size = new Size(566, 60);
      this.GroupBoxCommunication.TabIndex = 305;
      this.GroupBoxCommunication.TabStop = false;
      this.GroupBoxCommunication.Text = "Communication";
      this.CheckBoxHL7.AutoSize = true;
      this.CheckBoxHL7.Location = new Point(357, 40);
      this.CheckBoxHL7.Name = "CheckBoxHL7";
      this.CheckBoxHL7.Size = new Size(88, 17);
      this.CheckBoxHL7.TabIndex = 667;
      this.CheckBoxHL7.Text = "HL7 Protocol";
      this.CheckBoxHL7.UseVisualStyleBackColor = true;
      this.Label53.AutoSize = true;
      this.Label53.Location = new Point(493, 17);
      this.Label53.Name = "Label53";
      this.Label53.Size = new Size(33, 13);
      this.Label53.TabIndex = 666;
      this.Label53.Text = "Data:";
      this.ComboBoxDataBits.Font = new Font("Microsoft Sans Serif", 7f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.ComboBoxDataBits.FormattingEnabled = true;
      ComboBox.ObjectCollection items17 = this.ComboBoxDataBits.Items;
      object[] items18 = new object[16];
      int index65 = 0;
      string str48 = "1";
      items18[index65] = (object) str48;
      int index66 = 1;
      string str49 = "2";
      items18[index66] = (object) str49;
      int index67 = 2;
      string str50 = "3";
      items18[index67] = (object) str50;
      int index68 = 3;
      string str51 = "4";
      items18[index68] = (object) str51;
      int index69 = 4;
      string str52 = "5";
      items18[index69] = (object) str52;
      int index70 = 5;
      string str53 = "6";
      items18[index70] = (object) str53;
      int index71 = 6;
      string str54 = "7";
      items18[index71] = (object) str54;
      int index72 = 7;
      string str55 = "8";
      items18[index72] = (object) str55;
      int index73 = 8;
      string str56 = "9";
      items18[index73] = (object) str56;
      int index74 = 9;
      string str57 = "10";
      items18[index74] = (object) str57;
      int index75 = 10;
      string str58 = "11";
      items18[index75] = (object) str58;
      int index76 = 11;
      string str59 = "12";
      items18[index76] = (object) str59;
      int index77 = 12;
      string str60 = "13";
      items18[index77] = (object) str60;
      int index78 = 13;
      string str61 = "14";
      items18[index78] = (object) str61;
      int index79 = 14;
      string str62 = "15";
      items18[index79] = (object) str62;
      int index80 = 15;
      string str63 = "16";
      items18[index80] = (object) str63;
      items17.AddRange(items18);
      this.ComboBoxDataBits.Location = new Point(527, 13);
      this.ComboBoxDataBits.Name = "ComboBoxDataBits";
      this.ComboBoxDataBits.Size = new Size(31, 20);
      this.ComboBoxDataBits.TabIndex = 665;
      this.ComboBoxDataBits.Text = "8";
      this.Label52.AutoSize = true;
      this.Label52.Location = new Point(408, 17);
      this.Label52.Name = "Label52";
      this.Label52.Size = new Size(32, 13);
      this.Label52.TabIndex = 664;
      this.Label52.Text = "Stop:";
      this.ComboBoxStopBits.Font = new Font("Microsoft Sans Serif", 7f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.ComboBoxStopBits.FormattingEnabled = true;
      ComboBox.ObjectCollection items19 = this.ComboBoxStopBits.Items;
      object[] items20 = new object[3];
      int index81 = 0;
      string str64 = "One";
      items20[index81] = (object) str64;
      int index82 = 1;
      string str65 = "OnePointFive";
      items20[index82] = (object) str65;
      int index83 = 2;
      string str66 = "Two";
      items20[index83] = (object) str66;
      items19.AddRange(items20);
      this.ComboBoxStopBits.Location = new Point(443, 13);
      this.ComboBoxStopBits.Name = "ComboBoxStopBits";
      this.ComboBoxStopBits.Size = new Size(44, 20);
      this.ComboBoxStopBits.TabIndex = 663;
      this.ComboBoxStopBits.Text = "One";
      this.Label49.AutoSize = true;
      this.Label49.Location = new Point(317, 17);
      this.Label49.Name = "Label49";
      this.Label49.Size = new Size(36, 13);
      this.Label49.TabIndex = 662;
      this.Label49.Text = "Pority:";
      this.ComboBoxParity.Font = new Font("Microsoft Sans Serif", 7f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.ComboBoxParity.FormattingEnabled = true;
      ComboBox.ObjectCollection items21 = this.ComboBoxParity.Items;
      object[] items22 = new object[3];
      int index84 = 0;
      string str67 = "Even";
      items22[index84] = (object) str67;
      int index85 = 1;
      string str68 = "None";
      items22[index85] = (object) str68;
      int index86 = 2;
      string str69 = "Odd";
      items22[index86] = (object) str69;
      items21.AddRange(items22);
      this.ComboBoxParity.Location = new Point(356, 13);
      this.ComboBoxParity.Name = "ComboBoxParity";
      this.ComboBoxParity.Size = new Size(47, 20);
      this.ComboBoxParity.TabIndex = 661;
      this.ComboBoxParity.Text = "None";
      this.Label48.AutoSize = true;
      this.Label48.Location = new Point(226, 41);
      this.Label48.Name = "Label48";
      this.Label48.Size = new Size(80, 13);
      this.Label48.TabIndex = 660;
      this.Label48.Text = "Add/New Test:";
      this.CheckBoxCheckTestInDBResult.AutoSize = true;
      this.CheckBoxCheckTestInDBResult.Checked = true;
      this.CheckBoxCheckTestInDBResult.CheckState = CheckState.Checked;
      this.CheckBoxCheckTestInDBResult.Location = new Point(6, 39);
      this.CheckBoxCheckTestInDBResult.Name = "CheckBoxCheckTestInDBResult";
      this.CheckBoxCheckTestInDBResult.Size = new Size(224, 17);
      this.CheckBoxCheckTestInDBResult.TabIndex = 659;
      this.CheckBoxCheckTestInDBResult.Text = "Exclue stored test while sending test order";
      this.CheckBoxCheckTestInDBResult.UseVisualStyleBackColor = true;
      this.ComboBoxOrderType.DropDownStyle = ComboBoxStyle.DropDownList;
      this.ComboBoxOrderType.Font = new Font("Microsoft Sans Serif", 7f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.ComboBoxOrderType.FormattingEnabled = true;
      ComboBox.ObjectCollection items23 = this.ComboBoxOrderType.Items;
      object[] items24 = new object[2];
      int index87 = 0;
      string str70 = "N";
      items24[index87] = (object) str70;
      int index88 = 1;
      string str71 = "A";
      items24[index88] = (object) str71;
      items23.AddRange(items24);
      this.ComboBoxOrderType.Location = new Point(307, 37);
      this.ComboBoxOrderType.Name = "ComboBoxOrderType";
      this.ComboBoxOrderType.Size = new Size(40, 20);
      this.ComboBoxOrderType.TabIndex = 310;
      this.Label24.AutoSize = true;
      this.Label24.Location = new Point(221, 17);
      this.Label24.Name = "Label24";
      this.Label24.Size = new Size(35, 13);
      this.Label24.TabIndex = 309;
      this.Label24.Text = "Baud:";
      this.Label22.AutoSize = true;
      this.Label22.Location = new Point(118, 17);
      this.Label22.Name = "Label22";
      this.Label22.Size = new Size(29, 13);
      this.Label22.TabIndex = 308;
      this.Label22.Text = "Port:";
      this.RadioButtonSerial.AutoSize = true;
      this.RadioButtonSerial.Checked = true;
      this.RadioButtonSerial.Location = new Point(68, 15);
      this.RadioButtonSerial.Name = "RadioButtonSerial";
      this.RadioButtonSerial.Size = new Size(51, 17);
      this.RadioButtonSerial.TabIndex = 307;
      this.RadioButtonSerial.TabStop = true;
      this.RadioButtonSerial.Text = "Serial";
      this.RadioButtonSerial.UseVisualStyleBackColor = true;
      this.RadioButtonTCPIP.AutoSize = true;
      this.RadioButtonTCPIP.Location = new Point(6, 15);
      this.RadioButtonTCPIP.Name = "RadioButtonTCPIP";
      this.RadioButtonTCPIP.Size = new Size(61, 17);
      this.RadioButtonTCPIP.TabIndex = 306;
      this.RadioButtonTCPIP.Text = "TCP/IP";
      this.RadioButtonTCPIP.UseVisualStyleBackColor = true;
      this.ComboBoxBaudRate.Font = new Font("Microsoft Sans Serif", 7f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.ComboBoxBaudRate.FormattingEnabled = true;
      ComboBox.ObjectCollection items25 = this.ComboBoxBaudRate.Items;
      object[] items26 = new object[2];
      int index89 = 0;
      string str72 = "9600";
      items26[index89] = (object) str72;
      int index90 = 1;
      string str73 = "115200";
      items26[index90] = (object) str73;
      items25.AddRange(items26);
      this.ComboBoxBaudRate.Location = new Point(259, 13);
      this.ComboBoxBaudRate.Name = "ComboBoxBaudRate";
      this.ComboBoxBaudRate.Size = new Size(54, 20);
      this.ComboBoxBaudRate.TabIndex = 305;
      this.ComboBoxBaudRate.Text = "9600";
      this.ComboBoxPortList.Font = new Font("Microsoft Sans Serif", 7f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.ComboBoxPortList.FormattingEnabled = true;
      this.ComboBoxPortList.Location = new Point(149, 13);
      this.ComboBoxPortList.Name = "ComboBoxPortList";
      this.ComboBoxPortList.Size = new Size(69, 20);
      this.ComboBoxPortList.TabIndex = 304;
      this.CheckBoxTest.AutoSize = true;
      this.CheckBoxTest.Location = new Point(374, 55);
      this.CheckBoxTest.Name = "CheckBoxTest";
      this.CheckBoxTest.Size = new Size(47, 17);
      this.CheckBoxTest.TabIndex = 306;
      this.CheckBoxTest.Text = "Test";
      this.CheckBoxTest.UseVisualStyleBackColor = true;
      this.DataGridView2.AllowUserToAddRows = false;
      this.DataGridView2.AllowUserToOrderColumns = true;
      this.DataGridView2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      DataGridViewColumnCollection columns2 = this.DataGridView2.Columns;
      DataGridViewColumn[] dataGridViewColumnArray2 = new DataGridViewColumn[16];
      int index91 = 0;
      DataGridViewTextBoxColumn fieldEx1 = this.FieldEx1;
      dataGridViewColumnArray2[index91] = (DataGridViewColumn) fieldEx1;
      int index92 = 1;
      DataGridViewTextBoxColumn fieldEx2 = this.FieldEx2;
      dataGridViewColumnArray2[index92] = (DataGridViewColumn) fieldEx2;
      int index93 = 2;
      DataGridViewTextBoxColumn fieldEx3 = this.FieldEx3;
      dataGridViewColumnArray2[index93] = (DataGridViewColumn) fieldEx3;
      int index94 = 3;
      DataGridViewTextBoxColumn fieldEx4 = this.FieldEx4;
      dataGridViewColumnArray2[index94] = (DataGridViewColumn) fieldEx4;
      int index95 = 4;
      DataGridViewTextBoxColumn fieldEx5 = this.FieldEx5;
      dataGridViewColumnArray2[index95] = (DataGridViewColumn) fieldEx5;
      int index96 = 5;
      DataGridViewTextBoxColumn fieldEx6 = this.FieldEx6;
      dataGridViewColumnArray2[index96] = (DataGridViewColumn) fieldEx6;
      int index97 = 6;
      DataGridViewTextBoxColumn fieldEx7 = this.FieldEx7;
      dataGridViewColumnArray2[index97] = (DataGridViewColumn) fieldEx7;
      int index98 = 7;
      DataGridViewTextBoxColumn fieldEx8 = this.FieldEx8;
      dataGridViewColumnArray2[index98] = (DataGridViewColumn) fieldEx8;
      int index99 = 8;
      DataGridViewTextBoxColumn fieldEx9 = this.FieldEx9;
      dataGridViewColumnArray2[index99] = (DataGridViewColumn) fieldEx9;
      int index100 = 9;
      DataGridViewTextBoxColumn fieldEx10 = this.FieldEx10;
      dataGridViewColumnArray2[index100] = (DataGridViewColumn) fieldEx10;
      int index101 = 10;
      DataGridViewTextBoxColumn fieldEx11 = this.FieldEx11;
      dataGridViewColumnArray2[index101] = (DataGridViewColumn) fieldEx11;
      int index102 = 11;
      DataGridViewTextBoxColumn fieldEx12 = this.FieldEx12;
      dataGridViewColumnArray2[index102] = (DataGridViewColumn) fieldEx12;
      int index103 = 12;
      DataGridViewTextBoxColumn fieldEx13 = this.FieldEx13;
      dataGridViewColumnArray2[index103] = (DataGridViewColumn) fieldEx13;
      int index104 = 13;
      DataGridViewTextBoxColumn fieldEx14 = this.FieldEx14;
      dataGridViewColumnArray2[index104] = (DataGridViewColumn) fieldEx14;
      int index105 = 14;
      DataGridViewTextBoxColumn fieldEx15 = this.FieldEx15;
      dataGridViewColumnArray2[index105] = (DataGridViewColumn) fieldEx15;
      int index106 = 15;
      DataGridViewTextBoxColumn fieldEx16 = this.FieldEx16;
      dataGridViewColumnArray2[index106] = (DataGridViewColumn) fieldEx16;
      columns2.AddRange(dataGridViewColumnArray2);
      this.DataGridView2.EditMode = DataGridViewEditMode.EditOnEnter;
      this.DataGridView2.Location = new Point(374, 466);
      this.DataGridView2.Margin = new Padding(4);
      this.DataGridView2.Name = "DataGridView2";
      gridViewCellStyle2.BackColor = Color.FromArgb((int) byte.MaxValue, 224, 192);
      gridViewCellStyle2.ForeColor = Color.Black;
      this.DataGridView2.RowsDefaultCellStyle = gridViewCellStyle2;
      this.DataGridView2.Size = new Size(796, 142);
      this.DataGridView2.TabIndex = 307;
      this.FieldEx1.HeaderText = "Field1";
      this.FieldEx1.Name = "FieldEx1";
      this.FieldEx1.ReadOnly = true;
      this.FieldEx1.Width = 80;
      this.FieldEx2.HeaderText = "Field2";
      this.FieldEx2.Name = "FieldEx2";
      this.FieldEx2.ReadOnly = true;
      this.FieldEx2.Width = 80;
      this.FieldEx3.HeaderText = "Track No.";
      this.FieldEx3.Name = "FieldEx3";
      this.FieldEx3.ReadOnly = true;
      this.FieldEx4.HeaderText = "Field4";
      this.FieldEx4.Name = "FieldEx4";
      this.FieldEx4.ReadOnly = true;
      gridViewCellStyle3.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.FieldEx5.DefaultCellStyle = gridViewCellStyle3;
      this.FieldEx5.HeaderText = "Result";
      this.FieldEx5.Name = "FieldEx5";
      this.FieldEx5.Width = 50;
      this.FieldEx6.HeaderText = "Field6";
      this.FieldEx6.Name = "FieldEx6";
      this.FieldEx6.ReadOnly = true;
      this.FieldEx6.Width = 80;
      this.FieldEx7.HeaderText = "Field7";
      this.FieldEx7.Name = "FieldEx7";
      this.FieldEx7.ReadOnly = true;
      this.FieldEx7.Width = 50;
      this.FieldEx8.HeaderText = "Field8";
      this.FieldEx8.Name = "FieldEx8";
      this.FieldEx8.ReadOnly = true;
      this.FieldEx8.Width = 50;
      this.FieldEx9.HeaderText = "Field9";
      this.FieldEx9.Name = "FieldEx9";
      this.FieldEx9.ReadOnly = true;
      this.FieldEx9.Width = 50;
      this.FieldEx10.HeaderText = "Field10";
      this.FieldEx10.Name = "FieldEx10";
      this.FieldEx10.ReadOnly = true;
      this.FieldEx10.Width = 50;
      this.FieldEx11.HeaderText = "Field11";
      this.FieldEx11.Name = "FieldEx11";
      this.FieldEx11.ReadOnly = true;
      this.FieldEx11.Width = 50;
      this.FieldEx12.HeaderText = "Field12";
      this.FieldEx12.Name = "FieldEx12";
      this.FieldEx12.ReadOnly = true;
      this.FieldEx12.Width = 50;
      this.FieldEx13.HeaderText = "Field13";
      this.FieldEx13.Name = "FieldEx13";
      this.FieldEx13.ReadOnly = true;
      this.FieldEx13.Width = 50;
      this.FieldEx14.HeaderText = "Field14";
      this.FieldEx14.Name = "FieldEx14";
      this.FieldEx14.ReadOnly = true;
      this.FieldEx14.Width = 50;
      this.FieldEx15.HeaderText = "Field15";
      this.FieldEx15.Name = "FieldEx15";
      this.FieldEx15.ReadOnly = true;
      this.FieldEx15.Width = 50;
      this.FieldEx16.HeaderText = "Test Code";
      this.FieldEx16.Name = "FieldEx16";
      this.FieldEx16.ReadOnly = true;
      this.FieldEx16.Width = 50;
      this.ButtonImportException.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.ButtonImportException.BackColor = SystemColors.Control;
      this.ButtonImportException.ForeColor = Color.FromArgb(64, 0, 0);
      this.ButtonImportException.Location = new Point(1014, 617);
      this.ButtonImportException.Name = "ButtonImportException";
      this.ButtonImportException.Size = new Size(153, 27);
      this.ButtonImportException.TabIndex = 308;
      this.ButtonImportException.Text = "Import Exception Data";
      this.ButtonImportException.UseVisualStyleBackColor = false;
      this.TextBoxTrackForTestOrder.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      this.TextBoxTrackForTestOrder.BorderStyle = BorderStyle.FixedSingle;
      this.TextBoxTrackForTestOrder.Font = new Font("Microsoft Sans Serif", 11f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.TextBoxTrackForTestOrder.Location = new Point(86, 646);
      this.TextBoxTrackForTestOrder.Name = "TextBoxTrackForTestOrder";
      this.TextBoxTrackForTestOrder.Size = new Size(124, 24);
      this.TextBoxTrackForTestOrder.TabIndex = 309;
      this.Label25.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      this.Label25.AutoSize = true;
      this.Label25.Location = new Point(87, 632);
      this.Label25.Name = "Label25";
      this.Label25.Size = new Size(115, 13);
      this.Label25.TabIndex = 311;
      this.Label25.Text = "Track no. for test order";
      this.TextBoxLISData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
      this.TextBoxLISData.BackColor = Color.Black;
      this.TextBoxLISData.ForeColor = Color.Yellow;
      this.TextBoxLISData.Location = new Point(930, 72);
      this.TextBoxLISData.Multiline = true;
      this.TextBoxLISData.Name = "TextBoxLISData";
      this.TextBoxLISData.ScrollBars = ScrollBars.Both;
      this.TextBoxLISData.Size = new Size(240, 536);
      this.TextBoxLISData.TabIndex = 651;
      this.TextBoxLISData.WordWrap = false;
      this.ButtonSendTestOrder.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      this.ButtonSendTestOrder.Location = new Point(211, 645);
      this.ButtonSendTestOrder.Name = "ButtonSendTestOrder";
      this.ButtonSendTestOrder.Size = new Size(100, 26);
      this.ButtonSendTestOrder.TabIndex = 654;
      this.ButtonSendTestOrder.Text = "Send Order";
      this.ButtonSendTestOrder.UseVisualStyleBackColor = true;
      this.TextBoxLISRespond.Location = new Point(220, 34);
      this.TextBoxLISRespond.Multiline = true;
      this.TextBoxLISRespond.Name = "TextBoxLISRespond";
      this.TextBoxLISRespond.ScrollBars = ScrollBars.Vertical;
      this.TextBoxLISRespond.Size = new Size(146, 34);
      this.TextBoxLISRespond.TabIndex = 657;
      this.ButtonENQ.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      this.ButtonENQ.Location = new Point(312, 645);
      this.ButtonENQ.Name = "ButtonENQ";
      this.ButtonENQ.Size = new Size(53, 26);
      this.ButtonENQ.TabIndex = 658;
      this.ButtonENQ.Text = "ENQ";
      this.ButtonENQ.UseVisualStyleBackColor = true;
      this.ComboBoxDepartment.AccessibleDescription = "";
      this.ComboBoxDepartment.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
      this.ComboBoxDepartment.AutoCompleteSource = AutoCompleteSource.ListItems;
      this.ComboBoxDepartment.FlatStyle = FlatStyle.Popup;
      this.ComboBoxDepartment.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.ComboBoxDepartment.FormattingEnabled = true;
      this.ComboBoxDepartment.Location = new Point(78, 5);
      this.ComboBoxDepartment.Margin = new Padding(4);
      this.ComboBoxDepartment.Name = "ComboBoxDepartment";
      this.ComboBoxDepartment.Size = new Size(289, 24);
      this.ComboBoxDepartment.Sorted = true;
      this.ComboBoxDepartment.TabIndex = 659;
      this.Label54.AutoSize = true;
      this.Label54.Location = new Point(9, 11);
      this.Label54.Margin = new Padding(4, 0, 4, 0);
      this.Label54.Name = "Label54";
      this.Label54.Size = new Size(62, 13);
      this.Label54.TabIndex = 660;
      this.Label54.Text = "Department";
      this.ButtonBulkImport.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.ButtonBulkImport.Location = new Point(1015, 644);
      this.ButtonBulkImport.Name = "ButtonBulkImport";
      this.ButtonBulkImport.Size = new Size(77, 27);
      this.ButtonBulkImport.TabIndex = 661;
      this.ButtonBulkImport.Text = "Bulk Import";
      this.ButtonBulkImport.UseVisualStyleBackColor = true;
      this.Label47.AutoSize = true;
      this.Label47.BackColor = SystemColors.Control;
      this.Label47.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label47.Location = new Point(254, 486);
      this.Label47.Name = "Label47";
      this.Label47.Size = new Size(32, 16);
      this.Label47.TabIndex = 665;
      this.Label47.Text = "Port";
      this.TextBoxLISPort.BorderStyle = BorderStyle.FixedSingle;
      this.TextBoxLISPort.Location = new Point(292, 484);
      this.TextBoxLISPort.Name = "TextBoxLISPort";
      this.TextBoxLISPort.Size = new Size(66, 20);
      this.TextBoxLISPort.TabIndex = 664;
      this.Label55.AutoSize = true;
      this.Label55.BackColor = SystemColors.Control;
      this.Label55.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label55.Location = new Point(8, 486);
      this.Label55.Name = "Label55";
      this.Label55.Size = new Size(42, 16);
      this.Label55.TabIndex = 663;
      this.Label55.Text = "LIS IP";
      this.ComboBoxLISIPAddress.FormattingEnabled = true;
      this.ComboBoxLISIPAddress.Location = new Point(86, 484);
      this.ComboBoxLISIPAddress.Name = "ComboBoxLISIPAddress";
      this.ComboBoxLISIPAddress.Size = new Size(162, 21);
      this.ComboBoxLISIPAddress.TabIndex = 666;
      this.DataGridViewTextBoxColumn1.HeaderText = "Track Number";
      this.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1";
      this.DataGridViewTextBoxColumn1.ReadOnly = true;
      this.DataGridViewTextBoxColumn1.Width = 80;
      this.DataGridViewTextBoxColumn2.HeaderText = "Patient ID";
      this.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2";
      this.DataGridViewTextBoxColumn2.ReadOnly = true;
      this.DataGridViewTextBoxColumn2.Width = 80;
      this.DataGridViewTextBoxColumn3.HeaderText = "PatientName";
      this.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3";
      this.DataGridViewTextBoxColumn3.ReadOnly = true;
      this.DataGridViewTextBoxColumn3.Width = 200;
      this.DataGridViewTextBoxColumn4.HeaderText = "Patient Phone 1";
      this.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4";
      this.DataGridViewTextBoxColumn4.ReadOnly = true;
      this.DataGridViewTextBoxColumn4.Width = 150;
      gridViewCellStyle4.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.DataGridViewTextBoxColumn5.DefaultCellStyle = gridViewCellStyle4;
      this.DataGridViewTextBoxColumn5.HeaderText = "Patient Phone 2";
      this.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5";
      this.DataGridViewTextBoxColumn5.ReadOnly = true;
      this.DataGridViewTextBoxColumn5.Width = 150;
      this.DataGridViewTextBoxColumn6.HeaderText = "Total Charge";
      this.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6";
      this.DataGridViewTextBoxColumn6.ReadOnly = true;
      this.DataGridViewTextBoxColumn6.Resizable = DataGridViewTriState.True;
      this.DataGridViewTextBoxColumn6.SortMode = DataGridViewColumnSortMode.NotSortable;
      this.DataGridViewTextBoxColumn6.Width = 80;
      this.DataGridViewTextBoxColumn7.HeaderText = "Doctor Name";
      this.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7";
      this.DataGridViewTextBoxColumn7.ReadOnly = true;
      this.DataGridViewTextBoxColumn7.Resizable = DataGridViewTriState.True;
      this.DataGridViewTextBoxColumn7.SortMode = DataGridViewColumnSortMode.NotSortable;
      this.DataGridViewTextBoxColumn7.Width = 200;
      this.DataGridViewTextBoxColumn8.HeaderText = "Doctor Status";
      this.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8";
      this.DataGridViewTextBoxColumn8.ReadOnly = true;
      this.DataGridViewTextBoxColumn8.Width = 50;
      this.DataGridViewTextBoxColumn9.HeaderText = "Field9";
      this.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9";
      this.DataGridViewTextBoxColumn9.ReadOnly = true;
      this.DataGridViewTextBoxColumn9.Width = 50;
      this.DataGridViewTextBoxColumn10.HeaderText = "Field10";
      this.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10";
      this.DataGridViewTextBoxColumn10.ReadOnly = true;
      this.DataGridViewTextBoxColumn10.Width = 50;
      this.DataGridViewTextBoxColumn11.HeaderText = "Field11";
      this.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11";
      this.DataGridViewTextBoxColumn11.ReadOnly = true;
      this.DataGridViewTextBoxColumn11.Width = 50;
      this.DataGridViewTextBoxColumn12.HeaderText = "Field12";
      this.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12";
      this.DataGridViewTextBoxColumn12.ReadOnly = true;
      this.DataGridViewTextBoxColumn12.Width = 50;
      this.DataGridViewTextBoxColumn13.HeaderText = "Field13";
      this.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13";
      this.DataGridViewTextBoxColumn13.ReadOnly = true;
      this.DataGridViewTextBoxColumn13.Width = 50;
      this.DataGridViewTextBoxColumn14.HeaderText = "Field14";
      this.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14";
      this.DataGridViewTextBoxColumn14.ReadOnly = true;
      this.DataGridViewTextBoxColumn14.Width = 50;
      this.DataGridViewTextBoxColumn15.HeaderText = "Field15";
      this.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15";
      this.DataGridViewTextBoxColumn15.ReadOnly = true;
      this.DataGridViewTextBoxColumn15.Width = 50;
      this.DataGridViewTextBoxColumn16.HeaderText = "Field16";
      this.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16";
      this.DataGridViewTextBoxColumn16.ReadOnly = true;
      this.DataGridViewTextBoxColumn16.Width = 30;
      this.DataGridViewTextBoxColumn17.HeaderText = "Field1";
      this.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17";
      this.DataGridViewTextBoxColumn17.ReadOnly = true;
      this.DataGridViewTextBoxColumn17.Width = 80;
      this.DataGridViewTextBoxColumn18.HeaderText = "Field2";
      this.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18";
      this.DataGridViewTextBoxColumn18.ReadOnly = true;
      this.DataGridViewTextBoxColumn18.Width = 80;
      this.DataGridViewTextBoxColumn19.HeaderText = "Track No.";
      this.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19";
      this.DataGridViewTextBoxColumn19.ReadOnly = true;
      this.DataGridViewTextBoxColumn20.HeaderText = "Field4";
      this.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20";
      this.DataGridViewTextBoxColumn20.ReadOnly = true;
      gridViewCellStyle5.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.DataGridViewTextBoxColumn21.DefaultCellStyle = gridViewCellStyle5;
      this.DataGridViewTextBoxColumn21.HeaderText = "Result";
      this.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21";
      this.DataGridViewTextBoxColumn21.Width = 50;
      this.DataGridViewTextBoxColumn22.HeaderText = "Field6";
      this.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22";
      this.DataGridViewTextBoxColumn22.ReadOnly = true;
      this.DataGridViewTextBoxColumn22.Width = 80;
      this.DataGridViewTextBoxColumn23.HeaderText = "Field7";
      this.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23";
      this.DataGridViewTextBoxColumn23.ReadOnly = true;
      this.DataGridViewTextBoxColumn23.Width = 50;
      this.DataGridViewTextBoxColumn24.HeaderText = "Field8";
      this.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24";
      this.DataGridViewTextBoxColumn24.ReadOnly = true;
      this.DataGridViewTextBoxColumn24.Width = 50;
      this.DataGridViewTextBoxColumn25.HeaderText = "Field9";
      this.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25";
      this.DataGridViewTextBoxColumn25.ReadOnly = true;
      this.DataGridViewTextBoxColumn25.Width = 50;
      this.DataGridViewTextBoxColumn26.HeaderText = "Field10";
      this.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26";
      this.DataGridViewTextBoxColumn26.ReadOnly = true;
      this.DataGridViewTextBoxColumn26.Width = 50;
      this.DataGridViewTextBoxColumn27.HeaderText = "Field11";
      this.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27";
      this.DataGridViewTextBoxColumn27.ReadOnly = true;
      this.DataGridViewTextBoxColumn27.Width = 50;
      this.DataGridViewTextBoxColumn28.HeaderText = "Field12";
      this.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28";
      this.DataGridViewTextBoxColumn28.ReadOnly = true;
      this.DataGridViewTextBoxColumn28.Width = 50;
      this.DataGridViewTextBoxColumn29.HeaderText = "Field13";
      this.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29";
      this.DataGridViewTextBoxColumn29.ReadOnly = true;
      this.DataGridViewTextBoxColumn29.Width = 50;
      this.DataGridViewTextBoxColumn30.HeaderText = "Field14";
      this.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30";
      this.DataGridViewTextBoxColumn30.ReadOnly = true;
      this.DataGridViewTextBoxColumn30.Width = 50;
      this.DataGridViewTextBoxColumn31.HeaderText = "Field15";
      this.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31";
      this.DataGridViewTextBoxColumn31.ReadOnly = true;
      this.DataGridViewTextBoxColumn31.Width = 50;
      this.DataGridViewTextBoxColumn32.HeaderText = "Test Code";
      this.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32";
      this.DataGridViewTextBoxColumn32.ReadOnly = true;
      this.DataGridViewTextBoxColumn32.Width = 50;
      this.DataGridViewTextBoxColumn33.HeaderText = "Test Code";
      this.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33";
      this.DataGridViewTextBoxColumn33.ReadOnly = true;
      this.DataGridViewTextBoxColumn33.Width = 50;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1170, 672);
      this.Controls.Add((Control) this.ComboBoxLISIPAddress);
      this.Controls.Add((Control) this.Label47);
      this.Controls.Add((Control) this.TextBoxLISPort);
      this.Controls.Add((Control) this.Label55);
      this.Controls.Add((Control) this.ButtonBulkImport);
      this.Controls.Add((Control) this.ComboBoxDepartment);
      this.Controls.Add((Control) this.Label54);
      this.Controls.Add((Control) this.ButtonENQ);
      this.Controls.Add((Control) this.Label9);
      this.Controls.Add((Control) this.TextBoxLISRespond);
      this.Controls.Add((Control) this.ComboBoxTestFileMachineName);
      this.Controls.Add((Control) this.ButtonSendTestOrder);
      this.Controls.Add((Control) this.DataGridView1);
      this.Controls.Add((Control) this.Label25);
      this.Controls.Add((Control) this.TextBoxTrackForTestOrder);
      this.Controls.Add((Control) this.ButtonImportException);
      this.Controls.Add((Control) this.CheckBoxLIS);
      this.Controls.Add((Control) this.DataGridView2);
      this.Controls.Add((Control) this.CheckBoxTest);
      this.Controls.Add((Control) this.GroupBoxCommunication);
      this.Controls.Add((Control) this.TextBoxResponseMessage);
      this.Controls.Add((Control) this.RadioButtonExcelFile);
      this.Controls.Add((Control) this.GroupBox2);
      this.Controls.Add((Control) this.RadioButtonAbbottFile);
      this.Controls.Add((Control) this.GroupBox1);
      this.Controls.Add((Control) this.RadioButtonTextFile);
      this.Controls.Add((Control) this.RadioButtonMicrosoftAccessFile);
      this.Controls.Add((Control) this.GroupBoxTextFile);
      this.Controls.Add((Control) this.GroupBoxAccessFile);
      this.Controls.Add((Control) this.ButtonShowData);
      this.Controls.Add((Control) this.DateTimePickerTimeTo);
      this.Controls.Add((Control) this.DateTimePickerTimeFrom);
      this.Controls.Add((Control) this.ButtonSave);
      this.Controls.Add((Control) this.ComboBoxCheckSum4Format);
      this.Controls.Add((Control) this.ComboBoxCheckSum3Format);
      this.Controls.Add((Control) this.CheckBoxFile4STX);
      this.Controls.Add((Control) this.CheckBoxFile3STX);
      this.Controls.Add((Control) this.CheckBoxFile4CheckSum);
      this.Controls.Add((Control) this.CheckBoxFile3CheckSum);
      this.Controls.Add((Control) this.CheckBoxFile4CRLF);
      this.Controls.Add((Control) this.CheckBoxFile3CRLF);
      this.Controls.Add((Control) this.Label36);
      this.Controls.Add((Control) this.Label46);
      this.Controls.Add((Control) this.Label35);
      this.Controls.Add((Control) this.Label51);
      this.Controls.Add((Control) this.Label50);
      this.Controls.Add((Control) this.Label45);
      this.Controls.Add((Control) this.Label34);
      this.Controls.Add((Control) this.ButtonFile4);
      this.Controls.Add((Control) this.Label44);
      this.Controls.Add((Control) this.ButtonFile3);
      this.Controls.Add((Control) this.Label33);
      this.Controls.Add((Control) this.TextBoxFile4);
      this.Controls.Add((Control) this.TextBoxFile3);
      this.Controls.Add((Control) this.Label43);
      this.Controls.Add((Control) this.Label32);
      this.Controls.Add((Control) this.Label42);
      this.Controls.Add((Control) this.Label31);
      this.Controls.Add((Control) this.TextBoxFile4Col10);
      this.Controls.Add((Control) this.TextBoxFile3Col10);
      this.Controls.Add((Control) this.TextBoxFile4Res1);
      this.Controls.Add((Control) this.TextBoxFile3Res1);
      this.Controls.Add((Control) this.TextBoxFile4Col8);
      this.Controls.Add((Control) this.TextBoxFile3Col8);
      this.Controls.Add((Control) this.ButtonImportData);
      this.Controls.Add((Control) this.TextBoxFile4Col6);
      this.Controls.Add((Control) this.TextBoxFile3Col6);
      this.Controls.Add((Control) this.TextBoxFile4STX);
      this.Controls.Add((Control) this.TextBoxFile3STX);
      this.Controls.Add((Control) this.TextBoxFile4Col4);
      this.Controls.Add((Control) this.GroupBoxSearch);
      this.Controls.Add((Control) this.TextBoxFile3Col4);
      this.Controls.Add((Control) this.TextBoxFile4Col2);
      this.Controls.Add((Control) this.TextBoxFile3Col2);
      this.Controls.Add((Control) this.DTPTo);
      this.Controls.Add((Control) this.Label41);
      this.Controls.Add((Control) this.Label30);
      this.Controls.Add((Control) this.Label2);
      this.Controls.Add((Control) this.Label40);
      this.Controls.Add((Control) this.Label29);
      this.Controls.Add((Control) this.DTPFrom);
      this.Controls.Add((Control) this.Label39);
      this.Controls.Add((Control) this.Label28);
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.Label38);
      this.Controls.Add((Control) this.Label27);
      this.Controls.Add((Control) this.Label37);
      this.Controls.Add((Control) this.Label26);
      this.Controls.Add((Control) this.TextBoxFile4Col1);
      this.Controls.Add((Control) this.TextBoxFile3Col1);
      this.Controls.Add((Control) this.TextBoxFile4Col3);
      this.Controls.Add((Control) this.TextBoxFile3Col3);
      this.Controls.Add((Control) this.TextBoxFile4Col9);
      this.Controls.Add((Control) this.TextBoxFile3Col9);
      this.Controls.Add((Control) this.TextBoxFile4Col5);
      this.Controls.Add((Control) this.TextBoxFile3Col5);
      this.Controls.Add((Control) this.TextBoxFile4Col7);
      this.Controls.Add((Control) this.TextBoxFile3Col7);
      this.Controls.Add((Control) this.TextBoxLISData);
      this.Name = "PMS_DataImport";
      this.Text = "LIS";
      this.WindowState = FormWindowState.Maximized;
      this.GroupBoxSearch.ResumeLayout(false);
      this.GroupBoxSearch.PerformLayout();
      this.DataGridView1.EndInit();
      this.GroupBoxAccessFile.ResumeLayout(false);
      this.GroupBoxAccessFile.PerformLayout();
      this.GroupBoxTextFile.ResumeLayout(false);
      this.GroupBoxTextFile.PerformLayout();
      this.GroupBox1.ResumeLayout(false);
      this.GroupBox1.PerformLayout();
      this.GroupBox2.ResumeLayout(false);
      this.GroupBox2.PerformLayout();
      this.GroupBoxCommunication.ResumeLayout(false);
      this.GroupBoxCommunication.PerformLayout();
      this.DataGridView2.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private void DataImport_Disposed(object sender, EventArgs e)
    {
      RegisterMicrosoftVisualStudio.ds.Tables.Clear();
      if (this.SerialPortArchitect.IsOpen)
        this.SerialPortArchitect.Close();
      if (this.SerialPortELITE.IsOpen)
        this.SerialPortELITE.Close();
      if (this.SerialPortCellDynRuby.IsOpen)
        this.SerialPortCellDynRuby.Close();
      if (this.SerialPortImmulite2000.IsOpen)
        this.SerialPortImmulite2000.Close();
      if (this.SerialPortSiemensDimension.IsOpen)
        this.SerialPortSiemensDimension.Close();
      if (this.SerialPortSysmex.IsOpen)
        this.SerialPortSysmex.Close();
      if (this.SerialPortBioradD10.IsOpen)
        this.SerialPortBioradD10.Close();
      if (this.SerialPortBioradVariant.IsOpen)
        this.SerialPortBioradVariant.Close();
      if (this.SerialPortCelltacChemi.IsOpen)
        this.SerialPortCelltacChemi.Close();
      if (this.SerialPortVIDAS.IsOpen)
        this.SerialPortVIDAS.Close();
      if (!Information.IsNothing((object) this.server))
      {
        this.server.IsListining = false;
        this.server.CommThread.Abort();
        this.server.Server.Stop();
        this.server = (HL7Control) null;
      }
      if (Information.IsNothing((object) this.ASTMServer))
        return;
      this.ASTMServer.IsListining = false;
      this.ASTMServer.CommThread.Abort();
      this.ASTMServer.Server.Stop();
      this.ASTMServer = (ASTMControl) null;
    }

    private void DataImport_FormClosing(object sender, FormClosingEventArgs e)
    {
      RegisterMicrosoftVisualStudio.ds.Tables.Clear();
      if (this.SerialPortArchitect.IsOpen)
        this.SerialPortArchitect.Close();
      if (this.SerialPortELITE.IsOpen)
        this.SerialPortELITE.Close();
      if (this.SerialPortCellDynRuby.IsOpen)
        this.SerialPortCellDynRuby.Close();
      if (this.SerialPortImmulite2000.IsOpen)
        this.SerialPortImmulite2000.Close();
      if (this.SerialPortSiemensDimension.IsOpen)
        this.SerialPortSiemensDimension.Close();
      if (this.SerialPortSysmex.IsOpen)
        this.SerialPortSysmex.Close();
      if (this.SerialPortBioradD10.IsOpen)
        this.SerialPortBioradD10.Close();
      if (this.SerialPortBioradVariant.IsOpen)
        this.SerialPortBioradVariant.Close();
      if (this.SerialPortCelltacChemi.IsOpen)
        this.SerialPortCelltacChemi.Close();
      if (this.SerialPortVIDAS.IsOpen)
        this.SerialPortVIDAS.Close();
      if (!Information.IsNothing((object) this.server))
      {
        this.server.IsListining = false;
        this.server.CommThread.Abort();
        this.server.Server.Stop();
        this.server = (HL7Control) null;
      }
      if (Information.IsNothing((object) this.ASTMServer))
        return;
      this.ASTMServer.IsListining = false;
      this.ASTMServer.CommThread.Abort();
      this.ASTMServer.Server.Stop();
      this.ASTMServer = (ASTMControl) null;
    }

    private void DataImport_Load(object sender, EventArgs e)
    {
      RegisterMicrosoftVisualStudio.ds.Tables.Clear();
      this.WindowState = FormWindowState.Maximized;
      this.DateTimePickerTimeFrom.Text = "12:00 AM";
      this.DateTimePickerTimeTo.Text = "11:59 PM";
      this.ComboBoxTestFileTestName.SelectedIndex = 0;
      this.ComboBoxTestFileMachineName.SelectedIndex = 0;
      string networkMacAddress = RegisterMicrosoftVisualStudio.getNetworkMacAddress();
      this.ComboBoxLISIPAddress.Text = RegisterMicrosoftVisualStudio.GetSingleData("DeviceMacAddress", "LISIPAddress", "select top 1 LISIPAddress from DeviceMacAddress where replace(DeviceMacAddress,':','') in (" + networkMacAddress + ") and DeviceStatus='A' and len(LISIPAddress)>2");
      this.TextBoxLISPort.Text = RegisterMicrosoftVisualStudio.GetSingleData("DeviceMacAddress", "LISIPPort", "select top 1 LISIPPort from DeviceMacAddress where replace(DeviceMacAddress,':','') in (" + networkMacAddress + ") and DeviceStatus='A' and len(LISIPAddress)>2");
      ModUpdateDatabase.IP = this.ComboBoxLISIPAddress.Text;
      ModUpdateDatabase.port = Conversions.ToInteger(this.TextBoxLISPort.Text);
      this.myPort = (Array) SerialPort.GetPortNames();
      this.ComboBoxPortList.Items.AddRange((object[]) this.myPort);
      RegisterMicrosoftVisualStudio.SqlText = "SELECT CODE, NAME FROM Department";
      RegisterMicrosoftVisualStudio.da.SelectCommand = new OleDbCommand(RegisterMicrosoftVisualStudio.SqlText, RegisterMicrosoftVisualStudio.Conn);
      if (RegisterMicrosoftVisualStudio.ds.Tables["Department"] != null)
        RegisterMicrosoftVisualStudio.ds.Tables["Department"].Clear();
      ((DbDataAdapter) RegisterMicrosoftVisualStudio.da).Fill(RegisterMicrosoftVisualStudio.ds, "Department");
      ComboBox cbo;
      if (RegisterMicrosoftVisualStudio.ds.Tables["Department"].Rows.Count > 0)
      {
        cbo = this.ComboBoxDepartment;
        RegisterMicrosoftVisualStudio.PopulateComboV2(ref cbo, RegisterMicrosoftVisualStudio.ds.Tables["Department"], "NAME", (string) null);
        this.ComboBoxDepartment = cbo;
      }
      RegisterMicrosoftVisualStudio.SqlText = "select Distinct MachineName from LISAssayList";
      RegisterMicrosoftVisualStudio.da.SelectCommand = new OleDbCommand(RegisterMicrosoftVisualStudio.SqlText, RegisterMicrosoftVisualStudio.Conn);
      if (RegisterMicrosoftVisualStudio.ds.Tables["MachineName"] != null)
        RegisterMicrosoftVisualStudio.ds.Tables["MachineName"].Clear();
      ((DbDataAdapter) RegisterMicrosoftVisualStudio.da).Fill(RegisterMicrosoftVisualStudio.ds, "MachineName");
      if (RegisterMicrosoftVisualStudio.ds.Tables["MachineName"].Rows.Count > 0)
      {
        cbo = this.ComboBoxTestFileMachineName;
        RegisterMicrosoftVisualStudio.PopulateComboV2(ref cbo, RegisterMicrosoftVisualStudio.ds.Tables["MachineName"], "MachineName", (string) null);
        this.ComboBoxTestFileMachineName = cbo;
      }
      RegisterMicrosoftVisualStudio.SqlText = "exec spPatientDepartmentTests '" + this.ComboBoxDepartment.Text + "'";
      RegisterMicrosoftVisualStudio.cmd = new OleDbCommand(RegisterMicrosoftVisualStudio.SqlText, RegisterMicrosoftVisualStudio.Conn);
      RegisterMicrosoftVisualStudio.da.SelectCommand = RegisterMicrosoftVisualStudio.cmd;
      if (RegisterMicrosoftVisualStudio.ds.Tables["LISTestCodeList"] != null)
        RegisterMicrosoftVisualStudio.ds.Tables["LISTestCodeList"].Clear();
      ((DbDataAdapter) RegisterMicrosoftVisualStudio.da).Fill(RegisterMicrosoftVisualStudio.ds, "LISTestCodeList");
      this.LISBarcode8Bit = RegisterMicrosoftVisualStudio.GetSingleData("DefaultSettingPMS", "LISBarcode8Bit", "SELECT Top 1 coalesce([LISBarcode8Bit],'3') as [LISBarcode8Bit] FROM [DefaultSettingPMS]");
      if (this.ComboBoxPortList.Items.Count > 0)
        this.ComboBoxPortList.SelectedIndex = checked (this.ComboBoxPortList.Items.Count - 1);
      this.MachineName = this.ComboBoxTestFileMachineName.Text;
      this.MachineIndex = this.ComboBoxTestFileMachineName.SelectedIndex;
      this.dtLISResult.Columns.Add("PatientID", typeof (string));
      this.dtLISResult.Columns.Add("TrackNumber", typeof (string));
      this.dtLISResult.Columns.Add("TestCode", typeof (string));
      this.dtLISResult.Columns.Add("TestName", typeof (string));
      this.dtLISResult.Columns.Add("Result", typeof (string));
      this.dtLISResult.Columns.Add("LISTestCode", typeof (string));
      this.dtLISResult.Columns.Add("RackPosition", typeof (string));
      this.dtLISResult.Columns.Add("TestTime", typeof (string));
      this.ComboBoxOrderType.Text = "N";
    }

    private void getNetworkIPAddress()
    {
      try
      {
        NetworkInterface[] networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
        int index = 0;
        while (index < networkInterfaces.Length)
        {
          NetworkInterface networkInterface = networkInterfaces[index];
          IPInterfaceProperties ipProperties = networkInterface.GetIPProperties();
          try
          {
            foreach (UnicastIPAddressInformation addressInformation in ipProperties.UnicastAddresses)
            {
              if (addressInformation.Address.AddressFamily == AddressFamily.InterNetwork && networkInterface.OperationalStatus == OperationalStatus.Up)
                this.ComboBoxLISIPAddress.Items.Add((object) addressInformation.Address.ToString());
            }
          }
          finally
          {
            IEnumerator<UnicastIPAddressInformation> enumerator;
            if (enumerator != null)
              enumerator.Dispose();
          }
          checked { ++index; }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) MessageBox.Show(ex.Message);
        ProjectData.ClearProjectError();
      }
    }

    private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex == -1 || e.ColumnIndex == -1)
        return;
      this.GroupBoxSearch.Text = "Search by - " + this.DataGridView1.Columns[e.ColumnIndex].HeaderText;
      this.col = e.ColumnIndex;
    }

    private void TextBoxSearchValue_TextChanged(object sender, EventArgs e)
    {
      string Pattern = "*" + this.TextBoxSearchValue.Text.ToUpper() + "*";
      int num = checked (this.DataGridView1.Rows.Count - 1);
      int index = 0;
      while (index <= num)
      {
        this.DataGridView1.Rows[index].Visible = Conversions.ToBoolean(Interaction.IIf(LikeOperator.LikeString(this.DataGridView1[this.col, index].Value.ToString().ToUpper(), Pattern, CompareMethod.Binary), (object) true, (object) false));
        checked { ++index; }
      }
    }

    private void ButtonFile1_Click(object sender, EventArgs e)
    {
      SaveFileDialog saveFileDialog = new SaveFileDialog();
      saveFileDialog.Filter = "work files (*.wrk)|*.wrk|All files (*.*)|*.*";
      saveFileDialog.FilterIndex = 1;
      saveFileDialog.RestoreDirectory = true;
      if (saveFileDialog.ShowDialog() == DialogResult.OK)
        this.TextBoxAccessFile.Text = saveFileDialog.FileName;
      else
        this.TextBoxAccessFile.Text = "";
    }

    private bool NotValidData()
    {
      int num1 = checked (this.DataGridView1.Rows.Count - 1);
      int index1 = 0;
      while (index1 <= num1)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectNotEqual(this.DataGridView1[2, index1].Value, (object) "", false))
        {
          string str1 = Conversions.ToString(this.DataGridView1[2, index1].Value);
          string str2 = Conversions.ToString(this.DataGridView1[15, index1].Value);
          this.DataGridView1.Rows[index1].Selected = true;
          int num2 = checked (index1 + 1);
          int num3 = checked (this.DataGridView1.Rows.Count - 1);
          int index2 = num2;
          while (index2 <= num3)
          {
            if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView1[2, index2].Value, (object) str1, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView1[15, index2].Value, (object) str2, false))))
            {
              this.DataGridView1.Rows[index2].Selected = true;
              int num4 = (int) MessageBox.Show("Duplicate test result", "Mazeda Technologies", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
              return true;
            }
            else
              checked { ++index2; }
          }
          this.DataGridView1.Rows[index1].Selected = false;
        }
        checked { ++index1; }
      }
      return false;
    }

    private bool NotValidExceptionData()
    {
      int num1 = checked (this.DataGridView2.Rows.Count - 2);
      int index1 = 0;
      while (index1 <= num1)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectNotEqual(this.DataGridView2[2, index1].Value, (object) "", false))
        {
          string str1 = Conversions.ToString(this.DataGridView2[2, index1].Value);
          string str2 = Conversions.ToString(this.DataGridView2[15, index1].Value);
          this.DataGridView2.Rows[index1].Selected = true;
          int num2 = checked (index1 + 1);
          int num3 = checked (this.DataGridView2.Rows.Count - 1);
          int index2 = num2;
          while (index2 <= num3)
          {
            if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView2[2, index2].Value, (object) str1, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView2[15, index2].Value, (object) str2, false))))
            {
              this.DataGridView2.Rows[index2].Selected = true;
              int num4 = (int) MessageBox.Show("Duplicate test result", "Mazeda Technologies", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
              return true;
            }
            else
              checked { ++index2; }
          }
          this.DataGridView2.Rows[index1].Selected = false;
        }
        checked { ++index1; }
      }
      return false;
    }

    private void ButtonSave_Click(object sender, EventArgs e)
    {
      object obj = (object) this;
      RegisterMicrosoftVisualStudio.SingleQuoteReplace(ref obj);
      if (this.NotValidData() || MessageBox.Show("Are you confirm to change setup?", RegisterMicrosoftVisualStudio.mazedatech, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
        return;
      string[] strArray1 = new string[19];
      int index1 = 0;
      string str1 = "UPDATE [DataImport] SET [FileName] ='";
      strArray1[index1] = str1;
      int index2 = 1;
      string text1 = this.TextBoxAccessFile.Text;
      strArray1[index2] = text1;
      int index3 = 2;
      string str2 = "',[UserName] = '";
      strArray1[index3] = str2;
      int index4 = 3;
      string text2 = this.TextBoxAccessFileUserName.Text;
      strArray1[index4] = text2;
      int index5 = 4;
      string str3 = "',[Password] = '";
      strArray1[index5] = str3;
      int index6 = 5;
      string text3 = this.TextBoxAccessFilePassword.Text;
      strArray1[index6] = text3;
      int index7 = 6;
      string str4 = "',[TableName] = '";
      strArray1[index7] = str4;
      int index8 = 7;
      string text4 = this.ComboBoxAccessFileTableName.Text;
      strArray1[index8] = text4;
      int index9 = 8;
      string str5 = "',[SearchField] = '";
      strArray1[index9] = str5;
      int index10 = 9;
      string text5 = this.TextBoxAccessFileSearchField.Text;
      strArray1[index10] = text5;
      int index11 = 10;
      string str6 = "', [SearchExt]='";
      strArray1[index11] = str6;
      int index12 = 11;
      string text6 = this.TextBoxAccessFileSearchExt.Text;
      strArray1[index12] = text6;
      int index13 = 12;
      string str7 = "',[EntryBy] = '";
      strArray1[index13] = str7;
      int index14 = 13;
      string str8 = RegisterMicrosoftVisualStudio.UserName;
      strArray1[index14] = str8;
      int index15 = 14;
      string str9 = "',[IP]='";
      strArray1[index15] = str9;
      int index16 = 15;
      string text7 = this.TextBoxAccessIP.Text;
      strArray1[index16] = text7;
      int index17 = 16;
      string str10 = "',[Port]='";
      strArray1[index17] = str10;
      int index18 = 17;
      string text8 = this.TextBoxAccessPort.Text;
      strArray1[index18] = text8;
      int index19 = 18;
      string str11 = "' Where [FileNo] = 1;";
      strArray1[index19] = str11;
      RegisterMicrosoftVisualStudio.SqlText = string.Concat(strArray1);
      string[] strArray2 = new string[18];
      int index20 = 0;
      string str12 = RegisterMicrosoftVisualStudio.SqlText;
      strArray2[index20] = str12;
      int index21 = 1;
      string str13 = "UPDATE [DataImport] SET [FileName] ='";
      strArray2[index21] = str13;
      int index22 = 2;
      string text9 = this.TextBoxExcelFile.Text;
      strArray2[index22] = text9;
      int index23 = 3;
      string str14 = "',[TrackColumnNo] = '";
      strArray2[index23] = str14;
      int index24 = 4;
      string text10 = this.ComboBoxExcelTrackColumnNo.Text;
      strArray2[index24] = text10;
      int index25 = 5;
      string str15 = "',[TestNameColumnNo] = '";
      strArray2[index25] = str15;
      int index26 = 6;
      string text11 = this.ComboBoxExcelTestColumnNo.Text;
      strArray2[index26] = text11;
      int index27 = 7;
      string str16 = "',[TableName] = '";
      strArray2[index27] = str16;
      int index28 = 8;
      string text12 = this.ComboBoxExcelSheetNo.Text;
      strArray2[index28] = text12;
      int index29 = 9;
      string str17 = "',[SearchField] = '', [ResultColumnNo]='";
      strArray2[index29] = str17;
      int index30 = 10;
      string text13 = this.ComboBoxExcelResultColumnNo.Text;
      strArray2[index30] = text13;
      int index31 = 11;
      string str18 = "',[EntryBy] = '";
      strArray2[index31] = str18;
      int index32 = 12;
      string str19 = RegisterMicrosoftVisualStudio.UserName;
      strArray2[index32] = str19;
      int index33 = 13;
      string str20 = "',[IP]='";
      strArray2[index33] = str20;
      int index34 = 14;
      string text14 = this.TextBoxExcelFileIP.Text;
      strArray2[index34] = text14;
      int index35 = 15;
      string str21 = "',[Port]='";
      strArray2[index35] = str21;
      int index36 = 16;
      string text15 = this.TextBoxExcelFilePort.Text;
      strArray2[index36] = text15;
      int index37 = 17;
      string str22 = "' Where [FileNo] = 4;";
      strArray2[index37] = str22;
      RegisterMicrosoftVisualStudio.SqlText = string.Concat(strArray2);
      string[] strArray3 = new string[10];
      int index38 = 0;
      string str23 = RegisterMicrosoftVisualStudio.SqlText;
      strArray3[index38] = str23;
      int index39 = 1;
      string str24 = "UPDATE [DataImport] SET [FileName] ='";
      strArray3[index39] = str24;
      int index40 = 2;
      string text16 = this.TextBoxTextFile.Text;
      strArray3[index40] = text16;
      int index41 = 3;
      string str25 = "',[EntryBy] = '";
      strArray3[index41] = str25;
      int index42 = 4;
      string str26 = RegisterMicrosoftVisualStudio.UserName;
      strArray3[index42] = str26;
      int index43 = 5;
      string str27 = "',[IP]='";
      strArray3[index43] = str27;
      int index44 = 6;
      string text17 = this.TextBoxTextFileIP.Text;
      strArray3[index44] = text17;
      int index45 = 7;
      string str28 = "',[Port]='";
      strArray3[index45] = str28;
      int index46 = 8;
      string text18 = this.TextBoxTextFilePort.Text;
      strArray3[index46] = text18;
      int index47 = 9;
      string str29 = "' Where [FileNo] = 2;";
      strArray3[index47] = str29;
      RegisterMicrosoftVisualStudio.SqlText = string.Concat(strArray3);
      string[] strArray4 = new string[10];
      int index48 = 0;
      string str30 = RegisterMicrosoftVisualStudio.SqlText;
      strArray4[index48] = str30;
      int index49 = 1;
      string str31 = "UPDATE [DataImport] SET [FileName] ='";
      strArray4[index49] = str31;
      int index50 = 2;
      string text19 = this.TextBoxAbbottMachineFile.Text;
      strArray4[index50] = text19;
      int index51 = 3;
      string str32 = "',[EntryBy] = '";
      strArray4[index51] = str32;
      int index52 = 4;
      string str33 = RegisterMicrosoftVisualStudio.UserName;
      strArray4[index52] = str33;
      int index53 = 5;
      string str34 = "',[IP]='";
      strArray4[index53] = str34;
      int index54 = 6;
      string text20 = this.TextBoxAbbottMachineIP.Text;
      strArray4[index54] = text20;
      int index55 = 7;
      string str35 = "',[Port]='";
      strArray4[index55] = str35;
      int index56 = 8;
      string text21 = this.TextBoxAbbottMachinePort.Text;
      strArray4[index56] = text21;
      int index57 = 9;
      string str36 = "' Where [FileNo] = 3;";
      strArray4[index57] = str36;
      RegisterMicrosoftVisualStudio.SqlText = string.Concat(strArray4);
      string[] strArray5 = new string[8];
      int index58 = 0;
      string str37 = RegisterMicrosoftVisualStudio.SqlText;
      strArray5[index58] = str37;
      int index59 = 1;
      string str38 = "UPDATE DeviceMacAddress set LISIPAddress='";
      strArray5[index59] = str38;
      int index60 = 2;
      string text22 = this.ComboBoxLISIPAddress.Text;
      strArray5[index60] = text22;
      int index61 = 3;
      string str39 = "',LISIPPort='";
      strArray5[index61] = str39;
      int index62 = 4;
      string text23 = this.TextBoxLISPort.Text;
      strArray5[index62] = text23;
      int index63 = 5;
      string str40 = "' where '";
      strArray5[index63] = str40;
      int index64 = 6;
      string str41 = RegisterMicrosoftVisualStudio.getNetworkMacAddress().Replace("'", "");
      strArray5[index64] = str41;
      int index65 = 7;
      string str42 = "' LIKE '%' + replace(DeviceMacAddress,':','') + '%';";
      strArray5[index65] = str42;
      RegisterMicrosoftVisualStudio.SqlText = string.Concat(strArray5);
      RegisterMicrosoftVisualStudio.cmd.CommandType = CommandType.Text;
      RegisterMicrosoftVisualStudio.cmd.CommandText = RegisterMicrosoftVisualStudio.SqlText;
      RegisterMicrosoftVisualStudio.Conn.Open();
      try
      {
        RegisterMicrosoftVisualStudio.cmdresults = RegisterMicrosoftVisualStudio.cmd.ExecuteNonQuery();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) MessageBox.Show(ex.Message);
        RegisterMicrosoftVisualStudio.Conn.Close();
        ProjectData.ClearProjectError();
        return;
      }
      RegisterMicrosoftVisualStudio.Conn.Close();
    }

    private void ButtonShowData_Click(object sender, EventArgs e)
    {
      try
      {
        if (this.RadioButtonMicrosoftAccessFile.Checked)
          this.GetAccessData(this.TextBoxAccessFileUserName.Text, this.TextBoxAccessFilePassword.Text, this.ComboBoxAccessFileTableName.Text);
        else if (this.RadioButtonTextFile.Checked)
          this.GetTextData();
        else if (this.RadioButtonAbbottFile.Checked)
        {
          this.GetAbbottMachineData();
        }
        else
        {
          if (!this.RadioButtonExcelFile.Checked)
            return;
          this.GetExcelData(this.TextBoxExcelFile.Text, Conversions.ToInteger(this.ComboBoxExcelSheetNo.Text), Conversions.ToInteger(this.ComboBoxExcelTrackColumnNo.Text), Conversions.ToInteger(this.ComboBoxExcelTestColumnNo.Text), Conversions.ToInteger(this.ComboBoxExcelResultColumnNo.Text));
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) MessageBox.Show(ex.Message, RegisterMicrosoftVisualStudio.mazedatech);
        ProjectData.ClearProjectError();
      }
    }

    private void GetExcelData(string FileName, int SheetNo, int TrackColNo, int TestColNo, int ResultColNo)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.TextBoxExcelFile.Text, "", false) == 0)
        return;
      OleDbConnection selectConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + FileName + ";Extended Properties=\"Excel 8.0;HDR=YES;\"");
      DataSet dataSet = new DataSet();
      string srcTable = "";
      try
      {
        selectConnection.Open();
      }
      catch (OleDbException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        Console.WriteLine(ex.Message);
        ProjectData.ClearProjectError();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Console.WriteLine(ex.Message);
        ProjectData.ClearProjectError();
      }
      DataTable dataTable1 = new DataTable();
      DataTable oleDbSchemaTable = selectConnection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, (object[]) null);
      if (oleDbSchemaTable != null || oleDbSchemaTable.Rows.Count > 0)
      {
        try
        {
          srcTable = oleDbSchemaTable.Rows[SheetNo]["table_name"].ToString();
          ((DbDataAdapter) new OleDbDataAdapter("SELECT * FROM [" + srcTable + "]", selectConnection)).Fill(dataSet, srcTable);
        }
        catch (DataException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          Console.WriteLine(ex.Message);
          ProjectData.ClearProjectError();
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          Console.WriteLine(ex.Message);
          ProjectData.ClearProjectError();
        }
      }
      selectConnection.Close();
      try
      {
        this.DataGridView1.Rows.Clear();
        DataTable dataTable2 = dataSet.Tables[srcTable];
        int index1 = 0;
        int num1 = checked (dataTable2.Rows.Count - 1);
        int index2 = 0;
        while (index2 <= num1)
        {
          if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable2.Rows[index2][ResultColNo])))
          {
            string singleData = RegisterMicrosoftVisualStudio.GetSingleData("TestSetup", "TEST_CODE", Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "select stuff ( ( select ','+ TEST_CODE From TestSetup where TEST_NAME='", dataTable2.Rows[index2][TestColNo]), (object) "'"), (object) " for xml path('')), 1, 1, '') as TEST_CODE")));
            object Instance1 = dataTable2.Rows[index2][ResultColNo];
            // ISSUE: variable of the null type
            __Null local1 = null;
            string MemberName1 = "Replace";
            object[] Arguments1 = new object[2];
            int index3 = 0;
            string str1 = "<";
            Arguments1[index3] = (object) str1;
            int index4 = 1;
            string str2 = "";
            Arguments1[index4] = (object) str2;
            // ISSUE: variable of the null type
            __Null local2 = null;
            // ISSUE: variable of the null type
            __Null local3 = null;
            // ISSUE: variable of the null type
            __Null local4 = null;
            object Instance2 = NewLateBinding.LateGet(Instance1, (System.Type) local1, MemberName1, Arguments1, (string[]) local2, (System.Type[]) local3, (bool[]) local4);
            // ISSUE: variable of the null type
            __Null local5 = null;
            string MemberName2 = "Replace";
            object[] Arguments2 = new object[2];
            int index5 = 0;
            string str3 = ">";
            Arguments2[index5] = (object) str3;
            int index6 = 1;
            string str4 = "";
            Arguments2[index6] = (object) str4;
            // ISSUE: variable of the null type
            __Null local6 = null;
            // ISSUE: variable of the null type
            __Null local7 = null;
            // ISSUE: variable of the null type
            __Null local8 = null;
            object Instance3 = NewLateBinding.LateGet(NewLateBinding.LateGet(Instance2, (System.Type) local5, MemberName2, Arguments2, (string[]) local6, (System.Type[]) local7, (bool[]) local8), (System.Type) null, "Trim", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null);
            // ISSUE: variable of the null type
            __Null local9 = null;
            string MemberName3 = "Split";
            object[] Arguments3 = new object[1];
            int index7 = 0;
            string str5 = " ";
            Arguments3[index7] = (object) str5;
            // ISSUE: variable of the null type
            __Null local10 = null;
            // ISSUE: variable of the null type
            __Null local11 = null;
            // ISSUE: variable of the null type
            __Null local12 = null;
            object Instance4 = NewLateBinding.LateGet(Instance3, (System.Type) local9, MemberName3, Arguments3, (string[]) local10, (System.Type[]) local11, (bool[]) local12);
            object[] Arguments4 = new object[1];
            int index8 = 0;
            // ISSUE: variable of a boxed type
            __Boxed<int> local13 = (System.ValueType) 0;
            Arguments4[index8] = (object) local13;
            // ISSUE: variable of the null type
            __Null local14 = null;
            double num2 = Conversions.ToDouble(NewLateBinding.LateIndexGet(Instance4, Arguments4, (string[]) local14));
            if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(singleData, "", false) > 0U & Versioned.IsNumeric((object) num2))
            {
              this.DataGridView1.Rows.Add();
              this.DataGridView1["Field1", index1].Value = RuntimeHelpers.GetObjectValue(dataTable2.Rows[index2][0]);
              this.DataGridView1["Field2", index1].Value = RuntimeHelpers.GetObjectValue(dataTable2.Rows[index2][2]);
              this.DataGridView1["Field3", index1].Value = RuntimeHelpers.GetObjectValue(dataTable2.Rows[index2][TrackColNo]);
              this.DataGridView1["Field4", index1].Value = RuntimeHelpers.GetObjectValue(dataTable2.Rows[index2][3]);
              this.DataGridView1["Field8", index1].Value = RuntimeHelpers.GetObjectValue(dataTable2.Rows[index2][8]);
              DataGridViewCell dataGridViewCell = this.DataGridView1["Field5", index1];
              double num3 = num2;
              string t1 = "Testsetup";
              string f1 = "TestResultRoundTo";
              string str6 = "select top 1 coalesce(TestResultRoundTo,5) as TestResultRoundTo from TestSetup Where Test_Code='";
              string str7 = singleData;
              char[] chArray = new char[1];
              int index9 = 0;
              int num4 = 44;
              chArray[index9] = (char) num4;
              string str8 = str7.Split(chArray)[0];
              string str9 = "'";
              string str10 = str6 + str8 + str9;
              int digits = Conversions.ToInteger(RegisterMicrosoftVisualStudio.GetSingleData(t1, f1, str10));
              // ISSUE: variable of a boxed type
              __Boxed<double> local15 = (System.ValueType) Math.Round(num3, digits);
              dataGridViewCell.Value = (object) local15;
              this.DataGridView1["Field6", index1].Value = RuntimeHelpers.GetObjectValue(dataTable2.Rows[index2][5]);
              this.DataGridView1["Field7", index1].Value = RuntimeHelpers.GetObjectValue(dataTable2.Rows[index2][7]);
              this.DataGridView1["Field16", index1].Value = (object) singleData;
              checked { ++index1; }
            }
          }
          checked { ++index2; }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) MessageBox.Show(ex.Message, RegisterMicrosoftVisualStudio.mazedatech);
        ProjectData.ClearProjectError();
      }
      dataTable1 = (DataTable) null;
    }

    private void GetAbbottMachineData()
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.TextBoxAbbottMachineFile.Text, "", false) == 0)
        return;
      this.Cursor = Cursors.WaitCursor;
      try
      {
        StreamReader streamReader = new StreamReader(this.TextBoxAbbottMachineFile.Text);
        string str1 = streamReader.ReadLine();
        char[] chArray1 = new char[1];
        int index1 = 0;
        int num1 = 9;
        chArray1[index1] = (char) num1;
        string[] strArray1 = str1.Split(chArray1);
        RegisterMicrosoftVisualStudio.ds.Tables.Clear();
        RegisterMicrosoftVisualStudio.ds.Tables.Add("ImportedTemporyData");
        string[] strArray2 = strArray1;
        int index2 = 0;
        while (index2 < strArray2.Length)
        {
          string str2 = strArray2[index2];
          bool flag = false;
          string str3 = "";
          int num2 = 0;
          while (!flag)
          {
            string str4 = (str2 + str3).Replace("#", "").Replace("'", "").Replace("&", "");
            if (!RegisterMicrosoftVisualStudio.ds.Tables["ImportedTemporyData"].Columns.Contains(str4))
            {
              RegisterMicrosoftVisualStudio.ds.Tables["ImportedTemporyData"].Columns.Add(str4);
              flag = true;
            }
            else
            {
              checked { ++num2; }
              str3 = "_" + num2.ToString();
            }
          }
          checked { ++index2; }
        }
        string str5 = streamReader.ReadToEnd();
        char[] chArray2 = new char[1];
        int index3 = 0;
        int num3 = (int) Conversions.ToChar("\r" + new string("\n".ToCharArray()));
        chArray2[index3] = (char) num3;
        string[] strArray3 = str5.Split(chArray2);
        int index4 = 0;
        while (index4 < strArray3.Length)
        {
          string str2 = strArray3[index4];
          char[] chArray3 = new char[1];
          int index5 = 0;
          int num2 = 9;
          chArray3[index5] = (char) num2;
          string[] strArray4 = str2.Split(chArray3);
          RegisterMicrosoftVisualStudio.ds.Tables["ImportedTemporyData"].Rows.Add((object[]) strArray4);
          checked { ++index4; }
        }
        this.DataGridView1.Rows.Clear();
        DataTable dataTable = RegisterMicrosoftVisualStudio.ds.Tables["ImportedTemporyData"];
        int index6 = 0;
        int num4 = checked (dataTable.Rows.Count - 1);
        int index7 = 0;
        while (index7 <= num4)
        {
          string singleData = RegisterMicrosoftVisualStudio.GetSingleData("TestSetup", "TEST_CODE", Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "select stuff ( ( select ','+ TEST_CODE From TestSetup where TEST_NAME='", dataTable.Rows[index7][6]), (object) "'"), (object) " for xml path('')), 1, 1, '') as TEST_CODE")));
          if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(singleData, "", false) > 0U)
          {
            this.DataGridView1.Rows.Add();
            this.DataGridView1["Field1", index6].Value = RuntimeHelpers.GetObjectValue(dataTable.Rows[index7][0]);
            this.DataGridView1["Field2", index6].Value = RuntimeHelpers.GetObjectValue(dataTable.Rows[index7][2]);
            this.DataGridView1["Field3", index6].Value = RuntimeHelpers.GetObjectValue(dataTable.Rows[index7][1]);
            this.DataGridView1["Field4", index6].Value = RuntimeHelpers.GetObjectValue(dataTable.Rows[index7][3]);
            this.DataGridView1["Field8", index6].Value = RuntimeHelpers.GetObjectValue(dataTable.Rows[index7][8]);
            object Instance1 = dataTable.Rows[index7][8];
            // ISSUE: variable of the null type
            __Null local1 = null;
            string MemberName1 = "Replace";
            object[] Arguments1 = new object[2];
            int index5 = 0;
            string str2 = "<";
            Arguments1[index5] = (object) str2;
            int index8 = 1;
            string str3 = "";
            Arguments1[index8] = (object) str3;
            // ISSUE: variable of the null type
            __Null local2 = null;
            // ISSUE: variable of the null type
            __Null local3 = null;
            // ISSUE: variable of the null type
            __Null local4 = null;
            object Instance2 = NewLateBinding.LateGet(Instance1, (System.Type) local1, MemberName1, Arguments1, (string[]) local2, (System.Type[]) local3, (bool[]) local4);
            // ISSUE: variable of the null type
            __Null local5 = null;
            string MemberName2 = "Replace";
            object[] Arguments2 = new object[2];
            int index9 = 0;
            string str4 = ">";
            Arguments2[index9] = (object) str4;
            int index10 = 1;
            string str6 = "";
            Arguments2[index10] = (object) str6;
            // ISSUE: variable of the null type
            __Null local6 = null;
            // ISSUE: variable of the null type
            __Null local7 = null;
            // ISSUE: variable of the null type
            __Null local8 = null;
            object Instance3 = NewLateBinding.LateGet(NewLateBinding.LateGet(Instance2, (System.Type) local5, MemberName2, Arguments2, (string[]) local6, (System.Type[]) local7, (bool[]) local8), (System.Type) null, "Trim", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null);
            // ISSUE: variable of the null type
            __Null local9 = null;
            string MemberName3 = "Split";
            object[] Arguments3 = new object[1];
            int index11 = 0;
            string str7 = " ";
            Arguments3[index11] = (object) str7;
            // ISSUE: variable of the null type
            __Null local10 = null;
            // ISSUE: variable of the null type
            __Null local11 = null;
            // ISSUE: variable of the null type
            __Null local12 = null;
            object Instance4 = NewLateBinding.LateGet(Instance3, (System.Type) local9, MemberName3, Arguments3, (string[]) local10, (System.Type[]) local11, (bool[]) local12);
            object[] Arguments4 = new object[1];
            int index12 = 0;
            // ISSUE: variable of a boxed type
            __Boxed<int> local13 = (System.ValueType) 0;
            Arguments4[index12] = (object) local13;
            // ISSUE: variable of the null type
            __Null local14 = null;
            double num2 = Conversions.ToDouble(NewLateBinding.LateIndexGet(Instance4, Arguments4, (string[]) local14));
            DataGridViewCell dataGridViewCell = this.DataGridView1["Field5", index6];
            double num5 = num2;
            string t1 = "Testsetup";
            string f1 = "TestResultRoundTo";
            string str8 = "select top 1 coalesce(TestResultRoundTo,5) as TestResultRoundTo from TestSetup Where Test_Code='";
            string str9 = singleData;
            char[] chArray3 = new char[1];
            int index13 = 0;
            int num6 = 44;
            chArray3[index13] = (char) num6;
            string str10 = str9.Split(chArray3)[0];
            string str11 = "'";
            string str12 = str8 + str10 + str11;
            int digits = Conversions.ToInteger(RegisterMicrosoftVisualStudio.GetSingleData(t1, f1, str12));
            // ISSUE: variable of a boxed type
            __Boxed<double> local15 = (System.ValueType) Math.Round(num5, digits);
            dataGridViewCell.Value = (object) local15;
            this.DataGridView1["Field6", index6].Value = RuntimeHelpers.GetObjectValue(dataTable.Rows[index7][5]);
            this.DataGridView1["Field7", index6].Value = RuntimeHelpers.GetObjectValue(dataTable.Rows[index7][7]);
            this.DataGridView1["Field9", index6].Value = RuntimeHelpers.GetObjectValue(dataTable.Rows[index7][9]);
            this.DataGridView1["Field10", index6].Value = RuntimeHelpers.GetObjectValue(dataTable.Rows[index7][6]);
            this.DataGridView1["Field11", index6].Value = RuntimeHelpers.GetObjectValue(dataTable.Rows[index7][10]);
            this.DataGridView1["Field12", index6].Value = RuntimeHelpers.GetObjectValue(dataTable.Rows[index7][11]);
            this.DataGridView1["Field13", index6].Value = RuntimeHelpers.GetObjectValue(dataTable.Rows[index7][12]);
            this.DataGridView1["Field14", index6].Value = RuntimeHelpers.GetObjectValue(dataTable.Rows[index7][13]);
            this.DataGridView1["Field15", index6].Value = RuntimeHelpers.GetObjectValue(dataTable.Rows[index7][14]);
            this.DataGridView1["Field16", index6].Value = (object) singleData;
            checked { ++index6; }
          }
          checked { ++index7; }
        }
        this.Cursor = Cursors.Default;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        this.Cursor = Cursors.Default;
        int num = (int) MessageBox.Show(exception.Message, RegisterMicrosoftVisualStudio.mazedatech);
        ProjectData.ClearProjectError();
      }
    }

    public void GetAccessData(string UID, string pwd, string tblName)
    {
      OleDbConnection oleDbConnection = new OleDbConnection();
      try
      {
        string[] strArray1 = new string[6];
        int index1 = 0;
        string str1 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=";
        strArray1[index1] = str1;
        int index2 = 1;
        string text1 = this.TextBoxAccessFile.Text;
        strArray1[index2] = text1;
        int index3 = 2;
        string str2 = ";User ID=";
        strArray1[index3] = str2;
        int index4 = 3;
        string str3 = UID;
        strArray1[index4] = str3;
        int index5 = 4;
        string str4 = ";Password=";
        strArray1[index5] = str4;
        int index6 = 5;
        string str5 = pwd;
        strArray1[index6] = str5;
        string str6 = string.Concat(strArray1);
        oleDbConnection.ConnectionString = str6;
        oleDbConnection.Open();
        DateTime dateTime = this.DTPFrom.Value;
        string str7 = Strings.Mid(Conversions.ToString(dateTime.Year), 3);
        dateTime = this.DTPFrom.Value;
        int num1 = Strings.Len(dateTime.Month.ToString()) == 1 ? 1 : 0;
        string str8 = "0";
        dateTime = this.DTPFrom.Value;
        string str9 = dateTime.Month.ToString();
        string str10 = str8 + str9;
        dateTime = this.DTPFrom.Value;
        string str11 = dateTime.Month.ToString();
        object Right1 = Interaction.IIf(num1 != 0, (object) str10, (object) str11);
        object Left1 = Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) str7, Right1);
        dateTime = this.DTPFrom.Value;
        int num2 = Strings.Len(dateTime.Day.ToString()) == 1 ? 1 : 0;
        string str12 = "0";
        dateTime = this.DTPFrom.Value;
        string str13 = dateTime.Day.ToString();
        string str14 = str12 + str13;
        dateTime = this.DTPFrom.Value;
        string str15 = dateTime.Day.ToString();
        object Right2 = Interaction.IIf(num2 != 0, (object) str14, (object) str15);
        object Left2 = Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Left1, Right2);
        dateTime = this.DateTimePickerTimeFrom.Value;
        int num3 = Strings.Len(dateTime.Hour.ToString()) == 1 ? 1 : 0;
        string str16 = "0";
        dateTime = this.DateTimePickerTimeFrom.Value;
        string str17 = dateTime.Hour.ToString();
        string str18 = str16 + str17;
        dateTime = this.DateTimePickerTimeFrom.Value;
        string str19 = dateTime.Hour.ToString();
        object Right3 = Interaction.IIf(num3 != 0, (object) str18, (object) str19);
        object Left3 = Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Left2, Right3);
        dateTime = this.DateTimePickerTimeFrom.Value;
        int num4 = Strings.Len(dateTime.Minute.ToString()) == 1 ? 1 : 0;
        string str20 = "0";
        dateTime = this.DateTimePickerTimeFrom.Value;
        string str21 = dateTime.Minute.ToString();
        string str22 = str20 + str21;
        dateTime = this.DateTimePickerTimeFrom.Value;
        string str23 = dateTime.Minute.ToString();
        object Right4 = Interaction.IIf(num4 != 0, (object) str22, (object) str23);
        object Left4 = Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Left3, Right4);
        dateTime = this.DateTimePickerTimeFrom.Value;
        int num5 = Strings.Len(dateTime.Second.ToString()) == 1 ? 1 : 0;
        string str24 = "0";
        dateTime = this.DateTimePickerTimeFrom.Value;
        string str25 = dateTime.Second.ToString();
        string str26 = str24 + str25;
        dateTime = this.DateTimePickerTimeFrom.Value;
        string str27 = dateTime.Second.ToString();
        object Right5 = Interaction.IIf(num5 != 0, (object) str26, (object) str27);
        string str28 = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Left4, Right5), (object) this.TextBoxAccessFileSearchExt.Text));
        dateTime = this.DTPTo.Value;
        string str29 = Strings.Mid(Conversions.ToString(dateTime.Year), 3);
        dateTime = this.DTPTo.Value;
        int num6 = Strings.Len(dateTime.Month.ToString()) == 1 ? 1 : 0;
        string str30 = "0";
        dateTime = this.DTPTo.Value;
        string str31 = dateTime.Month.ToString();
        string str32 = str30 + str31;
        dateTime = this.DTPTo.Value;
        string str33 = dateTime.Month.ToString();
        object Right6 = Interaction.IIf(num6 != 0, (object) str32, (object) str33);
        object Left5 = Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) str29, Right6);
        dateTime = this.DTPTo.Value;
        int num7 = Strings.Len(dateTime.Day.ToString()) == 1 ? 1 : 0;
        string str34 = "0";
        dateTime = this.DTPTo.Value;
        string str35 = dateTime.Day.ToString();
        string str36 = str34 + str35;
        dateTime = this.DTPTo.Value;
        string str37 = dateTime.Day.ToString();
        object Right7 = Interaction.IIf(num7 != 0, (object) str36, (object) str37);
        object Left6 = Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Left5, Right7);
        dateTime = this.DateTimePickerTimeTo.Value;
        int num8 = Strings.Len(dateTime.Hour.ToString()) == 1 ? 1 : 0;
        string str38 = "0";
        dateTime = this.DateTimePickerTimeTo.Value;
        string str39 = dateTime.Hour.ToString();
        string str40 = str38 + str39;
        dateTime = this.DateTimePickerTimeTo.Value;
        string str41 = dateTime.Hour.ToString();
        object Right8 = Interaction.IIf(num8 != 0, (object) str40, (object) str41);
        object Left7 = Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Left6, Right8);
        dateTime = this.DateTimePickerTimeTo.Value;
        int num9 = Strings.Len(dateTime.Minute.ToString()) == 1 ? 1 : 0;
        string str42 = "0";
        dateTime = this.DateTimePickerTimeTo.Value;
        string str43 = dateTime.Minute.ToString();
        string str44 = str42 + str43;
        dateTime = this.DateTimePickerTimeTo.Value;
        string str45 = dateTime.Minute.ToString();
        object Right9 = Interaction.IIf(num9 != 0, (object) str44, (object) str45);
        object Left8 = Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Left7, Right9);
        dateTime = this.DateTimePickerTimeTo.Value;
        int num10 = Strings.Len(dateTime.Second.ToString()) == 1 ? 1 : 0;
        string str46 = "0";
        dateTime = this.DateTimePickerTimeTo.Value;
        string str47 = dateTime.Second.ToString();
        string str48 = str46 + str47;
        dateTime = this.DateTimePickerTimeTo.Value;
        string str49 = dateTime.Second.ToString();
        object Right10 = Interaction.IIf(num10 != 0, (object) str48, (object) str49);
        string str50 = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Left8, Right10), (object) this.TextBoxAccessFileSearchExt.Text));
        RegisterMicrosoftVisualStudio.cmd.Connection = oleDbConnection;
        OleDbCommand oleDbCommand = RegisterMicrosoftVisualStudio.cmd;
        string[] strArray2 = new string[11];
        int index7 = 0;
        string str51 = "SELECT * from ";
        strArray2[index7] = str51;
        int index8 = 1;
        string str52 = tblName;
        strArray2[index8] = str52;
        int index9 = 2;
        string str53 = " Where ";
        strArray2[index9] = str53;
        int index10 = 3;
        string text2 = this.TextBoxAccessFileSearchField.Text;
        strArray2[index10] = text2;
        int index11 = 4;
        string str54 = ">='";
        strArray2[index11] = str54;
        int index12 = 5;
        string str55 = str28;
        strArray2[index12] = str55;
        int index13 = 6;
        string str56 = "' and ";
        strArray2[index13] = str56;
        int index14 = 7;
        string text3 = this.TextBoxAccessFileSearchField.Text;
        strArray2[index14] = text3;
        int index15 = 8;
        string str57 = "<='";
        strArray2[index15] = str57;
        int index16 = 9;
        string str58 = str50;
        strArray2[index16] = str58;
        int index17 = 10;
        string str59 = "'";
        strArray2[index17] = str59;
        string str60 = string.Concat(strArray2);
        oleDbCommand.CommandText = str60;
        RegisterMicrosoftVisualStudio.da.SelectCommand = RegisterMicrosoftVisualStudio.cmd;
        if (RegisterMicrosoftVisualStudio.ds.Tables["ImportData"] != null)
          RegisterMicrosoftVisualStudio.ds.Tables["ImportData"].Clear();
        ((DbDataAdapter) RegisterMicrosoftVisualStudio.da).Fill(RegisterMicrosoftVisualStudio.ds, "ImportData");
        int count = RegisterMicrosoftVisualStudio.ds.Tables["ImportData"].Columns.Count;
        this.DataGridView1.Rows.Clear();
        DataTable dataTable = RegisterMicrosoftVisualStudio.ds.Tables["ImportData"];
        int index18 = 0;
        int num11 = checked (dataTable.Rows.Count - 1);
        int index19 = 0;
        while (index19 <= num11)
        {
          this.DataGridView1.Rows.Add();
          this.DataGridView1["Field1", index18].Value = RuntimeHelpers.GetObjectValue(dataTable.Rows[index19][0]);
          this.DataGridView1["Field2", index18].Value = RuntimeHelpers.GetObjectValue(dataTable.Rows[index19][1]);
          this.DataGridView1["Field3", index18].Value = RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows[index19][2])), (object) "", RuntimeHelpers.GetObjectValue(dataTable.Rows[index19][2])));
          this.DataGridView1["Field4", index18].Value = RuntimeHelpers.GetObjectValue(Interaction.IIf(count > 3, RuntimeHelpers.GetObjectValue(dataTable.Rows[index19][3]), (object) ""));
          this.DataGridView1["Field5", index18].Value = RuntimeHelpers.GetObjectValue(Interaction.IIf(count > 4, RuntimeHelpers.GetObjectValue(dataTable.Rows[index19][4]), (object) ""));
          this.DataGridView1["Field6", index18].Value = RuntimeHelpers.GetObjectValue(Interaction.IIf(count > 5, RuntimeHelpers.GetObjectValue(dataTable.Rows[index19][5]), (object) ""));
          this.DataGridView1["Field7", index18].Value = RuntimeHelpers.GetObjectValue(Interaction.IIf(count > 6, RuntimeHelpers.GetObjectValue(dataTable.Rows[index19][6]), (object) ""));
          this.DataGridView1["Field8", index18].Value = RuntimeHelpers.GetObjectValue(Interaction.IIf(count > 7, RuntimeHelpers.GetObjectValue(dataTable.Rows[index19][7]), (object) ""));
          this.DataGridView1["Field9", index18].Value = RuntimeHelpers.GetObjectValue(Interaction.IIf(count > 8, RuntimeHelpers.GetObjectValue(dataTable.Rows[index19][8]), (object) ""));
          this.DataGridView1["Field10", index18].Value = RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows[index19][4])), (object) "", RuntimeHelpers.GetObjectValue(dataTable.Rows[index19][4])));
          this.DataGridView1["Field11", index18].Value = RuntimeHelpers.GetObjectValue(Interaction.IIf(count > 10, RuntimeHelpers.GetObjectValue(dataTable.Rows[index19][10]), (object) ""));
          this.DataGridView1["Field12", index18].Value = RuntimeHelpers.GetObjectValue(Interaction.IIf(count > 11, RuntimeHelpers.GetObjectValue(dataTable.Rows[index19][11]), (object) ""));
          this.DataGridView1["Field13", index18].Value = RuntimeHelpers.GetObjectValue(Interaction.IIf(count > 12, RuntimeHelpers.GetObjectValue(dataTable.Rows[index19][12]), (object) ""));
          this.DataGridView1["Field14", index18].Value = RuntimeHelpers.GetObjectValue(Interaction.IIf(count > 13, RuntimeHelpers.GetObjectValue(dataTable.Rows[index19][13]), (object) ""));
          this.DataGridView1["Field15", index18].Value = RuntimeHelpers.GetObjectValue(Interaction.IIf(count > 14, RuntimeHelpers.GetObjectValue(dataTable.Rows[index19][14]), (object) ""));
          this.DataGridView1["Field16", index18].Value = RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows[index19][15])), (object) "", RuntimeHelpers.GetObjectValue(dataTable.Rows[index19][15])));
          checked { ++index18; }
          checked { ++index19; }
        }
        oleDbConnection.Close();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        if (oleDbConnection.State == ConnectionState.Open)
          oleDbConnection.Close();
        int num = (int) MessageBox.Show(exception.Message, RegisterMicrosoftVisualStudio.mazedatech);
        ProjectData.ClearProjectError();
      }
    }

    private void DeleteSourceRecordAccess(string UID, string pwd, string tblName)
    {
      OleDbConnection oleDbConnection = new OleDbConnection();
      int num1 = 0;
      string str1 = "";
      try
      {
        string[] strArray = new string[6];
        int index1 = 0;
        string str2 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=";
        strArray[index1] = str2;
        int index2 = 1;
        string text = this.TextBoxAccessFile.Text;
        strArray[index2] = text;
        int index3 = 2;
        string str3 = ";User ID=";
        strArray[index3] = str3;
        int index4 = 3;
        string str4 = UID;
        strArray[index4] = str4;
        int index5 = 4;
        string str5 = ";Password=";
        strArray[index5] = str5;
        int index6 = 5;
        string str6 = pwd;
        strArray[index6] = str6;
        string str7 = string.Concat(strArray);
        oleDbConnection.ConnectionString = str7;
        RegisterMicrosoftVisualStudio.cmd.Connection = oleDbConnection;
        string str8 = "Delete from " + tblName + " Where WrkRltIdx in (";
        int num2 = checked (this.DataGridView1.Rows.Count - 1);
        int index7 = 0;
        while (index7 <= num2)
        {
          str1 = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) (str1 + ", "), this.DataGridView1["Field1", index7].Value));
          checked { ++index7; }
        }
        string str9 = str8 + Strings.Mid(str1, 2) + ")";
        RegisterMicrosoftVisualStudio.cmd.CommandText = str9;
        oleDbConnection.Open();
        num1 = RegisterMicrosoftVisualStudio.cmd.ExecuteNonQuery();
        oleDbConnection.Close();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num2 = (int) MessageBox.Show(ex.Message);
        if (oleDbConnection.State == ConnectionState.Open)
          oleDbConnection.Close();
        ProjectData.ClearProjectError();
      }
    }

    private void ButtonMicrosoftAccessFile_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog1 = new OpenFileDialog();
      OpenFileDialog openFileDialog2 = openFileDialog1;
      openFileDialog2.CheckFileExists = true;
      openFileDialog2.ShowReadOnly = false;
      openFileDialog2.Filter = "Microsof Access Database Files (*)|*.mdb;*.mdb;*.*";
      openFileDialog2.FilterIndex = 2;
      if (openFileDialog2.ShowDialog() == DialogResult.OK)
        this.TextBoxAccessFile.Text = openFileDialog1.FileName;
    }

    private void ButtonImportData_Click(object sender, EventArgs e)
    {
      if (this.RadioButtonMicrosoftAccessFile.Checked)
      {
        string str1 = "";
        int num1 = 0;
        OleDbCommand oleDbCommand1 = new OleDbCommand(RegisterMicrosoftVisualStudio.SqlText, RegisterMicrosoftVisualStudio.Conn);
        object obj = (object) this;
        RegisterMicrosoftVisualStudio.SingleQuoteReplace(ref obj);
        if (this.NotValidData())
          return;
        DateTime now = DateAndTime.Now;
        RegisterMicrosoftVisualStudio.SqlText = "INSERT INTO DataImportData (DataFrom, EntryOn, EntryBy, Field1, Field2, Field3, Field4, Field5, Field6, Field7, Field8, Field9, Field10, Field11, Field12, Field13, Field14, Field15, Field16) VALUES ";
        this.Cursor = Cursors.WaitCursor;
        int num2 = checked (this.DataGridView1.Rows.Count - 1);
        int index1 = 0;
        while (index1 <= num2)
        {
          string[] strArray = new string[6];
          int index2 = 0;
          string str2 = str1;
          strArray[index2] = str2;
          int index3 = 1;
          string str3 = ", ('P','";
          strArray[index3] = str3;
          int index4 = 2;
          string str4 = Conversions.ToString(now);
          strArray[index4] = str4;
          int index5 = 3;
          string str5 = "','";
          strArray[index5] = str5;
          int index6 = 4;
          string str6 = RegisterMicrosoftVisualStudio.UserName;
          strArray[index6] = str6;
          int index7 = 5;
          string str7 = "','";
          strArray[index7] = str7;
          str1 = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) string.Concat(strArray), this.DataGridView1["Field1", index1].Value), (object) "','"), this.DataGridView1["Field2", index1].Value), (object) "','"), this.DataGridView1["Field3", index1].Value), (object) "','"), this.DataGridView1["Field4", index1].Value), (object) "','"), this.DataGridView1["Field5", index1].Value), (object) "','"), this.DataGridView1["Field6", index1].Value), (object) "','"), this.DataGridView1["Field7", index1].Value), (object) "','"), this.DataGridView1["Field8", index1].Value), (object) "','"), this.DataGridView1["Field9", index1].Value), (object) "','"), this.DataGridView1["Field10", index1].Value), (object) "','"), this.DataGridView1["Field11", index1].Value), (object) "','"), this.DataGridView1["Field12", index1].Value), (object) "','"), this.DataGridView1["Field13", index1].Value), (object) "','"), this.DataGridView1["Field14", index1].Value), (object) "','"), this.DataGridView1["Field15", index1].Value), (object) "','"), this.DataGridView1["Field16", index1].Value), (object) "')"));
          checked { ++index1; }
        }
        RegisterMicrosoftVisualStudio.SqlText = RegisterMicrosoftVisualStudio.SqlText + Strings.Mid(str1, 2);
        oleDbCommand1.CommandType = CommandType.Text;
        oleDbCommand1.CommandText = RegisterMicrosoftVisualStudio.SqlText;
        RegisterMicrosoftVisualStudio.Conn.Open();
        try
        {
          num1 = oleDbCommand1.ExecuteNonQuery();
          this.DeleteSourceRecordAccess(this.TextBoxAccessFileUserName.Text, this.TextBoxAccessFilePassword.Text, this.ComboBoxAccessFileTableName.Text);
          OleDbCommand oleDbCommand2 = oleDbCommand1;
          string[] strArray = new string[5];
          int index2 = 0;
          string str2 = "exec spUpdatePathologyDataWithImportedData '";
          strArray[index2] = str2;
          int index3 = 1;
          string str3 = Conversions.ToString(now);
          strArray[index3] = str3;
          int index4 = 2;
          string str4 = "','";
          strArray[index4] = str4;
          int index5 = 3;
          string str5 = RegisterMicrosoftVisualStudio.UserName;
          strArray[index5] = str5;
          int index6 = 4;
          string str6 = "';";
          strArray[index6] = str6;
          string str7 = string.Concat(strArray);
          oleDbCommand2.CommandText = str7;
          num1 = oleDbCommand1.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          Exception exception = ex;
          this.Cursor = Cursors.Default;
          int num3 = (int) MessageBox.Show(exception.Message);
          RegisterMicrosoftVisualStudio.Conn.Close();
          ProjectData.ClearProjectError();
          return;
        }
        RegisterMicrosoftVisualStudio.Conn.Close();
        this.DataGridView1.Rows.Clear();
        this.Cursor = Cursors.Default;
      }
      else
        this.SaveTextFileImportedData();
      int num = (int) MessageBox.Show("Record saved properly.", RegisterMicrosoftVisualStudio.mazedatech, MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
    }

    private void SaveTextFileImportedData()
    {
      string str1 = "";
      int num1 = 0;
      OleDbCommand oleDbCommand1 = new OleDbCommand(RegisterMicrosoftVisualStudio.SqlText, RegisterMicrosoftVisualStudio.Conn);
      object obj = (object) this;
      RegisterMicrosoftVisualStudio.SingleQuoteReplace(ref obj);
      if (this.NotValidData())
        return;
      DateTime now = DateAndTime.Now;
      int num2 = checked (this.DataGridView1.Rows.Count - 1);
      int index1 = 0;
      while (index1 <= num2)
      {
        string str2 = this.DataGridView1["Field16", index1].Value.ToString();
        char[] chArray = new char[1];
        int index2 = 0;
        int num3 = 44;
        chArray[index2] = (char) num3;
        string[] strArray1 = str2.Split(chArray);
        int num4 = Information.UBound((Array) strArray1, 1);
        int index3 = 0;
        while (index3 <= num4)
        {
          string[] strArray2 = new string[8];
          int index4 = 0;
          string str3 = str1;
          strArray2[index4] = str3;
          int index5 = 1;
          string str4 = ", ('";
          strArray2[index5] = str4;
          int index6 = 2;
          string str5 = Conversions.ToString(this.ComboBoxTestFileMachineName.SelectedIndex);
          strArray2[index6] = str5;
          int index7 = 3;
          string str6 = "','";
          strArray2[index7] = str6;
          int index8 = 4;
          string str7 = Conversions.ToString(now);
          strArray2[index8] = str7;
          int index9 = 5;
          string str8 = "','";
          strArray2[index9] = str8;
          int index10 = 6;
          string str9 = RegisterMicrosoftVisualStudio.UserName;
          strArray2[index10] = str9;
          int index11 = 7;
          string str10 = "','";
          strArray2[index11] = str10;
          str1 = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) string.Concat(strArray2), this.DataGridView1["Field1", index1].Value), (object) "','"), this.DataGridView1["Field2", index1].Value), (object) "','"), this.DataGridView1["Field3", index1].Value), (object) "','"), this.DataGridView1["Field4", index1].Value), (object) "','"), this.DataGridView1["Field5", index1].Value), (object) "','"), this.DataGridView1["Field6", index1].Value), (object) "','"), this.DataGridView1["Field7", index1].Value), (object) "','"), this.DataGridView1["Field8", index1].Value), (object) "','"), this.DataGridView1["Field9", index1].Value), (object) "','"), this.DataGridView1["Field10", index1].Value), (object) "','"), this.DataGridView1["Field11", index1].Value), (object) "','"), this.DataGridView1["Field12", index1].Value), (object) "','"), this.DataGridView1["Field13", index1].Value), (object) "','"), this.DataGridView1["Field14", index1].Value), (object) "','"), this.DataGridView1["Field15", index1].Value), (object) "','"), (object) strArray1[index3]), (object) "')"));
          checked { ++index3; }
        }
        checked { ++index1; }
      }
      RegisterMicrosoftVisualStudio.SqlText = "INSERT INTO DataImportData (DataFrom, EntryOn, EntryBy, Field1, Field2, Field3, Field4, Field5, Field6, Field7, Field8, Field9, Field10, Field11, Field12, Field13, Field14, Field15, Field16) VALUES ";
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Strings.Trim(str1), "", false) == 0)
        return;
      RegisterMicrosoftVisualStudio.SqlText = RegisterMicrosoftVisualStudio.SqlText + Strings.Mid(str1, 2);
      oleDbCommand1.CommandType = CommandType.Text;
      oleDbCommand1.CommandText = RegisterMicrosoftVisualStudio.SqlText;
      RegisterMicrosoftVisualStudio.Conn.Open();
      try
      {
        num1 = oleDbCommand1.ExecuteNonQuery();
        OleDbCommand oleDbCommand2 = oleDbCommand1;
        string[] strArray = new string[5];
        int index2 = 0;
        string str2 = "exec spUpdatePathologyDataWithImportedData '";
        strArray[index2] = str2;
        int index3 = 1;
        string str3 = Conversions.ToString(now);
        strArray[index3] = str3;
        int index4 = 2;
        string str4 = "','";
        strArray[index4] = str4;
        int index5 = 3;
        string str5 = RegisterMicrosoftVisualStudio.UserName;
        strArray[index5] = str5;
        int index6 = 4;
        string str6 = "';";
        strArray[index6] = str6;
        string str7 = string.Concat(strArray);
        oleDbCommand2.CommandText = str7;
        num1 = oleDbCommand1.ExecuteNonQuery();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num3 = (int) MessageBox.Show(ex.Message);
        RegisterMicrosoftVisualStudio.Conn.Close();
        ProjectData.ClearProjectError();
        return;
      }
      RegisterMicrosoftVisualStudio.Conn.Close();
      this.DataGridView1.Rows.Clear();
    }

    private void SaveLISImportedData()
    {
      string str1 = "";
      int num1 = 0;
      OleDbCommand oleDbCommand1 = new OleDbCommand(RegisterMicrosoftVisualStudio.SqlText, RegisterMicrosoftVisualStudio.Conn);
      DateTime now1 = DateAndTime.Now;
      DateTime now2 = DateAndTime.Now;
      string[] strArray1;
      try
      {
        int num2 = checked (this.dtLISResult.Rows.Count - 1);
        int index1 = 0;
        while (index1 <= num2)
        {
          string str2 = this.dtLISResult.Rows[index1]["TestCode"].ToString();
          char[] chArray = new char[1];
          int index2 = 0;
          int num3 = 44;
          chArray[index2] = (char) num3;
          string[] strArray2 = str2.Split(chArray);
          DateTime dateTime = Conversions.ToDate(Interaction.IIf(Information.IsDate(RuntimeHelpers.GetObjectValue(this.dtLISResult.Rows[index1]["TestTime"])), RuntimeHelpers.GetObjectValue(this.dtLISResult.Rows[index1]["TestTime"]), (object) DateAndTime.Now));
          int num4 = Information.UBound((Array) strArray2, 1);
          int index3 = 0;
          while (index3 <= num4)
          {
            string[] strArray3 = new string[8];
            int index4 = 0;
            string str3 = str1;
            strArray3[index4] = str3;
            int index5 = 1;
            string str4 = ", ('";
            strArray3[index5] = str4;
            int index6 = 2;
            string str5 = Conversions.ToString(this.MachineIndex);
            strArray3[index6] = str5;
            int index7 = 3;
            string str6 = "','";
            strArray3[index7] = str6;
            int index8 = 4;
            string str7 = Conversions.ToString(now1);
            strArray3[index8] = str7;
            int index9 = 5;
            string str8 = "','";
            strArray3[index9] = str8;
            int index10 = 6;
            string str9 = RegisterMicrosoftVisualStudio.UserName;
            strArray3[index10] = str9;
            int index11 = 7;
            string str10 = "','";
            strArray3[index11] = str10;
            str1 = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) string.Concat(strArray3), this.dtLISResult.Rows[index1]["RackPosition"]), (object) "','"), this.dtLISResult.Rows[index1]["PatientID"]), (object) "','"), this.dtLISResult.Rows[index1]["TrackNumber"]), (object) "','','"), this.dtLISResult.Rows[index1]["Result"]), (object) "','','','','','"), this.dtLISResult.Rows[index1]["TestName"]), (object) "','','','','','"), this.dtLISResult.Rows[index1]["LISTestCode"]), (object) "','"), (object) strArray2[index3]), (object) "','"), (object) dateTime), (object) "')"));
            checked { ++index3; }
          }
          checked { ++index1; }
        }
        RegisterMicrosoftVisualStudio.SqlText = "INSERT INTO DataImportData (DataFrom, EntryOn, EntryBy, Field1, Field2, Field3, Field4, Field5, Field6, Field7, Field8, Field9, Field10, Field11, Field12, Field13, Field14, Field15, Field16, TestTime) VALUES ";
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Strings.Trim(str1), "", false) == 0)
          return;
        RegisterMicrosoftVisualStudio.SqlText = RegisterMicrosoftVisualStudio.SqlText + Strings.Mid(str1, 2);
        oleDbCommand1.CommandType = CommandType.Text;
        oleDbCommand1.CommandText = RegisterMicrosoftVisualStudio.SqlText;
        RegisterMicrosoftVisualStudio.Conn.Open();
        num1 = oleDbCommand1.ExecuteNonQuery();
        OleDbCommand oleDbCommand2 = oleDbCommand1;
        string[] strArray4 = new string[5];
        int index12 = 0;
        string str11 = "exec spUpdatePathologyDataWithImportedData '";
        strArray4[index12] = str11;
        int index13 = 1;
        string str12 = Conversions.ToString(now1);
        strArray4[index13] = str12;
        int index14 = 2;
        string str13 = "','";
        strArray4[index14] = str13;
        int index15 = 3;
        string str14 = RegisterMicrosoftVisualStudio.UserName;
        strArray4[index15] = str14;
        int index16 = 4;
        string str15 = "';";
        strArray4[index16] = str15;
        string str16 = string.Concat(strArray4);
        oleDbCommand2.CommandText = str16;
        num1 = oleDbCommand1.ExecuteNonQuery();
        strArray1 = (string[]) null;
        num1 = 0;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        strArray1 = (string[]) null;
        int num2 = (int) MessageBox.Show(exception.Message, "SaveLISImportedData");
        RegisterMicrosoftVisualStudio.Conn.Close();
        ProjectData.ClearProjectError();
        return;
      }
      RegisterMicrosoftVisualStudio.Conn.Close();
      this.dtLISResult.Rows.Clear();
    }

    private void LoadSerialCommunicationSetting(int FileNo)
    {
      RegisterMicrosoftVisualStudio.SqlText = "SELECT [FileNo],[FileName],[UserName],[Password],[TableName],[SearchField],[SearchExt],[TrackColumnNo],[TestNameColumnNo],[ResultColumnNo],[IP],[Port] FROM [DataImport] where FileNo='" + Conversions.ToString(FileNo) + "'";
      RegisterMicrosoftVisualStudio.cmd = new OleDbCommand(RegisterMicrosoftVisualStudio.SqlText, RegisterMicrosoftVisualStudio.Conn);
      RegisterMicrosoftVisualStudio.da.SelectCommand = RegisterMicrosoftVisualStudio.cmd;
      if (RegisterMicrosoftVisualStudio.ds.Tables["File"] != null)
        RegisterMicrosoftVisualStudio.ds.Tables["File"].Clear();
      ((DbDataAdapter) RegisterMicrosoftVisualStudio.da).Fill(RegisterMicrosoftVisualStudio.ds, "File");
      if (RegisterMicrosoftVisualStudio.ds.Tables["File"].Rows.Count < 1)
        return;
      DataRow dataRow = RegisterMicrosoftVisualStudio.ds.Tables["File"].Rows[0];
      this.SearchEXT = Conversions.ToString(dataRow["SearchExt"]);
      this.TrackNumberFieldName = Conversions.ToString(NewLateBinding.LateGet(dataRow["SearchField"], (System.Type) null, "trim", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      this.TrackNumberFieldLocation = Conversions.ToInteger(dataRow["TrackColumnNo"]);
      this.TestNameLocation = Conversions.ToInteger(dataRow["TestNameColumnNo"]);
      this.TestResultLocation = Conversions.ToInteger(dataRow["ResultColumnNo"]);
    }

    private void LoadDataFromDatabase()
    {
      RegisterMicrosoftVisualStudio.SqlText = "SELECT [FileNo],[FileName],[UserName],[Password],[TableName],[SearchField],[SearchExt],[TrackColumnNo],[TestNameColumnNo],[ResultColumnNo],[IP],[Port] FROM [DataImport] order by FileNo";
      RegisterMicrosoftVisualStudio.cmd = new OleDbCommand(RegisterMicrosoftVisualStudio.SqlText, RegisterMicrosoftVisualStudio.Conn);
      RegisterMicrosoftVisualStudio.da.SelectCommand = RegisterMicrosoftVisualStudio.cmd;
      if (RegisterMicrosoftVisualStudio.ds.Tables["File"] != null)
        RegisterMicrosoftVisualStudio.ds.Tables["File"].Clear();
      ((DbDataAdapter) RegisterMicrosoftVisualStudio.da).Fill(RegisterMicrosoftVisualStudio.ds, "File");
      DataRow dataRow1 = RegisterMicrosoftVisualStudio.ds.Tables["File"].Rows[0];
      this.TextBoxAccessFile.Text = Conversions.ToString(dataRow1["FileName"]);
      this.TextBoxAccessFileUserName.Text = Conversions.ToString(dataRow1["UserName"]);
      this.TextBoxAccessFilePassword.Text = Conversions.ToString(dataRow1["Password"]);
      this.ComboBoxAccessFileTableName.Text = Conversions.ToString(dataRow1["TableName"]);
      this.TextBoxAccessFileSearchField.Text = Conversions.ToString(dataRow1["SearchField"]);
      this.TextBoxAccessFileSearchExt.Text = Conversions.ToString(dataRow1["SearchExt"]);
      this.TextBoxAccessIP.Text = Conversions.ToString(dataRow1["IP"]);
      this.TextBoxAccessPort.Text = Conversions.ToString(dataRow1["Port"]);
      DataRow dataRow2 = RegisterMicrosoftVisualStudio.ds.Tables["File"].Rows[1];
      this.TextBoxTextFile.Text = Conversions.ToString(dataRow2["FileName"]);
      this.TextBoxTextFileIP.Text = Conversions.ToString(dataRow2["IP"]);
      this.TextBoxTextFilePort.Text = Conversions.ToString(dataRow2["Port"]);
      DataRow dataRow3 = RegisterMicrosoftVisualStudio.ds.Tables["File"].Rows[2];
      this.TextBoxAbbottMachineFile.Text = Conversions.ToString(dataRow3["FileName"]);
      this.TextBoxAbbottMachineIP.Text = Conversions.ToString(dataRow3["IP"]);
      this.TextBoxAbbottMachinePort.Text = Conversions.ToString(dataRow3["Port"]);
      DataRow dataRow4 = RegisterMicrosoftVisualStudio.ds.Tables["File"].Rows[3];
      this.TextBoxExcelFile.Text = Conversions.ToString(dataRow4["FileName"]);
      this.ComboBoxExcelSheetNo.Text = Conversions.ToString(dataRow4["TableName"]);
      this.ComboBoxExcelTrackColumnNo.Text = Conversions.ToString(dataRow4["TrackColumnNo"]);
      this.ComboBoxExcelTestColumnNo.Text = Conversions.ToString(dataRow4["TestNameColumnNo"]);
      this.ComboBoxExcelResultColumnNo.Text = Conversions.ToString(dataRow4["ResultColumnNo"]);
      this.TextBoxExcelFileIP.Text = Conversions.ToString(dataRow4["IP"]);
      this.TextBoxExcelFilePort.Text = Conversions.ToString(dataRow4["Port"]);
    }

    private void GetTextData()
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.TextBoxTextFile.Text, "", false) == 0 || !(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.ComboBoxTestFileTestName.Text, "CBC", false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.ComboBoxTestFileMachineName.Text, "Cell Dyn Rubi", false) == 0))
        return;
      StreamReader streamReader = new StreamReader(this.TextBoxTextFile.Text);
      string str1 = streamReader.ReadLine();
      char[] chArray1 = new char[1];
      int index1 = 0;
      int num1 = 44;
      chArray1[index1] = (char) num1;
      string[] strArray1 = str1.Split(chArray1);
      RegisterMicrosoftVisualStudio.ds.Tables.Clear();
      RegisterMicrosoftVisualStudio.ds.Tables.Add("ImportedTemporyData");
      string[] strArray2 = strArray1;
      int index2 = 0;
      while (index2 < strArray2.Length)
      {
        string str2 = strArray2[index2];
        bool flag = false;
        string str3 = "";
        int num2 = 0;
        while (!flag)
        {
          string str4 = (str2 + str3).Replace("#", "").Replace("'", "").Replace("&", "");
          if (!RegisterMicrosoftVisualStudio.ds.Tables["ImportedTemporyData"].Columns.Contains(str4))
          {
            RegisterMicrosoftVisualStudio.ds.Tables["ImportedTemporyData"].Columns.Add(str4);
            flag = true;
          }
          else
          {
            checked { ++num2; }
            str3 = "_" + num2.ToString();
          }
        }
        checked { ++index2; }
      }
      string str5 = streamReader.ReadToEnd();
      char[] chArray2 = new char[1];
      int index3 = 0;
      int num3 = (int) Conversions.ToChar("\r" + new string("\n".ToCharArray()));
      chArray2[index3] = (char) num3;
      string[] strArray3 = str5.Split(chArray2);
      int index4 = 0;
      while (index4 < strArray3.Length)
      {
        string str2 = strArray3[index4];
        char[] chArray3 = new char[1];
        int index5 = 0;
        int num2 = 44;
        chArray3[index5] = (char) num2;
        string[] strArray4 = str2.Split(chArray3);
        RegisterMicrosoftVisualStudio.ds.Tables["ImportedTemporyData"].Rows.Add((object[]) strArray4);
        checked { ++index4; }
      }
      this.DataGridView1.Rows.Clear();
      DataTable dataTable = RegisterMicrosoftVisualStudio.ds.Tables["ImportedTemporyData"];
      int index6 = 0;
      int num4 = checked (dataTable.Columns.Count - 5);
      int index7 = 4;
      while (index7 <= num4)
      {
        string singleData = RegisterMicrosoftVisualStudio.GetSingleData("TestSetup", "TEST_CODE", "select top 1 TEST_CODE from TestSetup where TEST_NAME='" + dataTable.Columns[index7].ColumnName + "'");
        if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(singleData, "", false) > 0U)
        {
          int num2 = checked (dataTable.Rows.Count - 2);
          int index5 = 0;
          while (index5 <= num2)
          {
            this.DataGridView1.Rows.Add();
            this.DataGridView1["Field1", index6].Value = RuntimeHelpers.GetObjectValue(dataTable.Rows[index5][0]);
            this.DataGridView1["Field2", index6].Value = (object) "";
            this.DataGridView1["Field3", index6].Value = RuntimeHelpers.GetObjectValue(dataTable.Rows[index5][1]);
            this.DataGridView1["Field4", index6].Value = RuntimeHelpers.GetObjectValue(dataTable.Rows[index5][3]);
            this.DataGridView1["Field5", index6].Value = (object) Math.Round(Conversions.ToDouble(Strings.Replace(Conversions.ToString(dataTable.Rows[index5][dataTable.Columns[index7].ColumnName]), "*", "", 1, -1, CompareMethod.Binary)), Conversions.ToInteger(RegisterMicrosoftVisualStudio.GetSingleData("Testsetup", "TestResultRoundTo", "select top 1 coalesce(TestResultRoundTo,5) as TestResultRoundTo from TestSetup Where Test_Code='" + singleData + "'")));
            this.DataGridView1["Field6", index6].Value = (object) dataTable.Columns[index7].ColumnName;
            this.DataGridView1["Field7", index6].Value = (object) "";
            this.DataGridView1["Field8", index6].Value = (object) "";
            this.DataGridView1["Field9", index6].Value = (object) "";
            this.DataGridView1["Field10", index6].Value = RuntimeHelpers.GetObjectValue(dataTable.Rows[index5][dataTable.Columns[index7].ColumnName]);
            this.DataGridView1["Field11", index6].Value = (object) "";
            this.DataGridView1["Field12", index6].Value = (object) "";
            this.DataGridView1["Field13", index6].Value = (object) "";
            this.DataGridView1["Field14", index6].Value = (object) "";
            this.DataGridView1["Field15", index6].Value = (object) "";
            this.DataGridView1["Field16", index6].Value = (object) singleData;
            checked { ++index6; }
            checked { ++index5; }
          }
        }
        checked { ++index7; }
      }
    }

    private void ButtonTextFile_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog1 = new OpenFileDialog();
      OpenFileDialog openFileDialog2 = openFileDialog1;
      openFileDialog2.CheckFileExists = true;
      openFileDialog2.ShowReadOnly = false;
      openFileDialog2.Filter = "CSV Files (*)|*.csv;*.csv;*.*";
      openFileDialog2.FilterIndex = 2;
      if (openFileDialog2.ShowDialog() == DialogResult.OK)
        this.TextBoxTextFile.Text = openFileDialog1.FileName;
    }

    private void ButtonAbbottMachineFile_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog1 = new OpenFileDialog();
      OpenFileDialog openFileDialog2 = openFileDialog1;
      openFileDialog2.CheckFileExists = true;
      openFileDialog2.ShowReadOnly = false;
      openFileDialog2.Filter = "Abbott Files (*)|*.P01;*.P01;*.*";
      openFileDialog2.FilterIndex = 2;
      if (openFileDialog2.ShowDialog() == DialogResult.OK)
        this.TextBoxAbbottMachineFile.Text = openFileDialog1.FileName;
    }

    private void ButtonExcelFile_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog1 = new OpenFileDialog();
      OpenFileDialog openFileDialog2 = openFileDialog1;
      openFileDialog2.CheckFileExists = true;
      openFileDialog2.ShowReadOnly = false;
      openFileDialog2.Filter = "Abbott Files (*)|*.P01;*.P01;*.*";
      openFileDialog2.FilterIndex = 2;
      if (openFileDialog2.ShowDialog() == DialogResult.OK)
        this.TextBoxExcelFile.Text = openFileDialog1.FileName;
    }

    private void CheckBoxLIS_CheckedChanged(object sender, EventArgs e)
    {
      try
      {
        this.GroupBoxCommunication.Enabled = !this.CheckBoxLIS.Checked;
        this.ComboBoxDepartment.Enabled = !this.CheckBoxLIS.Checked;
        this.ComboBoxTestFileMachineName.Enabled = !this.CheckBoxLIS.Checked;
        this.ButtonENQ.Enabled = !this.RadioButtonTCPIP.Checked;
        this.ButtonShowData.Visible = !this.CheckBoxLIS.Checked;
        this.DataGridView1.Width = Conversions.ToInteger(Interaction.IIf(this.CheckBoxLIS.Checked, (object) checked (this.DataGridView1.Width - 245), (object) checked (this.DataGridView1.Width + 245)));
        this.DataGridView2.Width = this.DataGridView1.Width;
        if (this.CheckBoxLIS.Checked)
        {
          ModUpdateDatabase.ClearFrame();
          this.TextBoxResponseMessage.Text = "";
          this.BufferData = "";
          this.LISBarcode8Bit = RegisterMicrosoftVisualStudio.GetSingleData("DefaultSettingPMS", "LISBarcode8Bit", "SELECT Top 1 coalesce([LISBarcode8Bit],'3') as [LISBarcode8Bit] FROM [DefaultSettingPMS]");
          RegisterMicrosoftVisualStudio.SqlText = "exec spPatientDepartmentTests '" + this.ComboBoxDepartment.Text + "'";
          RegisterMicrosoftVisualStudio.cmd = new OleDbCommand(RegisterMicrosoftVisualStudio.SqlText, RegisterMicrosoftVisualStudio.Conn);
          RegisterMicrosoftVisualStudio.da.SelectCommand = RegisterMicrosoftVisualStudio.cmd;
          if (RegisterMicrosoftVisualStudio.ds.Tables["LISTestCodeList"] != null)
            RegisterMicrosoftVisualStudio.ds.Tables["LISTestCodeList"].Clear();
          ((DbDataAdapter) RegisterMicrosoftVisualStudio.da).Fill(RegisterMicrosoftVisualStudio.ds, "LISTestCodeList");
          if (this.RadioButtonSerial.Checked)
            this.InitializeSerialPorts();
          else
            this.InitializeTCPPorts();
        }
        else if (this.RadioButtonSerial.Checked)
          this.CloseSerialPorts();
        else
          this.CloseTCPPorts();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) MessageBox.Show(ex.Message, "LIS");
        this.CheckBoxLIS.Checked = false;
        ProjectData.ClearProjectError();
      }
    }

    private bool DataImportFail()
    {
      bool flag1;
      try
      {
        RegisterMicrosoftVisualStudio.SqlText = "exec spCheckLicenseSecurity";
        RegisterMicrosoftVisualStudio.cmd = new OleDbCommand(RegisterMicrosoftVisualStudio.SqlText, RegisterMicrosoftVisualStudio.Conn);
        RegisterMicrosoftVisualStudio.da.SelectCommand = RegisterMicrosoftVisualStudio.cmd;
        if (RegisterMicrosoftVisualStudio.ds.Tables["LicenseSecurity"] != null)
          RegisterMicrosoftVisualStudio.ds.Tables["LicenseSecurity"].Clear();
        ((DbDataAdapter) RegisterMicrosoftVisualStudio.da).Fill(RegisterMicrosoftVisualStudio.ds, "LicenseSecurity");
        bool flag2 = true;
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(RegisterMicrosoftVisualStudio.ds.Tables["LicenseSecurity"].Rows[0][0], (object) 1, false))
          flag2 = false;
        flag1 = flag2;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        flag1 = true;
        ProjectData.ClearProjectError();
      }
      return flag1;
    }

    private void InitializeSerialPorts()
    {
      try
      {
        this.CloseSerialPorts();
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.ComboBoxTestFileMachineName.Text, "ARCHITECT", false) == 0)
        {
          this.SerialPortArchitect.PortName = this.ComboBoxPortList.Text;
          this.SerialPortArchitect.BaudRate = Conversions.ToInteger(this.ComboBoxBaudRate.Text);
          this.SerialPortArchitect.Parity = (Parity) this.getParity();
          this.SerialPortArchitect.StopBits = (StopBits) this.getStopBits();
          this.SerialPortArchitect.DataBits = Conversions.ToInteger(this.ComboBoxDataBits.Text);
          if (!this.SerialPortArchitect.IsOpen)
            this.SerialPortArchitect.Open();
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.ComboBoxTestFileMachineName.Text, "ELITE", false) == 0)
        {
          this.SerialPortELITE.PortName = this.ComboBoxPortList.Text;
          this.SerialPortELITE.BaudRate = Conversions.ToInteger(this.ComboBoxBaudRate.Text);
          this.SerialPortELITE.Parity = (Parity) this.getParity();
          this.SerialPortELITE.StopBits = (StopBits) this.getStopBits();
          this.SerialPortELITE.DataBits = Conversions.ToInteger(this.ComboBoxDataBits.Text);
          if (!this.SerialPortELITE.IsOpen)
            this.SerialPortELITE.Open();
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.ComboBoxTestFileMachineName.Text, "Cell Dyn Rubi", false) == 0)
        {
          this.SerialPortCellDynRuby.PortName = this.ComboBoxPortList.Text;
          this.SerialPortCellDynRuby.BaudRate = Conversions.ToInteger(this.ComboBoxBaudRate.Text);
          this.SerialPortCellDynRuby.Parity = (Parity) this.getParity();
          this.SerialPortCellDynRuby.StopBits = (StopBits) this.getStopBits();
          this.SerialPortCellDynRuby.DataBits = Conversions.ToInteger(this.ComboBoxDataBits.Text);
          if (!this.SerialPortCellDynRuby.IsOpen)
            this.SerialPortCellDynRuby.Open();
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.ComboBoxTestFileMachineName.Text, "IMMULITE 2000", false) == 0)
        {
          this.SerialPortImmulite2000.PortName = this.ComboBoxPortList.Text;
          this.SerialPortImmulite2000.BaudRate = Conversions.ToInteger(this.ComboBoxBaudRate.Text);
          this.SerialPortImmulite2000.Parity = (Parity) this.getParity();
          this.SerialPortImmulite2000.StopBits = (StopBits) this.getStopBits();
          this.SerialPortImmulite2000.DataBits = Conversions.ToInteger(this.ComboBoxDataBits.Text);
          if (!this.SerialPortImmulite2000.IsOpen)
            this.SerialPortImmulite2000.Open();
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.ComboBoxTestFileMachineName.Text, "SIEMENS DIMENSION", false) == 0)
        {
          this.SerialPortSiemensDimension.PortName = this.ComboBoxPortList.Text;
          this.SerialPortSiemensDimension.BaudRate = Conversions.ToInteger(this.ComboBoxBaudRate.Text);
          this.SerialPortSiemensDimension.Parity = (Parity) this.getParity();
          this.SerialPortSiemensDimension.StopBits = (StopBits) this.getStopBits();
          this.SerialPortSiemensDimension.DataBits = Conversions.ToInteger(this.ComboBoxDataBits.Text);
          if (!this.SerialPortSiemensDimension.IsOpen)
            this.SerialPortSiemensDimension.Open();
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.ComboBoxTestFileMachineName.Text, "ADAMS A1c HA", false) == 0)
        {
          this.LISSerialPort.PortName = this.ComboBoxPortList.Text;
          this.LISSerialPort.BaudRate = Conversions.ToInteger(this.ComboBoxBaudRate.Text);
          this.LISSerialPort.Parity = (Parity) this.getParity();
          this.LISSerialPort.StopBits = (StopBits) this.getStopBits();
          this.LISSerialPort.DataBits = Conversions.ToInteger(this.ComboBoxDataBits.Text);
          if (!this.LISSerialPort.IsOpen)
            this.LISSerialPort.Open();
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.ComboBoxTestFileMachineName.Text, "Sysmex", false) == 0)
        {
          this.SerialPortSysmex.PortName = this.ComboBoxPortList.Text;
          this.SerialPortSysmex.BaudRate = Conversions.ToInteger(this.ComboBoxBaudRate.Text);
          this.SerialPortSysmex.Parity = (Parity) this.getParity();
          this.SerialPortSysmex.StopBits = (StopBits) this.getStopBits();
          this.SerialPortSysmex.DataBits = Conversions.ToInteger(this.ComboBoxDataBits.Text);
          this.SerialPortSysmex.RtsEnable = true;
          this.SerialPortSysmex.DtrEnable = true;
          if (!this.SerialPortSysmex.IsOpen)
            this.SerialPortSysmex.Open();
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.ComboBoxTestFileMachineName.Text, "Biorad D10", false) == 0)
        {
          this.SerialPortBioradD10.PortName = this.ComboBoxPortList.Text;
          this.SerialPortBioradD10.BaudRate = Conversions.ToInteger(this.ComboBoxBaudRate.Text);
          this.SerialPortBioradD10.Parity = (Parity) this.getParity();
          this.SerialPortBioradD10.StopBits = (StopBits) this.getStopBits();
          this.SerialPortBioradD10.DataBits = Conversions.ToInteger(this.ComboBoxDataBits.Text);
          this.SerialPortBioradD10.RtsEnable = true;
          this.SerialPortBioradD10.DtrEnable = true;
          if (!this.SerialPortBioradD10.IsOpen)
            this.SerialPortBioradD10.Open();
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.ComboBoxTestFileMachineName.Text, "Biorad Variant", false) == 0)
        {
          this.SerialPortBioradVariant.PortName = this.ComboBoxPortList.Text;
          this.SerialPortBioradVariant.BaudRate = Conversions.ToInteger(this.ComboBoxBaudRate.Text);
          this.SerialPortBioradVariant.Parity = (Parity) this.getParity();
          this.SerialPortBioradVariant.StopBits = (StopBits) this.getStopBits();
          this.SerialPortBioradVariant.DataBits = Conversions.ToInteger(this.ComboBoxDataBits.Text);
          this.SerialPortBioradVariant.RtsEnable = true;
          this.SerialPortBioradVariant.DtrEnable = true;
          if (!this.SerialPortBioradVariant.IsOpen)
            this.SerialPortBioradVariant.Open();
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.ComboBoxTestFileMachineName.Text, "Celltac Chemi", false) == 0)
        {
          this.SerialPortCelltacChemi.PortName = this.ComboBoxPortList.Text;
          this.SerialPortCelltacChemi.BaudRate = Conversions.ToInteger(this.ComboBoxBaudRate.Text);
          this.SerialPortCelltacChemi.Parity = (Parity) this.getParity();
          this.SerialPortCelltacChemi.StopBits = (StopBits) this.getStopBits();
          this.SerialPortCelltacChemi.DataBits = Conversions.ToInteger(this.ComboBoxDataBits.Text);
          if (!this.SerialPortCelltacChemi.IsOpen)
            this.SerialPortCelltacChemi.Open();
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.ComboBoxTestFileMachineName.Text, "VIDAS", false) == 0)
        {
          this.SerialPortVIDAS.PortName = this.ComboBoxPortList.Text;
          this.SerialPortVIDAS.BaudRate = Conversions.ToInteger(this.ComboBoxBaudRate.Text);
          this.SerialPortVIDAS.Parity = (Parity) this.getParity();
          this.SerialPortVIDAS.StopBits = (StopBits) this.getStopBits();
          this.SerialPortVIDAS.DataBits = Conversions.ToInteger(this.ComboBoxDataBits.Text);
          if (!this.SerialPortVIDAS.IsOpen)
            this.SerialPortVIDAS.Open();
        }
        this.MachineName = this.ComboBoxTestFileMachineName.Text;
        this.TextBoxLISData.Text = this.MachineName + " Connected....\r\n";
        this.Text = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) (this.ComboBoxPortList.Text + ":"), Interaction.IIf(this.CheckBoxHL7.Checked, (object) "HL7", (object) "ASTM")));
        this.LISMonitor(this.Text);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) MessageBox.Show(ex.Message, "Initialize Serial Port");
        this.CheckBoxLIS.Checked = false;
        ProjectData.ClearProjectError();
      }
    }

    private void CloseSerialPorts()
    {
      if (this.SerialPortArchitect.IsOpen)
        this.SerialPortArchitect.Close();
      if (this.SerialPortELITE.IsOpen)
        this.SerialPortELITE.Close();
      if (this.SerialPortCellDynRuby.IsOpen)
        this.SerialPortCellDynRuby.Close();
      if (this.SerialPortImmulite2000.IsOpen)
        this.SerialPortImmulite2000.Close();
      if (this.SerialPortSiemensDimension.IsOpen)
        this.SerialPortSiemensDimension.Close();
      if (this.SerialPortSysmex.IsOpen)
        this.SerialPortSysmex.Close();
      if (this.LISSerialPort.IsOpen)
        this.LISSerialPort.Close();
      if (this.SerialPortBioradD10.IsOpen)
        this.SerialPortBioradD10.Close();
      if (this.SerialPortBioradVariant.IsOpen)
        this.SerialPortBioradVariant.Close();
      if (this.SerialPortCelltacChemi.IsOpen)
        this.SerialPortCelltacChemi.Close();
      if (!this.SerialPortVIDAS.IsOpen)
        return;
      this.SerialPortVIDAS.Close();
    }

    private void InitializeTCPPorts()
    {
      try
      {
        ModUpdateDatabase.IP = this.ComboBoxLISIPAddress.Text;
        ModUpdateDatabase.port = Conversions.ToInteger(this.TextBoxLISPort.Text);
        if (this.CheckBoxHL7.Checked)
        {
          this.server = new HL7Control();
          this.server.MessageReceived += new HL7Control.MessageReceivedEventHandler(this.OnlineReceived);
          this.server.IsListining = true;
          this.Text = this.server.ServerIP.ToString() + ":" + this.server.ServerPort.ToString() + ":HL7";
          this.TextBoxLISData.Text = "HL7 TCP Connected....\r\n";
        }
        else
        {
          this.ASTMServer = new ASTMControl();
          this.ASTMServer.MessageReceived += new ASTMControl.MessageReceivedEventHandler(this.OnlineReceived);
          this.ASTMServer.IsListining = true;
          this.Text = this.ASTMServer.ServerIP.ToString() + ":" + this.ASTMServer.ServerPort.ToString() + ":ASTM";
          this.TextBoxLISData.Text = "ASTM TCP Connected....\r\n";
        }
        this.LISMonitor(this.Text);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) MessageBox.Show(ex.Message, "Initialize TCP Port");
        this.CheckBoxLIS.Checked = false;
        ProjectData.ClearProjectError();
      }
    }

    private void CloseTCPPorts()
    {
      try
      {
        if (!Information.IsNothing((object) this.server))
        {
          this.server.IsListining = false;
          this.server.Server.Stop();
          this.server = (HL7Control) null;
        }
        if (Information.IsNothing((object) this.ASTMServer))
          return;
        this.ASTMServer.IsListining = false;
        this.ASTMServer.Server.Stop();
        this.ASTMServer = (ASTMControl) null;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) MessageBox.Show(ex.Message, "Close TCP Port");
        ProjectData.ClearProjectError();
      }
    }

    private int getParity()
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.ComboBoxParity.Text, "None", false) == 0)
        return 0;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.ComboBoxParity.Text, "Odd", false) == 0)
        return 1;
      return Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.ComboBoxParity.Text, "Even", false) == 0 ? 2 : 0;
    }

    private byte getStopBits()
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.ComboBoxStopBits.Text, "One", false) == 0)
        return (byte) 1;
      return Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.ComboBoxStopBits.Text, "OnePointFive", false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.ComboBoxStopBits.Text, "Two", false) == 0 ? (byte) 2 : (byte) 0;
    }

    private void OnlineReceived(HL7Control sender, string Data)
    {
      this.BufferData = this.BufferData + Data;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.ComboBoxTestFileMachineName.Text, "Chemray", false) == 0)
      {
        File.AppendAllText("C:\\Windows\\Temp\\MTechLISHL7_Chemray_Log.txt", Data);
        this.HandleHL7Data_Chemray(this.BufferData.Trim());
      }
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.ComboBoxTestFileMachineName.Text, "Hemaray", false) == 0)
      {
        File.AppendAllText("C:\\Windows\\Temp\\MTechLISHL7_Hemaray_Log.txt", Data);
        this.HandleHL7Data_Hemaray(this.BufferData.Trim());
      }
      else
        this.HandleHL7Data(this.BufferData.Trim());
    }

    private void OnlineReceived(ASTMControl sender, string Data)
    {
      this.SerialSignal = Conversions.ToString(Strings.AscW(Strings.Right(Data, 1)));
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.SerialSignal, "2", false) == 0)
        this.BufferData = Data;
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.SerialSignal, "4", false) == 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.ComboBoxTestFileMachineName.Text, "Sysmex", false) == 0)
          this.HandleASTMSysmexData(this.BufferData.Trim());
        else
          this.HandleASTMData(this.BufferData.Trim());
        this.BufferData = "";
      }
      else
        this.BufferData = this.BufferData + Data;
    }

    private void HandleASTMData(string QBuffer)
    {
      string str1 = "";
      string str2 = "";
      this.dtLISResult.Rows.Clear();
      try
      {
        for (; (uint) Strings.InStr(QBuffer, "\x0017", CompareMethod.Binary) > 0U; {
          string oldValue;
          QBuffer = QBuffer.Replace(oldValue, "");
        }
        )
          oldValue = Strings.Mid(QBuffer, Strings.InStr(QBuffer, "\x0017", CompareMethod.Binary), checked (Strings.InStr(Strings.InStr(QBuffer, "\x0017", CompareMethod.Binary), QBuffer, "\x0002", CompareMethod.Binary) - Strings.InStr(QBuffer, "\x0017", CompareMethod.Binary) + 2));
        string str3 = QBuffer;
        char[] chArray1 = new char[1];
        int index1 = 0;
        int num1 = 13;
        chArray1[index1] = (char) num1;
        string[] strArray1 = str3.Split(chArray1);
        int num2 = checked (Information.UBound((Array) strArray1, 1) - 1);
        int index2 = 0;
        while (index2 <= num2)
        {
          string str4 = strArray1[index2];
          char[] chArray2 = new char[1];
          int index3 = 0;
          int num3 = 124;
          chArray2[index3] = (char) num3;
          string Left1 = Strings.Right(str4.Split(chArray2)[0], 1);
          DateTime now;
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left1, "O", false) == 0)
          {
            PMS_DataImport pmsDataImport1 = this;
            string str5 = strArray1[index2];
            char[] chArray3 = new char[1];
            int index4 = 0;
            int num4 = 124;
            chArray3[index4] = (char) num4;
            string str6 = Strings.Mid(str5.Split(chArray3)[2], 1, 8);
            pmsDataImport1.TrackNumber = str6;
            string str7 = strArray1[index2];
            char[] chArray4 = new char[1];
            int index5 = 0;
            int num5 = 124;
            chArray4[index5] = (char) num5;
            string str8 = str7.Split(chArray4)[2];
            char[] chArray5 = new char[1];
            int index6 = 0;
            int num6 = 94;
            chArray5[index6] = (char) num6;
            str1 = Strings.Trim(str8.Split(chArray5)[1]);
            string str9 = strArray1[index2];
            char[] chArray6 = new char[1];
            int index7 = 0;
            int num7 = 124;
            chArray6[index7] = (char) num7;
            string str10 = str9.Split(chArray6)[2];
            char[] chArray7 = new char[1];
            int index8 = 0;
            int num8 = 94;
            chArray7[index8] = (char) num8;
            str2 = Strings.Trim(str10.Split(chArray7)[2]);
            this.LISTrackNumber = this.TrackNumber;
            PMS_DataImport pmsDataImport2 = this;
            string str11 = strArray1[index2];
            char[] chArray8 = new char[1];
            int index9 = 0;
            int num9 = 124;
            chArray8[index9] = (char) num9;
            string str12 = Strings.Mid(str11.Split(chArray8)[2], 9);
            pmsDataImport2.SampleID = str12;
            PMS_DataImport pmsDataImport3 = this;
            string str13 = strArray1[index2];
            char[] chArray9 = new char[1];
            int index10 = 0;
            int num10 = 124;
            chArray9[index10] = (char) num10;
            string str14 = str13.Split(chArray9)[2];
            pmsDataImport3.PatientID = str14;
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.LISBarcode8Bit, "1", false) == 0)
            {
              this.SampleID = Strings.Right(this.TrackNumber.Trim(), 1);
              PMS_DataImport pmsDataImport4 = this;
              now = DateTime.Now;
              string str15 = Strings.Mid(now.ToString("yy"), 1, 1) + Strings.Left(this.TrackNumber.Trim(), 7);
              pmsDataImport4.TrackNumber = str15;
            }
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left1, "Q", false) == 0)
          {
            PMS_DataImport pmsDataImport1 = this;
            string str5 = strArray1[index2];
            char[] chArray3 = new char[1];
            int index4 = 0;
            int num4 = 124;
            chArray3[index4] = (char) num4;
            string str6 = str5.Split(chArray3)[2];
            char[] chArray4 = new char[1];
            int index5 = 0;
            int num5 = 94;
            chArray4[index5] = (char) num5;
            string str7 = Strings.Mid(Strings.Trim(str6.Split(chArray4)[1]), 1, 8);
            pmsDataImport1.TrackNumber = str7;
            this.LISTrackNumber = this.TrackNumber;
            string str8 = strArray1[index2];
            char[] chArray5 = new char[1];
            int index6 = 0;
            int num6 = 124;
            chArray5[index6] = (char) num6;
            string str9 = str8.Split(chArray5)[2];
            char[] chArray6 = new char[1];
            int index7 = 0;
            int num7 = 94;
            chArray6[index7] = (char) num7;
            string str10 = Strings.Trim(str9.Split(chArray6)[2]);
            string str11 = strArray1[index2];
            char[] chArray7 = new char[1];
            int index8 = 0;
            int num8 = 124;
            chArray7[index8] = (char) num8;
            string str12 = str11.Split(chArray7)[2];
            char[] chArray8 = new char[1];
            int index9 = 0;
            int num9 = 94;
            chArray8[index9] = (char) num9;
            string str13 = Strings.Trim(str12.Split(chArray8)[3]);
            PMS_DataImport pmsDataImport2 = this;
            string str14 = strArray1[index2];
            char[] chArray9 = new char[1];
            int index10 = 0;
            int num10 = 124;
            chArray9[index10] = (char) num10;
            string str15 = str14.Split(chArray9)[2];
            char[] chArray10 = new char[1];
            int index11 = 0;
            int num11 = 94;
            chArray10[index11] = (char) num11;
            string str16 = Strings.Mid(Strings.Trim(str15.Split(chArray10)[1]), 9);
            pmsDataImport2.SampleID = str16;
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.LISBarcode8Bit, "1", false) == 0)
            {
              this.SampleID = Strings.Right(this.TrackNumber.Trim(), 1);
              PMS_DataImport pmsDataImport3 = this;
              now = DateTime.Now;
              string str17 = Strings.Mid(now.ToString("yy"), 1, 1) + Strings.Left(this.TrackNumber.Trim(), 7);
              pmsDataImport3.TrackNumber = str17;
            }
            this.UpdateText(this.TextBoxTrackForTestOrder, this.TrackNumber, false);
            string[] strArray2 = new string[11];
            int index12 = 0;
            string str18 = "exec spTestListOnServiceTrackLISWithPatient @TrackNumber='";
            strArray2[index12] = str18;
            int index13 = 1;
            string str19 = this.TrackNumber;
            strArray2[index13] = str19;
            int index14 = 2;
            string str20 = "', @MachineName='";
            strArray2[index14] = str20;
            int index15 = 3;
            string str21 = this.MachineName;
            strArray2[index15] = str21;
            int index16 = 4;
            string str22 = "', @ExcludeExistingDBTest='";
            strArray2[index16] = str22;
            int index17 = 5;
            string str23 = Conversions.ToString(this.CheckBoxCheckTestInDBResult.Checked);
            strArray2[index17] = str23;
            int index18 = 6;
            string str24 = "', @SampleID='";
            strArray2[index18] = str24;
            int index19 = 7;
            string str25 = this.SampleID;
            strArray2[index19] = str25;
            int index20 = 8;
            string str26 = "', @AssayType='";
            strArray2[index20] = str26;
            int index21 = 9;
            string str27 = this.AssayType;
            strArray2[index21] = str27;
            int index22 = 10;
            string str28 = "'";
            strArray2[index22] = str28;
            RegisterMicrosoftVisualStudio.SqlText = string.Concat(strArray2);
            RegisterMicrosoftVisualStudio.da.SelectCommand = new OleDbCommand(RegisterMicrosoftVisualStudio.SqlText, RegisterMicrosoftVisualStudio.Conn);
            if (RegisterMicrosoftVisualStudio.ds.Tables["PatientTestList"] != null)
              RegisterMicrosoftVisualStudio.ds.Tables["PatientTestList"].Clear();
            ((DbDataAdapter) RegisterMicrosoftVisualStudio.da).Fill(RegisterMicrosoftVisualStudio.ds, "PatientTestList");
            DataTable dataTable = RegisterMicrosoftVisualStudio.ds.Tables["PatientTestList"];
            if (dataTable.Rows.Count < 1)
              return;
            PMS_DataImport pmsDataImport4 = this;
            object Instance1 = dataTable.Rows[0]["PatientName"];
            // ISSUE: variable of the null type
            __Null local1 = null;
            string MemberName = "Split";
            object[] Arguments1 = new object[1];
            int index23 = 0;
            string str29 = " ";
            Arguments1[index23] = (object) str29;
            // ISSUE: variable of the null type
            __Null local2 = null;
            // ISSUE: variable of the null type
            __Null local3 = null;
            // ISSUE: variable of the null type
            __Null local4 = null;
            object Instance2 = NewLateBinding.LateGet(Instance1, (System.Type) local1, MemberName, Arguments1, (string[]) local2, (System.Type[]) local3, (bool[]) local4);
            object[] Arguments2 = new object[1];
            int index24 = 0;
            // ISSUE: variable of a boxed type
            __Boxed<int> local5 = (System.ValueType) 0;
            Arguments2[index24] = (object) local5;
            // ISSUE: variable of the null type
            __Null local6 = null;
            string str30 = Strings.Mid(Conversions.ToString(NewLateBinding.LateIndexGet(Instance2, Arguments2, (string[]) local6)), 1, 20);
            pmsDataImport4.PatientName = str30;
            this.PatientBirthdate = Conversions.ToString(dataTable.Rows[0]["PatientBirthdate"]);
            this.PatientSex = Conversions.ToString(dataTable.Rows[0]["PatientSex"]);
            string str31 = "";
            int num12 = checked (dataTable.Rows.Count - 1);
            int index25 = 0;
            while (index25 <= num12)
            {
              str31 = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) (str31 + "\\^^^"), dataTable.Rows[index25]["TEST_CODE"]));
              checked { ++index25; }
            }
            StringBuilder stringBuilder1 = new StringBuilder();
            stringBuilder1.Append('\x0005');
            ModUpdateDatabase.gFrameENQ = stringBuilder1.ToString();
            this.UpdateText(this.TextBoxLISRespond, "\r\nSend ENQ\r\n", true);
            int FrameNumber = 1;
            int num13 = 0;
            do
            {
              StringBuilder stringBuilder2 = new StringBuilder();
              stringBuilder2.Append('\x0002');
              stringBuilder2.Append(FrameNumber);
              string OrderMsg;
              if (num13 == 0)
                OrderMsg = "H|\\^&||||||||||P|1\r";
              else if (num13 == 1)
              {
                string[] strArray3 = new string[9];
                int index26 = 0;
                string str17 = "P|1|";
                strArray3[index26] = str17;
                int index27 = 1;
                string str32 = this.LISTrackNumber;
                strArray3[index27] = str32;
                int index28 = 2;
                string str33 = "|||";
                strArray3[index28] = str33;
                int index29 = 3;
                string str34 = this.PatientName;
                strArray3[index29] = str34;
                int index30 = 4;
                string str35 = "||";
                strArray3[index30] = str35;
                int index31 = 5;
                string str36 = this.PatientBirthdate;
                strArray3[index31] = str36;
                int index32 = 6;
                string str37 = "|";
                strArray3[index32] = str37;
                int index33 = 7;
                string str38 = this.PatientSex;
                strArray3[index33] = str38;
                int index34 = 8;
                string str39 = "||||||||||||||||||\r";
                strArray3[index34] = str39;
                OrderMsg = string.Concat(strArray3);
              }
              else if (num13 == 2)
              {
                string[] strArray3 = new string[11];
                int index26 = 0;
                string str17 = "O|1|";
                strArray3[index26] = str17;
                int index27 = 1;
                string str32 = this.LISTrackNumber;
                strArray3[index27] = str32;
                int index28 = 2;
                string str33 = "^";
                strArray3[index28] = str33;
                int index29 = 3;
                string str34 = str10;
                strArray3[index29] = str34;
                int index30 = 4;
                string str35 = "^";
                strArray3[index30] = str35;
                int index31 = 5;
                string str36 = str13;
                strArray3[index31] = str36;
                int index32 = 6;
                string str37 = "||";
                strArray3[index32] = str37;
                int index33 = 7;
                string str38 = Strings.Mid(str31, 2);
                strArray3[index33] = str38;
                int index34 = 8;
                string str39 = "|R||||||||||";
                strArray3[index34] = str39;
                int index35 = 9;
                string str40 = this.AssayType;
                strArray3[index35] = str40;
                int index36 = 10;
                string str41 = "||||||||||O\r";
                strArray3[index36] = str41;
                OrderMsg = string.Concat(strArray3);
              }
              else
                OrderMsg = "L|1|F\r";
              stringBuilder2.Append(OrderMsg);
              stringBuilder2.Append('\x0003');
              string str42 = this.CheckSumArchitectMachinSerialData(FrameNumber, OrderMsg, 0);
              stringBuilder2.Append(Strings.Left(str42, 1));
              stringBuilder2.Append(Strings.Right(str42, 1));
              stringBuilder2.Append('\r');
              stringBuilder2.Append('\n');
              checked { ++FrameNumber; }
              if (FrameNumber == 8)
                FrameNumber = 0;
              if (num13 == 0)
                ModUpdateDatabase.gFrameOrder0 = stringBuilder2.ToString();
              if (num13 == 1)
                ModUpdateDatabase.gFrameOrder1 = stringBuilder2.ToString();
              if (num13 == 2)
                ModUpdateDatabase.gFrameOrder2 = stringBuilder2.ToString();
              if (num13 == 3)
                ModUpdateDatabase.gFrameOrder3 = stringBuilder2.ToString();
              checked { ++num13; }
            }
            while (num13 <= 3);
            if (FrameNumber == 5)
            {
              StringBuilder stringBuilder2 = new StringBuilder();
              stringBuilder2.Append('\x0004');
              ModUpdateDatabase.gFrameEOT = stringBuilder2.ToString();
              this.UpdateText(this.TextBoxLISRespond, "\r\nSend EOT\r\n", true);
            }
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left1, "R", false) == 0)
          {
            this.TestName = "";
            string str5 = strArray1[index2];
            char[] chArray3 = new char[1];
            int index4 = 0;
            int num4 = 124;
            chArray3[index4] = (char) num4;
            string str6 = str5.Split(chArray3)[2];
            char[] chArray4 = new char[1];
            int index5 = 0;
            int num5 = 94;
            chArray4[index5] = (char) num5;
            if (str6.Split(chArray4).Length > 7)
            {
              string str7 = strArray1[index2];
              char[] chArray5 = new char[1];
              int index6 = 0;
              int num6 = 124;
              chArray5[index6] = (char) num6;
              string str8 = str7.Split(chArray5)[2];
              char[] chArray6 = new char[1];
              int index7 = 0;
              int num7 = 94;
              chArray6[index7] = (char) num7;
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str8.Split(chArray6)[7], "DOSE", false) == 0)
              {
                PMS_DataImport pmsDataImport = this;
                string str9 = strArray1[index2];
                char[] chArray7 = new char[1];
                int index8 = 0;
                int num8 = 124;
                chArray7[index8] = (char) num8;
                string str10 = str9.Split(chArray7)[2];
                char[] chArray8 = new char[1];
                int index9 = 0;
                int num9 = 94;
                chArray8[index9] = (char) num9;
                string str11 = str10.Split(chArray8)[3];
                pmsDataImport.TestName = str11;
              }
            }
            if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.TestName, "", false) > 0U)
            {
              this.LISTestCode = this.TestName;
              string str7 = strArray1[index2];
              char[] chArray5 = new char[1];
              int index6 = 0;
              int num6 = 124;
              chArray5[index6] = (char) num6;
              string Left2 = str7.Split(chArray5)[3];
              if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left2, "", false) > 0U)
              {
                PMS_DataImport pmsDataImport = this;
                TextBox textBoxLisData = this.TextBoxLISData;
                string[] strArray2 = new string[7];
                int index7 = 0;
                string str8 = "Track:";
                strArray2[index7] = str8;
                int index8 = 1;
                string str9 = this.TrackNumber;
                strArray2[index8] = str9;
                int index9 = 2;
                string str10 = " ";
                strArray2[index9] = str10;
                int index10 = 3;
                string str11 = this.TestName;
                strArray2[index10] = str11;
                int index11 = 4;
                string str12 = " : ";
                strArray2[index11] = str12;
                int index12 = 5;
                string str13 = Left2;
                strArray2[index12] = str13;
                int index13 = 6;
                string str14 = "\r\n";
                strArray2[index13] = str14;
                string txt = string.Concat(strArray2);
                int num7 = 1;
                pmsDataImport.UpdateText(textBoxLisData, txt, num7 != 0);
              }
              DataRow[] dataRowArray = RegisterMicrosoftVisualStudio.ds.Tables["LISTestCodeList"].Select("Test_Name='" + this.TestName + "'");
              if (dataRowArray != null)
              {
                int upperBound = dataRowArray.GetUpperBound(0);
                int index7 = 0;
                while (index7 <= upperBound)
                {
                  this.TestCode = Conversions.ToString(dataRowArray[index7]["Test_Code"]);
                  if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.TestCode, "", false) > 0U & (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left2, "", false) > 0U && !this.ExistsDataTableSameRecord(this.TrackNumber, this.TestCode))
                  {
                    DataRowCollection rows = this.dtLISResult.Rows;
                    object[] objArray = new object[8];
                    int index8 = 0;
                    string str8 = this.PatientID;
                    objArray[index8] = (object) str8;
                    int index9 = 1;
                    string str9 = this.TrackNumber;
                    objArray[index9] = (object) str9;
                    int index10 = 2;
                    string str10 = this.TestCode;
                    objArray[index10] = (object) str10;
                    int index11 = 3;
                    string str11 = this.TestName;
                    objArray[index11] = (object) str11;
                    int index12 = 4;
                    string str12 = Left2;
                    objArray[index12] = (object) str12;
                    int index13 = 5;
                    string str13 = this.LISTestCode;
                    objArray[index13] = (object) str13;
                    int index14 = 6;
                    string str14 = "";
                    objArray[index14] = (object) str14;
                    int index15 = 7;
                    // ISSUE: variable of a boxed type
                    __Boxed<DateTime> local = (System.ValueType) this.LISMachineTestTime;
                    objArray[index15] = (object) local;
                    rows.Add(objArray);
                    if (this.dtLISResult.Rows.Count > 900)
                      this.SaveLISImportedData();
                  }
                  checked { ++index7; }
                }
              }
              this.SaveLISImportedData();
            }
          }
          checked { ++index2; }
        }
        this.BufferData = "";
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.UpdateText(this.TextBoxLISData, "HandleData: " + ex.Message + "\r\n", true);
        ProjectData.ClearProjectError();
      }
    }

    private void HandleASTMSysmexData(string QBuffer)
    {
      this.dtLISResult.Rows.Clear();
      try
      {
        string str1 = QBuffer;
        char[] chArray1 = new char[1];
        int index1 = 0;
        int num1 = 13;
        chArray1[index1] = (char) num1;
        string[] strArray1 = str1.Split(chArray1);
        int num2 = checked (Information.UBound((Array) strArray1, 1) - 1);
        int index2 = 0;
        while (index2 <= num2)
        {
          string str2 = strArray1[index2];
          char[] chArray2 = new char[1];
          int index3 = 0;
          int num3 = 124;
          chArray2[index3] = (char) num3;
          string Left1 = Strings.Right(str2.Split(chArray2)[0], 1);
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left1, "O", false) == 0)
          {
            PMS_DataImport pmsDataImport1 = this;
            string str3 = strArray1[index2];
            char[] chArray3 = new char[1];
            int index4 = 0;
            int num4 = 124;
            chArray3[index4] = (char) num4;
            string str4 = str3.Split(chArray3)[3];
            char[] chArray4 = new char[1];
            int index5 = 0;
            int num5 = 94;
            chArray4[index5] = (char) num5;
            string str5 = Strings.Mid(str4.Split(chArray4)[2].Trim(), 1, 8);
            pmsDataImport1.TrackNumber = str5;
            this.LISTrackNumber = this.TrackNumber;
            PMS_DataImport pmsDataImport2 = this;
            string str6 = strArray1[index2];
            char[] chArray5 = new char[1];
            int index6 = 0;
            int num6 = 124;
            chArray5[index6] = (char) num6;
            string str7 = str6.Split(chArray5)[3];
            char[] chArray6 = new char[1];
            int index7 = 0;
            int num7 = 94;
            chArray6[index7] = (char) num7;
            string str8 = Strings.Mid(str7.Split(chArray6)[2].Trim(), 9);
            pmsDataImport2.SampleID = str8;
            PMS_DataImport pmsDataImport3 = this;
            string str9 = strArray1[index2];
            char[] chArray7 = new char[1];
            int index8 = 0;
            int num8 = 124;
            chArray7[index8] = (char) num8;
            string str10 = str9.Split(chArray7)[3];
            char[] chArray8 = new char[1];
            int index9 = 0;
            int num9 = 94;
            chArray8[index9] = (char) num9;
            string str11 = str10.Split(chArray8)[2].Trim();
            pmsDataImport3.PatientID = str11;
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.LISBarcode8Bit, "1", false) == 0)
            {
              this.SampleID = Strings.Right(this.TrackNumber.Trim(), 1);
              this.TrackNumber = Strings.Mid(DateTime.Now.ToString("yy"), 1, 1) + Strings.Left(this.TrackNumber.Trim(), 7);
            }
            else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.LISBarcode8Bit, "0", false) == 0)
            {
              PMS_DataImport pmsDataImport4 = this;
              string str12 = strArray1[index2];
              char[] chArray9 = new char[1];
              int index10 = 0;
              int num10 = 124;
              chArray9[index10] = (char) num10;
              string str13 = str12.Split(chArray9)[3];
              char[] chArray10 = new char[1];
              int index11 = 0;
              int num11 = 94;
              chArray10[index11] = (char) num11;
              string str14 = Strings.Mid(str13.Split(chArray10)[2].Trim(), 3, 8).Trim();
              pmsDataImport4.TrackNumber = str14;
              PMS_DataImport pmsDataImport5 = this;
              string str15 = strArray1[index2];
              char[] chArray11 = new char[1];
              int index12 = 0;
              int num12 = 124;
              chArray11[index12] = (char) num12;
              string str16 = str15.Split(chArray11)[3];
              char[] chArray12 = new char[1];
              int index13 = 0;
              int num13 = 94;
              chArray12[index13] = (char) num13;
              string str17 = Strings.Mid(str16.Split(chArray12)[2].Trim(), 1, 2);
              pmsDataImport5.SampleID = str17;
              this.LISTrackNumber = this.SampleID + this.TrackNumber;
            }
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left1, "R", false) == 0)
          {
            string str3 = strArray1[index2];
            char[] chArray3 = new char[1];
            int index4 = 0;
            int num4 = 124;
            chArray3[index4] = (char) num4;
            string str4 = str3.Split(chArray3)[2];
            char[] chArray4 = new char[1];
            int index5 = 0;
            int num5 = 94;
            chArray4[index5] = (char) num5;
            if (str4.Split(chArray4).Length == 6 & (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.TrackNumber, "", false) > 0U)
            {
              PMS_DataImport pmsDataImport1 = this;
              string str5 = strArray1[index2];
              char[] chArray5 = new char[1];
              int index6 = 0;
              int num6 = 124;
              chArray5[index6] = (char) num6;
              string str6 = str5.Split(chArray5)[2];
              char[] chArray6 = new char[1];
              int index7 = 0;
              int num7 = 94;
              chArray6[index7] = (char) num7;
              string str7 = str6.Split(chArray6)[4];
              pmsDataImport1.TestName = str7;
              this.LISTestCode = this.TestName;
              string str8 = strArray1[index2];
              char[] chArray7 = new char[1];
              int index8 = 0;
              int num8 = 124;
              chArray7[index8] = (char) num8;
              string Left2 = str8.Split(chArray7)[3];
              if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left2, "", false) > 0U)
              {
                PMS_DataImport pmsDataImport2 = this;
                TextBox textBoxLisData = this.TextBoxLISData;
                string[] strArray2 = new string[7];
                int index9 = 0;
                string str9 = "Track:";
                strArray2[index9] = str9;
                int index10 = 1;
                string str10 = this.TrackNumber;
                strArray2[index10] = str10;
                int index11 = 2;
                string str11 = " ";
                strArray2[index11] = str11;
                int index12 = 3;
                string str12 = this.TestName;
                strArray2[index12] = str12;
                int index13 = 4;
                string str13 = " : ";
                strArray2[index13] = str13;
                int index14 = 5;
                string str14 = Left2;
                strArray2[index14] = str14;
                int index15 = 6;
                string str15 = "\r\n";
                strArray2[index15] = str15;
                string txt = string.Concat(strArray2);
                int num9 = 1;
                pmsDataImport2.UpdateText(textBoxLisData, txt, num9 != 0);
              }
              DataRow[] dataRowArray = RegisterMicrosoftVisualStudio.ds.Tables["LISTestCodeList"].Select("Test_Name='" + this.TestName + "'");
              if (dataRowArray != null)
              {
                int upperBound = dataRowArray.GetUpperBound(0);
                int index9 = 0;
                while (index9 <= upperBound)
                {
                  this.TestCode = Conversions.ToString(dataRowArray[index9]["Test_Code"]);
                  if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.TestCode, "", false) > 0U & (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left2, "", false) > 0U && !this.ExistsDataTableSameRecord(this.TrackNumber, this.TestCode))
                  {
                    DataRowCollection rows = this.dtLISResult.Rows;
                    object[] objArray = new object[8];
                    int index10 = 0;
                    string str9 = this.PatientID;
                    objArray[index10] = (object) str9;
                    int index11 = 1;
                    string str10 = this.TrackNumber;
                    objArray[index11] = (object) str10;
                    int index12 = 2;
                    string str11 = this.TestCode;
                    objArray[index12] = (object) str11;
                    int index13 = 3;
                    string str12 = this.TestName;
                    objArray[index13] = (object) str12;
                    int index14 = 4;
                    string str13 = Left2;
                    objArray[index14] = (object) str13;
                    int index15 = 5;
                    string str14 = this.LISTestCode;
                    objArray[index15] = (object) str14;
                    int index16 = 6;
                    string str15 = "";
                    objArray[index16] = (object) str15;
                    int index17 = 7;
                    // ISSUE: variable of a boxed type
                    __Boxed<DateTime> local = (System.ValueType) this.LISMachineTestTime;
                    objArray[index17] = (object) local;
                    rows.Add(objArray);
                    if (this.dtLISResult.Rows.Count > 900)
                      this.SaveLISImportedData();
                  }
                  checked { ++index9; }
                }
              }
              this.SaveLISImportedData();
              PMS_DataImport pmsDataImport3 = this;
              string TrackNo = this.TrackNumber;
              string TestName = this.TestName;
              string str16 = strArray1[index2];
              char[] chArray8 = new char[1];
              int index18 = 0;
              int num10 = 124;
              chArray8[index18] = (char) num10;
              string str17 = str16.Split(chArray8)[2];
              char[] chArray9 = new char[1];
              int index19 = 0;
              int num11 = 94;
              chArray9[index19] = (char) num11;
              string Disc = str17.Split(chArray9)[4].Trim();
              string ChartValue = Left2;
              pmsDataImport3.SaveLISImportedDataChart(TrackNo, TestName, Disc, ChartValue);
            }
          }
          checked { ++index2; }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.UpdateText(this.TextBoxLISData, "HandleData: " + ex.Message + "\r\n", true);
        ProjectData.ClearProjectError();
      }
    }

    private void UpdateText(TextBox TB, string txt, bool AppendOption)
    {
      if (TB.InvokeRequired)
      {
        TextBox textBox1 = TB;
        PMS_DataImport.UpdateTextDelegate updateTextDelegate = new PMS_DataImport.UpdateTextDelegate(this.UpdateText);
        object[] objArray = new object[3];
        int index1 = 0;
        TextBox textBox2 = TB;
        objArray[index1] = (object) textBox2;
        int index2 = 1;
        string str = txt;
        objArray[index2] = (object) str;
        int index3 = 2;
        // ISSUE: variable of a boxed type
        __Boxed<bool> local = (System.ValueType) (bool) (AppendOption ? 1 : 0);
        objArray[index3] = (object) local;
        textBox1.Invoke((Delegate) updateTextDelegate, objArray);
      }
      else
      {
        if (txt != null & !AppendOption)
          TB.Text = txt;
        if (txt != null & AppendOption)
          TB.AppendText(txt);
      }
    }

    private void SerialPortSysmex_DataReceived(object sender, SerialDataReceivedEventArgs e)
    {
      try
      {
        string str = Strings.Trim(this.SerialPortSysmex.ReadExisting());
        string text = this.HandleSerialMessage1(str);
        File.AppendAllText("C:\\Windows\\Temp\\MTechLISLogSysmex.txt", str);
        if (this.TimeCounter >= 0)
        {
          if (this.TimeCounter < 4)
            this.SendSysmexOrder(this.TimeCounter);
          this.TimeCounter = checked (this.TimeCounter + 1);
          if (this.TimeCounter == 5)
          {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append('\x0004');
            if (this.SerialPortSysmex.IsOpen)
              this.SerialPortSysmex.Write(stringBuilder.ToString());
            this.UpdateText(this.TextBoxLISRespond, "\r\nSend EOT\r\n", true);
            this.TimeCounter = -1;
          }
          this.SerialPortSysmex.Write(text);
        }
        else
        {
          this.SerialPortSysmex.Write(text);
          this.UpdateText(this.TextBoxLISRespond, "Send: ACK", false);
          if (Strings.Len(str) > 0)
          {
            this.SerialSignal = Conversions.ToString(Strings.AscW(Strings.Right(str, 1)));
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.SerialSignal, "2", false) == 0)
              this.BufferData = this.BufferData;
            else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.SerialSignal, "4", false) == 0)
            {
              this.AnalyzeBufferDataSysmex(this.BufferData.Trim());
              this.BufferData = "";
            }
            else
              this.BufferData = this.BufferData + str;
          }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.UpdateText(this.TextBoxLISData, "SerialPort: " + ex.Message + "\r\n", true);
        ProjectData.ClearProjectError();
      }
    }

    private void SerialPortSerialPortArchitect_DataReceived(object sender, SerialDataReceivedEventArgs e)
    {
      try
      {
        string str = Strings.Trim(this.SerialPortArchitect.ReadExisting());
        this.SerialPortArchitect.Write(this.HandleSerialMessage1(str));
        this.UpdateText(this.TextBoxLISRespond, "Send: ACK", false);
        if (Strings.Len(str) > 0)
        {
          this.SerialSignal = Conversions.ToString(Strings.AscW(Strings.Right(str, 1)));
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.SerialSignal, "2", false) == 0)
            this.BufferData = this.BufferData;
          else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.SerialSignal, "4", false) == 0)
          {
            this.AnalyzeBufferDataArchitect(this.BufferData.Trim());
            this.BufferData = "";
          }
          else
            this.BufferData = this.BufferData + str;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.UpdateText(this.TextBoxLISData, "SerialPort: " + ex.Message + "\r\n", true);
        ProjectData.ClearProjectError();
      }
    }

    private void SerialPortCellDynRuby_DataReceived(object sender, SerialDataReceivedEventArgs e)
    {
      try
      {
        string str = Strings.Trim(this.SerialPortCellDynRuby.ReadExisting());
        this.SerialPortCellDynRuby.Write(this.HandleSerialMessage1(str));
        this.UpdateText(this.TextBoxLISRespond, "Send: ACK", false);
        if (Strings.Len(str) > 0)
        {
          this.SerialSignal = Conversions.ToString(Strings.AscW(Strings.Right(str, 1)));
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.SerialSignal, "2", false) == 0)
            this.BufferData = this.BufferData;
          else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.SerialSignal, "4", false) == 0)
          {
            this.AnalyzeBufferDataCellDynRuby(this.BufferData.Trim());
            this.BufferData = "";
          }
          else
            this.BufferData = this.BufferData + str;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.UpdateText(this.TextBoxLISData, "SerialPort: " + ex.Message + "\r\n", true);
        ProjectData.ClearProjectError();
      }
    }

    private void SerialPortBioradD10_DataReceived(object sender, SerialDataReceivedEventArgs e)
    {
      try
      {
        string str = Strings.Trim(this.SerialPortBioradD10.ReadExisting());
        this.SerialPortBioradD10.Write(this.HandleSerialMessage1(str));
        this.UpdateText(this.TextBoxLISRespond, "Send: ACK", false);
        if (Strings.Len(str) > 0)
        {
          this.SerialSignal = Conversions.ToString(Strings.AscW(Strings.Right(str, 1)));
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.SerialSignal, "2", false) == 0)
            this.BufferData = this.BufferData;
          else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.SerialSignal, "4", false) == 0)
          {
            this.AnalyzeBufferDataBioradD10(this.BufferData.Trim());
            this.BufferData = "";
          }
          else
            this.BufferData = this.BufferData + str;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.UpdateText(this.TextBoxLISData, "SerialPort: " + ex.Message + "\r\n", true);
        ProjectData.ClearProjectError();
      }
    }

    private void SerialPortBioradVariant_DataReceived(object sender, SerialDataReceivedEventArgs e)
    {
      try
      {
        string str = Strings.Trim(this.SerialPortBioradVariant.ReadExisting());
        string text = this.HandleSerialMessage1(str);
        File.AppendAllText("C:\\Windows\\Temp\\MTechLISLogBioradVariant.txt", str);
        this.SerialPortBioradVariant.Write(text);
        this.UpdateText(this.TextBoxLISRespond, "Send: ACK", false);
        if (Strings.Len(str) > 0)
        {
          this.SerialSignal = Conversions.ToString(Strings.AscW(Strings.Right(str, 1)));
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.SerialSignal, "2", false) == 0)
            this.BufferData = this.BufferData;
          else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.SerialSignal, "4", false) == 0)
          {
            this.AnalyzeBufferDataBioradvariant(this.BufferData.Trim());
            this.BufferData = "";
          }
          else
            this.BufferData = this.BufferData + str;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.UpdateText(this.TextBoxLISData, "SerialPort: " + ex.Message + "\r\n", true);
        ProjectData.ClearProjectError();
      }
    }

    private void SerialPortCelltacChemi_DataReceived(object sender, SerialDataReceivedEventArgs e)
    {
      try
      {
        string str = Strings.Trim(this.SerialPortCelltacChemi.ReadExisting());
        this.SerialPortCelltacChemi.Write(this.HandleSerialMessage1(str));
        this.UpdateText(this.TextBoxLISRespond, "Send: ACK", false);
        if (Strings.Len(str) > 0)
        {
          this.SerialSignal = Conversions.ToString(Strings.AscW(Strings.Right(str, 1)));
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.SerialSignal, "2", false) == 0)
            this.BufferData = this.BufferData;
          else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.SerialSignal, "4", false) == 0)
          {
            this.AnalyzeBufferDataCelltacChemi(this.BufferData.Trim());
            this.BufferData = "";
          }
          else
            this.BufferData = this.BufferData + str;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.UpdateText(this.TextBoxLISData, "SerialPort: " + ex.Message + "\r\n", true);
        ProjectData.ClearProjectError();
      }
    }

    private void SerialPortVIDAS_DataReceived(object sender, SerialDataReceivedEventArgs e)
    {
      try
      {
        string str = Strings.Trim(this.SerialPortVIDAS.ReadExisting());
        string text = this.HandleSerialMessage1(str);
        File.AppendAllText("C:\\Windows\\Temp\\MTechLISLogVIDAS.txt", str);
        this.SerialPortVIDAS.Write(text);
        this.UpdateText(this.TextBoxLISRespond, "Send: ACK", false);
        if (Strings.Len(str) > 0)
        {
          this.SerialSignal = Conversions.ToString(Strings.AscW(Strings.Right(str, 1)));
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.SerialSignal, "2", false) == 0)
            this.BufferData = this.BufferData;
          else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.SerialSignal, "4", false) == 0)
          {
            this.AnalyzeBufferDataVIDAS(this.BufferData.Trim());
            this.BufferData = "";
          }
          else
            this.BufferData = this.BufferData + str;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.UpdateText(this.TextBoxLISData, "SerialPort: " + ex.Message + "\r\n", true);
        ProjectData.ClearProjectError();
      }
    }

    private void SerialPortImmulite2000_DataReceived(object sender, SerialDataReceivedEventArgs e)
    {
      try
      {
        string data = Strings.Trim(this.SerialPortImmulite2000.ReadExisting());
        string text = this.HandleSerialMessage1(data);
        this.BufferData = this.BufferData + data;
        this.SerialPortImmulite2000.Write(text);
        this.AnalyzeBufferDataImmulite2000(this.BufferData.Trim());
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.UpdateText(this.TextBoxLISData, "SerialPort: " + ex.Message + "\r\n", true);
        ProjectData.ClearProjectError();
      }
    }

    private void SerialPortSiemensDimension_DataReceived(object sender, SerialDataReceivedEventArgs e)
    {
      try
      {
        Thread.Sleep(200);
        string data = Strings.Trim(this.SerialPortSiemensDimension.ReadExisting());
        string text = this.HandleSerialMessage1(data);
        this.BufferData = this.BufferData + data;
        this.SerialPortSiemensDimension.Write(text);
        this.AnalyzeBufferDataSiemensDimension(this.BufferData);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.UpdateText(this.TextBoxLISData, "SerialPort: " + ex.Message + "\r\n", true);
        ProjectData.ClearProjectError();
      }
    }

    private void LISSerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
    {
      try
      {
        string str = Strings.Trim(this.LISSerialPort.ReadExisting());
        this.LISSerialPort.Write(this.HandleSerialMessage1(str));
        this.UpdateText(this.TextBoxLISRespond, "Send: ACK", false);
        if (Strings.Len(str) > 0)
        {
          this.SerialSignal = Conversions.ToString(Strings.AscW(Strings.Right(str, 1)));
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.SerialSignal, "2", false) == 0)
            this.BufferData = this.BufferData;
          else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.SerialSignal, "4", false) == 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.ComboBoxTestFileMachineName.Text, "ADAMS A1c HA", false) == 0)
              this.AnalyzeBufferDataADAMSA1cHA(this.BufferData.Trim());
            this.BufferData = "";
          }
          else
            this.BufferData = this.BufferData + str;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.UpdateText(this.TextBoxLISData, "SerialPort: " + ex.Message + "\r\n", true);
        ProjectData.ClearProjectError();
      }
    }

    private void AnalyzeBufferDataADAMSA1cHA(string QBuffer)
    {
      this.dtLISResult.Rows.Clear();
      try
      {
        string str1 = QBuffer;
        char[] chArray1 = new char[1];
        int index1 = 0;
        int num1 = 13;
        chArray1[index1] = (char) num1;
        string[] strArray1 = str1.Split(chArray1);
        int num2 = checked (Information.UBound((Array) strArray1, 1) - 1);
        int index2 = 0;
        while (index2 <= num2)
        {
          string str2 = strArray1[index2];
          char[] chArray2 = new char[1];
          int index3 = 0;
          int num3 = 124;
          chArray2[index3] = (char) num3;
          string Left1 = Strings.Right(str2.Split(chArray2)[0], 1);
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left1, "O", false) == 0)
          {
            PMS_DataImport pmsDataImport1 = this;
            string str3 = strArray1[index2];
            char[] chArray3 = new char[1];
            int index4 = 0;
            int num4 = 124;
            chArray3[index4] = (char) num4;
            string str4 = str3.Split(chArray3)[2];
            char[] chArray4 = new char[1];
            int index5 = 0;
            int num5 = 94;
            chArray4[index5] = (char) num5;
            string str5 = Strings.Mid(str4.Split(chArray4)[0].Trim(), 1, 8);
            pmsDataImport1.TrackNumber = str5;
            this.LISTrackNumber = this.TrackNumber;
            PMS_DataImport pmsDataImport2 = this;
            string str6 = strArray1[index2];
            char[] chArray5 = new char[1];
            int index6 = 0;
            int num6 = 124;
            chArray5[index6] = (char) num6;
            string str7 = str6.Split(chArray5)[2];
            char[] chArray6 = new char[1];
            int index7 = 0;
            int num7 = 94;
            chArray6[index7] = (char) num7;
            string str8 = Strings.Mid(str7.Split(chArray6)[0].Trim(), 9);
            pmsDataImport2.SampleID = str8;
            PMS_DataImport pmsDataImport3 = this;
            string str9 = strArray1[index2];
            char[] chArray7 = new char[1];
            int index8 = 0;
            int num8 = 124;
            chArray7[index8] = (char) num8;
            string str10 = str9.Split(chArray7)[2];
            char[] chArray8 = new char[1];
            int index9 = 0;
            int num9 = 94;
            chArray8[index9] = (char) num9;
            string str11 = str10.Split(chArray8)[0].Trim();
            pmsDataImport3.PatientID = str11;
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.LISBarcode8Bit, "1", false) == 0)
            {
              this.SampleID = Strings.Right(this.TrackNumber.Trim(), 1);
              this.TrackNumber = Strings.Mid(DateTime.Now.ToString("yy"), 1, 1) + Strings.Left(this.TrackNumber.Trim(), 7);
            }
            else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.LISBarcode8Bit, "0", false) == 0)
            {
              PMS_DataImport pmsDataImport4 = this;
              string str12 = strArray1[index2];
              char[] chArray9 = new char[1];
              int index10 = 0;
              int num10 = 124;
              chArray9[index10] = (char) num10;
              string str13 = str12.Split(chArray9)[2];
              char[] chArray10 = new char[1];
              int index11 = 0;
              int num11 = 94;
              chArray10[index11] = (char) num11;
              string str14 = Strings.Mid(str13.Split(chArray10)[0].Trim(), 3, 8);
              pmsDataImport4.TrackNumber = str14;
              PMS_DataImport pmsDataImport5 = this;
              string str15 = strArray1[index2];
              char[] chArray11 = new char[1];
              int index12 = 0;
              int num12 = 124;
              chArray11[index12] = (char) num12;
              string str16 = str15.Split(chArray11)[2];
              char[] chArray12 = new char[1];
              int index13 = 0;
              int num13 = 94;
              chArray12[index13] = (char) num13;
              string str17 = Strings.Mid(str16.Split(chArray12)[0].Trim(), 1, 2);
              pmsDataImport5.SampleID = str17;
              this.LISTrackNumber = this.SampleID + this.TrackNumber;
            }
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left1, "R", false) == 0)
          {
            string str3 = strArray1[index2];
            char[] chArray3 = new char[1];
            int index4 = 0;
            int num4 = 124;
            chArray3[index4] = (char) num4;
            string str4 = str3.Split(chArray3)[2];
            char[] chArray4 = new char[1];
            int index5 = 0;
            int num5 = 94;
            chArray4[index5] = (char) num5;
            if ((uint) Strings.InStr(str4.Split(chArray4)[3], "Value", CompareMethod.Binary) > 0U)
            {
              PMS_DataImport pmsDataImport1 = this;
              string str5 = strArray1[index2];
              char[] chArray5 = new char[1];
              int index6 = 0;
              int num6 = 124;
              chArray5[index6] = (char) num6;
              string str6 = str5.Split(chArray5)[2];
              char[] chArray6 = new char[1];
              int index7 = 0;
              int num7 = 94;
              chArray6[index7] = (char) num7;
              string str7 = str6.Split(chArray6)[3].Replace("Value", "");
              pmsDataImport1.TestName = str7;
              this.LISTestCode = this.TestName;
              string str8 = strArray1[index2];
              char[] chArray7 = new char[1];
              int index8 = 0;
              int num8 = 124;
              chArray7[index8] = (char) num8;
              string Left2 = str8.Split(chArray7)[3];
              if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left2, "", false) > 0U)
              {
                PMS_DataImport pmsDataImport2 = this;
                TextBox textBoxLisData = this.TextBoxLISData;
                string[] strArray2 = new string[7];
                int index9 = 0;
                string str9 = "Track:";
                strArray2[index9] = str9;
                int index10 = 1;
                string str10 = this.TrackNumber;
                strArray2[index10] = str10;
                int index11 = 2;
                string str11 = " ";
                strArray2[index11] = str11;
                int index12 = 3;
                string str12 = this.TestName;
                strArray2[index12] = str12;
                int index13 = 4;
                string str13 = " : ";
                strArray2[index13] = str13;
                int index14 = 5;
                string str14 = Left2;
                strArray2[index14] = str14;
                int index15 = 6;
                string str15 = "\r\n";
                strArray2[index15] = str15;
                string txt = string.Concat(strArray2);
                int num9 = 1;
                pmsDataImport2.UpdateText(textBoxLisData, txt, num9 != 0);
              }
              DataRow[] dataRowArray = RegisterMicrosoftVisualStudio.ds.Tables["LISTestCodeList"].Select("Test_Name='" + this.TestName + "'");
              if (dataRowArray != null)
              {
                int upperBound = dataRowArray.GetUpperBound(0);
                int index9 = 0;
                while (index9 <= upperBound)
                {
                  this.TestCode = Conversions.ToString(dataRowArray[index9]["Test_Code"]);
                  if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.TestCode, "", false) > 0U & (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left2, "", false) > 0U && !this.ExistsDataTableSameRecord(this.TrackNumber, this.TestCode))
                  {
                    DataRowCollection rows = this.dtLISResult.Rows;
                    object[] objArray = new object[8];
                    int index10 = 0;
                    string str9 = this.PatientID;
                    objArray[index10] = (object) str9;
                    int index11 = 1;
                    string str10 = this.TrackNumber;
                    objArray[index11] = (object) str10;
                    int index12 = 2;
                    string str11 = this.TestCode;
                    objArray[index12] = (object) str11;
                    int index13 = 3;
                    string str12 = this.TestName;
                    objArray[index13] = (object) str12;
                    int index14 = 4;
                    string str13 = Left2;
                    objArray[index14] = (object) str13;
                    int index15 = 5;
                    string str14 = this.LISTestCode;
                    objArray[index15] = (object) str14;
                    int index16 = 6;
                    string str15 = "";
                    objArray[index16] = (object) str15;
                    int index17 = 7;
                    // ISSUE: variable of a boxed type
                    __Boxed<DateTime> local = (System.ValueType) this.LISMachineTestTime;
                    objArray[index17] = (object) local;
                    rows.Add(objArray);
                    if (this.dtLISResult.Rows.Count > 900)
                      this.SaveLISImportedData();
                  }
                  checked { ++index9; }
                }
              }
            }
            this.SaveLISImportedData();
          }
          checked { ++index2; }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.UpdateText(this.TextBoxLISData, "HandleData: " + ex.Message + "\r\n", true);
        ProjectData.ClearProjectError();
      }
    }

    private void AnalyzeBufferDataSysmex(string QBuffer)
    {
      this.dtLISResult.Rows.Clear();
      try
      {
        string str1 = QBuffer;
        char[] chArray1 = new char[1];
        int index1 = 0;
        int num1 = 13;
        chArray1[index1] = (char) num1;
        string[] strArray1 = str1.Split(chArray1);
        int num2 = checked (Information.UBound((Array) strArray1, 1) - 1);
        int index2 = 0;
        while (index2 <= num2)
        {
          string str2 = strArray1[index2];
          char[] chArray2 = new char[1];
          int index3 = 0;
          int num3 = 124;
          chArray2[index3] = (char) num3;
          string Left1 = Strings.Right(str2.Split(chArray2)[0].Trim(), 1);
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left1, "O", false) == 0)
          {
            PMS_DataImport pmsDataImport1 = this;
            string str3 = strArray1[index2];
            char[] chArray3 = new char[1];
            int index4 = 0;
            int num4 = 124;
            chArray3[index4] = (char) num4;
            string str4 = str3.Split(chArray3)[3];
            char[] chArray4 = new char[1];
            int index5 = 0;
            int num5 = 94;
            chArray4[index5] = (char) num5;
            string str5 = Strings.Mid(str4.Split(chArray4)[2].Trim(), 1, 8);
            pmsDataImport1.TrackNumber = str5;
            this.LISTrackNumber = this.TrackNumber;
            PMS_DataImport pmsDataImport2 = this;
            string str6 = strArray1[index2];
            char[] chArray5 = new char[1];
            int index6 = 0;
            int num6 = 124;
            chArray5[index6] = (char) num6;
            string str7 = str6.Split(chArray5)[3];
            char[] chArray6 = new char[1];
            int index7 = 0;
            int num7 = 94;
            chArray6[index7] = (char) num7;
            string str8 = Strings.Mid(str7.Split(chArray6)[2].Trim(), 9);
            pmsDataImport2.SampleID = str8;
            PMS_DataImport pmsDataImport3 = this;
            string str9 = strArray1[index2];
            char[] chArray7 = new char[1];
            int index8 = 0;
            int num8 = 124;
            chArray7[index8] = (char) num8;
            string str10 = str9.Split(chArray7)[3];
            char[] chArray8 = new char[1];
            int index9 = 0;
            int num9 = 94;
            chArray8[index9] = (char) num9;
            string str11 = str10.Split(chArray8)[2];
            pmsDataImport3.PatientID = str11;
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.LISBarcode8Bit, "1", false) == 0)
            {
              this.SampleID = Strings.Right(this.TrackNumber.Trim(), 1);
              this.TrackNumber = Strings.Mid(DateTime.Now.ToString("yy"), 1, 1) + Strings.Left(this.TrackNumber.Trim(), 7);
            }
            else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.LISBarcode8Bit, "0", false) == 0)
            {
              PMS_DataImport pmsDataImport4 = this;
              string str12 = strArray1[index2];
              char[] chArray9 = new char[1];
              int index10 = 0;
              int num10 = 124;
              chArray9[index10] = (char) num10;
              string str13 = str12.Split(chArray9)[3];
              char[] chArray10 = new char[1];
              int index11 = 0;
              int num11 = 94;
              chArray10[index11] = (char) num11;
              string str14 = Strings.Mid(str13.Split(chArray10)[2].Trim(), 3, 8);
              pmsDataImport4.TrackNumber = str14;
              PMS_DataImport pmsDataImport5 = this;
              string str15 = strArray1[index2];
              char[] chArray11 = new char[1];
              int index12 = 0;
              int num12 = 124;
              chArray11[index12] = (char) num12;
              string str16 = str15.Split(chArray11)[3];
              char[] chArray12 = new char[1];
              int index13 = 0;
              int num13 = 94;
              chArray12[index13] = (char) num13;
              string str17 = Strings.Mid(str16.Split(chArray12)[2].Trim(), 1, 2);
              pmsDataImport5.SampleID = str17;
              this.LISTrackNumber = this.SampleID + this.TrackNumber;
            }
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left1, "Q", false) == 0)
          {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append('\x0005');
            if (this.SerialPortSysmex.IsOpen)
              this.SerialPortSysmex.Write(stringBuilder.ToString());
            this.UpdateText(this.TextBoxLISRespond, "\r\nSend ENQ\r\n", true);
            this.OrderQuery = strArray1[index2];
            this.TimeCounter = 0;
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left1, "R", false) == 0)
          {
            string str3 = strArray1[index2];
            char[] chArray3 = new char[1];
            int index4 = 0;
            int num4 = 2;
            chArray3[index4] = (char) num4;
            string[] strArray2 = str3.Split(chArray3);
            int num5 = Information.UBound((Array) strArray2, 1);
            int index5 = 1;
            while (index5 <= num5)
            {
              if (Strings.Len(strArray2[index5]) > 10)
              {
                PMS_DataImport pmsDataImport1 = this;
                string str4 = strArray2[index5];
                char[] chArray4 = new char[1];
                int index6 = 0;
                int num6 = 124;
                chArray4[index6] = (char) num6;
                string str5 = str4.Split(chArray4)[2];
                char[] chArray5 = new char[1];
                int index7 = 0;
                int num7 = 94;
                chArray5[index7] = (char) num7;
                string str6 = str5.Split(chArray5)[4].Trim();
                pmsDataImport1.TestName = str6;
                this.LISMachineTestTime = DateAndTime.Now;
                PMS_DataImport pmsDataImport2 = this;
                string str7 = "000";
                string str8 = strArray2[index5];
                char[] chArray6 = new char[1];
                int index8 = 0;
                int num8 = 124;
                chArray6[index8] = (char) num8;
                string str9 = str8.Split(chArray6)[2];
                char[] chArray7 = new char[1];
                int index9 = 0;
                int num9 = 94;
                chArray7[index9] = (char) num9;
                string str10 = str9.Split(chArray7)[3].Trim();
                string str11 = Strings.Right(str7 + str10, 3);
                pmsDataImport2.LISTestCode = str11;
                string str12 = strArray2[index5];
                char[] chArray8 = new char[1];
                int index10 = 0;
                int num10 = 124;
                chArray8[index10] = (char) num10;
                string Left2 = str12.Split(chArray8)[3].Trim();
                if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left2, "", false) > 0U)
                {
                  PMS_DataImport pmsDataImport3 = this;
                  TextBox textBoxLisData = this.TextBoxLISData;
                  string[] strArray3 = new string[7];
                  int index11 = 0;
                  string str13 = "Track:";
                  strArray3[index11] = str13;
                  int index12 = 1;
                  string str14 = this.TrackNumber;
                  strArray3[index12] = str14;
                  int index13 = 2;
                  string str15 = " ";
                  strArray3[index13] = str15;
                  int index14 = 3;
                  string str16 = this.TestName;
                  strArray3[index14] = str16;
                  int index15 = 4;
                  string str17 = " : ";
                  strArray3[index15] = str17;
                  int index16 = 5;
                  string str18 = Left2;
                  strArray3[index16] = str18;
                  int index17 = 6;
                  string str19 = "\r\n";
                  strArray3[index17] = str19;
                  string txt = string.Concat(strArray3);
                  int num11 = 1;
                  pmsDataImport3.UpdateText(textBoxLisData, txt, num11 != 0);
                }
                DataRow[] dataRowArray = (DataRow[]) Interaction.IIf(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.SampleID, "02", false) == 0, (object) RegisterMicrosoftVisualStudio.ds.Tables["LISTestCodeList"].Select("Test_Name='" + this.TestName + "' And TEST_NAME_SEQUENCE=2"), (object) RegisterMicrosoftVisualStudio.ds.Tables["LISTestCodeList"].Select("Test_Name='" + this.TestName + "' AND TEST_NAME_SEQUENCE=1"));
                if (dataRowArray != null)
                {
                  int upperBound = dataRowArray.GetUpperBound(0);
                  int index11 = 0;
                  while (index11 <= upperBound)
                  {
                    this.TestCode = Conversions.ToString(dataRowArray[index11]["Test_Code"]);
                    if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.TestCode, "", false) > 0U & (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left2, "", false) > 0U && !this.ExistsDataTableSameRecord(this.TrackNumber, this.TestCode))
                    {
                      DataRowCollection rows = this.dtLISResult.Rows;
                      object[] objArray = new object[8];
                      int index12 = 0;
                      string str13 = this.PatientID;
                      objArray[index12] = (object) str13;
                      int index13 = 1;
                      string str14 = this.TrackNumber;
                      objArray[index13] = (object) str14;
                      int index14 = 2;
                      string str15 = this.TestCode;
                      objArray[index14] = (object) str15;
                      int index15 = 3;
                      string str16 = this.TestName;
                      objArray[index15] = (object) str16;
                      int index16 = 4;
                      string str17 = Left2;
                      objArray[index16] = (object) str17;
                      int index17 = 5;
                      string str18 = this.LISTestCode;
                      objArray[index17] = (object) str18;
                      int index18 = 6;
                      string str19 = "";
                      objArray[index18] = (object) str19;
                      int index19 = 7;
                      // ISSUE: variable of a boxed type
                      __Boxed<DateTime> local = (System.ValueType) this.LISMachineTestTime;
                      objArray[index19] = (object) local;
                      rows.Add(objArray);
                      if (this.dtLISResult.Rows.Count > 900)
                        this.SaveLISImportedData();
                    }
                    checked { ++index11; }
                  }
                }
                this.SaveLISImportedData();
              }
              checked { ++index5; }
            }
          }
          checked { ++index2; }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.UpdateText(this.TextBoxLISData, "HandleData: " + ex.Message + "\r\n", true);
        ProjectData.ClearProjectError();
      }
    }

    private void AnalyzeBufferDataArchitect(string QBuffer)
    {
      this.dtLISResult.Rows.Clear();
      try
      {
        string str1 = QBuffer;
        char[] chArray1 = new char[1];
        int index1 = 0;
        int num1 = 13;
        chArray1[index1] = (char) num1;
        string[] strArray1 = str1.Split(chArray1);
        int num2 = checked (Information.UBound((Array) strArray1, 1) - 1);
        int index2 = 0;
        while (index2 <= num2)
        {
          string str2 = strArray1[index2];
          char[] chArray2 = new char[1];
          int index3 = 0;
          int num3 = 124;
          chArray2[index3] = (char) num3;
          string Left1 = Strings.Right(str2.Split(chArray2)[0].Trim(), 1);
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left1, "O", false) == 0)
          {
            PMS_DataImport pmsDataImport1 = this;
            string str3 = strArray1[index2];
            char[] chArray3 = new char[1];
            int index4 = 0;
            int num4 = 124;
            chArray3[index4] = (char) num4;
            string str4 = str3.Split(chArray3)[2];
            char[] chArray4 = new char[1];
            int index5 = 0;
            int num5 = 94;
            chArray4[index5] = (char) num5;
            string str5 = Strings.Mid(str4.Split(chArray4)[0], 1, 8);
            pmsDataImport1.TrackNumber = str5;
            this.LISTrackNumber = this.TrackNumber;
            PMS_DataImport pmsDataImport2 = this;
            string str6 = strArray1[index2];
            char[] chArray5 = new char[1];
            int index6 = 0;
            int num6 = 124;
            chArray5[index6] = (char) num6;
            string str7 = str6.Split(chArray5)[2];
            char[] chArray6 = new char[1];
            int index7 = 0;
            int num7 = 94;
            chArray6[index7] = (char) num7;
            string str8 = Strings.Mid(str7.Split(chArray6)[0], 9);
            pmsDataImport2.SampleID = str8;
            PMS_DataImport pmsDataImport3 = this;
            string str9 = strArray1[index2];
            char[] chArray7 = new char[1];
            int index8 = 0;
            int num8 = 124;
            chArray7[index8] = (char) num8;
            string str10 = str9.Split(chArray7)[2];
            char[] chArray8 = new char[1];
            int index9 = 0;
            int num9 = 94;
            chArray8[index9] = (char) num9;
            string str11 = str10.Split(chArray8)[0];
            pmsDataImport3.PatientID = str11;
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.LISBarcode8Bit, "1", false) == 0)
            {
              this.SampleID = Strings.Right(this.TrackNumber.Trim(), 1);
              this.TrackNumber = Strings.Mid(DateTime.Now.ToString("yy"), 1, 1) + Strings.Left(this.TrackNumber.Trim(), 7);
            }
            else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.LISBarcode8Bit, "0", false) == 0)
            {
              PMS_DataImport pmsDataImport4 = this;
              string str12 = strArray1[index2];
              char[] chArray9 = new char[1];
              int index10 = 0;
              int num10 = 124;
              chArray9[index10] = (char) num10;
              string str13 = str12.Split(chArray9)[2];
              char[] chArray10 = new char[1];
              int index11 = 0;
              int num11 = 94;
              chArray10[index11] = (char) num11;
              string str14 = Strings.Mid(str13.Split(chArray10)[0], 3, 8);
              pmsDataImport4.TrackNumber = str14;
              PMS_DataImport pmsDataImport5 = this;
              string str15 = strArray1[index2];
              char[] chArray11 = new char[1];
              int index12 = 0;
              int num12 = 124;
              chArray11[index12] = (char) num12;
              string str16 = str15.Split(chArray11)[2];
              char[] chArray12 = new char[1];
              int index13 = 0;
              int num13 = 94;
              chArray12[index13] = (char) num13;
              string str17 = Strings.Mid(str16.Split(chArray12)[0], 1, 2);
              pmsDataImport5.SampleID = str17;
              this.LISTrackNumber = this.SampleID + this.TrackNumber;
            }
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left1, "Q", false) == 0)
          {
            PMS_DataImport pmsDataImport1 = this;
            string str3 = strArray1[index2];
            char[] chArray3 = new char[1];
            int index4 = 0;
            int num4 = 124;
            chArray3[index4] = (char) num4;
            string str4 = str3.Split(chArray3)[2];
            char[] chArray4 = new char[1];
            int index5 = 0;
            int num5 = 94;
            chArray4[index5] = (char) num5;
            string str5 = Strings.Mid(str4.Split(chArray4)[1], 1, 8);
            pmsDataImport1.TrackNumber = str5;
            this.LISTrackNumber = this.TrackNumber;
            PMS_DataImport pmsDataImport2 = this;
            string str6 = strArray1[index2];
            char[] chArray5 = new char[1];
            int index6 = 0;
            int num6 = 124;
            chArray5[index6] = (char) num6;
            string str7 = str6.Split(chArray5)[2];
            char[] chArray6 = new char[1];
            int index7 = 0;
            int num7 = 94;
            chArray6[index7] = (char) num7;
            string str8 = Strings.Mid(str7.Split(chArray6)[1], 9);
            pmsDataImport2.SampleID = str8;
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.LISBarcode8Bit, "1", false) == 0)
            {
              this.SampleID = Strings.Right(this.TrackNumber.Trim(), 1);
              this.TrackNumber = Strings.Mid(DateTime.Now.ToString("yy"), 1, 1) + Strings.Left(this.TrackNumber.Trim(), 7);
            }
            else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.LISBarcode8Bit, "0", false) == 0)
            {
              PMS_DataImport pmsDataImport3 = this;
              string str9 = strArray1[index2];
              char[] chArray7 = new char[1];
              int index8 = 0;
              int num8 = 124;
              chArray7[index8] = (char) num8;
              string str10 = str9.Split(chArray7)[2];
              char[] chArray8 = new char[1];
              int index9 = 0;
              int num9 = 94;
              chArray8[index9] = (char) num9;
              string str11 = Strings.Mid(str10.Split(chArray8)[1], 3, 8);
              pmsDataImport3.TrackNumber = str11;
              PMS_DataImport pmsDataImport4 = this;
              string str12 = strArray1[index2];
              char[] chArray9 = new char[1];
              int index10 = 0;
              int num10 = 124;
              chArray9[index10] = (char) num10;
              string str13 = str12.Split(chArray9)[2];
              char[] chArray10 = new char[1];
              int index11 = 0;
              int num11 = 94;
              chArray10[index11] = (char) num11;
              string str14 = Strings.Mid(str13.Split(chArray10)[1], 1, 2);
              pmsDataImport4.SampleID = str14;
              this.LISTrackNumber = this.SampleID + this.TrackNumber;
            }
            this.AssayType = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.SampleID, "03", false) != 0 ? (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.SampleID, "04", false) != 0 ? "Serum" : "CSF") : "Urine";
            this.UpdateText(this.TextBoxTrackForTestOrder, this.TrackNumber, false);
            string[] strArray2 = new string[11];
            int index12 = 0;
            string str15 = "exec spTestListOnServiceTrackLISWithPatient @TrackNumber='";
            strArray2[index12] = str15;
            int index13 = 1;
            string str16 = this.TrackNumber;
            strArray2[index13] = str16;
            int index14 = 2;
            string str17 = "', @MachineName='";
            strArray2[index14] = str17;
            int index15 = 3;
            string str18 = this.MachineName;
            strArray2[index15] = str18;
            int index16 = 4;
            string str19 = "', @ExcludeExistingDBTest='";
            strArray2[index16] = str19;
            int index17 = 5;
            string str20 = Conversions.ToString(this.CheckBoxCheckTestInDBResult.Checked);
            strArray2[index17] = str20;
            int index18 = 6;
            string str21 = "', @SampleID='";
            strArray2[index18] = str21;
            int index19 = 7;
            string str22 = this.SampleID;
            strArray2[index19] = str22;
            int index20 = 8;
            string str23 = "', @AssayType='";
            strArray2[index20] = str23;
            int index21 = 9;
            string str24 = this.AssayType;
            strArray2[index21] = str24;
            int index22 = 10;
            string str25 = "'";
            strArray2[index22] = str25;
            RegisterMicrosoftVisualStudio.SqlText = string.Concat(strArray2);
            RegisterMicrosoftVisualStudio.da.SelectCommand = new OleDbCommand(RegisterMicrosoftVisualStudio.SqlText, RegisterMicrosoftVisualStudio.Conn);
            if (RegisterMicrosoftVisualStudio.ds.Tables["PatientTestList"] != null)
              RegisterMicrosoftVisualStudio.ds.Tables["PatientTestList"].Clear();
            ((DbDataAdapter) RegisterMicrosoftVisualStudio.da).Fill(RegisterMicrosoftVisualStudio.ds, "PatientTestList");
            DataTable dataTable = RegisterMicrosoftVisualStudio.ds.Tables["PatientTestList"];
            if (dataTable.Rows.Count < 1)
              break;
            PMS_DataImport pmsDataImport5 = this;
            object Instance1 = dataTable.Rows[0]["PatientName"];
            // ISSUE: variable of the null type
            __Null local1 = null;
            string MemberName = "Split";
            object[] Arguments1 = new object[1];
            int index23 = 0;
            string str26 = " ";
            Arguments1[index23] = (object) str26;
            // ISSUE: variable of the null type
            __Null local2 = null;
            // ISSUE: variable of the null type
            __Null local3 = null;
            // ISSUE: variable of the null type
            __Null local4 = null;
            object Instance2 = NewLateBinding.LateGet(Instance1, (System.Type) local1, MemberName, Arguments1, (string[]) local2, (System.Type[]) local3, (bool[]) local4);
            object[] Arguments2 = new object[1];
            int index24 = 0;
            // ISSUE: variable of a boxed type
            __Boxed<int> local5 = (System.ValueType) 0;
            Arguments2[index24] = (object) local5;
            // ISSUE: variable of the null type
            __Null local6 = null;
            string str27 = Strings.Mid(Conversions.ToString(NewLateBinding.LateIndexGet(Instance2, Arguments2, (string[]) local6)), 1, 20);
            pmsDataImport5.PatientName = str27;
            this.PatientBirthdate = Conversions.ToString(dataTable.Rows[0]["PatientBirthdate"]);
            this.PatientSex = Conversions.ToString(dataTable.Rows[0]["PatientSex"]);
            string str28 = "";
            int num12 = checked (dataTable.Rows.Count - 1);
            int index25 = 0;
            while (index25 <= num12)
            {
              str28 = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) (str28 + "\\^^^"), dataTable.Rows[index25]["TEST_CODE"]));
              checked { ++index25; }
            }
            StringBuilder stringBuilder1 = new StringBuilder();
            stringBuilder1.Append('\x0005');
            if (this.SerialPortArchitect.IsOpen)
              this.SerialPortArchitect.Write(stringBuilder1.ToString());
            this.UpdateText(this.TextBoxLISRespond, "\r\nSend ENQ\r\n", true);
            int FrameNumber = 1;
            int num13 = 0;
            do
            {
              StringBuilder stringBuilder2 = new StringBuilder();
              stringBuilder2.Append('\x0002');
              stringBuilder2.Append(FrameNumber);
              string OrderMsg;
              if (num13 == 0)
                OrderMsg = "H|\\^&||||||||||P|1\r";
              else if (num13 == 1)
              {
                string[] strArray3 = new string[15];
                int index8 = 0;
                string str9 = "P|1|";
                strArray3[index8] = str9;
                int index9 = 1;
                string str10 = this.TrackNumber;
                strArray3[index9] = str10;
                int index10 = 2;
                string str11 = "|";
                strArray3[index10] = str11;
                int index11 = 3;
                string str12 = this.TrackNumber;
                strArray3[index11] = str12;
                int index26 = 4;
                string str13 = "|";
                strArray3[index26] = str13;
                int index27 = 5;
                string str14 = this.TrackNumber;
                strArray3[index27] = str14;
                int index28 = 6;
                string str29 = "|";
                strArray3[index28] = str29;
                int index29 = 7;
                string str30 = this.PatientName;
                strArray3[index29] = str30;
                int index30 = 8;
                string str31 = "||";
                strArray3[index30] = str31;
                int index31 = 9;
                string str32 = this.PatientBirthdate;
                strArray3[index31] = str32;
                int index32 = 10;
                string str33 = "|";
                strArray3[index32] = str33;
                int index33 = 11;
                string str34 = this.PatientSex;
                strArray3[index33] = str34;
                int index34 = 12;
                string str35 = "||";
                strArray3[index34] = str35;
                int index35 = 13;
                string str36 = this.TrackNumber;
                strArray3[index35] = str36;
                int index36 = 14;
                string str37 = "||||||||||||||||\r";
                strArray3[index36] = str37;
                OrderMsg = string.Concat(strArray3);
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str28, "", false) == 0)
                  OrderMsg = "Q|1|^" + this.LISTrackNumber + "||^^^ALL||||||||X\r";
              }
              else if (num13 == 2)
              {
                string[] strArray3 = new string[9];
                int index8 = 0;
                string str9 = "O|1|";
                strArray3[index8] = str9;
                int index9 = 1;
                string str10 = this.LISTrackNumber;
                strArray3[index9] = str10;
                int index10 = 2;
                string str11 = "||";
                strArray3[index10] = str11;
                int index11 = 3;
                string str12 = Strings.Mid(str28, 2);
                strArray3[index11] = str12;
                int index26 = 4;
                string str13 = "|S||||||";
                strArray3[index26] = str13;
                int index27 = 5;
                string str14 = this.OrderType;
                strArray3[index27] = str14;
                int index28 = 6;
                string str29 = "||||";
                strArray3[index28] = str29;
                int index29 = 7;
                string str30 = this.AssayType;
                strArray3[index29] = str30;
                int index30 = 8;
                string str31 = "||||||||||Q|\r";
                strArray3[index30] = str31;
                OrderMsg = string.Concat(strArray3);
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str28, "", false) == 0)
                  OrderMsg = "L|1\r";
              }
              else
              {
                OrderMsg = "L|1|F\r";
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str28, "", false) == 0)
                  OrderMsg = "";
              }
              stringBuilder2.Append(OrderMsg);
              stringBuilder2.Append('\x0003');
              string str38 = this.CheckSumArchitectMachinSerialData(FrameNumber, OrderMsg, 0);
              stringBuilder2.Append(Strings.Left(str38, 1));
              stringBuilder2.Append(Strings.Right(str38, 1));
              stringBuilder2.Append('\r');
              stringBuilder2.Append('\n');
              checked { ++FrameNumber; }
              if (FrameNumber == 8)
                FrameNumber = 0;
              if (this.SerialPortArchitect.IsOpen)
                this.SerialPortArchitect.Write(stringBuilder2.ToString());
              checked { ++num13; }
            }
            while (num13 <= 3);
            StringBuilder stringBuilder3 = new StringBuilder();
            stringBuilder3.Append('\x0004');
            if (this.SerialPortArchitect.IsOpen)
              this.SerialPortArchitect.Write(stringBuilder3.ToString());
            this.UpdateText(this.TextBoxLISRespond, "\r\nSend EOT\r\n", true);
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left1, "R", false) == 0)
          {
            string str3 = strArray1[index2];
            char[] chArray3 = new char[1];
            int index4 = 0;
            int num4 = 124;
            chArray3[index4] = (char) num4;
            string str4 = str3.Split(chArray3)[2];
            char[] chArray4 = new char[1];
            int index5 = 0;
            int num5 = 94;
            chArray4[index5] = (char) num5;
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str4.Split(chArray4)[10], "F", false) == 0)
            {
              PMS_DataImport pmsDataImport1 = this;
              string str5 = strArray1[index2];
              char[] chArray5 = new char[1];
              int index6 = 0;
              int num6 = 124;
              chArray5[index6] = (char) num6;
              string str6 = str5.Split(chArray5)[2];
              char[] chArray6 = new char[1];
              int index7 = 0;
              int num7 = 94;
              chArray6[index7] = (char) num7;
              string str7 = str6.Split(chArray6)[4];
              pmsDataImport1.TestName = str7;
              PMS_DataImport pmsDataImport2 = this;
              string str8 = strArray1[index2];
              char[] chArray7 = new char[1];
              int index8 = 0;
              int num8 = 124;
              chArray7[index8] = (char) num8;
              DateTime dateTime = DateTime.ParseExact(str8.Split(chArray7)[12], "yyyyMMddHHmmss", (IFormatProvider) null);
              pmsDataImport2.LISMachineTestTime = dateTime;
              PMS_DataImport pmsDataImport3 = this;
              string str9 = "000";
              string str10 = strArray1[index2];
              char[] chArray8 = new char[1];
              int index9 = 0;
              int num9 = 124;
              chArray8[index9] = (char) num9;
              string str11 = str10.Split(chArray8)[2];
              char[] chArray9 = new char[1];
              int index10 = 0;
              int num10 = 94;
              chArray9[index10] = (char) num10;
              string str12 = str11.Split(chArray9)[3];
              string str13 = Strings.Right(str9 + str12, 4);
              pmsDataImport3.LISTestCode = str13;
              string str14 = strArray1[index2];
              char[] chArray10 = new char[1];
              int index11 = 0;
              int num11 = 124;
              chArray10[index11] = (char) num11;
              string Left2 = str14.Split(chArray10)[3];
              if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left2, "", false) > 0U)
              {
                PMS_DataImport pmsDataImport4 = this;
                TextBox textBoxLisData = this.TextBoxLISData;
                string[] strArray2 = new string[7];
                int index12 = 0;
                string str15 = "Track:";
                strArray2[index12] = str15;
                int index13 = 1;
                string str16 = this.TrackNumber;
                strArray2[index13] = str16;
                int index14 = 2;
                string str17 = " ";
                strArray2[index14] = str17;
                int index15 = 3;
                string str18 = this.TestName;
                strArray2[index15] = str18;
                int index16 = 4;
                string str19 = " : ";
                strArray2[index16] = str19;
                int index17 = 5;
                string str20 = Left2;
                strArray2[index17] = str20;
                int index18 = 6;
                string str21 = "\r\n";
                strArray2[index18] = str21;
                string txt = string.Concat(strArray2);
                int num12 = 1;
                pmsDataImport4.UpdateText(textBoxLisData, txt, num12 != 0);
              }
              DataRow[] dataRowArray = (DataRow[]) Interaction.IIf(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.SampleID, "02", false) == 0, (object) RegisterMicrosoftVisualStudio.ds.Tables["LISTestCodeList"].Select("Test_Name='" + this.TestName + "' And TEST_NAME_SEQUENCE=2"), (object) RegisterMicrosoftVisualStudio.ds.Tables["LISTestCodeList"].Select("Test_Name='" + this.TestName + "' AND TEST_NAME_SEQUENCE=1"));
              if (dataRowArray != null)
              {
                int upperBound = dataRowArray.GetUpperBound(0);
                int index12 = 0;
                while (index12 <= upperBound)
                {
                  this.TestCode = Conversions.ToString(dataRowArray[index12]["Test_Code"]);
                  if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.TestCode, "", false) > 0U & (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left2, "", false) > 0U && !this.ExistsDataTableSameRecord(this.TrackNumber, this.TestCode))
                  {
                    DataRowCollection rows = this.dtLISResult.Rows;
                    object[] objArray = new object[8];
                    int index13 = 0;
                    string str15 = this.PatientID;
                    objArray[index13] = (object) str15;
                    int index14 = 1;
                    string str16 = this.TrackNumber;
                    objArray[index14] = (object) str16;
                    int index15 = 2;
                    string str17 = this.TestCode;
                    objArray[index15] = (object) str17;
                    int index16 = 3;
                    string str18 = this.TestName;
                    objArray[index16] = (object) str18;
                    int index17 = 4;
                    string str19 = Left2;
                    objArray[index17] = (object) str19;
                    int index18 = 5;
                    string str20 = this.LISTestCode;
                    objArray[index18] = (object) str20;
                    int index19 = 6;
                    string str21 = "";
                    objArray[index19] = (object) str21;
                    int index20 = 7;
                    // ISSUE: variable of a boxed type
                    __Boxed<DateTime> local = (System.ValueType) this.LISMachineTestTime;
                    objArray[index20] = (object) local;
                    rows.Add(objArray);
                    if (this.dtLISResult.Rows.Count > 900)
                      this.SaveLISImportedData();
                  }
                  checked { ++index12; }
                }
              }
            }
            this.SaveLISImportedData();
          }
          checked { ++index2; }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.UpdateText(this.TextBoxLISData, "HandleData: " + ex.Message + "\r\n", true);
        ProjectData.ClearProjectError();
      }
    }

    private void AnalyzeBufferDataCellDynRuby(string QBuffer)
    {
      this.dtLISResult.Rows.Clear();
      try
      {
        string str1 = QBuffer;
        char[] chArray1 = new char[1];
        int index1 = 0;
        int num1 = 13;
        chArray1[index1] = (char) num1;
        string[] strArray1 = str1.Split(chArray1);
        int num2 = checked (Information.UBound((Array) strArray1, 1) - 1);
        int index2 = 0;
        while (index2 <= num2)
        {
          string str2 = strArray1[index2];
          char[] chArray2 = new char[1];
          int index3 = 0;
          int num3 = 124;
          chArray2[index3] = (char) num3;
          string Left1 = Strings.Right(str2.Split(chArray2)[0], 1);
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left1, "O", false) == 0)
          {
            PMS_DataImport pmsDataImport1 = this;
            string str3 = strArray1[index2];
            char[] chArray3 = new char[1];
            int index4 = 0;
            int num4 = 124;
            chArray3[index4] = (char) num4;
            string str4 = str3.Split(chArray3)[2];
            char[] chArray4 = new char[1];
            int index5 = 0;
            int num5 = 94;
            chArray4[index5] = (char) num5;
            string str5 = Strings.Mid(str4.Split(chArray4)[0], 1, 8);
            pmsDataImport1.TrackNumber = str5;
            this.LISTrackNumber = this.TrackNumber;
            PMS_DataImport pmsDataImport2 = this;
            string str6 = strArray1[index2];
            char[] chArray5 = new char[1];
            int index6 = 0;
            int num6 = 124;
            chArray5[index6] = (char) num6;
            string str7 = str6.Split(chArray5)[2];
            char[] chArray6 = new char[1];
            int index7 = 0;
            int num7 = 94;
            chArray6[index7] = (char) num7;
            string str8 = Strings.Mid(str7.Split(chArray6)[0], 9);
            pmsDataImport2.SampleID = str8;
            PMS_DataImport pmsDataImport3 = this;
            string str9 = strArray1[index2];
            char[] chArray7 = new char[1];
            int index8 = 0;
            int num8 = 124;
            chArray7[index8] = (char) num8;
            string str10 = str9.Split(chArray7)[2];
            char[] chArray8 = new char[1];
            int index9 = 0;
            int num9 = 94;
            chArray8[index9] = (char) num9;
            string str11 = str10.Split(chArray8)[0];
            pmsDataImport3.PatientID = str11;
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.LISBarcode8Bit, "1", false) == 0)
            {
              this.SampleID = Strings.Right(this.TrackNumber.Trim(), 1);
              this.TrackNumber = Strings.Mid(DateTime.Now.ToString("yy"), 1, 1) + Strings.Left(this.TrackNumber.Trim(), 7);
            }
            else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.LISBarcode8Bit, "0", false) == 0)
            {
              PMS_DataImport pmsDataImport4 = this;
              string str12 = strArray1[index2];
              char[] chArray9 = new char[1];
              int index10 = 0;
              int num10 = 124;
              chArray9[index10] = (char) num10;
              string str13 = str12.Split(chArray9)[2];
              char[] chArray10 = new char[1];
              int index11 = 0;
              int num11 = 94;
              chArray10[index11] = (char) num11;
              string str14 = Strings.Mid(str13.Split(chArray10)[0], 3, 8);
              pmsDataImport4.TrackNumber = str14;
              PMS_DataImport pmsDataImport5 = this;
              string str15 = strArray1[index2];
              char[] chArray11 = new char[1];
              int index12 = 0;
              int num12 = 124;
              chArray11[index12] = (char) num12;
              string str16 = str15.Split(chArray11)[2];
              char[] chArray12 = new char[1];
              int index13 = 0;
              int num13 = 94;
              chArray12[index13] = (char) num13;
              string str17 = Strings.Mid(str16.Split(chArray12)[0], 1, 2);
              pmsDataImport5.SampleID = str17;
              this.LISTrackNumber = this.SampleID + this.TrackNumber;
            }
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left1, "Q", false) == 0)
          {
            PMS_DataImport pmsDataImport1 = this;
            string str3 = strArray1[index2];
            char[] chArray3 = new char[1];
            int index4 = 0;
            int num4 = 124;
            chArray3[index4] = (char) num4;
            string str4 = str3.Split(chArray3)[2];
            char[] chArray4 = new char[1];
            int index5 = 0;
            int num5 = 94;
            chArray4[index5] = (char) num5;
            string str5 = Strings.Mid(str4.Split(chArray4)[1], 1, 8);
            pmsDataImport1.TrackNumber = str5;
            this.LISTrackNumber = this.TrackNumber;
            PMS_DataImport pmsDataImport2 = this;
            string str6 = strArray1[index2];
            char[] chArray5 = new char[1];
            int index6 = 0;
            int num6 = 124;
            chArray5[index6] = (char) num6;
            string str7 = str6.Split(chArray5)[2];
            char[] chArray6 = new char[1];
            int index7 = 0;
            int num7 = 94;
            chArray6[index7] = (char) num7;
            string str8 = Strings.Mid(str7.Split(chArray6)[1], 9);
            pmsDataImport2.SampleID = str8;
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.LISBarcode8Bit, "1", false) == 0)
            {
              this.SampleID = Strings.Right(this.TrackNumber.Trim(), 1);
              this.TrackNumber = Strings.Mid(DateTime.Now.ToString("yy"), 1, 1) + Strings.Left(this.TrackNumber.Trim(), 7);
            }
            else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.LISBarcode8Bit, "0", false) == 0)
            {
              PMS_DataImport pmsDataImport3 = this;
              string str9 = strArray1[index2];
              char[] chArray7 = new char[1];
              int index8 = 0;
              int num8 = 124;
              chArray7[index8] = (char) num8;
              string str10 = str9.Split(chArray7)[2];
              char[] chArray8 = new char[1];
              int index9 = 0;
              int num9 = 94;
              chArray8[index9] = (char) num9;
              string str11 = Strings.Mid(str10.Split(chArray8)[1], 3, 8);
              pmsDataImport3.TrackNumber = str11;
              PMS_DataImport pmsDataImport4 = this;
              string str12 = strArray1[index2];
              char[] chArray9 = new char[1];
              int index10 = 0;
              int num10 = 124;
              chArray9[index10] = (char) num10;
              string str13 = str12.Split(chArray9)[2];
              char[] chArray10 = new char[1];
              int index11 = 0;
              int num11 = 94;
              chArray10[index11] = (char) num11;
              string str14 = Strings.Mid(str13.Split(chArray10)[1], 1, 2);
              pmsDataImport4.SampleID = str14;
              this.LISTrackNumber = this.SampleID + this.TrackNumber;
            }
            this.UpdateText(this.TextBoxTrackForTestOrder, this.TrackNumber, false);
            this.AssayType = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.SampleID, "03", false) != 0 ? (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.SampleID, "04", false) != 0 ? "Serum" : "CSF") : "Urine";
            string[] strArray2 = new string[11];
            int index12 = 0;
            string str15 = "exec spTestListOnServiceTrackLISWithPatient @TrackNumber='";
            strArray2[index12] = str15;
            int index13 = 1;
            string str16 = this.TrackNumber;
            strArray2[index13] = str16;
            int index14 = 2;
            string str17 = "', @MachineName='";
            strArray2[index14] = str17;
            int index15 = 3;
            string str18 = this.MachineName;
            strArray2[index15] = str18;
            int index16 = 4;
            string str19 = "', @ExcludeExistingDBTest='";
            strArray2[index16] = str19;
            int index17 = 5;
            string str20 = Conversions.ToString(this.CheckBoxCheckTestInDBResult.Checked);
            strArray2[index17] = str20;
            int index18 = 6;
            string str21 = "', @SampleID='";
            strArray2[index18] = str21;
            int index19 = 7;
            string str22 = this.SampleID;
            strArray2[index19] = str22;
            int index20 = 8;
            string str23 = "', @AssayType='";
            strArray2[index20] = str23;
            int index21 = 9;
            string str24 = this.AssayType;
            strArray2[index21] = str24;
            int index22 = 10;
            string str25 = "'";
            strArray2[index22] = str25;
            RegisterMicrosoftVisualStudio.SqlText = string.Concat(strArray2);
            RegisterMicrosoftVisualStudio.da.SelectCommand = new OleDbCommand(RegisterMicrosoftVisualStudio.SqlText, RegisterMicrosoftVisualStudio.Conn);
            if (RegisterMicrosoftVisualStudio.ds.Tables["PatientTestList"] != null)
              RegisterMicrosoftVisualStudio.ds.Tables["PatientTestList"].Clear();
            ((DbDataAdapter) RegisterMicrosoftVisualStudio.da).Fill(RegisterMicrosoftVisualStudio.ds, "PatientTestList");
            DataTable dataTable = RegisterMicrosoftVisualStudio.ds.Tables["PatientTestList"];
            if (dataTable.Rows.Count < 1)
              break;
            this.PatientName = Conversions.ToString(dataTable.Rows[0]["PatientName"]);
            this.PatientBirthdate = Conversions.ToString(dataTable.Rows[0]["PatientBirthdate"]);
            this.PatientSex = Conversions.ToString(dataTable.Rows[0]["PatientSex"]);
            string str26 = "";
            int num12 = checked (dataTable.Rows.Count - 1);
            int index23 = 0;
            while (index23 <= num12)
            {
              str26 = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) (str26 + "\\^^^"), dataTable.Rows[index23]["TEST_CODE"]));
              checked { ++index23; }
            }
            StringBuilder stringBuilder1 = new StringBuilder();
            stringBuilder1.Append('\x0005');
            if (this.SerialPortCellDynRuby.IsOpen)
              this.SerialPortCellDynRuby.Write(stringBuilder1.ToString());
            this.UpdateText(this.TextBoxLISRespond, "\r\nSend ENQ\r\n", true);
            int FrameNumber = 1;
            int num13 = 0;
            do
            {
              StringBuilder stringBuilder2 = new StringBuilder();
              stringBuilder2.Append('\x0002');
              stringBuilder2.Append(FrameNumber);
              string OrderMsg;
              if (num13 == 0)
                OrderMsg = "H|\\^&||||||||||P|LIS2-A\r";
              else if (num13 == 1)
              {
                string[] strArray3 = new string[9];
                int index8 = 0;
                string str9 = "P|1||";
                strArray3[index8] = str9;
                int index9 = 1;
                string str10 = this.TrackNumber;
                strArray3[index9] = str10;
                int index10 = 2;
                string str11 = "||";
                strArray3[index10] = str11;
                int index11 = 3;
                string str12 = this.PatientName;
                strArray3[index11] = str12;
                int index24 = 4;
                string str13 = "||";
                strArray3[index24] = str13;
                int index25 = 5;
                string str14 = this.PatientBirthdate;
                strArray3[index25] = str14;
                int index26 = 6;
                string str27 = "|";
                strArray3[index26] = str27;
                int index27 = 7;
                string str28 = this.PatientSex;
                strArray3[index27] = str28;
                int index28 = 8;
                string str29 = "|||||||^\r";
                strArray3[index28] = str29;
                OrderMsg = string.Concat(strArray3);
              }
              else
                OrderMsg = num13 != 2 ? "L|1|N\r" : "O|1|" + this.LISTrackNumber + "||^^^CBC^5^0|||||||||||Patient^Human\r";
              stringBuilder2.Append(OrderMsg);
              stringBuilder2.Append('\x0003');
              string str30 = this.CheckSumArchitectMachinSerialData(FrameNumber, OrderMsg, 0);
              stringBuilder2.Append(Strings.Left(str30, 1));
              stringBuilder2.Append(Strings.Right(str30, 1));
              stringBuilder2.Append('\r');
              stringBuilder2.Append('\n');
              checked { ++FrameNumber; }
              if (FrameNumber == 8)
                FrameNumber = 0;
              if (this.SerialPortCellDynRuby.IsOpen)
                this.SerialPortCellDynRuby.Write(stringBuilder2.ToString());
              checked { ++num13; }
            }
            while (num13 <= 3);
            StringBuilder stringBuilder3 = new StringBuilder();
            stringBuilder3.Append('\x0004');
            if (this.SerialPortCellDynRuby.IsOpen)
              this.SerialPortCellDynRuby.Write(stringBuilder3.ToString());
            this.UpdateText(this.TextBoxLISRespond, "\r\nSend EOT\r\n", true);
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left1, "R", false) == 0)
          {
            PMS_DataImport pmsDataImport1 = this;
            string str3 = strArray1[index2];
            char[] chArray3 = new char[1];
            int index4 = 0;
            int num4 = 124;
            chArray3[index4] = (char) num4;
            string str4 = str3.Split(chArray3)[2];
            char[] chArray4 = new char[1];
            int index5 = 0;
            int num5 = 94;
            chArray4[index5] = (char) num5;
            string str5 = str4.Split(chArray4)[6];
            pmsDataImport1.TestName = str5;
            this.LISTestCode = this.TestName;
            string str6 = strArray1[index2];
            char[] chArray5 = new char[1];
            int index6 = 0;
            int num6 = 124;
            chArray5[index6] = (char) num6;
            string Left2 = str6.Split(chArray5)[3];
            if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left2, "", false) > 0U)
            {
              PMS_DataImport pmsDataImport2 = this;
              TextBox textBoxLisData = this.TextBoxLISData;
              string[] strArray2 = new string[7];
              int index7 = 0;
              string str7 = "Track:";
              strArray2[index7] = str7;
              int index8 = 1;
              string str8 = this.TrackNumber;
              strArray2[index8] = str8;
              int index9 = 2;
              string str9 = " ";
              strArray2[index9] = str9;
              int index10 = 3;
              string str10 = this.TestName;
              strArray2[index10] = str10;
              int index11 = 4;
              string str11 = " : ";
              strArray2[index11] = str11;
              int index12 = 5;
              string str12 = Left2;
              strArray2[index12] = str12;
              int index13 = 6;
              string str13 = "\r\n";
              strArray2[index13] = str13;
              string txt = string.Concat(strArray2);
              int num7 = 1;
              pmsDataImport2.UpdateText(textBoxLisData, txt, num7 != 0);
            }
            DataRow[] dataRowArray = RegisterMicrosoftVisualStudio.ds.Tables["LISTestCodeList"].Select("Test_Name='" + this.TestName + "'");
            if (dataRowArray != null)
            {
              int upperBound = dataRowArray.GetUpperBound(0);
              int index7 = 0;
              while (index7 <= upperBound)
              {
                this.TestCode = Conversions.ToString(dataRowArray[index7]["Test_Code"]);
                if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.TestCode, "", false) > 0U & (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left2, "", false) > 0U && !this.ExistsDataTableSameRecord(this.TrackNumber, this.TestCode))
                {
                  DataRowCollection rows = this.dtLISResult.Rows;
                  object[] objArray = new object[8];
                  int index8 = 0;
                  string str7 = this.PatientID;
                  objArray[index8] = (object) str7;
                  int index9 = 1;
                  string str8 = this.TrackNumber;
                  objArray[index9] = (object) str8;
                  int index10 = 2;
                  string str9 = this.TestCode;
                  objArray[index10] = (object) str9;
                  int index11 = 3;
                  string str10 = this.TestName;
                  objArray[index11] = (object) str10;
                  int index12 = 4;
                  string str11 = Left2;
                  objArray[index12] = (object) str11;
                  int index13 = 5;
                  string str12 = this.LISTestCode;
                  objArray[index13] = (object) str12;
                  int index14 = 6;
                  string str13 = "";
                  objArray[index14] = (object) str13;
                  int index15 = 7;
                  // ISSUE: variable of a boxed type
                  __Boxed<DateTime> local = (System.ValueType) this.LISMachineTestTime;
                  objArray[index15] = (object) local;
                  rows.Add(objArray);
                  if (this.dtLISResult.Rows.Count > 900)
                    this.SaveLISImportedData();
                }
                checked { ++index7; }
              }
            }
            this.SaveLISImportedData();
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left1, "M", false) == 0)
          {
            PMS_DataImport pmsDataImport1 = this;
            string str3 = strArray1[index2];
            char[] chArray3 = new char[1];
            int index4 = 0;
            int num4 = 124;
            chArray3[index4] = (char) num4;
            string str4 = str3.Split(chArray3)[3].Trim();
            pmsDataImport1.TestName = str4;
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.TestName, "PLT", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.TestName, "RBC", false) == 0)
            {
              PMS_DataImport pmsDataImport2 = this;
              string TrackNo = this.LISTrackNumber;
              string TestName = this.TestName;
              string str5 = strArray1[index2];
              char[] chArray4 = new char[1];
              int index5 = 0;
              int num5 = 124;
              chArray4[index5] = (char) num5;
              string Disc = str5.Split(chArray4)[5].Trim();
              string str6 = strArray1[index2];
              char[] chArray5 = new char[1];
              int index6 = 0;
              int num6 = 124;
              chArray5[index6] = (char) num6;
              string ChartValue = str6.Split(chArray5)[6].Trim();
              pmsDataImport2.SaveLISImportedDataChart(TrackNo, TestName, Disc, ChartValue);
            }
          }
          checked { ++index2; }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.UpdateText(this.TextBoxLISData, "HandleData: " + ex.Message + "\r\n", true);
        ProjectData.ClearProjectError();
      }
    }

    private void AnalyzeBufferDataCelltacChemi(string QBuffer)
    {
      this.dtLISResult.Rows.Clear();
      try
      {
        string str1 = QBuffer;
        char[] chArray1 = new char[1];
        int index1 = 0;
        int num1 = 13;
        chArray1[index1] = (char) num1;
        string[] strArray1 = str1.Split(chArray1);
        int num2 = checked (Information.UBound((Array) strArray1, 1) - 1);
        int index2 = 0;
        while (index2 <= num2)
        {
          string str2 = strArray1[index2];
          char[] chArray2 = new char[1];
          int index3 = 0;
          int num3 = 124;
          chArray2[index3] = (char) num3;
          string Left1 = Strings.Right(str2.Split(chArray2)[0], 1);
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left1, "O", false) == 0)
          {
            PMS_DataImport pmsDataImport1 = this;
            string str3 = strArray1[index2];
            char[] chArray3 = new char[1];
            int index4 = 0;
            int num4 = 124;
            chArray3[index4] = (char) num4;
            string str4 = str3.Split(chArray3)[2];
            char[] chArray4 = new char[1];
            int index5 = 0;
            int num5 = 94;
            chArray4[index5] = (char) num5;
            string str5 = Strings.Mid(str4.Split(chArray4)[0].Trim(), 1, 8);
            pmsDataImport1.TrackNumber = str5;
            this.LISTrackNumber = this.TrackNumber;
            PMS_DataImport pmsDataImport2 = this;
            string str6 = strArray1[index2];
            char[] chArray5 = new char[1];
            int index6 = 0;
            int num6 = 124;
            chArray5[index6] = (char) num6;
            string str7 = str6.Split(chArray5)[2];
            char[] chArray6 = new char[1];
            int index7 = 0;
            int num7 = 94;
            chArray6[index7] = (char) num7;
            string str8 = Strings.Mid(str7.Split(chArray6)[0].Trim(), 9);
            pmsDataImport2.SampleID = str8;
            PMS_DataImport pmsDataImport3 = this;
            string str9 = strArray1[index2];
            char[] chArray7 = new char[1];
            int index8 = 0;
            int num8 = 124;
            chArray7[index8] = (char) num8;
            string str10 = str9.Split(chArray7)[2];
            char[] chArray8 = new char[1];
            int index9 = 0;
            int num9 = 94;
            chArray8[index9] = (char) num9;
            string str11 = str10.Split(chArray8)[0].Trim();
            pmsDataImport3.PatientID = str11;
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.LISBarcode8Bit, "1", false) == 0)
            {
              this.SampleID = Strings.Right(this.TrackNumber.Trim(), 1);
              this.TrackNumber = Strings.Mid(DateTime.Now.ToString("yy"), 1, 1) + Strings.Left(this.TrackNumber.Trim(), 7);
            }
            else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.LISBarcode8Bit, "0", false) == 0)
            {
              PMS_DataImport pmsDataImport4 = this;
              string str12 = strArray1[index2];
              char[] chArray9 = new char[1];
              int index10 = 0;
              int num10 = 124;
              chArray9[index10] = (char) num10;
              string str13 = str12.Split(chArray9)[2];
              char[] chArray10 = new char[1];
              int index11 = 0;
              int num11 = 94;
              chArray10[index11] = (char) num11;
              string str14 = Strings.Mid(str13.Split(chArray10)[0].Trim(), 3, 8);
              pmsDataImport4.TrackNumber = str14;
              PMS_DataImport pmsDataImport5 = this;
              string str15 = strArray1[index2];
              char[] chArray11 = new char[1];
              int index12 = 0;
              int num12 = 124;
              chArray11[index12] = (char) num12;
              string str16 = str15.Split(chArray11)[2];
              char[] chArray12 = new char[1];
              int index13 = 0;
              int num13 = 94;
              chArray12[index13] = (char) num13;
              string str17 = Strings.Mid(str16.Split(chArray12)[0].Trim(), 1, 2);
              pmsDataImport5.SampleID = str17;
              this.LISTrackNumber = this.SampleID + this.TrackNumber;
            }
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left1, "R", false) == 0)
          {
            PMS_DataImport pmsDataImport1 = this;
            string str3 = strArray1[index2];
            char[] chArray3 = new char[1];
            int index4 = 0;
            int num4 = 124;
            chArray3[index4] = (char) num4;
            string str4 = str3.Split(chArray3)[2];
            char[] chArray4 = new char[1];
            int index5 = 0;
            int num5 = 94;
            chArray4[index5] = (char) num5;
            string str5 = str4.Split(chArray4)[3];
            pmsDataImport1.TestName = str5;
            this.LISTestCode = this.TestName;
            string str6 = strArray1[index2];
            char[] chArray5 = new char[1];
            int index6 = 0;
            int num6 = 124;
            chArray5[index6] = (char) num6;
            string Left2 = str6.Split(chArray5)[3];
            if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left2, "", false) > 0U)
            {
              PMS_DataImport pmsDataImport2 = this;
              TextBox textBoxLisData = this.TextBoxLISData;
              string[] strArray2 = new string[7];
              int index7 = 0;
              string str7 = "Track:";
              strArray2[index7] = str7;
              int index8 = 1;
              string str8 = this.TrackNumber;
              strArray2[index8] = str8;
              int index9 = 2;
              string str9 = " ";
              strArray2[index9] = str9;
              int index10 = 3;
              string str10 = this.TestName;
              strArray2[index10] = str10;
              int index11 = 4;
              string str11 = " : ";
              strArray2[index11] = str11;
              int index12 = 5;
              string str12 = Left2;
              strArray2[index12] = str12;
              int index13 = 6;
              string str13 = "\r\n";
              strArray2[index13] = str13;
              string txt = string.Concat(strArray2);
              int num7 = 1;
              pmsDataImport2.UpdateText(textBoxLisData, txt, num7 != 0);
            }
            DataRow[] dataRowArray = RegisterMicrosoftVisualStudio.ds.Tables["LISTestCodeList"].Select("Test_Name='" + this.TestName + "'");
            if (dataRowArray != null)
            {
              int upperBound = dataRowArray.GetUpperBound(0);
              int index7 = 0;
              while (index7 <= upperBound)
              {
                this.TestCode = Conversions.ToString(dataRowArray[index7]["Test_Code"]);
                if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.TestCode, "", false) > 0U & (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left2, "", false) > 0U && !this.ExistsDataTableSameRecord(this.TrackNumber, this.TestCode))
                {
                  DataRowCollection rows = this.dtLISResult.Rows;
                  object[] objArray = new object[8];
                  int index8 = 0;
                  string str7 = this.PatientID;
                  objArray[index8] = (object) str7;
                  int index9 = 1;
                  string str8 = this.TrackNumber;
                  objArray[index9] = (object) str8;
                  int index10 = 2;
                  string str9 = this.TestCode;
                  objArray[index10] = (object) str9;
                  int index11 = 3;
                  string str10 = this.TestName;
                  objArray[index11] = (object) str10;
                  int index12 = 4;
                  string str11 = Left2;
                  objArray[index12] = (object) str11;
                  int index13 = 5;
                  string str12 = this.LISTestCode;
                  objArray[index13] = (object) str12;
                  int index14 = 6;
                  string str13 = "";
                  objArray[index14] = (object) str13;
                  int index15 = 7;
                  // ISSUE: variable of a boxed type
                  __Boxed<DateTime> local = (System.ValueType) this.LISMachineTestTime;
                  objArray[index15] = (object) local;
                  rows.Add(objArray);
                  if (this.dtLISResult.Rows.Count > 900)
                    this.SaveLISImportedData();
                }
                checked { ++index7; }
              }
            }
            this.SaveLISImportedData();
          }
          checked { ++index2; }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.UpdateText(this.TextBoxLISData, "HandleData: " + ex.Message + "\r\n", true);
        ProjectData.ClearProjectError();
      }
    }

    private void AnalyzeBufferDataVIDAS(string QBuffer)
    {
      this.dtLISResult.Rows.Clear();
      try
      {
        string str1 = QBuffer;
        char[] chArray1 = new char[1];
        int index1 = 0;
        int num1 = 13;
        chArray1[index1] = (char) num1;
        string[] strArray1 = str1.Split(chArray1);
        int num2 = checked (Information.UBound((Array) strArray1, 1) - 1);
        int index2 = 0;
        while (index2 <= num2)
        {
          string str2 = strArray1[index2];
          char[] chArray2 = new char[1];
          int index3 = 0;
          int num3 = 124;
          chArray2[index3] = (char) num3;
          string Left1 = Strings.Right(str2.Split(chArray2)[0], 1);
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left1, "O", false) == 0)
          {
            PMS_DataImport pmsDataImport1 = this;
            string str3 = strArray1[index2];
            char[] chArray3 = new char[1];
            int index4 = 0;
            int num4 = 124;
            chArray3[index4] = (char) num4;
            string str4 = str3.Split(chArray3)[2];
            char[] chArray4 = new char[1];
            int index5 = 0;
            int num5 = 94;
            chArray4[index5] = (char) num5;
            string str5 = Strings.Mid(str4.Split(chArray4)[0], 1, 8);
            pmsDataImport1.TrackNumber = str5;
            this.LISTrackNumber = this.TrackNumber;
            PMS_DataImport pmsDataImport2 = this;
            string str6 = strArray1[index2];
            char[] chArray5 = new char[1];
            int index6 = 0;
            int num6 = 124;
            chArray5[index6] = (char) num6;
            string str7 = str6.Split(chArray5)[2];
            char[] chArray6 = new char[1];
            int index7 = 0;
            int num7 = 94;
            chArray6[index7] = (char) num7;
            string str8 = Strings.Mid(str7.Split(chArray6)[0], 9);
            pmsDataImport2.SampleID = str8;
            PMS_DataImport pmsDataImport3 = this;
            string str9 = strArray1[index2];
            char[] chArray7 = new char[1];
            int index8 = 0;
            int num8 = 124;
            chArray7[index8] = (char) num8;
            string str10 = str9.Split(chArray7)[2];
            char[] chArray8 = new char[1];
            int index9 = 0;
            int num9 = 94;
            chArray8[index9] = (char) num9;
            string str11 = str10.Split(chArray8)[0];
            pmsDataImport3.PatientID = str11;
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.LISBarcode8Bit, "1", false) == 0)
            {
              this.SampleID = Strings.Right(this.TrackNumber.Trim(), 1);
              this.TrackNumber = Strings.Mid(DateTime.Now.ToString("yy"), 1, 1) + Strings.Left(this.TrackNumber.Trim(), 7);
            }
            else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.LISBarcode8Bit, "0", false) == 0)
            {
              PMS_DataImport pmsDataImport4 = this;
              string str12 = strArray1[index2];
              char[] chArray9 = new char[1];
              int index10 = 0;
              int num10 = 124;
              chArray9[index10] = (char) num10;
              string str13 = str12.Split(chArray9)[2];
              char[] chArray10 = new char[1];
              int index11 = 0;
              int num11 = 94;
              chArray10[index11] = (char) num11;
              string str14 = Strings.Mid(str13.Split(chArray10)[0], 3, 8);
              pmsDataImport4.TrackNumber = str14;
              PMS_DataImport pmsDataImport5 = this;
              string str15 = strArray1[index2];
              char[] chArray11 = new char[1];
              int index12 = 0;
              int num12 = 124;
              chArray11[index12] = (char) num12;
              string str16 = str15.Split(chArray11)[2];
              char[] chArray12 = new char[1];
              int index13 = 0;
              int num13 = 94;
              chArray12[index13] = (char) num13;
              string str17 = Strings.Mid(str16.Split(chArray12)[0], 1, 2);
              pmsDataImport5.SampleID = str17;
              this.LISTrackNumber = this.SampleID + this.TrackNumber;
            }
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left1, "R", false) == 0)
          {
            PMS_DataImport pmsDataImport1 = this;
            string str3 = strArray1[index2];
            char[] chArray3 = new char[1];
            int index4 = 0;
            int num4 = 124;
            chArray3[index4] = (char) num4;
            string str4 = str3.Split(chArray3)[2];
            char[] chArray4 = new char[1];
            int index5 = 0;
            int num5 = 94;
            chArray4[index5] = (char) num5;
            string str5 = str4.Split(chArray4)[6];
            pmsDataImport1.TestName = str5;
            this.LISTestCode = this.TestName;
            string str6 = strArray1[index2];
            char[] chArray5 = new char[1];
            int index6 = 0;
            int num6 = 124;
            chArray5[index6] = (char) num6;
            string Left2 = str6.Split(chArray5)[3];
            if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left2, "", false) > 0U)
            {
              PMS_DataImport pmsDataImport2 = this;
              TextBox textBoxLisData = this.TextBoxLISData;
              string[] strArray2 = new string[7];
              int index7 = 0;
              string str7 = "Track:";
              strArray2[index7] = str7;
              int index8 = 1;
              string str8 = this.TrackNumber;
              strArray2[index8] = str8;
              int index9 = 2;
              string str9 = " ";
              strArray2[index9] = str9;
              int index10 = 3;
              string str10 = this.TestName;
              strArray2[index10] = str10;
              int index11 = 4;
              string str11 = " : ";
              strArray2[index11] = str11;
              int index12 = 5;
              string str12 = Left2;
              strArray2[index12] = str12;
              int index13 = 6;
              string str13 = "\r\n";
              strArray2[index13] = str13;
              string txt = string.Concat(strArray2);
              int num7 = 1;
              pmsDataImport2.UpdateText(textBoxLisData, txt, num7 != 0);
            }
            DataRow[] dataRowArray = RegisterMicrosoftVisualStudio.ds.Tables["LISTestCodeList"].Select("Test_Name='" + this.TestName + "'");
            if (dataRowArray != null)
            {
              int upperBound = dataRowArray.GetUpperBound(0);
              int index7 = 0;
              while (index7 <= upperBound)
              {
                this.TestCode = Conversions.ToString(dataRowArray[index7]["Test_Code"]);
                if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.TestCode, "", false) > 0U & (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left2, "", false) > 0U && !this.ExistsDataTableSameRecord(this.TrackNumber, this.TestCode))
                {
                  DataRowCollection rows = this.dtLISResult.Rows;
                  object[] objArray = new object[8];
                  int index8 = 0;
                  string str7 = this.PatientID;
                  objArray[index8] = (object) str7;
                  int index9 = 1;
                  string str8 = this.TrackNumber;
                  objArray[index9] = (object) str8;
                  int index10 = 2;
                  string str9 = this.TestCode;
                  objArray[index10] = (object) str9;
                  int index11 = 3;
                  string str10 = this.TestName;
                  objArray[index11] = (object) str10;
                  int index12 = 4;
                  string str11 = Left2;
                  objArray[index12] = (object) str11;
                  int index13 = 5;
                  string str12 = this.LISTestCode;
                  objArray[index13] = (object) str12;
                  int index14 = 6;
                  string str13 = "";
                  objArray[index14] = (object) str13;
                  int index15 = 7;
                  // ISSUE: variable of a boxed type
                  __Boxed<DateTime> local = (System.ValueType) this.LISMachineTestTime;
                  objArray[index15] = (object) local;
                  rows.Add(objArray);
                  if (this.dtLISResult.Rows.Count > 900)
                    this.SaveLISImportedData();
                }
                checked { ++index7; }
              }
            }
            this.SaveLISImportedData();
          }
          checked { ++index2; }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.UpdateText(this.TextBoxLISData, "HandleData: " + ex.Message + "\r\n", true);
        ProjectData.ClearProjectError();
      }
    }

    private void AnalyzeBufferDataBioradD10(string QBuffer)
    {
      this.dtLISResult.Rows.Clear();
      try
      {
        string str1 = QBuffer;
        char[] chArray1 = new char[1];
        int index1 = 0;
        int num1 = 13;
        chArray1[index1] = (char) num1;
        string[] strArray1 = str1.Split(chArray1);
        int num2 = checked (Information.UBound((Array) strArray1, 1) - 1);
        int index2 = 0;
        while (index2 <= num2)
        {
          string str2 = strArray1[index2];
          char[] chArray2 = new char[1];
          int index3 = 0;
          int num3 = 124;
          chArray2[index3] = (char) num3;
          string Left1 = Strings.Right(str2.Split(chArray2)[0], 1);
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left1, "O", false) == 0)
          {
            PMS_DataImport pmsDataImport1 = this;
            string str3 = strArray1[index2];
            char[] chArray3 = new char[1];
            int index4 = 0;
            int num4 = 124;
            chArray3[index4] = (char) num4;
            string str4 = Strings.Mid(str3.Split(chArray3)[2].Trim(), 1, 8);
            pmsDataImport1.TrackNumber = str4;
            this.LISTrackNumber = this.TrackNumber;
            PMS_DataImport pmsDataImport2 = this;
            string str5 = strArray1[index2];
            char[] chArray4 = new char[1];
            int index5 = 0;
            int num5 = 124;
            chArray4[index5] = (char) num5;
            string str6 = Strings.Mid(str5.Split(chArray4)[2].Trim(), 9);
            pmsDataImport2.SampleID = str6;
            PMS_DataImport pmsDataImport3 = this;
            string str7 = strArray1[index2];
            char[] chArray5 = new char[1];
            int index6 = 0;
            int num6 = 124;
            chArray5[index6] = (char) num6;
            string str8 = str7.Split(chArray5)[2].Trim();
            pmsDataImport3.PatientID = str8;
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.LISBarcode8Bit, "1", false) == 0)
            {
              this.SampleID = Strings.Right(this.TrackNumber.Trim(), 1);
              this.TrackNumber = Strings.Mid(DateTime.Now.ToString("yy"), 1, 1) + Strings.Left(this.TrackNumber.Trim(), 7);
            }
            else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.LISBarcode8Bit, "0", false) == 0)
            {
              PMS_DataImport pmsDataImport4 = this;
              string str9 = strArray1[index2];
              char[] chArray6 = new char[1];
              int index7 = 0;
              int num7 = 124;
              chArray6[index7] = (char) num7;
              string str10 = Strings.Mid(str9.Split(chArray6)[2].Trim(), 3, 8).Trim();
              pmsDataImport4.TrackNumber = str10;
              PMS_DataImport pmsDataImport5 = this;
              string str11 = strArray1[index2];
              char[] chArray7 = new char[1];
              int index8 = 0;
              int num8 = 124;
              chArray7[index8] = (char) num8;
              string str12 = Strings.Mid(str11.Split(chArray7)[2].Trim(), 1, 2);
              pmsDataImport5.SampleID = str12;
              this.LISTrackNumber = this.SampleID + this.TrackNumber;
            }
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left1, "R", false) == 0)
          {
            string str3 = strArray1[index2];
            char[] chArray3 = new char[1];
            int index4 = 0;
            int num4 = 124;
            chArray3[index4] = (char) num4;
            string str4 = str3.Split(chArray3)[2];
            char[] chArray4 = new char[1];
            int index5 = 0;
            int num5 = 94;
            chArray4[index5] = (char) num5;
            if (str4.Split(chArray4).Length == 5 & (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.TrackNumber, "", false) > 0U)
            {
              PMS_DataImport pmsDataImport1 = this;
              string str5 = strArray1[index2];
              char[] chArray5 = new char[1];
              int index6 = 0;
              int num6 = 124;
              chArray5[index6] = (char) num6;
              string str6 = str5.Split(chArray5)[2];
              char[] chArray6 = new char[1];
              int index7 = 0;
              int num7 = 94;
              chArray6[index7] = (char) num7;
              string str7 = str6.Split(chArray6)[3];
              pmsDataImport1.TestName = str7;
              this.LISTestCode = this.TestName;
              string str8 = strArray1[index2];
              char[] chArray7 = new char[1];
              int index8 = 0;
              int num8 = 124;
              chArray7[index8] = (char) num8;
              string Left2 = str8.Split(chArray7)[3];
              if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left2, "", false) > 0U)
              {
                PMS_DataImport pmsDataImport2 = this;
                TextBox textBoxLisData = this.TextBoxLISData;
                string[] strArray2 = new string[7];
                int index9 = 0;
                string str9 = "Track:";
                strArray2[index9] = str9;
                int index10 = 1;
                string str10 = this.TrackNumber;
                strArray2[index10] = str10;
                int index11 = 2;
                string str11 = " ";
                strArray2[index11] = str11;
                int index12 = 3;
                string str12 = this.TestName;
                strArray2[index12] = str12;
                int index13 = 4;
                string str13 = " : ";
                strArray2[index13] = str13;
                int index14 = 5;
                string str14 = Left2;
                strArray2[index14] = str14;
                int index15 = 6;
                string str15 = "\r\n";
                strArray2[index15] = str15;
                string txt = string.Concat(strArray2);
                int num9 = 1;
                pmsDataImport2.UpdateText(textBoxLisData, txt, num9 != 0);
              }
              DataRow[] dataRowArray = RegisterMicrosoftVisualStudio.ds.Tables["LISTestCodeList"].Select("Test_Name='" + this.TestName + "'");
              if (dataRowArray != null)
              {
                int upperBound = dataRowArray.GetUpperBound(0);
                int index9 = 0;
                while (index9 <= upperBound)
                {
                  this.TestCode = Conversions.ToString(dataRowArray[index9]["Test_Code"]);
                  int num9 = (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.TestCode, "", false) > 0U & (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left2, "", false) > 0U ? 1 : 0;
                  string str9 = strArray1[index2];
                  char[] chArray8 = new char[1];
                  int index10 = 0;
                  int num10 = 124;
                  chArray8[index10] = (char) num10;
                  string str10 = str9.Split(chArray8)[2];
                  char[] chArray9 = new char[1];
                  int index11 = 0;
                  int num11 = 94;
                  chArray9[index11] = (char) num11;
                  int num12 = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str10.Split(chArray9)[4].Trim(), "AREA", false) == 0 ? 1 : 0;
                  if ((num9 & num12) != 0 && !this.ExistsDataTableSameRecord(this.TrackNumber, this.TestCode))
                  {
                    DataRowCollection rows = this.dtLISResult.Rows;
                    object[] objArray = new object[8];
                    int index12 = 0;
                    string str11 = this.PatientID;
                    objArray[index12] = (object) str11;
                    int index13 = 1;
                    string str12 = this.TrackNumber;
                    objArray[index13] = (object) str12;
                    int index14 = 2;
                    string str13 = this.TestCode;
                    objArray[index14] = (object) str13;
                    int index15 = 3;
                    string str14 = this.TestName;
                    objArray[index15] = (object) str14;
                    int index16 = 4;
                    string str15 = Left2;
                    objArray[index16] = (object) str15;
                    int index17 = 5;
                    string str16 = this.LISTestCode;
                    objArray[index17] = (object) str16;
                    int index18 = 6;
                    string str17 = "";
                    objArray[index18] = (object) str17;
                    int index19 = 7;
                    // ISSUE: variable of a boxed type
                    __Boxed<DateTime> local = (System.ValueType) this.LISMachineTestTime;
                    objArray[index19] = (object) local;
                    rows.Add(objArray);
                    if (this.dtLISResult.Rows.Count > 900)
                      this.SaveLISImportedData();
                  }
                  checked { ++index9; }
                }
              }
              this.SaveLISImportedData();
              PMS_DataImport pmsDataImport3 = this;
              string TrackNo = this.TrackNumber;
              string TestName = this.TestName;
              string str18 = strArray1[index2];
              char[] chArray10 = new char[1];
              int index20 = 0;
              int num13 = 124;
              chArray10[index20] = (char) num13;
              string str19 = str18.Split(chArray10)[2];
              char[] chArray11 = new char[1];
              int index21 = 0;
              int num14 = 94;
              chArray11[index21] = (char) num14;
              string Disc = str19.Split(chArray11)[4].Trim();
              string ChartValue = Left2;
              pmsDataImport3.SaveLISImportedDataChart(TrackNo, TestName, Disc, ChartValue);
            }
          }
          checked { ++index2; }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.UpdateText(this.TextBoxLISData, "HandleData: " + ex.Message + "\r\n", true);
        ProjectData.ClearProjectError();
      }
    }

    private void AnalyzeBufferDataBioradvariant(string QBuffer)
    {
      this.dtLISResult.Rows.Clear();
      try
      {
        string str1 = QBuffer;
        char[] chArray1 = new char[1];
        int index1 = 0;
        int num1 = 13;
        chArray1[index1] = (char) num1;
        string[] strArray1 = str1.Split(chArray1);
        int num2 = checked (Information.UBound((Array) strArray1, 1) - 1);
        int index2 = 0;
        while (index2 <= num2)
        {
          string str2 = strArray1[index2];
          char[] chArray2 = new char[1];
          int index3 = 0;
          int num3 = 124;
          chArray2[index3] = (char) num3;
          string Left1 = Strings.Right(str2.Split(chArray2)[0], 1);
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left1, "O", false) == 0)
          {
            PMS_DataImport pmsDataImport1 = this;
            string str3 = strArray1[index2];
            char[] chArray3 = new char[1];
            int index4 = 0;
            int num4 = 124;
            chArray3[index4] = (char) num4;
            string str4 = Strings.Mid(str3.Split(chArray3)[2].Trim(), 1, 8);
            pmsDataImport1.TrackNumber = str4;
            this.LISTrackNumber = this.TrackNumber;
            PMS_DataImport pmsDataImport2 = this;
            string str5 = strArray1[index2];
            char[] chArray4 = new char[1];
            int index5 = 0;
            int num5 = 124;
            chArray4[index5] = (char) num5;
            string str6 = Strings.Mid(str5.Split(chArray4)[2].Trim(), 9);
            pmsDataImport2.SampleID = str6;
            PMS_DataImport pmsDataImport3 = this;
            string str7 = strArray1[index2];
            char[] chArray5 = new char[1];
            int index6 = 0;
            int num6 = 124;
            chArray5[index6] = (char) num6;
            string str8 = str7.Split(chArray5)[2].Trim();
            pmsDataImport3.PatientID = str8;
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.LISBarcode8Bit, "1", false) == 0)
            {
              this.SampleID = Strings.Right(this.TrackNumber.Trim(), 1);
              this.TrackNumber = Strings.Mid(DateTime.Now.ToString("yy"), 1, 1) + Strings.Left(this.TrackNumber.Trim(), 7);
            }
            else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.LISBarcode8Bit, "0", false) == 0)
            {
              PMS_DataImport pmsDataImport4 = this;
              string str9 = strArray1[index2];
              char[] chArray6 = new char[1];
              int index7 = 0;
              int num7 = 124;
              chArray6[index7] = (char) num7;
              string str10 = Strings.Mid(str9.Split(chArray6)[2].Trim(), 3, 8).Trim();
              pmsDataImport4.TrackNumber = str10;
              PMS_DataImport pmsDataImport5 = this;
              string str11 = strArray1[index2];
              char[] chArray7 = new char[1];
              int index8 = 0;
              int num8 = 124;
              chArray7[index8] = (char) num8;
              string str12 = Strings.Mid(str11.Split(chArray7)[2].Trim(), 1, 2);
              pmsDataImport5.SampleID = str12;
              this.LISTrackNumber = this.SampleID + this.TrackNumber;
            }
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left1, "R", false) == 0)
          {
            string str3 = strArray1[index2];
            char[] chArray3 = new char[1];
            int index4 = 0;
            int num4 = 124;
            chArray3[index4] = (char) num4;
            string str4 = str3.Split(chArray3)[2];
            char[] chArray4 = new char[1];
            int index5 = 0;
            int num5 = 94;
            chArray4[index5] = (char) num5;
            if (str4.Split(chArray4).Length == 5 & (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.TrackNumber, "", false) > 0U)
            {
              PMS_DataImport pmsDataImport1 = this;
              string str5 = strArray1[index2];
              char[] chArray5 = new char[1];
              int index6 = 0;
              int num6 = 124;
              chArray5[index6] = (char) num6;
              string str6 = str5.Split(chArray5)[2];
              char[] chArray6 = new char[1];
              int index7 = 0;
              int num7 = 94;
              chArray6[index7] = (char) num7;
              string str7 = str6.Split(chArray6)[3];
              pmsDataImport1.TestName = str7;
              this.LISTestCode = this.TestName;
              string str8 = strArray1[index2];
              char[] chArray7 = new char[1];
              int index8 = 0;
              int num8 = 124;
              chArray7[index8] = (char) num8;
              string Left2 = str8.Split(chArray7)[3];
              if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left2, "", false) > 0U)
              {
                PMS_DataImport pmsDataImport2 = this;
                TextBox textBoxLisData = this.TextBoxLISData;
                string[] strArray2 = new string[7];
                int index9 = 0;
                string str9 = "Track:";
                strArray2[index9] = str9;
                int index10 = 1;
                string str10 = this.TrackNumber;
                strArray2[index10] = str10;
                int index11 = 2;
                string str11 = " ";
                strArray2[index11] = str11;
                int index12 = 3;
                string str12 = this.TestName;
                strArray2[index12] = str12;
                int index13 = 4;
                string str13 = " : ";
                strArray2[index13] = str13;
                int index14 = 5;
                string str14 = Left2;
                strArray2[index14] = str14;
                int index15 = 6;
                string str15 = "\r\n";
                strArray2[index15] = str15;
                string txt = string.Concat(strArray2);
                int num9 = 1;
                pmsDataImport2.UpdateText(textBoxLisData, txt, num9 != 0);
              }
              DataRow[] dataRowArray = RegisterMicrosoftVisualStudio.ds.Tables["LISTestCodeList"].Select("Test_Name='" + this.TestName + "'");
              if (dataRowArray != null)
              {
                int upperBound = dataRowArray.GetUpperBound(0);
                int index9 = 0;
                while (index9 <= upperBound)
                {
                  this.TestCode = Conversions.ToString(dataRowArray[index9]["Test_Code"]);
                  int num9 = (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.TestCode, "", false) > 0U & (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left2, "", false) > 0U ? 1 : 0;
                  string str9 = strArray1[index2];
                  char[] chArray8 = new char[1];
                  int index10 = 0;
                  int num10 = 124;
                  chArray8[index10] = (char) num10;
                  string str10 = str9.Split(chArray8)[2];
                  char[] chArray9 = new char[1];
                  int index11 = 0;
                  int num11 = 94;
                  chArray9[index11] = (char) num11;
                  int num12 = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str10.Split(chArray9)[4].Trim(), "AREA", false) == 0 ? 1 : 0;
                  if ((num9 & num12) != 0 && !this.ExistsDataTableSameRecord(this.TrackNumber, this.TestCode))
                  {
                    DataRowCollection rows = this.dtLISResult.Rows;
                    object[] objArray = new object[8];
                    int index12 = 0;
                    string str11 = this.PatientID;
                    objArray[index12] = (object) str11;
                    int index13 = 1;
                    string str12 = this.TrackNumber;
                    objArray[index13] = (object) str12;
                    int index14 = 2;
                    string str13 = this.TestCode;
                    objArray[index14] = (object) str13;
                    int index15 = 3;
                    string str14 = this.TestName;
                    objArray[index15] = (object) str14;
                    int index16 = 4;
                    string str15 = Left2;
                    objArray[index16] = (object) str15;
                    int index17 = 5;
                    string str16 = this.LISTestCode;
                    objArray[index17] = (object) str16;
                    int index18 = 6;
                    string str17 = "";
                    objArray[index18] = (object) str17;
                    int index19 = 7;
                    // ISSUE: variable of a boxed type
                    __Boxed<DateTime> local = (System.ValueType) this.LISMachineTestTime;
                    objArray[index19] = (object) local;
                    rows.Add(objArray);
                    if (this.dtLISResult.Rows.Count > 900)
                      this.SaveLISImportedData();
                  }
                  checked { ++index9; }
                }
              }
              this.SaveLISImportedData();
              PMS_DataImport pmsDataImport3 = this;
              string TrackNo = this.TrackNumber;
              string TestName = this.TestName;
              string str18 = strArray1[index2];
              char[] chArray10 = new char[1];
              int index20 = 0;
              int num13 = 124;
              chArray10[index20] = (char) num13;
              string str19 = str18.Split(chArray10)[2];
              char[] chArray11 = new char[1];
              int index21 = 0;
              int num14 = 94;
              chArray11[index21] = (char) num14;
              string Disc = str19.Split(chArray11)[4].Trim();
              string ChartValue = Left2;
              pmsDataImport3.SaveLISImportedDataChart(TrackNo, TestName, Disc, ChartValue);
            }
          }
          checked { ++index2; }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.UpdateText(this.TextBoxLISData, "HandleData: " + ex.Message + "\r\n", true);
        ProjectData.ClearProjectError();
      }
    }

    private void SaveLISImportedDataChart(string TrackNo, string TestName, string Disc, string ChartValue)
    {
      int num1 = 0;
      OleDbCommand oleDbCommand = new OleDbCommand(RegisterMicrosoftVisualStudio.SqlText, RegisterMicrosoftVisualStudio.Conn);
      try
      {
        string[] strArray = new string[11];
        int index1 = 0;
        string str1 = "insert into DataImportDataChart (SampleID, TrackNumber, TestName, Discriminants, ChartValue) values ('";
        strArray[index1] = str1;
        int index2 = 1;
        string str2 = TrackNo;
        strArray[index2] = str2;
        int index3 = 2;
        string str3 = "','";
        strArray[index3] = str3;
        int index4 = 3;
        string str4 = TrackNo;
        strArray[index4] = str4;
        int index5 = 4;
        string str5 = "','";
        strArray[index5] = str5;
        int index6 = 5;
        string str6 = TestName;
        strArray[index6] = str6;
        int index7 = 6;
        string str7 = "','";
        strArray[index7] = str7;
        int index8 = 7;
        string str8 = Disc;
        strArray[index8] = str8;
        int index9 = 8;
        string str9 = "','";
        strArray[index9] = str9;
        int index10 = 9;
        string str10 = ChartValue;
        strArray[index10] = str10;
        int index11 = 10;
        string str11 = "');";
        strArray[index11] = str11;
        RegisterMicrosoftVisualStudio.SqlText = string.Concat(strArray);
        oleDbCommand.CommandType = CommandType.Text;
        oleDbCommand.CommandText = RegisterMicrosoftVisualStudio.SqlText;
        RegisterMicrosoftVisualStudio.Conn.Open();
        num1 = oleDbCommand.ExecuteNonQuery();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num2 = (int) MessageBox.Show(ex.Message, "SaveLISImportedDataChart");
        RegisterMicrosoftVisualStudio.Conn.Close();
        ProjectData.ClearProjectError();
        return;
      }
      RegisterMicrosoftVisualStudio.Conn.Close();
    }

    private void AnalyzeBufferDataImmulite2000(string QBuffer)
    {
      this.dtLISResult.Rows.Clear();
      try
      {
        this.SerialSignal = Conversions.ToString(Strings.AscW(Strings.Right(QBuffer, 1)));
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.SerialSignal, "4", false) == 0)
          this.UpdateText(this.TextBoxLISRespond, "Receive: EOT", false);
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.SerialSignal, "5", false) == 0)
          this.UpdateText(this.TextBoxLISRespond, "Receive: ENQ", false);
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.SerialSignal, "6", false) == 0)
          this.UpdateText(this.TextBoxLISRespond, "Receive: ACK", false);
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.SerialSignal, "21", false) == 0)
          this.UpdateText(this.TextBoxLISRespond, "Receive: NAK", false);
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.SerialSignal, "4", false) == 0)
        {
          string str1 = QBuffer;
          char[] chArray1 = new char[1];
          int index1 = 0;
          int num1 = 13;
          chArray1[index1] = (char) num1;
          string[] strArray1 = str1.Split(chArray1);
          int num2 = checked (Information.UBound((Array) strArray1, 1) - 1);
          int index2 = 0;
          while (index2 <= num2)
          {
            string str2 = strArray1[index2];
            char[] chArray2 = new char[1];
            int index3 = 0;
            int num3 = 124;
            chArray2[index3] = (char) num3;
            string Left1 = Strings.Right(str2.Split(chArray2)[0], 1);
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left1, "O", false) == 0)
            {
              string str3 = strArray1[index2];
              char[] chArray3 = new char[1];
              int index4 = 0;
              int num4 = 124;
              chArray3[index4] = (char) num4;
              if (Strings.Len(Strings.Mid(str3.Split(chArray3)[2], 1, 8)) > 1)
              {
                PMS_DataImport pmsDataImport = this;
                string str4 = strArray1[index2];
                char[] chArray4 = new char[1];
                int index5 = 0;
                int num5 = 124;
                chArray4[index5] = (char) num5;
                string str5 = Strings.Mid(str4.Split(chArray4)[2], 1, 8);
                pmsDataImport.TrackNumber = str5;
              }
              this.LISTrackNumber = this.TrackNumber;
              PMS_DataImport pmsDataImport1 = this;
              string str6 = strArray1[index2];
              char[] chArray5 = new char[1];
              int index6 = 0;
              int num6 = 124;
              chArray5[index6] = (char) num6;
              string str7 = Strings.Mid(str6.Split(chArray5)[2], 9, 2);
              pmsDataImport1.SampleID = str7;
              PMS_DataImport pmsDataImport2 = this;
              string str8 = strArray1[index2];
              char[] chArray6 = new char[1];
              int index7 = 0;
              int num7 = 124;
              chArray6[index7] = (char) num7;
              string str9 = str8.Split(chArray6)[2];
              pmsDataImport2.PatientID = str9;
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.LISBarcode8Bit, "1", false) == 0)
              {
                this.SampleID = Strings.Right(this.TrackNumber.Trim(), 1);
                this.TrackNumber = Strings.Mid(DateTime.Now.ToString("yy"), 1, 1) + Strings.Left(this.TrackNumber.Trim(), 7);
              }
              else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.LISBarcode8Bit, "0", false) == 0)
              {
                string str4 = strArray1[index2];
                char[] chArray4 = new char[1];
                int index5 = 0;
                int num5 = 124;
                chArray4[index5] = (char) num5;
                if (Strings.Len(Strings.Mid(str4.Split(chArray4)[2], 3, 8)) > 1)
                {
                  PMS_DataImport pmsDataImport3 = this;
                  string str5 = strArray1[index2];
                  char[] chArray7 = new char[1];
                  int index8 = 0;
                  int num8 = 124;
                  chArray7[index8] = (char) num8;
                  string str10 = Strings.Mid(str5.Split(chArray7)[2], 3, 8);
                  pmsDataImport3.TrackNumber = str10;
                }
                PMS_DataImport pmsDataImport4 = this;
                string str11 = strArray1[index2];
                char[] chArray8 = new char[1];
                int index9 = 0;
                int num9 = 124;
                chArray8[index9] = (char) num9;
                string str12 = Strings.Mid(str11.Split(chArray8)[2], 1, 2);
                pmsDataImport4.SampleID = str12;
                this.LISTrackNumber = this.SampleID + this.TrackNumber;
              }
            }
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left1, "Q", false) == 0)
            {
              string str3 = strArray1[index2];
              char[] chArray3 = new char[1];
              int index4 = 0;
              int num4 = 124;
              chArray3[index4] = (char) num4;
              string str4 = str3.Split(chArray3)[2];
              char[] chArray4 = new char[1];
              int index5 = 0;
              int num5 = 94;
              chArray4[index5] = (char) num5;
              if (Strings.Len(Strings.Mid(Strings.Trim(str4.Split(chArray4)[1]), 1, 8)) > 1)
              {
                PMS_DataImport pmsDataImport = this;
                string str5 = strArray1[index2];
                char[] chArray5 = new char[1];
                int index6 = 0;
                int num6 = 124;
                chArray5[index6] = (char) num6;
                string str6 = str5.Split(chArray5)[2];
                char[] chArray6 = new char[1];
                int index7 = 0;
                int num7 = 94;
                chArray6[index7] = (char) num7;
                string str7 = Strings.Mid(Strings.Trim(str6.Split(chArray6)[1]), 1, 8);
                pmsDataImport.TrackNumber = str7;
              }
              this.LISTrackNumber = this.TrackNumber;
              PMS_DataImport pmsDataImport1 = this;
              string str8 = strArray1[index2];
              char[] chArray7 = new char[1];
              int index8 = 0;
              int num8 = 124;
              chArray7[index8] = (char) num8;
              string str9 = str8.Split(chArray7)[2];
              char[] chArray8 = new char[1];
              int index9 = 0;
              int num9 = 94;
              chArray8[index9] = (char) num9;
              string str10 = Strings.Mid(Strings.Trim(str9.Split(chArray8)[1]), 9, 2);
              pmsDataImport1.SampleID = str10;
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.LISBarcode8Bit, "1", false) == 0)
              {
                this.SampleID = Strings.Right(this.TrackNumber.Trim(), 1);
                this.TrackNumber = Strings.Mid(DateTime.Now.ToString("yy"), 1, 1) + Strings.Left(this.TrackNumber.Trim(), 7);
              }
              else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.LISBarcode8Bit, "0", false) == 0)
                this.LISTrackNumber = this.TrackNumber + this.SampleID;
              this.UpdateText(this.TextBoxTrackForTestOrder, this.TrackNumber, false);
              this.AssayType = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.SampleID, "03", false) != 0 ? (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.SampleID, "04", false) != 0 ? "Serum" : "CSF") : "Urine";
              string[] strArray2 = new string[11];
              int index10 = 0;
              string str11 = "exec spTestListOnServiceTrackLISWithPatient @TrackNumber='";
              strArray2[index10] = str11;
              int index11 = 1;
              string str12 = this.TrackNumber;
              strArray2[index11] = str12;
              int index12 = 2;
              string str13 = "', @MachineName='";
              strArray2[index12] = str13;
              int index13 = 3;
              string str14 = this.MachineName;
              strArray2[index13] = str14;
              int index14 = 4;
              string str15 = "', @ExcludeExistingDBTest='";
              strArray2[index14] = str15;
              int index15 = 5;
              string str16 = Conversions.ToString(this.CheckBoxCheckTestInDBResult.Checked);
              strArray2[index15] = str16;
              int index16 = 6;
              string str17 = "', @SampleID='";
              strArray2[index16] = str17;
              int index17 = 7;
              string str18 = this.SampleID;
              strArray2[index17] = str18;
              int index18 = 8;
              string str19 = "', @AssayType='";
              strArray2[index18] = str19;
              int index19 = 9;
              string str20 = this.AssayType;
              strArray2[index19] = str20;
              int index20 = 10;
              string str21 = "'";
              strArray2[index20] = str21;
              RegisterMicrosoftVisualStudio.SqlText = string.Concat(strArray2);
              RegisterMicrosoftVisualStudio.da.SelectCommand = new OleDbCommand(RegisterMicrosoftVisualStudio.SqlText, RegisterMicrosoftVisualStudio.Conn);
              if (RegisterMicrosoftVisualStudio.ds.Tables["PatientTestList"] != null)
                RegisterMicrosoftVisualStudio.ds.Tables["PatientTestList"].Clear();
              ((DbDataAdapter) RegisterMicrosoftVisualStudio.da).Fill(RegisterMicrosoftVisualStudio.ds, "PatientTestList");
              DataTable dataTable = RegisterMicrosoftVisualStudio.ds.Tables["PatientTestList"];
              if (dataTable.Rows.Count < 1)
                return;
              PMS_DataImport pmsDataImport2 = this;
              object Instance1 = dataTable.Rows[0]["PatientName"];
              // ISSUE: variable of the null type
              __Null local1 = null;
              string MemberName = "Split";
              object[] Arguments1 = new object[1];
              int index21 = 0;
              string str22 = " ";
              Arguments1[index21] = (object) str22;
              // ISSUE: variable of the null type
              __Null local2 = null;
              // ISSUE: variable of the null type
              __Null local3 = null;
              // ISSUE: variable of the null type
              __Null local4 = null;
              object Instance2 = NewLateBinding.LateGet(Instance1, (System.Type) local1, MemberName, Arguments1, (string[]) local2, (System.Type[]) local3, (bool[]) local4);
              object[] Arguments2 = new object[1];
              int index22 = 0;
              // ISSUE: variable of a boxed type
              __Boxed<int> local5 = (System.ValueType) 0;
              Arguments2[index22] = (object) local5;
              // ISSUE: variable of the null type
              __Null local6 = null;
              string str23 = Strings.Mid(Conversions.ToString(NewLateBinding.LateIndexGet(Instance2, Arguments2, (string[]) local6)), 1, 20);
              pmsDataImport2.PatientName = str23;
              this.PatientBirthdate = Conversions.ToString(dataTable.Rows[0]["PatientBirthdate"]);
              this.PatientSex = Conversions.ToString(dataTable.Rows[0]["PatientSex"]);
              string str24 = "";
              int num10 = checked (dataTable.Rows.Count - 1);
              int index23 = 0;
              while (index23 <= num10)
              {
                str24 = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) (str24 + "\\^^^"), dataTable.Rows[index23]["TEST_CODE"]));
                checked { ++index23; }
              }
              StringBuilder stringBuilder1 = new StringBuilder();
              stringBuilder1.Append('\x0005');
              if (this.SerialPortImmulite2000.IsOpen)
                this.SerialPortImmulite2000.Write(stringBuilder1.ToString());
              this.UpdateText(this.TextBoxLISRespond, "\r\nSend ENQ\r\n", true);
              int FrameNumber = 1;
              int num11 = 0;
              do
              {
                StringBuilder stringBuilder2 = new StringBuilder();
                stringBuilder2.Append('\x0002');
                stringBuilder2.Append(FrameNumber);
                string OrderMsg;
                if (num11 == 0)
                  OrderMsg = "H|\\^&||||||||||P|1\r";
                else if (num11 == 1)
                {
                  string[] strArray3 = new string[9];
                  int index6 = 0;
                  string str5 = "P|1|";
                  strArray3[index6] = str5;
                  int index7 = 1;
                  string str6 = this.LISTrackNumber;
                  strArray3[index7] = str6;
                  int index24 = 2;
                  string str7 = "|||";
                  strArray3[index24] = str7;
                  int index25 = 3;
                  string str25 = this.PatientName;
                  strArray3[index25] = str25;
                  int index26 = 4;
                  string str26 = "||";
                  strArray3[index26] = str26;
                  int index27 = 5;
                  string str27 = this.PatientBirthdate;
                  strArray3[index27] = str27;
                  int index28 = 6;
                  string str28 = "|";
                  strArray3[index28] = str28;
                  int index29 = 7;
                  string str29 = this.PatientSex;
                  strArray3[index29] = str29;
                  int index30 = 8;
                  string str30 = "||||||||||||||||||\r";
                  strArray3[index30] = str30;
                  OrderMsg = string.Concat(strArray3);
                }
                else if (num11 == 2)
                {
                  string[] strArray3 = new string[5];
                  int index6 = 0;
                  string str5 = "O|1|";
                  strArray3[index6] = str5;
                  int index7 = 1;
                  string str6 = this.LISTrackNumber;
                  strArray3[index7] = str6;
                  int index24 = 2;
                  string str7 = "||";
                  strArray3[index24] = str7;
                  int index25 = 3;
                  string str25 = Strings.Mid(str24, 2);
                  strArray3[index25] = str25;
                  int index26 = 4;
                  string str26 = "|R|19931011091233|19931011091233||||||\r";
                  strArray3[index26] = str26;
                  OrderMsg = string.Concat(strArray3);
                }
                else
                  OrderMsg = "L|1|N\r";
                stringBuilder2.Append(OrderMsg);
                stringBuilder2.Append('\x0003');
                string str31 = this.CheckSumArchitectMachinSerialData(FrameNumber, OrderMsg, 0);
                stringBuilder2.Append(Strings.Left(str31, 1));
                stringBuilder2.Append(Strings.Right(str31, 1));
                stringBuilder2.Append('\r');
                stringBuilder2.Append('\n');
                checked { ++FrameNumber; }
                if (FrameNumber == 8)
                  FrameNumber = 0;
                if (this.SerialPortImmulite2000.IsOpen)
                {
                  this.SerialPortImmulite2000.Write(stringBuilder2.ToString());
                  this.UpdateText(this.TextBoxLISRespond, "\r\n" + OrderMsg + "\r\n", true);
                  if (FrameNumber == 5)
                    this.orderSend = "Order Send";
                }
                checked { ++num11; }
              }
              while (num11 <= 3);
              StringBuilder stringBuilder3 = new StringBuilder();
              stringBuilder3.Append('\x0004');
              if (this.SerialPortImmulite2000.IsOpen)
                this.SerialPortImmulite2000.Write(stringBuilder3.ToString());
              this.UpdateText(this.TextBoxLISRespond, "\r\nSend EOT\r\n", true);
            }
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left1, "R", false) == 0)
            {
              PMS_DataImport pmsDataImport1 = this;
              string str3 = strArray1[index2];
              char[] chArray3 = new char[1];
              int index4 = 0;
              int num4 = 124;
              chArray3[index4] = (char) num4;
              string str4 = str3.Split(chArray3)[2];
              char[] chArray4 = new char[1];
              int index5 = 0;
              int num5 = 94;
              chArray4[index5] = (char) num5;
              string str5 = str4.Split(chArray4)[3];
              pmsDataImport1.TestName = str5;
              this.LISTestCode = this.TestName;
              string str6 = strArray1[index2];
              char[] chArray5 = new char[1];
              int index6 = 0;
              int num6 = 124;
              chArray5[index6] = (char) num6;
              string Left2 = str6.Split(chArray5)[3];
              if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left2, "", false) > 0U)
              {
                PMS_DataImport pmsDataImport2 = this;
                TextBox textBoxLisData = this.TextBoxLISData;
                string[] strArray2 = new string[7];
                int index7 = 0;
                string str7 = "Track:";
                strArray2[index7] = str7;
                int index8 = 1;
                string str8 = this.TrackNumber;
                strArray2[index8] = str8;
                int index9 = 2;
                string str9 = " ";
                strArray2[index9] = str9;
                int index10 = 3;
                string str10 = this.TestName;
                strArray2[index10] = str10;
                int index11 = 4;
                string str11 = " : ";
                strArray2[index11] = str11;
                int index12 = 5;
                string str12 = Left2;
                strArray2[index12] = str12;
                int index13 = 6;
                string str13 = "\r\n";
                strArray2[index13] = str13;
                string txt = string.Concat(strArray2);
                int num7 = 1;
                pmsDataImport2.UpdateText(textBoxLisData, txt, num7 != 0);
              }
              DataRow[] dataRowArray = RegisterMicrosoftVisualStudio.ds.Tables["LISTestCodeList"].Select("Test_Name='" + this.TestName + "'");
              if (dataRowArray != null)
              {
                int upperBound = dataRowArray.GetUpperBound(0);
                int index7 = 0;
                while (index7 <= upperBound)
                {
                  this.TestCode = Conversions.ToString(dataRowArray[index7]["Test_Code"]);
                  if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.TestCode, "", false) > 0U & (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left2, "", false) > 0U && !this.ExistsDataTableSameRecord(this.TrackNumber, this.TestCode))
                  {
                    DataRowCollection rows = this.dtLISResult.Rows;
                    object[] objArray = new object[8];
                    int index8 = 0;
                    string str7 = this.PatientID;
                    objArray[index8] = (object) str7;
                    int index9 = 1;
                    string str8 = this.TrackNumber;
                    objArray[index9] = (object) str8;
                    int index10 = 2;
                    string str9 = this.TestCode;
                    objArray[index10] = (object) str9;
                    int index11 = 3;
                    string str10 = this.TestName;
                    objArray[index11] = (object) str10;
                    int index12 = 4;
                    string str11 = Left2;
                    objArray[index12] = (object) str11;
                    int index13 = 5;
                    string str12 = this.LISTestCode;
                    objArray[index13] = (object) str12;
                    int index14 = 6;
                    string str13 = "";
                    objArray[index14] = (object) str13;
                    int index15 = 7;
                    // ISSUE: variable of a boxed type
                    __Boxed<DateTime> local = (System.ValueType) this.LISMachineTestTime;
                    objArray[index15] = (object) local;
                    rows.Add(objArray);
                    if (this.dtLISResult.Rows.Count > 900)
                      this.SaveLISImportedData();
                  }
                  checked { ++index7; }
                }
              }
              this.SaveLISImportedData();
            }
            checked { ++index2; }
          }
          this.BufferData = "";
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.UpdateText(this.TextBoxLISData, "HandleData: " + ex.Message + "\r\n", true);
        ProjectData.ClearProjectError();
      }
    }

    private void AnalyzeBufferDataSiemensDimension(string QBuffer)
    {
      this.dtLISResult.Rows.Clear();
      try
      {
        this.SerialSignal = Conversions.ToString(Strings.AscW(Strings.Right(QBuffer, 1)));
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.SerialSignal, "4", false) == 0)
          this.UpdateText(this.TextBoxLISRespond, "Receive: EOT", false);
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.SerialSignal, "5", false) == 0)
          this.UpdateText(this.TextBoxLISRespond, "Receive: ENQ", false);
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.SerialSignal, "6", false) == 0)
          this.UpdateText(this.TextBoxLISRespond, "Receive: ACK", false);
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.SerialSignal, "21", false) == 0)
          this.UpdateText(this.TextBoxLISRespond, "Receive: NAK", false);
        if ((uint) Strings.InStr(QBuffer, "\x0003", CompareMethod.Binary) > 0U)
        {
          string str1 = QBuffer;
          char[] chArray1 = new char[1];
          int index1 = 0;
          int num1 = 2;
          chArray1[index1] = (char) num1;
          string[] strArray1 = str1.Split(chArray1);
          int num2 = Information.UBound((Array) strArray1, 1);
          int index2 = 1;
          while (index2 <= num2)
          {
            string Left1 = Conversions.ToString(strArray1[index2][0]);
            this.UpdateText(this.TextBoxLISRespond, "\r\n" + Left1, false);
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left1, "P", false) == 0)
            {
              StringBuilder stringBuilder = new StringBuilder();
              stringBuilder.Append('\x0002');
              stringBuilder.Append("N");
              stringBuilder.Append('\x001C');
              stringBuilder.Append("6");
              stringBuilder.Append("A");
              stringBuilder.Append('\x0003');
              if (this.SerialPortSiemensDimension.IsOpen)
                this.SerialPortSiemensDimension.Write(stringBuilder.ToString());
              this.UpdateText(this.TextBoxLISRespond, "Receive: POLL", true);
            }
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left1, "I", false) == 0)
            {
              PMS_DataImport pmsDataImport = this;
              string str2 = strArray1[1];
              char[] chArray2 = new char[1];
              int index3 = 0;
              int num3 = 28;
              chArray2[index3] = (char) num3;
              string str3 = Strings.Mid(str2.Split(chArray2)[1], 1, 8);
              pmsDataImport.TrackNumber = str3;
              this.LISTrackNumber = this.TrackNumber;
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.LISBarcode8Bit, "1", false) == 0)
              {
                this.SampleID = Strings.Right(this.TrackNumber.Trim(), 1);
                this.TrackNumber = Strings.Mid(DateTime.Now.ToString("yy"), 1, 1) + Strings.Left(this.TrackNumber.Trim(), 7);
              }
              else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.LISBarcode8Bit, "0", false) == 0)
                this.LISTrackNumber = this.TrackNumber + this.SampleID;
              this.UpdateText(this.TextBoxTrackForTestOrder, this.TrackNumber, false);
              if (Strings.Len(this.LISTrackNumber) == 8 | Strings.Len(this.LISTrackNumber) == 10)
              {
                string[] strArray2 = new string[11];
                int index4 = 0;
                string str4 = "exec spTestListOnServiceTrackLISWithPatient @TrackNumber='";
                strArray2[index4] = str4;
                int index5 = 1;
                string str5 = this.TrackNumber;
                strArray2[index5] = str5;
                int index6 = 2;
                string str6 = "', @MachineName='";
                strArray2[index6] = str6;
                int index7 = 3;
                string str7 = this.MachineName;
                strArray2[index7] = str7;
                int index8 = 4;
                string str8 = "', @ExcludeExistingDBTest='";
                strArray2[index8] = str8;
                int index9 = 5;
                string str9 = Conversions.ToString(this.CheckBoxCheckTestInDBResult.Checked);
                strArray2[index9] = str9;
                int index10 = 6;
                string str10 = "', @SampleID='";
                strArray2[index10] = str10;
                int index11 = 7;
                string str11 = this.SampleID;
                strArray2[index11] = str11;
                int index12 = 8;
                string str12 = "', @AssayType='";
                strArray2[index12] = str12;
                int index13 = 9;
                string str13 = this.AssayType;
                strArray2[index13] = str13;
                int index14 = 10;
                string str14 = "'";
                strArray2[index14] = str14;
                RegisterMicrosoftVisualStudio.SqlText = string.Concat(strArray2);
                RegisterMicrosoftVisualStudio.da.SelectCommand = new OleDbCommand(RegisterMicrosoftVisualStudio.SqlText, RegisterMicrosoftVisualStudio.Conn);
                if (RegisterMicrosoftVisualStudio.ds.Tables["PatientTestList"] != null)
                  RegisterMicrosoftVisualStudio.ds.Tables["PatientTestList"].Clear();
                ((DbDataAdapter) RegisterMicrosoftVisualStudio.da).Fill(RegisterMicrosoftVisualStudio.ds, "PatientTestList");
                if (RegisterMicrosoftVisualStudio.ds.Tables["PatientTestList"].Rows.Count == 0)
                  return;
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append('\x0002');
                stringBuilder.Append("D");
                stringBuilder.Append('\x001C');
                stringBuilder.Append("0");
                stringBuilder.Append('\x001C');
                stringBuilder.Append("0");
                stringBuilder.Append('\x001C');
                stringBuilder.Append("A");
                stringBuilder.Append('\x001C');
                stringBuilder.Append("");
                stringBuilder.Append('\x001C');
                stringBuilder.Append(this.LISTrackNumber);
                stringBuilder.Append('\x001C');
                stringBuilder.Append("1");
                stringBuilder.Append('\x001C');
                stringBuilder.Append('\x001C');
                stringBuilder.Append("0");
                stringBuilder.Append('\x001C');
                stringBuilder.Append("1");
                stringBuilder.Append('\x001C');
                stringBuilder.Append("**");
                stringBuilder.Append('\x001C');
                stringBuilder.Append("1");
                stringBuilder.Append('\x001C');
                stringBuilder.Append(RegisterMicrosoftVisualStudio.ds.Tables["PatientTestList"].Rows.Count);
                stringBuilder.Append('\x001C');
                int num4 = checked (RegisterMicrosoftVisualStudio.ds.Tables["PatientTestList"].Rows.Count - 1);
                int index15 = 0;
                while (index15 <= num4)
                {
                  stringBuilder.Append(RuntimeHelpers.GetObjectValue(RegisterMicrosoftVisualStudio.ds.Tables["PatientTestList"].Rows[index15]["TEST_CODE"]));
                  stringBuilder.Append('\x001C');
                  checked { ++index15; }
                }
                string str15 = this.CheckSumSeimensDimensionSerialData(stringBuilder.ToString().Replace("\x0002", ""));
                stringBuilder.Append(Strings.Left(str15, 1));
                stringBuilder.Append(Strings.Right(str15, 1));
                stringBuilder.Append('\x0003');
                if (this.SerialPortSiemensDimension.IsOpen)
                  this.SerialPortSiemensDimension.Write(stringBuilder.ToString());
                this.UpdateText(this.TextBoxLISRespond, "Send: Order", true);
              }
              else
              {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append('\x0002');
                stringBuilder.Append("N");
                stringBuilder.Append('\x001C');
                stringBuilder.Append("6");
                stringBuilder.Append("A");
                stringBuilder.Append('\x0003');
                if (this.SerialPortSiemensDimension.IsOpen)
                  this.SerialPortSiemensDimension.Write(stringBuilder.ToString());
                this.UpdateText(this.TextBoxLISRespond, "Send: No Order", true);
              }
            }
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left1, "R", false) == 0)
            {
              PMS_DataImport pmsDataImport1 = this;
              string str2 = strArray1[1];
              char[] chArray2 = new char[1];
              int index3 = 0;
              int num3 = 28;
              chArray2[index3] = (char) num3;
              string str3 = str2.Split(chArray2)[2];
              pmsDataImport1.PatientID = str3;
              PMS_DataImport pmsDataImport2 = this;
              string str4 = strArray1[1];
              char[] chArray3 = new char[1];
              int index4 = 0;
              int num4 = 28;
              chArray3[index4] = (char) num4;
              string str5 = str4.Split(chArray3)[3];
              pmsDataImport2.TrackNumber = str5;
              string str6 = strArray1[1];
              char[] chArray4 = new char[1];
              int index5 = 0;
              int num5 = 28;
              chArray4[index5] = (char) num5;
              int num6 = checked ((int) Math.Round(Conversion.Val(str6.Split(chArray4)[10])) - 1);
              int num7 = 0;
              while (num7 <= num6)
              {
                PMS_DataImport pmsDataImport3 = this;
                string str7 = strArray1[1];
                char[] chArray5 = new char[1];
                int index6 = 0;
                int num8 = 28;
                chArray5[index6] = (char) num8;
                string str8 = str7.Split(chArray5)[checked (11 + num7 * 4)];
                pmsDataImport3.TestName = str8;
                PMS_DataImport pmsDataImport4 = this;
                string str9 = strArray1[1];
                char[] chArray6 = new char[1];
                int index7 = 0;
                int num9 = 28;
                chArray6[index7] = (char) num9;
                string str10 = str9.Split(chArray6)[checked (11 + num7 * 4)];
                pmsDataImport4.LISTestCode = str10;
                string str11 = strArray1[1];
                char[] chArray7 = new char[1];
                int index8 = 0;
                int num10 = 28;
                chArray7[index8] = (char) num10;
                string Left2 = str11.Split(chArray7)[checked (12 + num7 * 4)];
                if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left2, "", false) > 0U)
                {
                  PMS_DataImport pmsDataImport5 = this;
                  TextBox textBoxLisData = this.TextBoxLISData;
                  string[] strArray2 = new string[7];
                  int index9 = 0;
                  string str12 = "Track:";
                  strArray2[index9] = str12;
                  int index10 = 1;
                  string str13 = this.TrackNumber;
                  strArray2[index10] = str13;
                  int index11 = 2;
                  string str14 = " ";
                  strArray2[index11] = str14;
                  int index12 = 3;
                  string str15 = this.TestName;
                  strArray2[index12] = str15;
                  int index13 = 4;
                  string str16 = " : ";
                  strArray2[index13] = str16;
                  int index14 = 5;
                  string str17 = Left2;
                  strArray2[index14] = str17;
                  int index15 = 6;
                  string str18 = "\r\n";
                  strArray2[index15] = str18;
                  string txt = string.Concat(strArray2);
                  int num11 = 1;
                  pmsDataImport5.UpdateText(textBoxLisData, txt, num11 != 0);
                }
                DataRow[] dataRowArray = RegisterMicrosoftVisualStudio.ds.Tables["LISTestCodeList"].Select("Test_Name='" + this.TestName + "'");
                if (dataRowArray != null)
                {
                  int upperBound = dataRowArray.GetUpperBound(0);
                  int index9 = 0;
                  while (index9 <= upperBound)
                  {
                    this.TestCode = Conversions.ToString(dataRowArray[index9]["Test_Code"]);
                    if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.TestCode, "", false) > 0U & (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left2, "", false) > 0U && !this.ExistsDataTableSameRecord(this.TrackNumber, this.TestCode))
                    {
                      DataRowCollection rows = this.dtLISResult.Rows;
                      object[] objArray = new object[8];
                      int index10 = 0;
                      string str12 = this.PatientID;
                      objArray[index10] = (object) str12;
                      int index11 = 1;
                      string str13 = this.TrackNumber;
                      objArray[index11] = (object) str13;
                      int index12 = 2;
                      string str14 = this.TestCode;
                      objArray[index12] = (object) str14;
                      int index13 = 3;
                      string str15 = this.TestName;
                      objArray[index13] = (object) str15;
                      int index14 = 4;
                      string str16 = Left2;
                      objArray[index14] = (object) str16;
                      int index15 = 5;
                      string str17 = this.LISTestCode;
                      objArray[index15] = (object) str17;
                      int index16 = 6;
                      string str18 = "";
                      objArray[index16] = (object) str18;
                      int index17 = 7;
                      // ISSUE: variable of a boxed type
                      __Boxed<DateTime> local = (System.ValueType) this.LISMachineTestTime;
                      objArray[index17] = (object) local;
                      rows.Add(objArray);
                      if (this.dtLISResult.Rows.Count > 900)
                        this.SaveLISImportedData();
                    }
                    checked { ++index9; }
                  }
                }
                this.SaveLISImportedData();
                checked { ++num7; }
              }
              StringBuilder stringBuilder = new StringBuilder();
              stringBuilder.Append('\x0002');
              stringBuilder.Append("M");
              stringBuilder.Append('\x001C');
              stringBuilder.Append("A");
              stringBuilder.Append('\x001C');
              stringBuilder.Append('\x001C');
              stringBuilder.Append("E");
              stringBuilder.Append("2");
              stringBuilder.Append('\x0003');
              if (this.SerialPortSiemensDimension.IsOpen)
                this.SerialPortSiemensDimension.Write(stringBuilder.ToString());
              this.UpdateText(this.TextBoxLISRespond, "Send: Result Message", true);
            }
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left1, "C", false) == 0)
            {
              StringBuilder stringBuilder = new StringBuilder();
              stringBuilder.Append('\x0002');
              stringBuilder.Append("M");
              stringBuilder.Append('\x001C');
              stringBuilder.Append("A");
              stringBuilder.Append('\x001C');
              stringBuilder.Append('\x001C');
              stringBuilder.Append("E");
              stringBuilder.Append("2");
              stringBuilder.Append('\x0003');
              if (this.SerialPortSiemensDimension.IsOpen)
                this.SerialPortSiemensDimension.Write(stringBuilder.ToString());
              this.UpdateText(this.TextBoxLISRespond, "Send: Calibration Message", true);
            }
            checked { ++index2; }
          }
          this.BufferData = "";
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.UpdateText(this.TextBoxLISData, "HandleData: " + ex.Message + "\r\n", true);
        ProjectData.ClearProjectError();
      }
    }

    private string HandleSerialMessage1(string data)
    {
      StringBuilder stringBuilder = new StringBuilder();
      stringBuilder.Append('\x0006');
      return stringBuilder.ToString();
    }

    private string HandleSerialMessage2(string data)
    {
      StringBuilder stringBuilder = new StringBuilder();
      stringBuilder.Append('\v');
      stringBuilder.Append('\x001C');
      stringBuilder.Append('\r');
      return stringBuilder.ToString();
    }

    private void HandleArchitectMachinSerialData(string[] pSerialData)
    {
      string str1 = "";
      try
      {
        this.dtLISResult.Rows.Clear();
        int num1 = checked (Information.UBound((Array) pSerialData, 1) - 1);
        int index1 = 0;
        while (index1 <= num1)
        {
          string str2 = pSerialData[index1];
          char[] chArray1 = new char[1];
          int index2 = 0;
          int num2 = 124;
          chArray1[index2] = (char) num2;
          string Left1 = Strings.Right(str2.Split(chArray1)[0], 1);
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left1, "O", false) == 0)
          {
            PMS_DataImport pmsDataImport = this;
            string str3 = pSerialData[index1];
            char[] chArray2 = new char[1];
            int index3 = 0;
            int num3 = 124;
            chArray2[index3] = (char) num3;
            string str4 = str3.Split(chArray2)[2];
            pmsDataImport.TrackNumber = str4;
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.LISBarcode8Bit, "1", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.LISBarcode8Bit, "True", false) == 0)
              this.TrackNumber = Strings.Mid(DateTime.Now.ToString("yy"), 1, 1) + Strings.Left(this.TrackNumber.Trim(), 7);
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left1, "R", false) == 0)
          {
            string str3 = pSerialData[index1];
            char[] chArray2 = new char[1];
            int index3 = 0;
            int num3 = 124;
            chArray2[index3] = (char) num3;
            string str4 = str3.Split(chArray2)[2];
            char[] chArray3 = new char[1];
            int index4 = 0;
            int num4 = 94;
            chArray3[index4] = (char) num4;
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str4.Split(chArray3)[10], "F", false) == 0)
            {
              PMS_DataImport pmsDataImport1 = this;
              string str5 = pSerialData[index1];
              char[] chArray4 = new char[1];
              int index5 = 0;
              int num5 = 124;
              chArray4[index5] = (char) num5;
              string str6 = str5.Split(chArray4)[2];
              char[] chArray5 = new char[1];
              int index6 = 0;
              int num6 = 94;
              chArray5[index6] = (char) num6;
              string str7 = str6.Split(chArray5)[4];
              pmsDataImport1.TestName = str7;
              PMS_DataImport pmsDataImport2 = this;
              string str8 = "000";
              string str9 = pSerialData[index1];
              char[] chArray6 = new char[1];
              int index7 = 0;
              int num7 = 124;
              chArray6[index7] = (char) num7;
              string str10 = str9.Split(chArray6)[2];
              char[] chArray7 = new char[1];
              int index8 = 0;
              int num8 = 94;
              chArray7[index8] = (char) num8;
              string str11 = str10.Split(chArray7)[3];
              string str12 = Strings.Right(str8 + str11, 4);
              pmsDataImport2.LISTestCode = str12;
              string str13 = pSerialData[index1];
              char[] chArray8 = new char[1];
              int index9 = 0;
              int num9 = 124;
              chArray8[index9] = (char) num9;
              string Left2 = str13.Split(chArray8)[3];
              PMS_DataImport pmsDataImport3 = this;
              TextBox textBoxLisData = this.TextBoxLISData;
              string[] strArray = new string[7];
              int index10 = 0;
              string str14 = "Track:";
              strArray[index10] = str14;
              int index11 = 1;
              string str15 = this.TrackNumber;
              strArray[index11] = str15;
              int index12 = 2;
              string str16 = " ";
              strArray[index12] = str16;
              int index13 = 3;
              string str17 = this.TestName;
              strArray[index13] = str17;
              int index14 = 4;
              string str18 = " : ";
              strArray[index14] = str18;
              int index15 = 5;
              string str19 = Left2;
              strArray[index15] = str19;
              int index16 = 6;
              string str20 = "\r\n";
              strArray[index16] = str20;
              string txt = string.Concat(strArray);
              int num10 = 1;
              pmsDataImport3.UpdateText(textBoxLisData, txt, num10 != 0);
              DataRow[] dataRowArray = RegisterMicrosoftVisualStudio.ds.Tables["LISTestCodeList"].Select("Test_Name='" + this.TestName + "'");
              if (dataRowArray != null)
              {
                int upperBound = dataRowArray.GetUpperBound(0);
                int index17 = 0;
                while (index17 <= upperBound)
                {
                  this.TestCode = Conversions.ToString(dataRowArray[index17]["Test_Code"]);
                  if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.TestCode, "", false) > 0U & (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left2, "", false) > 0U && !this.ExistsDataTableSameRecord(this.TrackNumber, this.TestCode))
                  {
                    DataRowCollection rows = this.dtLISResult.Rows;
                    object[] objArray = new object[8];
                    int index18 = 0;
                    string str21 = this.PatientID;
                    objArray[index18] = (object) str21;
                    int index19 = 1;
                    string str22 = this.TrackNumber;
                    objArray[index19] = (object) str22;
                    int index20 = 2;
                    string str23 = this.TestCode;
                    objArray[index20] = (object) str23;
                    int index21 = 3;
                    string str24 = this.TestName;
                    objArray[index21] = (object) str24;
                    int index22 = 4;
                    string str25 = Left2;
                    objArray[index22] = (object) str25;
                    int index23 = 5;
                    string str26 = this.LISTestCode;
                    objArray[index23] = (object) str26;
                    int index24 = 6;
                    string str27 = "";
                    objArray[index24] = (object) str27;
                    int index25 = 7;
                    // ISSUE: variable of a boxed type
                    __Boxed<DateTime> local = (System.ValueType) this.LISMachineTestTime;
                    objArray[index25] = (object) local;
                    rows.Add(objArray);
                    if (this.dtLISResult.Rows.Count > 900)
                      this.SaveLISImportedData();
                  }
                  checked { ++index17; }
                }
              }
            }
            this.SaveLISImportedData();
          }
          checked { ++index1; }
        }
        pSerialData = (string[]) null;
        str1 = (string) null;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.UpdateText(this.TextBoxLISData, "HandleData: " + ex.Message + "\r\n", true);
        ProjectData.ClearProjectError();
      }
    }

    private void HandleRubiMachinSerialData(string[] pSerialData)
    {
      string str1 = "";
      string str2;
      try
      {
        this.dtLISResult.Rows.Clear();
        int num1 = checked (Information.UBound((Array) pSerialData, 1) - 1);
        int index1 = 0;
        while (index1 <= num1)
        {
          string str3 = pSerialData[index1];
          char[] chArray1 = new char[1];
          int index2 = 0;
          int num2 = 124;
          chArray1[index2] = (char) num2;
          string Left1 = Strings.Right(str3.Split(chArray1)[0], 1);
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left1, "O", false) == 0)
          {
            PMS_DataImport pmsDataImport = this;
            string str4 = pSerialData[index1];
            char[] chArray2 = new char[1];
            int index3 = 0;
            int num3 = 124;
            chArray2[index3] = (char) num3;
            string str5 = str4.Split(chArray2)[2];
            char[] chArray3 = new char[1];
            int index4 = 0;
            int num4 = 94;
            chArray3[index4] = (char) num4;
            string str6 = str5.Split(chArray3)[0];
            pmsDataImport.TrackNumber = str6;
            this.PatientID = this.TrackNumber;
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.LISBarcode8Bit, "1", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.LISBarcode8Bit, "True", false) == 0)
              this.TrackNumber = Strings.Mid(DateTime.Now.ToString("yy"), 1, 1) + Strings.Left(this.TrackNumber.Trim(), 7);
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left1, "R", false) == 0)
          {
            PMS_DataImport pmsDataImport1 = this;
            string str4 = pSerialData[index1];
            char[] chArray2 = new char[1];
            int index3 = 0;
            int num3 = 124;
            chArray2[index3] = (char) num3;
            string str5 = str4.Split(chArray2)[2];
            char[] chArray3 = new char[1];
            int index4 = 0;
            int num4 = 94;
            chArray3[index4] = (char) num4;
            string str6 = str5.Split(chArray3)[6];
            pmsDataImport1.TestName = str6;
            PMS_DataImport pmsDataImport2 = this;
            string str7 = pSerialData[index1];
            char[] chArray4 = new char[1];
            int index5 = 0;
            int num5 = 124;
            chArray4[index5] = (char) num5;
            string str8 = str7.Split(chArray4)[2];
            char[] chArray5 = new char[1];
            int index6 = 0;
            int num6 = 94;
            chArray5[index6] = (char) num6;
            string str9 = str8.Split(chArray5)[6];
            pmsDataImport2.LISTestCode = str9;
            string str10 = pSerialData[index1];
            char[] chArray6 = new char[1];
            int index7 = 0;
            int num7 = 124;
            chArray6[index7] = (char) num7;
            string Left2 = str10.Split(chArray6)[3];
            TextBox textBoxLisData = this.TextBoxLISData;
            string[] strArray = new string[7];
            int index8 = 0;
            string str11 = "Track:";
            strArray[index8] = str11;
            int index9 = 1;
            string str12 = this.TrackNumber;
            strArray[index9] = str12;
            int index10 = 2;
            string str13 = " ";
            strArray[index10] = str13;
            int index11 = 3;
            string str14 = this.TestName;
            strArray[index11] = str14;
            int index12 = 4;
            string str15 = " : ";
            strArray[index12] = str15;
            int index13 = 5;
            string str16 = Left2;
            strArray[index13] = str16;
            int index14 = 6;
            string str17 = "\r\n";
            strArray[index14] = str17;
            string text = string.Concat(strArray);
            textBoxLisData.AppendText(text);
            DataRow[] dataRowArray = RegisterMicrosoftVisualStudio.ds.Tables["LISTestCodeList"].Select("Test_Name='" + this.TestName + "'");
            if (dataRowArray != null)
            {
              int upperBound = dataRowArray.GetUpperBound(0);
              int index15 = 0;
              while (index15 <= upperBound)
              {
                this.TestCode = Conversions.ToString(dataRowArray[index15]["Test_Code"]);
                if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.TestCode, "", false) > 0U & (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left2, "", false) > 0U && !this.ExistsDataTableSameRecord(this.TrackNumber, this.TestCode))
                {
                  DataRowCollection rows = this.dtLISResult.Rows;
                  object[] objArray = new object[8];
                  int index16 = 0;
                  string str18 = this.PatientID;
                  objArray[index16] = (object) str18;
                  int index17 = 1;
                  string str19 = this.TrackNumber;
                  objArray[index17] = (object) str19;
                  int index18 = 2;
                  string str20 = this.TestCode;
                  objArray[index18] = (object) str20;
                  int index19 = 3;
                  string str21 = this.TestName;
                  objArray[index19] = (object) str21;
                  int index20 = 4;
                  string str22 = Left2;
                  objArray[index20] = (object) str22;
                  int index21 = 5;
                  string str23 = this.LISTestCode;
                  objArray[index21] = (object) str23;
                  int index22 = 6;
                  string str24 = "";
                  objArray[index22] = (object) str24;
                  int index23 = 7;
                  // ISSUE: variable of a boxed type
                  __Boxed<DateTime> local = (System.ValueType) this.LISMachineTestTime;
                  objArray[index23] = (object) local;
                  rows.Add(objArray);
                  if (this.dtLISResult.Rows.Count > 900)
                    this.SaveLISImportedData();
                }
                checked { ++index15; }
              }
            }
            this.SaveLISImportedData();
          }
          checked { ++index1; }
        }
        pSerialData = (string[]) null;
        str2 = (string) null;
        str1 = (string) null;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        pSerialData = (string[]) null;
        str2 = (string) null;
        str1 = (string) null;
        int num = (int) MessageBox.Show(exception.Message);
        ProjectData.ClearProjectError();
      }
    }

    private string getFormatedValue(string MachineValue, string pTestCode)
    {
      string str;
      try
      {
        str = Math.Round(Conversions.ToDouble(Strings.Replace(Strings.Replace(MachineValue, "---", "", 1, -1, CompareMethod.Binary), "*", "", 1, -1, CompareMethod.Binary)), Conversions.ToInteger(RegisterMicrosoftVisualStudio.GetSingleData("Testsetup", "TestResultRoundTo", "Select top 1 coalesce(TestResultRoundTo,5) As TestResultRoundTo from TestSetup Where Test_Code='" + pTestCode + "'"))).ToString();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        str = MachineValue;
        ProjectData.ClearProjectError();
      }
      return str;
    }

    private string CheckSumArchitectMachinSerialData(int FrameNumber, string OrderMsg, int EOF_Message)
    {
      Decimal d1 = new Decimal();
      d1 = new Decimal(Strings.Asc(Conversions.ToString(FrameNumber)));
      int num = checked (OrderMsg.Length - 1);
      int index = 0;
      while (index <= num)
      {
        d1 = Decimal.Add(d1, new Decimal(Strings.Asc(OrderMsg[index])));
        checked { ++index; }
      }
      return Strings.Right(Conversion.Hex((object) (EOF_Message != 0 ? Decimal.Add(d1, new Decimal(23L)) : Decimal.Add(d1, new Decimal(3L)))), 2);
    }

    public string[] SplitString(string TheString, int StringLen)
    {
      string[] strArray = new string[checked (unchecked (checked (Strings.Len(TheString) - 1) / StringLen) + 1)];
      long num1 = (long) Strings.Len(TheString);
      long num2 = (long) StringLen;
      long num3 = 1L;
      while ((num2 >> 63 ^ num3) <= (num2 >> 63 ^ num1))
      {
        int index;
        strArray[index] = Strings.Mid(TheString, checked ((int) num3), StringLen);
        checked { ++index; }
        checked { num3 += num2; }
      }
      return strArray;
    }

    private void HandleHL7Data_Hemaray(string QBuffer)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(QBuffer, "", false) == 0)
        return;
      if (!Information.IsNothing((object) this.server))
        this.server.IsListining = false;
      string str1 = QBuffer;
      if (Strings.InStr(str1, "MSH|", CompareMethod.Binary) < 1)
        return;
      try
      {
        string str2 = str1;
        char[] chArray1 = new char[1];
        int index1 = 0;
        int num1 = 77;
        chArray1[index1] = (char) num1;
        string str3 = str2.Split(chArray1)[1];
        char[] chArray2 = new char[1];
        int index2 = 0;
        int num2 = 13;
        chArray2[index2] = (char) num2;
        string str4 = str3.Split(chArray2)[0];
        char[] chArray3 = new char[1];
        int index3 = 0;
        int num3 = 124;
        chArray3[index3] = (char) num3;
        string[] strArray1 = str4.Split(chArray3);
        if (Strings.InStr(str1, "OBR|", CompareMethod.Binary) < 1)
        {
          this.TrackNumber = strArray1[9];
        }
        else
        {
          PMS_DataImport pmsDataImport1 = this;
          string str5 = Strings.Split(str1, "OBR|", -1, CompareMethod.Text)[1];
          char[] chArray4 = new char[1];
          int index4 = 0;
          int num4 = 124;
          chArray4[index4] = (char) num4;
          string str6 = Strings.Mid(str5.Split(chArray4)[2], 1, 8);
          pmsDataImport1.TrackNumber = str6;
          this.LISTrackNumber = this.TrackNumber;
          PMS_DataImport pmsDataImport2 = this;
          string str7 = Strings.Split(str1, "OBR|", -1, CompareMethod.Text)[1];
          char[] chArray5 = new char[1];
          int index5 = 0;
          int num5 = 124;
          chArray5[index5] = (char) num5;
          string str8 = Strings.Mid(str7.Split(chArray5)[2], 9);
          pmsDataImport2.SampleID = str8;
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.LISBarcode8Bit, "1", false) == 0)
          {
            this.SampleID = Strings.Right(this.TrackNumber.Trim(), 1);
            this.TrackNumber = Strings.Mid(DateTime.Now.ToString("yy"), 1, 1) + Strings.Left(this.TrackNumber.Trim(), 7);
          }
          else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.LISBarcode8Bit, "0", false) == 0)
          {
            PMS_DataImport pmsDataImport3 = this;
            string str9 = Strings.Split(str1, "OBR|", -1, CompareMethod.Text)[1];
            char[] chArray6 = new char[1];
            int index6 = 0;
            int num6 = 124;
            chArray6[index6] = (char) num6;
            string str10 = Strings.Mid(str9.Split(chArray6)[2], 3, 8);
            pmsDataImport3.TrackNumber = str10;
            PMS_DataImport pmsDataImport4 = this;
            string str11 = Strings.Split(str1, "OBR|", -1, CompareMethod.Text)[1];
            char[] chArray7 = new char[1];
            int index7 = 0;
            int num7 = 124;
            chArray7[index7] = (char) num7;
            string str12 = Strings.Mid(str11.Split(chArray7)[2], 1, 2);
            pmsDataImport4.SampleID = str12;
            this.LISTrackNumber = this.SampleID + this.TrackNumber;
          }
        }
        if (Strings.InStr(str1, "OBX|", CompareMethod.Binary) > 0)
        {
          string str5 = str1.Substring(checked (Strings.InStr(str1, "OBX|", CompareMethod.Binary) - 1));
          char[] chArray4 = new char[1];
          int index4 = 0;
          int num4 = 13;
          chArray4[index4] = (char) num4;
          string[] strArray2 = str5.Split(chArray4);
          int num5 = Information.UBound((Array) strArray2, 1);
          int index5 = 0;
          while (index5 <= num5)
          {
            string str6 = strArray2[index5];
            char[] chArray5 = new char[1];
            int index6 = 0;
            int num6 = 124;
            chArray5[index6] = (char) num6;
            string[] strArray3 = str6.Split(chArray5);
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(strArray3[0].Trim(), "OBX", false) == 0)
            {
              this.TestName = strArray3[3];
              this.LISTestCode = this.TestName;
              string Left = strArray3[5];
              if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "", false) > 0U)
              {
                PMS_DataImport pmsDataImport = this;
                TextBox textBoxLisData = this.TextBoxLISData;
                string[] strArray4 = new string[7];
                int index7 = 0;
                string str7 = "Track:";
                strArray4[index7] = str7;
                int index8 = 1;
                string str8 = this.TrackNumber;
                strArray4[index8] = str8;
                int index9 = 2;
                string str9 = " ";
                strArray4[index9] = str9;
                int index10 = 3;
                string str10 = this.TestName;
                strArray4[index10] = str10;
                int index11 = 4;
                string str11 = " : ";
                strArray4[index11] = str11;
                int index12 = 5;
                string str12 = Left;
                strArray4[index12] = str12;
                int index13 = 6;
                string str13 = "\r\n";
                strArray4[index13] = str13;
                string txt = string.Concat(strArray4);
                int num7 = 1;
                pmsDataImport.UpdateText(textBoxLisData, txt, num7 != 0);
              }
              DataRow[] dataRowArray = RegisterMicrosoftVisualStudio.ds.Tables["LISTestCodeList"].Select("Test_Name='" + this.TestName + "'");
              if (dataRowArray != null)
              {
                int upperBound = dataRowArray.GetUpperBound(0);
                int index7 = 0;
                while (index7 <= upperBound)
                {
                  this.TestCode = Conversions.ToString(dataRowArray[index7]["Test_Code"]);
                  if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.TestCode, "", false) > 0U & (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "", false) > 0U && !this.ExistsDataTableSameRecord(this.TrackNumber, this.TestCode))
                  {
                    DataRowCollection rows = this.dtLISResult.Rows;
                    object[] objArray = new object[8];
                    int index8 = 0;
                    string str7 = this.PatientID;
                    objArray[index8] = (object) str7;
                    int index9 = 1;
                    string str8 = this.TrackNumber;
                    objArray[index9] = (object) str8;
                    int index10 = 2;
                    string str9 = this.TestCode;
                    objArray[index10] = (object) str9;
                    int index11 = 3;
                    string str10 = this.TestName;
                    objArray[index11] = (object) str10;
                    int index12 = 4;
                    string str11 = Left;
                    objArray[index12] = (object) str11;
                    int index13 = 5;
                    string str12 = this.LISTestCode;
                    objArray[index13] = (object) str12;
                    int index14 = 6;
                    string str13 = "";
                    objArray[index14] = (object) str13;
                    int index15 = 7;
                    // ISSUE: variable of a boxed type
                    __Boxed<DateTime> local = (System.ValueType) this.LISMachineTestTime;
                    objArray[index15] = (object) local;
                    rows.Add(objArray);
                    if (this.dtLISResult.Rows.Count > 900)
                      this.SaveLISImportedData();
                  }
                  checked { ++index7; }
                }
              }
              this.BufferData = "";
            }
            checked { ++index5; }
          }
          this.SaveLISImportedData();
          if (this.CheckBoxLIS.Checked & !Information.IsNothing((object) this.server))
            this.server.IsListining = true;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) MessageBox.Show(ex.Message, RegisterMicrosoftVisualStudio.mazedatech);
        ProjectData.ClearProjectError();
      }
    }

    private void HandleHL7Data_Chemray(string QBuffer)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(QBuffer, "", false) == 0)
        return;
      if (!Information.IsNothing((object) this.server))
        this.server.IsListining = false;
      string str1 = QBuffer;
      try
      {
        string str2 = str1;
        char[] chArray1 = new char[1];
        int index1 = 0;
        int num1 = 77;
        chArray1[index1] = (char) num1;
        string str3 = str2.Split(chArray1)[1];
        char[] chArray2 = new char[1];
        int index2 = 0;
        int num2 = 13;
        chArray2[index2] = (char) num2;
        string str4 = str3.Split(chArray2)[0];
        char[] chArray3 = new char[1];
        int index3 = 0;
        int num3 = 124;
        chArray3[index3] = (char) num3;
        string[] strArray1 = str4.Split(chArray3);
        if (Strings.InStr(str1, "OBR|", CompareMethod.Binary) < 1)
        {
          this.TrackNumber = strArray1[9];
        }
        else
        {
          PMS_DataImport pmsDataImport1 = this;
          string str5 = Strings.Split(str1, "OBR|", -1, CompareMethod.Text)[1];
          char[] chArray4 = new char[1];
          int index4 = 0;
          int num4 = 124;
          chArray4[index4] = (char) num4;
          string str6 = Strings.Mid(str5.Split(chArray4)[2], 1, 8);
          pmsDataImport1.TrackNumber = str6;
          this.LISTrackNumber = this.TrackNumber;
          PMS_DataImport pmsDataImport2 = this;
          string str7 = Strings.Split(str1, "OBR|", -1, CompareMethod.Text)[1];
          char[] chArray5 = new char[1];
          int index5 = 0;
          int num5 = 124;
          chArray5[index5] = (char) num5;
          string str8 = Strings.Mid(str7.Split(chArray5)[2], 9);
          pmsDataImport2.SampleID = str8;
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.LISBarcode8Bit, "1", false) == 0)
          {
            this.SampleID = Strings.Right(this.TrackNumber.Trim(), 1);
            this.TrackNumber = Strings.Mid(DateTime.Now.ToString("yy"), 1, 1) + Strings.Left(this.TrackNumber.Trim(), 7);
          }
          else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.LISBarcode8Bit, "0", false) == 0)
          {
            PMS_DataImport pmsDataImport3 = this;
            string str9 = Strings.Split(str1, "OBR|", -1, CompareMethod.Text)[1];
            char[] chArray6 = new char[1];
            int index6 = 0;
            int num6 = 124;
            chArray6[index6] = (char) num6;
            string str10 = Strings.Mid(str9.Split(chArray6)[2], 3, 8);
            pmsDataImport3.TrackNumber = str10;
            PMS_DataImport pmsDataImport4 = this;
            string str11 = Strings.Split(str1, "OBR|", -1, CompareMethod.Text)[1];
            char[] chArray7 = new char[1];
            int index7 = 0;
            int num7 = 124;
            chArray7[index7] = (char) num7;
            string str12 = Strings.Mid(str11.Split(chArray7)[2], 1, 2);
            pmsDataImport4.SampleID = str12;
            this.LISTrackNumber = this.SampleID + this.TrackNumber;
          }
        }
        if (Strings.InStr(str1, "OBX|", CompareMethod.Binary) > 0)
        {
          string str5 = str1.Substring(checked (Strings.InStr(str1, "OBX|", CompareMethod.Binary) - 1));
          char[] chArray4 = new char[1];
          int index4 = 0;
          int num4 = 13;
          chArray4[index4] = (char) num4;
          string[] strArray2 = str5.Split(chArray4);
          int num5 = Information.UBound((Array) strArray2, 1);
          int index5 = 0;
          while (index5 <= num5)
          {
            string str6 = strArray2[index5];
            char[] chArray5 = new char[1];
            int index6 = 0;
            int num6 = 124;
            chArray5[index6] = (char) num6;
            string[] strArray3 = str6.Split(chArray5);
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(strArray3[0].Trim(), "OBX", false) == 0)
            {
              this.TestName = strArray3[4];
              this.LISTestCode = this.TestName;
              string Left = strArray3[5];
              if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "", false) > 0U)
              {
                PMS_DataImport pmsDataImport = this;
                TextBox textBoxLisData = this.TextBoxLISData;
                string[] strArray4 = new string[7];
                int index7 = 0;
                string str7 = "Track:";
                strArray4[index7] = str7;
                int index8 = 1;
                string str8 = this.TrackNumber;
                strArray4[index8] = str8;
                int index9 = 2;
                string str9 = " ";
                strArray4[index9] = str9;
                int index10 = 3;
                string str10 = this.TestName;
                strArray4[index10] = str10;
                int index11 = 4;
                string str11 = " : ";
                strArray4[index11] = str11;
                int index12 = 5;
                string str12 = Left;
                strArray4[index12] = str12;
                int index13 = 6;
                string str13 = "\r\n";
                strArray4[index13] = str13;
                string txt = string.Concat(strArray4);
                int num7 = 1;
                pmsDataImport.UpdateText(textBoxLisData, txt, num7 != 0);
              }
              DataRow[] dataRowArray = (DataRow[]) Interaction.IIf(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.SampleID, "02", false) == 0, (object) RegisterMicrosoftVisualStudio.ds.Tables["LISTestCodeList"].Select("Test_Name='" + this.TestName + "' And TEST_NAME_SEQUENCE=2"), (object) RegisterMicrosoftVisualStudio.ds.Tables["LISTestCodeList"].Select("Test_Name='" + this.TestName + "' AND TEST_NAME_SEQUENCE=1"));
              if (dataRowArray != null)
              {
                int upperBound = dataRowArray.GetUpperBound(0);
                int index7 = 0;
                while (index7 <= upperBound)
                {
                  this.TestCode = Conversions.ToString(dataRowArray[index7]["Test_Code"]);
                  if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.TestCode, "", false) > 0U & (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "", false) > 0U && !this.ExistsDataTableSameRecord(this.TrackNumber, this.TestCode))
                  {
                    DataRowCollection rows = this.dtLISResult.Rows;
                    object[] objArray = new object[8];
                    int index8 = 0;
                    string str7 = this.PatientID;
                    objArray[index8] = (object) str7;
                    int index9 = 1;
                    string str8 = this.TrackNumber;
                    objArray[index9] = (object) str8;
                    int index10 = 2;
                    string str9 = this.TestCode;
                    objArray[index10] = (object) str9;
                    int index11 = 3;
                    string str10 = this.TestName;
                    objArray[index11] = (object) str10;
                    int index12 = 4;
                    string str11 = Left;
                    objArray[index12] = (object) str11;
                    int index13 = 5;
                    string str12 = this.LISTestCode;
                    objArray[index13] = (object) str12;
                    int index14 = 6;
                    string str13 = "";
                    objArray[index14] = (object) str13;
                    int index15 = 7;
                    // ISSUE: variable of a boxed type
                    __Boxed<DateTime> local = (System.ValueType) this.LISMachineTestTime;
                    objArray[index15] = (object) local;
                    rows.Add(objArray);
                    if (this.dtLISResult.Rows.Count > 900)
                      this.SaveLISImportedData();
                  }
                  checked { ++index7; }
                }
              }
              this.BufferData = "";
            }
            checked { ++index5; }
          }
          this.SaveLISImportedData();
          if (this.CheckBoxLIS.Checked & !Information.IsNothing((object) this.server))
            this.server.IsListining = true;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) MessageBox.Show(ex.Message, RegisterMicrosoftVisualStudio.mazedatech);
        ProjectData.ClearProjectError();
      }
    }

    private void HandleHL7Data(string QBuffer)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(QBuffer, "", false) == 0)
        return;
      if (!Information.IsNothing((object) this.server))
        this.server.IsListining = false;
      string str1 = QBuffer;
      if (Strings.InStr(str1, "MSH|", CompareMethod.Binary) < 1)
        return;
      try
      {
        string str2 = str1;
        char[] chArray1 = new char[1];
        int index1 = 0;
        int num1 = 77;
        chArray1[index1] = (char) num1;
        string str3 = str2.Split(chArray1)[1];
        char[] chArray2 = new char[1];
        int index2 = 0;
        int num2 = 13;
        chArray2[index2] = (char) num2;
        string str4 = str3.Split(chArray2)[0];
        char[] chArray3 = new char[1];
        int index3 = 0;
        int num3 = 124;
        chArray3[index3] = (char) num3;
        string[] strArray1 = str4.Split(chArray3);
        if (Strings.InStr(str1, "SPM|", CompareMethod.Binary) < 1)
        {
          this.TrackNumber = strArray1[9];
        }
        else
        {
          PMS_DataImport pmsDataImport = this;
          string str5 = Strings.Split(str1, "SPM|", -1, CompareMethod.Text)[1];
          char[] chArray4 = new char[1];
          int index4 = 0;
          int num4 = 124;
          chArray4[index4] = (char) num4;
          string str6 = str5.Split(chArray4)[1];
          pmsDataImport.TrackNumber = str6;
        }
        if (Strings.InStr(str1, "OBX|", CompareMethod.Binary) > 0)
        {
          string str5 = str1.Substring(checked (Strings.InStr(str1, "OBX|", CompareMethod.Binary) - 1));
          char[] chArray4 = new char[1];
          int index4 = 0;
          int num4 = 13;
          chArray4[index4] = (char) num4;
          string[] strArray2 = str5.Split(chArray4);
          int num5 = checked (Information.UBound((Array) strArray2, 1) - 1);
          int index5 = 0;
          while (index5 <= num5)
          {
            string str6 = strArray2[index5];
            char[] chArray5 = new char[1];
            int index6 = 0;
            int num6 = 124;
            chArray5[index6] = (char) num6;
            string[] strArray3 = str6.Split(chArray5);
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(strArray3[0].Trim(), "OBX", false) == 0)
            {
              string str7 = strArray3[3];
              char[] chArray6 = new char[1];
              int index7 = 0;
              int num7 = 94;
              chArray6[index7] = (char) num7;
              if (Information.UBound((Array) str7.Split(chArray6), 1) == 0)
              {
                this.TestName = strArray3[3];
              }
              else
              {
                PMS_DataImport pmsDataImport = this;
                string str8 = strArray3[3];
                char[] chArray7 = new char[1];
                int index8 = 0;
                int num8 = 94;
                chArray7[index8] = (char) num8;
                string str9 = str8.Split(chArray7)[1];
                pmsDataImport.TestName = str9;
              }
              DataRow[] dataRowArray = RegisterMicrosoftVisualStudio.ds.Tables["LISTestCodeList"].Select("Test_Name='" + this.TestName + "'");
              if (dataRowArray != null)
              {
                int upperBound = dataRowArray.GetUpperBound(0);
                int index8 = 0;
                while (index8 <= upperBound)
                {
                  this.TestCode = Conversions.ToString(dataRowArray[index8]["Test_Code"]);
                  string Left = strArray3[5];
                  TextBox textBoxLisData = this.TextBoxLISData;
                  string[] strArray4 = new string[7];
                  int index9 = 0;
                  string str8 = "Track:";
                  strArray4[index9] = str8;
                  int index10 = 1;
                  string str9 = this.TrackNumber;
                  strArray4[index10] = str9;
                  int index11 = 2;
                  string str10 = " ";
                  strArray4[index11] = str10;
                  int index12 = 3;
                  string str11 = this.TestName;
                  strArray4[index12] = str11;
                  int index13 = 4;
                  string str12 = " : ";
                  strArray4[index13] = str12;
                  int index14 = 5;
                  string str13 = Left;
                  strArray4[index14] = str13;
                  int index15 = 6;
                  string str14 = "\r\n";
                  strArray4[index15] = str14;
                  string text = string.Concat(strArray4);
                  textBoxLisData.AppendText(text);
                  if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.TestCode, "", false) > 0U & (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "", false) > 0U && !this.ExistsDataTableSameRecord(this.TrackNumber, this.TestCode))
                  {
                    DataRowCollection rows = this.dtLISResult.Rows;
                    object[] objArray = new object[8];
                    int index16 = 0;
                    string str15 = this.PatientID;
                    objArray[index16] = (object) str15;
                    int index17 = 1;
                    string str16 = this.TrackNumber;
                    objArray[index17] = (object) str16;
                    int index18 = 2;
                    string str17 = this.TestCode;
                    objArray[index18] = (object) str17;
                    int index19 = 3;
                    string str18 = this.TestName;
                    objArray[index19] = (object) str18;
                    int index20 = 4;
                    string str19 = Left;
                    objArray[index20] = (object) str19;
                    int index21 = 5;
                    string str20 = this.LISTestCode;
                    objArray[index21] = (object) str20;
                    int index22 = 6;
                    string str21 = "";
                    objArray[index22] = (object) str21;
                    int index23 = 7;
                    // ISSUE: variable of a boxed type
                    __Boxed<DateTime> local = (System.ValueType) this.LISMachineTestTime;
                    objArray[index23] = (object) local;
                    rows.Add(objArray);
                    if (this.dtLISResult.Rows.Count > 900)
                      this.SaveLISImportedData();
                  }
                  checked { ++index8; }
                }
              }
              this.BufferData = "";
            }
            checked { ++index5; }
          }
          this.SaveLISImportedData();
          if (this.CheckBoxLIS.Checked & !Information.IsNothing((object) this.server))
            this.server.IsListining = true;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) MessageBox.Show(ex.Message, RegisterMicrosoftVisualStudio.mazedatech);
        ProjectData.ClearProjectError();
      }
    }

    public bool ExistsGridSameRecord(ref DataGridView dgv, string trackNo, string testcode)
    {
      try
      {
        foreach (DataGridViewRow dataGridViewRow in (IEnumerable) dgv.Rows)
        {
          if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(dataGridViewRow.Cells["Field3"].Value, (object) trackNo, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(dataGridViewRow.Cells["Field16"].Value, (object) testcode, false))))
            return true;
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      return false;
    }

    public bool ExistsDataTableSameRecord(string trackNo, string testcode)
    {
      bool flag;
      try
      {
        int num = checked (this.dtLISResult.Rows.Count - 1);
        int index = 0;
        while (index <= num)
        {
          if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.dtLISResult.Rows[index]["TrackNumber"], (object) trackNo, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.dtLISResult.Rows[index]["TestCode"], (object) testcode, false))))
          {
            flag = true;
            goto label_8;
          }
          else
            checked { ++index; }
        }
        flag = false;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        flag = true;
        ProjectData.ClearProjectError();
      }
label_8:
      return flag;
    }

    private void RadioButtonTextFile_CheckedChanged(object sender, EventArgs e)
    {
      this.LoadSerialCommunicationSetting(2);
    }

    private void RadioButtonAbbottFile_CheckedChanged(object sender, EventArgs e)
    {
      this.LoadSerialCommunicationSetting(3);
    }

    private void RadioButtonExcelFile_CheckedChanged(object sender, EventArgs e)
    {
      this.LoadSerialCommunicationSetting(4);
    }

    private void RadioButtonMicrosoftAccessFile_CheckedChanged(object sender, EventArgs e)
    {
      this.LoadSerialCommunicationSetting(1);
    }

    private void ButtonImportException_Click(object sender, EventArgs e)
    {
      if (this.RadioButtonMicrosoftAccessFile.Checked)
      {
        string str = "";
        int num1 = 0;
        OleDbCommand oleDbCommand = new OleDbCommand(RegisterMicrosoftVisualStudio.SqlText, RegisterMicrosoftVisualStudio.Conn);
        object obj = (object) this;
        RegisterMicrosoftVisualStudio.SingleQuoteReplace(ref obj);
        if (this.NotValidExceptionData())
          return;
        RegisterMicrosoftVisualStudio.SqlText = "INSERT INTO DataImportData (DataFrom, EntryBy, Field1, Field2, Field3, Field4, Field5, Field6, Field7, Field8, Field9, Field10, Field11, Field12, Field13, Field14, Field15, Field16) VALUES ";
        this.Cursor = Cursors.WaitCursor;
        int num2 = checked (this.DataGridView2.Rows.Count - 1);
        int index = 0;
        while (index <= num2)
        {
          str = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) (str + ", ('P','" + RegisterMicrosoftVisualStudio.UserName + "','"), this.DataGridView2["FieldEx1", index].Value), (object) "','"), this.DataGridView2["FieldEx2", index].Value), (object) "','"), this.DataGridView2["FieldEx3", index].Value), (object) "','"), this.DataGridView2["FieldEx4", index].Value), (object) "','"), this.DataGridView2["FieldEx5", index].Value), (object) "','"), this.DataGridView2["FieldEx6", index].Value), (object) "','"), this.DataGridView2["FieldEx7", index].Value), (object) "','"), this.DataGridView2["FieldEx8", index].Value), (object) "','"), this.DataGridView2["FieldEx9", index].Value), (object) "','"), this.DataGridView2["FieldEx10", index].Value), (object) "','"), this.DataGridView2["FieldEx11", index].Value), (object) "','"), this.DataGridView2["FieldEx12", index].Value), (object) "','"), this.DataGridView2["FieldEx13", index].Value), (object) "','"), this.DataGridView2["FieldEx14", index].Value), (object) "','"), this.DataGridView2["FieldEx15", index].Value), (object) "','"), this.DataGridView2["FieldEx16", index].Value), (object) "')"));
          checked { ++index; }
        }
        RegisterMicrosoftVisualStudio.SqlText = RegisterMicrosoftVisualStudio.SqlText + Strings.Mid(str, 2);
        oleDbCommand.CommandType = CommandType.Text;
        oleDbCommand.CommandText = RegisterMicrosoftVisualStudio.SqlText;
        RegisterMicrosoftVisualStudio.Conn.Open();
        try
        {
          num1 = oleDbCommand.ExecuteNonQuery();
          this.DeleteSourceRecordAccess(this.TextBoxAccessFileUserName.Text, this.TextBoxAccessFilePassword.Text, this.ComboBoxAccessFileTableName.Text);
          oleDbCommand.CommandText = "exec spUpdatePathologyDataWithImportedData '" + RegisterMicrosoftVisualStudio.UserName + "';";
          num1 = oleDbCommand.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          Exception exception = ex;
          this.Cursor = Cursors.Default;
          int num3 = (int) MessageBox.Show(exception.Message);
          RegisterMicrosoftVisualStudio.Conn.Close();
          ProjectData.ClearProjectError();
          return;
        }
        RegisterMicrosoftVisualStudio.Conn.Close();
        this.DataGridView2.Rows.Clear();
        this.Cursor = Cursors.Default;
        int num4 = (int) MessageBox.Show("Record saved properly.", RegisterMicrosoftVisualStudio.mazedatech, MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
      }
      else
        this.SaveTextFileImportedExceptionData();
    }

    private void SaveTextFileImportedExceptionData()
    {
      string str1 = "";
      int num1 = 0;
      OleDbCommand oleDbCommand = new OleDbCommand(RegisterMicrosoftVisualStudio.SqlText, RegisterMicrosoftVisualStudio.Conn);
      object obj = (object) this;
      RegisterMicrosoftVisualStudio.SingleQuoteReplace(ref obj);
      if (this.NotValidExceptionData())
        return;
      RegisterMicrosoftVisualStudio.SqlText = "INSERT INTO DataImportData (DataFrom, EntryBy, Field1, Field2, Field3, Field4, Field5, Field6, Field7, Field8, Field9, Field10, Field11, Field12, Field13, Field14, Field15, Field16) VALUES ";
      this.Cursor = Cursors.WaitCursor;
      int num2 = checked (this.DataGridView2.Rows.Count - 1);
      int index1 = 0;
      while (index1 <= num2)
      {
        string str2 = this.DataGridView2["FieldEx16", index1].Value.ToString();
        char[] chArray = new char[1];
        int index2 = 0;
        int num3 = 44;
        chArray[index2] = (char) num3;
        string[] strArray1 = str2.Split(chArray);
        int num4 = Information.UBound((Array) strArray1, 1);
        int index3 = 0;
        while (index3 <= num4)
        {
          string[] strArray2 = new string[6];
          int index4 = 0;
          string str3 = str1;
          strArray2[index4] = str3;
          int index5 = 1;
          string str4 = ", ('";
          strArray2[index5] = str4;
          int index6 = 2;
          string str5 = Conversions.ToString(this.ComboBoxTestFileMachineName.SelectedIndex);
          strArray2[index6] = str5;
          int index7 = 3;
          string str6 = "','";
          strArray2[index7] = str6;
          int index8 = 4;
          string str7 = RegisterMicrosoftVisualStudio.UserName;
          strArray2[index8] = str7;
          int index9 = 5;
          string str8 = "','";
          strArray2[index9] = str8;
          str1 = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) string.Concat(strArray2), this.DataGridView2["FieldEx1", index1].Value), (object) "','"), this.DataGridView2["FieldEx2", index1].Value), (object) "','"), this.DataGridView2["FieldEx3", index1].Value), (object) "','"), this.DataGridView2["FieldEx4", index1].Value), (object) "','"), this.DataGridView2["FieldEx5", index1].Value), (object) "','"), this.DataGridView2["FieldEx6", index1].Value), (object) "','"), this.DataGridView2["FieldEx7", index1].Value), (object) "','"), this.DataGridView2["FieldEx8", index1].Value), (object) "','"), this.DataGridView2["FieldEx9", index1].Value), (object) "','"), this.DataGridView2["FieldEx10", index1].Value), (object) "','"), this.DataGridView2["FieldEx11", index1].Value), (object) "','"), this.DataGridView2["FieldEx12", index1].Value), (object) "','"), this.DataGridView2["FieldEx13", index1].Value), (object) "','"), this.DataGridView2["FieldEx14", index1].Value), (object) "','"), this.DataGridView2["FieldEx15", index1].Value), (object) "','"), (object) strArray1[index3]), (object) "')"));
          checked { ++index3; }
        }
        checked { ++index1; }
      }
      RegisterMicrosoftVisualStudio.SqlText = RegisterMicrosoftVisualStudio.SqlText + Strings.Mid(str1, 2);
      oleDbCommand.CommandType = CommandType.Text;
      oleDbCommand.CommandText = RegisterMicrosoftVisualStudio.SqlText;
      RegisterMicrosoftVisualStudio.Conn.Open();
      try
      {
        num1 = oleDbCommand.ExecuteNonQuery();
        oleDbCommand.CommandText = "exec spUpdatePathologyDataWithImportedData '" + RegisterMicrosoftVisualStudio.UserName + "';";
        num1 = oleDbCommand.ExecuteNonQuery();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        this.Cursor = Cursors.Default;
        int num3 = (int) MessageBox.Show(exception.Message);
        RegisterMicrosoftVisualStudio.Conn.Close();
        ProjectData.ClearProjectError();
        return;
      }
      RegisterMicrosoftVisualStudio.Conn.Close();
      this.DataGridView2.Rows.Clear();
      this.Cursor = Cursors.Default;
      int num5 = (int) MessageBox.Show("Record saved properly.", RegisterMicrosoftVisualStudio.mazedatech, MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
    }

    private void ButtonENQ_Click(object sender, EventArgs e)
    {
      try
      {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append('\x0005');
        if (!this.RadioButtonSerial.Checked)
          return;
        if (this.SerialPortArchitect.IsOpen)
          this.SerialPortArchitect.Write(stringBuilder.ToString());
        if (this.SerialPortELITE.IsOpen)
          this.SerialPortELITE.Write(stringBuilder.ToString());
        if (this.SerialPortCellDynRuby.IsOpen)
          this.SerialPortCellDynRuby.Write(stringBuilder.ToString());
        if (this.SerialPortImmulite2000.IsOpen)
          this.SerialPortImmulite2000.Write(stringBuilder.ToString());
        if (this.SerialPortSiemensDimension.IsOpen)
          this.SerialPortSiemensDimension.Write(stringBuilder.ToString());
        if (this.SerialPortSysmex.IsOpen)
          this.SerialPortSysmex.Write(stringBuilder.ToString());
        if (this.SerialPortBioradD10.IsOpen)
          this.SerialPortBioradD10.Write(stringBuilder.ToString());
        if (this.SerialPortBioradVariant.IsOpen)
          this.SerialPortBioradVariant.Write(stringBuilder.ToString());
        if (this.SerialPortCelltacChemi.IsOpen)
          this.SerialPortCelltacChemi.Write(stringBuilder.ToString());
        if (this.SerialPortVIDAS.IsOpen)
          this.SerialPortVIDAS.Write(stringBuilder.ToString());
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) MessageBox.Show(ex.Message);
        ProjectData.ClearProjectError();
      }
    }

    private void ReadTextFile()
    {
      try
      {
        if (this.RadioButtonSerial.Checked)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.ComboBoxTestFileMachineName.Text, "ARCHITECT", false) == 0)
          {
            PMS_DataImport pmsDataImport = this;
            string str = File.ReadAllText("C:\\Windows\\Temp\\MTechLISLog.txt").ToString();
            char[] chArray = new char[1];
            int index = 0;
            int num = 13;
            chArray[index] = (char) num;
            string[] pSerialData = str.Split(chArray);
            pmsDataImport.HandleArchitectMachinSerialData(pSerialData);
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.ComboBoxTestFileMachineName.Text, "Cell Dyn Rubi", false) == 0)
          {
            PMS_DataImport pmsDataImport = this;
            string str = File.ReadAllText("C:\\Windows\\Temp\\MTechLISLog.txt").ToString();
            char[] chArray = new char[1];
            int index = 0;
            int num = 13;
            chArray[index] = (char) num;
            string[] pSerialData = str.Split(chArray);
            pmsDataImport.HandleRubiMachinSerialData(pSerialData);
          }
          File.WriteAllText("C:\\Windows\\Temp\\MTechLISLog.txt", "");
        }
        else
        {
          this.HandleHL7Data(File.ReadAllText("C:\\Windows\\Temp\\MTechLISHL7Log.txt").ToString());
          File.WriteAllText("C:\\Windows\\Temp\\MTechLISHL7Log.txt", "");
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) MessageBox.Show(ex.Message);
        ProjectData.ClearProjectError();
      }
    }

    private void SendTestOrderQuery(string TrackNumber)
    {
      try
      {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append('\x0005');
        if (this.RadioButtonSerial.Checked)
          this.SerialPortArchitect.Write(stringBuilder.ToString());
        else if (this.CheckBoxHL7.Checked)
          this.server.Server.Server.Send(Encoding.UTF8.GetBytes(stringBuilder.ToString()));
        else
          this.ASTMServer.Server.Server.Send(Encoding.UTF8.GetBytes(stringBuilder.ToString()));
        string txt = "H|\\^&|||Mazedatech|||||||P|1|20170504150035\r" + "Q|1|^" + TrackNumber + "||^^^ALL||||||||O\x0003CC\r" + "L|1|F\r";
        if (this.RadioButtonSerial.Checked)
          this.UpdateText(this.TextBoxResponseMessage, txt, true);
        else
          this.UpdateText(this.TextBoxResponseMessage, txt, true);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) MessageBox.Show(ex.Message);
        ProjectData.ClearProjectError();
      }
    }

    private void ButtonSendTestOrder_Click(object sender, EventArgs e)
    {
      this.SendTestOrderQuery(this.TextBoxTrackForTestOrder.Text);
    }

    private void ComboBoxTestFileMachineName_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.MachineName = this.ComboBoxTestFileMachineName.Text;
      this.MachineIndex = this.ComboBoxTestFileMachineName.SelectedIndex;
    }

    private void ButtonBulkImport_Click(object sender, EventArgs e)
    {
      if (this.RadioButtonSerial.Checked)
      {
        if (File.Exists("C:\\Windows\\Temp\\MTechLISLog.txt"))
        {
          this.ReadTextFile();
        }
        else
        {
          int num1 = (int) MessageBox.Show("C:\\Windows\\Temp\\MTechLISLog.txt File Not exists");
        }
      }
      else if (File.Exists("C:\\Windows\\Temp\\MTechLISHL7Log.txt"))
      {
        this.ReadTextFile();
      }
      else
      {
        int num2 = (int) MessageBox.Show("C:\\Windows\\Temp\\MTechLISHL7Log.txt File Not exists");
      }
    }

    private void ComboBoxOrderType_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.OrderType = "N";
    }

    private string CheckSumSeimensDimensionSerialData(string OrderMsg)
    {
      Decimal d1 = new Decimal();
      int num = checked (OrderMsg.Length - 1);
      int index = 0;
      while (index <= num)
      {
        d1 = Decimal.Add(d1, new Decimal(Strings.Asc(OrderMsg[index])));
        checked { ++index; }
      }
      return Strings.Right(Conversion.Hex((object) d1), 2);
    }

    private void LISMonitor(string msg)
    {
      try
      {
        if (!this.CheckBoxLISMonitor.Checked)
          return;
        this.LISMonitorForm = new PMS_LISMonitor();
        this.LISMonitorForm.LabelMessage.Text = msg;
        PMS_LISMonitor pmsLisMonitor = this.LISMonitorForm;
        Form mdiParent = this.MdiParent;
        // ISSUE: explicit reference operation
        // ISSUE: variable of a reference type
        Form& MDIfrm = @mdiParent;
        Form form = (Form) this;
        // ISSUE: explicit reference operation
        // ISSUE: variable of a reference type
        Form& frm = @form;
        CheckBox checkBoxLis = this.CheckBoxLIS;
        // ISSUE: explicit reference operation
        // ISSUE: variable of a reference type
        CheckBox& chkboxLIS = @checkBoxLis;
        pmsLisMonitor.ShowMonitor(MDIfrm, frm, chkboxLIS);
        this.CheckBoxLIS = checkBoxLis;
        this.MdiParent = mdiParent;
        ((Control) this.LISMonitorForm).Show();
        this.MdiParent.Hide();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) MessageBox.Show(ex.Message, "LIS Monitor");
        ProjectData.ClearProjectError();
      }
    }

    private void TextBoxLISData_TextChanged(object sender, EventArgs e)
    {
      this.LISMonitorForm.TextBoxLISData.Text = this.TextBoxLISData.Text;
      if (Strings.Len(this.TextBoxLISData.Text) <= 3000)
        return;
      this.TextBoxLISData.Text = "";
    }

    private void TextBoxLISRespond_TextChanged(object sender, EventArgs e)
    {
      this.LISMonitorForm.TextBoxLISRespond.Text = this.TextBoxLISRespond.Text;
    }

    private void SerialPortELITE_DataReceived(object sender, SerialDataReceivedEventArgs e)
    {
      try
      {
        string str = Strings.Trim(this.SerialPortELITE.ReadExisting());
        this.SerialPortELITE.Write(this.HandleSerialMessage1(str));
        this.UpdateText(this.TextBoxLISRespond, "Send: ACK", false);
        if (Strings.Len(str) > 0)
        {
          this.SerialSignal = Conversions.ToString(Strings.AscW(Strings.Right(str, 1)));
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.SerialSignal, "1", false) == 0)
            this.BufferData = str;
          else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.SerialSignal, "4", false) == 0)
          {
            this.HandleEliteMachineSerialData(this.BufferData.Trim());
            this.BufferData = "";
            this.TrackNumber = "";
          }
          else
            this.BufferData = this.BufferData + str;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.UpdateText(this.TextBoxLISData, "SerialPort: " + ex.Message + "\r\n", true);
        ProjectData.ClearProjectError();
      }
    }

    private void HandleEliteMachineSerialData(string QBuffer)
    {
      string str1 = "";
      string str2 = QBuffer;
      char[] chArray1 = new char[1];
      int index1 = 0;
      int num1 = 13;
      chArray1[index1] = (char) num1;
      string[] strArray1 = str2.Split(chArray1);
      string[] strArray2;
      try
      {
        int num2 = checked (Information.UBound((Array) strArray1, 1) - 2);
        int index2 = 1;
        while (index2 <= num2)
        {
          string str3 = strArray1[index2];
          char[] chArray2 = new char[1];
          int index3 = 0;
          int num3 = 9;
          chArray2[index3] = (char) num3;
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str3.Split(chArray2)[0].Trim(), "SampleID:", false) == 0)
          {
            PMS_DataImport pmsDataImport1 = this;
            string str4 = strArray1[index2];
            char[] chArray3 = new char[1];
            int index4 = 0;
            int num4 = 9;
            chArray3[index4] = (char) num4;
            string str5 = str4.Split(chArray3)[1];
            pmsDataImport1.TrackNumber = str5;
            this.LISTrackNumber = this.TrackNumber;
            this.PatientID = this.TrackNumber;
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.LISBarcode8Bit, "1", false) == 0)
            {
              this.SampleID = Strings.Right(this.TrackNumber.Trim(), 1);
              this.TrackNumber = Strings.Mid(DateTime.Now.ToString("yy"), 1, 1) + Strings.Left(this.TrackNumber.Trim(), 7);
            }
            else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.LISBarcode8Bit, "0", false) == 0)
            {
              PMS_DataImport pmsDataImport2 = this;
              string str6 = strArray1[index2];
              char[] chArray4 = new char[1];
              int index5 = 0;
              int num5 = 9;
              chArray4[index5] = (char) num5;
              string str7 = Strings.Mid(str6.Split(chArray4)[1], 3);
              pmsDataImport2.TrackNumber = str7;
              PMS_DataImport pmsDataImport3 = this;
              string str8 = strArray1[index2];
              char[] chArray5 = new char[1];
              int index6 = 0;
              int num6 = 9;
              chArray5[index6] = (char) num6;
              string str9 = Strings.Mid(str8.Split(chArray5)[1], 1, 2);
              pmsDataImport3.SampleID = str9;
              this.LISTrackNumber = this.SampleID + this.TrackNumber;
            }
          }
          PMS_DataImport pmsDataImport4 = this;
          string str10 = strArray1[checked (index2 + 1)];
          char[] chArray6 = new char[1];
          int index7 = 0;
          int num7 = 9;
          chArray6[index7] = (char) num7;
          string[] strArray3 = str10.Split(chArray6);
          pmsDataImport4.OBX = strArray3;
          if (this.OBX.Length == 5 & (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.TrackNumber, "", false) > 0U)
          {
            this.TestName = this.OBX[0].Trim();
            string Left = this.OBX[2];
            if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "", false) > 0U)
            {
              PMS_DataImport pmsDataImport1 = this;
              TextBox textBoxLisData = this.TextBoxLISData;
              string[] strArray4 = new string[7];
              int index4 = 0;
              string str4 = "Track:";
              strArray4[index4] = str4;
              int index5 = 1;
              string str5 = this.TrackNumber;
              strArray4[index5] = str5;
              int index6 = 2;
              string str6 = " ";
              strArray4[index6] = str6;
              int index8 = 3;
              string str7 = this.TestName;
              strArray4[index8] = str7;
              int index9 = 4;
              string str8 = " : ";
              strArray4[index9] = str8;
              int index10 = 5;
              string str9 = Left;
              strArray4[index10] = str9;
              int index11 = 6;
              string str11 = "\r\n";
              strArray4[index11] = str11;
              string txt = string.Concat(strArray4);
              int num4 = 1;
              pmsDataImport1.UpdateText(textBoxLisData, txt, num4 != 0);
            }
            DataRow[] dataRowArray = RegisterMicrosoftVisualStudio.ds.Tables["LISTestCodeList"].Select("Test_Name='" + this.TestName + "'");
            if (dataRowArray != null)
            {
              int upperBound = dataRowArray.GetUpperBound(0);
              int index4 = 0;
              while (index4 <= upperBound)
              {
                this.TestCode = Conversions.ToString(dataRowArray[index4]["Test_Code"]);
                this.LISTestCode = this.TestName;
                if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.TestCode, "", false) > 0U & (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "", false) > 0U && !this.ExistsDataTableSameRecord(this.TrackNumber, this.TestCode))
                {
                  DataRowCollection rows = this.dtLISResult.Rows;
                  object[] objArray = new object[8];
                  int index5 = 0;
                  string str4 = this.PatientID;
                  objArray[index5] = (object) str4;
                  int index6 = 1;
                  string str5 = this.TrackNumber;
                  objArray[index6] = (object) str5;
                  int index8 = 2;
                  string str6 = this.TestCode;
                  objArray[index8] = (object) str6;
                  int index9 = 3;
                  string str7 = this.TestName;
                  objArray[index9] = (object) str7;
                  int index10 = 4;
                  string str8 = Left;
                  objArray[index10] = (object) str8;
                  int index11 = 5;
                  string str9 = this.LISTestCode;
                  objArray[index11] = (object) str9;
                  int index12 = 6;
                  string str11 = "";
                  objArray[index12] = (object) str11;
                  int index13 = 7;
                  // ISSUE: variable of a boxed type
                  __Boxed<DateTime> local = (System.ValueType) this.LISMachineTestTime;
                  objArray[index13] = (object) local;
                  rows.Add(objArray);
                  if (this.dtLISResult.Rows.Count > 900)
                    this.SaveLISImportedData();
                }
                checked { ++index4; }
              }
            }
          }
          checked { ++index2; }
        }
        this.SaveLISImportedData();
        strArray2 = (string[]) null;
        str1 = (string) null;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        strArray2 = (string[]) null;
        str1 = (string) null;
        int num2 = (int) MessageBox.Show(exception.Message);
        ProjectData.ClearProjectError();
      }
    }

    private void TextBoxResponseMessage_TextChanged(object sender, EventArgs e)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.ComboBoxTestFileMachineName.Text, "SIEMENS DIMENSION", false) == 0)
        this.AnalyzeBufferDataSiemensDimension(this.TextBoxResponseMessage.Text);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.ComboBoxTestFileMachineName.Text, "IMMULITE 2000", false) == 0)
        this.AnalyzeBufferDataImmulite2000(this.TextBoxResponseMessage.Text.Trim());
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.ComboBoxTestFileMachineName.Text, "ARCHITECT", false) == 0)
        this.AnalyzeBufferDataArchitect(this.TextBoxResponseMessage.Text);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.ComboBoxTestFileMachineName.Text, "Cell Dyn Rubi", false) == 0)
        this.AnalyzeBufferDataCellDynRuby(this.TextBoxResponseMessage.Text);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.ComboBoxTestFileMachineName.Text, "SIEMENS ADVIA", false) == 0)
        this.HandleASTMData(this.TextBoxResponseMessage.Text);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.ComboBoxTestFileMachineName.Text, "ELITE", false) == 0)
        this.HandleEliteMachineSerialData(this.TextBoxResponseMessage.Text);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.ComboBoxTestFileMachineName.Text, "Sysmex", false) == 0)
        this.HandleASTMSysmexData(this.TextBoxResponseMessage.Text);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.ComboBoxTestFileMachineName.Text, "Biorad D10", false) == 0)
        this.AnalyzeBufferDataBioradD10(this.TextBoxResponseMessage.Text);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.ComboBoxTestFileMachineName.Text, "Biorad Variant", false) == 0)
        this.AnalyzeBufferDataBioradvariant(this.TextBoxResponseMessage.Text);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.ComboBoxTestFileMachineName.Text, "Celltac Chemi", false) == 0)
        this.AnalyzeBufferDataCelltacChemi(this.TextBoxResponseMessage.Text);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.ComboBoxTestFileMachineName.Text, "VIDAS", false) == 0)
        this.AnalyzeBufferDataVIDAS(this.TextBoxResponseMessage.Text);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.ComboBoxTestFileMachineName.Text, "ADAMS A1c HA", false) == 0)
        this.AnalyzeBufferDataADAMSA1cHA(this.TextBoxResponseMessage.Text);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.ComboBoxTestFileMachineName.Text, "Chemray", false) == 0)
        this.HandleHL7Data_Chemray(this.TextBoxResponseMessage.Text);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.ComboBoxTestFileMachineName.Text, "Hemaray", false) != 0)
        return;
      this.HandleHL7Data_Hemaray(this.TextBoxResponseMessage.Text);
    }

    private void SendSysmexOrder(int k)
    {
      int FrameNumber = checked (k + 1);
      StringBuilder stringBuilder = new StringBuilder();
      stringBuilder.Append('\x0002');
      stringBuilder.Append(FrameNumber);
      string OrderMsg;
      if (k == 0)
        OrderMsg = "H|\\^&|||Mazedatech^^^^|||||CA-600\r";
      else if (k == 1)
        OrderMsg = "P|1\r";
      else if (k == 2)
      {
        PMS_DataImport pmsDataImport1 = this;
        string str1 = this.OrderQuery;
        char[] chArray1 = new char[1];
        int index1 = 0;
        int num1 = 124;
        chArray1[index1] = (char) num1;
        string str2 = str1.Split(chArray1)[2];
        char[] chArray2 = new char[1];
        int index2 = 0;
        int num2 = 94;
        chArray2[index2] = (char) num2;
        string str3 = Strings.Mid(str2.Split(chArray2)[2].Trim(), 1, 8);
        pmsDataImport1.TrackNumber = str3;
        this.LISTrackNumber = this.TrackNumber;
        string str4 = this.OrderQuery;
        char[] chArray3 = new char[1];
        int index3 = 0;
        int num3 = 124;
        chArray3[index3] = (char) num3;
        string str5 = str4.Split(chArray3)[2];
        char[] chArray4 = new char[1];
        int index4 = 0;
        int num4 = 94;
        chArray4[index4] = (char) num4;
        string str6 = Strings.Trim(str5.Split(chArray4)[0]);
        string str7 = this.OrderQuery;
        char[] chArray5 = new char[1];
        int index5 = 0;
        int num5 = 124;
        chArray5[index5] = (char) num5;
        string str8 = str7.Split(chArray5)[2];
        char[] chArray6 = new char[1];
        int index6 = 0;
        int num6 = 94;
        chArray6[index6] = (char) num6;
        string str9 = Strings.Trim(str8.Split(chArray6)[1]);
        PMS_DataImport pmsDataImport2 = this;
        string str10 = this.OrderQuery;
        char[] chArray7 = new char[1];
        int index7 = 0;
        int num7 = 124;
        chArray7[index7] = (char) num7;
        string str11 = str10.Split(chArray7)[2];
        char[] chArray8 = new char[1];
        int index8 = 0;
        int num8 = 94;
        chArray8[index8] = (char) num8;
        string str12 = Strings.Mid(str11.Split(chArray8)[2].Trim(), 9);
        pmsDataImport2.SampleID = str12;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.LISBarcode8Bit, "1", false) == 0)
        {
          this.SampleID = Strings.Right(this.TrackNumber.Trim(), 1);
          this.TrackNumber = Strings.Mid(DateTime.Now.ToString("yy"), 1, 1) + Strings.Left(this.TrackNumber.Trim(), 7);
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.LISBarcode8Bit, "0", false) == 0)
        {
          PMS_DataImport pmsDataImport3 = this;
          string str13 = this.OrderQuery;
          char[] chArray9 = new char[1];
          int index9 = 0;
          int num9 = 124;
          chArray9[index9] = (char) num9;
          string str14 = str13.Split(chArray9)[2];
          char[] chArray10 = new char[1];
          int index10 = 0;
          int num10 = 94;
          chArray10[index10] = (char) num10;
          string str15 = Strings.Mid(str14.Split(chArray10)[2].Trim(), 3, 8);
          pmsDataImport3.TrackNumber = str15;
          PMS_DataImport pmsDataImport4 = this;
          string str16 = this.OrderQuery;
          char[] chArray11 = new char[1];
          int index11 = 0;
          int num11 = 124;
          chArray11[index11] = (char) num11;
          string str17 = str16.Split(chArray11)[2];
          char[] chArray12 = new char[1];
          int index12 = 0;
          int num12 = 94;
          chArray12[index12] = (char) num12;
          string str18 = Strings.Mid(str17.Split(chArray12)[2].Trim(), 1, 2);
          pmsDataImport4.SampleID = str18;
          this.LISTrackNumber = this.SampleID + this.TrackNumber;
          string str19 = this.OrderQuery;
          char[] chArray13 = new char[1];
          int index13 = 0;
          int num13 = 124;
          chArray13[index13] = (char) num13;
          string str20 = str19.Split(chArray13)[2];
          char[] chArray14 = new char[1];
          int index14 = 0;
          int num14 = 94;
          chArray14[index14] = (char) num14;
          str6 = Strings.Trim(str20.Split(chArray14)[0]);
          string str21 = this.OrderQuery;
          char[] chArray15 = new char[1];
          int index15 = 0;
          int num15 = 124;
          chArray15[index15] = (char) num15;
          string str22 = str21.Split(chArray15)[2];
          char[] chArray16 = new char[1];
          int index16 = 0;
          int num16 = 94;
          chArray16[index16] = (char) num16;
          str9 = Strings.Trim(str22.Split(chArray16)[1]);
        }
        string[] strArray1 = new string[11];
        int index17 = 0;
        string str23 = "exec spTestListOnServiceTrackLISWithPatient @TrackNumber='";
        strArray1[index17] = str23;
        int index18 = 1;
        string str24 = this.TrackNumber;
        strArray1[index18] = str24;
        int index19 = 2;
        string str25 = "', @MachineName='";
        strArray1[index19] = str25;
        int index20 = 3;
        string str26 = this.MachineName;
        strArray1[index20] = str26;
        int index21 = 4;
        string str27 = "', @ExcludeExistingDBTest='";
        strArray1[index21] = str27;
        int index22 = 5;
        string str28 = Conversions.ToString(this.CheckBoxCheckTestInDBResult.Checked);
        strArray1[index22] = str28;
        int index23 = 6;
        string str29 = "', @SampleID='";
        strArray1[index23] = str29;
        int index24 = 7;
        string str30 = this.SampleID;
        strArray1[index24] = str30;
        int index25 = 8;
        string str31 = "', @AssayType='";
        strArray1[index25] = str31;
        int index26 = 9;
        string str32 = this.AssayType;
        strArray1[index26] = str32;
        int index27 = 10;
        string str33 = "'";
        strArray1[index27] = str33;
        RegisterMicrosoftVisualStudio.SqlText = string.Concat(strArray1);
        RegisterMicrosoftVisualStudio.da.SelectCommand = new OleDbCommand(RegisterMicrosoftVisualStudio.SqlText, RegisterMicrosoftVisualStudio.Conn);
        if (RegisterMicrosoftVisualStudio.ds.Tables["PatientTestList"] != null)
          RegisterMicrosoftVisualStudio.ds.Tables["PatientTestList"].Clear();
        ((DbDataAdapter) RegisterMicrosoftVisualStudio.da).Fill(RegisterMicrosoftVisualStudio.ds, "PatientTestList");
        DataTable dataTable = RegisterMicrosoftVisualStudio.ds.Tables["PatientTestList"];
        if (dataTable.Rows.Count < 1)
          return;
        this.PatientName = Conversions.ToString(dataTable.Rows[0]["PatientName"]);
        this.PatientBirthdate = Conversions.ToString(dataTable.Rows[0]["PatientBirthdate"]);
        this.PatientSex = Conversions.ToString(dataTable.Rows[0]["PatientSex"]);
        string str34 = "";
        int num17 = checked (dataTable.Rows.Count - 1);
        k = 0;
        while (k <= num17)
        {
          str34 = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) (str34 + "\\^^^"), dataTable.Rows[k]["TEST_CODE"]), (object) "^^100"));
          checked { ++k; }
        }
        string[] strArray2 = new string[9];
        int index28 = 0;
        string str35 = "O|1|";
        strArray2[index28] = str35;
        int index29 = 1;
        string str36 = str6;
        strArray2[index29] = str36;
        int index30 = 2;
        string str37 = "^";
        strArray2[index30] = str37;
        int index31 = 3;
        string str38 = str9;
        strArray2[index31] = str38;
        int index32 = 4;
        string str39 = "^";
        strArray2[index32] = str39;
        int index33 = 5;
        string str40 = this.LISTrackNumber;
        strArray2[index33] = str40;
        int index34 = 6;
        string str41 = "^B||";
        strArray2[index34] = str41;
        int index35 = 7;
        string str42 = Strings.Mid(str34, 2);
        strArray2[index35] = str42;
        int index36 = 8;
        string str43 = "|R|20180207101000|||||N\r";
        strArray2[index36] = str43;
        OrderMsg = string.Concat(strArray2);
      }
      else
        OrderMsg = "L|1|N\r";
      stringBuilder.Append(OrderMsg);
      stringBuilder.Append('\x0003');
      string str = this.CheckSumArchitectMachinSerialData(FrameNumber, OrderMsg, 0);
      stringBuilder.Append(Strings.Left(str, 1));
      stringBuilder.Append(Strings.Right(str, 1));
      stringBuilder.Append('\r');
      stringBuilder.Append('\n');
      if (this.SerialPortSysmex.IsOpen)
        this.SerialPortSysmex.Write(stringBuilder.ToString());
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    private void PMS_DataImport_Shown(object sender, EventArgs e)
    {
      if (!this.DataImportFail())
        return;
      ProjectData.EndApp();
    }

    private delegate void UpdateTextDelegate(TextBox TB, string txt, bool opt);
  }
}

