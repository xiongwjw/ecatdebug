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
    public partial class FormSetObjData : Form
    {
        public string NewValue = string.Empty;
        private List<KeyValue> _dataList = new List<KeyValue>();
        public FormSetObjData(string type, string key, string value)
        {
            InitializeComponent();
            txtDataType.Text = type;
            txtKey.Text = key;
            InitData(value);
            dgData.DataSource = _dataList;
        }

        private void InitData(string value)
        {
            string[] valueArr = value.Split(';');
            foreach (string item in valueArr)
            {
                KeyValue data = GetKeyValue(item);
                if (data != null)
                    _dataList.Add(data);
            }
        }
        private KeyValue GetKeyValue(string content)
        {
            string[] arr = content.Split(':');
            if(arr.Length==2)
            {
                return new KeyValue { Key=arr[0].Trim(),Value=arr[1].Trim()};
            }
            return null;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(changeList.Count<1)
            {
                MessageBox.Show("change nothing");
                return;
            }

            StringBuilder sb = new StringBuilder();
            foreach (KeyValue item in changeList)
            {
                sb.AppendFormat("{0}:{1}",item.Key,item.Value);
                sb.Append(";");
            }

            NewValue = sb.ToString();
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

        private List<KeyValue> changeList = new List<KeyValue>();

        private void dgData_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex>0)
            {
                string key = dgData[e.ColumnIndex-1, e.RowIndex].Value.ToString();
                string value = dgData[e.ColumnIndex, e.RowIndex].Value.ToString();
                InsertChangeList(new KeyValue {Key=key,Value=value});
            }
        }

        private void InsertChangeList(KeyValue item)
        {
            var record = changeList.FirstOrDefault(q => q.Key == item.Key);
            if (record != null)
                record.Value = item.Value;
            else
                changeList.Add(item);
        }
    }

    public class KeyValue
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }

}
