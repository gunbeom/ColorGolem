using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlayerCol : MonoBehaviour
{
    Rigidbody2D rigid;
    
    public GameObject overPanel;
    AudioSource audioSource;

    void Awake()
    {
        audioSource = this.gameObject.GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Enemy")
        {
            var enemy = col.GetComponent<Enemy>();

            if(enemy.colorNum != PlayerMove.colorNum)
            {
                Destroy(gameObject);    
                overPanel.SetActive(true);
                Time.timeScale = 0;
            }
            else if(enemy.colorNum == PlayerMove.colorNum)
            {
                Destroy(col.gameObject);
                Wizard.hp -= 10;
                FirBoss.nowHp -= 10;
                ThdBoss.NowHp -= 10;
                Camera.main.DOShakePosition(0.1f, 0.1f);
                this.audioSource.Play();
            }

        }

        if(col.gameObject.tag == "SlideBullet")
        {
            overPanel.SetActive(true);
            Time.timeScale = 0;
        }

        if(col.gameObject.tag == "WizardBall")
        {   
            Destroy(gameObject);
            overPanel.SetActive(true);
            Time.timeScale = 0;
            DOTween.KillAll();
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
