using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrCheck : MonoBehaviour
{
    // Start is called before the first frame update
    PlayerController controller;
    
    void Start()
    {
        controller=FindObjectOfType<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer==6)
        {
            controller.CJump();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            controller.NoJump();
        }
    }
}
