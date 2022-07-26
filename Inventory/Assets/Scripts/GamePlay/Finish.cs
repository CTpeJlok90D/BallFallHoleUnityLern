using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Collider))]
public class Finish : MonoBehaviour
{
	[SerializeField] private int SceneNumber;
	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.TryGetComponent(out PlayerBall player))
		{
			SceneManager.LoadScene(SceneNumber);
		}
	}
}
