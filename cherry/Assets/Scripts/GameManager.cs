using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Xml.Schema;
using UnityEngine.SocialPlatforms.Impl;
using UnityEditor.Experimental.GraphView;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameObject Cherry;
    public GameObject Regame;
    public GameObject Rangking;

    public TextMeshProUGUI totalScoreText;
    public TextMeshProUGUI timeText;
    public TextMeshProUGUI bestScore;
    public TextMeshProUGUI nowScore;
    

    int totalScore;
    float totalTime = 10.0f;
    int Score; 
    


   

    private void Awake()
    {
        Instance = this;
        Time.timeScale = 1.0f;
        
    }
  

    void Start()//ü�� ����
    {
        InvokeRepeating("MakeCherry", 0f, 0.3f);
        
    }

   
    void Update()
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



        if(totalTime == 0)
        {
            Rangking.SetActive(true);
            UpdateBestScore();
        }

      

    }

    void MakeCherry()
    {
        Instantiate(Cherry);
    }

    public void AddScore(int score)
    {
        totalScore += score;
        totalScoreText.text = totalScore.ToString();
        nowScore.text = totalScore.ToString();
    }

    void UpdateBestScore()
    {
        if (PlayerPrefs.HasKey("bestScore"))
        {
            float best = PlayerPrefs.GetFloat("bestScore");
            if (best < totalScore)//�ְ���������
            {
                PlayerPrefs.SetFloat("bestScore", totalScore);
                bestScore.text = totalScore.ToString();
            }
            else//��������
            {
                bestScore.text = best.ToString();
            }

        }
    }

}
