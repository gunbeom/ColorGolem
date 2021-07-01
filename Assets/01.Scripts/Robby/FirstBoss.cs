using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FirstBoss : MonoBehaviour
{
    public GameObject firBossStartBtn;

    public GameObject firHelpBtn;
    public GameObject firHelpOutBtn;

    public GameObject profilePanel;

    public GameObject secondBoss;
    public GameObject thdBoss;

    AudioSource audioSource;

    void Awake()
    {
        audioSource = this.gameObject.GetComponent<AudioSource>();
    }

    public void OnClickStartBtn()
    {
        SceneManager.LoadScene("FirstBoss");
        this.audioSource.Play();
    }

    public void OnClickHelpBtn()
    {
        profilePanel.SetActive(true);
        secondBoss.SetActive(false);
        thdBoss.SetActive(false);
        this.audioSource.Play();
    }

    public void OnClickHelpOutBtn()
    {
        profilePanel.SetActive(false);
        secondBoss.SetActive(true);
        thdBoss.SetActive(true);
        this.audioSource.Play();
    }

}
