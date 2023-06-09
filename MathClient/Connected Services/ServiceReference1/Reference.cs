﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MathClient.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/MathServiceLibrary")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://MyCompany.com", ConfigurationName="ServiceReference1.IBasicMath")]
    public interface IBasicMath {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://MyCompany.com/IBasicMath/Add", ReplyAction="http://MyCompany.com/IBasicMath/AddResponse")]
        int Add(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://MyCompany.com/IBasicMath/Add", ReplyAction="http://MyCompany.com/IBasicMath/AddResponse")]
        System.IAsyncResult BeginAdd(int x, int y, System.AsyncCallback callback, object asyncState);
        
        int EndAdd(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://MyCompany.com/IBasicMath/GetDataUsingDataContract", ReplyAction="http://MyCompany.com/IBasicMath/GetDataUsingDataContractResponse")]
        MathClient.ServiceReference1.CompositeType GetDataUsingDataContract(MathClient.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://MyCompany.com/IBasicMath/GetDataUsingDataContract", ReplyAction="http://MyCompany.com/IBasicMath/GetDataUsingDataContractResponse")]
        System.IAsyncResult BeginGetDataUsingDataContract(MathClient.ServiceReference1.CompositeType composite, System.AsyncCallback callback, object asyncState);
        
        MathClient.ServiceReference1.CompositeType EndGetDataUsingDataContract(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBasicMathChannel : MathClient.ServiceReference1.IBasicMath, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AddCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public AddCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public int Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetDataUsingDataContractCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetDataUsingDataContractCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public MathClient.ServiceReference1.CompositeType Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((MathClient.ServiceReference1.CompositeType)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BasicMathClient : System.ServiceModel.ClientBase<MathClient.ServiceReference1.IBasicMath>, MathClient.ServiceReference1.IBasicMath {
        
        private BeginOperationDelegate onBeginAddDelegate;
        
        private EndOperationDelegate onEndAddDelegate;
        
        private System.Threading.SendOrPostCallback onAddCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetDataUsingDataContractDelegate;
        
        private EndOperationDelegate onEndGetDataUsingDataContractDelegate;
        
        private System.Threading.SendOrPostCallback onGetDataUsingDataContractCompletedDelegate;
        
        public BasicMathClient() {
        }
        
        public BasicMathClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BasicMathClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BasicMathClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BasicMathClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public event System.EventHandler<AddCompletedEventArgs> AddCompleted;
        
        public event System.EventHandler<GetDataUsingDataContractCompletedEventArgs> GetDataUsingDataContractCompleted;
        
        public int Add(int x, int y) {
            return base.Channel.Add(x, y);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginAdd(int x, int y, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginAdd(x, y, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public int EndAdd(System.IAsyncResult result) {
            return base.Channel.EndAdd(result);
        }
        
        private System.IAsyncResult OnBeginAdd(object[] inValues, System.AsyncCallback callback, object asyncState) {
            int x = ((int)(inValues[0]));
            int y = ((int)(inValues[1]));
            return this.BeginAdd(x, y, callback, asyncState);
        }
        
        private object[] OnEndAdd(System.IAsyncResult result) {
            int retVal = this.EndAdd(result);
            return new object[] {
                    retVal};
        }
        
        private void OnAddCompleted(object state) {
            if ((this.AddCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.AddCompleted(this, new AddCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void AddAsync(int x, int y) {
            this.AddAsync(x, y, null);
        }
        
        public void AddAsync(int x, int y, object userState) {
            if ((this.onBeginAddDelegate == null)) {
                this.onBeginAddDelegate = new BeginOperationDelegate(this.OnBeginAdd);
            }
            if ((this.onEndAddDelegate == null)) {
                this.onEndAddDelegate = new EndOperationDelegate(this.OnEndAdd);
            }
            if ((this.onAddCompletedDelegate == null)) {
                this.onAddCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnAddCompleted);
            }
            base.InvokeAsync(this.onBeginAddDelegate, new object[] {
                        x,
                        y}, this.onEndAddDelegate, this.onAddCompletedDelegate, userState);
        }
        
        public MathClient.ServiceReference1.CompositeType GetDataUsingDataContract(MathClient.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGetDataUsingDataContract(MathClient.ServiceReference1.CompositeType composite, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetDataUsingDataContract(composite, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public MathClient.ServiceReference1.CompositeType EndGetDataUsingDataContract(System.IAsyncResult result) {
            return base.Channel.EndGetDataUsingDataContract(result);
        }
        
        private System.IAsyncResult OnBeginGetDataUsingDataContract(object[] inValues, System.AsyncCallback callback, object asyncState) {
            MathClient.ServiceReference1.CompositeType composite = ((MathClient.ServiceReference1.CompositeType)(inValues[0]));
            return this.BeginGetDataUsingDataContract(composite, callback, asyncState);
        }
        
        private object[] OnEndGetDataUsingDataContract(System.IAsyncResult result) {
            MathClient.ServiceReference1.CompositeType retVal = this.EndGetDataUsingDataContract(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetDataUsingDataContractCompleted(object state) {
            if ((this.GetDataUsingDataContractCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetDataUsingDataContractCompleted(this, new GetDataUsingDataContractCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetDataUsingDataContractAsync(MathClient.ServiceReference1.CompositeType composite) {
            this.GetDataUsingDataContractAsync(composite, null);
        }
        
        public void GetDataUsingDataContractAsync(MathClient.ServiceReference1.CompositeType composite, object userState) {
            if ((this.onBeginGetDataUsingDataContractDelegate == null)) {
                this.onBeginGetDataUsingDataContractDelegate = new BeginOperationDelegate(this.OnBeginGetDataUsingDataContract);
            }
            if ((this.onEndGetDataUsingDataContractDelegate == null)) {
                this.onEndGetDataUsingDataContractDelegate = new EndOperationDelegate(this.OnEndGetDataUsingDataContract);
            }
            if ((this.onGetDataUsingDataContractCompletedDelegate == null)) {
                this.onGetDataUsingDataContractCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetDataUsingDataContractCompleted);
            }
            base.InvokeAsync(this.onBeginGetDataUsingDataContractDelegate, new object[] {
                        composite}, this.onEndGetDataUsingDataContractDelegate, this.onGetDataUsingDataContractCompletedDelegate, userState);
        }
    }
}
