﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CompanyClient.CompanyService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CompanyService.ICompanyPublicService")]
    public interface ICompanyPublicService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICompanyPublicService/GetPubliInformation", ReplyAction="http://tempuri.org/ICompanyPublicService/GetPubliInformationResponse")]
        string GetPubliInformation();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICompanyPublicService/GetPubliInformation", ReplyAction="http://tempuri.org/ICompanyPublicService/GetPubliInformationResponse")]
        System.Threading.Tasks.Task<string> GetPubliInformationAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICompanyPublicServiceChannel : CompanyClient.CompanyService.ICompanyPublicService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CompanyPublicServiceClient : System.ServiceModel.ClientBase<CompanyClient.CompanyService.ICompanyPublicService>, CompanyClient.CompanyService.ICompanyPublicService {
        
        public CompanyPublicServiceClient() {
        }
        
        public CompanyPublicServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CompanyPublicServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CompanyPublicServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CompanyPublicServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetPubliInformation() {
            return base.Channel.GetPubliInformation();
        }
        
        public System.Threading.Tasks.Task<string> GetPubliInformationAsync() {
            return base.Channel.GetPubliInformationAsync();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CompanyService.ICompanyConfidentialService")]
    public interface ICompanyConfidentialService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICompanyConfidentialService/GetConfidentialInformation", ReplyAction="http://tempuri.org/ICompanyConfidentialService/GetConfidentialInformationResponse" +
            "")]
        string GetConfidentialInformation();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICompanyConfidentialService/GetConfidentialInformation", ReplyAction="http://tempuri.org/ICompanyConfidentialService/GetConfidentialInformationResponse" +
            "")]
        System.Threading.Tasks.Task<string> GetConfidentialInformationAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICompanyConfidentialServiceChannel : CompanyClient.CompanyService.ICompanyConfidentialService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CompanyConfidentialServiceClient : System.ServiceModel.ClientBase<CompanyClient.CompanyService.ICompanyConfidentialService>, CompanyClient.CompanyService.ICompanyConfidentialService {
        
        public CompanyConfidentialServiceClient() {
        }
        
        public CompanyConfidentialServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CompanyConfidentialServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CompanyConfidentialServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CompanyConfidentialServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetConfidentialInformation() {
            return base.Channel.GetConfidentialInformation();
        }
        
        public System.Threading.Tasks.Task<string> GetConfidentialInformationAsync() {
            return base.Channel.GetConfidentialInformationAsync();
        }
    }
}
