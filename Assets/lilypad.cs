using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Deathzone : MonoBehaviour

{

    void OnCollisionEnter2D(Collider2D collision){
        if (collision.gameObject.CompareTag("Player")) {
            Destroy(gameObject);
        }
    }

   


}
