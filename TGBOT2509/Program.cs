// 5674519998:AAGN7RUvAV5X1cd9FWPNNmCIFO96wxtygag"

using System;
using Microsoft.VisualBasic;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types;
using Telegram.Bot.Types.InlineQueryResults;

namespace TGBOT2509
{
    class Program
    {
        private static string _token = "5674519998:AAGN7RUvAV5X1cd9FWPNNmCIFO96wxtygag";
        private static TelegramBotClient _client;

        static void Main(string[] args)
        {
            _client = new TelegramBotClient(_token); //инициализация бота
            _client.StartReceiving();
            _client.OnMessage += OnMessageHandler;
            Console.ReadLine();
            _client.StopReceiving();
        }

        private static async void OnMessageHandler(object sender, MessageEventArgs e)
        {
            var mes = e.Message;
          
                Console.WriteLine($"Группа: {mes.Text}");

                switch (mes.Text)
                {
                    case "601-01":
                    case "601-91":
                    case "602-11":
                    case "603-11":
                    case "603-22":
                    case "604-01":
                    case "604-91":
                    case "605-21":
                    case "606-21":
                    case "607-01":
                    case "607-21":
                    case "608-02":
                    case "608-21":
                    case "608-92":
                    case "609-12":
                    case "609-91":
                        await _client.SendPhotoAsync(
                            chatId: mes.Chat.Id,
                            photo: "https://ic.wampi.ru/2022/09/25/" + mes.Text + ".jpg");
                        break;

                    case "601-11":
                    case "602-21":
                    case "603-01":
                    case "603-12":
                    case "603-91":
                    case "604-11":
                    case "605-01":
                    case "605-91":
                    case "606-11":
                    case "606-22":
                    case "607-11":
                    case "607-22":
                    case "607-91":
                    case "608-11":
                    case "608-22":
                    case "609-01":
                    case "609-21":
                        await _client.SendPhotoAsync(
                            chatId: mes.Chat.Id,
                            photo: "https://ie.wampi.ru/2022/09/25/" + mes.Text + ".jpg");
                        break;

                    case "601-21":
                    case "602-01":
                    case "602-91":
                    case "603-02":
                    case "603-21":
                    case "603-92":
                    case "604-21":
                    case "605-11":
                    case "606-01":
                    case "606-12":
                    case "606-91":
                    case "607-12":
                    case "608-01":
                    case "608-12":
                    case "608-91":
                    case "609-11":
                    case "609-22":
                        await _client.SendPhotoAsync(
                            chatId: mes.Chat.Id,
                            photo: "https://im.wampi.ru/2022/09/25/" + mes.Text + ".jpg");
                        break;
                   
                    default:
                        await _client.SendTextMessageAsync(
                                chatId: mes.Chat.Id,
                                text: "Группа не найдена!");
                        break;
                }
            
        }
    }
}