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

            //创建信道工厂
            IChannelFactory<IRequestChannel> channelFactory = binding.BuildChannelFactory<IRequestChannel>();
            //打开信道工厂
            channelFactory.Open();

            //创建请求信道
            IRequestChannel requestChannel = channelFactory.CreateChannel(new EndpointAddress(listenUri));
            //打开请求信道
            requestChannel.Open();

            //发送请求消息，并接收回复消息
            Message replyMessage = requestChannel.Request(CreateRequestMessage(binding.MessageVersion));
            Console.WriteLine(replyMessage);

            Console.WriteLine("Press Enter to terminate the client");
            Console.ReadLine();
        }

        private static Message CreateRequestMessage(MessageVersion messageVersion)
        {
            Message message;
            string action = "http://www.chucklu.com/calculatorService/Add";
            XNamespace xNamespace = "http://www.chucklu.com";
            XElement body =
                new XElement(new XElement(xNamespace + "Add", new XElement(xNamespace + "x", 1),
                    new XElement(xNamespace + "y", 2)));
            message = Message.CreateMessage(messageVersion, action, body);
            return message;
        }
    }
}
