using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Right : MonoBehaviour
{
    float jumpPower = 9f;
    float movePower = 5f;

    Vector3 moveD = Vector3.zero;
    Rigidbody2D rigid;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Move("LEFT");
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Move("RIGHT");
        }
        
        if (Input.GetKey(KeyCode.UpArrow)&&transform.position.y <= -3.5f)
        {
            Jump();
        }
    }
    private void Jump()
    {
        rigid.velocity = Vector2.zero;

        Vector2 jumpVelocity = new Vector2(0, jumpPower);
        rigid.AddForce(jumpVelocity, ForceMode2D.Impulse);
    }

    private void Move(string str)
    {
        switch (str)
        {
            case "LEFT":
                moveD = Vector3.left;
                break;
            case "RIGHT":
                moveD = Vector3.right;
                break;
        }
        transform.position += moveD * movePower * Time.deltaTime;
    }
    
}
