using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Media;

namespace angry_bird
{
	/// <summary>
	/// Start.
	/// </summary>
	public class Start:Base
	{
		//Determine to start game after startBackground
		public static bool Started{get;set;}
		//Determone if ended game
		public static bool Ended{get;set;}
		//Msg to users at startBackground
		public SpriteFont FontG{get;set;}
		//Play song at startBackground
		public Song SongM{get;set;}

		
		public Start (Texture2D text,Vector2 rec)
			:base(text,rec)
			
		{

		}
		
		public Start (GraphicsDeviceManager graphic,SpriteBatch batch,Texture2D text,Song song)
			:base(text,graphic.PreferredBackBufferWidth,graphic.PreferredBackBufferHeight,new Vector2(0,0),graphic,batch)
			
		{

			this.SongM=song;
			this.PlaySong();
		}

		public new void Draw()
		{
			Base.Batch.Begin ();
			Base.Batch.Draw (this.Text,new Rectangle(0,0,Base.Graphics.PreferredBackBufferWidth,Base.Graphics.PreferredBackBufferHeight),Color.White);
			Base.Batch.End ();

		}

		/// <summary>
		/// Plaies the song.
		/// </summary>
		public void PlaySong(){
			MediaPlayer.Play (SongM);

		}
		/// <summary>
		/// Stops the song.
		/// </summary>
		public void StopSong(){

			MediaPlayer.Stop ();

		}
	    
		/// <summary>
		/// Starts the game.
		/// </summary>
		/// <param name='text'>
		/// Text.
		/// </param>
		/// <param name='song'>
		/// Song.
		/// </param>
		public void StartGame(Texture2D text,Song song){
			//change song
			this.SongM=song;
			//change background
			this.Text=text;
			//stop old song
			this.StopSong ();
			//repeat new song looping
			MediaPlayer.IsRepeating=true;
			//play new song
			this.PlaySong ();

		}
}

}


