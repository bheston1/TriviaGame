using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaGame
{
    internal class Game
    {
        internal static void Start()
        {
            Console.WriteLine("                     ▄▄              ▄▄                                                          \r\n███▀▀██▀▀███         ██              ██               ▄▄█▀▀▀█▄█                                  \r\n█▀   ██   ▀█                                        ▄██▀     ▀█                                  \r\n     ██    ▀███▄███▀███ ▀██▀   ▀██▀▀███  ▄█▀██▄     ██▀       ▀ ▄█▀██▄ ▀████████▄█████▄   ▄▄█▀██ \r\n     ██      ██▀ ▀▀  ██   ██   ▄█    ██ ██   ██     ██         ██   ██   ██    ██    ██  ▄█▀   ██\r\n     ██      ██      ██    ██ ▄█     ██  ▄█████     ██▄    ▀████▄█████   ██    ██    ██  ██▀▀▀▀▀▀\r\n     ██      ██      ██     ███      ██ ██   ██     ▀██▄     ████   ██   ██    ██    ██  ██▄    ▄\r\n   ▄████▄  ▄████▄  ▄████▄    █     ▄████▄████▀██▄     ▀▀███████▀████▀██▄████  ████  ████▄ ▀█████▀\r\n                                                                                                 \r\n                                                                                                 \r\n");


            Console.WriteLine("Press ENTER");
            HelperFunctions.PressEnter();
            MenuController.ShowMenu();
        }
    }
}
