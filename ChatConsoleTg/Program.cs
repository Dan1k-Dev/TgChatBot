using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Args;

namespace ChatConsoleTg
{
    internal class Program
    {
        readonly private static string token = "6549211492:AAFtGp6j36GGBi6-0KzI2y-n-9lPWJ6yQTc";
        private static TelegramBotClient botClient;
        static void Main(string[] args)
        {
            botClient = new TelegramBotClient(token);
            botClient.StartReceiving();
            botClient.OnMessage += OnMessageHandler;
            Console.ReadLine();
            botClient.StopReceiving();
        }

        internal static async void OnMessageHandler(object sender, MessageEventArgs e)
        {
            var msg = e.Message;
            if (msg.Text != null)
            {
                await botClient.SendTextMessageAsync(msg.Chat.Id, $"{msg.From.Username}: {msg.Text}", replyToMessageId: msg.MessageId = 0);
            }
        }
    }
}
