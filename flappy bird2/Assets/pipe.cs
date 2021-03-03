using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe : MonoBehaviour

{ 
    public float vel=2f;
    
    // Start is called before the first frame update
   

    private void Update(){
        if(jump.hit){
            vel=0;
        }
    
    }
    private void FixedUpdate()
    {
       transform.position=new Vector2(transform.position.x-(vel*Time.fixedDeltaTime),transform.position.y);
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
       jump.point++;
    }
}
