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
    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void SelectSword()
    {
        //activeChar = SwordGuy;
    }
    public void SelectBow()
    {
        //activeChar = BowGuy;
    }
    public void SelectMagic()
    {
        //activeChar = MagicGuy;
    }
	// Update is called once per frame
	void Update () {
	
	}
}
