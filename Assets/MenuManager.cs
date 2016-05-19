using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {

	// Use this for initialization
    public static bool SelectedSword;
    public static bool SelectedBow;
    public static bool SelectedMagic;

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
        SelectedSword = true;
        SelectedMagic = false;
        SelectedBow = false;
    }
    public void SelectBow()
    {
        //activeChar = BowGuy;
        SelectedBow = true;
        SelectedSword = false;
        SelectedMagic = false;
    }
    public void SelectMagic()
    {
        //activeChar = MagicGuy;
        SelectedMagic = true;
        SelectedBow = false;
        SelectedSword = false;
    }
	// Update is called once per frame
	void Update () {
	
	}
}
