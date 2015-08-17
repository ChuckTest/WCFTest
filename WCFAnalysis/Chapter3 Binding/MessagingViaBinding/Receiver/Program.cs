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
            //创建信道监听器
            IChannelListener<IReplyChannel> channelListener = binding.BuildChannelListener<IReplyChannel>(listenUri);
            //打开信道监听器
            channelListener.Open();

            //创建回复信道
            IReplyChannel replyChannel = channelListener.AcceptChannel(TimeSpan.MaxValue);
            if(replyChannel!=null)
            {
                //打开回复信道
                replyChannel.Open();
                Console.WriteLine("Start Listening");
                //开始监听
                while (true)
                {
                    //接收请求消息
                    RequestContext requestContext = replyChannel.ReceiveRequest(TimeSpan.MaxValue);
                    if (requestContext != null)
                    {
                        //输出请求消息
                        Console.WriteLine(requestContext.RequestMessage);
                        //回复消息
                        requestContext.Reply(CreateReplyMessage(binding.MessageVersion));
                    }
                }
            }
        }

        private static Message CreateReplyMessage(MessageVersion messageVersion)
        {
            Message message;
            string action = "http://www.chucklu.com/calculatorService/AddResponse";
            XNamespace xNamespace = "http://www.chucklu.com";
            XElement body =
                new XElement(new XElement(xNamespace + "AddResponse", new XElement(xNamespace + "AddResult", 3)));
            message = Message.CreateMessage(messageVersion, action, body);
            return message;
        }
    }
}
