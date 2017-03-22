using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Write_mail : MonoBehaviour {

	public void SendMail()
	{
		
		Application.OpenURL("mailto:info@somyx.com?Subject=&body=");

	}
}
