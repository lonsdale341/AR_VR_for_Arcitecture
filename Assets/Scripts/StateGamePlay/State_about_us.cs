using System.Collections;
using System.Collections.Generic;
using UnityEngine;

internal class State_about_us : State {
	internal State_about_us()
	{
		StateScreen();
	}



	private void StateScreen()
	{
		DataLevel.Instance.DisableGameObjectForState();
		DataLevel.Instance.Menu_about_us.SetActive (true);
		DataLevel.Instance.Img_road.SetActive (true);
		DataLevel.Instance.Button_back_first_menu.SetActive (true);
		DataLevel.Instance.Image_background.SetActive (true);
	}


}
