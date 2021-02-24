using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    public static bool timerActive = false;
    public int maxTime;
    public int numItems;
    private int currentTime;
    public Text timerText;

    // Start is called before the first frame update
    void Start()
    {
        timerText.text = "Timer: " + maxTime.ToString();
    }

    // Update is called once per frame
    void Update()
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
    }

}
