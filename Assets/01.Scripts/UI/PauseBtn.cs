using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseBtn : MonoBehaviour
{
    public GameObject pauseBtn;
    public GameObject pausePanel;
    public GameObject exitBtn;

    AudioSource audioSource;

   public void Awake()
    {
        audioSource = this.gameObject.GetComponent<AudioSource>();
        Time.timeScale = 1;
    }

    public void OnClickBtn()
    {
        Time.timeScale = 0f;
        pausePanel.SetActive(true);
        this.audioSource.Play();
    }
    
    public void OnClickExitBtn()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1f;
        this.audioSource.Play();
    }
}
