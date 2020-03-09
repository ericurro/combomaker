using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ComboPractica : MonoBehaviour
{
    //public float starTime;
    public float timeLeft = 0;
    public float MaxTimer= 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
        if(timeLeft>MaxTimer)
        {
            timeLeft = 0;
        }
        else
        {
            timeLeft += Time.deltaTime;
        }


        if (Input.GetKeyDown("space"))
        {
            print("combo");
            Debug.Break();
        }


    }
}
