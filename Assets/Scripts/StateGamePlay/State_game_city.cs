using UnityEngine;
using System.Collections;

internal class State_game_city :  State
{
    internal State_game_city()
    {
        StateScreen();
    }



    private void StateScreen()
    {
        DataLevel.Instance.DisableGameObjectForState();
        
        DataLevel.Instance.City.transform.parent = DataLevel.Instance.VR_Game_Parent.transform;
        //DataLevel.Instance.City.transform.localPosition=new Vector3(0,0,0);
        //DataLevel.Instance.City.transform.localScale = new Vector3(0.00128866f, 0.00128866f, 0.00128866f);
        DataLevel.Instance.City.SetActive(true);
     
        Renderer[] rendererComponents = DataLevel.Instance.VR_Game_Parent.GetComponentsInChildren<Renderer>(true);
        Collider[] colliderComponents = DataLevel.Instance.VR_Game_Parent.GetComponentsInChildren<Collider>(true);
		DataLevel.Instance.Panorama.SetActive (true);
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
        DataLevel.Instance.Game_Camera_District.SetActive(true);
        DataLevel.Instance.Game_Camera_District.GetComponent<FPSInputController>().enabled = true;

        DataLevel.Instance.ButtonBackPlay.SetActive(true);
        


    }
}
