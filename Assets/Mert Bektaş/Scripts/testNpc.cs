using UnityEngine;

public class testNpc : MonoBehaviour
{
    public TestData data;

    public void CLICKME()
    {
        UIManager.Instance.ShowNPCInfo(data);
    }
}
