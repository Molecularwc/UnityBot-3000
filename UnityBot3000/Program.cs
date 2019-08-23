using System;
using System.Threading.Tasks;
using UnityBot3K.Discord;
using UnityBot3K.Discord.Entities;
using UnityBot3K.Storage;

namespace UnityBot3K
{
    internal class Program
    {
        private static async Task Main()
        {
            Unity.RegisterTypes();
            Console.WriteLine("Hello, Discord!");

            var storage = Unity.Resolve<IDataStorage>();

            var connection = Unity.Resolve<Connection>();
            await connection.ConnectAsync(new UnityBotConfig
            {
                Token = storage.RestoreObject<string>("Config/BotToken")
            });
        }
    }
}
