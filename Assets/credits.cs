
using UnityEngine;
using UnityEngine.SceneManagement;

public class credits : MonoBehaviour
{
    // Start is called before the first frame update
    public void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
