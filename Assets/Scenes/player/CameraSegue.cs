using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSegue : MonoBehaviour
{
    public GameObject player;
    public float pX;
    public float pY;
    public float limiteX1;
    public float limiteY1;
    public float limiteX2;
    public float limiteY2;
    public Vector3 posInicial;

    void Start()
    {
        posInicial = transform.position;
        player = GameObject.FindWithTag("Player");
    }

   
    void Update()
    {
        if(player != null)
        {
           
            pX = player.transform.position.x;
            pY = player.transform.position.y;
        }
        
        if(pY <= -13.62)
        {
            transform.position = posInicial;
        }

        if(pX > -13.62 && pY > 1 && pX < 30)
        {
            transform.position = new Vector3(pX, pY, -1);
        }

        if(player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player");
            transform.position = posInicial;
        }
        
    }
}
