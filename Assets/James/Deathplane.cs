using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deathplane : MonoBehaviour
{
    public Transform destination;
    public GameObject playerObject;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerObject.SetActive(false);
            playerObject.transform.position = destination.transform.position;
            playerObject.SetActive(true);
            playerObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
        }
    }


}
