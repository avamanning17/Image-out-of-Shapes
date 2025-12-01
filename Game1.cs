using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Data.Common;

namespace Image_out_of_Shapes
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        

        SpriteFont textFont;
        Rectangle hotPinkRectangle;
        Rectangle leg1Rectangle, leg2Rectangle, leg3Rectangle, leg4Rectangle;
        Rectangle purpleCircle;
        Rectangle eye1, eye2, eye1Dot, eye2Dot;
        Rectangle ear1, ear2, nose;

        Rectangle window;

        SpriteFont titlefont;

        Texture2D Texture;
        Texture2D triangleTexture;
        Texture2D pinkRectangleTexture;
        Texture2D circleTexture;
        Texture2D purpleRectangleTexture;

        MouseState mouseState;

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
            leg1Rectangle = new Rectangle(275, 300, 20, 75);
            leg2Rectangle = new Rectangle(305, 300, 20, 75);
            leg3Rectangle = new Rectangle(475, 300, 20, 75);
            leg4Rectangle = new Rectangle(505, 300, 20, 75);
            hotPinkRectangle = new Rectangle(275, 200, 250, 100);
            purpleCircle = new Rectangle(455, 125, 120, 120);
            eye1 = new Rectangle(470, 160, 35, 35 );
            eye2 = new Rectangle(515, 160, 35, 35);
            eye1Dot = new Rectangle(486, 180, 10, 10);
            eye2Dot = new Rectangle(530, 180, 10, 10);
            ear1 = new Rectangle(465, 110, 40, 40); 
            ear2 = new Rectangle(520, 110, 40, 40);
            nose = new Rectangle(500, 200, 25, 25);
            

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here

            pinkRectangleTexture = Content.Load<Texture2D>("hotPinkRectangle");
            triangleTexture = Content.Load<Texture2D>("triangle");
            triangleTexture = Content.Load<Texture2D>("triangle");
            triangleTexture = Content.Load<Texture2D>("triangle");
            circleTexture = Content.Load<Texture2D>("purpleCircle");
            circleTexture = Content.Load<Texture2D>("purpleCircle");
            circleTexture = Content.Load<Texture2D>("purpleCircle");
            purpleRectangleTexture = Content.Load<Texture2D>("purpleRectangle");
            purpleRectangleTexture = Content.Load<Texture2D>("purpleRectangle");
            purpleRectangleTexture = Content.Load<Texture2D>("purpleRectangle");
            purpleRectangleTexture = Content.Load<Texture2D>("purpleRectangle");
            titlefont = Content.Load<SpriteFont>("TextFont");


        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            mouseState = Mouse.GetState();

            this.Window.Title=mouseState.Position.ToString();
            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            _spriteBatch.Begin();


            _spriteBatch.Draw(pinkRectangleTexture, hotPinkRectangle, Color.White);
            _spriteBatch.Draw(circleTexture, purpleCircle, Color.White);
            _spriteBatch.Draw(circleTexture, eye1, Color.LightGray);
            _spriteBatch.Draw(circleTexture, eye2, Color.LightGray);
            _spriteBatch.Draw(circleTexture, eye1Dot, Color.Black);
            _spriteBatch.Draw(circleTexture, eye2Dot, Color.Black);
            _spriteBatch.Draw(triangleTexture, ear1, Color.HotPink);
            _spriteBatch.Draw(triangleTexture, ear2, Color.HotPink);
            _spriteBatch.Draw(triangleTexture, nose, Color.HotPink);
            _spriteBatch.Draw(purpleRectangleTexture, leg1Rectangle, Color.White);
            _spriteBatch.Draw(purpleRectangleTexture, leg2Rectangle, Color.White);
            _spriteBatch.Draw(purpleRectangleTexture, leg3Rectangle, Color.White);
            _spriteBatch.Draw(purpleRectangleTexture, leg4Rectangle, Color.White);

            _spriteBatch.DrawString(titlefont, "Im a Cat!", new Vector2(350, 400), Color.White);




            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
