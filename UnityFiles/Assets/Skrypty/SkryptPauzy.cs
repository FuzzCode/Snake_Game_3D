using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SkryptPauzy : MonoBehaviour
{
    public GameObject pausedMenu;
    public bool isPaused;
   
    void Start()
    {
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(isPaused)
            {
                resumeGame();
            }else
            {
                isPaused = true;
                pausedMenu.SetActive(true);
                Time.timeScale = 0f;

            }
        }
    }
    public  void resumeGame()
    {
        isPaused = false;
        pausedMenu.SetActive(false);
        Time.timeScale = 1f;
    }
    public void ReturnToMain()
    {
        SceneManager.LoadScene(0);
    }
}
