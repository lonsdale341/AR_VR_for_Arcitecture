using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SelectedScene : MonoBehaviour
{
    public string NameScene;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

   public void OnClickButton()
    {
        Debug.Log("HHHH");

        SceneManager.LoadScene(NameScene);
    }
}
