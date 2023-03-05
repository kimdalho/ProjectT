using System.Collections;
using System.Collections.Generic;
using System.Linq;
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

    //������ ������ ����ִ� �����迭(x,z)
    public Board[,] boards;

    //������ ������ ������ �������ִ�.
    public int[,,] boardMaster;

    public List<Board> spawnerBatchList = new List<Board>();


    //������ �Ӽ����� �����ϴ� 3�� �迭�̴�
    [Header("Layer")]
    //[x,y,0] = 1�̸� �ش� Ÿ���� ���� �ȴ�
    public const int Wall_Layer = 0;
    public void Setup()
    {
        //������ ����
        CreateBoard();
        //�̵��ϴ� �� �����
        CreateLoad();   
    }

    private void CreateBoard()
    {
        
        boards = new Board[MAX_X_SIZE, MAX_Y_SIZE];

        for (int y = 0; y < MAX_Y_SIZE; y++)
        {
            for (int x = 0; x < MAX_X_SIZE; x++)
            {
                var go = Instantiate(boardPrefab) as GameObject;
                go.transform.position = new Vector3(x, 0, y);
                boards[x, y] = go.AddComponent<Board>();
                go.name = $"{x},{y}";
            }
        }
    }

    private void CreateLoad()
    {
        for (int y = 0; y < MAX_Y_SIZE; y++)
        {
            var mesh = boards[4, y].GetComponent<MeshRenderer>();
            mesh.material.color = Color.red;
        }


        for (int x = 0; x < MAX_X_SIZE / 2; x++)
        {
            var mesh = boards[x,2].GetComponent<MeshRenderer>();
            mesh.material.color = Color.red;
        }

        for (int x = 5; x < MAX_X_SIZE ; x++)
        {
            var mesh = boards[x, 5].GetComponent<MeshRenderer>();
            mesh.material.color = Color.red;
        }



    }


}
