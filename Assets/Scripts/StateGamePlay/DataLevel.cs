﻿using UnityEngine;
using System.Collections;

public class DataLevel : SingletonBehaviour<DataLevel>
{

    public GameObject Screen_MainMenu;
    public GameObject Screen_solution_Overview;
    public GameObject ButtonBackPlay;
    public GameObject AR_Camera;
    public GameObject ALPS_Camera;
    public GameObject Game_Camera;
    public GameObject City;
    public GameObject VR_Game_Parent;
    public GameObject Light_City;
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
        Screen_MainMenu.SetActive(false);
        Screen_solution_Overview.SetActive(false);
        ButtonBackPlay.SetActive(false);
        AR_Camera.SetActive(false);
        ALPS_Camera.SetActive(false);
        Game_Camera.SetActive(false);
        City.SetActive(false);
        //VR_Game_Parent.SetActive(false);
        Light_City.SetActive(false);
        

    }
    public void ChangedSate(Mark mark)
    {
        managerSateScreen.FindOut(mark);
       
    }
}
