using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boxmovment : MonoBehaviour
{
    Rigidbody Rigidbody;
    public float movementSpeed;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody = GetComponent<Rigidbody>();
        movementSpeed = 2f; 
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W)){
        
            Rigidbody.AddForce(Vector3.right * movementSpeed, ForceMode.Impulse);
        }
    }
}
