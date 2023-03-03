using System.Collections.Generic;
using UnityEngine;

public class PathfindManager : MonoBehaviour
{
    //열린 리스트 이건 가능성이 있는 리스트를 담아둔다.
    public List<Node> openList;
    //단힌 리스트 최종 목적지에 가능성이 없는 리스트를 담아둔다.
    public List<Node> closeList;
    //최종 완성된 최단 거리 리스트
    public List<Node> finalList;
    
    //초기 셋업
    private void Setup()
    {
        
    }

    //탐색하고 최종 FinalList를 만들어낼 함수
    private void Nameless()
    {
        openList = new List<Node>();

        //openList.Add()
        if(openList.Count > 0)
        {
            Node cur =  openList[0];
        }
    }

}