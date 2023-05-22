using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BombSpawner : Spawner
{
    //[Header("Bomb")]


    private void Reset()
    {
        this.spawnPosName = "BomSpawnPos";
        this.prefabName = "BomPrefab";
        this.maxObj = 7;
    }


    //protected override void Spawn()
    //{
    //    this.spawnTimer += Time.deltaTime;
    //    if (this.spawnTimer < this.spawnDelay) return;
    //    this.spawnTimer = 0;
    //    Debug.Log("thả bom");

    //    if (this.objects.Count >= 7) return;
    //    index += 1;
    //    GameObject minion = new GameObject("Minion #" + index);
    //    GameObject minion = Instantiate(this.objPrefab, this.SpawnPos.transform.position, Quaternion.identity);
    //    minion.name = "minionsPrefab #" + index;

    //    minion.gameObject.SetActive(true);

    //    this.objects.Add(minion);
    //}



}
