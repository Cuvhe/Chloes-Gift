using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOnTouch : MonoBehaviour
{
    [SerializeField]
    public List<Transform> waypoints;
    public float moveSpeed;
    public int target;
    private bool moving;
    private Vector3 velocity;
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, waypoints[target].position, moveSpeed * Time.deltaTime);
    }

    
    

    private void FixedUpdate()

    {
        if (moving)
        {
            transform.position += (velocity *Time.deltaTime);
        }

        

    }
    private void OnCollisionEnter2D(Collision2D collision)
    
    {

       
       {
            moving = true;
            collision.collider.transform.SetParent(transform);
       }

            

        

    }
    private void OnCollisionExit2D(Collision2D collision)

    {
        
        {
            collision.collider.transform.SetParent(null);
            
        }
        
    }

}
