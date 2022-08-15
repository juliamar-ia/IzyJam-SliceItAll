using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Axe : MonoBehaviour
{
    public Rigidbody rb;

    public float force;

    public float torque = 20f;

    public Vector2 tap;


    void FixedUpdate()
    {

         if(Input.GetMouseButtonDown(0)){

            rb.isKinematic = false;
            tap = Camera.main.ScreenToViewportPoint(Input.mousePosition);
            Debug.Log(tap);
            rb.AddForce(tap * force, ForceMode.Impulse);
            rb.AddTorque(0f,0f, -torque, ForceMode.Impulse);
           
         }
      
    }

    void OnTriggerEnter(Collider coll){
        if(coll.tag == "Table"){
            rb.isKinematic = true;
        }

        else if(coll.tag == "Ground"){
            //GameOver - Chamar Cena de GameOver com opção tap para Iniciar na cena 1 novamente
            Debug.Log("GameOver");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        }

    }


}
