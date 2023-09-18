using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaGame
{
    internal class HelperFunctions
    {
        internal static void TitleScreen()
        {
            Console.WriteLine("                     ▄▄              ▄▄                                                          \r\n███▀▀██▀▀███         ██              ██               ▄▄█▀▀▀█▄█                                  \r\n█▀   ██   ▀█                                        ▄██▀     ▀█                                  \r\n     ██    ▀███▄███▀███ ▀██▀   ▀██▀▀███  ▄█▀██▄     ██▀       ▀ ▄█▀██▄ ▀████████▄█████▄   ▄▄█▀██ \r\n     ██      ██▀ ▀▀  ██   ██   ▄█    ██ ██   ██     ██         ██   ██   ██    ██    ██  ▄█▀   ██\r\n     ██      ██      ██    ██ ▄█     ██  ▄█████     ██▄    ▀████▄█████   ██    ██    ██  ██▀▀▀▀▀▀\r\n     ██      ██      ██     ███      ██ ██   ██     ▀██▄     ████   ██   ██    ██    ██  ██▄    ▄\r\n   ▄████▄  ▄████▄  ▄████▄    █     ▄████▄████▀██▄     ▀▀███████▀████▀██▄████  ████  ████▄ ▀█████▀\r\n                                                                                                 \r\n                                                                                                 \r\n");


            Console.WriteLine("Press ENTER");
            PressEnter();
            MenuController.ShowMenu();
        }

        private static void PressEnter()
        {
            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey(true);
            } while (key.Key != ConsoleKey.Enter);
        }
    }
}
