
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
namespace _vingOOP
{
    public class Entity
    {
        protected Texture2D texture;
        protected Vector2 position; 
        protected Rectangle hitbox;
        protected Color color;

        public Rectangle Hitbox{
            get{return hitbox;}
        }

        public Entity(Texture2D texture){

        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            hitbox.Location = position.ToPoint();
            spriteBatch.Draw(texture, hitbox, color);
        }

    }
}