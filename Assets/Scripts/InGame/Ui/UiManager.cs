using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Ui의 이벤트를 다른 배우들에게 알려주는 브릿지 역할을 담당
public class UiManager : MonoBehaviour
{
    public static UiManager Instance;

    public Button btnGameStart;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }

        Initalzie();
    }

    private void Initalzie()
    {
        //게임시작 버튼 초기화
        var canvas = GameObject.Find("Canvas");
        btnGameStart = canvas.transform.Find("BtnGameStart").GetComponent<Button>();
        btnGameStart.gameObject.SetActive(true);
        btnGameStart.onClick.AddListener(OnClickGameStart);



    }

    private void OnClickGameStart()
    {
        btnGameStart.gameObject.SetActive(false);
        GameManager.Instance.GameStart();
      
    }

}
