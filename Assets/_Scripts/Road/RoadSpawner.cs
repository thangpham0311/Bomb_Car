using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class RoadSpawner : MonoBehaviour
{
    [SerializeField] protected GameObject roadPrefab;
    [SerializeField] protected GameObject roadSpawnPos;

    protected float distance = 0;

    public GameObject roadCurrent;
    private void Awake()
    {
        roadPrefab = GameObject.Find("RoadPrefab");
        roadSpawnPos = GameObject.Find("RoadSpawnPos");

        this.roadPrefab.SetActive(false);

        //this.roadCurrent = this.roadPrefab;

        this.Spawn(this.roadPrefab.transform.position);
    }

    private void FixedUpdate()
    {
        this.UpdateRoad();
    }

    protected virtual void UpdateRoad()
    {
        this.distance = Vector2.Distance(PlayerCtrl.instance.transform.position, this.roadCurrent.transform.position);
        if (this.distance > 40) this.Spawn();
    }

    protected virtual void Spawn()
    {
        Vector3 pos = this.roadSpawnPos.transform.position;
        pos.x = 0;

        this.Spawn(pos);

        //this.roadCurrent = Instantiate(this.roadPrefab, pos, this.roadPrefab.transform.rotation);
        //this.roadPrefab.SetActive(true);

    }

    protected virtual void Spawn(Vector3 position)
    {
        this.roadCurrent = Instantiate(this.roadPrefab, position, this.roadPrefab.transform.rotation);
        this.roadCurrent.transform.parent = transform;
        this.roadCurrent.SetActive(true);
    }
}
