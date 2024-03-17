using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupableObject : MonoBehaviour
{
    public bool beingHit = false;

    private void Start()
    {
        beingHit = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (!beingHit)
        {
            this.gameObject.GetComponent<Renderer>().material.color = Color.white;
        }
        else
        {
            this.gameObject.GetComponent<Renderer>().material.color = Color.blue;
        }
        
    }
}
