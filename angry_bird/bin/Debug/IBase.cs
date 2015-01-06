using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.Input;

namespace angry_bird
{
	public interface IBase
	{
		 void UpDate();
		 void Draw(GameTime gameTime);
		 void Play();

	}
}

