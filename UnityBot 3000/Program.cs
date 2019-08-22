using System;
using System.Threading.Tasks;
using UnityBot_3000.Discord;
using UnityBot_3000.Discord.Entities;
using UnityBot_3000.Storage;

namespace UnityBot_3000
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
                Token = storage.RestoreObject<string>("BotToken")
            });
        }
    }
}
