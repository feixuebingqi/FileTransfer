namespace FileTransfer
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cbSelectModel = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.lstInfo = new System.Windows.Forms.ListBox();
            this.btnReceive = new System.Windows.Forms.Button();
            this.pbPercent = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "模式选择";
            // 
            // cbSelectModel
            // 
            this.cbSelectModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelectModel.FormattingEnabled = true;
            this.cbSelectModel.Items.AddRange(new object[] {
            "客户端",
            "服务器"});
            this.cbSelectModel.Location = new System.Drawing.Point(83, 30);
            this.cbSelectModel.Name = "cbSelectModel";
            this.cbSelectModel.Size = new System.Drawing.Size(132, 27);
            this.cbSelectModel.TabIndex = 1;
            this.cbSelectModel.SelectedIndexChanged += new System.EventHandler(this.cbSelectModel_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "IP地址";
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(83, 75);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(132, 25);
            this.txtIp.TabIndex = 3;
            this.txtIp.Text = "127.0.0.1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "端口号";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(83, 118);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(62, 25);
            this.txtPort.TabIndex = 5;
            this.txtPort.Text = "10000";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(100, 149);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(115, 33);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "连接";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(100, 199);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(115, 33);
            this.btnSelectFile.TabIndex = 8;
            this.btnSelectFile.Text = "选择文件";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(100, 238);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(115, 33);
            this.btnSend.TabIndex = 9;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lstInfo
            // 
            this.lstInfo.FormattingEnabled = true;
            this.lstInfo.ItemHeight = 19;
            this.lstInfo.Location = new System.Drawing.Point(234, 12);
            this.lstInfo.Name = "lstInfo";
            this.lstInfo.Size = new System.Drawing.Size(415, 308);
            this.lstInfo.TabIndex = 10;
            // 
            // btnReceive
            // 
            this.btnReceive.Location = new System.Drawing.Point(100, 277);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(115, 33);
            this.btnReceive.TabIndex = 11;
            this.btnReceive.Text = "接收";
            this.btnReceive.UseVisualStyleBackColor = true;
            this.btnReceive.Click += new System.EventHandler(this.btnReceive_Click);
            // 
            // pbPercent
            // 
            this.pbPercent.Location = new System.Drawing.Point(12, 334);
            this.pbPercent.Name = "pbPercent";
            this.pbPercent.Size = new System.Drawing.Size(637, 23);
            this.pbPercent.Step = 1;
            this.pbPercent.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(661, 363);
            this.Controls.Add(this.pbPercent);
            this.Controls.Add(this.btnReceive);
            this.Controls.Add(this.lstInfo);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbSelectModel);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "文件传输助手";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSelectModel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ListBox lstInfo;
        private System.Windows.Forms.Button btnReceive;
        private System.Windows.Forms.ProgressBar pbPercent;
    }
}