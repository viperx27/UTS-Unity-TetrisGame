using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Scene1 : MonoBehaviour
{







    public void LoadFirstLevel()
    {
        SceneManager.LoadSceneAsync(0);
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
