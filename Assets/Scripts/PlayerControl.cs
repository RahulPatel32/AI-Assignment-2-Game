using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

    public float speed;

    private Rigidbody rigidBody;

    void Start ()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    //void Update ()
    //{
    //    transform.position = new Vector3(Mathf.Clamp(transform.position.x, -10.13f, 9.95f), Mathf.Clamp(transform.position.y, -3.91f, 4.13f),transform.position.z);
    //}

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);
        rigidBody.velocity = movement * speed;
    }
}
