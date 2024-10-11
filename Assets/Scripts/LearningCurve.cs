using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    //В этом файле будут происходить действия из глав 1 2 3 4

    private int CurrentAge = 39;
    public int AddedAge = 1;
    
/// <summary>
/// Вычесление суммы лет 
/// </summary>
/// <param name="a">текущий возраст</param>
/// <param name="b">прибавление</param>
/// <returns>сумма лет</returns>
/// <summary>
    public int ComputeAge(int a, int b)
    {
        return a+b;
    }
    //variable for whole script
    //Character hero = new Character();
    void Start()
    {
        //local variable
        var weapon = new Weapon("Hunting bow", 105);
        var warBow = weapon;
        var hero = new Character();
        var hero2 = new Character("Agatha",10);
        Debug.LogFormat("Через {0} лет вам будет {1}", AddedAge,ComputeAge(CurrentAge,AddedAge));
        //use interpolate string
        //Debug.LogFormat($"Hero: {hero.Name} - Exp:{hero.Exp}");
        hero.PrintStat();
        hero2.PrintStat();
        
        weapon.PrintWeaponStat();
        warBow.name ="War Bow";
        warBow.PrintWeaponStat();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
