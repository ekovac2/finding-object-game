using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class razvaliSad : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer != 9) {
            Invoke("Allow", 0.2f);
        }
    }
    void Allow() {
        gameObject.layer = 10;
    }

}
