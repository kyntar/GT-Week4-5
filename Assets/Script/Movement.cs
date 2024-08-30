using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    Rigidbody2D rb;
    int speed;

    // Start is called before the first frame update
    public void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        speed = 2;
    }

    // Update is called once per frame
    public void Update()
    {
        if(Input.GetKey(KeyCode.D)){
            rb.velocity = new Vector2(speed,0);
        }
    }
}
