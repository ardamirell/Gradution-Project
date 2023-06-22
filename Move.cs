using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float moveSpeed = 6f; // Move Speed

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal"); // Horizontal Move
        float moveVertical = Input.GetAxis("Vertical"); // Vertical Move

        if (Input.GetKey(KeyCode.D))
            moveHorizontal = 1f;
        else if (Input.GetKey(KeyCode.A))
            moveHorizontal = -1f;
        else
            moveHorizontal = 0f;

        if (Input.GetKey(KeyCode.W))
            moveVertical = 1f;
        else if (Input.GetKey(KeyCode.S))
            moveVertical = -1f;
        else
            moveVertical = 0f;

        Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0f) * moveSpeed * Time.deltaTime;
        transform.Translate(movement);
    }
}