using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Image_out_of_Shapes
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        SpriteFont textFont;
        Rectangle hotPinkRectangle;
        Rectangle purpleRectangle;
        Rectangle purpleCircle;
        Rectangle triangle;

        Rectangle window;

        Texture2D Texture;
        Texture2D triangleTexture;
        Texture2D pinkRectangleTexture;
        Texture2D circleTexture;
        Texture2D purpleRectangleTexture;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            window = new Rectangle(0, 0, 800, 500);
            _graphics.PreferredBackBufferWidth = window.Width;
            _graphics.PreferredBackBufferHeight = window.Height;
            _graphics.ApplyChanges();

            // x y, width, height
            purpleRectangle = new Rectangle(0, 0, 0, 0);
            hotPinkRectangle = new Rectangle(275, 200, 250, 100);
            triangle = new Rectangle();
            purpleCircle = new Rectangle(455, 125, 120, 120);

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here

            pinkRectangleTexture = Content.Load<Texture2D>("hotPinkRectangle");
            triangleTexture = Content.Load<Texture2D>("triangle");
            circleTexture = Content.Load<Texture2D>("purpleCircle");
            purpleRectangleTexture = Content.Load<Texture2D>("purpleRectangle");
            
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            _spriteBatch.Begin();


            _spriteBatch.Draw(pinkRectangleTexture, hotPinkRectangle, Color.White);
            _spriteBatch.Draw(triangleTexture, triangle, Color.White);
            _spriteBatch.Draw(purpleRectangleTexture, purpleRectangle, Color.White);
            _spriteBatch.Draw(circleTexture, purpleCircle, Color.White);
            

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
