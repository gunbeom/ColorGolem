using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnManager : MonoBehaviour
{
    public GameObject Enemy;

    void SpawnEnemy()
    {
        float randomX = Random.Range(-2.3f, 2.3f);

        GameObject enemy = (GameObject)Instantiate(Enemy, new Vector3(randomX, 5f, -1.15f), Quaternion.identity);

    }

    void Start()
    {
        InvokeRepeating("SpawnEnemy", 3, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
