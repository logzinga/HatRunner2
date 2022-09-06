using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsNext : MonoBehaviour
{
    public void CreditsContinue ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // This loads the next level in the queue
    }

    public void CreditsQuit ()
    {
        Application.Quit();
    }
}
