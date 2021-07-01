using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart1 : MonoBehaviour
{
    public GameObject restartBtn;

    public void OnclickBtn()
    {
        SceneManager.LoadScene("FirstBoss");
        Time.timeScale = 1;
    }
    
}
