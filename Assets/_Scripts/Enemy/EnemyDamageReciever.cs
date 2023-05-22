using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamageReciever : DamageReciever
{
    //[Header("Enemy")]
    public EnemyCtrl enemyCtrl;
    private void Awake()
    {
        enemyCtrl = GetComponent<EnemyCtrl>();
    }

    private void Reset()
    {
        this.hp = 3;
    }
    public override void Reciver(int dame)
    {
        base.Reciver(dame);
        if (this.IsDead())
        {
            EffectManager.instance.SpawnVFX("Explosion_A", transform.position, transform.rotation);
            enemyCtrl.despawn.Despawn();
        } 
    }

}
