using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using eCatDebug.eCATObservor.eCATInspector;

namespace eCatDebug
{
    public class eCATObservorCallback : eCatDebug.eCATObservor.eCATInspector.IeCATInspectorServiceCallback
    {
#region constructor
        public eCATObservorCallback( FormObserver argMain )
        {
            Debug.Assert(null != argMain);
            m_main = argMain;
        }
#endregion

#region methods
        public void OnDataChanged( string argKey, 
                                   string argValue, 
                                   DataCacheType argType,
                                   string argDateTimestamp )
        {
            m_main.OnDataChanged(argKey, argValue, argType, argDateTimestamp);
        }

        public void OnDataCacheClear( DataCacheType argType,
                                      string argDateTimestamp )
        {
            m_main.OnDataCacheClear(argType, argDateTimestamp);
        }

        public void OnDataDeleted( string argKey,
                                   DataCacheType argType,
                                   string argDateTimestamp)
        {
            m_main.OnDataDeleted(argKey, argType, argDateTimestamp);
        }

        public void OnPackMessage(string timeStamp, Dictionary<string, string> dict)
        {
            m_main.OnPackMessage(timeStamp, dict);
        }

        public void OnUnPackMessage(string timeStamp, Dictionary<string, string> dict)
        {
            m_main.OnUnPackMessage(timeStamp, dict);
        }
#endregion

#region field
        private FormObserver m_main = null;
#endregion
    }
}
