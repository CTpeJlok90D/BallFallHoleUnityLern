using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : Trap
{
	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.TryGetComponent(out PlayerBall player))
		{
			_gotPlayer.Invoke();
			player.Kill(_playerDeathType);
		}
	}
}
