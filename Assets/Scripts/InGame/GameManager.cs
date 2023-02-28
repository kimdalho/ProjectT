using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//게임의 생성 게임 ㅔ이터의
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

        //초기화 게임시작과 관계없이 실행
        Initalize();
    }

    private void Initalize()
    {
        //보드매니저 초기화
        boardMgr.Setup();
    }
    

    //게임 시작 버튼이 눌렸을 시 호출
    public void GameStart()
    {
        //몬스터 생성
        spawnerMgr.StartWave();
        
    }


   
    

}
