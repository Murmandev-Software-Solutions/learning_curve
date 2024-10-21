using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//implement of game manager 
public class GameBehavior : MonoBehaviour
{
    private int _itemsCollected = 0;
    private int _PlayerHP = 10;
    //add getters and setters

    public int Items{
        get {return _itemsCollected;}
        set{
            _itemsCollected = value;
            //here use keyword value for setting new value
            Debug.LogFormat($"Items: {_itemsCollected} items");
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
}
