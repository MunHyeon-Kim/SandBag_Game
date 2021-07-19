using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_Button : MonoBehaviour
{

    public void GameStartClicked()
    {


        SoundManager.instance.audioSource.Play();

        SceneManager.LoadScene("Game");
    }

    public void SettingClicked()
    {

        SoundManager.instance.audioSource.Play();
        SceneManager.LoadScene("Setting");
    }

    public void ExitClicked()
    {

        SoundManager.instance.audioSource.Play();
        Application.Quit();
    }
}
