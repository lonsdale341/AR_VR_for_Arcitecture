using UnityEngine;
using System.Collections;

internal class State_game_apartment : State
{
    internal State_game_apartment()
    {
        StateScreen();
    }



    private void StateScreen()
    {
        DataLevel.Instance.DisableGameObjectForState();
        
        DataLevel.Instance.Apartment.transform.parent = DataLevel.Instance.VR_Game_Parent.transform;
        //DataLevel.Instance.City.transform.localPosition=new Vector3(0,0,0);
       // DataLevel.Instance.City.transform.localScale = new Vector3(0.00128866f, 0.00128866f, 0.00128866f);
        DataLevel.Instance.Apartment.SetActive(true);
        DataLevel.Instance.Light_apartment_1.SetActive(true);
        DataLevel.Instance.Light_apartment_2.SetActive(true);
        Renderer[] rendererComponents = DataLevel.Instance.VR_Game_Parent.GetComponentsInChildren<Renderer>(true);
        Collider[] colliderComponents = DataLevel.Instance.VR_Game_Parent.GetComponentsInChildren<Collider>(true);

        // Enable rendering:
        foreach (Renderer component in rendererComponents)
        {
            component.enabled = true;
        }

        // Enable colliders:
        foreach (Collider component in colliderComponents)
        {
            component.enabled = true;
        }
        DataLevel.Instance.Game_Camera_Apartment.SetActive(true);
        DataLevel.Instance.Game_Camera_Apartment.GetComponent<FPSInputController>().enabled = true;
        DataLevel.Instance.ButtonBackPlay.SetActive(true);


    }
}
