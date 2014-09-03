﻿using UnityEngine;
using System.Collections;

namespace Fungus.Script
{
	[CommandInfo("Audio", 
	             "Stop Music", 
	             "Stops the currently playing game music.", 
	             242, 209, 176)]
	public class StopMusic : FungusCommand
	{
		public override void OnEnter()
		{
			MusicController musicController = MusicController.GetInstance();
			if (musicController != null)
			{
				musicController.StopMusic();
			}

			Continue();
		}
	}

}