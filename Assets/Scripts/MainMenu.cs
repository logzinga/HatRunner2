using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame ()
    {
        SceneManager.LoadScene("Level01"); // This makes the PLAY Button actually work
    }

    public void QuitGame ()
    {
        Debug.Log("Quitting..."); // quits the game.
        Application.Quit();
    }

}
