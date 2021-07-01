using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Clear : MonoBehaviour
{
    public GameObject CheckBtn;

    public void OncClickCheckBtn()
    {
        SceneManager.LoadScene("Lobby");
    }
}
