using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace _vingOOP
{
    public class Player
    {
        private Vector2 position;
        private Texture2D texture;

        public Vector2 Position{
            get {return position;}
        }

        public Player(Texture2D texture){
            this.texture = texture;
        }
        public void Update()
        {
           KeyboardState kState = Keyboard.GetState();
           if(kState.IsKeyDown(Keys.W))
           {
                position.Y--;
           }

           if(kState.IsKeyDown(Keys.S))
           {
                position.Y++;
           } 

           if(kState.IsKeyDown(Keys.A))
           {
                position.X--;
           } 

           if(kState.IsKeyDown(Keys.D))
           {
                position.X++;
           }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle rec = new Rectangle();
            rec.Location = position.ToPoint();
            rec.Width = 25;
            rec.Height = 50;
            spriteBatch.Draw(texture, rec, Color.White);
        }
    }
}