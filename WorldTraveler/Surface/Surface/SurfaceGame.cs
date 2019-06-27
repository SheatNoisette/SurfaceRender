using System;
using System.Collections.Generic;

namespace SurfaceSystem
{
    public class SurfaceGame
    {
        private readonly List<Object> gameObject = new List<Object>();

        /// <summary>
        /// Update game instances
        /// </summary>
        public virtual void Update()
        {
            for (int i = 0; i < gameObject.Count; i++)
                gameObject[i].Update();
        }
        /// <summary>
        /// Draw gameobjects
        /// </summary>
        public virtual void Draw()
        {

        }

        /// <summary>
        /// Add a gameobject to the gameObjectList
        /// </summary>
        /// <param name="gameObj">Game object.</param>
        public void AddObject(Object gameObj)
        {
            gameObject.Add(gameObj);
        }
    }
}
