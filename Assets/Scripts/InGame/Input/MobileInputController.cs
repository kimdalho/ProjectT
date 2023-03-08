using UnityEngine;
using UnityEngine.EventSystems;


public class MobileInputController : MonoBehaviour,IBeginDragHandler,IDragHandler,IEndDragHandler,IPointerDownHandler,IPointerUpHandler {

    public GameObject JoyStick;

    public RectTransform Background;
    public RectTransform Knob;

    [Header("Input Values")]
    public float Horizontal = 0;
    public float Vertical = 0;

    public float offset;
    Vector2 PointPosition;
    bool isControlling = false;
    bool IsControlling
    {
        get
        {
            return isControlling;
        }
        set
        {
            isControlling = value;
            JoyStick.SetActive(value);
        }
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if(!IsControlling)
        {
            //최초 클릭 위치로 배치하기
            IsControlling = true;
            JoyStick.transform.position = eventData.position;
        }
        else
        {
            OnDrag(eventData);
        }
    }

    public void OnPointerUp(PointerEventData eventData) 
    {
        IsControlling = false;

        OnEndDrag(eventData);
    }

    private void Start()
    {
        JoyStick.SetActive(false);
    }

    // Update is called once per frame
    void Update () 
    {
        Horizontal = PointPosition.x;
        Vertical = PointPosition.y;
    }

    public void OnDrag(PointerEventData eventData)
    {
        //해당 위치를 중심으로 Knob 오브젝트 이동
        PointPosition = new Vector2((eventData.position.x - Background.position.x) / ((Background.rect.size.x - Knob.rect.size.x) / 2), (eventData.position.y - Background.position.y) / ((Background.rect.size.y - Knob.rect.size.y) / 2));
        PointPosition = (PointPosition.magnitude > 1.0f) ? PointPosition.normalized : PointPosition;
        Knob.transform.position = new Vector2((PointPosition.x * ((Background.rect.size.x - Knob.rect.size.x) / 2) * offset) + Background.position.x, (PointPosition.y * ((Background.rect.size.y - Knob.rect.size.y) / 2) * offset) + Background.position.y);
    }

    public  void OnEndDrag(PointerEventData eventData)
    {
        //위치 초기화
        PointPosition = new Vector2(0f, 0f);
        Knob.transform.position = Background.position;
    }
}
