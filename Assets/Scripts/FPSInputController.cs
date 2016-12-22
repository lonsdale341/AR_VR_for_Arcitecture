using UnityEngine;
using System.Collections;

public class FPSInputController : MonoBehaviour {
    public GameObject head;
    public float Speed;
    public static float pitch;
    public float forwardLowerBound = 20;
    public float forwardUpperBound = 30;
    public float forwardLimit = 50;
    public float backwardLowerBound = 20;
    public float backwardUpperBound = 30;
    public float backwardLimit = 50;

    public static float ForwardLowerBound;
    public static float ForwardUpperBound;
    public static float BackwardLowerBound;
    public static float BackwardUpperBound;
    public static float ForwardLimit;
    public static float BackwardLimit;

    public bool EnableVibration = false;

    /**Private**/
    private CharacterController controller;
    private bool moving;
    
    public void Awake()
    {
        head =gameObject;
#if UNITY_ANDROID
			head.AddComponent(typeof(ALPSGyro));
			ALPSAndroid.Init ();

#endif
    }

    public void Start()
    {
        ForwardLowerBound = forwardLowerBound;
        ForwardUpperBound = forwardUpperBound;
        BackwardLowerBound = 360 - backwardLowerBound;
        BackwardUpperBound = 360 - backwardUpperBound;
        ForwardLimit = forwardLimit;
        BackwardLimit = 360 - backwardLimit;

        controller = this.gameObject.GetComponent("CharacterController") as CharacterController;
        //this.gameObject.AddComponent <CharacterMotor>();
        //head = GameObject.Find("ALPSHead");
        if (Application.platform == RuntimePlatform.Android)
        {
            moving = false;
        }
    }

    /// <summary>
    /// Updates navigation state.
    /// </summary>
    public void Update()
    {
        pitch = head.transform.eulerAngles.x;
        if (pitch >= ForwardLowerBound && pitch <= ForwardUpperBound)
        {

            if (!moving)
            {
                if (EnableVibration)
                {
#if UNITY_ANDROID
                ALPSAndroid.Vibrate(20);
#elif UNITY_WP_8_1
                    ALPSWP8.Vibrate(200);
#endif
                }

                moving = true;
            }
            controller.Move(new Vector3(head.transform.forward.x, 0, head.transform.forward.z) * Time.deltaTime * Speed);
        }
        else if (pitch >= BackwardUpperBound && pitch <= BackwardLowerBound)
        {
            if (!moving)
            {
                if (EnableVibration)
                {
#if UNITY_ANDROID
                ALPSAndroid.Vibrate(20);
#elif UNITY_WP_8_1
                    ALPSWP8.Vibrate(200);
#endif
                }
                moving = true;
            }
            controller.Move(new Vector3(-head.transform.forward.x, 0, -head.transform.forward.z) * Time.deltaTime * Speed);

        }
        else
        {
            if (moving) moving = false;
        }
    }

    /// <summary>
    /// Initialize Android ALPS Activity.
    /// </summary>
    public static float Progress()
    {
        if (pitch >= ForwardLowerBound && pitch <= ForwardUpperBound || pitch >= BackwardUpperBound && pitch <= BackwardLowerBound)
        {
            return 1f;
        }
        else
        {
            if (pitch >= 0 && pitch < ForwardLowerBound) return pitch / 25f;
            else if (pitch <= 360 && pitch > BackwardLowerBound) return (360 - pitch) / 25f;
            else if (pitch > ForwardUpperBound && pitch <= ForwardLimit) return (ForwardLimit - pitch) / 25f;
            else if (pitch < BackwardUpperBound && pitch >= BackwardLimit) return (pitch - BackwardLimit) / 25f;
            else return 0f;
        }
    }
}
