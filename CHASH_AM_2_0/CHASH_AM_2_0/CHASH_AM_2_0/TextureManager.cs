using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace CHASH_AM_2_0
{
    class TextureManager
    {
        private Dictionary<string, Texture2D>     Textures;
        private ContentManager      Content;

        public Texture2D this[string value]
        {
            get 
            {
                if (Textures.ContainsKey(value)) return Textures[value];
                else
                {
                    Console.WriteLine("Unable to find the texture, attempting to load it...");
                    Textures[value] = Content.Load<Texture2D>("Graphics/" + value);
                    return Textures[value];
                }
            }
            private set;
        }

        public TextureManager(ContentManager content)
        {
            Textures = new Dictionary<string, Texture2D>();
            Content = content;
        }
    }
}
