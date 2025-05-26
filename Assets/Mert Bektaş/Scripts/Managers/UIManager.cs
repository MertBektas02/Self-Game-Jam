using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
public static UIManager Instance;

    [Header("UI References")]
    //public GameObject npcPanel;
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI idText;
   
    public TextMeshProUGUI npcCountryText;
    public TextMeshProUGUI npcJob;
    public TextMeshProUGUI npcExperienceText;
    public TextMeshProUGUI npcEducation;
    public TextMeshProUGUI jobLevelText;
    public TextMeshProUGUI ncpDialog;
    public NpcData currentData;
    public Image idPhoto; 
    // npcData nın sprite, ekrandaki tarafın da image olması gerekliymiş. //npcdata görsel verisini tutuyor //UIManager'deki Image resmi ekrana yansıtıyor.
    //biraz çorba yaptım.
    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    public void ShowNPCInfo(NpcData data)
    {
        currentData = data;
        nameText.text = data.name;
        idText.text = data.npcID;
        npcCountryText.text = data.npcCountry;
        npcJob.text = data.npcJob;
        
        
        npcExperienceText.text = data.experienceYears;
        npcEducation.text = data.npcEducation;
        jobLevelText.text = data.jobLevel;
        idPhoto.sprite = data.photo;

        ncpDialog.text = data.npcPurposeDialog;

        //npcPanel.SetActive(true);
    }

    // public void HideNPCInfo()
    // {
    //     currentData = null;
    //     npcPanel.SetActive(false);
    // }
}
