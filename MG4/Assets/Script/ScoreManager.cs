using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public int score { get; private set; } = 0;

    public event System.Action<int> OnScoreChanged;

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
        }
    }
    public void IncreaseScore()
    {
        score++;
        OnScoreChanged?.Invoke(score);
    }
    // Start is called before the first frame update
}
