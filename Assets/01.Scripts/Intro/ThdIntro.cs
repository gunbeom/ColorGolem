using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ThdIntro : MonoBehaviour
{
    public GameObject textPanel;

    public GameObject hpBack;
    public GameObject hpBar;

    public GameObject spawner1;
    public GameObject spawner2;
    public GameObject boss;

    public GameObject startBtn;

    public Text thdIntroText;

    AudioSource audioSource;

    private void Awake()
    {
        audioSource = this.gameObject.GetComponent<AudioSource>();
        spawner1.SetActive(false);
        spawner2.SetActive(false);
        boss.SetActive(false);
        hpBack.SetActive(false);
        hpBar.SetActive(false);
    }

    void Start()
    {
        Invoke("StartText", 1f);
        this.audioSource.Play();
    }

    void StartText()
    {
        thdIntroText.DOText("자신있어 보이는군.. 기대해라", 2f);
        Camera.main.DOShakePosition(2f, 0.5f);
        return;
    }
    public void OnClickBtn()
    {
        textPanel.SetActive(false);
        spawner1.SetActive(true);
        spawner2.SetActive(true);
        boss.SetActive(true);
        hpBack.SetActive(true);
        hpBar.SetActive(true);
    }

    void Update()
    {
        
    }
}
