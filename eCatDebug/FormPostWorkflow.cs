using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace eCatDebug
{



    public partial class FormPostWorkflow : Form
    {
        public string Workflow = string.Empty;
        public string ActionName = string.Empty;
        public FormPostWorkflow()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtWorkflow.Text) || string.IsNullOrEmpty(txtAction.Text))
            {
                MessageBox.Show("workflow or action can not be null");
                return;
            }

            this.Workflow = txtWorkflow.Text;
            this.ActionName = txtAction.Text;
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
