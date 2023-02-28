using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//서비스 역할
//보드의 생성 및 보드 관리를 서비스한다.
public class BoardManager : MonoBehaviour
{
    //생성할 보드판
    public GameObject boardPrefab;

    //보드판의 길이;
    public int MAX_X_SIZE;
    public int MAX_Y_SIZE;

    //보드의 정보를 담고있는 이차배열
    public Board[,] boards;

    //보드의 데이터 정보를 가지고있다.
    public int[,,] boardMaster;

    //[x,y,0] = 1이면 해당 타일은 몬스터를 생성하는 스포너가 된다.
    public const int SPAWN_BOARD = 0;


    public void Setup()
    {
        //보드 생성
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
