using FileTransfer.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace FileTransfer.Core
{
    public class Client : SaCBase
    {
        Socket client;

        public async override void Connect(string ip, int port)
        {
            await Task.Run(() =>
            {
                client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint iep = new IPEndPoint(IPAddress.Parse(ip), port);
                client.Connect(iep);
                Notify("连接成功");
            });
        }

        public override void ReceiveFile()
        {
            byte[] temp = new byte[BufferSize];
            int pos = 0;
            int readCount = client.Receive(temp);

            var fileData = SerializerHelper<FileData>.ToObjecy(temp.Take(readCount).ToArray());

            using (FileStream fs = new FileStream(fileData.Name, FileMode.Create, FileAccess.Write))
            {
                while (pos < fileData.Size)
                {
                    readCount = client.Receive(temp, 0, BufferSize, SocketFlags.None);
                    fs.Write(temp, 0, readCount);
                    pos += readCount;
                }
            }
            Notify("接收完成");
        }




        public override void SendFile(string fileName)
        {
            if (File.Exists(fileName))
            {
                using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
                {
                    FileData fileData = new FileData();
                    fileData.Name = Path.GetFileName(fileName);
                    fileData.Size = fs.Length;

                    client.Send(SerializerHelper<FileData>.ToBinary(fileData));  // 发送文件信息
                    int pos = 0;    // 当前文件流的位置
                    byte[] temp = new byte[BufferSize];
                    int readCount = 0;

                    while (pos < fs.Length)
                    {
                        readCount = fs.Read(temp, 0, BufferSize);
                        client.Send(temp, 0, readCount, SocketFlags.None);
                        pos += readCount;
                    }
                }
            }

            Notify("发送完成");
        }
    }
}
