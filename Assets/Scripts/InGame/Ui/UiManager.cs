using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Ui�� �̺�Ʈ�� �ٸ� ���鿡�� �˷��ִ� �긴�� ������ ���
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
        //���ӽ��� ��ư �ʱ�ȭ
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
