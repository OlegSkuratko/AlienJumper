using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratePlatform : MonoBehaviour
{
    public GameObject platformPrefab;       // змінна для префаба

    void Start()
    {
        Vector3 SpawnerPosition = new Vector3();    //новий вектор

        for (int i = 0; i < 15; i++)                // цикл For, який виконується 10 раз 
        {
            SpawnerPosition.x = Random.Range(-2.5f, 2.5f);  // позиція по осі х
            SpawnerPosition.y += Random.Range(1f, 3f);      // позиція по осі у 

            Instantiate(platformPrefab, SpawnerPosition, Quaternion.identity);  //  створення префабів
        }
    }

    void Update()
    {

    }
}