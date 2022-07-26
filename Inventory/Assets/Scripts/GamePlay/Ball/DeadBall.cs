using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadBall : MonoBehaviour
{
	[SerializeField] private List<Rigidbody> _parts;

	public void Init(Rigidbody playerRigidBody)
	{
		transform.rotation = playerRigidBody.rotation;
		foreach (Rigidbody part in _parts)
		{
			part.velocity = playerRigidBody.velocity;
		}
	}
}
