using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextScene : MonoBehaviour
{
    private Rigidbody2D rb;
    private float dirX, moveSpeed;

    // Use this for initialization
    void start () {
        rb = GetComponent<Rigidbody2D>();
        moveSpeed = 5f;
     }

    // Update is called once per frame
    void Update () {
        dirX = Input.GetAxis("Horizontal") * moveSpeed;
    }

    
}
