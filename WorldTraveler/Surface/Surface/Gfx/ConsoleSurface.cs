using System;

namespace SurfaceSystem
{
    public class ConsoleSurface : Surface
    {
        public ConsoleSurface(int width, int height): base(width, height){}

        /// <summary>
        /// Draw in the console
        /// </summary>
        /// @TODO: Faster implementation
        /// @TODO: Colors
        public override void Draw()
        {
            for (int y = 0; y < Width; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write(ASCIISurface[x, y]);
                }
            }
        }
    }
}
