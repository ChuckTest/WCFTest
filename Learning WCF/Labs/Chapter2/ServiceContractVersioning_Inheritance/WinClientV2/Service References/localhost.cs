namespace WinClientV2.localhost
{


    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.thatindigogirl.com/samples/2006/08", ConfigurationName = "WinClientV2.localhost.ServiceAContract")]
    public interface ServiceAContract
    {

        // CODEGEN: Generating message contract since the wrapper namespace (http://www.thatindigogirl.com/samples/2006/06) of message Operation1Request does not match the default value (http://www.thatindigogirl.com/samples/2006/08)
        [System.ServiceModel.OperationContractAttribute(Action = "http://www.thatindigogirl.com/samples/2006/06/ServiceAContract/Operation1", ReplyAction = "http://www.thatindigogirl.com/samples/2006/06/ServiceAContract/Operation1Response" +
            "")]
        WinClientV2.localhost.Operation1Response Operation1(WinClientV2.localhost.Operation1Request request);

        // CODEGEN: Generating message contract since the wrapper namespace (http://www.thatindigogirl.com/samples/2006/06) of message Operation2Request does not match the default value (http://www.thatindigogirl.com/samples/2006/08)
        [System.ServiceModel.OperationContractAttribute(Action = "http://www.thatindigogirl.com/samples/2006/06/ServiceAContract/Operation2", ReplyAction = "http://www.thatindigogirl.com/samples/2006/06/ServiceAContract/Operation2Response" +
            "")]
        WinClientV2.localhost.Operation2Response Operation2(WinClientV2.localhost.Operation2Request request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://www.thatindigogirl.com/samples/2006/08/ServiceAContract/Operation3", ReplyAction = "http://www.thatindigogirl.com/samples/2006/08/ServiceAContract/Operation3Response" +
            "")]
        string Operation3();
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "Operation1", WrapperNamespace = "http://www.thatindigogirl.com/samples/2006/06", IsWrapped = true)]
    public partial class Operation1Request
    {

        public Operation1Request()
        {
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "Operation1Response", WrapperNamespace = "http://www.thatindigogirl.com/samples/2006/06", IsWrapped = true)]
    public partial class Operation1Response
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.thatindigogirl.com/samples/2006/06", Order = 0)]
        public string Operation1Result;

        public Operation1Response()
        {
        }

        public Operation1Response(string Operation1Result)
        {
            this.Operation1Result = Operation1Result;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "Operation2", WrapperNamespace = "http://www.thatindigogirl.com/samples/2006/06", IsWrapped = true)]
    public partial class Operation2Request
    {

        public Operation2Request()
        {
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "Operation2Response", WrapperNamespace = "http://www.thatindigogirl.com/samples/2006/06", IsWrapped = true)]
    public partial class Operation2Response
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.thatindigogirl.com/samples/2006/06", Order = 0)]
        public string Operation2Result;

        public Operation2Response()
        {
        }

        public Operation2Response(string Operation2Result)
        {
            this.Operation2Result = Operation2Result;
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface ServiceAContractChannel : WinClientV2.localhost.ServiceAContract, System.ServiceModel.IClientChannel
    {
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class ServiceAContractClient : System.ServiceModel.ClientBase<WinClientV2.localhost.ServiceAContract>, WinClientV2.localhost.ServiceAContract
    {

        public ServiceAContractClient()
        {
        }

        public ServiceAContractClient(string endpointConfigurationName) :
            base(endpointConfigurationName)
        {
        }

        public ServiceAContractClient(string endpointConfigurationName, string remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public ServiceAContractClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public ServiceAContractClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
            base(binding, remoteAddress)
        {
        }

        WinClientV2.localhost.Operation1Response WinClientV2.localhost.ServiceAContract.Operation1(WinClientV2.localhost.Operation1Request request)
        {
            return base.Channel.Operation1(request);
        }

        public string Operation1()
        {
            WinClientV2.localhost.Operation1Request inValue = new WinClientV2.localhost.Operation1Request();
            WinClientV2.localhost.Operation1Response retVal = ((WinClientV2.localhost.ServiceAContract)(this)).Operation1(inValue);
            return retVal.Operation1Result;
        }

        WinClientV2.localhost.Operation2Response WinClientV2.localhost.ServiceAContract.Operation2(WinClientV2.localhost.Operation2Request request)
        {
            return base.Channel.Operation2(request);
        }

        public string Operation2()
        {
            WinClientV2.localhost.Operation2Request inValue = new WinClientV2.localhost.Operation2Request();
            WinClientV2.localhost.Operation2Response retVal = ((WinClientV2.localhost.ServiceAContract)(this)).Operation2(inValue);
            return retVal.Operation2Result;
        }

        public string Operation3()
        {
            return base.Channel.Operation3();
        }
    }
}
