using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Behavior : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float rotationSpeed = 75f;
    private float vInput;
    private float hInput;
    // Start is called before the first frame update
    // This is empty, and because it removed

    // Update is called once per frame
    void Update()
    {
        vInput = Input.GetAxis("Vertical") * moveSpeed;
        hInput = Input.GetAxis("Horizontal") * rotationSpeed;
        this.transform.Translate(Vector3.forward * vInput * Time.deltaTime);
        this.transform.Rotate(Vector3.up * hInput * Time.deltaTime);
    }
}
