using Discord;
using System.Collections.Generic;

namespace OpenSTATUS.Class.Types
{
    public class Server
    {
        public string IP;
        public ushort Port;
        public string ImgURL;
        public string ServerName;
        public int Ping;
        public List<string> Players;
        public IUserMessage LastMessage;

        public Server(string IP, ushort Port, string ImgURL)
        {
            this.IP = IP;
            this.Port = Port;
            this.ImgURL = ImgURL;
        }
    }
}
