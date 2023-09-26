using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
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
        public static DbModel _context = new DbModel();

        [Obsolete]
        static void Main(string[] args)
        {
            botClient = new TelegramBotClient(token);
            botClient.StartReceiving();
            botClient.OnMessage += OnMessageHandler;
            Console.ReadLine();
            botClient.StopReceiving();
        }

        /// <summary>
        /// Ответ пользователю сообщением из телеграм
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        [Obsolete]
        internal static void OnMessageHandler(object sender, MessageEventArgs e)
        {
            var msg = e.Message;
            if (msg.Text != null)
            {
                var historyMsgSave = new HistoryMsg()
                {
                    msg = msg.Text,
                    username = msg.From.Username,
                    time_msg = DateTime.Now.TimeOfDay
                };
                _context.HistoryMsgs.Add(historyMsgSave);   
                _context.SaveChanges();
            }
        }
    }
}
