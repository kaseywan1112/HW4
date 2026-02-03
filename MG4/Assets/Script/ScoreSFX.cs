using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSFX : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ScoreManager.instance.OnScoreChanged += PlayScoreSound;
    }

    void OnDestroy()
    {
        if (ScoreManager.instance != null)
            ScoreManager.instance.OnScoreChanged -= PlayScoreSound;
    }

    void PlayScoreSound(int newScore)
    {
        AudioManager.instance.PlayScoreSound();
    }
}

    // Update is called once per frame

