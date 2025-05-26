using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonJobs : MonoBehaviour
{
    [Header("Panels")]
    public GameObject infoOnePanel;
    public GameObject infoTwoPanel;
    public GameObject infoThreePanel;
    public GameObject rulesMainPanel;
    public void ReturnToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void PlayAgain()
    {
        SceneManager.LoadScene("UITest");
    }

    public void ToggleRulesMainPanel()
    {
        rulesMainPanel.SetActive(!rulesMainPanel.activeSelf);
        
    }
    public void ToggleInfoOnePanel()
    {
        infoOnePanel.SetActive(!infoOnePanel.activeSelf);
        if (infoOnePanel.activeSelf)
        infoOnePanel.transform.SetAsLastSibling(); //main panelin yaızı üstte gözüküyordu. Çözüm olarak bunu buldum.
        
    }

    public void CloseInfoOnePanel()
    {
        infoOnePanel.SetActive(!infoOnePanel.activeSelf);
    }

    public void ToggleInfoTwoPanel()
    {
        infoOnePanel.SetActive(!infoTwoPanel.activeSelf);
        if (infoOnePanel.activeSelf)
        infoOnePanel.transform.SetAsLastSibling();
    }
    public void ToggleInfoThreePanel()
    {
        infoThreePanel.SetActive(!infoThreePanel.activeSelf);
        if (infoOnePanel.activeSelf)
        infoOnePanel.transform.SetAsLastSibling();
    }
}
