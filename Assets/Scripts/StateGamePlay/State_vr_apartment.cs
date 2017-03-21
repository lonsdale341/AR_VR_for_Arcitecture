using UnityEngine;
using System.Collections;

internal class State_vr_apartment :State
{
    internal State_vr_apartment()
    {
        StateScreen();
    }



    private void StateScreen()
    {
        DataLevel.Instance.DisableGameObjectForState();
                           
        DataLevel.Instance.Apartment.transform.parent = DataLevel.Instance.VR_Game_Parent.transform;
       // DataLevel.Instance.Apartment.transform.localPosition = new Vector3(0, -0.01999998f, 0);
      //  DataLevel.Instance.Apartment.transform.localScale = new Vector3(0.169142f, 0.169142f, 0.169142f);
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
		DataLevel.Instance.ALPS_Camera_Apartment.GetComponent<Camera>().enabled = true;
        DataLevel.Instance.ALPS_Camera_Apartment.SetActive(true);
        DataLevel.Instance.ButtonBackPlay.SetActive(true);
        


    }
}
