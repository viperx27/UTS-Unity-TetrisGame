using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Menu : MonoBehaviour
{
    
 





    public void LoadFirstLevel()
    {
        SceneManager.LoadSceneAsync(1);
        DontDestroyOnLoad(gameObject);
       

        Debug.Log("Listner Added");
    }


  

    






    void Start()
    {
       



    }

    void Update()
    {

        
    }


   


}
