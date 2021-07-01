using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class FirstIntro : MonoBehaviour
{
    public GameObject golem;
    public GameObject textPanel;
    public GameObject spawner;

    public GameObject hpBack;
    public GameObject hpBar;

    public GameObject startBtn;

    public bool isPushed;

    public Text firIntroText;

    AudioSource golemroute;
    AudioSource audioSource;

    public void Awake()
    {
        audioSource = this.gameObject.GetComponent<AudioSource>();
        Time.timeScale = 1;
    }

    void Start()
    {
        audioSource.Play();
        golem.SetActive(false);
        spawner.SetActive(false);
        Invoke("StartText", 1f);
        hpBack.SetActive(false);
        hpBar.SetActive(false);

    }
    void StartText()
    {
        firIntroText.DOText("À¸¾Æ¤¿¤¿ !!!!!", 2f);
        Camera.main.DOShakePosition(2f, 0.5f);
        return;
    }
    public void OnClickBtn()
    {
        golem.SetActive(true);
        textPanel.SetActive(false);
        spawner.SetActive(true);
        hpBack.SetActive(true);
        hpBar.SetActive(true);
        shakeCamera();
    }

    void shakeCamera()
    {
        Camera.main.DOShakePosition(4.5f, 1f).SetAutoKill(true);
    }

    void Update()
    {
        
    }
}
