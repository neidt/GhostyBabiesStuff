using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 7f;
    public Vector3 direction = Vector3.down;

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            if (direction != Vector3.up)
            {
                direction = Vector3.up;
            }
            TurnPlayer(direction);
            MovePlayer(moveSpeed, direction);
        }
        if (Input.GetKey(KeyCode.S))
        {
            if (direction != Vector3.down)
            {
                direction = Vector3.down;
            }
            TurnPlayer(direction);
            MovePlayer(moveSpeed, direction);
        }
        if (Input.GetKey(KeyCode.A))
        {
            if (direction != Vector3.left)
            {
                direction = Vector3.left;
            }
            TurnPlayer(direction);
            MovePlayer(moveSpeed, direction);
        }
        if (Input.GetKey(KeyCode.D))
        {
            if (direction != Vector3.right)
            {
                direction = Vector3.right;
            }
            TurnPlayer(direction);
            MovePlayer(moveSpeed, direction);
        }
    }

    private void MovePlayer(float speed, Vector3 moveDir)
    {
        transform.position += moveDir * speed * Time.deltaTime;
    }

    private void TurnPlayer(Vector3 turnDir)
    {
        transform.Rotate(turnDir);
    }

}
