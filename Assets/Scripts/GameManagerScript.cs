using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    // Start is called before the first frame update
    bool gameEnd = false;
    [SerializeField] GameObject completeUI;
    [SerializeField] MovementScript movementScript;
    public void EndGame()
    {
        if (gameEnd == false)
        {
            gameEnd = true;
            Debug.Log("You Lose...");
            Invoke("Restart", 0.8f);
        }
    }

    public void CompleteGame()
    {
        movementScript.enabled = false;
        completeUI.SetActive(true);
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
