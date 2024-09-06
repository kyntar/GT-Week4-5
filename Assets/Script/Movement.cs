using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float moveSpeed = 5f;
    public Animator animasi;
    public bool isLeft;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Pindah")
        {
            SceneManager.LoadScene("Scene3");
        }
    }
    
    void Update()
    {
        Walk();
    }
   
    void Walk()
    {
        float moveInput = Input.GetAxis("Horizontal");
        rb.velocity=  new Vector2(moveInput * moveSpeed, rb.velocity.y);
        if(moveInput != 0 )
        {
            animasi.SetBool("isWalking" , true);
        }else{
            animasi.SetBool("isWalking" , false);
        }
        if(moveInput > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
            isLeft = false;
        }
        else if(moveInput < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
            isLeft = true;
        }
    }
}
