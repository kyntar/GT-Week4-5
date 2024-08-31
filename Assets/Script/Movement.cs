using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    float jumpForce;
    Rigidbody2D rb;
    int speed;
    private bool canJump;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        speed = 3;
        jumpForce = 5f;
        canJump = true;
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Pindah")
        {
            SceneManager.LoadScene("Scene3");
        }
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(0, rb.velocity.y);
        if(Input.GetKey(KeyCode.D)){
            rb.velocity = new Vector2(speed,0);
        }
        if(Input.GetKey(KeyCode.A)){
            rb.velocity = new Vector2(-speed,0);
        }
        if (Input.GetKeyDown(KeyCode.Space) && canJump)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            canJump = false;
        }
        if (rb.velocity.y == 0)
        {
            canJump = true;
        }
}
}
