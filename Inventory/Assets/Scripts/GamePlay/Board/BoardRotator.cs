using UnityEngine;

public class BoardRotator : MonoBehaviour
{
	[SerializeField] private float _maxSpeed = 10f;
	[SerializeField] private float _maxAngle = 15f;

	private Vector2 _velosity;
	private Vector2 _forse;

	public void Rotate(Vector2 force, Vector2 velocity)
	{
		UpdateForse(force);
		UpdateVilosity(velocity);

		float CorrectRotateX = Mathf.Abs(_forse.x) > _maxSpeed ? _maxSpeed * _velosity.x : _forse.x;
		float CorrectRotateY = Mathf.Abs(_forse.y) > _maxSpeed ? _maxSpeed * _velosity.y : _forse.y;

		transform.Rotate(LimitRotate(new Vector3(CorrectRotateX, 0, CorrectRotateY)) * Time.fixedDeltaTime);
	}
	public void UpdateForse(Vector2 force)
	{
		_forse.x = force.x;
		_forse.y = force.y;
	}
	public void UpdateVilosity(Vector2 velocity)
	{
		_velosity.x = velocity.x;
		_velosity.y = velocity.y;
	}
	private void Update()
	{
		_forse.x = AspirateAngleToZero(_forse.x);
		_forse.y = AspirateAngleToZero(_forse.y);
	}
	private Vector3 LimitRotate(Vector3 angles)
	{
		angles.x = ConvertAngle(angles.x);
		angles.z = ConvertAngle(angles.z);

		if (Mathf.Abs(angles.x + ConvertAngle(transform.rotation.eulerAngles.x)) > _maxAngle)
		{
			angles.x = _maxAngle * _velosity.x - ConvertAngle(transform.rotation.eulerAngles.x);
		}
		if (Mathf.Abs(angles.z + ConvertAngle(transform.rotation.eulerAngles.z)) > _maxAngle)
		{
			angles.z = _maxAngle * _velosity.y - ConvertAngle(transform.rotation.eulerAngles.z);
		}
		return angles;
	}
	private float AspirateAngleToZero(float angle)
	{
		if (Mathf.Abs(angle) < _maxSpeed)
		{
			return 0;
		}
		if (angle > 0)
		{
			return angle - _maxSpeed;
		}
		return angle + _maxSpeed;
	}
	private float ConvertAngle(float angle)
	{
		if (angle > 180)
		{
			return (360 - angle) * -1;
		}
		return angle;
	}
}
