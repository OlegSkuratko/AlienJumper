﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float forceJump;                                                    // змінна для сили стрибка

    public void OnCollisionEnter2D(Collision2D collision)         
    {
        if (collision.relativeVelocity.y < 0)                                // якщо швидкість менше 0
        {
            Alien.instance.AlienRigid.velocity = Vector2.up * forceJump;  // добавляєм стрибок до змінної із скрипта "Alien"
        }
    }

    public void OnCollisionExit2D(Collision2D collision)            
    {
        if (collision.collider.name == "DeadZone")                  // якщо змінна зіткнулась з обєктом під назвою DeadZone
        {
            float RandX = Random.Range(-1.7f, 1.7f);                                              // то задаємо нову позицію  по х
            float RandY = Random.Range(transform.position.y + 20f, transform.position.y + 22f);   // и нову позицію по у

            transform.position = new Vector3(RandX, RandY, 0);      // переміщаємо обєкт по заданих координатах
        }
    }


}
