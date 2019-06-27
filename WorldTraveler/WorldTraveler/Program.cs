using System.Collections.Generic;
using SurfaceSystem;

namespace WorldTraveler
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<Surface> surfaces = new List<Surface>();


            Surface surface = new ConsoleSurface(9, 9);
            Surface surfaceTest = new ConsoleSurface(9, 9);

            surfaces.Add(surface);
            surfaces.Add(surfaceTest);

            SurfaceDrawing.DrawRectangle(surface, 'A', 1, 1, 5, 5, 1);
            SurfaceDrawing.DrawLine(surface, 'C', 0, 0, 9, 9, 1);

            SurfaceDrawing.DrawText(surface, "Hello!", 0, 0, 0);
            surface.Draw();



        }
    }
}
