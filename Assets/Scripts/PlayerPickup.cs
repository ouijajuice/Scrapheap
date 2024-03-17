using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class PlayerPickup : MonoBehaviour
{
    public string pickupableTag;

    public float holdDistance;

    public Transform holdPos;

    private bool hitObjectKnown;
    void Update()
    {
        RaycastHit hit;

        bool hitSomething = Physics.Raycast(transform.position, transform.forward, out hit, holdDistance);

        if (hitSomething)
        {
            GameObject hitObject = hit.transform.gameObject;

            PickupableObject hitScript = hitObject.GetComponent<PickupableObject>();

            hitScript.beingHit = true;

            Renderer hitRenderer = hitObject.GetComponent<Renderer>();

            if (hitObject.CompareTag(pickupableTag))
            {
                hitRenderer.material.color = Color.blue;
            }


            if (Input.GetButton("Fire1"))
            {

                if (hitSomething)
                {

                    hitObjectKnown = true;
                    if (hitObjectKnown)
                    {
                        if (hitObject.CompareTag(pickupableTag))
                        {

                            hitObject.transform.position = holdPos.position;
                            hitObject.transform.rotation = holdPos.rotation;
                            Rigidbody hitRb = hitObject.GetComponent<Rigidbody>();
                            hitObject.transform.parent = holdPos.transform;
                            hitRb.isKinematic = true;
                            hitRb.velocity = Vector3.zero;
                            hitRb.angularVelocity = Vector3.zero;
                        }
                    }
                    //Debug.Log(hitObject.transform.position.y);
                }
            }
            else if (!Input.GetButton("Fire1"))
            {
                if (hitSomething)
                {
                    if (hitObject.CompareTag(pickupableTag))
                    {
                        hitScript.beingHit = false;
                        hitObject.GetComponent<Rigidbody>().isKinematic = false;
                        hitObject.transform.parent = null;
                        
                    }
                }
            }
            //hitRenderer.material.color = Color.white;
        }
        
    }
}
