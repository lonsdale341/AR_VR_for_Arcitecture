using UnityEngine;
using System.Collections;

public class MoveController : MonoBehaviour {
    public GameObject head;
   

    public void Awake()
    {
        head = gameObject;
#if UNITY_ANDROID
			head.AddComponent(typeof(ALPSGyro));
			ALPSAndroid.Init ();

#endif
    }

  
}
