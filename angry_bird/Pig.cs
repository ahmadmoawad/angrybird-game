using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Audio;
using System.Collections.Generic;


namespace angry_bird
{
	public class Pig:Base
	{

		private static List<Vector2> _myVectLst=new List<Vector2>();
		public  bool Died{get;set;}
		public static bool InterSected{get;set;}
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
			InterSected=false;
			if (this.Vect.X + this.Text.Width + this.Volicty > Base.Graphics.PreferredBackBufferWidth) {
			

				x *= -1;
				InterSected=true;

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
		public void RandiomInit ()
		{
		 

			Vector2 v = new Vector2 (_ran.Next (Base.Graphics.PreferredBackBufferWidth), _ran.Next (Base.Graphics.PreferredBackBufferHeight) / 3);
			Pig._myVectLst.Add (v);
			//if (!Pig._myVectLst.Contains (v)) {
				Base.VectSetXY (this, v.X, v.Y);
				return;
			//} else {
			//	RandiomInit ();
			
			//}
		}

		public void InterSect (Pig p)
		{

			if (this.Rect.Intersects (p.Rect)) {
				p.UpDate ();
				//Base.VectReSetXY (p,p.Vect.X*-1,p.Vect.Y *-1);
				//this.UpDate ();
			}
		}
			public bool InterSect (Bird b)
		{

			if (this.Rect.Intersects (b.Rect)) {
		b.ReturnOrg ();
				b.InterSected=true;
				return Died=true;
			} else {
				b.InterSected=false;
				return Died=false;

			}

		}

	
	
	
	}

}

