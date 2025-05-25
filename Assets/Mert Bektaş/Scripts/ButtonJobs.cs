using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonJobs : MonoBehaviour
{
    public void ReturnToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void PlayAgain()
    {
        SceneManager.LoadScene("UITest");
    }
}
