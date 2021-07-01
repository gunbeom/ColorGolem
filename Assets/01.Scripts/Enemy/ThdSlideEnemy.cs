using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ThdSlideEnemy : MonoBehaviour
{
    float ylimit;
    bool isMoved = false;

    public GameObject targetPosition1;
    public GameObject targetPosition2;
    public GameObject targetPosition3;
    public GameObject targetPosition4;
    Vector3 vel = Vector3.zero;
    public int pointNum;

    Rigidbody2D rigid;

    void Start()
    {
        gameObject.transform.rotation = Quaternion.Euler(0, 0, 180);
        rigid = GetComponent<Rigidbody2D>();
        pointNum = Random.Range(1, 5);
    }

    void ChangeBool()
    {
        isMoved = true;
    }

    void Slide()
    {
        
        if(pointNum == 1)
        {
            transform.position = Vector3.SmoothDamp(gameObject.transform.position, targetPosition1.transform.position, ref vel, 1f);
        }
        else if(pointNum == 2)
        {
            transform.position = Vector3.SmoothDamp(gameObject.transform.position, targetPosition2.transform.position, ref vel, 1f);
        }
        else if (pointNum == 3)
        {
            transform.position = Vector3.SmoothDamp(gameObject.transform.position, targetPosition3.transform.position, ref vel, 1f);
        }
        else if (pointNum == 4)
        {
            transform.position = Vector3.SmoothDamp(gameObject.transform.position, targetPosition4.transform.position, ref vel, 1f);
        }
    }
    // 랜덤 숫자를 뽑아와서 그 숫자를 시드로 타겟 포인트를 잡음

    void Move()
    {
        if(isMoved == true)
        {
            rigid.gravityScale = 3f;
            if (gameObject.transform.position.y < -5.8f)
            {
                Destroy(gameObject);
            }   
        }
    }

    // Update is called once per frame
    void Update()
    {
        Slide();
        Move();
        Invoke("ChangeBool", 1f);
    }
}
