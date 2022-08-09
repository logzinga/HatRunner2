using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public void LoadNextLevel ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // This loads the next level in the queue
    }
}
