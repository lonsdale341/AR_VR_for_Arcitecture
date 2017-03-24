using UnityEngine;
using System.Collections;
public class ManagerSateScreen
{
    internal State State { get; set; }
    public ManagerSateScreen()
    {
		State = new State_menu_about_app ();
        //DataLevel.Instance.CurrentState = Mark.main_menu;
    }
    public void FindOut(Mark mark)
    { State.HandleMark(this, mark); }
}
