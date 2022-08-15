using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOver : MonoBehaviour
{
   public void FixedUpdate(){
        if(Input.GetMouseButtonDown(0)){
            Debug.Log("Play");
            SceneManager.LoadScene(1);
         }
        
        
    }
}
