using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayersMovement : MonoBehaviour
{

    public float speed = 10f;
    public float rotationSpeed = 200f;

    public Animator anim;

    

    void Start()
    {
        anim = GetComponent<Animator>();

    }

  
    void Update()
    {


        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
            anim.SetBool("forward", true);
        }
        else
        {
            anim.SetBool("forward", false);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
            anim.SetBool("back", true);
        }
        else
        {
            anim.SetBool("back", false);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(-Vector3.forward, rotationSpeed * Time.deltaTime);
            anim.SetBool("rotateRight", true);
        }
        else
        {
            anim.SetBool("rotateRight", false);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
            anim.SetBool("rotateLeft", true);
        }
        else
        {
            anim.SetBool("rotateLeft", false);
        }

        // X axis
        /*if(transform.position.x <= -10f)
        {
            transform.position = new Vector2(-10f, transform.position.y);
        }
        else if (transform.position.x >= 10f)
        {
            transform.position = new Vector2(10f, transform.position.y);
        }

        // Y axis
        if (transform.position.y <= -10f)
        {
            transform.position = new Vector2(transform.position.x, -10f);
        }
        else if (transform.position.y >= 10f)
        {
            transform.position = new Vector2(transform.position.x, 10f);
        }*/
        
        var pos = Camera.main.WorldToViewportPoint(transform.position);
        pos.x = Mathf.Clamp(pos.x, 0, 1);
        pos.y = Mathf.Clamp(pos.y, 0, 1);
        transform.position = Camera.main.ViewportToWorldPoint(pos);
        
    }
    
    

}
   