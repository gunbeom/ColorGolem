using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SecondBoss : MonoBehaviour
{
    public GameObject secBossStartBtn;

    public GameObject secHelpBtn;
    public GameObject secHelpOutBtn;

    public GameObject profilePanel;

    public GameObject firBoss;
    public GameObject thdBoss;

    AudioSource audioSource;

    void Awake()
    {
        audioSource = this.gameObject.GetComponent<AudioSource>();
    }

    public void OnClickStartBtn()
    {
        SceneManager.LoadScene("SecondBoss");
        this.audioSource.Play();
    }

    public void OnClickHelpBtn()
    {
        profilePanel.SetActive(true);
        thdBoss.SetActive(false);
        firBoss.SetActive(false);
        this.audioSource.Play();
    }

    public void OnClickHelpOutBtn()
    {
        profilePanel.SetActive(false);
        thdBoss.SetActive(true);
        firBoss.SetActive(true);
        this.audioSource.Play();
    }

}
