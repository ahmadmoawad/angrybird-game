#region Using Statements
using System;
using System.Collections.Generic;
using System.Linq;

#endregion

namespace angry_bird
{
	static class Program
	{
		private static MainGame game;

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main ()
		{
			game = new MainGame ();
			game.Run ();
		}
	}
}
