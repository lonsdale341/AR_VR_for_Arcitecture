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
        }
    }

}

