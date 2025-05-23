using UnityEngine;

public class IsNpcOnScreen : MonoBehaviour
{
    public bool isNpcOnScreen = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Npc"))
        {
            //Debug.Log("triggered");
            isNpcOnScreen = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Npc"))
        {
            Debug.Log("exit happened");
            isNpcOnScreen = false;
            
        }
    }
}
