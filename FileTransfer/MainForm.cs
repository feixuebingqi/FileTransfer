using FileTransfer.Common;
using FileTransfer.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileTransfer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        SaCBase sc;
        private string _fileName;

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void cbSelectModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSelectModel.Text == "客户端")
            {
                btnConnect.Text = "连接服务器";
            }
            else if(cbSelectModel.Text == "服务器")
            {
                btnConnect.Text = "启动监听";
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if(!string.IsNullOrEmpty(txtIp.Text) && !string.IsNullOrEmpty(txtPort.Text) && !string.IsNullOrEmpty(cbSelectModel.Text))
                {
                    string ip = txtIp.Text;
                    int port = int.Parse(txtPort.Text);

                    IPEndPoint iep = new IPEndPoint(IPAddress.Parse(ip), port);

                    if (cbSelectModel.Text == "客户端")
                    {
                        sc = new Client();
                        sc.NotifyMsg += Sc_NotifyMsg;
                        sc.NotifyProgress += Sc_NotifyProgress;
                        sc.Connect(ip, port);
                    }
                    else if (cbSelectModel.Text == "服务器")
                    {
                        sc = new Server();
                        sc.NotifyProgress += Sc_NotifyProgress;
                        sc.NotifyMsg += Sc_NotifyMsg;
                        sc.Connect(ip, port);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Sc_NotifyProgress(int obj)
        {
            pbPercent.Value = obj;
        }

        private void Sc_NotifyMsg(string obj)
        {
            lstInfo.SafeInvokeMsg(obj);
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Multiselect = false;

            if(of.ShowDialog() == DialogResult.OK)
            {
                var fileName = of.FileName;

                FileInfo file = new FileInfo(fileName);
                _fileName = fileName;
                Sc_NotifyMsg($"已选择{fileName}");
            }
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                try
                {
                    if (!string.IsNullOrEmpty(_fileName))
                    {
                        if (sc != null)
                        {
                            sc.SendFile(_fileName);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            });
            
        }

        private async void btnReceive_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                try
                {
                    sc.ReceiveFile();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            });
        }
    }
}
