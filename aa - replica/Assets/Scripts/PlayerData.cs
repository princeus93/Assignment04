using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class PlayerData : MonoBehaviour
{
    public int ScoreCount;

    public PlayerData(Score score)
    {
        ScoreCount = Score.ScoreCount;
        //RotatorSpeed = rotator.speed;
    }
}
