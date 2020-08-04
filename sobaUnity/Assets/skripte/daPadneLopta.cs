using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class daPadneLopta : MonoBehaviour
{
    private bool _isInsideTrigger = false;

    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && _isInsideTrigger == true)
        {
            anim.SetTrigger("PadneLopta");
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
