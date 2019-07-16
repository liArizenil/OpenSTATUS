namespace OpenSTATUS.GUI
{
    partial class GUI_SETTING
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_discord = new System.Windows.Forms.TabPage();
            this.DiscordRefreshRate = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DiscordCHID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DiscordToken = new System.Windows.Forms.TextBox();
            this.tab_server = new System.Windows.Forms.TabPage();
            this.btn_Server = new System.Windows.Forms.Button();
            this.inputURL = new System.Windows.Forms.TextBox();
            this.inputPort = new System.Windows.Forms.TextBox();
            this.inputIP = new System.Windows.Forms.TextBox();
            this.ServerList = new System.Windows.Forms.ListView();
            this.IP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Port = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ImageURL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.tabControl1.SuspendLayout();
            this.tab_discord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiscordRefreshRate)).BeginInit();
            this.tab_server.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_discord);
            this.tabControl1.Controls.Add(this.tab_server);
            this.tabControl1.Location = new System.Drawing.Point(0, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(468, 364);
            this.tabControl1.TabIndex = 0;
            // 
            // tab_discord
            // 
            this.tab_discord.Controls.Add(this.linkLabel1);
            this.tab_discord.Controls.Add(this.DiscordRefreshRate);
            this.tab_discord.Controls.Add(this.label4);
            this.tab_discord.Controls.Add(this.label3);
            this.tab_discord.Controls.Add(this.label2);
            this.tab_discord.Controls.Add(this.DiscordCHID);
            this.tab_discord.Controls.Add(this.label1);
            this.tab_discord.Controls.Add(this.DiscordToken);
            this.tab_discord.Location = new System.Drawing.Point(4, 25);
            this.tab_discord.Name = "tab_discord";
            this.tab_discord.Padding = new System.Windows.Forms.Padding(3);
            this.tab_discord.Size = new System.Drawing.Size(460, 335);
            this.tab_discord.TabIndex = 0;
            this.tab_discord.Text = "Discord";
            this.tab_discord.UseVisualStyleBackColor = true;
            // 
            // DiscordRefreshRate
            // 
            this.DiscordRefreshRate.Location = new System.Drawing.Point(118, 78);
            this.DiscordRefreshRate.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.DiscordRefreshRate.Name = "DiscordRefreshRate";
            this.DiscordRefreshRate.Size = new System.Drawing.Size(63, 25);
            this.DiscordRefreshRate.TabIndex = 7;
            this.DiscordRefreshRate.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(182, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "초";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "새로고침 간격";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "채널 ID";
            // 
            // DiscordCHID
            // 
            this.DiscordCHID.Location = new System.Drawing.Point(90, 46);
            this.DiscordCHID.Name = "DiscordCHID";
            this.DiscordCHID.Size = new System.Drawing.Size(362, 25);
            this.DiscordCHID.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Token";
            // 
            // DiscordToken
            // 
            this.DiscordToken.Location = new System.Drawing.Point(90, 15);
            this.DiscordToken.Name = "DiscordToken";
            this.DiscordToken.Size = new System.Drawing.Size(362, 25);
            this.DiscordToken.TabIndex = 0;
            // 
            // tab_server
            // 
            this.tab_server.Controls.Add(this.btn_Server);
            this.tab_server.Controls.Add(this.inputURL);
            this.tab_server.Controls.Add(this.inputPort);
            this.tab_server.Controls.Add(this.inputIP);
            this.tab_server.Controls.Add(this.ServerList);
            this.tab_server.Location = new System.Drawing.Point(4, 25);
            this.tab_server.Name = "tab_server";
            this.tab_server.Padding = new System.Windows.Forms.Padding(3);
            this.tab_server.Size = new System.Drawing.Size(460, 335);
            this.tab_server.TabIndex = 1;
            this.tab_server.Text = "Server";
            this.tab_server.UseVisualStyleBackColor = true;
            // 
            // btn_Server
            // 
            this.btn_Server.Location = new System.Drawing.Point(368, 305);
            this.btn_Server.Name = "btn_Server";
            this.btn_Server.Size = new System.Drawing.Size(92, 26);
            this.btn_Server.TabIndex = 4;
            this.btn_Server.Text = "추가";
            this.btn_Server.UseVisualStyleBackColor = true;
            this.btn_Server.Click += new System.EventHandler(this.Btn_Server_Click);
            // 
            // inputURL
            // 
            this.inputURL.Location = new System.Drawing.Point(200, 305);
            this.inputURL.Name = "inputURL";
            this.inputURL.Size = new System.Drawing.Size(169, 25);
            this.inputURL.TabIndex = 3;
            // 
            // inputPort
            // 
            this.inputPort.Location = new System.Drawing.Point(121, 305);
            this.inputPort.MaxLength = 5;
            this.inputPort.Name = "inputPort";
            this.inputPort.Size = new System.Drawing.Size(80, 25);
            this.inputPort.TabIndex = 2;
            // 
            // inputIP
            // 
            this.inputIP.Location = new System.Drawing.Point(1, 305);
            this.inputIP.Name = "inputIP";
            this.inputIP.Size = new System.Drawing.Size(121, 25);
            this.inputIP.TabIndex = 1;
            // 
            // ServerList
            // 
            this.ServerList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IP,
            this.Port,
            this.ImageURL});
            this.ServerList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ServerList.LabelEdit = true;
            this.ServerList.Location = new System.Drawing.Point(0, 0);
            this.ServerList.Name = "ServerList";
            this.ServerList.Size = new System.Drawing.Size(459, 307);
            this.ServerList.TabIndex = 0;
            this.ServerList.UseCompatibleStateImageBehavior = false;
            this.ServerList.View = System.Windows.Forms.View.Details;
            this.ServerList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ServerList_MouseClick);
            // 
            // IP
            // 
            this.IP.Text = "IP";
            this.IP.Width = 121;
            // 
            // Port
            // 
            this.Port.Text = "Port";
            this.Port.Width = 78;
            // 
            // ImageURL
            // 
            this.ImageURL.Text = "ImageURL";
            this.ImageURL.Width = 200;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(107, 359);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(124, 40);
            this.btn_Save.TabIndex = 1;
            this.btn_Save.Text = "저장";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(237, 359);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(124, 40);
            this.btn_Close.TabIndex = 2;
            this.btn_Close.Text = "닫기";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(336, 304);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(104, 15);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Author : Arizen";
            this.linkLabel1.Click += new System.EventHandler(this.LinkLabel1_Click);
            // 
            // GUI_SETTING
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 404);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "GUI_SETTING";
            this.Text = "GUI_SETTING";
            this.tabControl1.ResumeLayout(false);
            this.tab_discord.ResumeLayout(false);
            this.tab_discord.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiscordRefreshRate)).EndInit();
            this.tab_server.ResumeLayout(false);
            this.tab_server.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_discord;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DiscordCHID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DiscordToken;
        private System.Windows.Forms.TabPage tab_server;
        private System.Windows.Forms.Button btn_Server;
        private System.Windows.Forms.TextBox inputURL;
        private System.Windows.Forms.TextBox inputPort;
        private System.Windows.Forms.TextBox inputIP;
        private System.Windows.Forms.ListView ServerList;
        private System.Windows.Forms.ColumnHeader IP;
        private System.Windows.Forms.ColumnHeader Port;
        private System.Windows.Forms.ColumnHeader ImageURL;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.NumericUpDown DiscordRefreshRate;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}