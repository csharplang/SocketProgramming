// Type: MTechERP.PMS_LISMonitor
// Assembly: MTechERP, Version=4.7.51.0, Culture=neutral, PublicKeyToken=null
// MVID: D0AABECB-CB7F-42E6-A234-0752CE355F07
// Assembly location: D:\CodeData\MTechERP -TMP\MTechERP.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace MTechERP
{
  [DesignerGenerated]
  public class PMS_LISMonitor : Form
  {
    private IContainer components;
    private Form CallingMDIForm;
    private Form CallingForm;
    private CheckBox checkboxlis;
    private int frmshown;

    internal virtual Label LabelMessage { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    public virtual TextBox TextBoxLISData { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button ButtonStop
    {
      get
      {
        return this._ButtonStop;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ButtonStop_Click);
        Button button1 = this._ButtonStop;
        if (button1 != null)
          button1.Click -= eventHandler;
        this._ButtonStop = value;
        Button button2 = this._ButtonStop;
        if (button2 == null)
          return;
        button2.Click += eventHandler;
      }
    }

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

    internal virtual TextBox TextBoxLISRespond { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

    public PMS_LISMonitor()
    {
      this.Closed += new EventHandler(this.PMS_LISMonitor_Closed);
      this.Load += new EventHandler(this.PMS_LISMonitor_Load);
      this.Shown += new EventHandler(this.PMS_LISMonitor_Shown);
      this.frmshown = 0;
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (PMS_LISMonitor));
      this.TextBoxLISData = new TextBox();
      this.LabelMessage = new Label();
      this.ButtonStop = new Button();
      this.TextBoxResponseMessage = new TextBox();
      this.TextBoxLISRespond = new TextBox();
      this.ButtonENQ = new Button();
      this.SuspendLayout();
      this.TextBoxLISData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.TextBoxLISData.BackColor = Color.Black;
      this.TextBoxLISData.ForeColor = Color.Yellow;
      this.TextBoxLISData.Location = new Point(1, 92);
      this.TextBoxLISData.Multiline = true;
      this.TextBoxLISData.Name = "TextBoxLISData";
      this.TextBoxLISData.Size = new Size(402, 517);
      this.TextBoxLISData.TabIndex = 652;
      this.TextBoxLISData.WordWrap = false;
      this.LabelMessage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      this.LabelMessage.BackColor = Color.Black;
      this.LabelMessage.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.LabelMessage.ForeColor = Color.Yellow;
      this.LabelMessage.Location = new Point(4, 4);
      this.LabelMessage.Name = "LabelMessage";
      this.LabelMessage.Size = new Size(398, 25);
      this.LabelMessage.TabIndex = 653;
      this.LabelMessage.Text = "Label1";
      this.LabelMessage.TextAlign = ContentAlignment.MiddleCenter;
      this.ButtonStop.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.ButtonStop.Location = new Point(359, 31);
      this.ButtonStop.Name = "ButtonStop";
      this.ButtonStop.Size = new Size(44, 60);
      this.ButtonStop.TabIndex = 654;
      this.ButtonStop.Text = "&Stop";
      this.ButtonStop.UseVisualStyleBackColor = true;
      this.TextBoxResponseMessage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.TextBoxResponseMessage.BorderStyle = BorderStyle.FixedSingle;
      this.TextBoxResponseMessage.Location = new Point(55, 611);
      this.TextBoxResponseMessage.Multiline = true;
      this.TextBoxResponseMessage.Name = "TextBoxResponseMessage";
      this.TextBoxResponseMessage.Size = new Size(347, 18);
      this.TextBoxResponseMessage.TabIndex = 655;
      this.TextBoxLISRespond.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      this.TextBoxLISRespond.Location = new Point(3, 32);
      this.TextBoxLISRespond.Multiline = true;
      this.TextBoxLISRespond.Name = "TextBoxLISRespond";
      this.TextBoxLISRespond.ScrollBars = ScrollBars.Vertical;
      this.TextBoxLISRespond.Size = new Size(354, 58);
      this.TextBoxLISRespond.TabIndex = 658;
      this.ButtonENQ.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      this.ButtonENQ.Location = new Point(1, 610);
      this.ButtonENQ.Name = "ButtonENQ";
      this.ButtonENQ.Size = new Size(53, 20);
      this.ButtonENQ.TabIndex = 659;
      this.ButtonENQ.Text = "ENQ";
      this.ButtonENQ.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(405, 630);
      this.Controls.Add((Control) this.ButtonENQ);
      this.Controls.Add((Control) this.TextBoxLISRespond);
      this.Controls.Add((Control) this.TextBoxResponseMessage);
      this.Controls.Add((Control) this.ButtonStop);
      this.Controls.Add((Control) this.LabelMessage);
      this.Controls.Add((Control) this.TextBoxLISData);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = "PMS_LISMonitor";
      this.Text = "MAZEDATECH LIS";
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    public void ShowMonitor(ref Form MDIfrm, ref Form frm, ref CheckBox chkboxLIS)
    {
      try
      {
        this.CallingMDIForm = MDIfrm;
        this.CallingForm = frm;
        this.checkboxlis = chkboxLIS;
        this.ButtonENQ.Enabled = ((PMS_DataImport) this.CallingForm).ButtonENQ.Enabled;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) MessageBox.Show(ex.Message, "Show Monitor");
        ProjectData.ClearProjectError();
      }
    }

    private void PMS_LISMonitor_Closed(object sender, EventArgs e)
    {
      try
      {
        this.checkboxlis.Checked = false;
        ((Control) this.CallingMDIForm).Show();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) MessageBox.Show(ex.Message, "LIS Monitor Close.");
        ProjectData.ClearProjectError();
      }
    }

    private void PMS_LISMonitor_Load(object sender, EventArgs e)
    {
      this.TextBoxLISData.ScrollBars = ScrollBars.Both;
      this.Text = "MAZEDATECH-LIS-" + ((PMS_DataImport) this.CallingForm).ComboBoxTestFileMachineName.Text;
    }

    private void ButtonStop_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void TextBoxResponseMessage_TextChanged(object sender, EventArgs e)
    {
      ((PMS_DataImport) this.CallingForm).TextBoxResponseMessage.Text = this.TextBoxResponseMessage.Text;
    }

    private void ButtonENQ_Click(object sender, EventArgs e)
    {
      ((PMS_DataImport) this.CallingForm).ButtonENQ.PerformClick();
    }

    private void PMS_LISMonitor_Shown(object sender, EventArgs e)
    {
      this.frmshown = 1;
    }
  }
}

