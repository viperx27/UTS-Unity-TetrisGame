using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{


    bool Pause = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame






    void Update()
    {


        if (Input.GetMouseButton(0))
        {
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;

                Pause = true;

            }

            else if (Input.GetMouseButton(1))
            {
                if(Time.timeScale == 0)
                {
                    Time.timeScale = 1;
                    Pause = false;
                }
            }
        }


     
  
       }
    }
   
    




