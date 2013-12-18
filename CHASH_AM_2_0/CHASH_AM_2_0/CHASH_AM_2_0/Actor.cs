using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CHASH_AM_2_0
{
    public abstract class Actor
    {
        public      Vector2       Position      { get; protected set; }
        public      Rectangle     CollisionBox  { get; protected set; }
        public      float         Speed;
        public      double        Angle;

        protected   Vector2       Direction;
        protected   Texture2D     Texture;

        public Actor(Vector2 position, Texture2D texture)
        {
            this.Position = position;
            this.Texture = texture;
            this.CollisionBox = Texture.Bounds;
        }

        public abstract void Update();
        public abstract void Draw(SpriteBatch spriteBatch);
    }
}
