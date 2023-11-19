using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerCapsule : MonoBehaviour
{
    public GameObject light;
    private void OnTriggerEnter(Collider other)
    {
        print("triggered");
        light.GetComponent<Light>().enabled = false;
    }
    private void OnTriggerExit(Collider other)
    {
        light.GetComponent<Light>().enabled = true;
    }

}
