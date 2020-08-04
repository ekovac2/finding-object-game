using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slomo : MonoBehaviour
{
    [Range(0f,1f)]
    public float time;
    public bool doNow;

    bool doing;
   
    // Update is called once per frame
    private void Update()
    {
        if (doNow)
        {
            doing = true;
            Time.timeScale = time;
        }
        else {
            if (doing) {
                
                Time.timeScale = 1f;
                doing = false;
            }
        }
        
    }
}
