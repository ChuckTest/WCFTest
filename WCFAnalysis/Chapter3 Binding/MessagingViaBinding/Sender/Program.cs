using System;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Xml.Linq;

namespace Sender
{
    class Program
    {
        static void Main()
        {
            Uri listenUri=new Uri("http://192.168.1.18/listener");
            Binding binding = new BasicHttpBinding();

            IChannelFactory<IRequestChannel> channelFactory = binding.BuildChannelFactory<IRequestChannel>();
            channelFactory.Open();

            IRequestChannel channel = channelFactory.CreateChannel(new EndpointAddress(listenUri));
            channel.Open();

            Message replyMessage = channel.Request(CreateRequestMessage(binding));
            Console.WriteLine(replyMessage);

            Console.WriteLine("Press Enter to terminate the client");
            Console.ReadLine();
        }

        private static Message CreateRequestMessage(Binding binding)
        {
            Message message;
            string action = "http://www.chucklu.com/calculatorService/Add";
            XNamespace xNamespace = "http://www.chucklu.com";
            XElement body =
                new XElement(new XElement(xNamespace + "Add", new XElement(xNamespace + "x", 1),
                    new XElement(xNamespace + "y", 2)));
            message = Message.CreateMessage(binding.MessageVersion, action, body);
            return message;
        }
    }
}
