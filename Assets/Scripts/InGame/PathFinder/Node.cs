
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 길찾기를 위해 사용되는 기본 요소
/// </summary>
[System.Serializable]
public class Node  
{


    public bool isWall;
    public int H;
    public int G;
    public int F;
    

    private List<Node> neighborNode = new List<Node>();


    public void SetupNeighborNodes()
    {

    }

}
