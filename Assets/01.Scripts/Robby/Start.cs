using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{
    AudioSource audioSource;

    void Awake()
    {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        Screen.SetResolution(500, 1000, true);
        Screen.SetResolution(Screen.width, (Screen.width / 1) * 2, true);
        audioSource = this.gameObject.GetComponent<AudioSource>();
    }
    public void OnClickStartBtn()
    {
        this.audioSource.Play();
        SceneManager.LoadScene("Lobby");
    }
}
