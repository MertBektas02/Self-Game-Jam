using UnityEngine;

public class WinManager : MonoBehaviour
{
    public GameObject winPanel;
    private void OnEnable()
    {
        //CallManager.Instance._OnAllNpcsCalled += GameWin;
    }

    private void OnDisable()
    {
        //CallManager.Instance._OnAllNpcsCalled -= GameWin;
    }

    private void GameWin()
    {
        Debug.Log("Tüm NPC'ler çağrıldı. Oyunu kazandın!");

    }
    public void ToggleObject()
    {
        winPanel.SetActive(!winPanel.activeSelf);
    }
}
