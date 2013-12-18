using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CHASH_AM_2_0
{
    public class Player : Actor
    {
        public List<Bullet> Bullets;
        public int          Points = 0;
        public int          Lives = 4;
        public int          Bombs = 4;

        public Player(Vector2 position, Texture2D texture) : base(position, texture) { }

        public override void Update()
        {
            for (int i = Bullets.Count - 1; i >= 0; i--)
            {
                
            }
        }

        public void Hit()
        {
            Lives--;
            // BOMB
            // RESET PLAYER POSITION
            //Position = new Vector2();
        }
    }
}
