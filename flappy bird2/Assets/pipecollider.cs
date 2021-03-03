using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipecollider : MonoBehaviour
{
    Collider2D box;
    // Start is called before the first frame update
    void Start()
    {
         box=GetComponent<Collider2D>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if(jump.hit){
            box.enabled=false;
        }
        
    }
}
