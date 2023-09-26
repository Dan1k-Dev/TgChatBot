<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
=======
﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
>>>>>>> master
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
<<<<<<< HEAD
=======
        public static DbModel _context = new DbModel();

        [Obsolete]
>>>>>>> master
        static void Main(string[] args)
        {
            botClient = new TelegramBotClient(token);
            botClient.StartReceiving();
            botClient.OnMessage += OnMessageHandler;
            Console.ReadLine();
            botClient.StopReceiving();
        }

<<<<<<< HEAD
        internal static async void OnMessageHandler(object sender, MessageEventArgs e)
=======
        /// <summary>
        /// Ответ пользователю сообщением из телеграм
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        [Obsolete]
        internal static void OnMessageHandler(object sender, MessageEventArgs e)
>>>>>>> master
        {
            var msg = e.Message;
            if (msg.Text != null)
            {
<<<<<<< HEAD
                await botClient.SendTextMessageAsync(msg.Chat.Id, $"{msg.From.Username}: {msg.Text}", replyToMessageId: msg.MessageId = 0);
=======
                var historyMsgSave = new HistoryMsg()
                {
                    msg = msg.Text,
                    username = msg.From.Username,
                    time_msg = DateTime.Now.TimeOfDay
                };
                _context.HistoryMsgs.Add(historyMsgSave);   
                _context.SaveChanges();
>>>>>>> master
            }
        }
    }
}
