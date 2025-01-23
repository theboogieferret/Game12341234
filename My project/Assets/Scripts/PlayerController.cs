using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    private float moveHorizontal;
    public Rigidbody2D rb2d;
    public float speed;
    private bool jump=false;
    public float jumpSpeed;
    void Start()
    {
        rb2d.freezeRotation = true;
        FindObjectOfType<GrCheck>();
    }

    // Update is called once per frame
    void Update()
    {
        moveHorizontal = Input.GetAxis("Horizontal");
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jump = true;
        }

    }

    void FixedUpdate()
    {
        rb2d.velocity = new Vector2(moveHorizontal * speed, rb2d.velocity.y);

        if (jump)
        {
            Debug.Log("jump");
            jump = false;
            rb2d.velocity = new Vector2(rb2d.velocity.x, jumpSpeed);
        }
    }
}
