using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    public float OnScreenDelay = 3f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, OnScreenDelay);
    }
}
