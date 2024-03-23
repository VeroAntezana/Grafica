﻿using Grafica;
using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafica
{
    internal class Program
    {
        static void Main(string[] args)
        {

            GameWindow window = new GameWindow(800, 600);
            Game game = new Game(window);
            window.Run();
        }
    }
}

