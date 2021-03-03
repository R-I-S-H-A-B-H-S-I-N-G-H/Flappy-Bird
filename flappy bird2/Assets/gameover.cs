using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameover : MonoBehaviour
{
    public GameObject gameoverscreen;
    // public GameObject playagain;
    // Start is called before the first frame update
    private void Start()
    {
        gameoverscreen.SetActive(false);
        // playagain.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if(jump.hit){
            
            gameoverscreen.SetActive(true);
            // playagain.SetActive(true);

        }
        
    }
}
