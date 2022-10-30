using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
 { public float dashDistance; public float dashCooldown; public LayerMask ignoreRay; public Transform rayStartPoint; private Transform player;

void Awake()
{
    //Find the player object and set it
    player = GameObject.FindGameObjectWithTag("Player").transform;

}

void Update()
{


    if (Input.GetMouseButtonDown(1))
    {

        StartCoroutine(DashRay());

    }
}

void DisableObj()
{
    player.GetComponent<SpriteRenderer>().enabled = false;
    player.GetComponent<BoxCollider2D>().enabled = false;
    player.GetComponent<Rigidbody2D>().isKinematic = true;
}

void EnableObj()
{
    player.GetComponent<SpriteRenderer>().enabled = true;
    player.GetComponent<BoxCollider2D>().enabled = true;
    player.GetComponent<Rigidbody2D>().isKinematic = false;
}

IEnumerator DashRay()
{
    //in order so return the direction of the ray
    Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;

    //to have the coords of the end of the ray in case there is no collision
    Vector2 end = player.position + difference * dashDistance;

    RaycastHit2D hit = Physics2D.Raycast(rayStartPoint.position, difference, dashDistance, ignoreRay);
    Debug.DrawRay(rayStartPoint.position, difference, Color.red, dashDistance);

    //if the ray hits something have the position of the player be the point of collision of the ray,
    //else have it be the position of the end of the ray



    DisableObj();



    if (hit)
    {
        Debug.Log(hit.transform.name);
        player.position = hit.point;

    }
    else
    {
        player.position = end;

    }

    yield return new WaitForSecondsRealtime(0.5f);



    EnableObj();
    Debug.Log("we waited");


    yield return null;

}

}


