using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSFX : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnEnable()
    {
        ScoreManager.instance.OnScoreChanged += PlayScoreSFX;
    }

    private void OnDisable()
    {
        ScoreManager.instance.OnScoreChanged -= PlayScoreSFX;
    }

    void PlayScoreSFX(int newScore)
    {
        AudioManager.instance.PlayScoreSound();

    }
}

    // Update is called once per frame

