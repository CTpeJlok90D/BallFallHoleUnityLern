using UnityEngine;

[RequireComponent(typeof(Rigidbody),typeof(AudioSource))]
public class BallSound : MonoBehaviour
{
	[SerializeField] private AudioClip _moveSound;
	[SerializeField] private float _minimalMoveSpeedToPlaySound = 0.1f;

	private Rigidbody _rigidbody;
	private AudioSource _audioSource;
	private bool _soundIsPlaying = false;

	private void Start()
	{
		_rigidbody = GetComponent<Rigidbody>();
		_audioSource = GetComponent<AudioSource>();

		_audioSource.clip = _moveSound;
	}
	private void Update()
	{
		if (IsMoving() && _soundIsPlaying == false)
		{
			_audioSource.Play();
			_soundIsPlaying = true;
		}
		else if (IsMoving() == false)
		{
			_audioSource.Stop();
			_soundIsPlaying = false;
		}
	}
	private bool IsMoving()
	{
		for (int i = 0; i < 3; i++)
		{
			if (_rigidbody.velocity[i] > _minimalMoveSpeedToPlaySound)
			{
				return true;
			}
		}
		return false;
	}
}
