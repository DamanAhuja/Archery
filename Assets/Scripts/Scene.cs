using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    public void SceneChange()
    {
        SceneManager.LoadScene("Game");
        UIManager.score = 0;
        UIManager.count = 10;
        BowMovement.speed = 1.0f;
    }
}
