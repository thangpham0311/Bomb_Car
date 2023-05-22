using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageReciever : MonoBehaviour
{
    [Header("DamageReciever")]
    public int hp = 1;
    public virtual void Reciver(int dame)
    {
        this.hp -= dame;
    }
    public virtual bool IsDead()
    {
        return this.hp <= 0;
    }

}
