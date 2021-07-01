using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WizardAttack : MonoBehaviour
{
    public float moveSpeed = 1.5f;

    void move()
    {
        float distanceY = moveSpeed * Time.deltaTime;
        this.gameObject.transform.Translate(0, -1 * distanceY, 0);

        if (gameObject.transform.position.y < -6.54f)
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }
}
