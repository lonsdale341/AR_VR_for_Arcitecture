using UnityEngine;
using System.Collections;

internal class State_game_tutor : State {
	internal State_game_tutor()
	{
		StateScreen ();
	}

	private void StateScreen()
	{

		DataLevel.Instance.DisableGameObjectForState();
		DataLevel.Instance.GameTutor.SetActive (true);
		DataLevel.Instance.ButtonBackPlay.SetActive(true);
		DataLevel.Instance.BackgroundMenu.SetActive (true);
	}
}
