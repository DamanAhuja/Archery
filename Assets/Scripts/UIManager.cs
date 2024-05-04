using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    public TextMeshProUGUI Score;
    public TextMeshProUGUI arrows;

    public static int score = 0;
    public static int count = 10;

    void Awake()
    {
        instance = this;
        UIManager.instance.UpdateCount();
        UIManager.instance.UpdateScore();
    }

    public static void AddScore(int amount)
    {
        score += amount;
        UIManager.instance.UpdateScore();
    }

    public static void arrowdec(int amount)
    {
        count -= amount;
        UIManager.instance.UpdateCount();
    }

    public static void arrowinc(int amount)
    {
        count += amount;
        UIManager.instance.UpdateCount();
    }

    public void UpdateScore()
    {
        Score.text = "" + score;
    }

    public void UpdateCount()
    {
        string emoji = new string('\u2191', count);
        arrows.text = emoji;
    }
}
