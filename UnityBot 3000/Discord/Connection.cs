using System.Threading.Tasks;
using Discord;
using Discord.WebSocket;
using UnityBot_3000.Discord.Entities;

namespace UnityBot_3000.Discord
{
    public class Connection
    {
        private DiscordSocketClient _client;
        private DiscordLogger _logger;

        public Connection(DiscordLogger logger)
        {
            _logger = logger;
        }

        internal async Task ConnectAsync(UnityBotConfig config)
        {
            _client = new DiscordSocketClient(config.SocketConfig);

            _client.Log += _logger.Log;

            //TODO: Continue
        }
    }
}
