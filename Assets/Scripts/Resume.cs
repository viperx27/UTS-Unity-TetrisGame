using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resume : MonoBehaviour
{


   // bool Pause = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame






    void Update()
    {

        if (Input.GetMouseButton(0))
        {
          if (Time.timeScale ==0)
            {
                Time.timeScale = 1;
            }
          else if (Time.timeScale != 0)
            {
                Time.timeScale = 1;
            }


           

          //  Pause = true;
        }
        else
        {
         //   Pause = false;
        }


    }





}










