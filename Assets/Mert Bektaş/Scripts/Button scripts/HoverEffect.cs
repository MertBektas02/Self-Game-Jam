using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
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
    private Button button;

    void Start()
    {
        originalScale = transform.localScale;
        targetScale = originalScale;
        button = GetComponent<Button>();
    }

    void Update()
    {
        transform.localScale = Vector3.Lerp(transform.localScale, targetScale, Time.deltaTime * animationSpeed);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (!IsTouchInput())
        {
            targetScale = originalScale * hoverScaleMultiplier;
            SoundManager.PlaySound(SoundType.ONHOVER); 
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (!IsTouchInput())
        {
            targetScale = originalScale;
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (IsTouchInput() && (button == null || button.interactable))
        {
            targetScale = originalScale * touchScaleMultiplier;
            SoundManager.PlaySound(SoundType.ONHOVER); 
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if (IsTouchInput())
        {
            targetScale = originalScale;
        }
    }

    private bool IsTouchInput()
    {
        return Input.touchCount > 0 || Application.isMobilePlatform;
    }
}
