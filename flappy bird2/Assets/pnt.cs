using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class pnt : MonoBehaviour
{
    TextMeshProUGUI mText;
   private void Start()
   {
        mText = GetComponent<TextMeshProUGUI>();
       
   }


    // Update is called once per frame
    void Update()
    {
        mText.text=jump.point.ToString();
        
        
    }
}
