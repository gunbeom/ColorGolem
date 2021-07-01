using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuleBook : MonoBehaviour
{
    public GameObject ruleBook;
    public GameObject rulePanel;
    
    AudioSource audioSource;

    void Awake()
    {
        audioSource = this.gameObject.GetComponent<AudioSource>();
    }


    public void OnClickBtn()
    {
        rulePanel.SetActive(true);
        this.audioSource.Play();
    }

    public void OnClickChekBtn()
    {
        rulePanel.SetActive(false);
        this.audioSource.Play();
    }
}
