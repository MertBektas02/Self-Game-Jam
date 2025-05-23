using UnityEngine;

public class CurrentNpc : MonoBehaviour
{
    public GameObject currentNpc { get; private set; }
public static CurrentNpc Instance { get; private set; }
    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject); 
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Npc"))
        {
            currentNpc = other.gameObject;
            Debug.Log("trigger aktif" + currentNpc);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Npc")&& other.gameObject==currentNpc)
        {
            currentNpc =null;
        }  
    }
}
