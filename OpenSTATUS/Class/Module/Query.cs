using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OpenSTATUS; 
using Newtonsoft.Json.Linq;
using QueryMaster.GameServer;
using Discord;

namespace OpenSTATUS.Class.Module
{
    public class Query
    {
        private GUI_MAIN _Core;
        private List<Types.Server> servers;
        private int Delay;

        public Query(GUI_MAIN _Core, int Delay, List<Types.Server> servers)
        {
            this._Core = _Core;
            this.Delay = Delay;
            this.servers = servers;
        }

        public async void Run()
        {
            try
            {
                int TotalPlayer = 0;
                _Core.discord.DeleteMessage(10);
                for (int i = 0; i < servers.Count; i++)
                {
                    servers[i] = GetServerStats(servers[i]);
                    TotalPlayer += servers[i].Players.Count;
                    servers[i].LastMessage = await _Core.discord.SendEmbedAsync(GetEmbed(servers[i]));
                    await Task.Delay(300);
                }
                _Core.discord.SetGameAsync(TotalPlayer);

                while (true)
                {
                    await Task.Delay(Delay * 1000);
                    TotalPlayer = 0;
                    for (int i = 0; i < servers.Count; i++)
                    {
                        servers[i] = GetServerStats(servers[i]);
                        TotalPlayer += servers[i].Players.Count;
                        if (0 < DateTime.UtcNow.CompareTo(servers[i].LastMessage.Timestamp.AddSeconds(60).DateTime))
                        {
                            await servers[i].LastMessage.DeleteAsync();
                            servers[i].LastMessage = await _Core.discord.SendEmbedAsync(GetEmbed(servers[i]));
                        }
                        else
                        {
                            _Core.discord.EditEmbedAsync(GetEmbed(servers[i]), servers[i].LastMessage);
                        }
                        
                        await Task.Delay(300);
                    }
                    _Core.discord.SetGameAsync(TotalPlayer);
                }
            }
            catch (Exception e)
            {
                _Core.WriteLog("오류가 발생 했습니다 : " + e);
            }
        }

        private EmbedBuilder GetEmbed(Types.Server server)
        {
            if (server.Ping > 0)
            {
                string PlayerList = "";
                if (server.Players.Count == 0)
                {
                    PlayerList = "접속중인 플레이어가 없습니다.";
                }
                else
                {
                    foreach (string Player in server.Players)
                    {
                        PlayerList += Player + "\n";
                    }
                }
                EmbedBuilder SvstsEmbed = new EmbedBuilder()
                    .WithColor(Color.Green)
                    .WithThumbnailUrl(server.ImgURL)
                    .WithTitle("Server Status")
                    .WithDescription($"{server.ServerName}")
                    .AddField("Ping", $"{server.Ping} ms")
                    .AddField("온라인", $"{server.Players.Count} 명 온라인")
                    .AddField("플레이어", $"{PlayerList}")
                    .WithFooter(DateTime.Now.ToString("yyyy/MM/dd H:mm:ss") + " 기준");
                return SvstsEmbed;
            }
            else
            {
                return ConnectionFail(server.ImgURL);
            }
        }

        private EmbedBuilder ConnectionFail(string ImgURL)
        {
            return new EmbedBuilder()
                          .WithColor(Color.Red)
                          .WithThumbnailUrl(ImgURL)
                          .WithTitle("Server Status")
                          .WithDescription("Unable to Connect to the Server")
                          .WithFooter(DateTime.Now.ToString("yyyy/MM/dd H:mm:ss") + " 기준");
        }

        private Types.Server GetServerStats(Types.Server server)
        {
            try
            {
                server.Players = new List<string>();
                using (var Connect = ServerQuery.GetServerInstance((QueryMaster.Game)107410, server.IP, server.Port, throwExceptions: false, retries: 0, sendTimeout: 4000, receiveTimeout: 4000))
                {
                    var Connection = Connect.GetInfo();
                    if (Connection == null)
                    {
                        server.Ping = -1;
                        return server;
                    }
                    else
                    {
                        var INFO = JObject.FromObject(Connection);
                        server.ServerName = (string)INFO["Name"];
                        server.Ping = (int)INFO["Ping"];
                        var Players = Connect.GetPlayers();
                        foreach (var Player in Players)
                        {
                            var ply = JObject.FromObject(Player);
                            server.Players.Add((string)ply["Name"]);
                        }
                        return server;
                    }
                }
            }
            catch
            {
                server.Ping = -1;
                return server;
            }
        }
    }
}
