using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float moveH;
    public int velocidade;
    public int forcaPulo;
    private Rigidbody2D rb;
    public bool isJumping = false;
    public bool comVida = true;
    public Vector3 posInicial;
    

    void Start()
    {
        posInicial = transform.position;
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate() 
    {
        moveH = Input.GetAxis("Horizontal");
        transform.position += new Vector3(moveH * velocidade * Time.deltaTime, 0, 0);
    }

    void Update()
    {
    

        if(Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            rb.AddForce(transform.up * forcaPulo,ForceMode2D.Impulse);
            isJumping = true;
        }
        
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.gameObject.CompareTag("Floor"))
        {
            isJumping = false;
        }
    }}


    
