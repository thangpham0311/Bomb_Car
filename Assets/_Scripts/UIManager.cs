using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject bnGameOver;
    static public UIManager instance;

    private void Awake()
    {
        UIManager.instance = this;
        this.bnGameOver = GameObject.Find("BnGameOver");
        this.bnGameOver.SetActive(false);
    }
}
