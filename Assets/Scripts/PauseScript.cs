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
        
    }
       
    public void pausegame()
    {
        Pause = !Pause;
        if (Pause)
        {
            Time.timeScale = 0;
        }
        else if (!Pause)
        {
            Time.timeScale = 1;
        }
    }




    }


    
    
   
    




