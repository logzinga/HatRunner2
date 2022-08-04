using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool gameHasEnded = false;

    public float restartDelay = 3f;

    public GameObject completeLevelUI;

    public void CompleteLevel ()
    {
        Debug.Log("Level Completed Successfully");
        completeLevelUI.SetActive(true);
    }

    public void EndGame ()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Ending Game");
            Invoke("Restart", restartDelay);
        }
    }

    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}