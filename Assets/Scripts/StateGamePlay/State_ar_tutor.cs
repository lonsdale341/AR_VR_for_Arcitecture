using UnityEngine;
using System.Collections;

internal class State_ar_tutor : State {
	internal State_ar_tutor()
	{
		StateScreen ();
	}

	private void StateScreen()
	{
		DataLevel.Instance.DisableGameObjectForState();
		DataLevel.Instance.ARTutor.SetActive (true);
		DataLevel.Instance.ButtonBackPlay.SetActive(true);
	}
}
