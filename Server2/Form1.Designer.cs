namespace Server2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.InfoTxt = new System.Windows.Forms.RichTextBox();
            this.ConnectBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.IPTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // InfoTxt
            // 
            this.InfoTxt.Location = new System.Drawing.Point(202, 129);
            this.InfoTxt.Name = "InfoTxt";
            this.InfoTxt.ReadOnly = true;
            this.InfoTxt.Size = new System.Drawing.Size(670, 378);
            this.InfoTxt.TabIndex = 14;
            this.InfoTxt.Text = "";
            // 
            // ConnectBTN
            // 
            this.ConnectBTN.Location = new System.Drawing.Point(703, 537);
            this.ConnectBTN.Name = "ConnectBTN";
            this.ConnectBTN.Size = new System.Drawing.Size(94, 29);
            this.ConnectBTN.TabIndex = 13;
            this.ConnectBTN.Text = "Connect";
            this.ConnectBTN.UseVisualStyleBackColor = true;
            this.ConnectBTN.Click += new System.EventHandler(this.ConnectBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "IP";
            // 
            // IPTxt
            // 
            this.IPTxt.Location = new System.Drawing.Point(202, 70);
            this.IPTxt.Name = "IPTxt";
            this.IPTxt.ReadOnly = true;
            this.IPTxt.Size = new System.Drawing.Size(670, 27);
            this.IPTxt.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 636);
            this.Controls.Add(this.InfoTxt);
            this.Controls.Add(this.ConnectBTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IPTxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox InfoTxt;
        private Button ConnectBTN;
        private Label label1;
        private TextBox IPTxt;
    }
}