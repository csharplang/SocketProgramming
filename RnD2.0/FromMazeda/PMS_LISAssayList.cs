// Type: MTechERP.PMS_LISAssayList
// Assembly: MTechERP, Version=4.7.51.0, Culture=neutral, PublicKeyToken=null
// MVID: D0AABECB-CB7F-42E6-A234-0752CE355F07
// Assembly location: D:\CodeData\MTechERP -TMP\MTechERP.exe

using ClassLibraryMicrosoftVisualStudio;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace MTechERP
{
  [DesignerGenerated]
  public class PMS_LISAssayList : Form
  {
    private IContainer components;
    private int Checker;
    private ComboBox cbo;
    private int col;

    internal virtual TextBox TextBoxAssayProtocol { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBoxAssayCode { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBoxAssayActive { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

    internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox ComboBoxTestFileMachineName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual GroupBox GroupBoxSearch { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBoxAssayName
    {
      get
      {
        return this._TextBoxAssayName;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.TextBoxAssayName_TextChanged);
        TextBox textBox1 = this._TextBoxAssayName;
        if (textBox1 != null)
          textBox1.TextChanged -= eventHandler;
        this._TextBoxAssayName = value;
        TextBox textBox2 = this._TextBoxAssayName;
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
        EventHandler eventHandler = new EventHandler(this.DataGridView1_DoubleClick);
        DataGridViewCellMouseEventHandler mouseEventHandler = new DataGridViewCellMouseEventHandler(this.DataGridView1_RowHeaderMouseDoubleClick);
        DataGridViewCellEventHandler cellEventHandler = new DataGridViewCellEventHandler(this.DataGridView1_CellClick);
        DataGridView dataGridView1 = this._DataGridView1;
        if (dataGridView1 != null)
        {
          dataGridView1.DoubleClick -= eventHandler;
          dataGridView1.RowHeaderMouseDoubleClick -= mouseEventHandler;
          dataGridView1.CellClick -= cellEventHandler;
        }
        this._DataGridView1 = value;
        DataGridView dataGridView2 = this._DataGridView1;
        if (dataGridView2 == null)
          return;
        dataGridView2.DoubleClick += eventHandler;
        dataGridView2.RowHeaderMouseDoubleClick += mouseEventHandler;
        dataGridView2.CellClick += cellEventHandler;
      }
    }

    internal virtual Button btnSave
    {
      get
      {
        return this._btnSave;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.btnSave_Click);
        EventHandler eventHandler2 = new EventHandler(this.btnSave_GotFocus);
        EventHandler eventHandler3 = new EventHandler(this.btnSave_LostFocus);
        EventHandler eventHandler4 = new EventHandler(this.btnSave_MouseHover);
        EventHandler eventHandler5 = new EventHandler(this.btnSave_MouseLeave);
        Button button1 = this._btnSave;
        if (button1 != null)
        {
          button1.Click -= eventHandler1;
          button1.GotFocus -= eventHandler2;
          button1.LostFocus -= eventHandler3;
          button1.MouseHover -= eventHandler4;
          button1.MouseLeave -= eventHandler5;
        }
        this._btnSave = value;
        Button button2 = this._btnSave;
        if (button2 == null)
          return;
        button2.Click += eventHandler1;
        button2.GotFocus += eventHandler2;
        button2.LostFocus += eventHandler3;
        button2.MouseHover += eventHandler4;
        button2.MouseLeave += eventHandler5;
      }
    }

    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridViewTextBoxColumn MachineName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridViewTextBoxColumn AssayName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridViewTextBoxColumn AssayCode { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridViewTextBoxColumn AssayType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridViewTextBoxColumn AssayProtocol { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridViewTextBoxColumn AssayActive { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBoxAssayType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    public PMS_LISAssayList()
    {
      this.Load += new EventHandler(this.PMS_LISAssayList_Load);
      this.Checker = 0;
      this.col = 0;
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
      this.TextBoxAssayProtocol = new TextBox();
      this.Label5 = new Label();
      this.TextBoxAssayCode = new TextBox();
      this.CheckBoxAssayActive = new CheckBox();
      this.Label8 = new Label();
      this.TextBoxSearchValue = new TextBox();
      this.Label2 = new Label();
      this.ComboBoxTestFileMachineName = new ComboBox();
      this.Label17 = new Label();
      this.GroupBoxSearch = new GroupBox();
      this.Label15 = new Label();
      this.Label14 = new Label();
      this.Label1 = new Label();
      this.TextBoxAssayName = new TextBox();
      this.DataGridView1 = new DataGridView();
      this.MachineName = new DataGridViewTextBoxColumn();
      this.AssayName = new DataGridViewTextBoxColumn();
      this.AssayCode = new DataGridViewTextBoxColumn();
      this.AssayType = new DataGridViewTextBoxColumn();
      this.AssayProtocol = new DataGridViewTextBoxColumn();
      this.AssayActive = new DataGridViewTextBoxColumn();
      this.btnSave = new Button();
      this.DataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
      this.DataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
      this.DataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
      this.DataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
      this.DataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
      this.Label3 = new Label();
      this.TextBoxAssayType = new TextBox();
      this.GroupBoxSearch.SuspendLayout();
      this.DataGridView1.BeginInit();
      this.SuspendLayout();
      this.TextBoxAssayProtocol.BorderStyle = BorderStyle.FixedSingle;
      this.TextBoxAssayProtocol.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.TextBoxAssayProtocol.Location = new Point(115, 143);
      this.TextBoxAssayProtocol.MaxLength = 100;
      this.TextBoxAssayProtocol.Name = "TextBoxAssayProtocol";
      this.TextBoxAssayProtocol.Size = new Size(194, 23);
      this.TextBoxAssayProtocol.TabIndex = 304;
      this.Label5.AutoSize = true;
      this.Label5.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label5.Location = new Point(12, 89);
      this.Label5.Name = "Label5";
      this.Label5.Size = new Size(83, 17);
      this.Label5.TabIndex = 302;
      this.Label5.Text = "Assay Code";
      this.TextBoxAssayCode.BorderStyle = BorderStyle.FixedSingle;
      this.TextBoxAssayCode.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.TextBoxAssayCode.Location = new Point(115, 85);
      this.TextBoxAssayCode.MaxLength = 100;
      this.TextBoxAssayCode.Name = "TextBoxAssayCode";
      this.TextBoxAssayCode.Size = new Size(104, 23);
      this.TextBoxAssayCode.TabIndex = 301;
      this.CheckBoxAssayActive.AutoSize = true;
      this.CheckBoxAssayActive.Location = new Point(405, 192);
      this.CheckBoxAssayActive.Name = "CheckBoxAssayActive";
      this.CheckBoxAssayActive.Size = new Size(56, 17);
      this.CheckBoxAssayActive.TabIndex = 300;
      this.CheckBoxAssayActive.Text = "Active";
      this.CheckBoxAssayActive.UseVisualStyleBackColor = true;
      this.Label8.AutoSize = true;
      this.Label8.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label8.Location = new Point(12, 31);
      this.Label8.Name = "Label8";
      this.Label8.Size = new Size(85, 17);
      this.Label8.TabIndex = 294;
      this.Label8.Text = "LIS Machine";
      this.TextBoxSearchValue.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.TextBoxSearchValue.BackColor = Color.AliceBlue;
      this.TextBoxSearchValue.BorderStyle = BorderStyle.FixedSingle;
      this.TextBoxSearchValue.Font = new Font("Microsoft Sans Serif", 11f);
      this.TextBoxSearchValue.ForeColor = Color.Black;
      this.TextBoxSearchValue.Location = new Point(6, 14);
      this.TextBoxSearchValue.Margin = new Padding(0);
      this.TextBoxSearchValue.Name = "TextBoxSearchValue";
      this.TextBoxSearchValue.Size = new Size((int) byte.MaxValue, 24);
      this.TextBoxSearchValue.TabIndex = 242;
      this.Label2.AutoSize = true;
      this.Label2.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label2.Location = new Point(12, 147);
      this.Label2.Name = "Label2";
      this.Label2.Size = new Size(60, 17);
      this.Label2.TabIndex = 305;
      this.Label2.Text = "Protocol";
      this.ComboBoxTestFileMachineName.FormattingEnabled = true;
      ComboBox.ObjectCollection items1 = this.ComboBoxTestFileMachineName.Items;
      object[] items2 = new object[14];
      int index1 = 0;
      string str1 = "ARCHITECT";
      items2[index1] = (object) str1;
      int index2 = 1;
      string str2 = "ELITE";
      items2[index2] = (object) str2;
      int index3 = 2;
      string str3 = "Cell Dyn Rubi";
      items2[index3] = (object) str3;
      int index4 = 3;
      string str4 = "IMMULITE 2000";
      items2[index4] = (object) str4;
      int index5 = 4;
      string str5 = "SIEMENS ADVIA";
      items2[index5] = (object) str5;
      int index6 = 5;
      string str6 = "SIEMENS DIMENSION";
      items2[index6] = (object) str6;
      int index7 = 6;
      string str7 = "ADAMS A1c HA";
      items2[index7] = (object) str7;
      int index8 = 7;
      string str8 = "Sysmex";
      items2[index8] = (object) str8;
      int index9 = 8;
      string str9 = "Biorad D10";
      items2[index9] = (object) str9;
      int index10 = 9;
      string str10 = "Biorad Variant";
      items2[index10] = (object) str10;
      int index11 = 10;
      string str11 = "Celltac Chemi";
      items2[index11] = (object) str11;
      int index12 = 11;
      string str12 = "VIDAS";
      items2[index12] = (object) str12;
      int index13 = 12;
      string str13 = "Chemray";
      items2[index13] = (object) str13;
      int index14 = 13;
      string str14 = "Hemaray";
      items2[index14] = (object) str14;
      items1.AddRange(items2);
      this.ComboBoxTestFileMachineName.Location = new Point(115, 29);
      this.ComboBoxTestFileMachineName.Name = "ComboBoxTestFileMachineName";
      this.ComboBoxTestFileMachineName.Size = new Size(346, 21);
      this.ComboBoxTestFileMachineName.TabIndex = 303;
      this.Label17.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      this.Label17.BorderStyle = BorderStyle.Fixed3D;
      this.Label17.FlatStyle = FlatStyle.Flat;
      this.Label17.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label17.ForeColor = Color.Black;
      this.Label17.Location = new Point(499, 25);
      this.Label17.Name = "Label17";
      this.Label17.Size = new Size(72, 24);
      this.Label17.TabIndex = 299;
      this.Label17.Text = "Charges";
      this.Label17.TextAlign = ContentAlignment.MiddleLeft;
      this.GroupBoxSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.GroupBoxSearch.Controls.Add((Control) this.TextBoxSearchValue);
      this.GroupBoxSearch.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.GroupBoxSearch.ForeColor = Color.FromArgb(192, 0, 0);
      this.GroupBoxSearch.Location = new Point(583, 11);
      this.GroupBoxSearch.Name = "GroupBoxSearch";
      this.GroupBoxSearch.Size = new Size(267, 43);
      this.GroupBoxSearch.TabIndex = 298;
      this.GroupBoxSearch.TabStop = false;
      this.GroupBoxSearch.Text = "Search";
      this.Label15.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
      this.Label15.BorderStyle = BorderStyle.Fixed3D;
      this.Label15.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label15.ForeColor = SystemColors.ActiveBorder;
      this.Label15.Location = new Point(489, -1);
      this.Label15.Name = "Label15";
      this.Label15.Size = new Size(3, 415);
      this.Label15.TabIndex = 297;
      this.Label14.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      this.Label14.BorderStyle = BorderStyle.Fixed3D;
      this.Label14.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label14.ForeColor = SystemColors.ActiveBorder;
      this.Label14.Location = new Point(4, 361);
      this.Label14.Name = "Label14";
      this.Label14.Size = new Size(487, 3);
      this.Label14.TabIndex = 296;
      this.Label1.AutoSize = true;
      this.Label1.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label1.Location = new Point(12, 60);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(87, 17);
      this.Label1.TabIndex = 295;
      this.Label1.Text = "Assay Name";
      this.TextBoxAssayName.BorderStyle = BorderStyle.FixedSingle;
      this.TextBoxAssayName.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.TextBoxAssayName.Location = new Point(115, 56);
      this.TextBoxAssayName.MaxLength = 100;
      this.TextBoxAssayName.Name = "TextBoxAssayName";
      this.TextBoxAssayName.Size = new Size(194, 23);
      this.TextBoxAssayName.TabIndex = 291;
      this.DataGridView1.AllowUserToAddRows = false;
      this.DataGridView1.AllowUserToDeleteRows = false;
      this.DataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      DataGridViewColumnCollection columns = this.DataGridView1.Columns;
      DataGridViewColumn[] dataGridViewColumnArray = new DataGridViewColumn[6];
      int index15 = 0;
      DataGridViewTextBoxColumn machineName = this.MachineName;
      dataGridViewColumnArray[index15] = (DataGridViewColumn) machineName;
      int index16 = 1;
      DataGridViewTextBoxColumn assayName = this.AssayName;
      dataGridViewColumnArray[index16] = (DataGridViewColumn) assayName;
      int index17 = 2;
      DataGridViewTextBoxColumn assayCode = this.AssayCode;
      dataGridViewColumnArray[index17] = (DataGridViewColumn) assayCode;
      int index18 = 3;
      DataGridViewTextBoxColumn assayType = this.AssayType;
      dataGridViewColumnArray[index18] = (DataGridViewColumn) assayType;
      int index19 = 4;
      DataGridViewTextBoxColumn assayProtocol = this.AssayProtocol;
      dataGridViewColumnArray[index19] = (DataGridViewColumn) assayProtocol;
      int index20 = 5;
      DataGridViewTextBoxColumn assayActive = this.AssayActive;
      dataGridViewColumnArray[index20] = (DataGridViewColumn) assayActive;
      columns.AddRange(dataGridViewColumnArray);
      this.DataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;
      this.DataGridView1.Location = new Point(498, 60);
      this.DataGridView1.Name = "DataGridView1";
      this.DataGridView1.ReadOnly = true;
      this.DataGridView1.Size = new Size(353, 344);
      this.DataGridView1.TabIndex = 293;
      this.MachineName.HeaderText = "Machine Name";
      this.MachineName.Name = "MachineName";
      this.MachineName.ReadOnly = true;
      this.MachineName.Width = 120;
      this.AssayName.HeaderText = "Assay Name";
      this.AssayName.Name = "AssayName";
      this.AssayName.ReadOnly = true;
      this.AssayCode.HeaderText = "Assay Code";
      this.AssayCode.Name = "AssayCode";
      this.AssayCode.ReadOnly = true;
      this.AssayType.HeaderText = "Assay Type";
      this.AssayType.Name = "AssayType";
      this.AssayType.ReadOnly = true;
      this.AssayProtocol.HeaderText = "Assay Protocol";
      this.AssayProtocol.Name = "AssayProtocol";
      this.AssayProtocol.ReadOnly = true;
      this.AssayActive.HeaderText = "Active";
      this.AssayActive.Name = "AssayActive";
      this.AssayActive.ReadOnly = true;
      this.btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      this.btnSave.Location = new Point(405, 377);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new Size(75, 24);
      this.btnSave.TabIndex = 292;
      this.btnSave.Text = "&Save";
      this.DataGridViewTextBoxColumn1.HeaderText = "Machine Name";
      this.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1";
      this.DataGridViewTextBoxColumn1.Width = 120;
      this.DataGridViewTextBoxColumn2.HeaderText = "Assay Name";
      this.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2";
      this.DataGridViewTextBoxColumn3.HeaderText = "Assay Code";
      this.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3";
      this.DataGridViewTextBoxColumn4.HeaderText = "Assay Protocol";
      this.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4";
      this.DataGridViewTextBoxColumn5.HeaderText = "Active";
      this.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5";
      this.Label3.AutoSize = true;
      this.Label3.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label3.Location = new Point(12, 118);
      this.Label3.Name = "Label3";
      this.Label3.Size = new Size(82, 17);
      this.Label3.TabIndex = 307;
      this.Label3.Text = "Assay Type";
      this.TextBoxAssayType.BorderStyle = BorderStyle.FixedSingle;
      this.TextBoxAssayType.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.TextBoxAssayType.Location = new Point(115, 114);
      this.TextBoxAssayType.MaxLength = 100;
      this.TextBoxAssayType.Name = "TextBoxAssayType";
      this.TextBoxAssayType.Size = new Size(141, 23);
      this.TextBoxAssayType.TabIndex = 306;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(855, 413);
      this.Controls.Add((Control) this.Label3);
      this.Controls.Add((Control) this.TextBoxAssayType);
      this.Controls.Add((Control) this.TextBoxAssayProtocol);
      this.Controls.Add((Control) this.Label5);
      this.Controls.Add((Control) this.TextBoxAssayCode);
      this.Controls.Add((Control) this.CheckBoxAssayActive);
      this.Controls.Add((Control) this.Label8);
      this.Controls.Add((Control) this.Label2);
      this.Controls.Add((Control) this.ComboBoxTestFileMachineName);
      this.Controls.Add((Control) this.Label17);
      this.Controls.Add((Control) this.GroupBoxSearch);
      this.Controls.Add((Control) this.Label15);
      this.Controls.Add((Control) this.Label14);
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.TextBoxAssayName);
      this.Controls.Add((Control) this.DataGridView1);
      this.Controls.Add((Control) this.btnSave);
      this.Name = "PMS_LISAssayList";
      this.Text = "LIS Assay List";
      this.WindowState = FormWindowState.Maximized;
      this.GroupBoxSearch.ResumeLayout(false);
      this.GroupBoxSearch.PerformLayout();
      this.DataGridView1.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private void PMS_LISAssayList_Load(object sender, EventArgs e)
    {
      RegisterMicrosoftVisualStudio.SqlText = "SELECT [MachineName],[AssayName],[AssayCode],[AssayType],[AssayProtocol],[AssayActive] FROM [LISAssayList]";
      this.LoadDataP(RegisterMicrosoftVisualStudio.SqlText);
      this.WindowState = FormWindowState.Maximized;
      this.GroupBoxSearch.Text = "Search by - " + this.DataGridView1.Columns[0].HeaderText;
      this.TextBoxAssayName.Focus();
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      OleDbCommand oleDbCommand = new OleDbCommand(RegisterMicrosoftVisualStudio.SqlText, RegisterMicrosoftVisualStudio.Conn);
      object obj = (object) this;
      RegisterMicrosoftVisualStudio.SingleQuoteReplace(ref obj);
      if (this.NotValidData())
        return;
      string t1 = "LISAssayList";
      string f1 = "AssayName";
      string[] strArray1 = new string[5];
      int index1 = 0;
      string str1 = "SELECT [AssayName] FROM [LISAssayList] Where [MachineName]='";
      strArray1[index1] = str1;
      int index2 = 1;
      string text1 = this.ComboBoxTestFileMachineName.Text;
      strArray1[index2] = text1;
      int index3 = 2;
      string str2 = "' and [AssayName]='";
      strArray1[index3] = str2;
      int index4 = 3;
      string text2 = this.TextBoxAssayName.Text;
      strArray1[index4] = text2;
      int index5 = 4;
      string str3 = "'";
      strArray1[index5] = str3;
      string str4 = string.Concat(strArray1);
      string str5;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(RegisterMicrosoftVisualStudio.GetSingleData(t1, f1, str4), "", false) == 0)
      {
        string[] strArray2 = new string[13];
        int index6 = 0;
        string str6 = "INSERT INTO LISAssayList ([MachineName],[AssayName],[AssayCode],[AssayType],[AssayProtocol],[AssayActive]) VALUES ('";
        strArray2[index6] = str6;
        int index7 = 1;
        string text3 = this.ComboBoxTestFileMachineName.Text;
        strArray2[index7] = text3;
        int index8 = 2;
        string str7 = "','";
        strArray2[index8] = str7;
        int index9 = 3;
        string text4 = this.TextBoxAssayName.Text;
        strArray2[index9] = text4;
        int index10 = 4;
        string str8 = "','";
        strArray2[index10] = str8;
        int index11 = 5;
        string text5 = this.TextBoxAssayCode.Text;
        strArray2[index11] = text5;
        int index12 = 6;
        string str9 = "','";
        strArray2[index12] = str9;
        int index13 = 7;
        string text6 = this.TextBoxAssayType.Text;
        strArray2[index13] = text6;
        int index14 = 8;
        string str10 = "','";
        strArray2[index14] = str10;
        int index15 = 9;
        string text7 = this.TextBoxAssayProtocol.Text;
        strArray2[index15] = text7;
        int index16 = 10;
        string str11 = "','";
        strArray2[index16] = str11;
        int index17 = 11;
        string str12 = Conversions.ToString(this.CheckBoxAssayActive.Checked);
        strArray2[index17] = str12;
        int index18 = 12;
        string str13 = "')";
        strArray2[index18] = str13;
        str5 = string.Concat(strArray2);
      }
      else
      {
        if (MessageBox.Show("Assay exists, do you want to overwrite?", RegisterMicrosoftVisualStudio.mazedatech, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
          return;
        string[] strArray2 = new string[13];
        int index6 = 0;
        string str6 = "UPDATE LISAssayList SET AssayCode = '";
        strArray2[index6] = str6;
        int index7 = 1;
        string text3 = this.TextBoxAssayCode.Text;
        strArray2[index7] = text3;
        int index8 = 2;
        string str7 = "',[AssayType]='";
        strArray2[index8] = str7;
        int index9 = 3;
        string text4 = this.TextBoxAssayType.Text;
        strArray2[index9] = text4;
        int index10 = 4;
        string str8 = "', AssayProtocol = '";
        strArray2[index10] = str8;
        int index11 = 5;
        string text5 = this.TextBoxAssayProtocol.Text;
        strArray2[index11] = text5;
        int index12 = 6;
        string str9 = "', AssayActive ='";
        strArray2[index12] = str9;
        int index13 = 7;
        string str10 = Conversions.ToString(this.CheckBoxAssayActive.Checked);
        strArray2[index13] = str10;
        int index14 = 8;
        string str11 = "' Where [MachineName]='";
        strArray2[index14] = str11;
        int index15 = 9;
        string text6 = this.ComboBoxTestFileMachineName.Text;
        strArray2[index15] = text6;
        int index16 = 10;
        string str12 = "' and [AssayName]='";
        strArray2[index16] = str12;
        int index17 = 11;
        string text7 = this.TextBoxAssayName.Text;
        strArray2[index17] = text7;
        int index18 = 12;
        string str13 = "'";
        strArray2[index18] = str13;
        str5 = string.Concat(strArray2);
      }
      oleDbCommand.CommandType = CommandType.Text;
      oleDbCommand.CommandText = str5;
      RegisterMicrosoftVisualStudio.Conn.Open();
      try
      {
        oleDbCommand.ExecuteNonQuery();
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
      int num1 = (int) MessageBox.Show("Record saved properly.", RegisterMicrosoftVisualStudio.mazedatech, MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
      string[] strArray3 = new string[5];
      int index19 = 0;
      string str14 = "SELECT [MachineName],[AssayName],[AssayCode],[AssayType],[AssayProtocol],[AssayActive] FROM [LISAssayList] WHERE [MachineName]='";
      strArray3[index19] = str14;
      int index20 = 1;
      string text8 = this.ComboBoxTestFileMachineName.Text;
      strArray3[index20] = text8;
      int index21 = 2;
      string str15 = "' and [AssayName]='";
      strArray3[index21] = str15;
      int index22 = 3;
      string text9 = this.TextBoxAssayName.Text;
      strArray3[index22] = text9;
      int index23 = 4;
      string str16 = "'";
      strArray3[index23] = str16;
      RegisterMicrosoftVisualStudio.SqlText = string.Concat(strArray3);
      this.LoadDataP(RegisterMicrosoftVisualStudio.SqlText);
    }

    private bool NotValidData()
    {
      bool flag;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Strings.Trim(this.ComboBoxTestFileMachineName.Text), "", false) == 0)
      {
        int num = (int) MessageBox.Show("Provide Machine Name", RegisterMicrosoftVisualStudio.mazedatech, MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
        flag = true;
        this.ComboBoxTestFileMachineName.Focus();
      }
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Strings.Trim(this.TextBoxAssayName.Text), "", false) == 0)
      {
        int num = (int) MessageBox.Show("Provide Assay Name", RegisterMicrosoftVisualStudio.mazedatech, MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
        flag = true;
        this.TextBoxAssayName.Focus();
      }
      else
        flag = false;
      return flag;
    }

    private void LoadDataP(string SqlText)
    {
      RegisterMicrosoftVisualStudio.cmd = new OleDbCommand(SqlText, RegisterMicrosoftVisualStudio.Conn);
      RegisterMicrosoftVisualStudio.da.SelectCommand = RegisterMicrosoftVisualStudio.cmd;
      if (RegisterMicrosoftVisualStudio.ds.Tables["LISAssayListSetup"] != null)
        RegisterMicrosoftVisualStudio.ds.Tables["LISAssayListSetup"].Clear();
      ((DbDataAdapter) RegisterMicrosoftVisualStudio.da).Fill(RegisterMicrosoftVisualStudio.ds, "LISAssayListSetup");
      this.DataGridView1.Rows.Clear();
      DataTable dataTable = RegisterMicrosoftVisualStudio.ds.Tables["LISAssayListSetup"];
      int index1 = 0;
      int num = checked (dataTable.Rows.Count - 1);
      int index2 = 0;
      while (index2 <= num)
      {
        this.DataGridView1.Rows.Add();
        this.DataGridView1["MachineName", index1].Value = RuntimeHelpers.GetObjectValue(dataTable.Rows[index2]["MachineName"]);
        this.DataGridView1["AssayName", index1].Value = RuntimeHelpers.GetObjectValue(dataTable.Rows[index2]["AssayName"]);
        this.DataGridView1["AssayCode", index1].Value = RuntimeHelpers.GetObjectValue(dataTable.Rows[index2]["AssayCode"]);
        this.DataGridView1["AssayType", index1].Value = RuntimeHelpers.GetObjectValue(dataTable.Rows[index2]["AssayType"]);
        this.DataGridView1["AssayProtocol", index1].Value = RuntimeHelpers.GetObjectValue(dataTable.Rows[index2]["AssayProtocol"]);
        this.DataGridView1["AssayActive", index1].Value = RuntimeHelpers.GetObjectValue(dataTable.Rows[index2]["AssayActive"]);
        checked { ++index1; }
        checked { ++index2; }
      }
      if (RegisterMicrosoftVisualStudio.ds.Tables["LISAssayListSetup"].Rows.Count <= 0)
        return;
      this.LoadDataFromGrid();
    }

    private void LoadDataFromGrid()
    {
      int index = this.DataGridView1.CurrentRow.Index;
      DataGridView dataGridView1 = this.DataGridView1;
      this.TextBoxAssayCode.Text = Conversions.ToString(dataGridView1["AssayCode", index].Value);
      this.TextBoxAssayType.Text = Conversions.ToString(dataGridView1["AssayType", index].Value);
      this.TextBoxAssayProtocol.Text = Conversions.ToString(dataGridView1["AssayProtocol", index].Value);
      this.CheckBoxAssayActive.Checked = Conversions.ToBoolean(dataGridView1["AssayActive", index].Value);
    }

    private void TextBoxAssayName_TextChanged(object sender, EventArgs e)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.TextBoxAssayName.Text, "", false) == 0)
      {
        RegisterMicrosoftVisualStudio.SqlText = "SELECT [MachineName],[AssayName],[AssayCode],[AssayType],[AssayProtocol],[AssayActive] FROM [LISAssayList]";
      }
      else
      {
        string[] strArray = new string[5];
        int index1 = 0;
        string str1 = "SELECT [MachineName],[AssayName],[AssayCode],[AssayType],[AssayProtocol],[AssayActive] FROM [LISAssayList] WHERE MachineName='";
        strArray[index1] = str1;
        int index2 = 1;
        string text = this.ComboBoxTestFileMachineName.Text;
        strArray[index2] = text;
        int index3 = 2;
        string str2 = "' and AssayName = '";
        strArray[index3] = str2;
        int index4 = 3;
        string str3 = Strings.Trim(this.TextBoxAssayName.Text);
        strArray[index4] = str3;
        int index5 = 4;
        string str4 = "'";
        strArray[index5] = str4;
        RegisterMicrosoftVisualStudio.SqlText = string.Concat(strArray);
      }
      this.LoadDataP(RegisterMicrosoftVisualStudio.SqlText);
    }

    private void DataGridView1_DoubleClick(object sender, EventArgs e)
    {
      this.TextBoxAssayName.Text = "";
    }

    private void DataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
    {
      DataGridViewCell currentCell = this.DataGridView1.CurrentCell;
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1[0, currentCell.RowIndex].Value)))
        return;
      this.ComboBoxTestFileMachineName.Text = Conversions.ToString(this.DataGridView1[0, currentCell.RowIndex].Value);
      this.TextBoxAssayName.Text = Conversions.ToString(this.DataGridView1[1, currentCell.RowIndex].Value);
    }

    private void btnSave_GotFocus(object sender, EventArgs e)
    {
      this.btnSave.ForeColor = Color.Red;
    }

    private void btnSave_LostFocus(object sender, EventArgs e)
    {
      this.btnSave.ForeColor = Color.Black;
    }

    private void btnSave_MouseHover(object sender, EventArgs e)
    {
      this.btnSave.ForeColor = Color.Red;
    }

    private void btnSave_MouseLeave(object sender, EventArgs e)
    {
      this.btnSave.ForeColor = Color.Black;
    }

    public void passCombobox(ref ComboBox pcbo, int pchecker)
    {
      this.cbo = pcbo;
      this.Checker = pchecker;
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

    private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex == -1 || e.ColumnIndex == -1)
        return;
      this.GroupBoxSearch.Text = "Search by - " + this.DataGridView1.Columns[e.ColumnIndex].HeaderText;
      this.col = e.ColumnIndex;
    }
  }
}

