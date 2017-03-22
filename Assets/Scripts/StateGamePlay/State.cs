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
				Debug.Log ("Main_menu");
                }
        
            case Mark.ar_camera_city:
                {
                    managerSateScreen.State = new Sate_ar_camera_city();
                    break;
                }

            case Mark.vr_city:
                {
                    managerSateScreen.State = new State_vr_city();
                    break;
                }
            case Mark.game_city:
                {
                    managerSateScreen.State = new State_game_city();
                    break;
                }
			case Mark.ar_tutorial:
				{
				managerSateScreen.State = new State_ar_tutorial ();
					break;
				}
			case Mark.vr_tutorial:
				{
				managerSateScreen.State = new State_vr_tutorial ();
					break;
				}
			case Mark.game_tutorial:
				{
				managerSateScreen.State = new State_game_tutorial ();
					break;
				}
		case Mark.menu_first_page:
			{
				managerSateScreen.State = new State_first_page ();
				break;
			}
		case Mark.menu_about_company:
			{
				managerSateScreen.State = new State_about_us ();
				break;
			}
     
        }
    }

}

