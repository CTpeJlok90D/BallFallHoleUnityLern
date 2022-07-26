using UnityEngine;

public class InteractiveHint : MonoBehaviour
{
	[SerializeField] private float _sizeMultiply = 1.1f;
	private Vector3 _baseSize;
	private Vector3 _newSize;
	private Transform _transform;

	private void Start()
	{
		_transform = GetComponent<Transform>();
		_baseSize = _transform.localScale;
		_newSize = _baseSize * _sizeMultiply;
	}

	private void OnMouseEnter()
	{
		_transform.localScale = _newSize;
	}
	private void OnMouseExit()
	{
		_transform.localScale = _baseSize;
	}
}
