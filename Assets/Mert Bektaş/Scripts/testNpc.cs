    using UnityEngine;

    public class testNpc : MonoBehaviour
{
    public TestData data;
    

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
