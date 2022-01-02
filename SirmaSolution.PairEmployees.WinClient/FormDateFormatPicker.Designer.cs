
namespace SirmaSolution.PairEmployees.WinClient
{
    partial class FormDateFormatPicker
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
            this.comboBoxDateFormats = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxOther = new System.Windows.Forms.TextBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxDateFormats
            // 
            this.comboBoxDateFormats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDateFormats.FormattingEnabled = true;
            this.comboBoxDateFormats.Items.AddRange(new object[] {
            "Auto",
            "yyyy-MM-dd",
            "yyyy/MM/dd",
            "Other"});
            this.comboBoxDateFormats.Location = new System.Drawing.Point(68, 12);
            this.comboBoxDateFormats.Name = "comboBoxDateFormats";
            this.comboBoxDateFormats.Size = new System.Drawing.Size(268, 23);
            this.comboBoxDateFormats.TabIndex = 0;
            this.comboBoxDateFormats.SelectedIndexChanged += new System.EventHandler(this.comboBoxDateFormats_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Format:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Other:";
            // 
            // textBoxOther
            // 
            this.textBoxOther.Enabled = false;
            this.textBoxOther.Location = new System.Drawing.Point(68, 41);
            this.textBoxOther.Name = "textBoxOther";
            this.textBoxOther.Size = new System.Drawing.Size(268, 23);
            this.textBoxOther.TabIndex = 1;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(259, 72);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 2;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // FormDateFormatPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 107);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.textBoxOther);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxDateFormats);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDateFormatPicker";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Date Format";
            this.Load += new System.EventHandler(this.FormDateFormatPicker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonLoad;
        public System.Windows.Forms.ComboBox comboBoxDateFormats;
        public System.Windows.Forms.TextBox textBoxOther;
    }
}