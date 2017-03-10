using UnityEngine;
using System.Collections;

public class AccelerometerInput : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		gameObject.transform.Translate(Input.acceleration.x, 0, -Input.acceleration.z);
	}
}
