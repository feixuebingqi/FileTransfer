using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTransfer.Core
{
    [Serializable]
    public class FileData
    {
        public string Name { get; set; }

        public long Size { get; set; }

        public string Path { get; set; }
    }
}
