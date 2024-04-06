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
        private float originX, originY, originZ;

        public Tele(float originX, float originY, float originZ)
        {
            this.originX = originX;
            this.originY = originY;
            this.originZ = originZ;
        }

        public void Draw(float rotationAngle)
        {
            GL.PushMatrix(); // Guarda la matriz actual de OpenGL
            GL.Translate(originX, originY, originZ); // Traslada al punto de origen
            GL.Rotate(rotationAngle, 0.0f, 1.0f, 0.0f); // Rota la televisión en el eje Y
            GL.Begin(PrimitiveType.Quads);

            // Pantalla
            GL.Color3(1.0f, 1.0f, 1.0f); // Color blanco
            GL.Vertex3(originX - 5, originY - 3, originZ);
            GL.Vertex3(originX + 5, originY - 3, originZ);
            GL.Vertex3(originX + 5, originY + 3, originZ);
            GL.Vertex3(originX - 5, originY + 3, originZ);

            // Borde
            GL.Color3(0.5f, 0.5f, 0.5f); // Color gris claro
            // Borde izquierdo
            GL.Vertex3(originX - 6, originY - 4, originZ);
            GL.Vertex3(originX - 5, originY - 4, originZ);
            GL.Vertex3(originX - 5, originY + 4, originZ);
            GL.Vertex3(originX - 6, originY + 4, originZ);
            // Borde derecho
            GL.Vertex3(originX + 5, originY - 4, originZ);
            GL.Vertex3(originX + 6, originY - 4, originZ);
            GL.Vertex3(originX + 6, originY + 4, originZ);
            GL.Vertex3(originX + 5, originY + 4, originZ);
            // Borde superior
            GL.Vertex3(originX - 6, originY + 4, originZ);
            GL.Vertex3(originX + 6, originY + 4, originZ);
            GL.Vertex3(originX + 6, originY + 3, originZ);
            GL.Vertex3(originX - 6, originY + 3, originZ);
            // Borde inferior
            GL.Vertex3(originX - 6, originY - 4, originZ);
            GL.Vertex3(originX + 6, originY - 4, originZ);
            GL.Vertex3(originX + 6, originY - 3, originZ);
            GL.Vertex3(originX - 6, originY - 3, originZ);

            // Plataforma
            GL.Color3(0.0f, 0.0f, 0.0f); // Color negro
            GL.Vertex3(originX - 5, originY - 4, originZ + 1); // Esquina inferior izquierda
            GL.Vertex3(originX + 5, originY - 4, originZ + 1); // Esquina inferior derecha
            GL.Vertex3(originX + 5, originY - 4, originZ - 2); // Esquina superior derecha
            GL.Vertex3(originX - 5, originY - 4, originZ - 2); // Esquina superior izquierda

            GL.End();
            GL.PopMatrix(); // Restaura la matriz de OpenGL
        }

        private void DrawQuadRelative(float x1, float y1, float x2, float y2, float z)
        {
            GL.Vertex3(x1, y1, z);
            GL.Vertex3(x2, y1, z);
            GL.Vertex3(x2, y2, z);
            GL.Vertex3(x1, y2, z);
        }
    
    }
}