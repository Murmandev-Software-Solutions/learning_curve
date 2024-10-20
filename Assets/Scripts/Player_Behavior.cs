using System;
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
    public float distanceToGround = 0.1f;
    public LayerMask groundLayer;
    private CapsuleCollider _col;

    void Start()
    {
        //инициализация физики
        _rb = GetComponent<Rigidbody>();
        //get player capsule collider 
        _col = GetComponent<CapsuleCollider>();
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
        if(isGrounded() && Input.GetKeyDown(KeyCode.Space))
        {
            _rb.AddForce(Vector3.up * jumpVelocity,ForceMode.Impulse);
        }
    }
    private bool isGrounded()
    {
        //get center botton of capsule
        Vector3 capsuleBotton = new Vector3(_col.bounds.center.x,_col.bounds.min.y,_col.bounds.center.z);
        //check interaction 
        bool grounded = Physics.CheckCapsule(_col.bounds.center,capsuleBotton,distanceToGround,groundLayer, QueryTriggerInteraction.Ignore);

        return grounded;
    }
}
