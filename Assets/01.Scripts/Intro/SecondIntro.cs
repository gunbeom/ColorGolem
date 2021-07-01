using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class SecondIntro : MonoBehaviour
{
    public GameObject Wizard;
    public GameObject textPanel;
    public GameObject spawner;

    public GameObject startBtn;

    public Text secondBossText;

    AudioSource audioSource;

    private void Awake()
    {
        audioSource = this.gameObject.GetComponent<AudioSource>();
    }
    private void Start()
    {
        this.audioSource.Play();
        Wizard.SetActive(false);
        spawner.SetActive(false);
        Invoke("StartText", 1f);
    }

    void StartText()
    {
            secondBossText.DOText("게임 시작이다 !!!", 2f);
            Camera.main.DOShakePosition(2f, 0.5f);
            return;
    }

    public void OnClickBtn()
    {
        Wizard.SetActive(true);
        textPanel.SetActive(false);
        spawner.SetActive(true);
    }

    void Update()
    {

    }
}
