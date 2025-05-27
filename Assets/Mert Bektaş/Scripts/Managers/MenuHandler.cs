using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuHandler : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("UITest");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
