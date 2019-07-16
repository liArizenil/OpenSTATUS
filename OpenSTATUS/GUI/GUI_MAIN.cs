using Newtonsoft.Json.Linq;
using OpenSTATUS.Class.Module;
using OpenSTATUS.Class.Types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenSTATUS
{
    public partial class GUI_MAIN : Form
    {
        public Class.Module.Discord discord;
        public List<Server> Servers = new List<Server>();
        public Query query;

        public string DiscordToken;
        public ulong DiscordCh;
        public int refreshRate;

        public GUI_MAIN()
        {
            InitializeComponent();
        }
        public async void Run()
        {
            try
            {
                discord = new Class.Module.Discord(this, DiscordToken);
                new Thread(new ThreadStart(discord.Run)).Start();
                label2.Text = "활성화 됨";
                label2.ForeColor = Color.Green;

                while (true)
                {
                    await Task.Delay(100);
                    if (discord.IsLoaded)
                    {
                        break;
                    }
                }
                query = new Query(this, refreshRate, Servers);
                query.Run();
            }
            catch(Exception e)
            {
                WriteLog(e.Message);
            }
        }
        private async void Btn_Start_Click(object sender, EventArgs e)
        {
            if (btn_Start.Text == "시작")
            {
                LoadSetting();
                Run();
                btn_Start.Text = "종료";
            }
            else
            {
                Environment.Exit(0);
            }
        }

        private void Btn_Setting_Click(object sender, EventArgs e)
        {
            GUI.GUI_SETTING gui = new GUI.GUI_SETTING();
            gui.ShowDialog();
        }
        private void LoadSetting()
        {
            try
            {
                JArray Discord = JArray.Parse(Properties.Settings.Default.Discord);
                DiscordToken = Discord[0].ToString();
                DiscordCh = Convert.ToUInt64(Discord[1]);
                refreshRate = Convert.ToInt32(Discord[2]);

                foreach (var Server in JArray.Parse(Properties.Settings.Default.ServerList))
                {
                    JArray Row = JArray.Parse(Server.ToString());
                    Server server = new Server(Row[0].ToString(), Convert.ToUInt16(Row[1]), Row[2].ToString());
                    Servers.Add(server);
                }
            }
            catch (Exception e)
            {
                WriteLog("설정을 불러오지 못했습니다 : " + e);
            }
        }
        public void ShowMessageBox(string msg)
        {
            MessageBox.Show(msg);
        }

        public void WriteLog(string log)
        {
            log = "[ " + DateTime.Now.ToString() + " ] " + log;
            WriteTextBox(log);
            Console.WriteLine(log);
        }
        private void WriteTextBox(string log)
        {
            if (Log.InvokeRequired)
            {
                Invoke(new MethodInvoker(delegate ()
                {
                    if (Log.Text == "")
                    {
                        Log.Text = log;
                    }
                    else
                    {
                        Log.Text = Log.Text + "\r\n" + log;
                    }
                    Log.Select(Log.Text.Length, 0);
                    Log.ScrollToCaret();
                }));
            }
            else
            {
                if (Log.Text == "")
                {
                    Log.Text = log;
                }
                else
                {
                    Log.Text = Log.Text + "\r\n" + log;
                }
                Log.Select(Log.Text.Length, 0);
                Log.ScrollToCaret();
            }
        }
    }
}
