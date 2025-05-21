using UnityEngine;
using UnityEngine.UI;

public class SendManager : MonoBehaviour
{
    public Image GameOverBar;
    public float barAmount = 100f;

    public void Send()
    {
        var data = UIManager.Instance.currentData;
        if (data != null && data.isOkay)
        {
            Debug.Log(data.isOkay);
            Debug.Log(data.name);
        }
        if (data!=null && !data.isOkay)
        {
            LoseTime(10);
        }
    }

    public void DontSend()
    {
        var data = UIManager.Instance.currentData;
        if (data != null && !data.isOkay)
        {
            Debug.Log(data.isOkay);
            Debug.Log(data.name);


        }
    }

    public void LoseTime(float lostAmount)
    {
        barAmount -= lostAmount;
        GameOverBar.fillAmount = barAmount / 100f;
    }
    public void Refill(float fillAmount)
    {
        barAmount += fillAmount;
        barAmount = Mathf.Clamp(barAmount, 0, 100);
        GameOverBar.fillAmount = barAmount / 100f;
    }
}
