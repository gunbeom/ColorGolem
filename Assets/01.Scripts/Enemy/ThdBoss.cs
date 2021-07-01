using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ThdBoss : MonoBehaviour
{
    Animator animator;

    public GameObject slideBullet;

    public Image firBackImg;
    public Image firHpBar;
    public Image secBackImg;
    public Image secHpBar;

    public GameObject pageSwapPanel;

    public GameObject player;

    public GameObject overPanel;

    public GameObject boss;

    public float firmaxHp = 200;
    public float secmaxHp = 250;

    public static float NowHp;

    public bool isdied = false;

    AudioSource audioSource;

    private void Awake()
    {
        audioSource = this.gameObject.GetComponent<AudioSource>();
    }

    void Start()
    {
        animator = GetComponent<Animator>();
        Time.timeScale = 1;
        InvokeRepeating("SlideSkill", 3, 5f); // 스크롤 블럭 발사
        NowHp = firmaxHp;
        InvokeRepeating("PlayAtkAnim",2.2f, 5f);

        isdied = false;
    }

    void Update()
    {
        FirPage();
        SecPage();
    }

    void FirPage()
    {
        firHpBar.fillAmount = NowHp / firmaxHp;
        if (NowHp <= 0 && isdied == false)
        {
            pageSwapPanel.SetActive(true);
            Time.timeScale = 0f;
            NowHp = secmaxHp;
            swapPage();
            firBackImg.gameObject.SetActive(false);
            firHpBar.gameObject.SetActive(false);
        }
    }

    public void OnClickOkBtn()
    {
        pageSwapPanel.SetActive(false);
        Time.timeScale = 1f;
    }

    void swapPage()
    {
        isdied = true;
    }

    void SecPage()
    {
        if (isdied == true)
        {
            secHpBar.fillAmount = NowHp / secmaxHp;
            secBackImg.gameObject.SetActive(true);
            secHpBar.gameObject.SetActive(true);
        }
        if(NowHp <= 0 )
        {
            overPanel.SetActive(true);
            boss.SetActive(false);
            Time.timeScale = 0f;
        }

    }

    void SlideSkill()
    {
        GameObject enemy = (GameObject)Instantiate(slideBullet, new Vector3(0, 1.75f, 0f), Quaternion.identity);
        this.audioSource.Play();
        Camera.main.DOShakePosition(0.5f, 0.6f).SetAutoKill(true);
    }

    void PlayAtkAnim()
    {
        animator.Play("ThdBossAtk");
    }
}
