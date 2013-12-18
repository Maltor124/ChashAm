using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CHASH_AM_2_0
{
    class Enemy : Actor
    {
        public int      Health;
        public Player   Target;

        public Enemy(Vector2 position, int health, ref Player target, Texture2D texture)
            : base(position, texture)
        {
            Health = health;
            Speed = 0.0117f * Health + 3.09f;
            Target = target;
        }

        public override void Update()
        {
            if (CollisionBox.Intersects(Target.CollisionBox)) Target.Hit();
            else
            {
                Angle = Math.Atan2(Target.Position.Y - this.Position.Y, Target.Position.X - this.Position.X);
                float cos = (float)Math.Cos(Angle), sin = (float)Math.Sin(Angle);
                Direction = Speed * new Vector2(cos, sin);
                Position += Direction;
                CollisionBox = new Rectangle((int)Position.X, (int)Position.Y, (int) (16f * cos * Math.Max(Health / 50f, 1f)), (int) (16f * sin * Math.Max(Health / 10f, 1f)));
            }
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Texture,
                Position,
                null,
                Color.Green,
                (float)Angle,
                new Vector2(8, 8),
                MathHelper.Clamp(Health / 10.0f, 1.0f, 2.0f),
                (Angle < MathHelper.PiOver2 && Angle > -MathHelper.PiOver2) ? SpriteEffects.None : SpriteEffects.FlipVertically,
                0);
        }
    }
}
