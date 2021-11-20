using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walk : MonoBehaviour
{
    private float playerSpeed = 6.5f;

    void FixedUpdate()
    {
        float moveX = 0f;
        float moveY = 0f;
        if(static_walk.can_walk == true)
        {
            if (Input.GetKey(KeyCode.W))
            {
                moveY = +1f;   
            }
            if (Input.GetKey(KeyCode.S))
            {
                moveY = -1f;
            }
            if (Input.GetKey(KeyCode.A))
            {
                moveX = -1f;
            }
            if (Input.GetKey(KeyCode.D))
            {
                moveX = +1f;
            }
            Vector3 moveDir = new Vector3(moveX, moveY).normalized;

            Vector3 targetMovePosition = transform.position + moveDir * playerSpeed * Time.deltaTime;
            RaycastHit2D rh = Physics2D.Raycast(transform.position, moveDir, playerSpeed * Time.deltaTime);
            transform.position = targetMovePosition;
        }
    }
}
