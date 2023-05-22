using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerPosition : MonoBehaviour
{
    float playerPosX;
    List<GameObject> minions;
    public GameObject minionsPrefab;
    int index;
    protected float spawnTimer = 0f;
    protected float spawnDelay = 1f;

    private void Awake()
    {
        minionsPrefab.SetActive(false);
    }
    private void Start()
    {
        minions = new List<GameObject>();
    }
    // Start is called before the first frame update
    void Update()
    {
        /*this.playerPosX = transform.position.x;
        int spawnLoacation = 7;

        if (this.playerPosX >= spawnLoacation) this.spawn();*/
        this.spawn();
        checkMinionDead();

    }   

    void spawn() 
    {
        this.spawnTimer += Time.deltaTime;
        if (this.spawnTimer < this.spawnDelay) return;
        this.spawnTimer = 0;
        Debug.Log("thả bom");

        if (this.minions.Count >= 7) return;
        index += 1;
        //GameObject minion = new GameObject("Minion #" + index);
        GameObject minion = Instantiate(this.minionsPrefab, transform.position, Quaternion.identity);
        minion.name = "minionsPrefab #" + index;

        minion.gameObject.SetActive(true);

        this.minions.Add(minion);
    }

    void checkMinionDead()
    {
        GameObject minion;
        for(int i = 0; i < this.minions.Count; i++)
        {
            minion = this.minions[i];
            if(minion == null) this.minions.RemoveAt(i);
        }
    }

}
