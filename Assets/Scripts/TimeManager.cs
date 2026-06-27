using System;
using TMPro;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI countDownText;
    [SerializeField] private float countDownTime = 60f;

    public static event Action OnTimeFinished;

    private void Update()
    {
        CountDownTime();
    }

    private void CountDownTime()
    {
        countDownTime -= Time.deltaTime;
        countDownText.text = $"{Mathf.Max(0, countDownTime):F1}";

        if (countDownTime <= 0)
        {
            OnTimeFinished?.Invoke();
        }
    }

}
