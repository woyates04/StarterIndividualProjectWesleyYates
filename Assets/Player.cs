using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float horizontalInput;
    private float verticalInput;
    private float speed;
    private float horizontalScreenSize = 8f;
    private float verticalScreenSize = 4.5f;
  
    // Start is called before the first frame update
    void Start()
    {
        speed = 4f;
    }

    // Update is called once per frame
    void Update()
    {
        Movement();

    }

    void Movement()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(horizontalInput, verticalInput, 0) * Time.deltaTime * speed);

        if (transform.position.x > horizontalScreenSize)
        {
            transform.position = new Vector3(horizontalScreenSize, transform.position.y, 0);
        }


        if (transform.position.x <= -horizontalScreenSize)
        {
            transform.position = new Vector3(-horizontalScreenSize, transform.position.y, 0);
        }


        if (transform.position.y > verticalScreenSize)
        {
            transform.position = new Vector3(transform.position.x, verticalScreenSize, 0);
        }


        if (transform.position.y <= -verticalScreenSize)
        {
            transform.position = new Vector3(transform.position.x, -verticalScreenSize, 0);
        }
    }

}
   
