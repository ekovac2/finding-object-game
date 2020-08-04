using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breakGlass : MonoBehaviour
{

    public Transform brokenObject;
    public float magnitudeCol, radius, power, upwards;
    // Start is called before the first frame update
    void OnCollisionEnter(Collision collision)
    {
        transform.parent.Find("razbijenoStaklo").gameObject.SetActive(true);
        gameObject.SetActive(false);
    }
}


