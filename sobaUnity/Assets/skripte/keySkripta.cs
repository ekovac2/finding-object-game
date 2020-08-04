using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keySkripta : MonoBehaviour
{
    private bool _isInsideTrigger = false;
    public Component doorCollider;
    public GameObject key;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerStay()
    {
        if (_isInsideTrigger)
        {
            if (Input.GetKey(KeyCode.K))
                doorCollider.GetComponent<SphereCollider>().enabled = true;

            if (Input.GetKey(KeyCode.K))
                key.SetActive(false);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        _isInsideTrigger = true;

    }
    void OnTriggerExit(Collider other)
    {
        _isInsideTrigger = false;
    }
}
