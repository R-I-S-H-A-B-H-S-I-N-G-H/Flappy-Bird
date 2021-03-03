using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundmanager : MonoBehaviour
{
    public static AudioClip wing;
    public static AudioSource src;
    // Start is called before the first frame update
    void Start()
    {
        wing=Resources.Load<AudioClip>("wing");
        src=GetComponent<AudioSource>();
        
    }
   public static void playsound(string clip){
        if(clip=="wing"){
           
           Debug.Log("sound plays here");

        }

    }
}
