using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paladin : Character
{
    Weapon weapon;
    public Paladin(string name,Weapon weapon) : base(name)
    {
        this.weapon = weapon;
    }
    public override void PrintStat()
    {
        Debug.LogFormat($"Hail {this.Name}!! Take your {this.weapon.name}");
    }
}
