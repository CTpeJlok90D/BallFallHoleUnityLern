using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class Door : MonoBehaviour
{
	[SerializeField] private Transform _movingObject;
	[SerializeField] private bool _isOpen;
	[SerializeField] private Animator _doorAnimation;

	private Collider _collider;

	public void Open()
	{
		_collider.enabled = false;
		_doorAnimation.SetBool("IsOpen", true);
	}
	public void Close()
	{
		_collider.enabled = true;
		_doorAnimation.SetBool("IsOpen", false);
	}
	public void InvertState()
	{
		_isOpen = !_isOpen;
		CheckDoor();
	}

	private void Awake()
	{
		_collider = GetComponent<Collider>();
		CheckDoor();
	}
	private void CheckDoor()
	{
		if (_isOpen)
		{
			Open();
		}
		else
		{
			Close();
		}
	}
}
