using System;
using System.Threading.Tasks;
using UnityBot3000.Discord;
using UnityBot3000.Discord.Entities;
using UnityBot3000.Storage;

namespace UnityBot3000
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
