using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace _vingOOP
{
    public class Archer: Enemy
    {

        public Archer(Texture2D texture, Player target): base (texture, target){
            this.texture = texture;
            this.target = target;

            position = new Vector2(500, 500);
            color = Color.DarkGreen;
        }

        public override void Update(){
            
            Vector2 direction = target.Position - position;
            direction.Normalize();
            if(Vector2.Distance(target.Position, position) > 100){ 
                position += direction;

            }

            else if (Vector2.Distance(target.Position, position) < 100){
                position += direction;
            }
           
           hitbox.Location = position.ToPoint();
        }
    }
}