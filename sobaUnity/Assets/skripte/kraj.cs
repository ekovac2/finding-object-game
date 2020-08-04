using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kraj : MonoBehaviour
{
    public GameObject key;
    void OnTriggerEnter()
    {
       GameObject.Find("FPSController").SendMessage("Finish");
    }
}
