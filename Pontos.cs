using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pontos : MonoBehaviour
{

    public static Pontos instance;

    public Text scoreTxt;

    private int score = 0;

    private void Awake(){
        instance = this;
    }
    void Start()
    {
        
        scoreTxt.text = score.ToString() + " Pontos";
      
    }

    public void AddPoint()
    {
        score += 1;
        scoreTxt.text = score.ToString() + " Pontos";
    }
}
