using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Graphics.OpenGL;

namespace Grafica
{
    internal class Tele
    {
        public void Draw()
        {
            // Dibujar la televisión en 3D utilizando OpenGL
            GL.Begin(PrimitiveType.Quads);

            // Pantalla
            GL.Color3(1.0f, 1.0f, 1.0f); // Color blanco
            GL.Vertex3(-5, -3, 0);
            GL.Vertex3(5, -3, 0);
            GL.Vertex3(5, 3, 0);
            GL.Vertex3(-5, 3, 0);

            // Borde
            GL.Color3(0.5f, 0.5f, 0.5f); // Color gris claro
            GL.Vertex3(-6, -4, 0);
            GL.Vertex3(6, -4, 0);
            GL.Vertex3(6, 4, 0);
            GL.Vertex3(-6, 4, 0);

            GL.Vertex3(-6, -4, 0);
            GL.Vertex3(6, -4, 0);
            GL.Vertex3(6, -4, -1);
            GL.Vertex3(-6, -4, -1);

            GL.Vertex3(-6, 4, 0);
            GL.Vertex3(6, 4, 0);
            GL.Vertex3(6, 4, -1);
            GL.Vertex3(-6, 4, -1);

            GL.Vertex3(-6, -4, -1);
            GL.Vertex3(-6, 4, -1);
            GL.Vertex3(-6, 4, 0);
            GL.Vertex3(-6, -4, 0);

            GL.Vertex3(6, -4, -1);
            GL.Vertex3(6, 4, -1);
            GL.Vertex3(6, 4, 0);
            GL.Vertex3(6, -4, 0);

            // Plataforma
            GL.Color3(0.0f, 0.0f, 0.0f); // Color negro
            GL.Vertex3(-6, -4, 1); // Esquina inferior izquierda
            GL.Vertex3(6, -4, 1); // Esquina inferior derecha
            GL.Vertex3(6, -4, -6); // Esquina superior derecha
            GL.Vertex3(-6, -4, -2); // Esquina superior izquierda

            GL.End();
        }
    }
}