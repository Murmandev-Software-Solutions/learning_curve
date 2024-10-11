using System.Collections;
using System.Collections.Generic;
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

    void Start()
    {
        Debug.LogFormat("Через {0} лет вам будет {1}", AddedAge,ComputeAge(CurrentAge,AddedAge));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
