
namespace SirmaSolution.PairEmployees.WinClient
{
    partial class FormMain
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
            this.dataGridViewPairEmployees = new System.Windows.Forms.DataGridView();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.EmpID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpID2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaysWorked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPairEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPairEmployees
            // 
            this.dataGridViewPairEmployees.AllowUserToAddRows = false;
            this.dataGridViewPairEmployees.AllowUserToDeleteRows = false;
            this.dataGridViewPairEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPairEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPairEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmpID1,
            this.EmpID2,
            this.ProjectID,
            this.DaysWorked});
            this.dataGridViewPairEmployees.Location = new System.Drawing.Point(12, 50);
            this.dataGridViewPairEmployees.Name = "dataGridViewPairEmployees";
            this.dataGridViewPairEmployees.ReadOnly = true;
            this.dataGridViewPairEmployees.RowTemplate.Height = 25;
            this.dataGridViewPairEmployees.Size = new System.Drawing.Size(614, 227);
            this.dataGridViewPairEmployees.TabIndex = 0;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(539, 12);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(87, 32);
            this.buttonLoad.TabIndex = 1;
            this.buttonLoad.Text = "Load Text File";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Text files|*.txt";
            // 
            // EmpID1
            // 
            this.EmpID1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmpID1.DataPropertyName = "EmpID1";
            this.EmpID1.HeaderText = "Employee ID #1";
            this.EmpID1.Name = "EmpID1";
            this.EmpID1.ReadOnly = true;
            // 
            // EmpID2
            // 
            this.EmpID2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmpID2.DataPropertyName = "EmpID2";
            this.EmpID2.HeaderText = "Employee ID #2";
            this.EmpID2.Name = "EmpID2";
            this.EmpID2.ReadOnly = true;
            // 
            // ProjectID
            // 
            this.ProjectID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProjectID.DataPropertyName = "ProjectID";
            this.ProjectID.HeaderText = "Project ID";
            this.ProjectID.Name = "ProjectID";
            this.ProjectID.ReadOnly = true;
            // 
            // DaysWorked
            // 
            this.DaysWorked.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DaysWorked.DataPropertyName = "DaysWorked";
            this.DaysWorked.HeaderText = "Days worked";
            this.DaysWorked.Name = "DaysWorked";
            this.DaysWorked.ReadOnly = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 289);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.dataGridViewPairEmployees);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Win Client";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPairEmployees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPairEmployees;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpID1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpID2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaysWorked;
    }
}

