using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//������ ���� ���� ��������
public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public SpawnerManager spawnerMgr;
    public BoardManager boardMgr;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }

        //�ʱ�ȭ ���ӽ��۰� ������� ����
        Initalize();
    }

    private void Initalize()
    {
        //����Ŵ��� �ʱ�ȭ
        boardMgr.Setup();
    }
    

    //���� ���� ��ư�� ������ �� ȣ��
    public void GameStart()
    {
        //���� ����
        spawnerMgr.StartWave();
        
    }


   
    

}
