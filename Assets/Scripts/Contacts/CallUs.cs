using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallUs : MonoBehaviour {

	public void CallPhone()
	{
		Application.OpenURL ("tel://+38067506589");
	}
}
