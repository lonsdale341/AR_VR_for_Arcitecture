using UnityEngine;
using System.Collections;

public class DataLevel : SingletonBehaviour<DataLevel>
{

    public GameObject Screen_MainMenu;
	public GameObject AR_tutorial;
	public GameObject VR_tutorial;
	public GameObject Game_tutorial;
	public GameObject Image_background;
	public GameObject Image_city_roll;
	public GameObject Menu_first_page;
	public GameObject Menu_about_us;
	public GameObject Img_road;
	public GameObject Button_back_first_menu;

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
		Img_road.SetActive (false);
        Screen_MainMenu.SetActive(false);
		AR_tutorial.SetActive (false);
		VR_tutorial.SetActive (false);
		Game_tutorial.SetActive (false);
		Image_background.SetActive (false);
		Image_city_roll.SetActive (false);
		Menu_about_us.SetActive (false);
		Menu_first_page.SetActive (false);
	
		Button_back_first_menu.SetActive (false);

        ButtonBackPlay.SetActive(false);
        AR_Camera.SetActive(false);
        ALPS_Camera_District.SetActive(false);
        Game_Camera_District.SetActive(false);
		Panorama.SetActive (false);
        City.SetActive(false);

      

    }
    public void ChangedSate(Mark mark)
    {
        managerSateScreen.FindOut(mark);
       
    }
}
