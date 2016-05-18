using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {

	// Use this for initialization

	public void StartGame () 
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	
	}
	
    public void QuitGame()
    {
        Debug.Log("The game Quit");
        Application.Quit();
    }
    public void Cancel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
	// Update is called once per frame
	void Update () {
	
	}
}
