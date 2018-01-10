using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    [SerializeField]
    private GameObject _MusicManager;

    [SerializeField]
    private Image _SoundButtonImage;

    [SerializeField]
    private Sprite _OnSprite, _OffSprite;

    private bool _OnOff;

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void EnableSoundOnOff()
    {
        if (!_OnOff)
        {
            _SoundButtonImage.sprite = _OnSprite;
            _MusicManager.SetActive(true);
            _OnOff = true;
        }
        else
        {
            _SoundButtonImage.sprite = _OffSprite;
            _MusicManager.SetActive(false);
            _OnOff = false;
        }
    }

    public void BackToHome()
    {
        SceneManager.LoadScene(0);
    }

}
