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
    public partial class FormSearch : Form
    {
        private List<DataItem> _dataList = new List<DataItem>();
        public FormSearch()
        {
            InitializeComponent();
            InitListView();
        }

        private void InitListView()
        {
            lvMain.Items.Clear();
            lvMain.FullRowSelect = true;
            lvMain.View = View.Details;
            lvMain.GridLines = true;
        }

        public void RefreshList(List<DataItem> list)
        {
            _dataList = list;
        }


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                List<DataItem> list = this._dataList.Where(q => q.Key.IndexOf(txtSearch.Text, StringComparison.OrdinalIgnoreCase) != -1).ToList();
                if (list != null)
                    ShowID(list);
            }
            else
                ShowID(this._dataList);
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (lvMain.SelectedItems.Count > 0)
                {
                    ListViewItem lv = lvMain.SelectedItems[0];
                    SelectLine = lv.Tag as DataItem;
                    this.DialogResult = DialogResult.OK;
                    this.Hide();
                }
            }
            else if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                if (lvMain.SelectedItems.Count > 0)
                {
                    lvMain.Select();
                }
            }
        }

        private void lvMain_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (lvMain.SelectedItems.Count > 0)
                {
                    ListViewItem lv = lvMain.SelectedItems[0];
                    SelectLine = lv.Tag as DataItem;
                    this.DialogResult = DialogResult.OK;
                    this.Hide();
                }
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Hide();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void ShowID(List<DataItem> dataList)
        {
            lvMain.Items.Clear();
            foreach (DataItem line in dataList)
            {
                ListViewItem lv = new ListViewItem();
                lv.Text = line.Type.ToString();
                lv.SubItems.Add(line.Key);
                lv.SubItems.Add(line.Value);
                lv.Tag = line;
                lvMain.Items.Add(lv);
            }
            if (lvMain.Items.Count > 0)
                lvMain.Items[0].Selected = true;
        }

        public DataItem SelectLine = null;

        private void lvMain_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lvMain.SelectedItems.Count > 0)
            {
                ListViewItem lv = lvMain.SelectedItems[0];
                SelectLine = lv.Tag as DataItem;
                this.DialogResult = DialogResult.OK;
                this.Hide();
            }
        }

        private void FormSearch_Shown(object sender, EventArgs e)
        {
            ShowID(this._dataList);
            txtSearch.Text = string.Empty;
            txtSearch.Select();
        }



    }
}
