using System.Collections;
using System.Collections.Generic;
using UnityEngine;

internal class State_menu_about_company : State {
	internal State_menu_about_company()
	{
		StateScreen();
	}



	private void StateScreen()
	{
		DataLevel.Instance.DisableGameObjectForState();
		DataLevel.Instance.Interior_Img.SetActive (true);
		DataLevel.Instance.P_About_Company.SetActive (true);
		DataLevel.Instance.Back_To_First_Menu.SetActive (true);
		DataLevel.Instance.Background_for_explain.SetActive (true);
	}

}
