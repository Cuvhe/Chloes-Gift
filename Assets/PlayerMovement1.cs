using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement1 : MonoBehaviour
{
    public CharacterController2D controller;
    static AudioSource audioSrc;
    public float runSpeed = 40f;
    AudioClip jumpsound;
    public AudioSource audioPlayer;
    Rigidbody2D rb;
    float horizontalMove = 0f;
    bool jump = false;
    bool isMoving = false;
    // Start is called before the first frame update
   
    // Update is called once per frame
    
    void Start () {
        rb = GetComponent<Rigidbody2D> ();
        audioPlayer = GetComponent<AudioSource> ();
        jumpsound=GetComponent<AudioClip>();

        audioSrc = GetComponent<AudioSource> ();
    }
    
    void Update()
    {
        jumpsound = Resources.Load <AudioClip> ("jumpsound");
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }

       
    }

   

    void FixedUpdate ()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }

    public void OnTriggerEnter(Collision2D collision){

        if(collision.gameObject.tag == "Banjo"){
            audioPlayer.Play();
        }
        
 }
}
