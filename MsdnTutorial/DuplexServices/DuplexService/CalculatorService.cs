using System.Globalization;
using System.ServiceModel;
using System.Threading;
using DuplexServiceContract;

namespace DuplexService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
    public class CalculatorService : ICalculatorDuplex
    {
        private double result;
        private string equation;

        public CalculatorService()
        {
            equation = result.ToString(CultureInfo.CurrentCulture);
        }

        public void Clear()
        {
            Callback.Equation(equation + " = " + result);
            equation = result.ToString(CultureInfo.CurrentCulture);
        }

        /// <summary>
        /// 客户端在调用AddTo函数后
        /// 服务端启用一个计时器，定时回调客户端
        /// </summary>
        /// <param name="n"></param>
        public void AddTo(double n)
        {
            result += n;
            equation = string.Format("{0}+{1}", equation, n);
            //Callback.Equals(result);
            var callback = OperationContext.Current.GetCallbackChannel<ICalculatorDuplexCallback>();
            Thread thread = new Thread(CreateTimer) { IsBackground = true };
            thread.Start(callback);
        }

        private void CreateTimer(object obj)
        {
            var callback = obj as ICalculatorDuplexCallback;
            if (callback != null)
            {
                TimerCallback.Instance.CreateTimer(1000, callback);
            }
        }

        public void SubtractFrom(double n)
        {
            result -= n;
            equation += " - " + n;
            Callback.Equals(result);
        }

        public void MultiplyBy(double n)
        {
            result *= n;
            equation += " * " + n;
            Callback.Equals(result);
        }

        public void DivideBy(double n)
        {
            result /= n;
            equation += " / " + n;
            Callback.Equals(result);
        }

        private ICalculatorDuplexCallback Callback
        {
            get { return OperationContext.Current.GetCallbackChannel<ICalculatorDuplexCallback>(); }
        }
    }
}
