using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour {

    public float jumpForce = 200f;
    Rigidbody2D rb;

    public float forwardSpeed = 2f;


    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        rb.transform.Translate(new Vector3(1, 0, 0) * forwardSpeed * Time.deltaTime);
        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = Vector2.zero;
            rb.AddForce(Vector2.up * jumpForce);
        }

    }


}
