using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
namespace _vingOOP
{
    public abstract class Enemy: Entity
    {

        protected Player target;
        public abstract void Update();

          public Enemy(Texture2D texture, Player target):base(texture){
            this.texture = texture;
            this.target = target;
            hitbox.Size = new Point(25,50);
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            Rectangle rec = new Rectangle();
            rec.Location = position.ToPoint();
            rec.Width = 25;
            rec.Height = 50;
            spriteBatch.Draw(texture, rec, color);
        }
    }
}