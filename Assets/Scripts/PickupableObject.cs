using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupableObject : MonoBehaviour
{
    public bool beingHit;

    private void Start()
    {
        //beingHit = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (beingHit)
        {
            this.gameObject.GetComponent<Renderer>().material.color = new Color(0.22f, 1f, 1f);
        }
        else if (!beingHit)
        {
            this.gameObject.GetComponent<Renderer>().material.color = Color.white;
        }
        beingHit = false;
        
    }
}
