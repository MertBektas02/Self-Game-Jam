using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonMethods : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("UITest");
    }
}
