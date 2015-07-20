namespace WinClient.localhost
{


    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Name = "ServiceAContract", Namespace = "http://www.thatindigogirl.com/samples/2006/06", ConfigurationName = "WinClient.localhost.IServiceA")]
    public interface IServiceA
    {

        [System.ServiceModel.OperationContractAttribute(Action = "http://www.thatindigogirl.com/samples/2006/06/ServiceAContract/Operation1", ReplyAction = "http://www.thatindigogirl.com/samples/2006/06/ServiceAContract/Operation1Response")]
        string Operation1();

        [System.ServiceModel.OperationContractAttribute(Action = "http://www.thatindigogirl.com/samples/2006/06/ServiceAContract/Operation2", ReplyAction = "http://www.thatindigogirl.com/samples/2006/06/ServiceAContract/Operation2Response")]
        string Operation2();
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface IServiceAChannel : WinClient.localhost.IServiceA, System.ServiceModel.IClientChannel
    {
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class ServiceAClient : System.ServiceModel.ClientBase<WinClient.localhost.IServiceA>, WinClient.localhost.IServiceA
    {

        public ServiceAClient()
        {
        }

        public ServiceAClient(string endpointConfigurationName) :
            base(endpointConfigurationName)
        {
        }

        public ServiceAClient(string endpointConfigurationName, string remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public ServiceAClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public ServiceAClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
            base(binding, remoteAddress)
        {
        }

        public string Operation1()
        {
            return base.Channel.Operation1();
        }

        public string Operation2()
        {
            return base.Channel.Operation2();
        }
    }
}
