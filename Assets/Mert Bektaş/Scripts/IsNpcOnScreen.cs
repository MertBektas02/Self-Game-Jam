using UnityEngine;

public class IsNpcOnScreen : MonoBehaviour
{
    public bool isNpcOnScreen = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Npc"))
        {
            isNpcOnScreen = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Npc"))
        {
            isNpcOnScreen = false;
            
        }
    }
}
