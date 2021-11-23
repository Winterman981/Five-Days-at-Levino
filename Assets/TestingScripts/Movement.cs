using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public int moveSpeed;

    public Rigidbody2D rb;
    public Camera cam;

    Vector2 movement;
    Vector2 mousePos;

    public GameObject player;

    void Update() //Mouselook
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        //mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

        SpriteControl();
    }

    void FixedUpdate() //Movement
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

        //Vector2 lookDir = mousePos - rb.position;
        //float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;
        //rb.rotation = angle;
    }

    public void getNewMovement(int newSpeed)
	{
        moveSpeed = newSpeed;
        Debug.Log("Changed speed to " + moveSpeed);
	}

    public void SpriteControl()
	{
        if(Input.GetKeyDown(KeyCode.W))
		{
            player.transform.rotation = Quaternion.Euler(0, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            player.transform.rotation = Quaternion.Euler(0, 0, 90);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            player.transform.rotation = Quaternion.Euler(0, 0, 180);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            player.transform.rotation = Quaternion.Euler(0, 0, -90);
        }

        //if (Input.GetKeyDown(KeyCode.W) && Input.GetKeyDown(KeyCode.A))
        //{
        //    player.transform.rotation = Quaternion.Euler(0, 0, 45);
        //}

        //if (Input.GetKeyDown(KeyCode.W) && Input.GetKeyDown(KeyCode.D))
        //{
        //    player.transform.rotation = Quaternion.Euler(0, 0, -45);
        //}

        //if (Input.GetKeyDown(KeyCode.S) && Input.GetKeyDown(KeyCode.A))
        //{
        //    player.transform.rotation = Quaternion.Euler(0, 0, 135);
        //}

        //if (Input.GetKeyDown(KeyCode.S) && Input.GetKeyDown(KeyCode.D))
        //{
        //    player.transform.rotation = Quaternion.Euler(0, 0, -135);
        //}
    }
}
