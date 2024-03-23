using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Graphics.OpenGL;
using System.Drawing;


namespace Grafica
{
    class Game
    {
        public GameWindow windows;
        private Tele tele;
        private float rotationAngle = 0.0f;

        public Game(GameWindow windowsInput)
        {
           this.windows = windowsInput;
           tele = new Tele();


            windows.Load += Windows_Load;
            windows.RenderFrame += Windows_RenderFrame;
            windows.UpdateFrame += Windows_UpdateFrame;
            windows.Closing += Windows_Closing;
            windows.MouseDown += Windows_MouseDown;
        }

        private void Windows_MouseDown(object? sender, OpenTK.Input.MouseButtonEventArgs e)
        {
            
        }

        private void Windows_Load(object? sender, EventArgs e)
        {
            GL.ClearColor(Color.FromArgb(135, 206, 235));
            GL.Enable(EnableCap.DepthTest); // Habilita el test de profundidad para objetos 3D
        }
        private void Windows_Closing(object? sender, System.ComponentModel.CancelEventArgs e)
        {
            
        }

        private void Windows_UpdateFrame(object? sender, FrameEventArgs e)
        {
            rotationAngle += 0.5f * (float)e.Time; // Ajusta la velocidad de rotación según sea necesario
            if (rotationAngle >= 360.0f)
                rotationAngle -= 360.0f;
        }

        private void Windows_RenderFrame(object? sender, FrameEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Frustum(-1.0, 1.0, -1.0, 1.0, 1.0, 100.0); // Configura la proyección perspectiva
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();


            // Posiciona y orienta la cámara
            GL.Translate(0.0f, 0.0f, -15.0f); // Mueve la cámara hacia atrás
            GL.Rotate(20.0f, 1.0f, 0.0f, 0.0f); // Inclina la vista hacia abajo
            GL.Rotate(40.0f, 0.0f, 1.0f, 0.0f); // Rota la vista hacia un ángulo lateral
            tele.Draw();
            windows.SwapBuffers();

           
            

        }

      
    }
}

