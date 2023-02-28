using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Monster Data", menuName = "Scriptable Object/Monster Data", order = int.MaxValue)]
public class MonsterData : ScriptableObject
{
    public int id;
    public string _name;
    public int hp;
    public int damage;
    //시야범위
    public float sightRange;
    //이동속도
    public float moveSpeed;
    //대상 프리펩
    public GameObject modelPrefab;

}
