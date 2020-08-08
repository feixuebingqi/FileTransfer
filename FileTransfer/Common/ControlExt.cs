using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileTransfer.Common
{
    public static class ControlExt
    {
        public static void SafeInvokeMsg(this ListBox listBox, string msg)
        {
            if (listBox.InvokeRequired)
            {
                listBox.Invoke(new Action(() =>
                {
                    if (listBox.Items.Count > 50)
                    {
                        listBox.Items.RemoveAt(listBox.Items.Count - 1);
                    }
                    listBox.Items.Insert(0, msg);
                }));
            }
            else
            {
                if (listBox.Items.Count > 50)
                {
                    listBox.Items.RemoveAt(listBox.Items.Count - 1);
                }
                listBox.Items.Insert(0, msg);
            }
        }
    }
}
