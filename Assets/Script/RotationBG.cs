using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationBG : MonoBehaviour
{
    public float rotateSpeed = 1.0f;
    
    void Update()
    {
        this.transform.Rotate(0,0,rotateSpeed, Space.World);
    }
}
