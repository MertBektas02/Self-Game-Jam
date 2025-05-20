using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
public static UIManager Instance;

    [Header("UI References")]
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI idText;
    public GameObject npcPanel;
    public TestData currentData;

    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    public void ShowNPCInfo(TestData data)
    {
        currentData = data;
        nameText.text = data.name;
        idText.text = data.npcID;
        npcPanel.SetActive(true);
    }

    public void HideNPCInfo()
    {
        currentData = null;
        npcPanel.SetActive(false);
    }
}
