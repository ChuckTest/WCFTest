using System;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Xml.Linq;

namespace Receiver
{
    class Program
    {
        static void Main()
        {
            Uri listenUri = new Uri("http://192.168.1.18/listener");
            Binding binding = new BasicHttpBinding();
            IChannelListener<IReplyChannel> channelListener = binding.BuildChannelListener<IReplyChannel>(listenUri);
            channelListener.Open();

            IReplyChannel replyChannel = channelListener.AcceptChannel(TimeSpan.MaxValue);
            if(replyChannel!=null)
            {
                replyChannel.Open();
                Console.WriteLine("Start Listening");
                while (true)
                {
                    RequestContext requestContext = replyChannel.ReceiveRequest(TimeSpan.MaxValue);
                    if (requestContext != null)
                    {
                        Console.WriteLine(requestContext.RequestMessage);
                        requestContext.Reply(CreateReplyMessage(binding));
                    }
                }
            }
        }

        private static Message CreateReplyMessage(Binding binding)
        {
            Message message;
            string action = "http://www.chucklu.com/calculatorService/AddResponse";
            XNamespace xNamespace = "http://www.chucklu.com";
            XElement body =
                new XElement(new XElement(xNamespace + "AddResponse", new XElement(xNamespace + "AddResult", 3)));
            message = Message.CreateMessage(binding.MessageVersion, action, body);
            return message;
        }
    }
}
