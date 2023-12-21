using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace _vingOOP
{
    public class Archer: Enemy
    {
        private Vector2 position;

        private Texture2D texture;

        private Player target;

        public Archer(Texture2D texture, Player target){
            this.texture = texture;
            this.target = target;

            position = new Vector2(500, 500);
        }

        public void Update(){
            
            Vector2 direction = target.Position - position;
            direction.Normalize();
            if(Vector2.Distance(target.Position, position) > 100){ 
                position += direction;

            }

            else if (Vector2.Distance(target.Position, position) > 100){
                position += direction;
            }
           
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle rec = new Rectangle();
            rec.Location = position.ToPoint();
            rec.Width = 25;
            rec.Height = 50;
            spriteBatch.Draw(texture, rec, Color.DarkGreen);
        }
    }
}