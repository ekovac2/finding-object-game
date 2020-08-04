using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VrataSkripta : MonoBehaviour
{
    private bool _isInsideTrigger = false;
    public Component bearCollider;
    Animator anim;
    public GameObject medo;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V) && _isInsideTrigger == true)
        {
            anim.SetTrigger("OpenDoor");

            
           bearCollider.GetComponent<SphereCollider>().enabled = true;
          
        }
        
    }


    void OnTriggerEnter(Collider other)
    {
           _isInsideTrigger = true;
   
    }

    void OnTriggerExit(Collider other)
    {
        _isInsideTrigger = false;
        anim.enabled = true;
    }

    void pauseAnimationEvent()
    {
        
            anim.enabled = false;
        
    }
}
