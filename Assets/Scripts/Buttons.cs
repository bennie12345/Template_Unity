using UnityEngine;
using System.Collections;

public class Buttons : MonoBehaviour {

    public void PlayGame()
    {
        AutoFade.LoadLevel("Game", 3, 1, Color.black);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void MainMenu() 
    {
        Application.LoadLevel("Menu");
    }
}
