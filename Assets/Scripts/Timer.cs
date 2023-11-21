using System;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    private TMP_Text _timerText;
    enum TimerType {Countdown, Stopwatch }
    [SerializeField] private TimerType timerType;

    [SerializeField] private float timeToDisplay = 10.0f;

    private bool _isRunning;

    private void Awake()
    {
        _timerText = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (timerType == TimerType.Countdown && timeToDisplay < 0.0f) return;
        timeToDisplay += timerType == TimerType.Countdown ? -Time.deltaTime : Time.deltaTime;

        TimeSpan timeSpan = TimeSpan.FromSeconds(timeToDisplay);
        _timerText.text = timeSpan.ToString(@"ss\:ff");

        if (_timerText.text == "00:00")
        {
            SceneManager.LoadScene("WinScreen");
        }
    }
}
