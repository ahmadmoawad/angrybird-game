using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Audio;


namespace angry_bird

{

	/// <summary>
	/// Base. 
	///where classes inherited 
	/// </summary>

	public class Base{

		public Rectangle Rect{get;set;}
		public Texture2D Text{get;set;}
		int Width{get;set;}
		int Hieght{get;set;}
		private Vector2 _vec;
		public Vector2 Vect{get{return _vec;}set{_vec=value;}}
		public int Volicty{get;set;}

		public SoundEffect Sound{get;set;}


		public static SpriteBatch Batch{get;set;}
		public static GraphicsDeviceManager Graphics{get;set;}

		public Base ()
		{
			
		}
		public Base (Texture2D text,Vector2 rec,int width=40,int hieght=40)
		{
			Text=text;
			Width=width;
			Hieght=hieght;
			Vect=rec;
		
		}

		public Base (Texture2D text,int width,int height,Vector2 rec,GraphicsDeviceManager graphic,SpriteBatch batch)
			:this(text,rec,width,height)
		{
			Base.Batch=batch;
			Base.Graphics=graphic;
		
			
		}
		public Base (Texture2D text,Vector2 rec,int volicty,SoundEffect sound)
			:this(text,rec)
		{
			Sound=sound;
			Volicty=volicty;

			
		}
	
		/// <summary>
		/// Ups the date.
		/// </summary>
		public void UpDate(){


		}
		/// <summary>
		/// Draw this instance.
		/// </summary>
		public void  Draw ()
		{
		
			Base.Batch.Begin ();
			this.Rect=new Rectangle((int)Vect.X,(int)Vect.Y,Width,Hieght);
			Base.Batch.Draw (this.Text,this.Rect,Color.White);
			Base.Batch.End ();

		}

		/// <summary>
		/// Plaies the sound effect.
		/// </summary>
		public void PlaySoundEffect(){

			Sound.Play ();
		
		}
		/// <summary>
		/// Change Vect x,y.
		/// </summary>
		/// <param name='b'>
		/// B.
		/// </param>
		/// <param name='x'>
		/// X.
		/// </param>
		/// <param name='y'>
		/// Y.
		/// </param>
		public static void VectSetXY(Base b,float x,float y){

			b._vec.X+=x;
			b._vec.Y+=y;
		}
			public static void VectReSetXY (Base b,float x,float y)
		{

			b._vec.X = x;
			b._vec.Y = y;
		}
		public static void VectSetY(Base b,float y){


			b._vec.Y+=y;
		}
		public static void VectSetX(Base b,float x){


			b._vec.X+=x;
		}
	
	}


}