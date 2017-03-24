using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MailUs : MonoBehaviour {

	public void WriteMail()
	{

		Application.OpenURL("mailto:info@somyx.com?subject=");
	}
}
