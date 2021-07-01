using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Wizard: MonoBehaviour
{

    Animator animator;

    public GameObject Bullet;
    public GameObject clearPanel;
    
    public Image hpBar;

    public float maxHp = 150;
    public static float hp;

    int drawBossCount;

    SpriteRenderer spriteRenderer;

    AudioSource audioSource;

    void Awake()
    {
        audioSource = this.gameObject.GetComponent<AudioSource>();
        Time.timeScale = 1;
        hp = maxHp;

        animator = GetComponent<Animator>();

        InvokeRepeating("SpawnMetor", 3, 8f); // 메테오 발사
        InvokeRepeating("PlayAttackAnim", 2.2f, 8f); // 메테오 발사 시간에 맞게 ( 싱크 맞게 ) 애니메이션 미리 작동 

        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.DOFade(0, 0).SetAutoKill(true);

        InvokeRepeating("DrawBoss", 0, 1f);
    }


    void Update()
    {
        hpBar.fillAmount = hp / maxHp;

        if(hp <= 0)
        {
            gameObject.SetActive(false);
            clearPanel.SetActive(true);
            Time.timeScale = 0f;
            DOTween.KillAll();
        }
    }

    void DrawBoss()
    {
        spriteRenderer.DOFade(1, 3f).SetAutoKill(true);
        {
            drawBossCount++;
        }
        if(drawBossCount >= 1)
        {
            CancelInvoke("DrawBoss");
        }
    }

    void PlayAttackAnim()
    {
        animator.Play("WizardBall");
    }

    void SpawnMetor()
    {
        GameObject enemy = (GameObject)Instantiate(Bullet, new Vector3(0f, 1.15f, 0f), Quaternion.identity);
        Camera.main.DOShakePosition(0.5f, 0.6f).SetAutoKill(true);
        this.audioSource.Play();
    }

}
