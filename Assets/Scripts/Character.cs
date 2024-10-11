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
    private void Reset()
    {
        this.Name = "Not Assigned";
        this.Exp = 0;
    }
}
public struct Weapon
{
    public string name;
    public int damage;
    public Weapon(string name,int damage)
    {
        this.name = name;
        this.damage = damage;
    }
    public void PrintWeaponStat()
    {
        Debug.LogFormat($"Weapon {this.name}, has damage {this.damage}");
    }
}
