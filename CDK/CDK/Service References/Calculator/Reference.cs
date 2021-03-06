﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CDK.Calculator {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfString", Namespace="http://cdk.com/webservices", ItemName="string")]
    [System.SerializableAttribute()]
    public class ArrayOfString : System.Collections.Generic.List<string> {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://cdk.com/webservices", ConfigurationName="Calculator.WebService1Soap")]
    public interface WebService1Soap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://cdk.com/webservices/Add", ReplyAction="*")]
        int Add(int firstNumber, int secondNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://cdk.com/webservices/Add", ReplyAction="*")]
        System.Threading.Tasks.Task<int> AddAsync(int firstNumber, int secondNumber);
        
        // CODEGEN: Generating message contract since element name GetCalculationsResult from namespace http://cdk.com/webservices is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://cdk.com/webservices/GetCalculations", ReplyAction="*")]
        CDK.Calculator.GetCalculationsResponse GetCalculations(CDK.Calculator.GetCalculationsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://cdk.com/webservices/GetCalculations", ReplyAction="*")]
        System.Threading.Tasks.Task<CDK.Calculator.GetCalculationsResponse> GetCalculationsAsync(CDK.Calculator.GetCalculationsRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCalculationsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetCalculations", Namespace="http://cdk.com/webservices", Order=0)]
        public CDK.Calculator.GetCalculationsRequestBody Body;
        
        public GetCalculationsRequest() {
        }
        
        public GetCalculationsRequest(CDK.Calculator.GetCalculationsRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetCalculationsRequestBody {
        
        public GetCalculationsRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCalculationsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetCalculationsResponse", Namespace="http://cdk.com/webservices", Order=0)]
        public CDK.Calculator.GetCalculationsResponseBody Body;
        
        public GetCalculationsResponse() {
        }
        
        public GetCalculationsResponse(CDK.Calculator.GetCalculationsResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://cdk.com/webservices")]
    public partial class GetCalculationsResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public CDK.Calculator.ArrayOfString GetCalculationsResult;
        
        public GetCalculationsResponseBody() {
        }
        
        public GetCalculationsResponseBody(CDK.Calculator.ArrayOfString GetCalculationsResult) {
            this.GetCalculationsResult = GetCalculationsResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : CDK.Calculator.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<CDK.Calculator.WebService1Soap>, CDK.Calculator.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Add(int firstNumber, int secondNumber) {
            return base.Channel.Add(firstNumber, secondNumber);
        }
        
        public System.Threading.Tasks.Task<int> AddAsync(int firstNumber, int secondNumber) {
            return base.Channel.AddAsync(firstNumber, secondNumber);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CDK.Calculator.GetCalculationsResponse CDK.Calculator.WebService1Soap.GetCalculations(CDK.Calculator.GetCalculationsRequest request) {
            return base.Channel.GetCalculations(request);
        }
        
        public CDK.Calculator.ArrayOfString GetCalculations() {
            CDK.Calculator.GetCalculationsRequest inValue = new CDK.Calculator.GetCalculationsRequest();
            inValue.Body = new CDK.Calculator.GetCalculationsRequestBody();
            CDK.Calculator.GetCalculationsResponse retVal = ((CDK.Calculator.WebService1Soap)(this)).GetCalculations(inValue);
            return retVal.Body.GetCalculationsResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CDK.Calculator.GetCalculationsResponse> CDK.Calculator.WebService1Soap.GetCalculationsAsync(CDK.Calculator.GetCalculationsRequest request) {
            return base.Channel.GetCalculationsAsync(request);
        }
        
        public System.Threading.Tasks.Task<CDK.Calculator.GetCalculationsResponse> GetCalculationsAsync() {
            CDK.Calculator.GetCalculationsRequest inValue = new CDK.Calculator.GetCalculationsRequest();
            inValue.Body = new CDK.Calculator.GetCalculationsRequestBody();
            return ((CDK.Calculator.WebService1Soap)(this)).GetCalculationsAsync(inValue);
        }
    }
}
