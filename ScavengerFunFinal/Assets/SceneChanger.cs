using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{

    //Main to level 1
    public void mainToLevelOne()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    //Main to level 2
    public void mainToLevelTwo()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    //Main to level 3
    public void mainToLevelThree()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    //Main to level 4
    public void mainToLevelFour()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }

    //Main to Freestyle
    public void mainToFreestyle()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
    }

    //Quit to desktop
    public void quit()
    {
        Application.Quit();
    }

    //--------------------------------------------
    //Freestyle to Level 1
    public void freestyleToLevelOne()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 5);
        //disable timer
    }

    //Freestyle to Level 2
    public void freestyleToLevelTwo()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
        //disable timer
    }

    //Freestyle to Level 3
    public void freestyleToLevelThree()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
        //disable timer
    }

    //Freestyle to Level 4
    public void freestyleToLevelFour()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        //disable timer
    }
    //----------------------------------------------

    //Load back to main menu
    public void MainMenu()
    {
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 4)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 5)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
        } 
        else if (SceneManager.GetActiveScene().buildIndex == 6)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
        }
    }
}
  
