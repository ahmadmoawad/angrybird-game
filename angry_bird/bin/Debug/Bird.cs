using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Audio;
using System.Threading;


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
				:base(text,new Vector2(0,Base.Graphics.PreferredBackBufferHeight-190),250,120)
			{

			}
		
		
		}

		Vector2 _orgVec;
		bool _flied,_return;
		public Bird (Texture2D text,Firer f,int volicty,SoundEffect sound)
			:base(text,new Vector2((f.Text.Width/2)+30,f.Vect.Y-20),volicty,sound)

		{
			_orgVec=new Vector2((f.Text.Width/2)+30,f.Vect.Y-20);
				this.Volicty=2;

		}

	
		int randY=new Random().Next (10);

		public new void UpDate ()
		{
			if (!_flied) {
				this.PlaySoundEffect ();
			
			}
			if (this.Vect.X + this.Volicty <= 0 || this.Text.Width + this.Vect.X + this.Volicty >= Base.Graphics.PreferredBackBufferWidth) {

				this.Vect = _orgVec;
				_flied = false;
				_return = false;
			 
				randY=new Random().Next (10);
			}

			 else {
				if (!_return) {

					Base.VectSetX (this, this.Volicty * -1);
					if (this.Vect.X < _orgVec.X-30) {

						_return = true;
					}

				} else {
					Base.VectSetXY (this, this.Volicty, randY * -1);

				}
			_flied = true;
			}
		
		}


	}
}


