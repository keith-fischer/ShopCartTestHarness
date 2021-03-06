﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShopCart.ServiceReferenceCartService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceCartService.ICartService")]
    public interface ICartService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICartService/CreateCart", ReplyAction="http://tempuri.org/ICartService/CreateCartResponse")]
        string CreateCart();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICartService/GetCart", ReplyAction="http://tempuri.org/ICartService/GetCartResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(GreatCall.ShoppingCart.Contracts.CartNotFoundFault), Action="http://tempuri.org/ICartService/GetCartCartNotFoundFaultFault", Name="CartNotFoundFault", Namespace="http://schemas.datacontract.org/2004/07/GreatCall.ShoppingCart.Contracts")]
        GreatCall.ShoppingCart.Contracts.Cart GetCart(string cartId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICartService/UpdateCart", ReplyAction="http://tempuri.org/ICartService/UpdateCartResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(GreatCall.ShoppingCart.Contracts.ProductNotFoundFault), Action="http://tempuri.org/ICartService/UpdateCartProductNotFoundFaultFault", Name="ProductNotFoundFault", Namespace="http://schemas.datacontract.org/2004/07/GreatCall.ShoppingCart.Contracts")]
        [System.ServiceModel.FaultContractAttribute(typeof(GreatCall.ShoppingCart.Contracts.CartNotFoundFault), Action="http://tempuri.org/ICartService/UpdateCartCartNotFoundFaultFault", Name="CartNotFoundFault", Namespace="http://schemas.datacontract.org/2004/07/GreatCall.ShoppingCart.Contracts")]
        [System.ServiceModel.FaultContractAttribute(typeof(GreatCall.ShoppingCart.Contracts.ProductNotFoundInCartFault), Action="http://tempuri.org/ICartService/UpdateCartProductNotFoundInCartFaultFault", Name="ProductNotFoundInCartFault", Namespace="http://schemas.datacontract.org/2004/07/GreatCall.ShoppingCart.Contracts")]
        GreatCall.ShoppingCart.Contracts.Cart UpdateCart(GreatCall.ShoppingCart.Contracts.CartUpdateRequest update);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICartService/UpdateCartWithCartUpdateRequestList", ReplyAction="http://tempuri.org/ICartService/UpdateCartWithCartUpdateRequestListResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(GreatCall.ShoppingCart.Contracts.CartNotFoundFault), Action="http://tempuri.org/ICartService/UpdateCartWithCartUpdateRequestListCartNotFoundFa" +
            "ultFault", Name="CartNotFoundFault", Namespace="http://schemas.datacontract.org/2004/07/GreatCall.ShoppingCart.Contracts")]
        [System.ServiceModel.FaultContractAttribute(typeof(GreatCall.ShoppingCart.Contracts.ProductNotFoundInCartFault), Action="http://tempuri.org/ICartService/UpdateCartWithCartUpdateRequestListProductNotFoun" +
            "dInCartFaultFault", Name="ProductNotFoundInCartFault", Namespace="http://schemas.datacontract.org/2004/07/GreatCall.ShoppingCart.Contracts")]
        [System.ServiceModel.FaultContractAttribute(typeof(GreatCall.ShoppingCart.Contracts.ProductNotFoundFault), Action="http://tempuri.org/ICartService/UpdateCartWithCartUpdateRequestListProductNotFoun" +
            "dFaultFault", Name="ProductNotFoundFault", Namespace="http://schemas.datacontract.org/2004/07/GreatCall.ShoppingCart.Contracts")]
        GreatCall.ShoppingCart.Contracts.Cart UpdateCartWithCartUpdateRequestList(GreatCall.ShoppingCart.Contracts.CartUpdateRequest[] update);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICartService/SaveCart", ReplyAction="http://tempuri.org/ICartService/SaveCartResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(GreatCall.ShoppingCart.Contracts.CartNotFoundFault), Action="http://tempuri.org/ICartService/SaveCartCartNotFoundFaultFault", Name="CartNotFoundFault", Namespace="http://schemas.datacontract.org/2004/07/GreatCall.ShoppingCart.Contracts")]
        void SaveCart(GreatCall.ShoppingCart.Contracts.Cart cart);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICartService/GetProductForCart", ReplyAction="http://tempuri.org/ICartService/GetProductForCartResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(GreatCall.ShoppingCart.Contracts.ProductNotFoundFault), Action="http://tempuri.org/ICartService/GetProductForCartProductNotFoundFaultFault", Name="ProductNotFoundFault", Namespace="http://schemas.datacontract.org/2004/07/GreatCall.ShoppingCart.Contracts")]
        GreatCall.ShoppingCart.Contracts.Product GetProductForCart(string cartId, string groupId, string productId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICartService/GetProduct", ReplyAction="http://tempuri.org/ICartService/GetProductResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(GreatCall.ShoppingCart.Contracts.ProductNotFoundFault), Action="http://tempuri.org/ICartService/GetProductProductNotFoundFaultFault", Name="ProductNotFoundFault", Namespace="http://schemas.datacontract.org/2004/07/GreatCall.ShoppingCart.Contracts")]
        GreatCall.ShoppingCart.Contracts.Product GetProduct(string productId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICartService/GetOrderedProductsByID", ReplyAction="http://tempuri.org/ICartService/GetOrderedProductsByIDResponse")]
        GreatCall.ShoppingCart.Contracts.Product[] GetOrderedProductsByID(string[] productIDs);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICartService/GetProductsByType", ReplyAction="http://tempuri.org/ICartService/GetProductsByTypeResponse")]
        GreatCall.ShoppingCart.Contracts.Product[] GetProductsByType(string cartId, string groupId, GreatCall.ShoppingCart.Contracts.ProductType type);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICartServiceChannel : ShopCart.ServiceReferenceCartService.ICartService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CartServiceClient : System.ServiceModel.ClientBase<ShopCart.ServiceReferenceCartService.ICartService>, ShopCart.ServiceReferenceCartService.ICartService {
        
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
        
        public GreatCall.ShoppingCart.Contracts.Cart GetCart(string cartId) {
            return base.Channel.GetCart(cartId);
        }
        
        public GreatCall.ShoppingCart.Contracts.Cart UpdateCart(GreatCall.ShoppingCart.Contracts.CartUpdateRequest update) {
            return base.Channel.UpdateCart(update);
        }
        
        public GreatCall.ShoppingCart.Contracts.Cart UpdateCartWithCartUpdateRequestList(GreatCall.ShoppingCart.Contracts.CartUpdateRequest[] update) {
            return base.Channel.UpdateCartWithCartUpdateRequestList(update);
        }
        
        public void SaveCart(GreatCall.ShoppingCart.Contracts.Cart cart) {
            base.Channel.SaveCart(cart);
        }
        
        public GreatCall.ShoppingCart.Contracts.Product GetProductForCart(string cartId, string groupId, string productId) {
            return base.Channel.GetProductForCart(cartId, groupId, productId);
        }
        
        public GreatCall.ShoppingCart.Contracts.Product GetProduct(string productId) {
            return base.Channel.GetProduct(productId);
        }
        
        public GreatCall.ShoppingCart.Contracts.Product[] GetOrderedProductsByID(string[] productIDs) {
            return base.Channel.GetOrderedProductsByID(productIDs);
        }
        
        public GreatCall.ShoppingCart.Contracts.Product[] GetProductsByType(string cartId, string groupId, GreatCall.ShoppingCart.Contracts.ProductType type) {
            return base.Channel.GetProductsByType(cartId, groupId, type);
        }
    }
}
