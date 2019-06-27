using System;

namespace SurfaceSystem
{
    public class Surface: ISurfaceable
    {
        protected char[,] ASCIISurface;
        protected int[,] SurfaceColor;

        public int Width;
        public int Height;

        /// <summary>
        /// Create a new surface
        /// </summary>
        /// <param name="width">Width.</param>
        /// <param name="height">Height.</param>
        public Surface(int width, int height)
        {
            Width = width;
            Height = height;

            ASCIISurface = new char[width, height];
            SurfaceColor = new int[width, height];

            Clear();
        }

        /// <summary>
        /// Draw the surface on screen
        /// </summary>
        public virtual void Draw()
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Clear the ASCII surface
        /// </summary>
        public void Clear()
        {
            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    ASCIISurface[x, y] = ' ';
                    SurfaceColor[x, y] = 0;
                }
            }
        }

        /// <summary>
        /// Add a char in ASCII table
        /// </summary>
        /// <param name="c">C.</param>
        /// <param name="color">Color.</param>
        /// <param name="PosX">Position x.</param>
        /// <param name="PosY">Position y.</param>
        public void DrawTo(char c, int PosX, int PosY, int color)
        {
            if (PosX < 0 || PosY < 0) return;
            if (PosX > Width || PosY > Height) return;

            ASCIISurface[PosX, PosY] = c;
            SurfaceColor[PosX, PosY] = color;
        }

        /// <summary>
        /// Gets the char at posx and posy.
        /// </summary>
        /// <returns>The <see cref="T:System.Char"/>.</returns>
        /// <param name="posx">Posx.</param>
        /// <param name="posy">Posy.</param>
        public char GetCharAt(int posx, int posy)
            => ASCIISurface[posx, posy];

        /// <summary>
        /// Gets the color at posx and posy.
        /// </summary>
        /// <returns>The <see cref="T:System.Int32"/>.</returns>
        /// <param name="posx">Posx.</param>
        /// <param name="posy">Posy.</param>
        public int GetColorAt(int posx, int posy)
            => SurfaceColor[posx, posy];

    }
}

interface ISurfaceable
{
    /// <summary>
    /// Update the surface on screen
    /// </summary>
    void Draw();

    /// <summary>
    /// Put a char in the ASCII surface
    /// </summary>
    /// <param name="c">C.</param>
    /// <param name="color">Color</param>
    /// <param name="PosX">Position x.</param>
    /// <param name="PosY">Position y.</param>
    void DrawTo(char c, int color, int PosX, int PosY);

    /// <summary>
    /// Clear the surface
    /// </summary>
    void Clear();

    /// <summary>
    /// Gets the char at posx and posy.
    /// </summary>
    /// <returns>The <see cref="T:System.Char"/>.</returns>
    /// <param name="posx">Posx.</param>
    /// <param name="posy">Posy.</param>
    char GetCharAt(int posx, int posy);

    /// <summary>
    /// Gets the color at posx and posy.
    /// </summary>
    /// <returns>The <see cref="T:System.Int32"/>.</returns>
    /// <param name="posx">Posx.</param>
    /// <param name="posy">Posy.</param>
    int GetColorAt(int posx, int posy);
}