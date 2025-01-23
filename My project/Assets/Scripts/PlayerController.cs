using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    private float moveHorizontal;
    public Rigidbody2D rb2d;
    public float speed=20;
    private bool jump=false;
    public float jumpSpeed=10;
    private bool grounded=false;
    void Start()
    {
        rb2d.freezeRotation = true;
        FindObjectOfType<GrCheck>();
        speed = 10;
        jumpSpeed = 10;
    }
    public void CJump()
    {
        grounded = true;
    }

    public void NoJump()
    {
        grounded = false;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(grounded);
        moveHorizontal = Input.GetAxis("Horizontal");
        if (Input.GetKeyDown(KeyCode.Space)&&grounded)
        {
            jump = true;
        }
        //Debug.Log(CanJump);
    }

    void FixedUpdate()
    {
        rb2d.velocity = new Vector2(moveHorizontal * speed, rb2d.velocity.y);
        if (jump&& grounded)
        {
            jump = false;
            grounded = false;
            rb2d.velocity = new Vector2(rb2d.velocity.x, jumpSpeed);
        }
    }
}
