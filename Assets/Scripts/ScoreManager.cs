using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI highScoreText;
    private int currentScore;
    private int highestScore;

    private const string HIGH_SCORE_KEY = "HighScore";

    private void Start()
    {
        highestScore = PlayerPrefs.GetInt(HIGH_SCORE_KEY, 0);
        UpdateUI();
    }

    private void OnEnable()
    {
        Coins.OnItemCollected += IncrementingScore;
        TimeManager.OnTimeFinished += CheckAndSaveHighestScore;
    }

    private void OnDisable()
    {
        Coins.OnItemCollected -= IncrementingScore;
        TimeManager.OnTimeFinished -= CheckAndSaveHighestScore;
    }

    private void IncrementingScore(int value)
    {
        currentScore += value;
        UpdateUI();
    }

    public void CheckAndSaveHighestScore()
    {
        if (currentScore > highestScore)
        {
            highestScore = currentScore;

            PlayerPrefs.SetInt(HIGH_SCORE_KEY, highestScore);

            PlayerPrefs.Save();
        }

        UpdateUI();
    }

    private void UpdateUI()
    {
        scoreText.text = $"Score: {currentScore}";
        highScoreText.text = $"High Score: {highestScore}";
    }
}
