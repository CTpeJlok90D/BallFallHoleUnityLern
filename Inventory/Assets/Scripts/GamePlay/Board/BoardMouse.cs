using UnityEngine;

[RequireComponent(typeof(BoardRotator))]
public class BoardMouse : MonoBehaviour
{
	[SerializeField] private float _sensivity = 1;
	private BoardRotator _boardRotate;

	private void Update()
	{
		if (Input.GetMouseButton(1))
		{
			_boardRotate.Rotate(GetInputForse() * _sensivity, GetInputVilosity());
		}
	}
	private void Start()
	{
		_boardRotate = GetComponent<BoardRotator>();
	}
	private Vector2 GetInputForse()
	{
		Vector2 forse = new Vector2();
		forse.x = Input.GetAxis("Horizontal");
		forse.y = Input.GetAxis("Vertical");
		return forse;
	}
	private Vector2 GetInputVilosity()
	{
		Vector2 velosity = new Vector2();
		velosity.x = Input.GetAxis("Horizontal") > 0 ? 1 : -1;
		velosity.y = Input.GetAxis("Vertical") > 0 ? 1 : -1;
		return velosity;
	}
}
