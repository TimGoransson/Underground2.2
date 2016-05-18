using UnityEngine;
using System.Collections;

public class ArrowCharStatus : MonoBehaviour {

	// Use this for initialization
    bool spawnBow = true;
    void Start()
    {
        if(GameObject.FindGameObjectWithTag("CharSelect").GetComponent<MenuManager>().SelectedBow == false)
        {
            Destroy(gameObject);
        }
    }
	void Awake () 
    {

	
	}
	// Update is called once per frame
	void Update () {
	
	}
}
