using Discord;
using Discord.Net;
using Discord.WebSocket;
using System;
using System.Threading.Tasks;

namespace OpenSTATUS.Class.Module
{
    public class Discord
    {
        private GUI_MAIN _Core;
        private DiscordSocketClient _client;
        private string _token;

        public bool IsLoaded = false;

        public Discord(GUI_MAIN _Core, string token)
        {
            this._Core = _Core;
            _token = token;
        }
        public async void Run()
        {
            MainAsync().GetAwaiter().GetResult();
        }

        public async Task MainAsync()
        {
            _client = new DiscordSocketClient(new DiscordSocketConfig
            {
                LogLevel = LogSeverity.Info
            });

            _client.Log += Log;
            _client.Ready += async () => { IsLoaded = true; };

            try
            {
                await _client.LoginAsync(TokenType.Bot, _token);
                await _client.StartAsync();
            }
            catch (HttpException e)
            {
                _Core.WriteLog("연결을 할 수 없습니다 : " + e);
                _client.Dispose();
            }
            

            await Task.Delay(-1);
        }
        public async void SetGameAsync(int curply)
        {
            if (curply == -1)
            {
                await _client.SetGameAsync("| 연결되지 않음 |");
            }
            else
            {
                await _client.SetGameAsync("| " + curply + " 명 온라인 |");
            }
        }
        public async void DeleteMessage(int count)
        {
            try
            {
                var channel = _client.GetChannel(_Core.DiscordCh) as SocketTextChannel;
                var messages = await channel.GetMessagesAsync(count).FlattenAsync();

                await channel.DeleteMessagesAsync(messages);
            }
            catch (HttpException e)
            {
                _Core.WriteLog("메시지를 삭제할 권한이 없습니다 :" + e.Message);
            }
        }
        public async Task<IUserMessage> SendEmbedAsync(EmbedBuilder embed)
        {
            try
            {
                var channel = _client.GetChannel(_Core.DiscordCh) as SocketTextChannel;
                var message = await channel.SendMessageAsync("", false, embed.Build());
                return message;
            }
            catch(HttpException e)
            {
                _Core.WriteLog("권한이 없습니다 :" + e.Message);
                _Core.ShowMessageBox("권한이 없습니다" + e.Message);
                var channel = _client.GetChannel(_Core.DiscordCh) as SocketTextChannel;
                var message = await channel.SendMessageAsync("", false, embed.Build());
                return message;
            }
        }
        public async void EditEmbedAsync(EmbedBuilder embed, IUserMessage message)
        {
            try
            {
                await message.ModifyAsync(x => x.Embed = embed.Build());
            }
            catch (HttpException e)
            {
                _Core.WriteLog("메시지를 찾을 수 없습니다 :" + e);
            }
        }
        private Task Log(LogMessage msg)
        {
            _Core.WriteLog(msg.ToString());
            return Task.CompletedTask;
        }
    }
}
