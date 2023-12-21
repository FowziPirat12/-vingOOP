using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
namespace _vingOOP
{
    public class Wernow: Enemy
    {

          public Wernow(Texture2D texture, Player target): base(texture, target){
            this.texture = texture;
            this.target = target;

            position = new Vector2(500, 500);
            color = Color.Red;
        }
        public override void Update(){

            Vector2 direction = target.Position - position;
            direction.Normalize();

            position += direction;

        }

        
    }
}