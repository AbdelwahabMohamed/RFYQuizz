﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.35317
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyRedPillConsumer.MyRedPillServiceRef {
    using System.Runtime.Serialization;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TriangleType", Namespace="http://KnockKnock.readify.net")]
    public enum TriangleType : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Error = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Equilateral = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Isosceles = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Scalene = 3,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MyRedPillServiceRef.IMyRedPillService")]
    public interface IMyRedPillService {
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://KnockKnock.readify.net) of message WhatIsYourTokenRequest does not match the default value (http://tempuri.org/)
        [System.ServiceModel.OperationContractAttribute(Action="http://KnockKnock.readify.net/IRedPill/WhatIsYourToken", ReplyAction="http://KnockKnock.readify.net/IRedPill/WhatIsYourTokenResponse")]
        MyRedPillConsumer.MyRedPillServiceRef.WhatIsYourTokenResponse WhatIsYourToken(MyRedPillConsumer.MyRedPillServiceRef.WhatIsYourTokenRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://KnockKnock.readify.net/IRedPill/WhatIsYourToken", ReplyAction="http://KnockKnock.readify.net/IRedPill/WhatIsYourTokenResponse")]
        System.Threading.Tasks.Task<MyRedPillConsumer.MyRedPillServiceRef.WhatIsYourTokenResponse> WhatIsYourTokenAsync(MyRedPillConsumer.MyRedPillServiceRef.WhatIsYourTokenRequest request);
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://KnockKnock.readify.net) of message FibonacciNumberRequest does not match the default value (http://tempuri.org/)
        [System.ServiceModel.OperationContractAttribute(Action="http://KnockKnock.readify.net/IRedPill/FibonacciNumber", ReplyAction="http://KnockKnock.readify.net/IRedPill/FibonacciNumberResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(System.ArgumentOutOfRangeException), Action="http://KnockKnock.readify.net/IRedPill/FibonacciNumberArgumentOutOfRangeException" +
            "Fault", Name="ArgumentOutOfRangeException", Namespace="http://schemas.datacontract.org/2004/07/System")]
        MyRedPillConsumer.MyRedPillServiceRef.FibonacciNumberResponse FibonacciNumber(MyRedPillConsumer.MyRedPillServiceRef.FibonacciNumberRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://KnockKnock.readify.net/IRedPill/FibonacciNumber", ReplyAction="http://KnockKnock.readify.net/IRedPill/FibonacciNumberResponse")]
        System.Threading.Tasks.Task<MyRedPillConsumer.MyRedPillServiceRef.FibonacciNumberResponse> FibonacciNumberAsync(MyRedPillConsumer.MyRedPillServiceRef.FibonacciNumberRequest request);
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://KnockKnock.readify.net) of message WhatShapeIsThisRequest does not match the default value (http://tempuri.org/)
        [System.ServiceModel.OperationContractAttribute(Action="http://KnockKnock.readify.net/IRedPill/WhatShapeIsThis", ReplyAction="http://KnockKnock.readify.net/IRedPill/WhatShapeIsThisResponse")]
        MyRedPillConsumer.MyRedPillServiceRef.WhatShapeIsThisResponse WhatShapeIsThis(MyRedPillConsumer.MyRedPillServiceRef.WhatShapeIsThisRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://KnockKnock.readify.net/IRedPill/WhatShapeIsThis", ReplyAction="http://KnockKnock.readify.net/IRedPill/WhatShapeIsThisResponse")]
        System.Threading.Tasks.Task<MyRedPillConsumer.MyRedPillServiceRef.WhatShapeIsThisResponse> WhatShapeIsThisAsync(MyRedPillConsumer.MyRedPillServiceRef.WhatShapeIsThisRequest request);
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://KnockKnock.readify.net) of message ReverseWordsRequest does not match the default value (http://tempuri.org/)
        [System.ServiceModel.OperationContractAttribute(Action="http://KnockKnock.readify.net/IRedPill/ReverseWords", ReplyAction="http://KnockKnock.readify.net/IRedPill/ReverseWordsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(System.ArgumentNullException), Action="http://KnockKnock.readify.net/IRedPill/ReverseWordsArgumentNullExceptionFault", Name="ArgumentNullException", Namespace="http://schemas.datacontract.org/2004/07/System")]
        MyRedPillConsumer.MyRedPillServiceRef.ReverseWordsResponse ReverseWords(MyRedPillConsumer.MyRedPillServiceRef.ReverseWordsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://KnockKnock.readify.net/IRedPill/ReverseWords", ReplyAction="http://KnockKnock.readify.net/IRedPill/ReverseWordsResponse")]
        System.Threading.Tasks.Task<MyRedPillConsumer.MyRedPillServiceRef.ReverseWordsResponse> ReverseWordsAsync(MyRedPillConsumer.MyRedPillServiceRef.ReverseWordsRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="WhatIsYourToken", WrapperNamespace="http://KnockKnock.readify.net", IsWrapped=true)]
    public partial class WhatIsYourTokenRequest {
        
        public WhatIsYourTokenRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="WhatIsYourTokenResponse", WrapperNamespace="http://KnockKnock.readify.net", IsWrapped=true)]
    public partial class WhatIsYourTokenResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://KnockKnock.readify.net", Order=0)]
        public System.Guid WhatIsYourTokenResult;
        
        public WhatIsYourTokenResponse() {
        }
        
        public WhatIsYourTokenResponse(System.Guid WhatIsYourTokenResult) {
            this.WhatIsYourTokenResult = WhatIsYourTokenResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="FibonacciNumber", WrapperNamespace="http://KnockKnock.readify.net", IsWrapped=true)]
    public partial class FibonacciNumberRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://KnockKnock.readify.net", Order=0)]
        public long n;
        
        public FibonacciNumberRequest() {
        }
        
        public FibonacciNumberRequest(long n) {
            this.n = n;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="FibonacciNumberResponse", WrapperNamespace="http://KnockKnock.readify.net", IsWrapped=true)]
    public partial class FibonacciNumberResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://KnockKnock.readify.net", Order=0)]
        public long FibonacciNumberResult;
        
        public FibonacciNumberResponse() {
        }
        
        public FibonacciNumberResponse(long FibonacciNumberResult) {
            this.FibonacciNumberResult = FibonacciNumberResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="WhatShapeIsThis", WrapperNamespace="http://KnockKnock.readify.net", IsWrapped=true)]
    public partial class WhatShapeIsThisRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://KnockKnock.readify.net", Order=0)]
        public int a;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://KnockKnock.readify.net", Order=1)]
        public int b;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://KnockKnock.readify.net", Order=2)]
        public int c;
        
        public WhatShapeIsThisRequest() {
        }
        
        public WhatShapeIsThisRequest(int a, int b, int c) {
            this.a = a;
            this.b = b;
            this.c = c;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="WhatShapeIsThisResponse", WrapperNamespace="http://KnockKnock.readify.net", IsWrapped=true)]
    public partial class WhatShapeIsThisResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://KnockKnock.readify.net", Order=0)]
        public MyRedPillConsumer.MyRedPillServiceRef.TriangleType WhatShapeIsThisResult;
        
        public WhatShapeIsThisResponse() {
        }
        
        public WhatShapeIsThisResponse(MyRedPillConsumer.MyRedPillServiceRef.TriangleType WhatShapeIsThisResult) {
            this.WhatShapeIsThisResult = WhatShapeIsThisResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ReverseWords", WrapperNamespace="http://KnockKnock.readify.net", IsWrapped=true)]
    public partial class ReverseWordsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://KnockKnock.readify.net", Order=0)]
        public string s;
        
        public ReverseWordsRequest() {
        }
        
        public ReverseWordsRequest(string s) {
            this.s = s;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ReverseWordsResponse", WrapperNamespace="http://KnockKnock.readify.net", IsWrapped=true)]
    public partial class ReverseWordsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://KnockKnock.readify.net", Order=0)]
        public string ReverseWordsResult;
        
        public ReverseWordsResponse() {
        }
        
        public ReverseWordsResponse(string ReverseWordsResult) {
            this.ReverseWordsResult = ReverseWordsResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMyRedPillServiceChannel : MyRedPillConsumer.MyRedPillServiceRef.IMyRedPillService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MyRedPillServiceClient : System.ServiceModel.ClientBase<MyRedPillConsumer.MyRedPillServiceRef.IMyRedPillService>, MyRedPillConsumer.MyRedPillServiceRef.IMyRedPillService {
        
        public MyRedPillServiceClient() {
        }
        
        public MyRedPillServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MyRedPillServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MyRedPillServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MyRedPillServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MyRedPillConsumer.MyRedPillServiceRef.WhatIsYourTokenResponse MyRedPillConsumer.MyRedPillServiceRef.IMyRedPillService.WhatIsYourToken(MyRedPillConsumer.MyRedPillServiceRef.WhatIsYourTokenRequest request) {
            return base.Channel.WhatIsYourToken(request);
        }
        
        public System.Guid WhatIsYourToken() {
            MyRedPillConsumer.MyRedPillServiceRef.WhatIsYourTokenRequest inValue = new MyRedPillConsumer.MyRedPillServiceRef.WhatIsYourTokenRequest();
            MyRedPillConsumer.MyRedPillServiceRef.WhatIsYourTokenResponse retVal = ((MyRedPillConsumer.MyRedPillServiceRef.IMyRedPillService)(this)).WhatIsYourToken(inValue);
            return retVal.WhatIsYourTokenResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<MyRedPillConsumer.MyRedPillServiceRef.WhatIsYourTokenResponse> MyRedPillConsumer.MyRedPillServiceRef.IMyRedPillService.WhatIsYourTokenAsync(MyRedPillConsumer.MyRedPillServiceRef.WhatIsYourTokenRequest request) {
            return base.Channel.WhatIsYourTokenAsync(request);
        }
        
        public System.Threading.Tasks.Task<MyRedPillConsumer.MyRedPillServiceRef.WhatIsYourTokenResponse> WhatIsYourTokenAsync() {
            MyRedPillConsumer.MyRedPillServiceRef.WhatIsYourTokenRequest inValue = new MyRedPillConsumer.MyRedPillServiceRef.WhatIsYourTokenRequest();
            return ((MyRedPillConsumer.MyRedPillServiceRef.IMyRedPillService)(this)).WhatIsYourTokenAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MyRedPillConsumer.MyRedPillServiceRef.FibonacciNumberResponse MyRedPillConsumer.MyRedPillServiceRef.IMyRedPillService.FibonacciNumber(MyRedPillConsumer.MyRedPillServiceRef.FibonacciNumberRequest request) {
            return base.Channel.FibonacciNumber(request);
        }
        
        public long FibonacciNumber(long n) {
            MyRedPillConsumer.MyRedPillServiceRef.FibonacciNumberRequest inValue = new MyRedPillConsumer.MyRedPillServiceRef.FibonacciNumberRequest();
            inValue.n = n;
            MyRedPillConsumer.MyRedPillServiceRef.FibonacciNumberResponse retVal = ((MyRedPillConsumer.MyRedPillServiceRef.IMyRedPillService)(this)).FibonacciNumber(inValue);
            return retVal.FibonacciNumberResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<MyRedPillConsumer.MyRedPillServiceRef.FibonacciNumberResponse> MyRedPillConsumer.MyRedPillServiceRef.IMyRedPillService.FibonacciNumberAsync(MyRedPillConsumer.MyRedPillServiceRef.FibonacciNumberRequest request) {
            return base.Channel.FibonacciNumberAsync(request);
        }
        
        public System.Threading.Tasks.Task<MyRedPillConsumer.MyRedPillServiceRef.FibonacciNumberResponse> FibonacciNumberAsync(long n) {
            MyRedPillConsumer.MyRedPillServiceRef.FibonacciNumberRequest inValue = new MyRedPillConsumer.MyRedPillServiceRef.FibonacciNumberRequest();
            inValue.n = n;
            return ((MyRedPillConsumer.MyRedPillServiceRef.IMyRedPillService)(this)).FibonacciNumberAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MyRedPillConsumer.MyRedPillServiceRef.WhatShapeIsThisResponse MyRedPillConsumer.MyRedPillServiceRef.IMyRedPillService.WhatShapeIsThis(MyRedPillConsumer.MyRedPillServiceRef.WhatShapeIsThisRequest request) {
            return base.Channel.WhatShapeIsThis(request);
        }
        
        public MyRedPillConsumer.MyRedPillServiceRef.TriangleType WhatShapeIsThis(int a, int b, int c) {
            MyRedPillConsumer.MyRedPillServiceRef.WhatShapeIsThisRequest inValue = new MyRedPillConsumer.MyRedPillServiceRef.WhatShapeIsThisRequest();
            inValue.a = a;
            inValue.b = b;
            inValue.c = c;
            MyRedPillConsumer.MyRedPillServiceRef.WhatShapeIsThisResponse retVal = ((MyRedPillConsumer.MyRedPillServiceRef.IMyRedPillService)(this)).WhatShapeIsThis(inValue);
            return retVal.WhatShapeIsThisResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<MyRedPillConsumer.MyRedPillServiceRef.WhatShapeIsThisResponse> MyRedPillConsumer.MyRedPillServiceRef.IMyRedPillService.WhatShapeIsThisAsync(MyRedPillConsumer.MyRedPillServiceRef.WhatShapeIsThisRequest request) {
            return base.Channel.WhatShapeIsThisAsync(request);
        }
        
        public System.Threading.Tasks.Task<MyRedPillConsumer.MyRedPillServiceRef.WhatShapeIsThisResponse> WhatShapeIsThisAsync(int a, int b, int c) {
            MyRedPillConsumer.MyRedPillServiceRef.WhatShapeIsThisRequest inValue = new MyRedPillConsumer.MyRedPillServiceRef.WhatShapeIsThisRequest();
            inValue.a = a;
            inValue.b = b;
            inValue.c = c;
            return ((MyRedPillConsumer.MyRedPillServiceRef.IMyRedPillService)(this)).WhatShapeIsThisAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MyRedPillConsumer.MyRedPillServiceRef.ReverseWordsResponse MyRedPillConsumer.MyRedPillServiceRef.IMyRedPillService.ReverseWords(MyRedPillConsumer.MyRedPillServiceRef.ReverseWordsRequest request) {
            return base.Channel.ReverseWords(request);
        }
        
        public string ReverseWords(string s) {
            MyRedPillConsumer.MyRedPillServiceRef.ReverseWordsRequest inValue = new MyRedPillConsumer.MyRedPillServiceRef.ReverseWordsRequest();
            inValue.s = s;
            MyRedPillConsumer.MyRedPillServiceRef.ReverseWordsResponse retVal = ((MyRedPillConsumer.MyRedPillServiceRef.IMyRedPillService)(this)).ReverseWords(inValue);
            return retVal.ReverseWordsResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<MyRedPillConsumer.MyRedPillServiceRef.ReverseWordsResponse> MyRedPillConsumer.MyRedPillServiceRef.IMyRedPillService.ReverseWordsAsync(MyRedPillConsumer.MyRedPillServiceRef.ReverseWordsRequest request) {
            return base.Channel.ReverseWordsAsync(request);
        }
        
        public System.Threading.Tasks.Task<MyRedPillConsumer.MyRedPillServiceRef.ReverseWordsResponse> ReverseWordsAsync(string s) {
            MyRedPillConsumer.MyRedPillServiceRef.ReverseWordsRequest inValue = new MyRedPillConsumer.MyRedPillServiceRef.ReverseWordsRequest();
            inValue.s = s;
            return ((MyRedPillConsumer.MyRedPillServiceRef.IMyRedPillService)(this)).ReverseWordsAsync(inValue);
        }
    }
}
