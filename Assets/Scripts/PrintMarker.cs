using UnityEngine;
using System.Collections;

public class PrintMarker : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void OnClick()
	{
		Application.OpenURL("https://drive.google.com/file/d/0B4TdSrFJS3kcMzVLYlJ0YXZ1RzQ/view?usp=sharing");
	}
}
