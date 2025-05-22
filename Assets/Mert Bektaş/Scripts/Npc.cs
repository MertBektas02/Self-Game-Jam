    using UnityEngine;

    public class Npc : MonoBehaviour
{
    public NpcData data;
    

    public void CLICKME()
    {
        UIManager.Instance.ShowNPCInfo(data);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (CompareTag("Player"))
        {
            UIManager.Instance.ShowNPCInfo(data);
            //Debug.Log(data.isOkay);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (CompareTag("Player"))
        {
            UIManager.Instance.HideNPCInfo();
            
        }
    }
}
