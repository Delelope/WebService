﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCF_QuanLyKhachSanForm.ServiceReferencePhieuDatPhong {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PhieuDatPhongDTO", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceQuanLyKhachSan")]
    [System.SerializableAttribute()]
    public partial class PhieuDatPhongDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MakhachhangField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MaphieudatField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime NgaydenField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime NgaydiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SonguoiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal SotiendatcocField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TinhtrangField;
        
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
        public string Makhachhang {
            get {
                return this.MakhachhangField;
            }
            set {
                if ((object.ReferenceEquals(this.MakhachhangField, value) != true)) {
                    this.MakhachhangField = value;
                    this.RaisePropertyChanged("Makhachhang");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Maphieudat {
            get {
                return this.MaphieudatField;
            }
            set {
                if ((object.ReferenceEquals(this.MaphieudatField, value) != true)) {
                    this.MaphieudatField = value;
                    this.RaisePropertyChanged("Maphieudat");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Ngayden {
            get {
                return this.NgaydenField;
            }
            set {
                if ((this.NgaydenField.Equals(value) != true)) {
                    this.NgaydenField = value;
                    this.RaisePropertyChanged("Ngayden");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Ngaydi {
            get {
                return this.NgaydiField;
            }
            set {
                if ((this.NgaydiField.Equals(value) != true)) {
                    this.NgaydiField = value;
                    this.RaisePropertyChanged("Ngaydi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Songuoi {
            get {
                return this.SonguoiField;
            }
            set {
                if ((this.SonguoiField.Equals(value) != true)) {
                    this.SonguoiField = value;
                    this.RaisePropertyChanged("Songuoi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Sotiendatcoc {
            get {
                return this.SotiendatcocField;
            }
            set {
                if ((this.SotiendatcocField.Equals(value) != true)) {
                    this.SotiendatcocField = value;
                    this.RaisePropertyChanged("Sotiendatcoc");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Tinhtrang {
            get {
                return this.TinhtrangField;
            }
            set {
                if ((object.ReferenceEquals(this.TinhtrangField, value) != true)) {
                    this.TinhtrangField = value;
                    this.RaisePropertyChanged("Tinhtrang");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferencePhieuDatPhong.IServicePhieuDatPhong")]
    public interface IServicePhieuDatPhong {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePhieuDatPhong/CountListPDP", ReplyAction="http://tempuri.org/IServicePhieuDatPhong/CountListPDPResponse")]
        int CountListPDP();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePhieuDatPhong/CountListPDP", ReplyAction="http://tempuri.org/IServicePhieuDatPhong/CountListPDPResponse")]
        System.Threading.Tasks.Task<int> CountListPDPAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePhieuDatPhong/getListPhieuDatPhongAll", ReplyAction="http://tempuri.org/IServicePhieuDatPhong/getListPhieuDatPhongAllResponse")]
        WCF_QuanLyKhachSanForm.ServiceReferencePhieuDatPhong.PhieuDatPhongDTO[] getListPhieuDatPhongAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePhieuDatPhong/getListPhieuDatPhongAll", ReplyAction="http://tempuri.org/IServicePhieuDatPhong/getListPhieuDatPhongAllResponse")]
        System.Threading.Tasks.Task<WCF_QuanLyKhachSanForm.ServiceReferencePhieuDatPhong.PhieuDatPhongDTO[]> getListPhieuDatPhongAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePhieuDatPhong/getListPhieuDatPhongLMAll", ReplyAction="http://tempuri.org/IServicePhieuDatPhong/getListPhieuDatPhongLMAllResponse")]
        WCF_QuanLyKhachSanForm.ServiceReferencePhieuDatPhong.PhieuDatPhongDTO[] getListPhieuDatPhongLMAll(int a);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePhieuDatPhong/getListPhieuDatPhongLMAll", ReplyAction="http://tempuri.org/IServicePhieuDatPhong/getListPhieuDatPhongLMAllResponse")]
        System.Threading.Tasks.Task<WCF_QuanLyKhachSanForm.ServiceReferencePhieuDatPhong.PhieuDatPhongDTO[]> getListPhieuDatPhongLMAllAsync(int a);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePhieuDatPhong/getPhieuDatPhongByID", ReplyAction="http://tempuri.org/IServicePhieuDatPhong/getPhieuDatPhongByIDResponse")]
        WCF_QuanLyKhachSanForm.ServiceReferencePhieuDatPhong.PhieuDatPhongDTO getPhieuDatPhongByID(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePhieuDatPhong/getPhieuDatPhongByID", ReplyAction="http://tempuri.org/IServicePhieuDatPhong/getPhieuDatPhongByIDResponse")]
        System.Threading.Tasks.Task<WCF_QuanLyKhachSanForm.ServiceReferencePhieuDatPhong.PhieuDatPhongDTO> getPhieuDatPhongByIDAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePhieuDatPhong/getListPhieuDatPhongByMKH", ReplyAction="http://tempuri.org/IServicePhieuDatPhong/getListPhieuDatPhongByMKHResponse")]
        WCF_QuanLyKhachSanForm.ServiceReferencePhieuDatPhong.PhieuDatPhongDTO[] getListPhieuDatPhongByMKH(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePhieuDatPhong/getListPhieuDatPhongByMKH", ReplyAction="http://tempuri.org/IServicePhieuDatPhong/getListPhieuDatPhongByMKHResponse")]
        System.Threading.Tasks.Task<WCF_QuanLyKhachSanForm.ServiceReferencePhieuDatPhong.PhieuDatPhongDTO[]> getListPhieuDatPhongByMKHAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePhieuDatPhong/getLikePhieuDatPhongByID", ReplyAction="http://tempuri.org/IServicePhieuDatPhong/getLikePhieuDatPhongByIDResponse")]
        WCF_QuanLyKhachSanForm.ServiceReferencePhieuDatPhong.PhieuDatPhongDTO[] getLikePhieuDatPhongByID(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePhieuDatPhong/getLikePhieuDatPhongByID", ReplyAction="http://tempuri.org/IServicePhieuDatPhong/getLikePhieuDatPhongByIDResponse")]
        System.Threading.Tasks.Task<WCF_QuanLyKhachSanForm.ServiceReferencePhieuDatPhong.PhieuDatPhongDTO[]> getLikePhieuDatPhongByIDAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePhieuDatPhong/getListLikePhieuDatPhongByMKH", ReplyAction="http://tempuri.org/IServicePhieuDatPhong/getListLikePhieuDatPhongByMKHResponse")]
        WCF_QuanLyKhachSanForm.ServiceReferencePhieuDatPhong.PhieuDatPhongDTO[] getListLikePhieuDatPhongByMKH(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePhieuDatPhong/getListLikePhieuDatPhongByMKH", ReplyAction="http://tempuri.org/IServicePhieuDatPhong/getListLikePhieuDatPhongByMKHResponse")]
        System.Threading.Tasks.Task<WCF_QuanLyKhachSanForm.ServiceReferencePhieuDatPhong.PhieuDatPhongDTO[]> getListLikePhieuDatPhongByMKHAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePhieuDatPhong/insertPhieuDatPhong", ReplyAction="http://tempuri.org/IServicePhieuDatPhong/insertPhieuDatPhongResponse")]
        int insertPhieuDatPhong(WCF_QuanLyKhachSanForm.ServiceReferencePhieuDatPhong.PhieuDatPhongDTO pdpDTO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePhieuDatPhong/insertPhieuDatPhong", ReplyAction="http://tempuri.org/IServicePhieuDatPhong/insertPhieuDatPhongResponse")]
        System.Threading.Tasks.Task<int> insertPhieuDatPhongAsync(WCF_QuanLyKhachSanForm.ServiceReferencePhieuDatPhong.PhieuDatPhongDTO pdpDTO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePhieuDatPhong/deletePhieuDatPhong", ReplyAction="http://tempuri.org/IServicePhieuDatPhong/deletePhieuDatPhongResponse")]
        int deletePhieuDatPhong(string IDPhieuDatPhong);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePhieuDatPhong/deletePhieuDatPhong", ReplyAction="http://tempuri.org/IServicePhieuDatPhong/deletePhieuDatPhongResponse")]
        System.Threading.Tasks.Task<int> deletePhieuDatPhongAsync(string IDPhieuDatPhong);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePhieuDatPhong/updatePhieuDatPhong", ReplyAction="http://tempuri.org/IServicePhieuDatPhong/updatePhieuDatPhongResponse")]
        int updatePhieuDatPhong(WCF_QuanLyKhachSanForm.ServiceReferencePhieuDatPhong.PhieuDatPhongDTO pdpDTO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePhieuDatPhong/updatePhieuDatPhong", ReplyAction="http://tempuri.org/IServicePhieuDatPhong/updatePhieuDatPhongResponse")]
        System.Threading.Tasks.Task<int> updatePhieuDatPhongAsync(WCF_QuanLyKhachSanForm.ServiceReferencePhieuDatPhong.PhieuDatPhongDTO pdpDTO);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicePhieuDatPhongChannel : WCF_QuanLyKhachSanForm.ServiceReferencePhieuDatPhong.IServicePhieuDatPhong, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicePhieuDatPhongClient : System.ServiceModel.ClientBase<WCF_QuanLyKhachSanForm.ServiceReferencePhieuDatPhong.IServicePhieuDatPhong>, WCF_QuanLyKhachSanForm.ServiceReferencePhieuDatPhong.IServicePhieuDatPhong {
        
        public ServicePhieuDatPhongClient() {
        }
        
        public ServicePhieuDatPhongClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicePhieuDatPhongClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicePhieuDatPhongClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicePhieuDatPhongClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int CountListPDP() {
            return base.Channel.CountListPDP();
        }
        
        public System.Threading.Tasks.Task<int> CountListPDPAsync() {
            return base.Channel.CountListPDPAsync();
        }
        
        public WCF_QuanLyKhachSanForm.ServiceReferencePhieuDatPhong.PhieuDatPhongDTO[] getListPhieuDatPhongAll() {
            return base.Channel.getListPhieuDatPhongAll();
        }
        
        public System.Threading.Tasks.Task<WCF_QuanLyKhachSanForm.ServiceReferencePhieuDatPhong.PhieuDatPhongDTO[]> getListPhieuDatPhongAllAsync() {
            return base.Channel.getListPhieuDatPhongAllAsync();
        }
        
        public WCF_QuanLyKhachSanForm.ServiceReferencePhieuDatPhong.PhieuDatPhongDTO[] getListPhieuDatPhongLMAll(int a) {
            return base.Channel.getListPhieuDatPhongLMAll(a);
        }
        
        public System.Threading.Tasks.Task<WCF_QuanLyKhachSanForm.ServiceReferencePhieuDatPhong.PhieuDatPhongDTO[]> getListPhieuDatPhongLMAllAsync(int a) {
            return base.Channel.getListPhieuDatPhongLMAllAsync(a);
        }
        
        public WCF_QuanLyKhachSanForm.ServiceReferencePhieuDatPhong.PhieuDatPhongDTO getPhieuDatPhongByID(string id) {
            return base.Channel.getPhieuDatPhongByID(id);
        }
        
        public System.Threading.Tasks.Task<WCF_QuanLyKhachSanForm.ServiceReferencePhieuDatPhong.PhieuDatPhongDTO> getPhieuDatPhongByIDAsync(string id) {
            return base.Channel.getPhieuDatPhongByIDAsync(id);
        }
        
        public WCF_QuanLyKhachSanForm.ServiceReferencePhieuDatPhong.PhieuDatPhongDTO[] getListPhieuDatPhongByMKH(string name) {
            return base.Channel.getListPhieuDatPhongByMKH(name);
        }
        
        public System.Threading.Tasks.Task<WCF_QuanLyKhachSanForm.ServiceReferencePhieuDatPhong.PhieuDatPhongDTO[]> getListPhieuDatPhongByMKHAsync(string name) {
            return base.Channel.getListPhieuDatPhongByMKHAsync(name);
        }
        
        public WCF_QuanLyKhachSanForm.ServiceReferencePhieuDatPhong.PhieuDatPhongDTO[] getLikePhieuDatPhongByID(string id) {
            return base.Channel.getLikePhieuDatPhongByID(id);
        }
        
        public System.Threading.Tasks.Task<WCF_QuanLyKhachSanForm.ServiceReferencePhieuDatPhong.PhieuDatPhongDTO[]> getLikePhieuDatPhongByIDAsync(string id) {
            return base.Channel.getLikePhieuDatPhongByIDAsync(id);
        }
        
        public WCF_QuanLyKhachSanForm.ServiceReferencePhieuDatPhong.PhieuDatPhongDTO[] getListLikePhieuDatPhongByMKH(string name) {
            return base.Channel.getListLikePhieuDatPhongByMKH(name);
        }
        
        public System.Threading.Tasks.Task<WCF_QuanLyKhachSanForm.ServiceReferencePhieuDatPhong.PhieuDatPhongDTO[]> getListLikePhieuDatPhongByMKHAsync(string name) {
            return base.Channel.getListLikePhieuDatPhongByMKHAsync(name);
        }
        
        public int insertPhieuDatPhong(WCF_QuanLyKhachSanForm.ServiceReferencePhieuDatPhong.PhieuDatPhongDTO pdpDTO) {
            return base.Channel.insertPhieuDatPhong(pdpDTO);
        }
        
        public System.Threading.Tasks.Task<int> insertPhieuDatPhongAsync(WCF_QuanLyKhachSanForm.ServiceReferencePhieuDatPhong.PhieuDatPhongDTO pdpDTO) {
            return base.Channel.insertPhieuDatPhongAsync(pdpDTO);
        }
        
        public int deletePhieuDatPhong(string IDPhieuDatPhong) {
            return base.Channel.deletePhieuDatPhong(IDPhieuDatPhong);
        }
        
        public System.Threading.Tasks.Task<int> deletePhieuDatPhongAsync(string IDPhieuDatPhong) {
            return base.Channel.deletePhieuDatPhongAsync(IDPhieuDatPhong);
        }
        
        public int updatePhieuDatPhong(WCF_QuanLyKhachSanForm.ServiceReferencePhieuDatPhong.PhieuDatPhongDTO pdpDTO) {
            return base.Channel.updatePhieuDatPhong(pdpDTO);
        }
        
        public System.Threading.Tasks.Task<int> updatePhieuDatPhongAsync(WCF_QuanLyKhachSanForm.ServiceReferencePhieuDatPhong.PhieuDatPhongDTO pdpDTO) {
            return base.Channel.updatePhieuDatPhongAsync(pdpDTO);
        }
    }
}
