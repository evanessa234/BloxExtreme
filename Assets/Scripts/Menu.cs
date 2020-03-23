using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1 );

    }

    public void Ouit()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }

    public void RestartQuit()
    {
        Debug.Log("RESTART QUIT");
        SceneManager.LoadScene("Credits");
    }

    public void Restart()
    {
        SceneManager.LoadScene("Menu");

    }
}
