using UnityEngine;
using System.Collections;

public class Controller_Awards : MonoBehaviour
{
    public GameObject Arrow;
    public Camera CurrentCamera;
    public float b;
    public float c;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        float a = 0;
        if (Screen.width < Screen.height)
        {
            a = Screen.width;
        }
        if (Screen.height < Screen.width)
        {
            a = Screen.height;
        }
        Arrow.transform.position = CurrentCamera.ScreenToWorldPoint(new Vector3(b ,c, 10f));
	}
}
