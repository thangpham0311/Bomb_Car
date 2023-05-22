using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header("Spawner")]
    public GameObject objPrefab;
    public GameObject SpawnPos;
    public List<GameObject> objects;
    public float spawnTimer = 0f;
    public float spawnDelay = 1f;
    public string spawnPosName = "";
    public string prefabName = "";
    public int maxObj = 1;

    private void Awake()
    {
        this.objects = new List<GameObject>();
        this.SpawnPos = GameObject.Find(this.spawnPosName);
        this.objPrefab = GameObject.Find(this.prefabName);
        this.objPrefab.SetActive(false);
    }

    private void Update()
    {
        this.Spawn();
        this.checkDead();
    }

    protected virtual void Spawn()
    {
        if (PlayerCtrl.instance.damageReciever.IsDead()) return;
        if (this.objects.Count >= this.maxObj) return;


        // Thời gian sinh ra enemy
        this.spawnTimer += Time.deltaTime;
        if (this.spawnTimer < this.spawnDelay) return;
        this.spawnTimer = 0;
        // code sinh ra enemy ở tại vị trí của của enemy
        GameObject enemy = Instantiate(this.objPrefab);
        enemy.transform.position = this.SpawnPos.transform.position;
        // tạo những object con trong object cha
        enemy.transform.parent = transform;
        enemy.SetActive(true);

        this.objects.Add(enemy);
    }
    protected virtual void checkDead()
    {
        GameObject minion;
        for (int i = 0; i < this.objects.Count; i++)
        {
            minion = this.objects[i];
            if (minion == null) this.objects.RemoveAt(i);
        }
    }
}
