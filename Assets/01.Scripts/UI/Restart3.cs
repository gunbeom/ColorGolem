using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart3 : MonoBehaviour
{
    public GameObject restartBtn;

    public void OnclickBtn()
    {
        SceneManager.LoadScene("ThirdBoss");
        Time.timeScale = 1;
    }
    
}
