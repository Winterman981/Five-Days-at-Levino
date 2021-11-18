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

    void Update() //Mouselook
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        //mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

        //SpriteControl();
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
            this.gameObject.transform.Rotate(0, 0, 0, Space.Self);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            this.gameObject.transform.Rotate(0, 0, -90, Space.Self);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            this.gameObject.transform.Rotate(0, 0, 180, Space.Self);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            this.gameObject.transform.Rotate(0, 0, 90, Space.Self);
        }
    }
}
