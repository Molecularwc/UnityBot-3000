using System;
using UnityBot_3000.Discord;
using UnityBot_3000.Discord.Entities;

namespace UnityBot_3000
{
    internal class Program
    {
        private static void Main()
        {
            Unity.RegisterTypes();
            Console.WriteLine("Hello, Discord!");

            var discordbotConfig = new UnityBotConfig
            {
                Token = "ABC",
                SocketConfig = SocketConfig.GetDefault()
            };
        }
    }
}
