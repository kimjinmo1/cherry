using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Xml.Schema;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameObject Cherry;
    public GameObject Regame;

    public TextMeshProUGUI totalScoreText;
    public TextMeshProUGUI timeText;

    int totalScore;
    float totalTime = 10.0f;

    private void Awake()
    {
        Instance = this;
        Time.timeScale = 1.0f;
    }

    void Start()//체리 생성
    {
        InvokeRepeating("MakeCherry", 2f, 0.3f);
        
    }

   
    void Update()//
    {
        if (totalTime > 0f)
        {
            totalTime -= Time.deltaTime;
        }
        else
        {
            totalTime = 0f;
            Regame.SetActive(true);
            Time.timeScale = 0f;
        }

        timeText.text = totalTime.ToString("N2");
    }

    void MakeCherry()
    {
        Instantiate(Cherry);
    }

    public void AddScore(int score)
    {
        totalScore += score;
        totalScoreText.text = totalScore.ToString();
    }
}
