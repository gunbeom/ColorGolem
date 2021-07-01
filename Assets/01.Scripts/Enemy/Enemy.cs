using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public float moveSpeed = 5f;

    float ylimit;

    SpriteRenderer sprite;

    Rigidbody2D rigid;

    public int colorNum;


    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();

        sprite = gameObject.GetComponent<SpriteRenderer>();

    }
  
    void Move()
    {
        float distanceY = moveSpeed * Time.deltaTime;
        this.gameObject.transform.Translate(0, -1 * distanceY, 0);
        
        if(gameObject.transform.position.y < -5.8f)
        {
            Destroy(gameObject);
        }
    }    

    void ChangeColor()
    {
        int GetOurColor = Random.Range(1, 4);

        if (GetOurColor == 1)
        {
            colorNum = 0;
            sprite.material.color = new Color(181 / 255f, 182 / 255f, 179 / 255f);
            colorNum = 1;
            
        }
        if(GetOurColor == 2)
        {
            colorNum = 0;
            sprite.material.color = new Color(165 / 255f, 247 / 255f, 0 / 255f);
            colorNum = 2;

        }
        if(GetOurColor == 3)
        {
            colorNum = 0;
            sprite.material.color = new Color(187 / 255f, 0 / 255f, 248 / 255f);
            colorNum = 3;
        }
    }

    public void Start()
    {
        ChangeColor();
        InvokeRepeating("ChangeColor", 1, 1);
    }

    public void Update()
    {
        Move();
    }

}
