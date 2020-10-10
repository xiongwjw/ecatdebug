using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using eCatDebug.eCATObservor.eCATInspector;
using System.ServiceModel;
//using eCATInspectorSerivceProtocol;
using System.Diagnostics;
using System.Threading;
using System.IO;
using System.Xml;

namespace eCatDebug
{
    public delegate void UpdateDataHandler(string argKey,
                                            string argValue,
                                            DataCacheType argType,
                                            string argDateTime);

    public delegate void DataClearHandler(DataCacheType argType,
                                           string argDateTime);

    public delegate void DataDeletedHandler(string argKey,
                                             DataCacheType argType,
                                             string argDateTime);

    public delegate void PackMessageHandler(string timeStamp, Dictionary<string, string> dict);

    public delegate void UnPackMessageHandler(string timeStamp, Dictionary<string, string> dict);

    public partial class FormObserver : Form
    {
        public FormObserver()
        {
            m_updateDataHandler = (UpdateDataHandler)Delegate.CreateDelegate(typeof(UpdateDataHandler), this, "UpdateData");
            m_dataClearHandler = (DataClearHandler)Delegate.CreateDelegate(typeof(DataClearHandler), this, "HandleDataClear");
            m_dataDeletedHandler = (DataDeletedHandler)Delegate.CreateDelegate(typeof(DataDeletedHandler), this, "HandleDataDeleted");
            m_packMessageHandler = (PackMessageHandler)Delegate.CreateDelegate(typeof(PackMessageHandler), this, "PackMessage");
            m_unpackMessageHandler = (UnPackMessageHandler)Delegate.CreateDelegate(typeof(UnPackMessageHandler), this, "UnPackMessage");

            InitializeComponent();

            //CheckAndReviseConfigFile();

            //CopyOurService();

            m_visibleCount = (int)((listBoxLog.Height - SystemInformation.HorizontalScrollBarHeight) / listBoxLog.ItemHeight);

            DateTime now = DateTime.Now;
            m_backupFileName = string.Format(@"{8}\Observer\eCATObserverLog_{0:D4}{1:D2}{2:D3}{3:D2}{4:D2}{5:D2}{6:D2}_{7}.txt",
                                              now.Year,
                                              now.Month,
                                              now.Day,
                                              now.Hour,
                                              now.Minute,
                                              now.Second,
                                              now.Millisecond,
                                              m_fileCount,
                                              AppDomain.CurrentDomain.BaseDirectory);
            string dir = string.Format(@"{0}\Observer\", AppDomain.CurrentDomain.BaseDirectory);
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            try
            {
                m_graphic = Graphics.FromHwnd(this.Handle);

                //LoginIn("grgbaning", "002152");
            }
            catch (System.Exception ex)
            {
                Log.Debug(ex);
                //MessageBox.Show(this, string.Format("Failed to connect eCAT distribute service \n [{0}]", ex.Message), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                //buttonDisconnect_Click(null, null);
            }
        }

        private string GetNodeAttrValue(string key, XmlNode xmlNode)
        {
            if (xmlNode == null || xmlNode.Attributes == null)
                return string.Empty;
            XmlAttributeCollection xmlAttr = xmlNode.Attributes;
            for (int i = 0; i < xmlAttr.Count; i++)
            {
                if (xmlAttr.Item(i).Name.ToUpper() == key.ToUpper())
                {
                    return xmlAttr.Item(i).Value;
                }
            }
            return string.Empty;
        }

        private void SetNodeAttrValue(string key, string value, XmlNode xmlNode)
        {

            XmlAttributeCollection xmlAttr = xmlNode.Attributes;
            for (int i = 0; i < xmlAttr.Count; i++)
            {
                if (xmlAttr.Item(i).Name.ToUpper() == key.ToUpper())
                {
                    xmlAttr.Item(i).Value = value;
                    return;
                }
            }
            //can't find so add here
            XmlAttribute nodeAttribute = xmlNode.OwnerDocument.CreateAttribute(key);
            nodeAttribute.Value = value;
            xmlNode.Attributes.Append(nodeAttribute);

        }

        private void CopyOurService(string ecatFolder)
        {
            try
            {
                if (!Directory.Exists(ecatFolder))
                    return;
                string serviceFile = Path.Combine(ecatFolder, @"DistributedService\eCATInspectorService.dll");
                string protocolFile = Path.Combine(ecatFolder, @"Protocol\DistributedService\eCATInspectorSerivceProtocol.dll");
                File.Copy(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"InstallService\eCATInspectorService.dll"), serviceFile, true);
                File.Copy(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"InstallService\eCATInspectorSerivceProtocol.dll"), protocolFile, true);

            }
            catch (System.Exception ex)
            {
                Log.Debug(ex);
            }
        }
        private void CheckAndReviseConfigFile(string ecatFolder)
        {
            try
            {
                if (!Directory.Exists(ecatFolder))
                    return;
                string configFile1 = Path.Combine(ecatFolder, @"config\Kernel\eCATBusinessConfig.xml");
                string configFile2 = Path.Combine(ecatFolder, @"config\Services\WCFServiceHostConfig.xml");
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(configFile1);
                XmlNode xmlNode = xmlDoc.SelectSingleNode("/BusinessService/Services/WCFServiceHost");
                if (xmlNode != null)
                    SetNodeAttrValue("enable", "1", xmlNode);
                xmlDoc.Save(configFile1);

                xmlDoc.Load(configFile2);
                xmlNode = xmlDoc.SelectSingleNode("/WCFConfig/Service[@name='Inspector']");
                if (xmlNode != null)
                    SetNodeAttrValue("enable", "1", xmlNode);
                xmlDoc.Save(configFile2);

            }
            catch (System.Exception ex)
            {
                Log.Debug(ex);
            }


        }

        public void OnDataChanged(string argkey,
                                   string argValue,
                                   DataCacheType type,
                                   string argDatetimeStamp)
        {
            this.BeginInvoke(m_updateDataHandler,
                              argkey,
                              argValue,
                              type,
                              argDatetimeStamp);
        }

        public void OnDataCacheClear(DataCacheType argType,
                                      string argDateTimestamp)
        {
            this.BeginInvoke(m_dataClearHandler,
                              argType,
                              argDateTimestamp);
        }

        public void OnDataDeleted(string argKey,
                                   DataCacheType argType,
                                   string argDateTimeStamp)
        {
            this.BeginInvoke(m_dataDeletedHandler,
                              argKey,
                              argType,
                              argDateTimeStamp);
        }

        public void OnPackMessage(string timeStamp, Dictionary<string, string> dict)
        {
            this.BeginInvoke(m_packMessageHandler, timeStamp, dict);
        }

        public void OnUnPackMessage(string timeStamp, Dictionary<string, string> dict)
        {
            this.BeginInvoke(m_unpackMessageHandler, timeStamp, dict);
        }

        private void UpdateStatusPanel(string key, string value)
        {
            switch (key)
            {
                case "CurrentWorkflowName":
                    this.lbCurrentWorkflowName.Text = value;
                    break;
                case "CurrentActionName":
                    this.lbCurrentActionName.Text = value;
                    break;
                case "LastActionName":
                    this.lbLastActionName.Text = value;
                    break;
                case "LastWorkflowName":
                    this.lbLastWorkflowName.Text = value;
                    break;
                case "ActionID":
                    this.lbActionID.Text = value;
                    break;
                case "ActionTimeout":
                    this.lbActionTimeout.Text = value;
                    break;
                case "LastNextCondition":
                    this.lbLastNextCondition.Text = value;
                    break;
                case "CurrentScreenName":
                    this.lbCurrentScreenName.Text = value;
                    break;
                case "CurrentUILanguage":
                    this.lbCurrentUILanguage.Text = value;
                    break;
            }
        }

        private bool LoginIn(string argName,
                              string argPassword)
        {
            eCATObservorCallback callback = new eCATObservorCallback(this);
            InstanceContext context = new InstanceContext(callback);
            m_inspectorService = new IeCATInspectorServiceClient(context);
            bool result = m_inspectorService.LoginIn(out m_accessToken, argName, argPassword);
            if (!result)
            {
                MessageBox.Show("Failed to connect eCAT distribute service", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            else
            {
                DataSnapShot snapShot = m_inspectorService.QuerySnapshotOfData(m_accessToken);
                if (null != snapShot)
                {
                    foreach (var item in snapShot.Items)
                    {
                        if (item.Type == DataCacheType.None)
                        {
                            UpdateStatusPanel(item.Key, item.Value);
                            RaiseNodeChangeEvent(item.Key, item.Value);
                        }
                        else
                            InsertDataList(item);
                    }

                    snapShot = null;
                }
                bool isListen =  m_inspectorService.ListenDataChanged(m_accessToken);

                m_timer = new System.Threading.Timer(new TimerCallback(OnHeartBeatTimer), null, 0, 2000);
               
                return true;

            }
        }

        private void RaiseNodeChangeEvent(string key, string value)
        {
            if (key == "CurrentWorkflowName" || key == "ActionID")
            {
                if (!string.IsNullOrEmpty(value) &&
                    !string.IsNullOrEmpty(this.lbCurrentWorkflowName.Text) &&
                    !string.IsNullOrEmpty(this.lbActionID.Text))
                {
                 //   Msger.FireOnFlowNodeChange(this.lbCurrentWorkflowName.Text, this.lbActionID.Text);
                }
            }
        }

        private void HandleDataClear(DataCacheType argType,
                                      string argDateTime)
        {
            string typedes = argType.ToString();
            AddLogInfo(string.Format(s_clearDataFormat,
                                      argDateTime,
                                      typedes));

            int total = listViewData.Items.Count;
            for (int i = 0; i < total;)
            {
                if ((DataCacheType)(listViewData.Items[i].Tag) == argType)
                {
                    AddLogInfo(string.Format(s_deleteDataFormat,
                                argDateTime,
                                (string)listViewData.Items[i].SubItems[1].Tag,
                                typedes));
                    listViewData.Items.RemoveAt(i);
                    --total;
                }
                else
                {
                    ++i;
                }
            }
        }

        private void HandleDataDeleted(string argKey,
                                        DataCacheType argType,
                                        string argDateTime)
        {
            string typedes = argType.ToString();
            int total = listViewData.Items.Count;
            for (int i = 0; i < total;)
            {
                if ((DataCacheType)(listViewData.Items[i].Tag) == argType &&
                     string.Equals(argKey, (string)listViewData.Items[i].Tag, StringComparison.Ordinal))
                {
                    AddLogInfo(string.Format(s_deleteDataFormat,
                    argDateTime,
                    (string)listViewData.Items[i].SubItems[1].Tag,
                    typedes));
                    listViewData.Items.RemoveAt(i);
                    --total;
                }
                else
                {
                    ++i;
                }
            }
        }

        private void UpdateData(string argkey,
                                   string argValue,
                                   DataCacheType type,
                                   string argDatetimeStamp)
        {
            if (type == DataCacheType.None)
            {
                UpdateStatusPanel(argkey, argValue);
                RaiseNodeChangeEvent(argkey, argValue);
                return;

            }

            ListViewItem item = FindExistItem(argkey, listViewData);
            if (null != item)
            {
                UpdateData(item, argValue, argDatetimeStamp);
            }
            else
            {
                AddData(argkey,
                         argValue,
                         type,
                         argDatetimeStamp, listViewData);
            }

            //add by wjw to update the watchList
            ListViewItem itemWatch = FindExistItem(argkey, listViewWatch);
            if (null != itemWatch)
            {
                UpdateData(itemWatch, argValue, argDatetimeStamp);
            }



        }


        private void ShowDict(Dictionary<string, string> dict)
        {
            if (dict == null)
                return;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine();
            foreach (KeyValuePair<string, string> item in dict)
            {
                sb.AppendLine(item.Key + ":" + item.Value);
            }
            ShowMessage(sb.ToString());
        }


        private void ShowMessage(string message)
        {
            if (rtMessage.Lines.Length > 400)
                rtMessage.Clear();
            rtMessage.SelectionColor = Color.Black;
            rtMessage.AppendText(DateTime.Now.ToString() + ":" + message);
            rtMessage.AppendText(Environment.NewLine);
            rtMessage.SelectionStart = rtMessage.Text.Length;
            rtMessage.ScrollToCaret();
        }


        private void PackMessage(string timeStamp, Dictionary<string, string> dict)
        {
            ShowMessage(timeStamp + "      Send to host.");
            ShowDict(dict);
        }

        private void UnPackMessage(string timeStamp, Dictionary<string, string> dict)
        {
            ShowMessage(timeStamp + "      Receive from host.");
            ShowDict(dict);
        }

        private void AddData(string argkey,
                             string argValue,
                             DataCacheType type,
                             string argDatetimeStamp,
                             ListView lv)
        {
            ListViewItem item = lv.Items.Add(type.ToString());
            ListViewItem.ListViewSubItem keyItem = item.SubItems.Add(argkey);
            keyItem.Tag = argkey;
            ListViewItem.ListViewSubItem valueItem = item.SubItems.Add(argValue);
            item.Tag = type;
            item.ForeColor = QueryColorByDataCacheType(type);

            //log
            AddLogInfo(string.Format(s_AddDataFormat,
                                     argDatetimeStamp,
                                     argkey,
                                     argValue));
        }

        private void UpdateData(ListViewItem argItem,
                                 string argValue,
                                 string argDateTimeStamp)
        {
            AddLogInfo(string.Format(s_updateDataFormat,
                                       argDateTimeStamp,
                                       argItem.SubItems[1].Text,
                                       argItem.SubItems[2].Text,
                                       argValue));

            argItem.SubItems[2].Text = argValue;
            argItem.SubItems[2].Tag = argValue;
            argItem.ForeColor = Color.Red;
        }

        private ListViewItem FindExistItem(string argKey, ListView lv)
        {
            foreach (ListViewItem item in lv.Items)
            {
                if (argKey.Equals((string)(item.SubItems[1].Tag), StringComparison.Ordinal))
                {
                    return item;
                }
            }

            return null;
        }

        private void InsertDataList(DataSnapShotItem argItem)
        {
            Debug.Assert(null != argItem);

            DateTime now = DateTime.Now;
            string dateTime = string.Format("{0:D2}:{1:D2}:{2:D2}.{3:D3}",
                                             now.Hour,
                                             now.Minute,
                                             now.Second,
                                             now.Millisecond);
            ListViewItem item = listViewData.Items.Add(argItem.Type.ToString());
            ListViewItem.ListViewSubItem KeyItem = item.SubItems.Add(argItem.Key);
            KeyItem.Tag = argItem.Key;
            ListViewItem.ListViewSubItem valueItem = item.SubItems.Add(argItem.Value);
            valueItem.Tag = argItem.Value;
            item.Tag = argItem.Type;
            item.ForeColor = QueryColorByDataCacheType(argItem.Type);

            //log
            AddLogInfo(string.Format(s_AddDataFormat,
                                                dateTime,
                                                argItem.Key,
                                                argItem.Value));
        }

        private void AddLogInfo(string argInfo)
        {
            Debug.Assert(null != m_graphic);

            SizeF size = m_graphic.MeasureString(argInfo, listBoxLog.Font);
            if (listBoxLog.HorizontalExtent < (int)size.Width)
            {
                listBoxLog.HorizontalExtent = (int)size.Width;
            }
            listBoxLog.Items.Add(argInfo);
            listBoxLog.TopIndex = listBoxLog.Items.Count - m_visibleCount;

            try
            {
                using (FileStream fs = new FileStream(m_backupFileName, FileMode.Append, FileAccess.Write))
                {
                    using (StreamWriter writer = new StreamWriter(fs, Encoding.UTF8))
                    {
                        writer.WriteLine(argInfo);
                    }
                }
            }
            catch (System.Exception ex)
            {

            }

            if (listBoxLog.Items.Count >= s_maxLogCount)
            {
                DateTime now = DateTime.Now;
                m_backupFileName = string.Format(@"{8}\Observer\eCATObserverLog_{0:D4}{1:D2}{2:D3}{3:D2}{4:D2}{5:D2}{6:D2}_{7}.txt",
                                                  now.Year,
                                                  now.Month,
                                                  now.Day,
                                                  now.Hour,
                                                  now.Minute,
                                                  now.Second,
                                                  now.Millisecond,
                                                  m_fileCount,
                                                  AppDomain.CurrentDomain.BaseDirectory);
                listBoxLog.Items.Clear();
            }
        }

        private void buttonSaveLog_Click(object sender, EventArgs e)
        {
            buttonSaveLog.Enabled = false;
            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.DefaultExt = ".txt";
                dlg.Title = "Save log file";
                dlg.CheckPathExists = true;
                dlg.Filter = "Log file(*.txt)|*.txt";
                if (DialogResult.OK == dlg.ShowDialog(this))
                {
                    try
                    {
                        using (FileStream fs = new FileStream(dlg.FileName, FileMode.Create, FileAccess.Write))
                        {
                            using (StreamWriter writer = new StreamWriter(fs, Encoding.UTF8))
                            {
                                foreach (var item in listBoxLog.Items)
                                {
                                    writer.WriteLine(item);
                                }
                                writer.Flush();
                            }
                        }

                        MessageBox.Show(this,
                                        "Success to save log",
                                        this.Text,
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show(this,
                                        "Failed to save log",
                                        this.Text,
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                }
            }


            buttonSaveLog.Enabled = true;
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (LoginIn("grgbanking", "002152"))
                    SetButtonEnable(true);
                else
                    DisConnect();
            }
            catch (System.Exception ex)
            {
                DisConnect();

                MessageBox.Show(this, string.Format("Failed to connect eCAT distribute service [{0}]", ex.Message), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void OnHeartBeatTimer(object argState)
        {
            if (null == m_inspectorService)
            {
                return;
            }

            try
            {
                m_inspectorService.Hearbeat(m_accessToken);
            }
            catch (System.Exception ex)
            {
                DisConnect();
            }
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            DisConnect();

        }

        private void DisConnect()
        {
            try
            {
                CloseClientServcie();
                SetButtonEnable(false);
                ClearAllData();
            }
            catch (System.Exception ex)
            {
                Log.Debug(ex);
           //     Loger.LogToAll(ex.Message);
            }
        }

        private void CloseClientServcie()
        {
            if (null != m_inspectorService)
            {
                if (m_inspectorService.State != CommunicationState.Faulted &&
                     m_inspectorService.State != CommunicationState.Closed)
                {
                    m_inspectorService.Close();
                }
                m_inspectorService = null;
            }
        }

        private void SetButtonEnable(bool isOpen)
        {
            buttonConnect.Enabled = !isOpen;
            buttonDisconnect.Enabled = isOpen;
            btnEndworkflow.Enabled = isOpen;
            btnPostWorkflow.Enabled = isOpen;
            btnReboot.Enabled = isOpen;
            btnShutDown.Enabled = isOpen;
            btnReload.Enabled = isOpen;
            btnReDraw.Enabled = isOpen;
            btnKileCat.Enabled = isOpen;
            btnStarteCat.Enabled = isOpen;
       //     btnShowUIPreview.Enabled = isOpen;
            buttonSaveLog.Enabled = isOpen;
         //   btnSearch.Enabled = isOpen;
        }

        private void ClearAllData()
        {
            ClearDataText();
            listBoxLog.Items.Clear();
            listViewData.Items.Clear();
            listViewWatch.Items.Clear();
            rtMessage.Text = string.Empty;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this,
                             "eCAT observer 1.0.0.0 \nCopyright. @Grgbanking co,ltd",
                             this.Text,
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Information);
        }

        private Color QueryColorByDataCacheType(DataCacheType argType)
        {
            Color clr = Color.Black;
            switch (argType)
            {
                case DataCacheType.None:
                    {
                        clr = Color.Green;
                    }
                    break;

                case DataCacheType.Transaction:
                    {
                        clr = Color.Blue;
                    }
                    break;

                case DataCacheType.CardHolder:
                    {
                        clr = SystemColors.WindowText;
                    }
                    break;

                case DataCacheType.Terminal:
                    {
                        clr = Color.Fuchsia;
                    }
                    break;
            }

            return clr;
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (UiConfig.uiPreviewer != null)
            //    UiConfig.uiPreviewer.OnPreviewClose -= new UIPreviewer.PreviewClosedHandler(uiPreviewer_OnPreviewClose);
            //e.Cancel = true;
            //this.Hide();
            //if (DialogResult.Yes == MessageBox.Show(this,
            //                                          "Do you want to close the eCAT observer?",
            //                                          this.Text,
            //                                          MessageBoxButtons.YesNo,
            //                                          MessageBoxIcon.Question))
            //{
            //    e.Cancel = false;
            //}
            //else
            //{
            //    e.Cancel = true;
            //}
        }

        public void CloseObserver()
        {
            try
            {
                buttonConnect.Enabled = true;
                buttonDisconnect.Enabled = false;
                if (null != m_inspectorService)
                {
                    m_inspectorService.LoginOff(m_accessToken);
                }
                m_inspectorService.Close();
                m_inspectorService = null;
            }
            catch (System.Exception ex)
            {
              //  Loger.WriteFile(ex.Message);
            }

            if (null != m_graphic)
            {
                m_graphic.Dispose();
                m_graphic = null;
            }

            if (null != m_timer)
            {
                m_timer.Dispose();
                m_timer = null;
            }
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseObserver();
        }

        #region field
        private IeCATInspectorServiceClient m_inspectorService = null;

        private int m_accessToken = 0;

        private System.Threading.Timer m_timer = null;

        private string m_backupFileName = null;

        private int m_fileCount = 0;

        private Graphics m_graphic = null;

        private int m_visibleCount = 0;

        private int s_maxLogCount = 10000;

        private UpdateDataHandler m_updateDataHandler = null;

        private DataClearHandler m_dataClearHandler = null;

        private DataDeletedHandler m_dataDeletedHandler = null;

        private PackMessageHandler m_packMessageHandler = null;

        private UnPackMessageHandler m_unpackMessageHandler = null;

        public const string s_AddDataFormat = "{0} - Add data key[{1}] value[{2}]";

        public const string s_updateDataFormat = "{0} - Update data key[{1}] old value[{2}] new value[{3}]";

        public const string s_deleteDataFormat = "{0} - Delete data key[{1}] with datacachetype[{2}]";

        public const string s_clearDataFormat = "{0} - All data with datacachetype[{1}] will be clear";
        #endregion
        //need to change here
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //if (txtSearch.Text.Trim() == string.Empty)
            //    return;
            //StringBuilder sb = new StringBuilder();
            //foreach (ListViewItem item in listViewData.Items)
            //{
            //    string itemKey = (string)(item.SubItems[1].Tag);
            //    if (itemKey.IndexOf(txtSearch.Text, StringComparison.OrdinalIgnoreCase) != -1)
            //    {
            //        string itemValue = (string)(item.SubItems[2].Text);
            //        sb.Append(itemKey + "==" + itemValue);
            //        sb.AppendLine();
            //    }
            //}
            //if (sb.Length > 0)
            //    MessageBox.Show(sb.ToString());
            //else
            //    MessageBox.Show("Can't find any datacache match the search text!");
        }

        private void listBoxLog_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeOtherToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // Msger.FireOnCloseOtherWinEvent();
        }

        private void listViewData_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listViewData.SelectedItems == null || listViewData.SelectedItems.Count < 1)
                return;
            ListViewItem lv = listViewData.SelectedItems[0];

            DataItem item = new DataItem
            {
                Type = (DataCacheType)(lv.Tag),
                Key=lv.SubItems[1].Text,
                Value=lv.SubItems[2].Text
            };

            ThreadPool.QueueUserWorkItem(SendChangeData, item);
          //  ChangeData(item);

            //FormSetData fs = new FormSetData(lv.Tag.ToString(), lv.SubItems[1].Text, lv.SubItems[2].Text);
            //DialogResult dr = fs.ShowDialog();
            //if (dr == DialogResult.OK)
            //{
            //    DataCacheType type = (DataCacheType)(lv.Tag);
            //    string key = lv.SubItems[1].Text;
            //    string value = fs.NewValue;
            //    m_inspectorService.ChangeDataCache(m_accessToken, type, key, value);
            //}
        }

        private void ChangeData(DataItem item)
        {
            try
            {
                if (item.Value.Contains(";"))//this is object?
                {
                    FormSetObjData fs = new FormSetObjData(item.Type.ToString(), item.Key, item.Value);
                    if (fs.ShowDialog() == DialogResult.OK)
                    {
                        m_inspectorService.ChangeDataCache(m_accessToken, item.Type, item.Key, fs.NewValue);
                    }
                }
                else
                {
                    FormSetData fs = new FormSetData(item.Type.ToString(), item.Key, item.Value);
                    DialogResult dr = fs.ShowDialog();
                    if (dr == DialogResult.OK)
                    {
                        m_inspectorService.ChangeDataCache(m_accessToken, item.Type, item.Key, fs.NewValue);
                    }
                }
            }
            catch (System.Exception ex)
            {
                Log.Debug(ex);
            }
        }

        private void SendChangeData(object state)
        {
            DataItem item = state as DataItem;
            ChangeData(item);
            //try
            //{
            //    if(item.Value.Contains(";"))//this is object?
            //    {
            //        FormSetObjData fs = new FormSetObjData(item.Type.ToString(), item.Key, item.Value);
            //        if(fs.ShowDialog()==DialogResult.OK)
            //        {
            //            m_inspectorService.ChangeDataCache(m_accessToken, item.Type, item.Key, fs.NewValue);
            //        }
            //    }
            //    else
            //    {
            //        FormSetData fs = new FormSetData(item.Type.ToString(), item.Key, item.Value);
            //        DialogResult dr = fs.ShowDialog();
            //        if (dr == DialogResult.OK)
            //        {
            //            m_inspectorService.ChangeDataCache(m_accessToken, item.Type, item.Key, fs.NewValue);
            //        }
            //    }
            //}
            //catch (System.Exception ex)
            //{
            //    Log.Debug(ex);
            //}
          
        }

       

        private FormSearch formSearch = new FormSearch();

        private void Search()
        {
            //refresh list
            List<DataItem> dataList = new List<DataItem>();
            foreach (ListViewItem lv in listViewData.Items)
            {
                DataCacheType type = (DataCacheType)(lv.Tag);
                string key = lv.SubItems[1].Text;
                string value = lv.SubItems[2].Text;
                dataList.Add(new DataItem {
                    Type=type,
                    Key = key,
                    Value=value
                });

            }

            formSearch.RefreshList(dataList);


            //show
            if (formSearch.ShowDialog()==DialogResult.OK)
            {
                DataItem item = formSearch.SelectLine;
                var checkItem = FindExistItem(item.Key, listViewWatch);
                if(checkItem==null)
                      AddData(item.Key, item.Value, item.Type, DateTime.Now.ToString(), listViewWatch);
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.Q))
            {
                Search();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }


        private void addToWatchListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewData.SelectedItems.Count < 1)
                return;
            ListViewItem lv = listViewData.SelectedItems[0];
            DataCacheType type = (DataCacheType)(lv.Tag);
            string key = lv.SubItems[1].Text;
            string value = lv.SubItems[2].Text;
            ListViewItem lvi = FindExistItem(key, listViewWatch);
            if (lvi == null)
                AddData(key, value, type, DateTime.Now.ToString(), listViewWatch);
        }

        private void removeFromWatchListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewWatch.SelectedItems.Count < 1)
                return;
            ListViewItem lv = listViewWatch.SelectedItems[0];
            listViewWatch.Items.Remove(lv);
        }

        private void btnEndworkflow_Click(object sender, EventArgs e)
        {
            if (m_inspectorService != null)
                m_inspectorService.EndCurrentWorkflow(m_accessToken);
        }

        private void btnReboot_Click(object sender, EventArgs e)
        {
            m_inspectorService.Reboot(m_accessToken);
        }

        private void btnPostWorkflow_Click(object sender, EventArgs e)
        {
            FormPostWorkflow form = new FormPostWorkflow();
            if (DialogResult.OK == form.ShowDialog())
            {
                m_inspectorService.ChangeWorkflow(m_accessToken, form.Workflow, form.ActionName);
            }
        }

        private void btnShutDown_Click(object sender, EventArgs e)
        {
            m_inspectorService.ShutDown(m_accessToken);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            try
            {
                m_inspectorService.ReLoadUI(m_accessToken);
            }
            catch (System.Exception ex)
            {
                Log.Debug(ex);
               // Loger.LogDebug(ex);
            }

        }

        private void btnReDraw_Click(object sender, EventArgs e)
        {
            try
            {
                m_inspectorService.ReDrawUI(m_accessToken);
            }
            catch (System.Exception ex)
            {
                Log.Debug(ex);
                //  Loger.LogDebug(ex);
            }


        }

        private void btnReStarteCat_Click(object sender, EventArgs e)
        {
            m_inspectorService.DebugReboot(m_accessToken);
            //StarteCat();

        }

        private void KilleCat()
        {
            string killFile = Path.Combine(Application.StartupPath, "KillATMC.bat");
            if (File.Exists(killFile))
            {
                Process.Start(killFile);
            }
        }

        private void StarteCat()
        {
            //string appName = Path.Combine(Common.GlobalVar.ProjectPath, "ecat.exe");
            //if (!File.Exists(appName))
            //{
            // //   Loger.PopMessage(UIManager.UIManagerImp.SingleInstance.LoadString("pop_noecat"));
            //    return;
            //}

            //ProcessStartInfo ps = new ProcessStartInfo()
            //{
            //    WorkingDirectory = Common.GlobalVar.ProjectPath,
            //    FileName = appName
            //};

            //Process proc = Process.Start(ps);
        }

        private void ClearDataText()
        {
            lbCurrentActionName.Text = string.Empty;
            lbCurrentWorkflowName.Text = string.Empty;
            lbCurrentScreenName.Text = string.Empty;
            lbLastActionName.Text = string.Empty;
            lbLastWorkflowName.Text = string.Empty;
            lbActionID.Text = string.Empty;
            lbLastNextCondition.Text = string.Empty;
            lbCurrentUILanguage.Text = string.Empty;
            lbActionTimeout.Text = string.Empty;
        }
        private void FormObserver_Load(object sender, EventArgs e)
        {
            ClearDataText();
            SetButtonEnable(false);
            //if (UiConfig.uiPreviewer != null)
            //    UiConfig.uiPreviewer.OnPreviewClose += new UIPreviewer.PreviewClosedHandler(uiPreviewer_OnPreviewClose);
        }

        private void uiPreviewer_OnPreviewClose()
        {
            isShowPreview = false;
        }

        private void lbCurrentWorkflowName_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //if (Common.GlobalVar.IsProjectOpen == false)
            //    return;
            //Flow flow = ProjectManager.Current.ProjectObject.FlowCollection.Find(q => q.Name == this.lbCurrentWorkflowName.Text);
            //if (flow != null)
            //{
            //    string fileName = Path.Combine(Common.GlobalVar.WorkflowPath, flow.Uri);
            //    if (File.Exists(fileName))
            //        Msger.FireOnOpenFlowEvent(flow, fileName);
            //    else
            //        Loger.WriteFile("open flow in observer ,fileName:" + fileName);
            //}
        }

        private void lbCurrentActionName_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void lbLastWorkflowName_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //if (Common.GlobalVar.IsProjectOpen == false)
            //    return;
            //Flow flow = ProjectManager.Current.ProjectObject.FlowCollection.Find(q => q.Name == this.lbLastActionName.Text);
            //if (flow != null)
            //{
            //    string fileName = Path.Combine(Common.GlobalVar.WorkflowPath, flow.Uri);
            //    Msger.FireOnOpenFlowEvent(flow, fileName);
            //}
        }

        private void lbLastActionName_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void lbCurrentScreenName_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //if (Common.GlobalVar.IsProjectOpen == false)
            //    return;
            //string fileName = UiConfig.uiServiceOperator.GetFullPathFromUiName(this.lbCurrentScreenName.Text);
            //if (string.IsNullOrEmpty(fileName))
            //{
            //    Msger.FireOnOpenPageEvent(fileName);
            //}
        }

        private void ShowUIPreview()
        {
            if (isShowPreview)
            {
                if (!string.IsNullOrEmpty(this.lbCurrentScreenName.Text))
                {
                    //UiConfig.uiPreviewer.ShowPreview(this.lbCurrentScreenName.Text);
                }
            }
        }

        private void lbCurrentWorkflowName_Click(object sender, EventArgs e)
        {

        }

        private bool isShowPreview = false;
        private void btnShowUIPreview_Click(object sender, EventArgs e)
        {
            //UiConfig.uiPreviewer.SetPreview(true);
            //isShowPreview = true;
            //if (!string.IsNullOrEmpty(this.lbCurrentScreenName.Text))
            //    UiConfig.uiPreviewer.ShowPreview(this.lbCurrentScreenName.Text);
        }

        private void btnKileCat_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fd = new FolderBrowserDialog();
            if(fd.ShowDialog()==DialogResult.OK)
            {
                CopyOurService(fd.SelectedPath);
                CheckAndReviseConfigFile(fd.SelectedPath);
            }



            //install service
            // KilleCat();
        }

        private void StartThread(WaitCallback action)
        {
            ThreadPool.QueueUserWorkItem(action);
        }


        private void listViewWatch_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            if (listViewWatch.SelectedItems == null || listViewWatch.SelectedItems.Count < 1)
                return;
            ListViewItem lv = listViewWatch.SelectedItems[0];


            DataItem data = new DataItem
            {
                Type = (DataCacheType)(lv.Tag),
                Key = lv.SubItems[1].Text,
                Value = lv.SubItems[2].Text
            };

          //  ChangeData(data);

            ThreadPool.QueueUserWorkItem(SendChangeData, data);


            //FormSetData fs = new FormSetData(lv.Tag.ToString(), lv.SubItems[1].Text, lv.SubItems[2].Text);
            //DialogResult dr = fs.ShowDialog();
            //if (dr == DialogResult.OK)
            //{
            //    DataCacheType type = (DataCacheType)(lv.Tag);
            //    string key = lv.SubItems[1].Text;
            //    string value = fs.NewValue;
            //    m_inspectorService.ChangeDataCache(m_accessToken, type, key, value);
            //}
        }
    }

    public class DataItem
    {
        public DataCacheType Type { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
