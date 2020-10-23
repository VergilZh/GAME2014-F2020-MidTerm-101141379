/*
    File Name: EnemyController.cs
    Student Name: Han Zhan
    Student ID: 101141379
    Date last Modified: 2020/10/21
    Program description: Controller enemy move.
    Revision History: Modified the movement direction of the enemy, and can move up and down.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    //public float horizontalSpeed;
    //public float horizontalBoundary;
    public float YSpeed;
    public float YBoundary;
    public float direction;

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _Move()
    {
        //transform.position += new Vector3(horizontalSpeed * direction * Time.deltaTime, 0.0f, 0.0f);
        transform.position += new Vector3(0.0f, YSpeed * direction * Time.deltaTime, 0.0f);
    }

    private void _CheckBounds()
    {
        // check right boundary
        if (transform.position.y >= YBoundary)
        {
            direction = -1.0f;
        }

        // check left boundary
        if (transform.position.y <= -YBoundary)
        {
            direction = 1.0f;
        }
    }
}
