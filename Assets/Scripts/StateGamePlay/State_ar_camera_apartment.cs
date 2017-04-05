using UnityEngine;
using System.Collections;

internal class State_ar_camera_apartment :State
{
    internal State_ar_camera_apartment()
    {
        StateScreen();
    }



    private void StateScreen()
    {
      //  DataLevel.Instance.DisableGameObjectForState();
      //  DataLevel.Instance.AR_Camera.SetActive(true);
		DataLevel.Instance.ARAlert.SetActive(false);
        Renderer[] rendererComponents = DataLevel.Instance.VR_Game_Parent.GetComponentsInChildren<Renderer>(true);
        Collider[] colliderComponents = DataLevel.Instance.VR_Game_Parent.GetComponentsInChildren<Collider>(true);

        // Enable rendering:
        foreach (Renderer component in rendererComponents)
        {
            component.enabled = false;
        }

        // Enable colliders:
        foreach (Collider component in colliderComponents)
        {
            component.enabled = false;
        }
        DataLevel.Instance.Apartment.transform.parent = DataLevel.Instance.ImgMarker.transform;
      //  DataLevel.Instance.Apartment.transform.localPosition = new Vector3(0, 0.1632474f, 0);
       // DataLevel.Instance.Apartment.transform.localScale = new Vector3(0.1691419f, 0.1691419f, 0.1691419f);

        
        DataLevel.Instance.Apartment.SetActive(true);
       
        DataLevel.Instance.ButtonBackPlay.SetActive(true);



    }
}
