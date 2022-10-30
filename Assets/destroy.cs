using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    public GameObject Square;

    void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player")
        {
           Destroy(Square); 
        }
    }
    
}
