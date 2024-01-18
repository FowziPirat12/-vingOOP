using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace _vingOOP;

public class Game1 : Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;

    Texture2D pixel; 
    Player player;
    

    List<Enemy> enemies = new List<Enemy>();
   


    public Game1()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here

        base.Initialize();
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);

        pixel = new Texture2D(GraphicsDevice,1,1);
        pixel.SetData(new Color[]{Color.White});

        player = new Player(pixel);
        enemies.Add (new Wernow(pixel, player));
        enemies.Add(new Archer(pixel, player));

        // TODO: use this.Content to load your game content here
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

            player.Update();
            foreach (Enemy enemy in enemies){
                enemy.Update();
            }
            Collision();
        // TODO: Add your update logic here

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);

        _spriteBatch.Begin();
        player.Draw(_spriteBatch);
        
        foreach (Enemy enemy in enemies){
            enemy.Draw(_spriteBatch);
        }


        _spriteBatch.End();

        // TODO: Add your drawing code here

        base.Draw(gameTime);
    }

    private void Collision(){
        List<Bullet> bullets = player.Bullets;
        if(bullets.Count == 0) return;
        foreach(Bullet bullet in bullets){
            for(int i = 0; i < enemies.Count; i++){
                if(bullet.Hitbox.Intersects(enemies[i].Hitbox)){
                    enemies.RemoveAt(i);
                    i--;
                }
            } 
        }
    }
}
