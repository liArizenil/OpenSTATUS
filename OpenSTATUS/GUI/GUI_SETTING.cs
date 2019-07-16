using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenSTATUS.GUI
{
    public partial class GUI_SETTING : Form
    {
        public GUI_SETTING()
        {
            InitializeComponent();
            LoadSetting();
        }

        public void LoadSetting()
        {
            try
            {
                JArray Discord = JArray.Parse(Properties.Settings.Default.Discord);
                DiscordToken.Text = Discord[0].ToString();
                DiscordCHID.Text = Discord[1].ToString();
                DiscordRefreshRate.Text = Discord[2].ToString();

                foreach (var Server in JArray.Parse(Properties.Settings.Default.ServerList))
                {
                    JArray Row = JArray.Parse(Server.ToString());
                    string[] ent = { Row[0].ToString(), Row[1].ToString(), Row[2].ToString()};
                    ServerList.Items.Add(new ListViewItem(ent));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            //Discord to Json
            string[] Discord = { DiscordToken.Text, DiscordCHID.Text, DiscordRefreshRate.Value.ToString() };
            Properties.Settings.Default.Discord = JsonConvert.SerializeObject(Discord);
            //ServerList to Json
            List<string> Serverlist = new List<string>();
            foreach (ListViewItem item in ServerList.Items)
            {
                string[] Array = { item.Text, item.SubItems[1].Text, item.SubItems[2].Text };
                Serverlist.Add(JsonConvert.SerializeObject(Array));
            }
            Properties.Settings.Default.ServerList = JsonConvert.SerializeObject(Serverlist.ToArray());

            Properties.Settings.Default.Save();
            MessageBox.Show("저장되었습니다");
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Server_Click(object sender, EventArgs e)
        {
            if ((ServerList.Items.Count + 1) > 10)
            {
                MessageBox.Show("10개 이상의 서버를 등록 하실 수 없습니다.");
                return;
            }
            foreach (ListViewItem checksum in ServerList.Items)
            {
                string Listitem = checksum.SubItems[0].Text + checksum.SubItems[1].Text;
                if (Listitem.Equals(inputIP.Text + inputPort.Text))
                {
                    MessageBox.Show("이미 존재하는 서버를 등록 하실 수 없습니다.");
                    return;
                }
            }
            string[] ent = { inputIP.Text, inputPort.Text, inputURL.Text };
            ServerList.Items.Add(new ListViewItem(ent));
            inputIP.Text = "";
            inputPort.Text = "";
            inputURL.Text = "";
        }

        private void ServerList_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ListViewItem Item = default(ListViewItem);
                {
                    ContextMenuStrip Menu = new ContextMenuStrip();
                    Menu.Items.Add("Delete", null, Delete);
                    Item = ServerList.GetItemAt(e.Location.X, e.Location.Y);
                    if ((Item != null))
                    {
                        Menu.Show(Cursor.Position);
                    }
                }
            }
        }
        private void Delete(object sender, EventArgs e)
        {
            ListViewItem item = ServerList.SelectedItems[0];
            ServerList.Items.Remove(item);
        }

        private void LinkLabel1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/liArizenil");
        }
    }
}
