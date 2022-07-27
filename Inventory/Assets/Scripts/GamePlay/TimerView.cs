using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Timer))]
public class TimerView : MonoBehaviour
{
    [SerializeField] private Image _clock;
    private Timer _timer;

    private void Start()
    {
        _timer = GetComponent<Timer>();
    }
    private void Update()
    {
        FillClock();
    }
    private void FillClock()
    {
        if (_timer.CorrectTime > 0 && _timer.CorrectTime <= _timer.RequiredTime)
        {
            _clock.fillAmount = _timer.CorrectTime / _timer.RequiredTime;
            return;
        }
        _clock.fillAmount = 0;
    }
}
