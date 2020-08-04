using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dodajForce : MonoBehaviour
{
    public bool doNow;
    public Vector3 force;
    public ForceMode forceMode = ForceMode.Impulse;
    private void Update()
    {
        if (doNow)
        {
            GetComponent<Rigidbody>().AddForce(force, forceMode);
            doNow = false;
        }

    }

}
