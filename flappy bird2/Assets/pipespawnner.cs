using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipespawnner : MonoBehaviour
{
    public GameObject destroyer;
    List<GameObject> pipes=new List<GameObject>();
    int i=0;
    bool pipespawn=true;
    public GameObject pipe;
    float timestart=0;
   public float timeend=2;
    private void Start()
    {
        GameObject temp= Instantiate(pipe,new Vector2(transform.position.x,Random.Range(-4,1)),pipe.transform.rotation);
        pipes.Add(temp);
    }
    private void FixedUpdate()
    {
        if(!jump.hit){

            spawn();
        }
    }

    void spawn(){
        
        if(timestart>=timeend){
            if(pipes[0].transform.position.x>=destroyer.transform.position.x && pipespawn){
                GameObject temp= Instantiate(pipe,new Vector2(transform.position.x,Random.Range(-4,1)),pipe.transform.rotation);
                pipes.Add(temp);
            }else{
                pipespawn=false;
                GameObject pipepop=pipes[0];
                pipes.RemoveAt(0);
                pipepop.transform.position= new Vector2(transform.position.x,Random.Range(-4,1));
                pipes.Add(pipepop);

            }

            timestart=0;
        }

        else{
            timestart+=Time.fixedDeltaTime;
        }

    }
}
