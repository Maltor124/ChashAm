using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CHASH_AM_2_0
{
    class Bullet
    {
        public  Vector2     Position;
        private Vector2     Direction;
        public  Rectangle   CollisionBox;
        public  float       Angle;

        public Bullet(Vector2 position, Vector2 direction, double angle)
        {
            Position = position;
            Direction = 15f * direction;
            CollisionBox = new Rectangle((int)position.X, (int)position.Y, 16, 8);
            Angle = (float)angle;
        }

        public void Update()
        {
            Position += Direction;
            CollisionBox = new Rectangle((int)Position.X, (int)Position.Y, 16, 8);
        }
    }
}
