using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public Text scoreText;
    public GameObject UI_Menu;

    public GameObject UI_Setting;
    public GameObject UI_HighScore;
    public GameObject UI_About;
    public Slider slider;

    private void Start()
    {
        AudioListener.volume = PlayerPrefs.GetFloat("sound");
        slider.value = PlayerPrefs.GetFloat("sound");
    }

    public void ToGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Back()
    {
        UI_About.SetActive(false);
        UI_HighScore.SetActive(false);
        UI_Setting.SetActive(false);

        UI_Menu.SetActive(true);
    }

    public void HighScore()
    {
        scoreText.text = PlayerPrefs.GetInt("score").ToString();
        UI_Menu.SetActive(false);

        UI_HighScore.SetActive(true);
    }

    public void Setting()
    {
        UI_Menu.SetActive(false);
        UI_Setting.SetActive(true);
    }

    public void About()
    {
        UI_Menu.SetActive(false);
        UI_About.SetActive(true);
    }

    public void SettingAudio()
    {
        AudioListener.volume = slider.value;
        PlayerPrefs.SetFloat("sound", slider.value);
    }

    public void Reset()
    {
        PlayerPrefs.SetInt("score", 0);
    }
}