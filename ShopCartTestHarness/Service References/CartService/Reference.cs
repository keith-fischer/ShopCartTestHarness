﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShopCartTestHarness.CartService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Cart", Namespace="http://schemas.datacontract.org/2004/07/GreatCall.ShoppingCart.Contracts")]
    [System.SerializableAttribute()]
    public partial class Cart : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool AllowPhoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool AllowResponderField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CartIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ShopCartTestHarness.CartService.CartGroup[] GroupsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int VersionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ZipCodeField;
        
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
        public bool AllowPhone {
            get {
                return this.AllowPhoneField;
            }
            set {
                if ((this.AllowPhoneField.Equals(value) != true)) {
                    this.AllowPhoneField = value;
                    this.RaisePropertyChanged("AllowPhone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool AllowResponder {
            get {
                return this.AllowResponderField;
            }
            set {
                if ((this.AllowResponderField.Equals(value) != true)) {
                    this.AllowResponderField = value;
                    this.RaisePropertyChanged("AllowResponder");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CartId {
            get {
                return this.CartIdField;
            }
            set {
                if ((object.ReferenceEquals(this.CartIdField, value) != true)) {
                    this.CartIdField = value;
                    this.RaisePropertyChanged("CartId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ShopCartTestHarness.CartService.CartGroup[] Groups {
            get {
                return this.GroupsField;
            }
            set {
                if ((object.ReferenceEquals(this.GroupsField, value) != true)) {
                    this.GroupsField = value;
                    this.RaisePropertyChanged("Groups");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Version {
            get {
                return this.VersionField;
            }
            set {
                if ((this.VersionField.Equals(value) != true)) {
                    this.VersionField = value;
                    this.RaisePropertyChanged("Version");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ZipCode {
            get {
                return this.ZipCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.ZipCodeField, value) != true)) {
                    this.ZipCodeField = value;
                    this.RaisePropertyChanged("ZipCode");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="CartGroup", Namespace="http://schemas.datacontract.org/2004/07/GreatCall.ShoppingCart.Contracts")]
    [System.SerializableAttribute()]
    public partial class CartGroup : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GroupIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ShopCartTestHarness.CartService.CartItem[] ItemsField;
        
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
        public string GroupId {
            get {
                return this.GroupIdField;
            }
            set {
                if ((object.ReferenceEquals(this.GroupIdField, value) != true)) {
                    this.GroupIdField = value;
                    this.RaisePropertyChanged("GroupId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ShopCartTestHarness.CartService.CartItem[] Items {
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
    [System.Runtime.Serialization.DataContractAttribute(Name="CartItem", Namespace="http://schemas.datacontract.org/2004/07/GreatCall.ShoppingCart.Contracts")]
    [System.SerializableAttribute()]
    public partial class CartItem : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ShopCartTestHarness.CartService.Product ProductField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int QuantityField;
        
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
        public ShopCartTestHarness.CartService.Product Product {
            get {
                return this.ProductField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductField, value) != true)) {
                    this.ProductField = value;
                    this.RaisePropertyChanged("Product");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Quantity {
            get {
                return this.QuantityField;
            }
            set {
                if ((this.QuantityField.Equals(value) != true)) {
                    this.QuantityField = value;
                    this.RaisePropertyChanged("Quantity");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Product", Namespace="http://schemas.datacontract.org/2004/07/GreatCall.ShoppingCart.Contracts")]
    [System.SerializableAttribute()]
    public partial class Product : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ShopCartTestHarness.CartService.ChargeType ChargeTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool DefaultProductField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsRemovableField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProductIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ShopCartTestHarness.CartService.ProductType ProductTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SkuField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool VisibleField;
        
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
        public ShopCartTestHarness.CartService.ChargeType ChargeType {
            get {
                return this.ChargeTypeField;
            }
            set {
                if ((this.ChargeTypeField.Equals(value) != true)) {
                    this.ChargeTypeField = value;
                    this.RaisePropertyChanged("ChargeType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool DefaultProduct {
            get {
                return this.DefaultProductField;
            }
            set {
                if ((this.DefaultProductField.Equals(value) != true)) {
                    this.DefaultProductField = value;
                    this.RaisePropertyChanged("DefaultProduct");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsRemovable {
            get {
                return this.IsRemovableField;
            }
            set {
                if ((this.IsRemovableField.Equals(value) != true)) {
                    this.IsRemovableField = value;
                    this.RaisePropertyChanged("IsRemovable");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductId {
            get {
                return this.ProductIdField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductIdField, value) != true)) {
                    this.ProductIdField = value;
                    this.RaisePropertyChanged("ProductId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ShopCartTestHarness.CartService.ProductType ProductType {
            get {
                return this.ProductTypeField;
            }
            set {
                if ((this.ProductTypeField.Equals(value) != true)) {
                    this.ProductTypeField = value;
                    this.RaisePropertyChanged("ProductType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Sku {
            get {
                return this.SkuField;
            }
            set {
                if ((object.ReferenceEquals(this.SkuField, value) != true)) {
                    this.SkuField = value;
                    this.RaisePropertyChanged("Sku");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Visible {
            get {
                return this.VisibleField;
            }
            set {
                if ((this.VisibleField.Equals(value) != true)) {
                    this.VisibleField = value;
                    this.RaisePropertyChanged("Visible");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ChargeType", Namespace="http://schemas.datacontract.org/2004/07/GreatCall.ShoppingCart.Contracts")]
    public enum ChargeType : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        UNKNOWN = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Today = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Monthly = 2,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ProductType", Namespace="http://schemas.datacontract.org/2004/07/GreatCall.ShoppingCart.Contracts")]
    public enum ProductType : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Device = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Plan = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Feature = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Vas = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Accessory = 5,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Fee = 6,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Shipping = 7,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Text = 8,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Data = 9,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CartNotFoundFault", Namespace="http://schemas.datacontract.org/2004/07/GreatCall.ShoppingCart.Contracts")]
    [System.SerializableAttribute()]
    public partial class CartNotFoundFault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CartIdField;
        
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
        public string CartId {
            get {
                return this.CartIdField;
            }
            set {
                if ((object.ReferenceEquals(this.CartIdField, value) != true)) {
                    this.CartIdField = value;
                    this.RaisePropertyChanged("CartId");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="CartUpdateRequest", Namespace="http://schemas.datacontract.org/2004/07/GreatCall.ShoppingCart.Contracts")]
    [System.SerializableAttribute()]
    public partial class CartUpdateRequest : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CartIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GroupIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int NewQuantityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProductIdField;
        
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
        public string CartId {
            get {
                return this.CartIdField;
            }
            set {
                if ((object.ReferenceEquals(this.CartIdField, value) != true)) {
                    this.CartIdField = value;
                    this.RaisePropertyChanged("CartId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string GroupId {
            get {
                return this.GroupIdField;
            }
            set {
                if ((object.ReferenceEquals(this.GroupIdField, value) != true)) {
                    this.GroupIdField = value;
                    this.RaisePropertyChanged("GroupId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int NewQuantity {
            get {
                return this.NewQuantityField;
            }
            set {
                if ((this.NewQuantityField.Equals(value) != true)) {
                    this.NewQuantityField = value;
                    this.RaisePropertyChanged("NewQuantity");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductId {
            get {
                return this.ProductIdField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductIdField, value) != true)) {
                    this.ProductIdField = value;
                    this.RaisePropertyChanged("ProductId");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ProductNotFoundFault", Namespace="http://schemas.datacontract.org/2004/07/GreatCall.ShoppingCart.Contracts")]
    [System.SerializableAttribute()]
    public partial class ProductNotFoundFault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProductIdField;
        
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
        public string ProductId {
            get {
                return this.ProductIdField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductIdField, value) != true)) {
                    this.ProductIdField = value;
                    this.RaisePropertyChanged("ProductId");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ProductNotFoundInCartFault", Namespace="http://schemas.datacontract.org/2004/07/GreatCall.ShoppingCart.Contracts")]
    [System.SerializableAttribute()]
    public partial class ProductNotFoundInCartFault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ShopCartTestHarness.CartService.CartGroup GroupField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProductIdField;
        
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
        public ShopCartTestHarness.CartService.CartGroup Group {
            get {
                return this.GroupField;
            }
            set {
                if ((object.ReferenceEquals(this.GroupField, value) != true)) {
                    this.GroupField = value;
                    this.RaisePropertyChanged("Group");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductId {
            get {
                return this.ProductIdField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductIdField, value) != true)) {
                    this.ProductIdField = value;
                    this.RaisePropertyChanged("ProductId");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CartService.ICartService")]
    public interface ICartService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICartService/CreateCart", ReplyAction="http://tempuri.org/ICartService/CreateCartResponse")]
        string CreateCart();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICartService/GetCart", ReplyAction="http://tempuri.org/ICartService/GetCartResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ShopCartTestHarness.CartService.CartNotFoundFault), Action="http://tempuri.org/ICartService/GetCartCartNotFoundFaultFault", Name="CartNotFoundFault", Namespace="http://schemas.datacontract.org/2004/07/GreatCall.ShoppingCart.Contracts")]
        ShopCartTestHarness.CartService.Cart GetCart(string cartId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICartService/UpdateCart", ReplyAction="http://tempuri.org/ICartService/UpdateCartResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ShopCartTestHarness.CartService.ProductNotFoundFault), Action="http://tempuri.org/ICartService/UpdateCartProductNotFoundFaultFault", Name="ProductNotFoundFault", Namespace="http://schemas.datacontract.org/2004/07/GreatCall.ShoppingCart.Contracts")]
        [System.ServiceModel.FaultContractAttribute(typeof(ShopCartTestHarness.CartService.CartNotFoundFault), Action="http://tempuri.org/ICartService/UpdateCartCartNotFoundFaultFault", Name="CartNotFoundFault", Namespace="http://schemas.datacontract.org/2004/07/GreatCall.ShoppingCart.Contracts")]
        [System.ServiceModel.FaultContractAttribute(typeof(ShopCartTestHarness.CartService.ProductNotFoundInCartFault), Action="http://tempuri.org/ICartService/UpdateCartProductNotFoundInCartFaultFault", Name="ProductNotFoundInCartFault", Namespace="http://schemas.datacontract.org/2004/07/GreatCall.ShoppingCart.Contracts")]
        ShopCartTestHarness.CartService.Cart UpdateCart(ShopCartTestHarness.CartService.CartUpdateRequest update);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICartService/UpdateCartWithCartUpdateRequestList", ReplyAction="http://tempuri.org/ICartService/UpdateCartWithCartUpdateRequestListResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ShopCartTestHarness.CartService.CartNotFoundFault), Action="http://tempuri.org/ICartService/UpdateCartWithCartUpdateRequestListCartNotFoundFa" +
            "ultFault", Name="CartNotFoundFault", Namespace="http://schemas.datacontract.org/2004/07/GreatCall.ShoppingCart.Contracts")]
        [System.ServiceModel.FaultContractAttribute(typeof(ShopCartTestHarness.CartService.ProductNotFoundInCartFault), Action="http://tempuri.org/ICartService/UpdateCartWithCartUpdateRequestListProductNotFoun" +
            "dInCartFaultFault", Name="ProductNotFoundInCartFault", Namespace="http://schemas.datacontract.org/2004/07/GreatCall.ShoppingCart.Contracts")]
        [System.ServiceModel.FaultContractAttribute(typeof(ShopCartTestHarness.CartService.ProductNotFoundFault), Action="http://tempuri.org/ICartService/UpdateCartWithCartUpdateRequestListProductNotFoun" +
            "dFaultFault", Name="ProductNotFoundFault", Namespace="http://schemas.datacontract.org/2004/07/GreatCall.ShoppingCart.Contracts")]
        ShopCartTestHarness.CartService.Cart UpdateCartWithCartUpdateRequestList(ShopCartTestHarness.CartService.CartUpdateRequest[] update);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICartService/SaveCart", ReplyAction="http://tempuri.org/ICartService/SaveCartResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ShopCartTestHarness.CartService.CartNotFoundFault), Action="http://tempuri.org/ICartService/SaveCartCartNotFoundFaultFault", Name="CartNotFoundFault", Namespace="http://schemas.datacontract.org/2004/07/GreatCall.ShoppingCart.Contracts")]
        void SaveCart(ShopCartTestHarness.CartService.Cart cart);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICartService/GetProductForCart", ReplyAction="http://tempuri.org/ICartService/GetProductForCartResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ShopCartTestHarness.CartService.ProductNotFoundFault), Action="http://tempuri.org/ICartService/GetProductForCartProductNotFoundFaultFault", Name="ProductNotFoundFault", Namespace="http://schemas.datacontract.org/2004/07/GreatCall.ShoppingCart.Contracts")]
        ShopCartTestHarness.CartService.Product GetProductForCart(string cartId, string groupId, string productId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICartService/GetProduct", ReplyAction="http://tempuri.org/ICartService/GetProductResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ShopCartTestHarness.CartService.ProductNotFoundFault), Action="http://tempuri.org/ICartService/GetProductProductNotFoundFaultFault", Name="ProductNotFoundFault", Namespace="http://schemas.datacontract.org/2004/07/GreatCall.ShoppingCart.Contracts")]
        ShopCartTestHarness.CartService.Product GetProduct(string productId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICartService/GetOrderedProductsByID", ReplyAction="http://tempuri.org/ICartService/GetOrderedProductsByIDResponse")]
        ShopCartTestHarness.CartService.Product[] GetOrderedProductsByID(string[] productIDs);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICartService/GetProductsByType", ReplyAction="http://tempuri.org/ICartService/GetProductsByTypeResponse")]
        ShopCartTestHarness.CartService.Product[] GetProductsByType(string cartId, string groupId, ShopCartTestHarness.CartService.ProductType type);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICartServiceChannel : ShopCartTestHarness.CartService.ICartService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CartServiceClient : System.ServiceModel.ClientBase<ShopCartTestHarness.CartService.ICartService>, ShopCartTestHarness.CartService.ICartService {
        
        public CartServiceClient() {
        }
        
        public CartServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CartServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CartServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CartServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string CreateCart() {
            return base.Channel.CreateCart();
        }
        
        public ShopCartTestHarness.CartService.Cart GetCart(string cartId) {
            return base.Channel.GetCart(cartId);
        }
        
        public ShopCartTestHarness.CartService.Cart UpdateCart(ShopCartTestHarness.CartService.CartUpdateRequest update) {
            return base.Channel.UpdateCart(update);
        }
        
        public ShopCartTestHarness.CartService.Cart UpdateCartWithCartUpdateRequestList(ShopCartTestHarness.CartService.CartUpdateRequest[] update) {
            return base.Channel.UpdateCartWithCartUpdateRequestList(update);
        }
        
        public void SaveCart(ShopCartTestHarness.CartService.Cart cart) {
            base.Channel.SaveCart(cart);
        }
        
        public ShopCartTestHarness.CartService.Product GetProductForCart(string cartId, string groupId, string productId) {
            return base.Channel.GetProductForCart(cartId, groupId, productId);
        }
        
        public ShopCartTestHarness.CartService.Product GetProduct(string productId) {
            return base.Channel.GetProduct(productId);
        }
        
        public ShopCartTestHarness.CartService.Product[] GetOrderedProductsByID(string[] productIDs) {
            return base.Channel.GetOrderedProductsByID(productIDs);
        }
        
        public ShopCartTestHarness.CartService.Product[] GetProductsByType(string cartId, string groupId, ShopCartTestHarness.CartService.ProductType type) {
            return base.Channel.GetProductsByType(cartId, groupId, type);
        }
    }
}