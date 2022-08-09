using UnityEngine;

public class EndTrigger : MonoBehaviour
{

    public GameManager gameManager;

    void OnTriggerEnter ()
    {
        gameManager.CompleteLevel();        // when the player hits the End Block
    }
}
