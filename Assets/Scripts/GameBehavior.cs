using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEngine.SceneManagement; // management for sceene
using UnityEngine;

//implement of game manager 
public class GameBehavior : MonoBehaviour
{
    private int _itemsCollected = 0;
    private int _PlayerHP = 3;
    //add getters and setters
    public string labelText = "Соберите все четыре предмета и получите свободу";
    public int maxItem = 4; //max item on scene
    public bool showWinScreen = false;
    public bool ShowLoseScreen = false;
    private void RestartLevel()
    {
        SceneManager.LoadScene(0); // reload scene
        Time.timeScale=1.0f; 
    }
    public int Items{
        get {return _itemsCollected;}
        set{
            _itemsCollected = value;
            //here use keyword value for setting new value
            Debug.LogFormat($"Items: {_itemsCollected} items");
            if(_itemsCollected>=maxItem)
            {
                labelText = "Вы собрали все предметы!";
                showWinScreen = true;
                Time.timeScale=0f; //freeze game
            }
            else{
                labelText = "Предмет найдет! Осталось найти еще " + (maxItem- _itemsCollected) + "!!";
            }
        }
    }
    public int HP{
        get{
            return _PlayerHP;
        }
        set{
            _PlayerHP = value;
            Debug.LogFormat($"Lives {_PlayerHP}");
            if(_PlayerHP <=0) //gameover confition
            {
                ShowLoseScreen = true;
                Time.timeScale=0;
            }else{
                labelText = "Это было больно ...." ;
            }
        }
    }
    void OnGUI() {
        //draw hp box
        GUI.Box(new Rect(20,20,150,25),"Player Health: " + _PlayerHP);
        //draw items collected
        GUI.Box(new Rect(20,50,150,25), "Item Collected: " + _itemsCollected );
        //Draw text
        GUI.Label(new Rect(Screen.width/2 -100, Screen.height - 50,380,50),labelText);
        //show WinScreen
        if(showWinScreen)
        {
            if(GUI.Button(new Rect(Screen.width/2-100,Screen.height/2-100,320,200),"You WON!"))
            {
                RestartLevel(); 
            }
        }
        if(ShowLoseScreen)
        {
            if(GUI.Button(new Rect(Screen.width/2-100,Screen.height/2-100,320,200),"Try again!"))
            {
                RestartLevel();
            }
        }
    }
}
