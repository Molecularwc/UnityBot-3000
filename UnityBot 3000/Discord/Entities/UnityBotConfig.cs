using Discord.WebSocket;

namespace UnityBot_3000.Discord.Entities
{
    public class UnityBotConfig
    {
        public string Token { get; set; }
        public DiscordSocketConfig SocketConfig { get; set; }
    }
}
