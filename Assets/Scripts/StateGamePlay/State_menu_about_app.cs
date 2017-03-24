using System.Collections;
using System.Collections.Generic;
using UnityEngine;

internal class State_menu_about_app : State {
	internal State_menu_about_app()
	{
		StateScreen();
	}



	private void StateScreen()
	{
		DataLevel.Instance.DisableGameObjectForState();
		DataLevel.Instance.Interior_Img.SetActive (true);
		DataLevel.Instance.Background_for_explain.SetActive (true);
		DataLevel.Instance.P_About_App.SetActive (true);
	}


}
