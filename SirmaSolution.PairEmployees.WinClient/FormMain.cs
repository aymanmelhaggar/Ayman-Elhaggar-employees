using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SirmaSolution.PairEmployees.WinClient
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FormDateFormatPicker formDateFormatPicker = new FormDateFormatPicker();
                if(formDateFormatPicker.ShowDialog() == DialogResult.OK)
                {
                    List<Employee> employees = null;
                    try
                    {
                        EmployeeFileReader.DateFormat = formDateFormatPicker.comboBoxDateFormats.SelectedItem.ToString() == "Other" ? formDateFormatPicker.textBoxOther.Text : formDateFormatPicker.comboBoxDateFormats.SelectedItem.ToString();
                        employees = EmployeeFileReader.ReadEmployeeFile(openFileDialog.FileName);
                    }
                    catch (Exception ex)
                    {
                        if (ex is ArgumentOutOfRangeException || ex is FormatException || ex is System.IO.IOException)
                        {
                            MessageBox.Show("Read Employee File Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else MessageBox.Show("Unknown Read Employee File Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    List<ProjectEmployeePair> projectEmployeePairPairs = ProjectEmployeePairFinder.GetProjectEmployeePairs(employees);

                    dataGridViewPairEmployees.DataSource = null;
                    
                    if (projectEmployeePairPairs.Count > 0)
                    {
                        projectEmployeePairPairs = projectEmployeePairPairs.OrderByDescending(e => e.DaysWorked).ToList();

                        dataGridViewPairEmployees.DataSource = projectEmployeePairPairs;
                    }
                    else MessageBox.Show("No Match Found");
                }
            }
        }
    }
}
