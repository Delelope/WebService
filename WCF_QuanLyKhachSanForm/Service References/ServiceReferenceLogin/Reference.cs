﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCF_QuanLyKhachSanForm.ServiceReferenceLogin {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="LoginDTO", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceQuanLyKhachSan")]
    [System.SerializableAttribute()]
    public partial class LoginDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ChucVuField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MaNVField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TenNVField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsernameField;
        
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
        public string ChucVu {
            get {
                return this.ChucVuField;
            }
            set {
                if ((object.ReferenceEquals(this.ChucVuField, value) != true)) {
                    this.ChucVuField = value;
                    this.RaisePropertyChanged("ChucVu");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MaNV {
            get {
                return this.MaNVField;
            }
            set {
                if ((object.ReferenceEquals(this.MaNVField, value) != true)) {
                    this.MaNVField = value;
                    this.RaisePropertyChanged("MaNV");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TenNV {
            get {
                return this.TenNVField;
            }
            set {
                if ((object.ReferenceEquals(this.TenNVField, value) != true)) {
                    this.TenNVField = value;
                    this.RaisePropertyChanged("TenNV");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Username {
            get {
                return this.UsernameField;
            }
            set {
                if ((object.ReferenceEquals(this.UsernameField, value) != true)) {
                    this.UsernameField = value;
                    this.RaisePropertyChanged("Username");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceLogin.IServiceLogin")]
    public interface IServiceLogin {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceLogin/Login", ReplyAction="http://tempuri.org/IServiceLogin/LoginResponse")]
        WCF_QuanLyKhachSanForm.ServiceReferenceLogin.LoginDTO[] Login(string user, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceLogin/Login", ReplyAction="http://tempuri.org/IServiceLogin/LoginResponse")]
        System.Threading.Tasks.Task<WCF_QuanLyKhachSanForm.ServiceReferenceLogin.LoginDTO[]> LoginAsync(string user, string pass);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceLoginChannel : WCF_QuanLyKhachSanForm.ServiceReferenceLogin.IServiceLogin, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceLoginClient : System.ServiceModel.ClientBase<WCF_QuanLyKhachSanForm.ServiceReferenceLogin.IServiceLogin>, WCF_QuanLyKhachSanForm.ServiceReferenceLogin.IServiceLogin {
        
        public ServiceLoginClient() {
        }
        
        public ServiceLoginClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceLoginClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceLoginClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceLoginClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WCF_QuanLyKhachSanForm.ServiceReferenceLogin.LoginDTO[] Login(string user, string pass) {
            return base.Channel.Login(user, pass);
        }
        
        public System.Threading.Tasks.Task<WCF_QuanLyKhachSanForm.ServiceReferenceLogin.LoginDTO[]> LoginAsync(string user, string pass) {
            return base.Channel.LoginAsync(user, pass);
        }
    }
}
