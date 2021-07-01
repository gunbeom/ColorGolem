using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ThirdBoss : MonoBehaviour
{
    public GameObject thdBossStartBtn;

    public GameObject thdHelpBtn;
    public GameObject thdHelpOutBtn;

    public GameObject profilePanel;

    public GameObject firBoss;
    public GameObject secBoss;

    AudioSource audioSource;

    void Awake()
    {
        audioSource = this.gameObject.GetComponent<AudioSource>();
    }

    public void OnClickStartBtn()
    {
        SceneManager.LoadScene("ThirdBoss");
    }

    public void OnClickHelpBtn()
    {
        profilePanel.SetActive(true);
        secBoss.SetActive(false);
        firBoss.SetActive(false);
        this.audioSource.Play();
    }

    public void OnClickHelpOutBtn()
    {
        profilePanel.SetActive(false);
        secBoss.SetActive(true);
        firBoss.SetActive(true);
        this.audioSource.Play();
    }
}
