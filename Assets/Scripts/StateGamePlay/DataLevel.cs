using UnityEngine;
using System.Collections;

public class DataLevel : SingletonBehaviour<DataLevel>
{
	public GameObject MainMenu;
	public GameObject VRTutor;
	public GameObject ARTutor;
	public GameObject GameTutor;
	public GameObject BackgroundMenu;
	public GameObject Interior_Img;
	public GameObject Background_for_explain;
	public GameObject P_About_App;
	public GameObject P_About_Company;
	public GameObject Back_To_First_Menu;
	public GameObject ARAlert;
    
    public GameObject ButtonBackPlay;
    public GameObject AR_Camera;

    public GameObject ALPS_Camera_Apartment;
    public GameObject Game_Camera_Apartment;

    public GameObject Apartment;
    public GameObject VR_Game_Parent;

    public GameObject Light_apartment_1;
    public GameObject Light_apartment_2;

    public GameObject ImgMarker;

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
		ARAlert.SetActive (false);
		Interior_Img.SetActive(false);
		Background_for_explain.SetActive (false);
		P_About_App.SetActive (false);
		P_About_Company.SetActive (false);
		Back_To_First_Menu.SetActive (false);
		      
		MainMenu.SetActive (false);
		VRTutor.SetActive (false);
		ARTutor.SetActive(false);
		GameTutor.SetActive (false);
        ButtonBackPlay.SetActive(false);
		BackgroundMenu.SetActive (false);

        AR_Camera.SetActive(false);
   
        ALPS_Camera_Apartment.SetActive(false);
        Game_Camera_Apartment.SetActive(false);
       
        Apartment.SetActive(false);
        //VR_Game_Parent.SetActive(false);
  
        Light_apartment_1.SetActive(false);
        Light_apartment_2.SetActive(false);

    }
    public void ChangedSate(Mark mark)
    {
        managerSateScreen.FindOut(mark);
       
    }
}
