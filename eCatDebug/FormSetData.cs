using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eCatDebug
{
    public partial class FormSetData : Form
    {
        public string NewValue = string.Empty;
        public FormSetData(string type, string key, string value)
        {
            InitializeComponent();
            txtDataType.Text = type;
            txtKey.Text = key;
            txtOldValue.Text = value;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewValue.Text))
            {
                MessageBox.Show("The value can't be null or empty");
                txtNewValue.Focus();
                return;
            }
            NewValue = txtNewValue.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

    }
}
