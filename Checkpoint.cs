using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public GameObject[] Checkpoints;
    public GameObject FirstParkingBound;
    int count;
    AudioSource checkp;

    private void Start()
    {
        checkp = GetComponent<AudioSource>();
        checkp.Stop();
    }


    public void OpenNext(Collider c)
    {
        
        Checkpoints[count].SetActive(false);
        checkp.Play();
        if (count < Checkpoints.Length-1)
        {
            count++;
            Checkpoints[count].SetActive(true);            
        }
        
        else if (count == Checkpoints.Length-1)
        {
            FirstParkingBound.SetActive(true);
        } 
    }
}
