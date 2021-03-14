using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int ScoreCount;
    public Text text;
    

    public void Update()
    {
        text.text = ScoreCount.ToString();
    }

   public void SaveScore()
    {
       Save.SaveScore(this);
    }

    public void LoadScore()
    {

        PlayerData data = Save.LoadScore();
        ScoreCount = data.ScoreCount;
        
    }
}
