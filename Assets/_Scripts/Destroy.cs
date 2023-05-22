using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Destroy1", 10f);
    }

    void Destroy1 ()
    {
        Destroy(gameObject);
    }

}
