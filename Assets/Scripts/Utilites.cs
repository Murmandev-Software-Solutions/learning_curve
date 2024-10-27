using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.SceneManagement;

public static class Utilities
{
    public static int playerDeaths = 0;
    public static string UpdateDeathCount(ref int counterRef)
    {
        counterRef+=1;
        return "Next u'll be at number"+counterRef ;
    }
    public static void RestartLevel()
    {
        //use it in case when player die
        Debug.Log("Player deaths:" + playerDeaths);
        string message = UpdateDeathCount(ref playerDeaths);
        Debug.Log("Player deaths:"+ playerDeaths);
        SceneManager.LoadScene(0);
        Time.timeScale=1f;
    }
    public static bool RestartLevel(int nIndex)
    {
        SceneManager.LoadScene(nIndex);
        Time.timeScale=1f;
        return true;
    }
}