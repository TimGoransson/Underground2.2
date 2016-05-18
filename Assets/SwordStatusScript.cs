using UnityEngine;
using System.Collections;

public class SwordStatusScript : MonoBehaviour {

	// Use this for initialization
    void Start()
    {
        if (GameObject.FindGameObjectWithTag("CharSelect").GetComponent<MenuManager>().SelectedSword == false || GameObject.FindGameObjectWithTag("CharSelect").GetComponent<MenuManager>().SelectedSword == null)
        {
            Destroy(gameObject);
        }
    }
	// Update is called once per frame
	void Update () {
	
	}
}
