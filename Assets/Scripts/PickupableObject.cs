using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupableObject : MonoBehaviour
{
    public bool beingHit = true;

    // Update is called once per frame
    void Update()
    {
        if (!beingHit)
        {
            this.gameObject.GetComponent<Renderer>().material.color = Color.white;
        }
        
    }
}
