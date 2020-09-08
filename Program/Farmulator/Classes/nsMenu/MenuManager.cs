﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Farmulator.Classes.nsGame;
using Farmulator.Classes.nsPrinter;

namespace Farmulator.Classes.nsMenu
{
    static class MenuManager
    {
        private static Game game;
        public static void StartMenu()
        {
            Console.Clear();

            string titleGame = "░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\n" +
            "░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\n" +
            "░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░BIENVENIDO░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\n" ; 



            List<string> optionsStartMenu = new List<string>() { "New Game", "Load Game", "Options" };

            int optionSelect = Print.RenderMenu(optionsStartMenu, titleGame);

            switch (optionSelect)
            {
                case 1:
                    NewGameMenu();
                    break;
                case 2:
                    LoadGameMenu();
                    break;
                case 3:
                    OptionsMenu();
                    break;
            }
        }

        private static void NewGameMenu()
        {

        }

        private static void LoadGameMenu()
        {

        }

        private static void OptionsMenu()
        {

        }

    }
}