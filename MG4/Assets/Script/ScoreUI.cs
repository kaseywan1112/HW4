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
    private void OnEnable()
    {
        ScoreManager.instance.OnScoreChanged += UpdateScoreText;
    }
    private void OnDisable()
    {
        ScoreManager.instance.OnScoreChanged -= UpdateScoreText;
    }

    void Start()
    {
       UpdateScoreText(ScoreManager.instance.score);
    }

    // Update is called once per frame
    void UpdateScoreText(int newScore)
    {
        scoreText.text = "Score: " + newScore.ToString();
    }
}
