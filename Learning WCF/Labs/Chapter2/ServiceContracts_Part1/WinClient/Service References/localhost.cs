namespace WinClient.localhost
{


    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName = "WinClient.localhost.IServiceA")]
    public interface IServiceA
    {

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IServiceA/Operation1", ReplyAction = "http://tempuri.org/IServiceA/Operation1Response")]
        string Operation1();

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IServiceA/Operation2", ReplyAction = "http://tempuri.org/IServiceA/Operation2Response")]
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
