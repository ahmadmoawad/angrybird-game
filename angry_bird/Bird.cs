using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Audio;
using System.Threading;
using System.Collections.Generic;


namespace angry_bird
{
	/// <summary>
	/// Bird.
	/// </summary>
	public class Bird:Base
	{


		public class Firer:Base{

			//static bool _created;

			public Firer ()
			{
				
			}
			public Firer (Texture2D text)
				:base(text,new Vector2(0,Base.Graphics.PreferredBackBufferHeight-190),100,120)
			{

			}
		
		
		
		}
		public bool InterSected{get;set;}
		//to change brd there
		public static int Index{get; set;}
		//to count list<bird> items
		public static int Score{get;set;}
		//know the org postion on firer 
		public Vector2 _orgVec;

		bool _flied,_return;
		public Bird (Texture2D text, Firer f, int volicty, SoundEffect sound)
			:base(text,new Vector2((f.Text.Width/2),f.Vect.Y-10),volicty,sound)
		{

			_orgVec = new Vector2 ((f.Text.Width / 2), f.Vect.Y - 10);

		}

	
		int ran=new Random().Next (10);
		public void ReturnOrg ()
		{
		
				this.Vect = _orgVec;
				_flied = false;
				_return = false;
				MngIndex ();
				ran=new Random().Next (8);
		}
		public new void UpDate ()
		{
			if (!_flied) {
				this.PlaySoundEffect ();
			
			}

			if (this.Vect.Y + this.Volicty <= 0||this.Volicty+this.Vect.X+this.Text.Width>=Base.Graphics.PreferredBackBufferWidth) {

				ReturnOrg ();
			}

			 else {
				if (!_return) {

					Base.VectSetX (this, this.Volicty * -1);
					if (this.Vect.X < _orgVec.X-40) {

						_return = true;
					}

				} else {
					Base.VectSetXY (this, (ran+1) ,(this.Volicty)*-1 );

				}
			_flied = true;
			}
		
		}
		public static void MngIndex ()
		{
			if (Index >= Score-1)
				Index = 0;
			else
				Index += 1;
		
		}
		public static void Reset(){

			Index=0;
			Score=0;
		}
	}
}


