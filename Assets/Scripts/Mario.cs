using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mario : MonoBehaviour
{

    public Rigidbody2D _rigidBody2D;
    public float HorizontalSpeed = 2f;
    public float thrust = 10;
    public bool isMoving = false;

    void Awake() 
    {
        _rigidBody2D = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0.0f, -2.0f, 0.0f);
    }

    // Update is called once per frame

    void Update() 
    {
     
    }

   void FixedUpdate() 
   {
    if (Input.GetButton("Jump"))
    {
        _rigidBody2D.AddForce(transform.up * thrust);
    }
    
    _rigidBody2D.velocity = new Vector2(5f, 0f);
    isMoving = true;
    Debug.Log("Moving!");
   }
    

}
