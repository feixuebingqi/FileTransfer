using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTransfer
{
    [Serializable]
    public class CommandId
    {
        /// <summary>
        /// 操作：
        ///     1、
        /// </summary>
        public int Operation { get; set; }

        /// <summary>
        /// 请求的类型：
        ///     1、发送信息
        ///     2、发送文件
        /// </summary>
        public int RequestType { get; set; }


        /// <summary>
        /// 功能：
        ///     1、
        /// </summary>
        public int FunctionId { get; set; }


        public object Objects { get; set; }
    }
}
