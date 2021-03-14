using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SceneSwitcher : MonoBehaviour
{
    public GameTimer gametimer;
    public InputField playerName;
    public Slider pinSpeedSlider;
    public Slider targetSpeedSlider;
    public Dropdown Lives;

    


    public void PlayGame()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
        SceneManager.LoadScene(1);
        Debug.Log("Player name is:" + playerName);

        
        GameTimer.playerNameStr = playerName.text;
        GameTimer.lives = Lives.value;
        //GameTimer.pinSpeed = pinSpeedSlider.value;
        //GameTimer.targetSpeed = targetSpeedSlider.value;
    }

    public void MainMenu()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1);
        SceneManager.LoadScene(0);
    }

    

    public void Quit()
    {
        Application.Quit();
    }

}
