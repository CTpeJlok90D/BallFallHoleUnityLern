using UnityEngine;
using UnityEngine.Events;

public abstract class Trap : MonoBehaviour
{
	[SerializeField] protected PlayerDeath _playerDeathType;
	[SerializeField] protected UnityEvent _gotPlayer;
}
