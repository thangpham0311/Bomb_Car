using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCtrl : MonoBehaviour
{
    public Despawner despawn;
    public EnemyDamageReciever damageReciever;
    private void Awake()
    {
        this.despawn = GetComponent<Despawner>();
        this.damageReciever = GetComponent<EnemyDamageReciever>();
    }
}
