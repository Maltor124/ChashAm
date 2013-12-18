using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;


namespace CHASH_AM_2_0
{
    /// <summary>
    /// This is a game component that implements IUpdateable.
    /// </summary>
    public class ActorManager : Microsoft.Xna.Framework.DrawableGameComponent
    {
        public  static Rectangle       ClientBounds;

        private TextureManager  textures;
        private SpriteBatch     spriteBatch;
        private List<Actor>     actors;

        public ActorManager(Game game)
            : base(game)
        {
            // TODO: Construct any child components here.
            textures = new TextureManager(game.Content);
            ClientBounds = game.Window.ClientBounds;
        }

        /// <summary>
        /// Allows the game component to perform any initialization it needs to before starting
        /// to run.  This is where it can query for any required services and load content.
        /// </summary>
        public override void Initialize()
        {
            // TODO: Add your initialization code here
            spriteBatch = new SpriteBatch(GraphicsDevice);
            actors = new List<Actor>();
            actors.Add(new Player(new Vector2(ClientBounds.Width/2, ClientBounds.Height/2), textures["player.png"]));

            base.Initialize();
        }

        /// <summary>
        /// Allows the game component to update itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        public override void Update(GameTime gameTime)
        {
            // TODO: Add your update code here
            for (int i = actors.Count - 1; i >= 0; i--)
            {
                actors[i].Update();
            }

            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            spriteBatch.Begin();
            foreach (Actor a in actors) a.Draw(spriteBatch);
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
