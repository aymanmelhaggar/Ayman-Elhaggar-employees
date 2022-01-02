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
    public partial class FormDateFormatPicker : Form
    {
        private void FormDateFormatPicker_Load(object sender, EventArgs e)
        {
            comboBoxDateFormats.SelectedItem = "Auto";
        }

        public FormDateFormatPicker()
        {
            InitializeComponent();
        }

        private void comboBoxDateFormats_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxOther.Text = "";
            textBoxOther.Enabled = comboBoxDateFormats.SelectedItem.ToString() == "Other";
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
