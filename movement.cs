using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    Rigidbody2D player;
    public float speed;
    Vector3 Velocity;
    public float jumpforce;
    public bool isGrounded;
    Animator anim;
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    


 
    void Update()
    {
        Velocity = new Vector3(Input.GetAxis("Horizontal"), 0f);
        transform.position += Velocity * speed *Time.deltaTime;




        if (Input.GetButtonDown("Jump") && Mathf.Approximately(player.velocity.y,0))
        {
                player.AddForce(Vector3.up * jumpforce, ForceMode2D.Impulse);
        }

        if (Input.GetAxisRaw("Horizontal") == 1)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        else if (Input.GetAxisRaw("Horizontal") == -1)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }

     

    }



}


