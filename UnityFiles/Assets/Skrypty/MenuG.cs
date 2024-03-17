using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuG : MonoBehaviour
{
 public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
    public void wyjdz()
    {
        Application.Quit();
    }
}
