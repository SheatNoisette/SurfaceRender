using System;

namespace SurfaceSystem
{
    public static class Keyboard
    {
        /// <summary>
        /// Get char input in console
        /// </summary>
        /// <returns>Char</returns>
        public static ConsoleKey GetInput()
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            return keyInfo.Key;
        }
    }
}
