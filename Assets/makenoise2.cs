using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makenoise2 : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D other){
        GetComponent<AudioSource>().Play();
    
        DontDestroyOnLoad(gameObject);
		
	}
  
}