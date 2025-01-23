using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BG : MonoBehaviour
{
    public int kecepatan;
    public float batasan;

    Vector2 posisiAwal;
    void Start()
    {
        posisiAwal = transform.position;
    }

    
    void Update()
    {
        transform.Translate(kecepatan,0,0);

        if(transform.position.x < batasan)
        {
            transform.position = posisiAwal;
        }
    }
}
