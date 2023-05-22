using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    protected PlayerCtrl playerCtrl;

    private void Awake()
    {
        this.playerCtrl = GetComponent<PlayerCtrl>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public virtual void Dead()
    {
        Debug.Log("Dead");
    }
}
