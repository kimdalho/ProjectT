using UnityEngine;
public abstract class BaseToy : MonoBehaviour
{
    public MonsterData info;

    

    public virtual void Setup()
    {
        gameObject.name = info.name;
    }

}