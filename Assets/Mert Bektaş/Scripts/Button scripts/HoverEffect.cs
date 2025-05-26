using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof(Button))] // Buton bileşeni gerektir (opsiyonel)
public class UniversalHoverEffect : MonoBehaviour,
    IPointerEnterHandler,
    IPointerExitHandler,
    IPointerDownHandler,
    IPointerUpHandler
{
    [SerializeField] private float hoverScaleMultiplier = 1.2f;
    [SerializeField] private float touchScaleMultiplier = 1.1f;
    [SerializeField] private float animationSpeed = 10f;
    private Vector3 originalScale;
    private Vector3 targetScale;
    private Button button; // Buton bileşeni (opsiyonel) 

    void Start()
    {
        originalScale = transform.localScale;
        targetScale = originalScale;
        button = GetComponent<Button>();
    }

    void Update()
    {
        // Yumuşak geçiş (Lerp)
        transform.localScale = Vector3.Lerp(transform.localScale, targetScale, Time.deltaTime * animationSpeed);
    }

    // ---- PC (Fare) Kontrolleri ----
    public void OnPointerEnter(PointerEventData eventData)
    {
        if (!IsTouchInput()) // Sadece fareyle çalışsın
        {
            targetScale = originalScale * hoverScaleMultiplier;
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (!IsTouchInput()) // Sadece fareyle çalışsın
        {
            targetScale = originalScale;
        }
    }

    // ---- Mobil (Dokunma) Kontrolleri ----
    public void OnPointerDown(PointerEventData eventData)
    {
        if (IsTouchInput() && (button == null || button.interactable)) // Dokunma ve buton etkinse
        {
            targetScale = originalScale * touchScaleMultiplier;
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if (IsTouchInput()) // Dokunma desteği
        {
            targetScale = originalScale;
        }
    }

    // Dokunma kontrolü (mobil mi?)
    private bool IsTouchInput()
    {
        return Input.touchCount > 0 || Application.isMobilePlatform;
    }
}


//standart Hover scriptim mobilde nasıl çalışır bilmiyorum, yapay zeka üstteki "mobil ile çalışan" versiyonu biraz çorba yaptı. 
//umarım build sonrası problem yaşatmaz.

// using UnityEngine;
// using UnityEngine.EventSystems; 
// using UnityEngine.UI; 


// //oha scale büyütme efektinin bir ismi varmış. pointer denen zımbırtı da çok pratikmiş.
// public class HoverEffect : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
// {
//     [SerializeField] private float hoverScaleMultiplier = 1.5f; 
//     private Vector3 originalScale; 

//     void Start()
//     {
//         originalScale = transform.localScale; 
//     }

//     // Mouse üzerine geldiğinde
//     public void OnPointerEnter(PointerEventData eventData)
//     {
//         transform.localScale = originalScale * hoverScaleMultiplier;
//     }

//     // Mouse üzerinden çekildiğinde
//     public void OnPointerExit(PointerEventData eventData)
//     {
//         transform.localScale = originalScale; // Orijinal boyuta dön
//     }
// }