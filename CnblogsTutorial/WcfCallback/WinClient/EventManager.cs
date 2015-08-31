using System;
using System.Collections.Generic;
using ServiceContracts;

namespace WinClient
{
    public class EventManager
    {
        private EventManager()
        {
        }

        private static readonly EventManager instance = new EventManager();

        public static EventManager Instance
        {
            get { return instance; }
        }

        public event EventHandler<DataArrivedEventArgs> DataArrived;

        public void OnDataArrived(DataArrivedEventArgs e)
        {
            var handler = DataArrived;
            if (handler != null)
            {
                handler(this, e);
            }
        }
    }

    public class DataArrivedEventArgs : EventArgs
    {
        public ReturnData ReturnData { get; set; }
    }
}
