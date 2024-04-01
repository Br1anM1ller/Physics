using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SupermanMovement : MonoBehaviour
{
    public Transform targetPoint;
    public float speed = 5f;

    private bool isMovingToPoint = false;

    void Update()
    {
        if (isMovingToPoint)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, targetPoint.position, step);

            if (transform.position == targetPoint.position)
            {
                isMovingToPoint = false;
            }
        }
    }

    public void MoveToPoint()
    {
        isMovingToPoint = true;
    }
}
