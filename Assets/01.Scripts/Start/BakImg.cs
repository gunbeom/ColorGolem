using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BakImg : MonoBehaviour
{
    Transform backPos;
    public float speed = 50f;

    public GameObject backImg;

    public void Rotate()
    {

    }

    void Start()
    {
        backPos = backImg.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        backPos.Rotate(new Vector3(0,0, speed * Time.deltaTime));
    }
}
