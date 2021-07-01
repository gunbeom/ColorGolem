using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart2 : MonoBehaviour
{
    public GameObject restartBtn;

    public void OnclickBtn()
    {
        SceneManager.LoadScene("SecondBoss");
        Time.timeScale = 1;
    }
    
}
