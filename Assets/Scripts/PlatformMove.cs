using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlatformMove : MonoBehaviour
{
    public Transform pos1, pos2;
    public float speed = 1f;
    public Transform startPos;

    private Vector3 nextPos;
    private Rigidbody2D rb;

    void Start()
    {
        nextPos = startPos.position;


        rb = GetComponent<Rigidbody2D>();
        if (rb == null)
        {
            rb = gameObject.AddComponent<Rigidbody2D>();
        }
        rb.isKinematic = true;
    }

    void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, nextPos, speed * Time.deltaTime);

        if (transform.position == pos1.position)
        {
            nextPos = pos2.position;
        }
        else if (transform.position == pos2.position)
        {
            nextPos = pos1.position;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(pos1.position, pos2.position);
    }
}