using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LogController : MonoBehaviour
{
    
    public GameObject SlicedLog;

    private Rigidbody rb;

    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    
    void OnTriggerEnter(Collider col){

        if(col.tag == "Player"){

            
            // Vector2 direction = (col.transform.position - transform.position).normalized;

            // Quaternion rotation = Quaternion.LookRotation(direction);
            // Quaternion myQuaternion = Quaternion.Euler(0, 90, 0);
            GameObject slicedLog = Instantiate(SlicedLog, transform.position, Quaternion.identity);
            Pontos.instance.AddPoint();
            
            Destroy(slicedLog, 0.5f);
            Destroy(gameObject);
            
        }

    }
}
