using Grafica;
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

            using (Game game = new Game())
            {
                game.Run(60.0); // Ejecutar el bucle del juego con una tasa de actualización de 60 FPS
            }
        }
    }
}

