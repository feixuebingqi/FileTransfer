using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTransfer.Core
{
    /// <summary>
    /// Server和Client的基类
    /// </summary>
    public abstract class SaCBase
    {
        public event Action<string> NotifyMsg;
        public event Action<int> NotifyProgress;

        public void Notify(string msg)
        {
            NotifyMsg?.Invoke(msg);
        }

        public void NotifyComplete(int value)
        {
            NotifyProgress?.Invoke(value);
        }


        public const int BufferSize = 1024 * 1024;

        public abstract void Connect(string ip, int port);

        public abstract void SendFile(string fileName);

        public abstract void ReceiveFile();

    }
}
