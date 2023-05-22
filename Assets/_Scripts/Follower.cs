using Mono.Cecil.Cil;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Follower : MonoBehaviour
{
    public Transform player;
    // Start is called before the first frame update
    public float speed = 27f;
    public float disLimit = 6f;
    public float randPos = 0;

    private void Awake()
    {
        this.player = PlayerCtrl.instance.transform;

        this.randPos = Random.Range(-6,6);
    }

    // Update is called once per frame
     private void FixedUpdate()
    {
        // Invoke sau 1 khoảng thời gian thì hàm follow sẽ chạy theo
        //Invoke("follow", 1f);
        follow();
    }

    void follow()
    {
        Vector3 pos = this.player.position;
        pos.x = this.randPos;
        // enemy theo player
        Vector3 distance = pos - transform.position;

        if (distance.magnitude >= this.disLimit)
        {
            Vector3 targetPoint = pos - distance.normalized * this.disLimit;
            gameObject.transform.position =
                Vector3.MoveTowards(gameObject.transform.position, targetPoint, this.speed * Time.fixedDeltaTime);
        }

    }
}
