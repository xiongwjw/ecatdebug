﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eCatDebug.eCATObservor.eCATInspector {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DataSnapShot", Namespace="http://www.grgbanking.com/product/eCAT3")]
    [System.SerializableAttribute()]
    public partial class DataSnapShot : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private eCatDebug.eCATObservor.eCATInspector.DataSnapShotItem[] ItemsField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public eCatDebug.eCATObservor.eCATInspector.DataSnapShotItem[] Items {
            get {
                return this.ItemsField;
            }
            set {
                if ((object.ReferenceEquals(this.ItemsField, value) != true)) {
                    this.ItemsField = value;
                    this.RaisePropertyChanged("Items");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DataSnapShotItem", Namespace="http://www.grgbanking.com/product/eCAT3")]
    [System.SerializableAttribute()]
    public partial class DataSnapShotItem : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string KeyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private eCatDebug.eCATObservor.eCATInspector.DataCacheType TypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ValueField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string Key {
            get {
                return this.KeyField;
            }
            set {
                if ((object.ReferenceEquals(this.KeyField, value) != true)) {
                    this.KeyField = value;
                    this.RaisePropertyChanged("Key");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public eCatDebug.eCATObservor.eCATInspector.DataCacheType Type {
            get {
                return this.TypeField;
            }
            set {
                if ((this.TypeField.Equals(value) != true)) {
                    this.TypeField = value;
                    this.RaisePropertyChanged("Type");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Value {
            get {
                return this.ValueField;
            }
            set {
                if ((object.ReferenceEquals(this.ValueField, value) != true)) {
                    this.ValueField = value;
                    this.RaisePropertyChanged("Value");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DataCacheType", Namespace="http://schemas.datacontract.org/2004/07/eCATInspectorSerivceProtocol")]
    public enum DataCacheType : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        None = -1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Transaction = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        CardHolder = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Terminal = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Workflow = 3,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.grgbanking.com/product/eCAT3R2", ConfigurationName="eCATObservor.eCATInspector.IeCATInspectorService", CallbackContract=typeof(eCatDebug.eCATObservor.eCATInspector.IeCATInspectorServiceCallback))]
    public interface IeCATInspectorService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.grgbanking.com/product/eCAT3R2/IeCATInspectorService/LoginIn", ReplyAction="http://www.grgbanking.com/product/eCAT3R2/IeCATInspectorService/LoginInResponse")]
        bool LoginIn(out int argAccessToken, string argAccount, string argPassword);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.grgbanking.com/product/eCAT3R2/IeCATInspectorService/LoginOff", ReplyAction="http://www.grgbanking.com/product/eCAT3R2/IeCATInspectorService/LoginOffResponse")]
        bool LoginOff(int argAccessToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.grgbanking.com/product/eCAT3R2/IeCATInspectorService/QuerySnapshotOfDa" +
            "ta", ReplyAction="http://www.grgbanking.com/product/eCAT3R2/IeCATInspectorService/QuerySnapshotOfDa" +
            "taResponse")]
        eCatDebug.eCATObservor.eCATInspector.DataSnapShot QuerySnapshotOfData(int argAccessToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.grgbanking.com/product/eCAT3R2/IeCATInspectorService/ListenDataChanged" +
            "", ReplyAction="http://www.grgbanking.com/product/eCAT3R2/IeCATInspectorService/ListenDataChanged" +
            "Response")]
        bool ListenDataChanged(int argAccessToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.grgbanking.com/product/eCAT3R2/IeCATInspectorService/UnlistenDataChang" +
            "ed", ReplyAction="http://www.grgbanking.com/product/eCAT3R2/IeCATInspectorService/UnlistenDataChang" +
            "edResponse")]
        bool UnlistenDataChanged(int argAccessToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.grgbanking.com/product/eCAT3R2/IeCATInspectorService/Hearbeat", ReplyAction="http://www.grgbanking.com/product/eCAT3R2/IeCATInspectorService/HearbeatResponse")]
        void Hearbeat(int argAccessToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.grgbanking.com/product/eCAT3R2/IeCATInspectorService/EndCurrentWorkflo" +
            "w", ReplyAction="http://www.grgbanking.com/product/eCAT3R2/IeCATInspectorService/EndCurrentWorkflo" +
            "wResponse")]
        void EndCurrentWorkflow(int argAccessToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.grgbanking.com/product/eCAT3R2/IeCATInspectorService/ChangeWorkflow", ReplyAction="http://www.grgbanking.com/product/eCAT3R2/IeCATInspectorService/ChangeWorkflowRes" +
            "ponse")]
        void ChangeWorkflow(int argAccessToken, string workflowName, string actionName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.grgbanking.com/product/eCAT3R2/IeCATInspectorService/ReDrawUI", ReplyAction="http://www.grgbanking.com/product/eCAT3R2/IeCATInspectorService/ReDrawUIResponse")]
        void ReDrawUI(int argAccessToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.grgbanking.com/product/eCAT3R2/IeCATInspectorService/DebugReboot", ReplyAction="http://www.grgbanking.com/product/eCAT3R2/IeCATInspectorService/DebugRebootRespon" +
            "se")]
        void DebugReboot(int argAccessToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.grgbanking.com/product/eCAT3R2/IeCATInspectorService/ReLoadUI", ReplyAction="http://www.grgbanking.com/product/eCAT3R2/IeCATInspectorService/ReLoadUIResponse")]
        void ReLoadUI(int argAccessToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.grgbanking.com/product/eCAT3R2/IeCATInspectorService/Reboot", ReplyAction="http://www.grgbanking.com/product/eCAT3R2/IeCATInspectorService/RebootResponse")]
        void Reboot(int argAccessToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.grgbanking.com/product/eCAT3R2/IeCATInspectorService/ShutDown", ReplyAction="http://www.grgbanking.com/product/eCAT3R2/IeCATInspectorService/ShutDownResponse")]
        void ShutDown(int argAccessToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.grgbanking.com/product/eCAT3R2/IeCATInspectorService/ChangeDataCache", ReplyAction="http://www.grgbanking.com/product/eCAT3R2/IeCATInspectorService/ChangeDataCacheRe" +
            "sponse")]
        void ChangeDataCache(int argAccessToken, eCatDebug.eCATObservor.eCATInspector.DataCacheType dataType, string argKey, string argValue);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IeCATInspectorServiceCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://www.grgbanking.com/product/eCAT3R2/IeCATInspectorService/OnDataChanged")]
        void OnDataChanged(string argKey, string argValue, eCatDebug.eCATObservor.eCATInspector.DataCacheType argType, string argDateTime);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://www.grgbanking.com/product/eCAT3R2/IeCATInspectorService/OnDataDeleted")]
        void OnDataDeleted(string argKey, eCatDebug.eCATObservor.eCATInspector.DataCacheType argType, string argDateTime);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://www.grgbanking.com/product/eCAT3R2/IeCATInspectorService/OnDataCacheClear")]
        void OnDataCacheClear(eCatDebug.eCATObservor.eCATInspector.DataCacheType argType, string argDateTime);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://www.grgbanking.com/product/eCAT3R2/IeCATInspectorService/OnPackMessage")]
        void OnPackMessage(string timeStamp, System.Collections.Generic.Dictionary<string, string> dict);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://www.grgbanking.com/product/eCAT3R2/IeCATInspectorService/OnUnPackMessage")]
        void OnUnPackMessage(string timeStamp, System.Collections.Generic.Dictionary<string, string> dict);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IeCATInspectorServiceChannel : eCatDebug.eCATObservor.eCATInspector.IeCATInspectorService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class IeCATInspectorServiceClient : System.ServiceModel.DuplexClientBase<eCatDebug.eCATObservor.eCATInspector.IeCATInspectorService>, eCatDebug.eCATObservor.eCATInspector.IeCATInspectorService {
        
        public IeCATInspectorServiceClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public IeCATInspectorServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public IeCATInspectorServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public IeCATInspectorServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public IeCATInspectorServiceClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public bool LoginIn(out int argAccessToken, string argAccount, string argPassword) {
            return base.Channel.LoginIn(out argAccessToken, argAccount, argPassword);
        }
        
        public bool LoginOff(int argAccessToken) {
            return base.Channel.LoginOff(argAccessToken);
        }
        
        public eCatDebug.eCATObservor.eCATInspector.DataSnapShot QuerySnapshotOfData(int argAccessToken) {
            return base.Channel.QuerySnapshotOfData(argAccessToken);
        }
        
        public bool ListenDataChanged(int argAccessToken) {
            return base.Channel.ListenDataChanged(argAccessToken);
        }
        
        public bool UnlistenDataChanged(int argAccessToken) {
            return base.Channel.UnlistenDataChanged(argAccessToken);
        }
        
        public void Hearbeat(int argAccessToken) {
            base.Channel.Hearbeat(argAccessToken);
        }
        
        public void EndCurrentWorkflow(int argAccessToken) {
            base.Channel.EndCurrentWorkflow(argAccessToken);
        }
        
        public void ChangeWorkflow(int argAccessToken, string workflowName, string actionName) {
            base.Channel.ChangeWorkflow(argAccessToken, workflowName, actionName);
        }
        
        public void ReDrawUI(int argAccessToken) {
            base.Channel.ReDrawUI(argAccessToken);
        }
        
        public void DebugReboot(int argAccessToken) {
            base.Channel.DebugReboot(argAccessToken);
        }
        
        public void ReLoadUI(int argAccessToken) {
            base.Channel.ReLoadUI(argAccessToken);
        }
        
        public void Reboot(int argAccessToken) {
            base.Channel.Reboot(argAccessToken);
        }
        
        public void ShutDown(int argAccessToken) {
            base.Channel.ShutDown(argAccessToken);
        }
        
        public void ChangeDataCache(int argAccessToken, eCatDebug.eCATObservor.eCATInspector.DataCacheType dataType, string argKey, string argValue) {
            base.Channel.ChangeDataCache(argAccessToken, dataType, argKey, argValue);
        }
    }
}
