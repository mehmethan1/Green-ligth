using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    Rigidbody rb;

    public bool moveLeft;
    public bool moveRigth;
    private float horizontalMove;
    public float speed = 5;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

        moveLeft = false;
        moveRigth = false;
    }

    public void PointerDownLeft()
    {
        moveLeft = true;
    }

    public void PointerUpLeft()
    {
        moveLeft = false;
    }

    public void PointerDownRigth()
    {
        moveRigth = true;
    }

    public void PointerUpRigth()
    {
        moveRigth = false;
    }

    private void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        if (moveLeft)
        {
            horizontalMove = -speed;
        }
        else if (moveRigth)
        {
            horizontalMove = speed;
        }
        else
        {
            horizontalMove = 0;
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(horizontalMove, rb.velocity.y, rb.velocity.z);
    }
}
