using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    static public PlayerCtrl instance;
    public DamageReciever damageReciever;
    public PlayerStatus   playerStatus;

    private void Awake()
    {
        PlayerCtrl.instance = this;

        this.damageReciever = GetComponent<DamageReciever>();
        this.playerStatus = GetComponent<PlayerStatus>();
    }
}
