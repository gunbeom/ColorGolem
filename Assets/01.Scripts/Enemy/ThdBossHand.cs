using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThdBossHand : MonoBehaviour
{
    public GameObject hand;
    public GameObject warningimg;
    void SpawnEnemy()
    {
        float randomX = Random.Range(-2.3f, 2.3f);
        hand.SetActive(true);
        GameObject enemy = (GameObject)Instantiate(hand, new Vector3(randomX, -4.8f, -1.15f), Quaternion.identity);
    }
    void Start()
    {
        hand.SetActive(false);
        InvokeRepeating("SpawnEnemy", 4, 4f);
    }

    void Update()
    {
        
    }
}
