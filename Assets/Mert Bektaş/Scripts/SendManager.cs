using UnityEngine;
using UnityEngine.UI;

public class SendManager : MonoBehaviour
{
    public void Send()
    {
        var data = UIManager.Instance.currentData;
        if (data!=null && data.isOkay)
        {
            Debug.Log(data.isOkay);
            Debug.Log(data.name);
            Debug.Log(data.npcID);
            Debug.Log("NPC were SEND.");
        }
        
    }

    public void DontSend()
    {
        var data = UIManager.Instance.currentData;
        if (data != null && !data.isOkay)
        {
            Debug.Log(data.isOkay);
            Debug.Log(data.name);
            Debug.Log(data.npcID);
            Debug.Log("NPC DENIED");

        }
    }
}
