using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using UnityEngine;

public class Camera_Behavior : MonoBehaviour
{
    
    public Vector3 camOffset = new(0f,1.3f,-2.6f);
    [SerializeField]private Transform target;
    public void Start()
    {
        target = GameObject.Find("Player").transform;
        Debug.Log("Camera script active");
    }
    public void LateUpdate() //не путать с LastUpdate
    {
        
        // следование камеры
        this.transform.position = target.TransformPoint(camOffset);
        this.transform.LookAt(target);
        
    }
    public void FixedUpdate() {

    }
}