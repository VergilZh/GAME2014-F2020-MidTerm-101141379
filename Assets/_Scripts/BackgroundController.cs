/*
    File Name: BackgroundController.cs
    Student Name: Han Zhan
    Student ID: 101141379
    Date last Modified: 2020/10/21
    Program description: Controller background move and update.
    Revision History: change the y boundary and horizontal to x.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    //public float verticalSpeed;
    //public float verticalBoundary;
    public float XSpeed;
    public float XBoundary;

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _Reset()
    {
        //transform.position = new Vector3(0.0f, verticalBoundary);
        transform.position = new Vector3(XBoundary, 0.0f);
    }

    private void _Move()
    {
        //transform.position -= new Vector3(0.0f, verticalSpeed) * Time.deltaTime;
        transform.position -= new Vector3(XSpeed, 0.0f) * Time.deltaTime;
    }

    private void _CheckBounds()
    {
        // if the background is lower than the bottom of the screen then reset
        if (transform.position.x <= -XBoundary)
        {
            _Reset();
        }
    }
}
