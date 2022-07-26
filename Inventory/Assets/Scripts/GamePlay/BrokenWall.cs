using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class BrokenWall : MonoBehaviour
{
	private Collider _collider;
	private void Awake()
	{
		_collider = GetComponent<Collider>();
	}
	private void OnCollisionEnter(Collision collision)
	{
		
	}
}
