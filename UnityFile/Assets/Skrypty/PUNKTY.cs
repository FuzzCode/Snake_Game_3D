using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PUNKTY : MonoBehaviour
{
    public static PUNKTY instance;

    public Text scoreText;
    public Text highscoreText;

    int score = 0;
    int highscore = 0;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        highscore = PlayerPrefs.GetInt("NAJLEPSZY WYNIK", 0);
        scoreText.text =" PUNKTY:" + score.ToString();
        highscoreText.text = "NAJLEPSZY WYNIK: " + highscore.ToString();

    }

    public void AddPoint()
    {
        score += 1;
        scoreText.text = " PUNKTY:" + score.ToString();
        if (highscore < score)
        PlayerPrefs.SetInt("NAJLEPSZY WYNIK", score);
    }

    void Update()
    {
       
    }
}
