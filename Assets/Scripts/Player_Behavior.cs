using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Behavior : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float rotationSpeed = 75f;
    private float vInput;
    private float hInput;
    private Rigidbody _rb;
    public float jumpVelocity = 5f;
    void Start()
    {
        //инициализация физики
        _rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        //Одновременно работать либо с RigidBody либо прямое управвление через трансформацию
        vInput = Input.GetAxis("Vertical") * moveSpeed;
        hInput = Input.GetAxis("Horizontal") * rotationSpeed;
        /*
        this.transform.Translate(Vector3.forward * vInput * Time.deltaTime);
        this.transform.Rotate(Vector3.up * hInput * Time.deltaTime);
        */
    }
    void FixedUpdate()
    {
        Vector3 rotatation = Vector3.up * hInput;
        Quaternion angleRot = Quaternion.Euler(rotatation * Time.fixedDeltaTime);
        //необходимо пояснение по этой функции 
        _rb.MovePosition(this.transform.position + this.transform.forward * vInput * Time.fixedDeltaTime);
        _rb.MoveRotation(_rb.rotation * angleRot);
        // add jump
        if(Input.GetKeyDown(KeyCode.Space))
        {
            _rb.AddForce(Vector3.up * jumpVelocity,ForceMode.Impulse);
        }
    }
}
