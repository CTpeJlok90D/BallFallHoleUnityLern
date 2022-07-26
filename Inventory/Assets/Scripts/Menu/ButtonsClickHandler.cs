using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsClickHandler : MonoBehaviour
{
	public void LoadLevel(int levelNumber)
	{
		SceneManager.LoadScene(levelNumber);
	}
	public void ExitGame()
	{
		Application.Quit();
	}
}
