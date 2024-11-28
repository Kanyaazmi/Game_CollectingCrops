using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float movSpeed = 5f;
    Rigidbody2D rb2;
    public Animator anim;
    public int facingDirection = 1;
    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();   
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        Vector2 move = new Vector2 (moveX, moveY);

        if (moveX > 0 && transform.localScale.x < 0 || moveX < 0 && transform.localScale.x > 0)
        {
            Flip();
        }

        if (moveX != 0 || moveY != 0)
        {
            anim.SetFloat("isMoving", 1);
        }
        else
        {
            anim.SetFloat("isMoving", 0);
        }


        rb2.velocity = move * movSpeed;
    }

    void Flip()
    {
        facingDirection *= -1;
        transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
    }
}
