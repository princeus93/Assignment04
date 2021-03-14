using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    public rotator rotator;
    public Pin pin;
    public Text timeLimitText;
    public Text remainingTimeText;
    public Slider pinSpeedSlider;
    public Slider targetSpeedSlider;
    public Text Lives;
   

    public float timelimit = 30.0f;
    public float timeRemaining;
    public static float pinSpeed;
    public static float targetSpeed;
    public static int lives = 0;

    public Text playerName;
    public static string playerNameStr;

    // Start is called before the first frame update
    void Start()
    {
        //displays name to text box
        playerName.text = playerNameStr;
        //pinSpeedSlider.value = pinSpeed;
        //targetSpeedSlider.value = targetSpeed;

        timeRemaining = timelimit;
        //pinSpeed = pin.speed;
       // targetSpeed = rotator.speed;
        timeLimitText.text = "Time limit: " + timelimit.ToString("F2");
        remainingTimeText.text = "Time remaining: " + timeRemaining.ToString("F2");
        Lives.text = lives.ToString();
    }

    public void HandleInputData(int val)
    {
        if(val == 1)
        {
            Lives.text = "1";
           
        }
        if(val == 2)
        {
            Lives.text = "2";
        }
        if (val == 3)
        {
            Lives.text = "3";
        }
    }

    

    // Update is called once per frame
    void Update()
    {
        timeRemaining -= Time.deltaTime;
        if (timeRemaining >= 0)
        {
            remainingTimeText.text = "Time remaining: " + timeRemaining.ToString("F2");
        }
        else
        {
            remainingTimeText.text = "Game Over";
        }

        
    }

    
}