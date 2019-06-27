using System;
namespace SurfaceSystem
{
    public abstract class Object
    {
        protected readonly int x;
        protected readonly int y;

        /// <summary>
        /// Runned on the creation of the instance
        /// </summary>
        public abstract void OnCreate();

        /// <summary>
        /// Update object
        /// </summary>
        public abstract void Update();
    }
}
