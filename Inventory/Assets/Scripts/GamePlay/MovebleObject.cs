using UnityEngine;

[RequireComponent(typeof(Rigidbody),typeof(Collider))]
public class MovebleObject : MonoBehaviour
{
    private Rigidbody _rigidbody;

    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
	private void OnCollisionEnter(Collision collision)
	{
        if (collision.gameObject.TryGetComponent(out PlayerBall player))
        {
            _rigidbody.isKinematic = false;
        }
	}
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out PlayerBall player))
        {
            _rigidbody.isKinematic = true;
        }
    }
}
