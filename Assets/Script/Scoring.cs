using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{

    public Text ScoreText;
    public int score = 0;
    public int maxScore;

    public GameObject Score;
    public GameObject VoceVenceuText;


    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    public void Addscore(int newScore)
    {
        score += newScore;
    }

    public void UpdateScore()
    {
        ScoreText.text = "Score 0" + score;
    }

    // Update is called once per frame
    void Update()
    {
        UpdateScore();

        if(score == maxScore)
        {
            Score.SetActive(false);
            VoceVenceuText.SetActive(true);
        }


    }
}
