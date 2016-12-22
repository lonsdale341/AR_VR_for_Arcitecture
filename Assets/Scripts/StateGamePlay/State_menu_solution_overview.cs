using UnityEngine;
using System.Collections;

internal class State_menu_solution_overview : State
{
    internal State_menu_solution_overview()
    {
        StateScreen();
    }



    private void StateScreen()
    {
        DataLevel.Instance.DisableGameObjectForState();
        DataLevel.Instance.Screen_solution_Overview.SetActive(true);




    }
}
