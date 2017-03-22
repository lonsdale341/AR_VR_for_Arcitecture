using UnityEngine;
using System.Collections;
public class ManagerSateScreen
{
    internal State State { get; set; }
    public ManagerSateScreen()
    {
		State = new State_first_page ();
		Debug.Log ("MainMenu");
        //DataLevel.Instance.CurrentState = Mark.main_menu;
    }
    public void FindOut(Mark mark)
    { State.HandleMark(this, mark); }
}
