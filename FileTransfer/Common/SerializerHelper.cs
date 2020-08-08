using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace FileTransfer.Common
{
    public class SerializerHelper<T>
    {
        public static byte[] ToBinary(T t)
        {
            MemoryStream ms = new MemoryStream();
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(ms, t);
            byte[] data = ms.ToArray();
            ms.Close();
            return data;
        }


        public static T ToObjecy(byte[] data)
        {
            MemoryStream ms = new MemoryStream();
            ms.Write(data, 0, data.Length);
            ms.Position = 0;
            BinaryFormatter bf = new BinaryFormatter();
            T t = (T)bf.Deserialize(ms);
            ms.Close();
            return t;
        }
    }
}
