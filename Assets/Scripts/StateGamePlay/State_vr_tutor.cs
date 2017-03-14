using UnityEngine;
using System.Collections;

internal class State_vr_tutor : State {

	internal State_vr_tutor()
	{
		StateScreen();
	}

	private void StateScreen()
	{
		DataLevel.Instance.DisableGameObjectForState();
		DataLevel.Instance.VRTutor.SetActive (true);
		DataLevel.Instance.ButtonBackPlay.SetActive(true);
		DataLevel.Instance.BackgroundMenu.SetActive (true);
	}
}
