using System.Collections;
using System.Collections.Generic;
using UnityEngine;

internal class State_ar_tutorial : State {

	internal State_ar_tutorial()
	{
		StateScreen();
	}



	private void StateScreen()
	{
		DataLevel.Instance.DisableGameObjectForState();
		DataLevel.Instance.AR_tutorial.SetActive (true);
		DataLevel.Instance.ButtonBackPlay.SetActive (true);
		DataLevel.Instance.Image_background.SetActive (true);
		DataLevel.Instance.Image_city_roll.SetActive (true);
		
	}
}
