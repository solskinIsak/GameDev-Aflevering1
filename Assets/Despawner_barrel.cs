using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Despawner_barrel : MonoBehaviour
{

    public Transform barrelLine, barrelSpawn;
    
    public GameObject barrelLineObject;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("before IF");
        Debug.Log("LOOOOK:"+barrelSpawn.position);
        if (other.gameObject.tag == "barrel")
        {
            barrelLine.transform.position = barrelSpawn.position;
            
            Debug.Log("barrel despawned");
            Debug.Log(barrelLine.transform.position);
            barrelLineObject.GetComponent<Rigidbody>().velocity = Vector3.zero;

        }
        
    }
}
