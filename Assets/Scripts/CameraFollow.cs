﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;     // позиція героя

    void Update()
    {
        if (target.position.y > transform.position.y)    // якщо позиція героя більша за позицію камери
        {
                // то позиція камери прирівнюється до позиції нашого героя
            transform.position = new Vector3(transform.position.x, target.position.y, transform.position.z);
        }
    }
}