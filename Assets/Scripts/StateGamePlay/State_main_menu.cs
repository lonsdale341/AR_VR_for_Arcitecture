using UnityEngine;
using System.Collections;

internal class State_main_menu : State
{
    internal State_main_menu()
    {
        StateScreen();
    }



    private void StateScreen()
    {
        DataLevel.Instance.DisableGameObjectForState();
		DataLevel.Instance.MainMenu.SetActive(true);
		FPSInputController.IsMoving = false;
		DataLevel.Instance.BackgroundMenu.SetActive (true);


    }
}
