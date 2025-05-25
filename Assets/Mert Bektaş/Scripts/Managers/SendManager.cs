using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class SendManager : MonoBehaviour
{
    public GameObject losePanel;
    public Image GameOverBar;
    public float barAmount = 100f;

    void Update()
    {
        LoseGame();// I get lazy:(
    }
    // public void Send()
    // {
    //     var data = UIManager.Instance.currentData;
    //     GameObject npc = CurrentNpc.Instance?.currentNpc;
    //     Animator animator = npc.GetComponent<Animator>();


    //     if (data != null && data.isOkay)
    //     {
    //         Debug.Log(data.isOkay);
    //         Debug.Log(data.name);
    //         animator.SetTrigger("NpcApproved");
    //     }
    //     if (data != null && !data.isOkay)// yanlış kişiyi kişiyi geçirirsen 
    //     {
    //         LoseTime(20);
    //     }
    //     if (animator == null)
    //     {
    //         Debug.LogWarning("Animator bileşeni eksik.");
    //         return;
    //     }



    // }
    public void Send()
    {
        var data = UIManager.Instance.currentData;
        GameObject npc = CurrentNpc.Instance.currentNpc;
        Animator animator = npc.GetComponent<Animator>();

        if (data != null && data.isOkay)// doğru kişiyi geçirirsen
        {
            //Debug.Log(data.isOkay);
            //Debug.Log(data.name);
            animator.SetTrigger("NpcApproved");
        }
        else if (data != null && !data.isOkay)// YANLIŞ kişiyi geçirirsen
        {
            LoseTime(20);
            animator.SetTrigger("NpcApproved");
        }
    }


    public void DontSend()
    {
        GameObject npc = CurrentNpc.Instance.currentNpc;
        Animator animator = npc.GetComponent<Animator>();
        var data = UIManager.Instance.currentData;

        if (data != null && !data.isOkay)// yanlış kişiyi reddedersen
        {
            //Debug.Log(data.isOkay);
            animator.SetTrigger("NpcDenied");


        }
        else if (data != null && data.isOkay) //doğru kişiyi reddedersen
        {
            LoseTime(20);
            animator.SetTrigger("NpcDenied");
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

    public void LoseGame()
    {
        if (barAmount<=0f)
        {
            losePanel.SetActive(!losePanel.activeSelf);
        }
    }
}
