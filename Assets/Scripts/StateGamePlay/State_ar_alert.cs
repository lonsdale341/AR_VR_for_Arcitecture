using System.Collections;
using System.Collections.Generic;
using UnityEngine;

internal class State_ar_alert : State {
	internal State_ar_alert()
	{
		StateScreen();
	}



	private void StateScreen()
	{
		
		DataLevel.Instance.DisableGameObjectForState();
		DataLevel.Instance.ARAlert.SetActive (true);
		DataLevel.Instance.AR_Camera.SetActive(true);

	}

}
