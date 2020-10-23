/*
    File Name: BulletController.cs
    Student Name: Han Zhan
    Student ID: 101141379
    Date last Modified: 2020/10/21
    Program description: Controller bullet move.
    Revision History: Modified the movement direction and position of the bullet.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour, IApplyDamage
{
    //public float verticalSpeed;
    //public float verticalBoundary;
    public float XSpeed;
    public float XBoundary;
    public BulletManager bulletManager;
    public int damage;
    
    // Start is called before the first frame update
    void Start()
    {
        bulletManager = FindObjectOfType<BulletManager>();
        transform.Rotate(new Vector3(0, 0, -90));
    }

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _Move()
    {
        //transform.position += new Vector3(0.0f, verticalSpeed, 0.0f) * Time.deltaTime;
        transform.position += new Vector3(XSpeed, 0.0f, 0.0f) * Time.deltaTime;

    }

    private void _CheckBounds()
    {
        if (transform.position.x > XBoundary)
        {
            bulletManager.ReturnBullet(gameObject);
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log(other.gameObject.name);
        bulletManager.ReturnBullet(gameObject);
    }

    public int ApplyDamage()
    {
        return damage;
    }
}
