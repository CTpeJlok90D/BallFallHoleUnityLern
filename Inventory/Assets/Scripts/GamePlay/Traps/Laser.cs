using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider))]
public class Laser : MonoBehaviour, IEnableDisable
{
	[SerializeField] private bool _enabled;
	[SerializeField] private MeshRenderer _deadZoneMesh;
	[SerializeField] protected PlayerDeath _playerDeathType;
	[SerializeField] protected UnityEvent _gotPlayer;

	private Collider _deadZoneCollider;

	public void Disable()
	{
		SetActive(false);
	}

	public void Enable()
	{
		SetActive(true);
	}
	public void InvertState()
	{
		SetActive(!_enabled);
	}

	private void Awake()
	{
		_deadZoneCollider = GetComponent<Collider>();
		SetActive(_enabled);
	}
	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.TryGetComponent(out PlayerBall player))
		{
			_gotPlayer.Invoke();
			player.Kill(_playerDeathType);
		}
	}
	private void SetActive(bool flag)
	{
		_deadZoneCollider.enabled = flag;
		_deadZoneMesh.enabled = flag;
		_enabled = flag;
	}
}
