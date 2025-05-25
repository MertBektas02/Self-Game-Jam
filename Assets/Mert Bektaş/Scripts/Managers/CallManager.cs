using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CallManager : MonoBehaviour
{
    public static CallManager Instance { get; private set; }
    [SerializeField] private List<GameObject> npcList;
    [SerializeField] private Transform triggerPosition;

    private List<GameObject> availableNpcs = new List<GameObject>();

    //public delegate void OnAllNpcsCalled();
    //public event OnAllNpcsCalled _OnAllNpcsCalled; //event kullanmamaya karar verdim. 
    [SerializeField] private IsNpcOnScreen screenChecker;
    [SerializeField] private GameObject winPanel;

    private void Start()
    {
        availableNpcs = new List<GameObject>(npcList);

    }




    public void CallRandomNpc()
    {
        if (screenChecker.isNpcOnScreen) return;

        GameObject selectedNPC = GetRandomNpc();

        if (selectedNPC != null && triggerPosition != null)
        {

            selectedNPC.transform.position = triggerPosition.position;
        }
    }



    private GameObject GetRandomNpc()
    {
        if (availableNpcs.Count == 0)
        {
            //Debug.Log("Tüm NPC'ler çağrıldı.");
            return null;
        }

        int index = Random.Range(0, availableNpcs.Count);
        GameObject selectedNPC = availableNpcs[index];
        availableNpcs.RemoveAt(index);

        //Debug.Log("NPC seçildi: " + selectedNPC.name);

        //win condiition
        if (availableNpcs.Count == 0)
        {
            ToggleWinUI();
        }

        return selectedNPC;
    }

    public void ToggleWinUI()
    {
        winPanel.SetActive(!winPanel.activeSelf);
    }
}
