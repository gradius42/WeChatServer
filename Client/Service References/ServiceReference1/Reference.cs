﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetMessage", ReplyAction="http://tempuri.org/IService/GetMessageResponse")]
        string GetMessage(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetMessage", ReplyAction="http://tempuri.org/IService/GetMessageResponse")]
        System.Threading.Tasks.Task<string> GetMessageAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetResultOfAddition", ReplyAction="http://tempuri.org/IService/GetResultOfAdditionResponse")]
        int GetResultOfAddition(int val1, int val2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetResultOfAddition", ReplyAction="http://tempuri.org/IService/GetResultOfAdditionResponse")]
        System.Threading.Tasks.Task<int> GetResultOfAdditionAsync(int val1, int val2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SetTest", ReplyAction="http://tempuri.org/IService/SetTestResponse")]
        void SetTest(int val);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SetTest", ReplyAction="http://tempuri.org/IService/SetTestResponse")]
        System.Threading.Tasks.Task SetTestAsync(int val);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetTest", ReplyAction="http://tempuri.org/IService/GetTestResponse")]
        int GetTest();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetTest", ReplyAction="http://tempuri.org/IService/GetTestResponse")]
        System.Threading.Tasks.Task<int> GetTestAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : Client.ServiceReference1.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<Client.ServiceReference1.IService>, Client.ServiceReference1.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetMessage(string name) {
            return base.Channel.GetMessage(name);
        }
        
        public System.Threading.Tasks.Task<string> GetMessageAsync(string name) {
            return base.Channel.GetMessageAsync(name);
        }
        
        public int GetResultOfAddition(int val1, int val2) {
            return base.Channel.GetResultOfAddition(val1, val2);
        }
        
        public System.Threading.Tasks.Task<int> GetResultOfAdditionAsync(int val1, int val2) {
            return base.Channel.GetResultOfAdditionAsync(val1, val2);
        }
        
        public void SetTest(int val) {
            base.Channel.SetTest(val);
        }
        
        public System.Threading.Tasks.Task SetTestAsync(int val) {
            return base.Channel.SetTestAsync(val);
        }
        
        public int GetTest() {
            return base.Channel.GetTest();
        }
        
        public System.Threading.Tasks.Task<int> GetTestAsync() {
            return base.Channel.GetTestAsync();
        }
    }
}