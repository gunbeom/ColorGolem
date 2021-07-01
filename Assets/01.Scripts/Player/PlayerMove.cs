using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class PlayerMove : MonoBehaviour
{

    float xPosition;

    SpriteRenderer sprite;

    Rigidbody2D rigid;

    public static int colorNum;

    public Color gray = new Color(181 / 255f, 182 / 255f, 179 / 255f);
    public Color green = new Color(165 / 255f, 247 / 255f, 0 / 255f);
    public Color purple = new Color(187 / 255f, 0 / 255f, 248 / 255f);

    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        sprite = gameObject.GetComponent<SpriteRenderer>();

        sprite.material.color = new Color(181 / 255f, 182 / 255f, 179 / 255f);
        colorNum = 1;
    }

    void Move()
    {
        xPosition = Mathf.Clamp(transform.position.x, -2.3f, 2.3f);

        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = new Vector2(xPosition - 3f * Time.deltaTime, transform.position.y);
            sprite.flipX = false;
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = new Vector2(xPosition + 3f * Time.deltaTime, transform.position.y);
            sprite.flipX = true;
        }
    }

    public void ChangeColor()
    {
        if(Input.GetKeyDown(KeyCode.Z))
        {
            colorNum = 0;
            sprite.material.DOColor(gray, 0.3f);
            colorNum = 1;

        }
        if(Input.GetKeyDown(KeyCode.X))
        {
            colorNum = 0;
            sprite.material.DOColor(green, 0.3f);
            colorNum = 2;

        }
        if(Input.GetKeyDown(KeyCode.C))
        {
            colorNum = 0;
            sprite.material.DOColor(purple, 0.3f);
            colorNum = 3;

        }
        
    }

    void Update()
    {
        Move();

        ChangeColor();
    }
}
