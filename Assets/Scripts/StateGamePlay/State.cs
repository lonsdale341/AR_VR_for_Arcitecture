using UnityEngine;
using System.Collections;
internal abstract class State
{
    internal virtual void HandleMark(ManagerSateScreen mangerSateScreen, Mark mark)
    { ChangeState(mangerSateScreen, mark); }
    protected void ChangeState(ManagerSateScreen managerSateScreen, Mark mark)
    {
        switch (mark)
        {
            case Mark.main_menu:
                {
                    managerSateScreen.State = new State_main_menu();
                    break;
                }
			case Mark.vr_tutor:
				{
				managerSateScreen.State = new State_vr_tutor ();
					break;
				}
			case Mark.ar_tutor:
				{
				managerSateScreen.State = new State_ar_tutor ();
					break;
				}
			case Mark.game_tutor:
				{
				managerSateScreen.State = new State_game_tutor ();
					break;
				}
            case Mark.ar_camera_apartment:
                {
                    managerSateScreen.State = new State_ar_camera_apartment();
                    break;
                }
            case Mark.vr_apartment:
                {
                    managerSateScreen.State = new State_vr_apartment();
                    break;
                }
            case Mark.game_apartment:
                {
                    managerSateScreen.State = new State_game_apartment();
                    break;
                }
		case Mark.menu_about_app:
			{
				managerSateScreen.State = new State_menu_about_app ();
				break;
			}
		case Mark.menu_about_company:
			{
				managerSateScreen.State = new State_menu_about_company ();
				break;
			}
			case Mark.ar_alert:
			{
				managerSateScreen.State = new State_ar_alert ();
				break;
			}
        }
    }

}

