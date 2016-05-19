using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	// Use this for initialization
    
	void Start () 
    {
	    if(MenuManager.SelectedSword == true)
        {
            GameObject SwordInventory = (GameObject)Instantiate(Resources.Load("Invetory and crafting 1"));
            GameObject HPMANACanvas = (GameObject)Instantiate(Resources.Load("HPMANACanvas"));
            GameObject Sword = (GameObject)Instantiate(Resources.Load("SwordGuy")); 
        }
        if (MenuManager.SelectedBow == true)
        {
            //GameObject HPMANACanvas = (GameObject)Instantiate(Resources.Load("HPMANACanvas"));
            //GameObject SwordInventory = (GameObject)Instantiate(Resources.Load("Invetory and crafting 1"));
            GameObject Bow = (GameObject)Instantiate(Resources.Load("Player"));
        }
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}
}
