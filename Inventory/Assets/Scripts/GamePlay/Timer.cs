using UnityEngine;
using UnityEngine.Events;

public class Timer : MonoBehaviour, IEnableDisable
{
	[SerializeField] private bool _isTicking = false;
	[SerializeField] private bool _loop = false;
	[SerializeField] private float _requiredTime = 10;
	[SerializeField] private UnityEvent _done;

	private float _correctTime = 0;

	public float CorrectTime => _correctTime;
	public float RequiredTime => _requiredTime;

	public void Disable()
	{
		_isTicking = false;
	}
	public void Enable()
	{
		_isTicking = true;
	}

	private void Update()
	{
		Tick();
	}
	private void Tick()
	{
		if (_isTicking == false)
		{
			return;
		}
		if (_correctTime >= _requiredTime)
		{
			_done.Invoke();
			_correctTime = 0;
			if (_loop == false)
			{
				Disable();
			}
			return;
		}
		_correctTime += Time.deltaTime;
	}
}
