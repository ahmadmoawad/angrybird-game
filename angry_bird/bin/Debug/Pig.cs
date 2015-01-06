using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Audio;
namespace angry_bird
{
	public class Pig:Base
	{

		Random _ran;
		//bool _intersected;
		public Pig (Texture2D text,Vector2 rec,int volicty,SoundEffect sound)
			:base(text,rec,volicty,sound)
		{
			_ran=new Random();
			this.RandiomInit ();

		}

		int x=1,y = 1;
		public new void UpDate ()
		{

			//if(_intersected)return;

			if (this.Vect.X + this.Text.Width + this.Volicty > Base.Graphics.PreferredBackBufferWidth) {
			

				x *= -1;


			}
			if (this.Vect.X + this.Volicty <= 0) {
			

				x *= -1;

			}
			if (this.Vect.Y + this.Text.Height + this.Volicty > Base.Graphics.PreferredBackBufferHeight/2) {

				y *= -1;

			}
			

			if (this.Vect.Y + this.Volicty <= 0) {

				y *= -1;
			}

			Base.VectSetXY (this, (this.Volicty * x), (this.Volicty * y));


		
		}
		public void RandiomInit(){

			Base.VectSetXY (this,_ran.Next(Base.Graphics.PreferredBackBufferWidth-this.Text.Width-50),_ran.Next (Base.Graphics.PreferredBackBufferHeight)/3);
		}

		public bool InterSect (Pig p)
		{

			if (this.Text.Bounds.Intersects (p.Text.Bounds)) {
				p.UpDate ();
				//this.UpDate ();
				return true;
			} else {
				return false;
			}

		}
			public bool InterSect (Bird p)
		{
			if (this.Text.Bounds.Intersects (p.Text.Bounds)) {
				//_intersected = true;
				//Base.VectReSetXY (this, 0, 0);
				return true;
			} else {
				return false;
			}

		}

	}

}

