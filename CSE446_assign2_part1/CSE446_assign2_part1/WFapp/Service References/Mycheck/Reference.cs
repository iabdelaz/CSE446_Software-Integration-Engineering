﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WorkflowConsoleApplication1.Mycheck {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Mycheck.IService")]
    public interface IService {
        checkNumberResponse checkNumberResponse
        {
            get;
            set;
        }
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/secretNumber", ReplyAction="http://tempuri.org/IService/secretNumberResponse")]
        WorkflowConsoleApplication1.Mycheck.secretNumberResponse secretNumber(WorkflowConsoleApplication1.Mycheck.secretNumberRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/secretNumber", ReplyAction="http://tempuri.org/IService/secretNumberResponse")]
        System.Threading.Tasks.Task<WorkflowConsoleApplication1.Mycheck.secretNumberResponse> secretNumberAsync(WorkflowConsoleApplication1.Mycheck.secretNumberRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/checkNumber", ReplyAction="http://tempuri.org/IService/checkNumberResponse")]
        WorkflowConsoleApplication1.Mycheck.checkNumberResponse checkNumber(WorkflowConsoleApplication1.Mycheck.checkNumberRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/checkNumber", ReplyAction="http://tempuri.org/IService/checkNumberResponse")]
        System.Threading.Tasks.Task<WorkflowConsoleApplication1.Mycheck.checkNumberResponse> checkNumberAsync(WorkflowConsoleApplication1.Mycheck.checkNumberRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="secretNumber", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class secretNumberRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int lower;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public int upper;
        
        public secretNumberRequest() {
        }
        
        public secretNumberRequest(int lower, int upper) {
            this.lower = lower;
            this.upper = upper;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="secretNumberResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class secretNumberResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int secretNumberResult;
        
        public secretNumberResponse() {
        }
        
        public secretNumberResponse(int secretNumberResult) {
            this.secretNumberResult = secretNumberResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="checkNumber", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class checkNumberRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int userNum;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public int secretNum;
        
        public checkNumberRequest() {
        }
        
        public checkNumberRequest(int userNum, int secretNum) {
            this.userNum = userNum;
            this.secretNum = secretNum;
        }

        public IService IService
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="checkNumberResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class checkNumberResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string checkNumberResult;
        
        public checkNumberResponse() {
        }
        
        public checkNumberResponse(string checkNumberResult) {
            this.checkNumberResult = checkNumberResult;
        }
    }
}
