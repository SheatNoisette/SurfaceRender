using System;
namespace SurfaceSystem
{
    public static class SurfaceDrawing
    {
        //Basic geometry on surface

        /// <summary>
        /// Draw a rectangle
        /// </summary>
        /// <param name="x1">The first x value.</param>
        /// <param name="y1">The first y value.</param>
        /// <param name="x2">The second x value.</param>
        /// <param name="y2">The second y value.</param>
        /// <param name="color">Color.</param>
        /// @TODO: Add filling style
        /// @TODO: Verify coordinates
        public static void DrawRectangle(Surface surface, char c, int x1, int y1, int x2, int y2, int color)
        {
            for (int y = y1; y < y2; y++)
            {
                for (int x = x1; x < x2; x++)
                {
                    surface.DrawTo(c, x, y, color);
                }
            }
        }

        /// <summary>
        /// Draw a square on a surface
        /// </summary>
        /// <param name="c">C.</param>
        /// <param name="x">The x coordinate.</param>
        /// <param name="y">The y coordinate.</param>
        /// <param name="size">Size.</param>
        /// <param name="color">Color.</param>
        public static void DrawSquare(Surface surface,char c, int x, int y, int size, int color)
        {
            DrawRectangle(surface, c, x, y, x + size, y + size, color);
        }

        /// <summary>
        /// Draw a line
        /// </summary>
        /// <param name="c">Char</param>
        /// <param name="x1">The first x value.</param>
        /// <param name="y1">The first y value.</param>
        /// <param name="x2">The second x value.</param>
        /// <param name="y2">The second y value.</param>
        /// <param name="color">Color.</param>
        public static void DrawLine(Surface surface, char c, int x1, int y1, int x2, int y2, int color)
        {

            int dx = Math.Abs(x2 - x1);
            int sx = x1 < x2 ? 1 : -1;
            int dy = Math.Abs(y2 - y1);
            int sy = y1 < y2 ? 1 : -1;

            int err = (dx > dy ? dx : -dy) / 2;
            int e2 = err;

            while (x1 != x2 || y1 != y2)
            {
                surface.DrawTo(c, x1, y1, color);
    
                e2 = err;

                //Error correction
                if (e2 > -dx)
                {
                    err -= dy;
                    x1 += sx;
                }
                if (e2 < dy)
                {
                    err += dx;
                    y1 += sy;
                }
            }

        }

        /// <summary>
        /// Write a text in the <paramref name="surface"/>
        /// </summary>
        /// <param name="surface">Surface.</param>
        /// <param name="posx">Posx.</param>
        /// <param name="posy">Posy.</param>
        /// <param name="color">Color.</param>
        
        public static void DrawText(Surface surface, string text, int posx, int posy, int color)
        {
            for (int i = 0; i < text.Length; i++)
                surface.DrawTo(text[i], posx + i, posy, color);
        }

        /// <summary>
        /// Merge two surfaces
        /// </summary>
        /// <returns>The merged surface</returns>
        /// <param name="background">Background.</param>
        /// <param name="foreground">Foreground.</param>
        public static Surface MergeSurfaces(Surface background, Surface foreground)
        {
            //Take the bigger surface of these two
            int surfaceWidth = background.Width > foreground.Width ? background.Width : foreground.Width; 
            int surfaceHeight = background.Height > foreground.Height ? background.Height : foreground.Height;

            //Create a new surface
            Surface finalsurface = new Surface(surfaceWidth, surfaceHeight);

            for (int y = 0; y < surfaceHeight; y++)
            {
                for (int x = 0; x < surfaceHeight; x++)
                {
                    finalsurface.DrawTo(background.GetCharAt(x, y), x, y, background.GetColorAt(x, y));
                    finalsurface.DrawTo(foreground.GetCharAt(x, y), x, y, foreground.GetColorAt(x, y));
                }
            }

            return finalsurface;
        }
    }
}
