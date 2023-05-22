using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageSender : MonoBehaviour
{
    [Header("DamageSender")]
    public int damage = 1;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        this.ColliderSendDamage(collision);
    }

    protected virtual void ColliderSendDamage(Collider2D collision)
    {
        //    if (collision.gameObject.CompareTag("Player"))
        //    {
        DamageReciever damageReciever = collision.GetComponent<DamageReciever>();
            if (damageReciever == null) return;
            damageReciever.Reciver(this.damage);
        //}
    }
}
