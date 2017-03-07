using UnityEngine;
using System.Collections;

public class DataLevel : SingletonBehaviour<DataLevel>
{

    public GameObject Screen_MainMenu;

    public GameObject ButtonBackPlay;
    public GameObject AR_Camera;
    public GameObject ALPS_Camera_District;
    public GameObject Game_Camera_District;

    public GameObject City;

    public GameObject VR_Game_Parent;

  
    public GameObject ImgMarker;
	public GameObject Panorama;
    private ManagerSateScreen managerSateScreen;
    void Awake()
    {
        // ResetContent();
      
        managerSateScreen = new ManagerSateScreen();
        
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void DisableGameObjectForState()
    {
        Screen_MainMenu.SetActive(false);

        ButtonBackPlay.SetActive(false);
        AR_Camera.SetActive(false);
        ALPS_Camera_District.SetActive(false);
        Game_Camera_District.SetActive(false);
   
        City.SetActive(false);

        //VR_Game_Parent.SetActive(false);


        

    }
    public void ChangedSate(Mark mark)
    {
        managerSateScreen.FindOut(mark);
       
    }
}
