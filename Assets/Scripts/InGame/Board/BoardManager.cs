using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//���� ����
//������ ���� �� ���� ������ �����Ѵ�.
public class BoardManager : MonoBehaviour
{
    //������ ������
    public GameObject boardPrefab;

    //�������� ����;
    public int MAX_X_SIZE;
    public int MAX_Y_SIZE;

    //������ ������ ����ִ� �����迭
    public Board[,] boards;

    //������ ������ ������ �������ִ�.
    public int[,,] boardMaster;

    //[x,y,0] = 1�̸� �ش� Ÿ���� ���͸� �����ϴ� �����ʰ� �ȴ�.
    public const int SPAWN_BOARD = 0;


    public void Setup()
    {
        //���� ����
        boards = new Board[MAX_X_SIZE, MAX_Y_SIZE];
        for (int y =0; y < MAX_Y_SIZE; y++)
        {
            for (int x = 0; x < MAX_X_SIZE; x++)
            {
               var go  = Instantiate(boardPrefab) as GameObject;
               go.transform.position = new Vector3(x, 0, y);
               boards[x,y] =  go.AddComponent<Board>();
            }
        }
    }

}
