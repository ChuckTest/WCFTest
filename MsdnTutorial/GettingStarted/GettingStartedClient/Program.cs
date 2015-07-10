using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GettingStartedClient.ServiceReference1;

namespace GettingStartedClient
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Step 1: Create an instance of the WCF proxy.
                CalculatorClient client = new CalculatorClient();

                // Step 2: Call the service operations.
                // Call the Add service operation.
                double value1 = 100.00D;
                double value2 = 15.99D;
                double result = client.Add(value1, value2);
                Console.WriteLine("Add({0},{1}) = {2}", value1, value2, result);

                // Call the Subtract service operation.
                value1 = 145.00D;
                value2 = 76.54D;
                result = client.Subtract(value1, value2);
                Console.WriteLine("Subtract({0},{1}) = {2}", value1, value2, result);

                // Call the Multiply service operation.
                value1 = 9.00D;
                value2 = 81.25D;
                result = client.Multiply(value1, value2);
                Console.WriteLine("Multiply({0},{1}) = {2}", value1, value2, result);

                // Call the Divide service operation.
                value1 = 22.00D;
                value2 = 7.00D;
                result = client.Divide(value1, value2);
                Console.WriteLine("Divide({0},{1}) = {2}", value1, value2, result);

                //Step 3: Closing the client gracefully closes the connection and cleans up resources.
                client.Close();
            }
            catch (Exception ex)
            {
                StringBuilder innerExceptionString = new StringBuilder();

                if (ex.InnerException != null)//内部异常存在
                {
                    innerExceptionString.Append(string.Format("错误信息:{0}\r\n异常类型:{1}\r\n程序集:{2}\r\n方法:{3}\r\n跟踪栈信息:\r\n{4}",
                        ex.InnerException.Message,//错误信息
                        ex.InnerException.GetType(),//异常类型
                        ex.InnerException.Source,//程序集
                        ex.InnerException.TargetSite,//方法
                        ex.InnerException.StackTrace));//跟踪堆栈信息
                }

                if (!string.IsNullOrEmpty(innerExceptionString.ToString()))//如果 innerExceptionString.ToString() 参数为 null 或空字符串 ("")，则为 true；否则为 false。
                {
                    Console.WriteLine(string.Format("错误信息:{0}{1}异常类型:{2}{1}内部异常{1}({1}{3}{1}){1}程序集:{4}{1}方法:{5}{1}跟踪栈信息:{1}{6}{1}",
                    ex.Message,
                    Environment.NewLine,
                    ex.GetType(),
                    innerExceptionString,
                    ex.Source,
                    ex.TargetSite,
                    ex.StackTrace));
                }
                else
                {
                    Console.WriteLine(string.Format("错误信息:{0}{1}异常类型:{2}{1}程序集:{3}{1}方法:{4}{1}跟踪栈信息:{1}{5}{1}",
                        ex.Message,
                        Environment.NewLine,
                        ex.GetType(),
                        ex.Source,
                        ex.TargetSite,
                        ex.StackTrace));//写入文件
                }
            }
            Console.ReadKey();
        }
    }
}
