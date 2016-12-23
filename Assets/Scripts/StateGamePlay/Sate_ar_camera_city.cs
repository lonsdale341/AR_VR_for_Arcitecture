using UnityEngine;
using System.Collections;

internal class Sate_ar_camera_city : State
{
    internal Sate_ar_camera_city()
    {
        StateScreen();
    }



    private void StateScreen()
    {
        DataLevel.Instance.DisableGameObjectForState();
        DataLevel.Instance.AR_Camera.SetActive(true);
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
        DataLevel.Instance.City.transform.parent = DataLevel.Instance.ImgMarker.transform;
        DataLevel.Instance.City.transform.localPosition = new Vector3(0, 0.02f, 0);
        DataLevel.Instance.City.transform.localScale = new Vector3(0.00128866f, 0.00128866f, 0.00128866f);

        
        DataLevel.Instance.City.SetActive(true);
       
        DataLevel.Instance.ButtonBackPlay.SetActive(true);



    }
}
