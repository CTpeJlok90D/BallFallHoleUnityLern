using UnityEngine;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{
	public bool _isTicking = false;

	[SerializeField] private float _requiredTime = 10;
	[SerializeField] private UnityEvent _done;

	private float _correctTime = 0;

	public void Enable()
	{
		_isTicking = true;
	}
	public void Disable()
	{
		_isTicking = false;
	}
	public void InvertState()
	{
		_isTicking = !_isTicking;
	}

	private void Update()
	{
		Tick();
	}
	private void Tick()
	{
		if (_isTicking)
		{
			if(_correctTime >= _requiredTime)
			{
				_done.Invoke();
				_correctTime = 0;
				return;
			}
			_correctTime += Time.deltaTime;
		}
	}
}
