using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class FirBoss : MonoBehaviour
{

    public Image Bar;
    public Image HpBar;

    public float maxHp = 100;
    public static float nowHp;

    public GameObject clearPanel;

    void Start()
    {
        Time.timeScale = 1;
        nowHp = maxHp;
        
    }

    void Update()
    {

        HpBar.fillAmount = nowHp / maxHp;
        if (nowHp <= 0)
        {
            gameObject.SetActive(false);
            clearPanel.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
