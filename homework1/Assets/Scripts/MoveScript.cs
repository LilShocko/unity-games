using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour{
    private Rigidbody2D rb;
    public float jumpForce;
    bool isGrounded;
    public Transform groundCheck;
    public LayerMask groundlayer;

    void Start(){
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update(){
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundlayer);
        groundCheck.transform.localPosition = new Vector3(0, -0.79f, 0);
        if (Input.GetKey("d")){
            transform.Translate(4 * Time.deltaTime, 0,0);
        }
        if (Input.GetKey("a")){
            transform.Translate(-4 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKeyDown("w") && isGrounded)
        {
            //transform.Translate(0, 50 * Time.deltaTime, 0);
            rb.velocity = Vector2.up * jumpForce;
        }

    }
}
