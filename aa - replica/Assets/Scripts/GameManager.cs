using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.UI;
using System;

public class GameManager : MonoBehaviour
{
    private bool gameHasEnded = false;
  
    public rotator rotator;
    public Spawner spawner;
    public Pin pin;

    public Animator animator;
    
    private void Update()
    {
        
    }



    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            return;
        }

        rotator.enabled = false;
        spawner.enabled = false;
        pin.enabled = false;
        gameHasEnded = true;

        animator.SetTrigger("EndGame");
        Debug.Log("END GAME"); 
        
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    
}
