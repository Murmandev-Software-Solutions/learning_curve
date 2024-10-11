using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    // Start is called before the first frame update
    public string Name;
    public int Exp;
    //default constructor
    public Character()
    {
        this.Name = "Not Assigned";
    }
    //class constructor
    public Character(string name, int exp){
        this.Name = name;
        this.Exp = exp;
    }
    public void PrintStat()
    {
        Debug.LogFormat($"Hero: {this.Name} - Exp {this.Exp}");
    }
}
