using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    public float jump;
    public bool isjump;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        isjump = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isjump == false)
        {
            rb.velocity = new Vector2 (0, jump);
            isjump = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        isjump = false;
    }
}
