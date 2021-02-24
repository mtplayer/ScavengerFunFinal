using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour
{
    public static bool timerActive = true;
    public int maxTime;
    public int numItems;
    public int currentTime;
    public static bool gameWon;
    public Text timerText;
    public Text winner;


    // Start is called before the first frame update
    void Start()
    {
        timerText.text = "Timer: " + maxTime.ToString();
        currentTime = maxTime;
    }

    void wait()
    {
        winner = GameObject.Find("EndGame").GetComponent<Text>();
        winner.text = "You Won!";
        Time.timeScale = 0;
        gameWon = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (timerActive)
        {
            currentTime = (int)Mathf.Ceil(maxTime - Time.timeSinceLevelLoad);
            timerText.text = "Timer: " + currentTime.ToString();
        }
        else
        {
            timerText.text = "";
        }
        if (ItemInteraction.itemsFound == numItems)
        {

            Invoke("wait", 0.5f);
        }
    }

}
