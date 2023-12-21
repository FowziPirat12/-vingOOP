using System.Collections.Generic;
using System.Xml;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace _vingOOP
{
    public class Player: Entity
    {

        List<Bullet> bullets = new List<Bullet>();

        public List<Bullet> Bullets
        {
            get{ return bullets;}
        }

        public Vector2 Position{
            get {return position;}
        }

        public Player(Texture2D texture): base (texture){
            this.texture = texture;
            color = Color.White;
            hitbox = new Rectangle(0,0,25,50);
        }
        public void Update()
        {
           Move();
           Shoot();

           foreach(Bullet bullets in bullets){
            bullets.Update();
           }
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);

            foreach(Bullet bullet in bullets){
                bullet.Draw(spriteBatch);
            }
        }

        private void Shoot(){
            MouseState mouse = Mouse.GetState();
            if(mouse.LeftButton == ButtonState.Pressed){
                bullets.Add(new Bullet(texture, Position));
            }
        }

        private void Move(){
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
    }
}