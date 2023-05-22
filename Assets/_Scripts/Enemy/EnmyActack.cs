using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnmyActack : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // check xem có phải object Enmy không
        if (collision.gameObject.CompareTag("Enmy"))
        {
            Destroy(gameObject);
        }
    }
}
