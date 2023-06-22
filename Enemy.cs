using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform target;

    public float moveSpeed = 3f; // Move Speed

    void Update()
    {
        if (target != null)
        {
            Vector3 direction = target.position - transform.position;
            direction.Normalize();

            Vector3 movement = direction * moveSpeed * Time.deltaTime;
            transform.Translate(movement);
        }
    }
}