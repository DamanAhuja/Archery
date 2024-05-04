using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager2 : MonoBehaviour
{
    public static UIManager2 instance;
    public TextMeshProUGUI HighScore;
    private static int high = 0;

    void Awake()
    {
        instance = this;
        LoadHighScore();

        if (UIManager1.Score > high) // Compare with saved high score
        {
            high = UIManager1.Score;
            SaveHighScore(); // Save the new high score
        }

        UpdateScore();
    }

    public void UpdateScore()
    {
        HighScore.text = "High Score - " + high;
    }

    void LoadHighScore()
    {
        high = PlayerPrefs.GetInt("HighScore", 0);
    }

    void SaveHighScore()
    {
        PlayerPrefs.SetInt("HighScore", high);
        PlayerPrefs.Save();
    }
}

