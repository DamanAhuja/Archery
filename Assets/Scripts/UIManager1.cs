using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager1 : MonoBehaviour
{
    public static UIManager1 instance;
    public TextMeshProUGUI FinalScore;
    public static int Score = 0;

    void Awake()
    {
        instance = this;
        Score = UIManager.score;
        UIManager1.instance.UpdateScore();
    }

    public void UpdateScore()
    {
        FinalScore.text = "" + Score;
    }

}
