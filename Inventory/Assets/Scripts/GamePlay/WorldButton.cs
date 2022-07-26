using UnityEngine;
using UnityEngine.Events;
[RequireComponent(typeof(Collider))]
public class WorldButton : MonoBehaviour
{
	[SerializeField] private UnityEvent _pressed;
	[SerializeField] private UnityEvent _unPressed;
	[SerializeField] private UnityEvent _staing;

	[SerializeField] private Animator _animator;

	private void OnTriggerEnter(Collider other)
	{
		_pressed.Invoke();
		_animator.SetBool("IsPressed", true);
	}
	private void OnTriggerExit(Collider other)
	{
		_unPressed.Invoke();
		_animator.SetBool("IsPressed", false);
	}
	private void OnTriggerStay(Collider other)
	{
		_staing.Invoke();
	}
}
