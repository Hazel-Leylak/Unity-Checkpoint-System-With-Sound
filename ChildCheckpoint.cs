using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildCheckpoint : MonoBehaviour
{

    void OnTriggerEnter(Collider c)
    {
        if (c.tag == "Player")
        {
           gameObject.GetComponentInParent<Checkpoint>().OpenNext(c);            
        }
    }
}
