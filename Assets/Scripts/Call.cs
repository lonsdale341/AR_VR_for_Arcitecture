using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Call : MonoBehaviour {

	public void CallUs()
	{
		Application.OpenURL ("tel://+380960405514");
	}
}
