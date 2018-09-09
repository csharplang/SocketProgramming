namespace ServerAppGUI
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
            this.btnSendData = new System.Windows.Forms.Button();
            this.richSendData = new System.Windows.Forms.RichTextBox();
            this.lblListening = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSendData
            // 
            this.btnSendData.Location = new System.Drawing.Point(79, 208);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(153, 52);
            this.btnSendData.TabIndex = 3;
            this.btnSendData.Text = "Send Data";
            this.btnSendData.UseVisualStyleBackColor = true;
            this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
            // 
            // richSendData
            // 
            this.richSendData.Location = new System.Drawing.Point(51, 32);
            this.richSendData.Name = "richSendData";
            this.richSendData.Size = new System.Drawing.Size(243, 123);
            this.richSendData.TabIndex = 2;
            this.richSendData.Text = "";
            // 
            // lblListening
            // 
            this.lblListening.AutoSize = true;
            this.lblListening.Location = new System.Drawing.Point(76, 174);
            this.lblListening.Name = "lblListening";
            this.lblListening.Size = new System.Drawing.Size(0, 13);
            this.lblListening.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 331);
            this.Controls.Add(this.lblListening);
            this.Controls.Add(this.btnSendData);
            this.Controls.Add(this.richSendData);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSendData;
        private System.Windows.Forms.RichTextBox richSendData;
        private System.Windows.Forms.Label lblListening;
    }
}

