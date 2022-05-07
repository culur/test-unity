using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class padderBehavior : MonoBehaviour
{

    public static Rigidbody2D rb;
    public float moveSpeed;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        TouchMove();
    }



    void TouchMove()
    {
        if (Input.GetMouseButton(0))
        {
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if (touchPos.x > rb.position.x)
            {
                rb.velocity = Vector2.right * moveSpeed;
                //move to right
            } else
            {
                //move to left
                rb.velocity = Vector2.left * moveSpeed;
            }


        } else
        {
            rb.velocity = Vector2.zero;
        }

    }
}
