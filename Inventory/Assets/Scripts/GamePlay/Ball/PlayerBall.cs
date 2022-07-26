using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerBall : MonoBehaviour
{
	[SerializeField] private List<DeadBall> _playerDeathsObjects;

	private Rigidbody _rigidbody;
	public void Kill(PlayerDeath _deathType)
	{
		DeadBall deadBall = Instantiate(_playerDeathsObjects[(int)_deathType], transform.position, Quaternion.identity);
		deadBall.Init(_rigidbody);
		Destroy(gameObject);
	}
	private void Awake()
	{
		_rigidbody = GetComponent<Rigidbody>();
	}
}
