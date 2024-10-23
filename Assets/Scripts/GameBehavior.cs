using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEngine;

//implement of game manager 
public class GameBehavior : MonoBehaviour
{
    private int _itemsCollected = 0;
    private int _PlayerHP = 10;
    //add getters and setters
    public string labelText = "Соберите все четыре предмета и получите свободу";
    public int maxItem = 4; //max item on scene
    public int Items{
        get {return _itemsCollected;}
        set{
            _itemsCollected = value;
            //here use keyword value for setting new value
            Debug.LogFormat($"Items: {_itemsCollected} items");
            if(_itemsCollected>=maxItem)
            {
                labelText = "Вы собрали все предметы!";
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
        }
    }
    void OnGUI() {
        //draw hp box
        GUI.Box(new Rect(20,20,150,25),"Player Health: " + _PlayerHP);
        //draw items collected
        GUI.Box(new Rect(20,50,150,25), "Item Collected: " + _itemsCollected );
        //Draw text
        GUI.Label(new Rect(Screen.width/2 -100, Screen.height - 50,380,50),labelText);

    }
}
