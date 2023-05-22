using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamageReciever : DamageReciever
{
    protected PlayerCtrl playerCtrl;

    private void Awake()
    {
        this.playerCtrl = GetComponent<PlayerCtrl>();
    }
    //kế thừa
    public override void Reciver(int dame)
    {
        base.Reciver(dame);
        if (this.IsDead())
        {
            this.playerCtrl.playerStatus.Dead();
            UIManager.instance.bnGameOver.SetActive(true);
        }
    }    
}
