using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    int count=0;
    public AudioSource wing;
    public AudioSource die;
    public AudioSource hitbase;
    public AudioSource pointsound;
    float initialpoint=0f; 
    public float deltaangle=1f;
    float rotangle=-45;
    public static float point=0;
    public static bool hit=false;
    Animator bird;
    Rigidbody2D rb;
    public float vel=1;
    // Start is called before the first frame update
    void Start()
    {
        bird=GetComponent<Animator>();
        rb=GetComponent<Rigidbody2D>();
        wing=GetComponent<AudioSource>();
        // die=GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(initialpoint<point){
            pointsound.Play();
            initialpoint=point;

        }

        if(Input.GetMouseButtonDown(0)){
            if(vel!=0){
            wing.Play();
            rotangle=45;
            rb.velocity=Vector2.up*(vel);
            // Debug.Log("pressed");
            }

        }else{
            if(rotangle>=-90){
                rotangle-=deltaangle*Time.deltaTime;
            }

            // Debug.Log("not pressed");
        }
        transform.rotation=Quaternion.Euler(transform.rotation.x,transform.rotation.y,rotangle);
       

        
    }


    private void OnCollisionEnter2D(Collision2D other)
    {       if(other.gameObject.CompareTag("base")){
                hitbase.Play();
                count++;
            }
            else
            if(count==0){
             die.Play();
             count++;
            }
       
        rotangle=-90;
        hit=true;
        bird.enabled=false;
        vel=0;
        rb.gravityScale=3;
    }
}
