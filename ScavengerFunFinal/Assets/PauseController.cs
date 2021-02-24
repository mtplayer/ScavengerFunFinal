using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseController : MonoBehaviour {

    public GameObject pausePanel;

    public void PauseGame()  {
        pausePanel.SetActive(true);
        Time.timeScale = 0;

    }
    
    public void ResumeGame() {
        pausePanel.SetActive(false);
        Time.timeScale = 1;

    }


    void FixedUpdate()
    {
        GameObject timer = GameObject.Find("Timer");
        TimerScript timerScript = timer.GetComponent<TimerScript>();
        if (timerScript.currentTime <= 0)
        {
            
        }
    }



} // class

