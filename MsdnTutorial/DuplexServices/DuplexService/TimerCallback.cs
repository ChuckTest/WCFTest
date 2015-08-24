using System;
using System.Timers;
using DuplexServiceContract;

namespace DuplexService
{
    class TimerCallback
    {
        private TimerCallback()
        { }

        private static readonly TimerCallback instance = new TimerCallback();

        public static TimerCallback Instance
        {
            get { return instance; }
        }
        private static readonly Random random = new Random();

        private double number;
        private ICalculatorDuplexCallback callback;

        public void CreateTimer(double interval, ICalculatorDuplexCallback tempCallback)
        {
            callback = tempCallback;
            Timer timer = new Timer { Interval = interval };
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            int r = random.Next(1, 10);
            number += r;
            callback.Equals(number);
        }
    }

}
