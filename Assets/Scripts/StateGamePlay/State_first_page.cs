using System.Collections;
using System.Collections.Generic;
using UnityEngine;

internal class State_first_page : State {
	internal State_first_page()
	{
		StateScreen();
	}



	private void StateScreen()
	{
		DataLevel.Instance.DisableGameObjectForState();
		DataLevel.Instance.Menu_first_page.SetActive (true);
		DataLevel.Instance.Img_road.SetActive (true);
		DataLevel.Instance.Image_background.SetActive (true);
	}
}
