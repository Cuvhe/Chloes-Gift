using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class stopnoise : MonoBehaviour
{
      private void OnTriggerEnter2D(Collider2D other){
        GetComponent<AudioSource>().Stop();
        
        DontDestroyOnLoad(gameObject);

        }
        
     
}
