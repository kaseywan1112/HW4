using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreUI : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    // Start is called before the first frame update

    private void Awake()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
    }

    void Start()
    {
        ScoreManager.instance.OnScoreChanged += UpdateScoreText;
        UpdateScoreText(ScoreManager.instance.score);
    }
    private void OnDestroy()
    {
        if (ScoreManager.instance != null)
        {
            ScoreManager.instance.OnScoreChanged -= UpdateScoreText;
        }
    }
    // Update is called once per frame
    void UpdateScoreText(int newScore)
    {
        scoreText.text = "Score: " + newScore.ToString();
    }
}
