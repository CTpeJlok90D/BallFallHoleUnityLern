using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class LoadConfigurator : MonoBehaviour
{
    [Header("Кнопка <Start>")]
    [SerializeField] private Button _button;
    [SerializeField] private TMP_Text _text;
    [SerializeField] private string _newGameText = "New game";
    [SerializeField] private string _continueGameText = "Continue";
	[Header("Обработчик нажатий")]
    [SerializeField] private ButtonsClickHandler _buttonsClickHandler;

    private void OnEnable()
    {
        ChangeText();
        if (IsFirstLaunch())
		{
            PlayerPrefs.SetInt("AvailableLevel", 1);
		}
        _button.onClick.AddListener(() => { _buttonsClickHandler.LoadLevel(PlayerPrefs.GetInt("AvailableLevel")); });
    }
    private bool IsFirstLaunch()
	{
        return PlayerPrefs.GetInt("AvailableLevel") == 0;
    }
    private void ChangeText()
	{
        if (IsFirstLaunch())
        {
            _text.text = _newGameText;
            return;
        }
        _text.text = _continueGameText;
    }
}
