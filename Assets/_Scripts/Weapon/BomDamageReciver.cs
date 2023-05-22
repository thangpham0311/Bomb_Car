using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BomDamageReciver : DamageReciever
{
    //[Header("Enemy")]

    private void Reset()
    {
        this.hp = 1;
    }
    public override void Reciver(int dame)
    {
        base.Reciver(dame);
        if (this.IsDead())
        {
            EffectManager.instance.SpawnVFX("Explosion_B",transform.position,transform.rotation );
            Destroy(gameObject);
        }
    }
}
