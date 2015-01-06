#region Using Statements
using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using System.Diagnostics;
using System.Collections.Generic;

#endregion

namespace angry_bird
{


	public class MainGame : Game

	{

		#region Mrgn

		List<Start>_strLst;
		List<Pig> _pigLst;
	    Bird.Firer _firer;

		#endregion
	
		#region pg
		GraphicsDeviceManager graphics;
		SpriteBatch spriteBatch;

		public MainGame ()
		{
			graphics = new GraphicsDeviceManager (this);
			Content.RootDirectory = "Content";	
			graphics.PreferredBackBufferHeight =500;
			graphics.PreferredBackBufferWidth = 700;
			graphics.ApplyChanges ();
			//graphics.IsFullScreen = true;		

		}


		protected override void Initialize ()
		{

			base.Initialize ();
				
		}

		protected override void LoadContent ()
		{

			spriteBatch = new SpriteBatch (GraphicsDevice);

			_strLst =new List<Start>();
			_strLst.Add (new Start(graphics,spriteBatch,Content.Load<Texture2D> ("img/strt/bak1"),Content.Load<Song>("snd/main")));
			_strLst.Add (new Start(Content.Load<Texture2D> ("img/brd/yellow"),new Rectangle(50,50,60,60)));

			_pigLst=new List<Pig>();

			_pigLst.Add (new Pig(Content.Load<Texture2D>("img/brd/red"),new Rectangle(0,0,60,60)));
		
		
		}

	
		protected override void Update (GameTime gameTime)
		{
			// For Mobile devices, this logic will close the Game when the Back button is pressed
			if (GamePad.GetState (PlayerIndex.One).Buttons.Back == ButtonState.Pressed) {
				Exit ();
			}
			if (!Start.Started&&Keyboard.GetState ().IsKeyDown (Keys.Enter)) {
				Start.Started=true;
				_strLst[0].StartGame (Content.Load<Texture2D> ("img/lvl/angry_birds_background_by_gsgill37-d3kogmx"),Content.Load<Song>("snd/playing"));
			
				_strLst.RemoveAt (1);
					_firer=new Bird.Firer(Content.Load<Texture2D>("img/firer/firer"));
			}

			base.Update (gameTime);
		}


		protected override void Draw (GameTime gameTime)
		{
			graphics.GraphicsDevice.Clear (Color.CornflowerBlue);



			foreach (var item in _strLst) {
				item.Draw ();
			}

			if (Start.Started) {
			
					_firer.Draw ();

				foreach (var item in _pigLst) {
					item.Draw ();
				
				}
			}
			base.Draw (gameTime);
		}
	}
		#endregion

}	





